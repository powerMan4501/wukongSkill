using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace System.Net;

internal class AutoWebProxyScriptWrapper
{
	private const string c_appDomainName = "WebProxyScript";

	private int appDomainIndex;

	private AppDomain scriptDomain;

	private IWebProxyScript site;

	private static volatile AppDomain s_ExcessAppDomain;

	private static Hashtable s_AppDomains;

	private static bool s_CleanedUp;

	private static int s_NextAppDomainIndex;

	private static AppDomainSetup s_AppDomainInfo;

	private static volatile Type s_ProxyScriptHelperType;

	private static volatile Exception s_ProxyScriptHelperLoadError;

	private static object s_ProxyScriptHelperLock;

	private string scriptText;

	private byte[] scriptBytes;

	private DateTime lastModified;

	internal string ScriptBody => scriptText;

	internal byte[] Buffer
	{
		get
		{
			return scriptBytes;
		}
		set
		{
			scriptBytes = value;
		}
	}

	internal DateTime LastModified
	{
		get
		{
			return lastModified;
		}
		set
		{
			lastModified = value;
		}
	}

	static AutoWebProxyScriptWrapper()
	{
		s_AppDomains = new Hashtable();
		s_ProxyScriptHelperLock = new object();
		AppDomain.CurrentDomain.DomainUnload += OnDomainUnload;
	}

	[ReflectionPermission(SecurityAction.Assert, Flags = ReflectionPermissionFlag.MemberAccess)]
	[ReflectionPermission(SecurityAction.Assert, Flags = ReflectionPermissionFlag.TypeInformation)]
	internal AutoWebProxyScriptWrapper()
	{
		Exception ex = null;
		if (s_ProxyScriptHelperLoadError == null && s_ProxyScriptHelperType == null)
		{
			lock (s_ProxyScriptHelperLock)
			{
				if (s_ProxyScriptHelperLoadError == null && s_ProxyScriptHelperType == null)
				{
					try
					{
						s_ProxyScriptHelperType = Type.GetType("System.Net.VsaWebProxyScript, Microsoft.JScript, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
					}
					catch (Exception ex2)
					{
						ex = ex2;
					}
					if (s_ProxyScriptHelperType == null)
					{
						s_ProxyScriptHelperLoadError = ((ex == null) ? new InternalException() : ex);
					}
				}
			}
		}
		if (s_ProxyScriptHelperLoadError != null)
		{
			throw new TypeLoadException(SR.GetString("net_cannot_load_proxy_helper"), (s_ProxyScriptHelperLoadError is InternalException) ? null : s_ProxyScriptHelperLoadError);
		}
		CreateAppDomain();
		ex = null;
		try
		{
			ObjectHandle objectHandle = Activator.CreateInstance(scriptDomain, s_ProxyScriptHelperType.Assembly.FullName, s_ProxyScriptHelperType.FullName, ignoreCase: false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.CreateInstance, null, null, null, null, null);
			if (objectHandle != null)
			{
				site = (IWebProxyScript)objectHandle.Unwrap();
			}
		}
		catch (Exception ex3)
		{
			ex = ex3;
		}
		if (site != null)
		{
			return;
		}
		lock (s_ProxyScriptHelperLock)
		{
			if (s_ProxyScriptHelperLoadError == null)
			{
				s_ProxyScriptHelperLoadError = ((ex == null) ? new InternalException() : ex);
			}
		}
		throw new TypeLoadException(SR.GetString("net_cannot_load_proxy_helper"), (s_ProxyScriptHelperLoadError is InternalException) ? null : s_ProxyScriptHelperLoadError);
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlAppDomain)]
	private void CreateAppDomain()
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Monitor.Enter(s_AppDomains.SyncRoot, ref lockTaken);
			if (s_CleanedUp)
			{
				throw new InvalidOperationException(SR.GetString("net_cant_perform_during_shutdown"));
			}
			if (s_AppDomainInfo == null)
			{
				s_AppDomainInfo = new AppDomainSetup();
				s_AppDomainInfo.DisallowBindingRedirects = true;
				s_AppDomainInfo.DisallowCodeDownload = true;
				NamedPermissionSet namedPermissionSet = new NamedPermissionSet("__WebProxySandbox", PermissionState.None);
				namedPermissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
				ApplicationTrust applicationTrust = new ApplicationTrust();
				applicationTrust.DefaultGrantSet = new PolicyStatement(namedPermissionSet);
				s_AppDomainInfo.ApplicationTrust = applicationTrust;
				s_AppDomainInfo.ApplicationBase = Environment.SystemDirectory;
			}
			AppDomain appDomain = s_ExcessAppDomain;
			if (appDomain != null)
			{
				TimerThread.GetOrCreateQueue(0).CreateTimer(CloseAppDomainCallback, appDomain);
				throw new InvalidOperationException(SR.GetString("net_cant_create_environment"));
			}
			appDomainIndex = s_NextAppDomainIndex++;
			try
			{
			}
			finally
			{
				PermissionSet permissionSet = new PermissionSet(PermissionState.None);
				permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
				s_ExcessAppDomain = AppDomain.CreateDomain("WebProxyScript", (Evidence)null, s_AppDomainInfo, permissionSet, (StrongName[])null);
				try
				{
					s_AppDomains.Add(appDomainIndex, s_ExcessAppDomain);
					scriptDomain = s_ExcessAppDomain;
				}
				finally
				{
					if (scriptDomain == s_ExcessAppDomain)
					{
						s_ExcessAppDomain = null;
					}
					else
					{
						try
						{
							s_AppDomains.Remove(appDomainIndex);
						}
						finally
						{
							TimerThread.GetOrCreateQueue(0).CreateTimer(CloseAppDomainCallback, s_ExcessAppDomain);
						}
					}
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(s_AppDomains.SyncRoot);
			}
		}
	}

	internal void Close()
	{
		site.Close();
		TimerThread.GetOrCreateQueue(0).CreateTimer(CloseAppDomainCallback, appDomainIndex);
		GC.SuppressFinalize(this);
	}

	~AutoWebProxyScriptWrapper()
	{
		if (!NclUtilities.HasShutdownStarted && scriptDomain != null)
		{
			TimerThread.GetOrCreateQueue(0).CreateTimer(CloseAppDomainCallback, appDomainIndex);
		}
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlAppDomain)]
	private static void CloseAppDomainCallback(TimerThread.Timer timer, int timeNoticed, object context)
	{
		try
		{
			if (!(context is AppDomain appDomain))
			{
				CloseAppDomain((int)context);
			}
			else if (appDomain == s_ExcessAppDomain)
			{
				try
				{
					AppDomain.Unload(appDomain);
				}
				catch (AppDomainUnloadedException)
				{
				}
				s_ExcessAppDomain = null;
			}
		}
		catch (Exception exception)
		{
			if (NclUtilities.IsFatal(exception))
			{
				throw;
			}
		}
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlAppDomain)]
	private static void CloseAppDomain(int index)
	{
		bool lockTaken = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		AppDomain domain;
		try
		{
			Monitor.Enter(s_AppDomains.SyncRoot, ref lockTaken);
			if (s_CleanedUp)
			{
				return;
			}
			domain = (AppDomain)s_AppDomains[index];
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(s_AppDomains.SyncRoot);
				lockTaken = false;
			}
		}
		try
		{
			AppDomain.Unload(domain);
		}
		catch (AppDomainUnloadedException)
		{
		}
		finally
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				Monitor.Enter(s_AppDomains.SyncRoot, ref lockTaken);
				s_AppDomains.Remove(index);
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(s_AppDomains.SyncRoot);
				}
			}
		}
	}

	[ReliabilityContract(Consistency.MayCorruptProcess, Cer.MayFail)]
	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlAppDomain)]
	private static void OnDomainUnload(object sender, EventArgs e)
	{
		lock (s_AppDomains.SyncRoot)
		{
			if (s_CleanedUp)
			{
				return;
			}
			s_CleanedUp = true;
			foreach (AppDomain value in s_AppDomains.Values)
			{
				try
				{
					AppDomain.Unload(value);
				}
				catch
				{
				}
			}
			s_AppDomains.Clear();
			AppDomain appDomain = s_ExcessAppDomain;
			if (appDomain != null)
			{
				try
				{
					AppDomain.Unload(appDomain);
				}
				catch
				{
				}
				s_ExcessAppDomain = null;
			}
		}
	}

	internal string FindProxyForURL(string url, string host)
	{
		return site.Run(url, host);
	}

	internal bool Compile(Uri engineScriptLocation, string scriptBody, byte[] buffer)
	{
		if (site.Load(engineScriptLocation, scriptBody, typeof(WebProxyScriptHelper)))
		{
			scriptText = scriptBody;
			scriptBytes = buffer;
			return true;
		}
		return false;
	}
}
