using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.IO;
using System.Net.Cache;
using System.Net.Configuration;
using System.Net.Security;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

[Serializable]
[global::__DynamicallyInvokable]
public abstract class WebRequest : MarshalByRefObject, ISerializable
{
	internal class DesignerWebRequestCreate : IWebRequestCreate
	{
		public WebRequest Create(Uri uri)
		{
			return WebRequest.Create(uri);
		}
	}

	internal class WebProxyWrapperOpaque : IAutoWebProxy, IWebProxy
	{
		protected readonly WebProxy webProxy;

		public ICredentials Credentials
		{
			get
			{
				return webProxy.Credentials;
			}
			set
			{
				webProxy.Credentials = value;
			}
		}

		internal WebProxyWrapperOpaque(WebProxy webProxy)
		{
			this.webProxy = webProxy;
		}

		public Uri GetProxy(Uri destination)
		{
			return webProxy.GetProxy(destination);
		}

		public bool IsBypassed(Uri host)
		{
			return webProxy.IsBypassed(host);
		}

		public ProxyChain GetProxies(Uri destination)
		{
			return ((IAutoWebProxy)webProxy).GetProxies(destination);
		}
	}

	internal class WebProxyWrapper : WebProxyWrapperOpaque
	{
		internal WebProxy WebProxy => webProxy;

		internal WebProxyWrapper(WebProxy webProxy)
			: base(webProxy)
		{
		}
	}

	private delegate void DelEtwFireBeginWRGet(object id, string uri, bool success, bool synchronous);

	private delegate void DelEtwFireEndWRGet(object id, bool success, bool synchronous);

	private delegate void DelEtwFireEndWRespGet(object id, bool success, bool synchronous, int statusCode);

	internal const int DefaultTimeout = 100000;

	private static volatile ArrayList s_PrefixList;

	private static object s_InternalSyncObject;

	private static TimerThread.Queue s_DefaultTimerQueue = TimerThread.CreateQueue(100000);

	private AuthenticationLevel m_AuthenticationLevel;

	private TokenImpersonationLevel m_ImpersonationLevel;

	private RequestCachePolicy m_CachePolicy;

	private RequestCacheProtocol m_CacheProtocol;

	private RequestCacheBinding m_CacheBinding;

	private static DesignerWebRequestCreate webRequestCreate = new DesignerWebRequestCreate();

	private static volatile IWebProxy s_DefaultWebProxy;

	private static volatile bool s_DefaultWebProxyInitialized;

	private static DelEtwFireBeginWRGet s_EtwFireBeginGetResponse;

	private static DelEtwFireEndWRespGet s_EtwFireEndGetResponse;

	private static DelEtwFireBeginWRGet s_EtwFireBeginGetRequestStream;

	private static DelEtwFireEndWRGet s_EtwFireEndGetRequestStream;

	private static volatile bool s_TriedGetEtwDelegates;

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public virtual IWebRequestCreate CreatorInstance => webRequestCreate;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	internal static TimerThread.Queue DefaultTimerQueue => s_DefaultTimerQueue;

	internal static ArrayList PrefixList
	{
		get
		{
			if (s_PrefixList == null)
			{
				lock (InternalSyncObject)
				{
					if (s_PrefixList == null)
					{
						s_PrefixList = WebRequestModulesSectionInternal.GetSection().WebRequestModules;
					}
				}
			}
			return s_PrefixList;
		}
		set
		{
			s_PrefixList = value;
		}
	}

	public static RequestCachePolicy DefaultCachePolicy
	{
		get
		{
			return RequestCacheManager.GetBinding(string.Empty).Policy;
		}
		set
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			RequestCacheBinding binding = RequestCacheManager.GetBinding(string.Empty);
			RequestCacheManager.SetBinding(string.Empty, new RequestCacheBinding(binding.Cache, binding.Validator, value));
		}
	}

	public virtual RequestCachePolicy CachePolicy
	{
		get
		{
			return m_CachePolicy;
		}
		set
		{
			InternalSetCachePolicy(value);
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string Method
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		[global::__DynamicallyInvokable]
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual Uri RequestUri
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	public virtual string ConnectionGroupName
	{
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual WebHeaderCollection Headers
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		[global::__DynamicallyInvokable]
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	public virtual long ContentLength
	{
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string ContentType
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		[global::__DynamicallyInvokable]
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual ICredentials Credentials
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		[global::__DynamicallyInvokable]
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual bool UseDefaultCredentials
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		[global::__DynamicallyInvokable]
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual IWebProxy Proxy
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		[global::__DynamicallyInvokable]
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	public virtual bool PreAuthenticate
	{
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	public virtual int Timeout
	{
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	internal RequestCacheProtocol CacheProtocol
	{
		get
		{
			return m_CacheProtocol;
		}
		set
		{
			m_CacheProtocol = value;
		}
	}

	public AuthenticationLevel AuthenticationLevel
	{
		get
		{
			return m_AuthenticationLevel;
		}
		set
		{
			m_AuthenticationLevel = value;
		}
	}

	public TokenImpersonationLevel ImpersonationLevel
	{
		get
		{
			return m_ImpersonationLevel;
		}
		set
		{
			m_ImpersonationLevel = value;
		}
	}

	internal static IWebProxy InternalDefaultWebProxy
	{
		get
		{
			if (!s_DefaultWebProxyInitialized)
			{
				lock (InternalSyncObject)
				{
					if (!s_DefaultWebProxyInitialized)
					{
						DefaultProxySectionInternal section = DefaultProxySectionInternal.GetSection();
						if (section != null)
						{
							s_DefaultWebProxy = section.WebProxy;
						}
						s_DefaultWebProxyInitialized = true;
					}
				}
			}
			return s_DefaultWebProxy;
		}
		set
		{
			if (!s_DefaultWebProxyInitialized)
			{
				lock (InternalSyncObject)
				{
					s_DefaultWebProxy = value;
					s_DefaultWebProxyInitialized = true;
					return;
				}
			}
			s_DefaultWebProxy = value;
		}
	}

	[global::__DynamicallyInvokable]
	public static IWebProxy DefaultWebProxy
	{
		[global::__DynamicallyInvokable]
		get
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			return InternalDefaultWebProxy;
		}
		[global::__DynamicallyInvokable]
		set
		{
			ExceptionHelper.WebPermissionUnrestricted.Demand();
			InternalDefaultWebProxy = value;
		}
	}

	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void RegisterPortableWebRequestCreator(IWebRequestCreate creator)
	{
	}

	private static WebRequest Create(Uri requestUri, bool useUriBase)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.Web, "WebRequest", "Create", requestUri.ToString());
		}
		WebRequestPrefixElement webRequestPrefixElement = null;
		bool flag = false;
		string text = (useUriBase ? (requestUri.Scheme + ":") : requestUri.AbsoluteUri);
		int length = text.Length;
		ArrayList prefixList = PrefixList;
		for (int i = 0; i < prefixList.Count; i++)
		{
			webRequestPrefixElement = (WebRequestPrefixElement)prefixList[i];
			if (length >= webRequestPrefixElement.Prefix.Length && string.Compare(webRequestPrefixElement.Prefix, 0, text, 0, webRequestPrefixElement.Prefix.Length, StringComparison.OrdinalIgnoreCase) == 0)
			{
				flag = true;
				break;
			}
		}
		WebRequest webRequest = null;
		if (flag)
		{
			webRequest = webRequestPrefixElement.Creator.Create(requestUri);
			if (Logging.On)
			{
				Logging.Exit(Logging.Web, "WebRequest", "Create", webRequest);
			}
			return webRequest;
		}
		if (Logging.On)
		{
			Logging.Exit(Logging.Web, "WebRequest", "Create", null);
		}
		throw new NotSupportedException(SR.GetString("net_unknown_prefix"));
	}

	[global::__DynamicallyInvokable]
	public static WebRequest Create(string requestUriString)
	{
		if (requestUriString == null)
		{
			throw new ArgumentNullException("requestUriString");
		}
		return Create(new Uri(requestUriString), useUriBase: false);
	}

	[global::__DynamicallyInvokable]
	public static WebRequest Create(Uri requestUri)
	{
		if (requestUri == null)
		{
			throw new ArgumentNullException("requestUri");
		}
		return Create(requestUri, useUriBase: false);
	}

	public static WebRequest CreateDefault(Uri requestUri)
	{
		if (requestUri == null)
		{
			throw new ArgumentNullException("requestUri");
		}
		return Create(requestUri, useUriBase: true);
	}

	[global::__DynamicallyInvokable]
	public static HttpWebRequest CreateHttp(string requestUriString)
	{
		if (requestUriString == null)
		{
			throw new ArgumentNullException("requestUriString");
		}
		return CreateHttp(new Uri(requestUriString));
	}

	[global::__DynamicallyInvokable]
	public static HttpWebRequest CreateHttp(Uri requestUri)
	{
		if (requestUri == null)
		{
			throw new ArgumentNullException("requestUri");
		}
		if (requestUri.Scheme != Uri.UriSchemeHttp && requestUri.Scheme != Uri.UriSchemeHttps)
		{
			throw new NotSupportedException(SR.GetString("net_unknown_prefix"));
		}
		return (HttpWebRequest)CreateDefault(requestUri);
	}

	[global::__DynamicallyInvokable]
	public static bool RegisterPrefix(string prefix, IWebRequestCreate creator)
	{
		bool flag = false;
		if (prefix == null)
		{
			throw new ArgumentNullException("prefix");
		}
		if (creator == null)
		{
			throw new ArgumentNullException("creator");
		}
		ExceptionHelper.WebPermissionUnrestricted.Demand();
		lock (InternalSyncObject)
		{
			ArrayList arrayList = (ArrayList)PrefixList.Clone();
			if (Uri.TryCreate(prefix, UriKind.Absolute, out var result))
			{
				string text = result.AbsoluteUri;
				if (!prefix.EndsWith("/", StringComparison.Ordinal) && result.GetComponents(UriComponents.PathAndQuery | UriComponents.Fragment, UriFormat.UriEscaped).Equals("/"))
				{
					text = text.Substring(0, text.Length - 1);
				}
				prefix = text;
			}
			int i;
			for (i = 0; i < arrayList.Count; i++)
			{
				WebRequestPrefixElement webRequestPrefixElement = (WebRequestPrefixElement)arrayList[i];
				if (prefix.Length > webRequestPrefixElement.Prefix.Length)
				{
					break;
				}
				if (prefix.Length == webRequestPrefixElement.Prefix.Length && string.Compare(webRequestPrefixElement.Prefix, prefix, StringComparison.OrdinalIgnoreCase) == 0)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				arrayList.Insert(i, new WebRequestPrefixElement(prefix, creator));
				PrefixList = arrayList;
			}
		}
		return !flag;
	}

	[global::__DynamicallyInvokable]
	protected WebRequest()
	{
		m_ImpersonationLevel = TokenImpersonationLevel.Delegation;
		m_AuthenticationLevel = AuthenticationLevel.MutualAuthRequested;
	}

	protected WebRequest(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		GetObjectData(serializationInfo, streamingContext);
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	private void InternalSetCachePolicy(RequestCachePolicy policy)
	{
		if (m_CacheBinding != null && m_CacheBinding.Cache != null && m_CacheBinding.Validator != null && CacheProtocol == null && policy != null && policy.Level != RequestCacheLevel.BypassCache)
		{
			CacheProtocol = new RequestCacheProtocol(m_CacheBinding.Cache, m_CacheBinding.Validator.CreateValidator());
		}
		m_CachePolicy = policy;
	}

	public virtual Stream GetRequestStream()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	public virtual WebResponse GetResponse()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual IAsyncResult BeginGetRequestStream(AsyncCallback callback, object state)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	public virtual Stream EndGetRequestStream(IAsyncResult asyncResult)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task<Stream> GetRequestStreamAsync()
	{
		IWebProxy webProxy = null;
		try
		{
			webProxy = Proxy;
		}
		catch (NotImplementedException)
		{
		}
		if (ExecutionContext.IsFlowSuppressed() && (UseDefaultCredentials || Credentials != null || (webProxy != null && webProxy.Credentials != null)))
		{
			WindowsIdentity currentUser = SafeCaptureIdenity();
			return Task.Run(delegate
			{
				using (currentUser)
				{
					using (currentUser.Impersonate())
					{
						return Task<Stream>.Factory.FromAsync(BeginGetRequestStream, EndGetRequestStream, null);
					}
				}
			});
		}
		return Task.Run(() => Task<Stream>.Factory.FromAsync(BeginGetRequestStream, EndGetRequestStream, null));
	}

	[global::__DynamicallyInvokable]
	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public virtual Task<WebResponse> GetResponseAsync()
	{
		IWebProxy webProxy = null;
		try
		{
			webProxy = Proxy;
		}
		catch (NotImplementedException)
		{
		}
		if (ExecutionContext.IsFlowSuppressed() && (UseDefaultCredentials || Credentials != null || (webProxy != null && webProxy.Credentials != null)))
		{
			WindowsIdentity currentUser = SafeCaptureIdenity();
			return Task.Run(delegate
			{
				using (currentUser)
				{
					using (currentUser.Impersonate())
					{
						return Task<WebResponse>.Factory.FromAsync(BeginGetResponse, EndGetResponse, null);
					}
				}
			});
		}
		return Task.Run(() => Task<WebResponse>.Factory.FromAsync(BeginGetResponse, EndGetResponse, null));
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	private WindowsIdentity SafeCaptureIdenity()
	{
		return WindowsIdentity.GetCurrent();
	}

	[global::__DynamicallyInvokable]
	public virtual void Abort()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	internal virtual ContextAwareResult GetConnectingContext()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	internal virtual ContextAwareResult GetWritingContext()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	internal virtual ContextAwareResult GetReadingContext()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	internal virtual void RequestCallback(object obj)
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}

	public static IWebProxy GetSystemWebProxy()
	{
		ExceptionHelper.WebPermissionUnrestricted.Demand();
		return InternalGetSystemWebProxy();
	}

	internal static IWebProxy InternalGetSystemWebProxy()
	{
		return new WebProxyWrapperOpaque(new WebProxy(enableAutoproxy: true));
	}

	internal void SetupCacheProtocol(Uri uri)
	{
		m_CacheBinding = RequestCacheManager.GetBinding(uri.Scheme);
		InternalSetCachePolicy(m_CacheBinding.Policy);
		if (m_CachePolicy == null)
		{
			InternalSetCachePolicy(DefaultCachePolicy);
		}
	}

	private static void InitEtwMethods()
	{
		Type typeFromHandle = typeof(FrameworkEventSource);
		Type[] types = new Type[4]
		{
			typeof(object),
			typeof(string),
			typeof(bool),
			typeof(bool)
		};
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		MethodInfo method = typeFromHandle.GetMethod("BeginGetResponse", bindingAttr, null, types, null);
		MethodInfo method2 = typeFromHandle.GetMethod("EndGetResponse", bindingAttr, null, new Type[4]
		{
			typeof(object),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, null);
		MethodInfo method3 = typeFromHandle.GetMethod("BeginGetRequestStream", bindingAttr, null, types, null);
		MethodInfo method4 = typeFromHandle.GetMethod("EndGetRequestStream", bindingAttr, null, new Type[3]
		{
			typeof(object),
			typeof(bool),
			typeof(bool)
		}, null);
		if (method != null && method2 != null && method3 != null && method4 != null)
		{
			s_EtwFireBeginGetResponse = (DelEtwFireBeginWRGet)method.CreateDelegate(typeof(DelEtwFireBeginWRGet), FrameworkEventSource.Log);
			s_EtwFireEndGetResponse = (DelEtwFireEndWRespGet)method2.CreateDelegate(typeof(DelEtwFireEndWRespGet), FrameworkEventSource.Log);
			s_EtwFireBeginGetRequestStream = (DelEtwFireBeginWRGet)method3.CreateDelegate(typeof(DelEtwFireBeginWRGet), FrameworkEventSource.Log);
			s_EtwFireEndGetRequestStream = (DelEtwFireEndWRGet)method4.CreateDelegate(typeof(DelEtwFireEndWRGet), FrameworkEventSource.Log);
		}
		s_TriedGetEtwDelegates = true;
	}

	internal void LogBeginGetResponse(bool success, bool synchronous)
	{
		string originalString = RequestUri.OriginalString;
		if (!s_TriedGetEtwDelegates)
		{
			InitEtwMethods();
		}
		if (s_EtwFireBeginGetResponse != null)
		{
			s_EtwFireBeginGetResponse(this, originalString, success, synchronous);
		}
	}

	internal void LogEndGetResponse(bool success, bool synchronous, int statusCode)
	{
		if (!s_TriedGetEtwDelegates)
		{
			InitEtwMethods();
		}
		if (s_EtwFireEndGetResponse != null)
		{
			s_EtwFireEndGetResponse(this, success, synchronous, statusCode);
		}
	}

	internal void LogBeginGetRequestStream(bool success, bool synchronous)
	{
		string originalString = RequestUri.OriginalString;
		if (!s_TriedGetEtwDelegates)
		{
			InitEtwMethods();
		}
		if (s_EtwFireBeginGetRequestStream != null)
		{
			s_EtwFireBeginGetRequestStream(this, originalString, success, synchronous);
		}
	}

	internal void LogEndGetRequestStream(bool success, bool synchronous)
	{
		if (!s_TriedGetEtwDelegates)
		{
			InitEtwMethods();
		}
		if (s_EtwFireEndGetRequestStream != null)
		{
			s_EtwFireEndGetRequestStream(this, success, synchronous);
		}
	}
}
