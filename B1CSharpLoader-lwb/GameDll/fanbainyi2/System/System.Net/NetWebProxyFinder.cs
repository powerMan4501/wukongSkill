using System.Collections.Generic;
using System.IO;
using System.Net.Cache;
using System.Net.Configuration;
using System.Security;
using System.Threading;

namespace System.Net;

internal sealed class NetWebProxyFinder : BaseWebProxyFinder
{
	private static readonly char[] splitChars = new char[1] { ';' };

	private static TimerThread.Queue timerQueue;

	private static readonly TimerThread.Callback timerCallback = RequestTimeoutCallback;

	private static readonly WaitCallback abortWrapper = AbortWrapper;

	private RequestCache backupCache;

	private AutoWebProxyScriptWrapper scriptInstance;

	private Uri engineScriptLocation;

	private Uri scriptLocation;

	private bool scriptDetectionFailed;

	private object lockObject;

	private volatile WebRequest request;

	private volatile bool aborted;

	private const int MaximumProxyStringLength = 2058;

	public NetWebProxyFinder(AutoWebProxyScriptEngine engine)
		: base(engine)
	{
		backupCache = new SingleItemRequestCache(RequestCacheManager.IsCachingEnabled);
		lockObject = new object();
	}

	public override bool GetProxies(Uri destination, out IList<string> proxyList)
	{
		try
		{
			proxyList = null;
			EnsureEngineAvailable();
			if (base.State != AutoWebProxyState.Completed)
			{
				return false;
			}
			bool result = false;
			try
			{
				string scriptReturn = scriptInstance.FindProxyForURL(destination.ToString(), destination.Host);
				proxyList = ParseScriptResult(scriptReturn);
				result = true;
			}
			catch (Exception ex)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_script_execution_error", ex));
				}
			}
			return result;
		}
		finally
		{
			aborted = false;
		}
	}

	public override void Abort()
	{
		lock (lockObject)
		{
			aborted = true;
			if (request != null)
			{
				ThreadPool.UnsafeQueueUserWorkItem(abortWrapper, request);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && scriptInstance != null)
		{
			scriptInstance.Close();
		}
	}

	private void EnsureEngineAvailable()
	{
		if (base.State == AutoWebProxyState.Uninitialized || engineScriptLocation == null)
		{
			if (base.Engine.AutomaticallyDetectSettings)
			{
				DetectScriptLocation();
				if (scriptLocation != null)
				{
					if (scriptLocation.Equals(engineScriptLocation))
					{
						base.State = AutoWebProxyState.Completed;
						return;
					}
					AutoWebProxyState autoWebProxyState = DownloadAndCompile(scriptLocation);
					if (autoWebProxyState == AutoWebProxyState.Completed)
					{
						base.State = AutoWebProxyState.Completed;
						engineScriptLocation = scriptLocation;
						return;
					}
				}
			}
			if (base.Engine.AutomaticConfigurationScript != null && !aborted)
			{
				if (base.Engine.AutomaticConfigurationScript.Equals(engineScriptLocation))
				{
					base.State = AutoWebProxyState.Completed;
					return;
				}
				base.State = DownloadAndCompile(base.Engine.AutomaticConfigurationScript);
				if (base.State == AutoWebProxyState.Completed)
				{
					engineScriptLocation = base.Engine.AutomaticConfigurationScript;
					return;
				}
			}
		}
		else
		{
			base.State = DownloadAndCompile(engineScriptLocation);
			if (base.State == AutoWebProxyState.Completed)
			{
				return;
			}
			if (!engineScriptLocation.Equals(base.Engine.AutomaticConfigurationScript) && !aborted)
			{
				base.State = DownloadAndCompile(base.Engine.AutomaticConfigurationScript);
				if (base.State == AutoWebProxyState.Completed)
				{
					engineScriptLocation = base.Engine.AutomaticConfigurationScript;
					return;
				}
			}
		}
		base.State = AutoWebProxyState.DiscoveryFailure;
		if (scriptInstance != null)
		{
			scriptInstance.Close();
			scriptInstance = null;
		}
		engineScriptLocation = null;
	}

	private AutoWebProxyState DownloadAndCompile(Uri location)
	{
		AutoWebProxyState autoWebProxyState = AutoWebProxyState.DownloadFailure;
		WebResponse webResponse = null;
		TimerThread.Timer timer = null;
		AutoWebProxyScriptWrapper autoWebProxyScriptWrapper = null;
		ExceptionHelper.WebPermissionUnrestricted.Assert();
		try
		{
			lock (lockObject)
			{
				if (aborted)
				{
					throw new WebException(NetRes.GetWebStatusString("net_requestaborted", WebExceptionStatus.RequestCanceled), WebExceptionStatus.RequestCanceled);
				}
				request = WebRequest.Create(location);
			}
			request.Timeout = -1;
			request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.Default);
			request.ConnectionGroupName = "__WebProxyScript";
			if (request.CacheProtocol != null)
			{
				request.CacheProtocol = new RequestCacheProtocol(backupCache, request.CacheProtocol.Validator);
			}
			if (request is HttpWebRequest httpWebRequest)
			{
				httpWebRequest.Accept = "*/*";
				httpWebRequest.UserAgent = GetType().FullName + "/" + Environment.Version;
				httpWebRequest.KeepAlive = false;
				httpWebRequest.Pipelined = false;
				httpWebRequest.InternalConnectionGroup = true;
			}
			else if (request is FtpWebRequest ftpWebRequest)
			{
				ftpWebRequest.KeepAlive = false;
			}
			request.Proxy = null;
			request.Credentials = base.Engine.Credentials;
			if (timerQueue == null)
			{
				timerQueue = TimerThread.GetOrCreateQueue(SettingsSectionInternal.Section.DownloadTimeout);
			}
			timer = timerQueue.CreateTimer(timerCallback, request);
			webResponse = request.GetResponse();
			DateTime dateTime = DateTime.MinValue;
			if (webResponse is HttpWebResponse httpWebResponse)
			{
				dateTime = httpWebResponse.LastModified;
			}
			else if (webResponse is FtpWebResponse ftpWebResponse)
			{
				dateTime = ftpWebResponse.LastModified;
			}
			if (scriptInstance != null && dateTime != DateTime.MinValue && scriptInstance.LastModified == dateTime)
			{
				autoWebProxyScriptWrapper = scriptInstance;
				autoWebProxyState = AutoWebProxyState.Completed;
			}
			else
			{
				string text = null;
				byte[] array = null;
				using (Stream stream = webResponse.GetResponseStream())
				{
					if (stream is SingleItemRequestCache.ReadOnlyStream readOnlyStream)
					{
						array = readOnlyStream.Buffer;
					}
					if (scriptInstance != null && array != null && array == scriptInstance.Buffer)
					{
						scriptInstance.LastModified = dateTime;
						autoWebProxyScriptWrapper = scriptInstance;
						autoWebProxyState = AutoWebProxyState.Completed;
					}
					else
					{
						using StreamReader streamReader = new StreamReader(stream);
						text = streamReader.ReadToEnd();
					}
				}
				WebResponse webResponse2 = webResponse;
				webResponse = null;
				webResponse2.Close();
				timer.Cancel();
				timer = null;
				if (autoWebProxyState != AutoWebProxyState.Completed)
				{
					if (scriptInstance != null && text == scriptInstance.ScriptBody)
					{
						scriptInstance.LastModified = dateTime;
						if (array != null)
						{
							scriptInstance.Buffer = array;
						}
						autoWebProxyScriptWrapper = scriptInstance;
						autoWebProxyState = AutoWebProxyState.Completed;
					}
					else
					{
						autoWebProxyScriptWrapper = new AutoWebProxyScriptWrapper();
						autoWebProxyScriptWrapper.LastModified = dateTime;
						autoWebProxyState = ((!autoWebProxyScriptWrapper.Compile(location, text, array)) ? AutoWebProxyState.CompilationFailure : AutoWebProxyState.Completed);
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_script_download_compile_error", ex));
			}
		}
		finally
		{
			timer?.Cancel();
			try
			{
				webResponse?.Close();
			}
			finally
			{
				CodeAccessPermission.RevertAssert();
				request = null;
			}
		}
		if (autoWebProxyState == AutoWebProxyState.Completed && scriptInstance != autoWebProxyScriptWrapper)
		{
			if (scriptInstance != null)
			{
				scriptInstance.Close();
			}
			scriptInstance = autoWebProxyScriptWrapper;
		}
		return autoWebProxyState;
	}

	private static IList<string> ParseScriptResult(string scriptReturn)
	{
		IList<string> list = new List<string>();
		if (scriptReturn == null)
		{
			return list;
		}
		string[] array = scriptReturn.Split(splitChars);
		string[] array2 = array;
		foreach (string text in array2)
		{
			string text2 = text.Trim(' ');
			string text3;
			if (!text2.StartsWith("PROXY ", StringComparison.OrdinalIgnoreCase))
			{
				if (string.Compare("DIRECT", text2, StringComparison.OrdinalIgnoreCase) != 0)
				{
					continue;
				}
				text3 = null;
			}
			else
			{
				text3 = text2.Substring(6).TrimStart(' ');
				Uri result = null;
				if (!Uri.TryCreate("http://" + text3, UriKind.Absolute, out result) || result.UserInfo.Length > 0 || result.HostNameType == UriHostNameType.Basic || result.AbsolutePath.Length != 1 || text3[text3.Length - 1] == '/' || text3[text3.Length - 1] == '#' || text3[text3.Length - 1] == '?')
				{
					continue;
				}
			}
			list.Add(text3);
		}
		return list;
	}

	private void DetectScriptLocation()
	{
		if (!scriptDetectionFailed && !(scriptLocation != null))
		{
			scriptLocation = SafeDetectAutoProxyUrl(UnsafeNclNativeMethods.WinHttp.AutoDetectType.Dhcp);
			if (scriptLocation == null)
			{
				scriptLocation = SafeDetectAutoProxyUrl(UnsafeNclNativeMethods.WinHttp.AutoDetectType.DnsA);
			}
			if (scriptLocation == null)
			{
				scriptDetectionFailed = true;
			}
		}
	}

	private unsafe static Uri SafeDetectAutoProxyUrl(UnsafeNclNativeMethods.WinHttp.AutoDetectType discoveryMethod)
	{
		Uri result = null;
		string text = null;
		if (!UnsafeNclNativeMethods.WinHttp.WinHttpDetectAutoProxyConfigUrl(discoveryMethod, out var autoConfigUrl))
		{
			autoConfigUrl?.SetHandleAsInvalid();
		}
		else
		{
			text = new string((char*)(void*)autoConfigUrl.DangerousGetHandle());
			autoConfigUrl.Close();
		}
		if (text != null)
		{
			if (!Uri.TryCreate(text, UriKind.Absolute, out result) && Logging.On)
			{
				Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_autodetect_script_location_parse_error", ValidationHelper.ToString(text)));
			}
		}
		else if (Logging.On)
		{
			Logging.PrintWarning(Logging.Web, SR.GetString("net_log_proxy_autodetect_failed"));
		}
		return result;
	}

	private static void RequestTimeoutCallback(TimerThread.Timer timer, int timeNoticed, object context)
	{
		ThreadPool.UnsafeQueueUserWorkItem(abortWrapper, context);
	}

	private static void AbortWrapper(object context)
	{
		if (context != null)
		{
			((WebRequest)context).Abort();
		}
	}
}
