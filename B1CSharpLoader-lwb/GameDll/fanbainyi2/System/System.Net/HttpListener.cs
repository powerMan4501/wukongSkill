using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net;

public sealed class HttpListener : IDisposable
{
	private class AuthenticationSelectorInfo
	{
		private AuthenticationSchemeSelector m_SelectorDelegate;

		private bool m_CanUseAdvancedAuth;

		internal AuthenticationSchemeSelector Delegate => m_SelectorDelegate;

		internal bool AdvancedAuth => m_CanUseAdvancedAuth;

		internal AuthenticationSelectorInfo(AuthenticationSchemeSelector selectorDelegate, bool canUseAdvancedAuth)
		{
			m_SelectorDelegate = selectorDelegate;
			m_CanUseAdvancedAuth = canUseAdvancedAuth;
		}
	}

	public delegate ExtendedProtectionPolicy ExtendedProtectionSelector(HttpListenerRequest request);

	private enum State
	{
		Stopped,
		Started,
		Closed
	}

	private struct DigestContext
	{
		internal NTAuthentication context;

		internal int timestamp;
	}

	private class DisconnectAsyncResult : IAsyncResult
	{
		private unsafe static readonly IOCompletionCallback s_IOCallback = WaitCallback;

		private ulong m_ConnectionId;

		private HttpListener m_HttpListener;

		private unsafe NativeOverlapped* m_NativeOverlapped;

		private int m_OwnershipState;

		private WindowsPrincipal m_AuthenticatedConnection;

		private NTAuthentication m_Session;

		internal const string NTLM = "NTLM";

		internal unsafe NativeOverlapped* NativeOverlapped => m_NativeOverlapped;

		public object AsyncState
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		public bool IsCompleted
		{
			get
			{
				throw ExceptionHelper.PropertyNotImplementedException;
			}
		}

		internal WindowsPrincipal AuthenticatedConnection
		{
			get
			{
				return m_AuthenticatedConnection;
			}
			set
			{
				m_AuthenticatedConnection = value;
			}
		}

		internal NTAuthentication Session
		{
			get
			{
				return m_Session;
			}
			set
			{
				m_Session = value;
			}
		}

		internal unsafe DisconnectAsyncResult(HttpListener httpListener, ulong connectionId)
		{
			m_OwnershipState = 1;
			m_HttpListener = httpListener;
			m_ConnectionId = connectionId;
			m_NativeOverlapped = new Overlapped
			{
				AsyncResult = this
			}.UnsafePack(s_IOCallback, null);
		}

		internal bool StartOwningDisconnectHandling()
		{
			int num;
			while ((num = Interlocked.CompareExchange(ref m_OwnershipState, 1, 0)) == 2)
			{
				Thread.SpinWait(1);
			}
			return num < 2;
		}

		internal void FinishOwningDisconnectHandling()
		{
			if (Interlocked.CompareExchange(ref m_OwnershipState, 0, 1) == 2)
			{
				HandleDisconnect();
			}
		}

		internal unsafe void IOCompleted(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
		{
			IOCompleted(this, errorCode, numBytes, nativeOverlapped);
		}

		private unsafe static void IOCompleted(DisconnectAsyncResult asyncResult, uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
		{
			Overlapped.Free(nativeOverlapped);
			if (Interlocked.Exchange(ref asyncResult.m_OwnershipState, 2) == 0)
			{
				asyncResult.HandleDisconnect();
			}
		}

		private unsafe static void WaitCallback(uint errorCode, uint numBytes, NativeOverlapped* nativeOverlapped)
		{
			Overlapped overlapped = Overlapped.Unpack(nativeOverlapped);
			DisconnectAsyncResult asyncResult = (DisconnectAsyncResult)overlapped.AsyncResult;
			IOCompleted(asyncResult, errorCode, numBytes, nativeOverlapped);
		}

		private void HandleDisconnect()
		{
			m_HttpListener.DisconnectResults.Remove(m_ConnectionId);
			if (m_Session != null)
			{
				if (m_Session.Package == "WDigest")
				{
					m_HttpListener.SaveDigestContext(m_Session);
				}
				else
				{
					m_Session.CloseContext();
				}
			}
			IDisposable disposable = ((m_AuthenticatedConnection == null) ? null : (m_AuthenticatedConnection.Identity as IDisposable));
			if (disposable != null && m_AuthenticatedConnection.Identity.AuthenticationType == "NTLM" && m_HttpListener.UnsafeConnectionNtlmAuthentication)
			{
				disposable.Dispose();
			}
			int num = Interlocked.Exchange(ref m_OwnershipState, 3);
		}
	}

	private static readonly Type ChannelBindingStatusType = typeof(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_CHANNEL_BIND_STATUS);

	private static readonly int RequestChannelBindStatusSize = Marshal.SizeOf(typeof(UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_CHANNEL_BIND_STATUS));

	internal static readonly bool SkipIOCPCallbackOnSuccess = ComNetOS.IsWin8orLater;

	private const int UnknownHeaderLimit = 1000;

	private static byte[] s_WwwAuthenticateBytes = new byte[16]
	{
		87, 87, 87, 45, 65, 117, 116, 104, 101, 110,
		116, 105, 99, 97, 116, 101
	};

	private AuthenticationSelectorInfo m_AuthenticationDelegate;

	private AuthenticationSchemes m_AuthenticationScheme = AuthenticationSchemes.Anonymous;

	private SecurityException m_SecurityException;

	private string m_Realm;

	private CriticalHandle m_RequestQueueHandle;

	private bool m_RequestHandleBound;

	private volatile State m_State;

	private HttpListenerPrefixCollection m_Prefixes;

	private bool m_IgnoreWriteExceptions;

	private bool m_UnsafeConnectionNtlmAuthentication;

	private ExtendedProtectionSelector m_ExtendedProtectionSelectorDelegate;

	private ExtendedProtectionPolicy m_ExtendedProtectionPolicy;

	private ServiceNameStore m_DefaultServiceNames;

	private HttpServerSessionHandle m_ServerSessionHandle;

	private ulong m_UrlGroupId;

	private HttpListenerTimeoutManager m_TimeoutManager;

	private bool m_V2Initialized;

	private Hashtable m_DisconnectResults;

	private object m_InternalLock;

	internal Hashtable m_UriPrefixes = new Hashtable();

	private const int DigestLifetimeSeconds = 300;

	private const int MaximumDigests = 1024;

	private const int MinimumDigestLifetimeSeconds = 10;

	private DigestContext[] m_SavedDigests;

	private ArrayList m_ExtraSavedDigests;

	private ArrayList m_ExtraSavedDigestsBaking;

	private int m_ExtraSavedDigestsTimestamp;

	private int m_NewestContext;

	private int m_OldestContext;

	internal CriticalHandle RequestQueueHandle => m_RequestQueueHandle;

	public AuthenticationSchemeSelector AuthenticationSchemeSelectorDelegate
	{
		get
		{
			return m_AuthenticationDelegate?.Delegate;
		}
		set
		{
			CheckDisposed();
			try
			{
				new SecurityPermission(SecurityPermissionFlag.ControlPrincipal).Demand();
				m_AuthenticationDelegate = new AuthenticationSelectorInfo(value, canUseAdvancedAuth: true);
			}
			catch (SecurityException securityException)
			{
				m_SecurityException = securityException;
				m_AuthenticationDelegate = new AuthenticationSelectorInfo(value, canUseAdvancedAuth: false);
			}
		}
	}

	public ExtendedProtectionSelector ExtendedProtectionSelectorDelegate
	{
		get
		{
			return m_ExtendedProtectionSelectorDelegate;
		}
		set
		{
			CheckDisposed();
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			if (!AuthenticationManager.OSSupportsExtendedProtection)
			{
				throw new PlatformNotSupportedException(SR.GetString("security_ExtendedProtection_NoOSSupport"));
			}
			m_ExtendedProtectionSelectorDelegate = value;
		}
	}

	public AuthenticationSchemes AuthenticationSchemes
	{
		get
		{
			return m_AuthenticationScheme;
		}
		set
		{
			CheckDisposed();
			if ((value & (AuthenticationSchemes.IntegratedWindowsAuthentication | AuthenticationSchemes.Digest)) != AuthenticationSchemes.None)
			{
				new SecurityPermission(SecurityPermissionFlag.ControlPrincipal).Demand();
			}
			m_AuthenticationScheme = value;
		}
	}

	public ExtendedProtectionPolicy ExtendedProtectionPolicy
	{
		get
		{
			return m_ExtendedProtectionPolicy;
		}
		set
		{
			CheckDisposed();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!AuthenticationManager.OSSupportsExtendedProtection && value.PolicyEnforcement == PolicyEnforcement.Always)
			{
				throw new PlatformNotSupportedException(SR.GetString("security_ExtendedProtection_NoOSSupport"));
			}
			if (value.CustomChannelBinding != null)
			{
				throw new ArgumentException(SR.GetString("net_listener_cannot_set_custom_cbt"), "CustomChannelBinding");
			}
			m_ExtendedProtectionPolicy = value;
		}
	}

	public ServiceNameCollection DefaultServiceNames => m_DefaultServiceNames.ServiceNames;

	public string Realm
	{
		get
		{
			return m_Realm;
		}
		set
		{
			CheckDisposed();
			m_Realm = value;
		}
	}

	public HttpListenerTimeoutManager TimeoutManager
	{
		get
		{
			ValidateV2Property();
			return m_TimeoutManager;
		}
	}

	public static bool IsSupported => UnsafeNclNativeMethods.HttpApi.Supported;

	public bool IsListening => m_State == State.Started;

	public bool IgnoreWriteExceptions
	{
		get
		{
			return m_IgnoreWriteExceptions;
		}
		set
		{
			CheckDisposed();
			m_IgnoreWriteExceptions = value;
		}
	}

	public bool UnsafeConnectionNtlmAuthentication
	{
		get
		{
			return m_UnsafeConnectionNtlmAuthentication;
		}
		set
		{
			CheckDisposed();
			if (m_UnsafeConnectionNtlmAuthentication == value)
			{
				return;
			}
			lock (DisconnectResults.SyncRoot)
			{
				if (m_UnsafeConnectionNtlmAuthentication == value)
				{
					return;
				}
				m_UnsafeConnectionNtlmAuthentication = value;
				if (value)
				{
					return;
				}
				foreach (DisconnectAsyncResult value2 in DisconnectResults.Values)
				{
					value2.AuthenticatedConnection = null;
				}
			}
		}
	}

	private Hashtable DisconnectResults
	{
		get
		{
			if (m_DisconnectResults == null)
			{
				lock (m_InternalLock)
				{
					if (m_DisconnectResults == null)
					{
						m_DisconnectResults = Hashtable.Synchronized(new Hashtable());
					}
				}
			}
			return m_DisconnectResults;
		}
	}

	public HttpListenerPrefixCollection Prefixes
	{
		get
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.HttpListener, this, "Prefixes_get", "");
			}
			CheckDisposed();
			if (m_Prefixes == null)
			{
				m_Prefixes = new HttpListenerPrefixCollection(this);
			}
			return m_Prefixes;
		}
	}

	public HttpListener()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "HttpListener", "");
		}
		if (!UnsafeNclNativeMethods.HttpApi.Supported)
		{
			throw new PlatformNotSupportedException();
		}
		m_State = State.Stopped;
		m_InternalLock = new object();
		m_DefaultServiceNames = new ServiceNameStore();
		m_TimeoutManager = new HttpListenerTimeoutManager(this);
		m_ExtendedProtectionPolicy = new ExtendedProtectionPolicy(PolicyEnforcement.Never);
		if (Logging.On)
		{
			Logging.Exit(Logging.HttpListener, this, "HttpListener", "");
		}
	}

	private void ValidateV2Property()
	{
		lock (m_InternalLock)
		{
			CheckDisposed();
			SetupV2Config();
		}
	}

	private void SetUrlGroupProperty(UnsafeNclNativeMethods.HttpApi.HTTP_SERVER_PROPERTY property, IntPtr info, uint infosize)
	{
		uint num = 0u;
		num = UnsafeNclNativeMethods.HttpApi.HttpSetUrlGroupProperty(m_UrlGroupId, property, info, infosize);
		if (num != 0)
		{
			HttpListenerException ex = new HttpListenerException((int)num);
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "HttpSetUrlGroupProperty:: Property: " + property, ex);
			}
			throw ex;
		}
	}

	internal unsafe void SetServerTimeout(int[] timeouts, uint minSendBytesPerSecond)
	{
		ValidateV2Property();
		UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_LIMIT_INFO hTTP_TIMEOUT_LIMIT_INFO = new UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_LIMIT_INFO
		{
			Flags = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY,
			DrainEntityBody = (ushort)timeouts[1],
			EntityBody = (ushort)timeouts[0],
			RequestQueue = (ushort)timeouts[2],
			IdleConnection = (ushort)timeouts[3],
			HeaderWait = (ushort)timeouts[4],
			MinSendRate = minSendBytesPerSecond
		};
		IntPtr info = new IntPtr(&hTTP_TIMEOUT_LIMIT_INFO);
		SetUrlGroupProperty(UnsafeNclNativeMethods.HttpApi.HTTP_SERVER_PROPERTY.HttpServerTimeoutsProperty, info, (uint)Marshal.SizeOf(typeof(UnsafeNclNativeMethods.HttpApi.HTTP_TIMEOUT_LIMIT_INFO)));
	}

	internal unsafe void AddPrefix(string uriPrefix)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "AddPrefix", "uriPrefix:" + uriPrefix);
		}
		string text = null;
		try
		{
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			new WebPermission(NetworkAccess.Accept, uriPrefix).Demand();
			CheckDisposed();
			int num;
			if (string.Compare(uriPrefix, 0, "http://", 0, 7, StringComparison.OrdinalIgnoreCase) == 0)
			{
				num = 7;
			}
			else
			{
				if (string.Compare(uriPrefix, 0, "https://", 0, 8, StringComparison.OrdinalIgnoreCase) != 0)
				{
					throw new ArgumentException(SR.GetString("net_listener_scheme"), "uriPrefix");
				}
				num = 8;
			}
			bool flag = false;
			int i;
			for (i = num; i < uriPrefix.Length && uriPrefix[i] != '/' && (uriPrefix[i] != ':' || flag); i++)
			{
				if (uriPrefix[i] == '[')
				{
					if (flag)
					{
						i = num;
						break;
					}
					flag = true;
				}
				if (flag && uriPrefix[i] == ']')
				{
					flag = false;
				}
			}
			if (num == i)
			{
				throw new ArgumentException(SR.GetString("net_listener_host"), "uriPrefix");
			}
			if (uriPrefix[uriPrefix.Length - 1] != '/')
			{
				throw new ArgumentException(SR.GetString("net_listener_slash"), "uriPrefix");
			}
			text = ((uriPrefix[i] == ':') ? string.Copy(uriPrefix) : (uriPrefix.Substring(0, i) + ((num == 7) ? ":80" : ":443") + uriPrefix.Substring(i)));
			fixed (char* ptr = text)
			{
				for (num = 0; ptr[num] != ':'; num++)
				{
					ptr[num] = (char)CaseInsensitiveAscii.AsciiToLower[(byte)ptr[num]];
				}
			}
			if (m_State == State.Started)
			{
				uint num2 = InternalAddPrefix(text);
				switch (num2)
				{
				case 183u:
					throw new HttpListenerException((int)num2, SR.GetString("net_listener_already", text));
				default:
					throw new HttpListenerException((int)num2);
				case 0u:
					break;
				}
			}
			m_UriPrefixes[uriPrefix] = text;
			m_DefaultServiceNames.Add(uriPrefix);
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "AddPrefix", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "AddPrefix", "prefix:" + text);
			}
		}
	}

	internal bool RemovePrefix(string uriPrefix)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "RemovePrefix", "uriPrefix:" + uriPrefix);
		}
		try
		{
			CheckDisposed();
			if (uriPrefix == null)
			{
				throw new ArgumentNullException("uriPrefix");
			}
			if (!m_UriPrefixes.Contains(uriPrefix))
			{
				return false;
			}
			if (m_State == State.Started)
			{
				InternalRemovePrefix((string)m_UriPrefixes[uriPrefix]);
			}
			m_UriPrefixes.Remove(uriPrefix);
			m_DefaultServiceNames.Remove(uriPrefix);
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "RemovePrefix", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "RemovePrefix", "uriPrefix:" + uriPrefix);
			}
		}
		return true;
	}

	internal void RemoveAll(bool clear)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "RemoveAll", "");
		}
		try
		{
			CheckDisposed();
			if (m_UriPrefixes.Count <= 0)
			{
				return;
			}
			if (m_State == State.Started)
			{
				foreach (string value in m_UriPrefixes.Values)
				{
					InternalRemovePrefix(value);
				}
			}
			if (clear)
			{
				m_UriPrefixes.Clear();
				m_DefaultServiceNames.Clear();
			}
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "RemoveAll", "");
			}
		}
	}

	private IntPtr DangerousGetHandle()
	{
		return ((HttpRequestQueueV2Handle)m_RequestQueueHandle).DangerousGetHandle();
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	internal void EnsureBoundHandle()
	{
		if (m_RequestHandleBound)
		{
			return;
		}
		lock (m_InternalLock)
		{
			if (!m_RequestHandleBound)
			{
				ThreadPool.BindHandle(DangerousGetHandle());
				m_RequestHandleBound = true;
			}
		}
	}

	private unsafe void SetupV2Config()
	{
		uint num = 0u;
		ulong num2 = 0uL;
		if (m_V2Initialized)
		{
			return;
		}
		try
		{
			num = UnsafeNclNativeMethods.HttpApi.HttpCreateServerSession(UnsafeNclNativeMethods.HttpApi.Version, &num2, 0u);
			if (num != 0)
			{
				throw new HttpListenerException((int)num);
			}
			m_ServerSessionHandle = new HttpServerSessionHandle(num2);
			num2 = 0uL;
			num = UnsafeNclNativeMethods.HttpApi.HttpCreateUrlGroup(m_ServerSessionHandle.DangerousGetServerSessionId(), &num2, 0u);
			if (num != 0)
			{
				throw new HttpListenerException((int)num);
			}
			m_UrlGroupId = num2;
			m_V2Initialized = true;
		}
		catch (Exception e)
		{
			m_State = State.Closed;
			if (m_ServerSessionHandle != null)
			{
				m_ServerSessionHandle.Close();
			}
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "SetupV2Config", e);
			}
			throw;
		}
	}

	public void Start()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Start", "");
		}
		lock (m_InternalLock)
		{
			try
			{
				CheckDisposed();
				if (m_State != State.Started)
				{
					SetupV2Config();
					CreateRequestQueueHandle();
					AttachRequestQueueToUrlGroup();
					try
					{
						AddAllPrefixes();
					}
					catch (HttpListenerException)
					{
						DetachRequestQueueFromUrlGroup();
						ClearDigestCache();
						throw;
					}
					m_State = State.Started;
				}
			}
			catch (Exception e)
			{
				m_State = State.Closed;
				CloseRequestQueueHandle();
				CleanupV2Config();
				if (Logging.On)
				{
					Logging.Exception(Logging.HttpListener, this, "Start", e);
				}
				throw;
			}
			finally
			{
				if (Logging.On)
				{
					Logging.Exit(Logging.HttpListener, this, "Start", "");
				}
			}
		}
	}

	private void CleanupV2Config()
	{
		if (m_V2Initialized)
		{
			uint num = UnsafeNclNativeMethods.HttpApi.HttpCloseUrlGroup(m_UrlGroupId);
			if (num != 0 && Logging.On)
			{
				Logging.PrintError(Logging.HttpListener, this, "CloseV2Config", SR.GetString("net_listener_close_urlgroup_error", num));
			}
			m_UrlGroupId = 0uL;
			m_ServerSessionHandle.Close();
		}
	}

	private unsafe void AttachRequestQueueToUrlGroup()
	{
		UnsafeNclNativeMethods.HttpApi.HTTP_BINDING_INFO hTTP_BINDING_INFO = new UnsafeNclNativeMethods.HttpApi.HTTP_BINDING_INFO
		{
			Flags = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.HTTP_RECEIVE_REQUEST_FLAG_COPY_BODY,
			RequestQueueHandle = DangerousGetHandle()
		};
		IntPtr info = new IntPtr(&hTTP_BINDING_INFO);
		SetUrlGroupProperty(UnsafeNclNativeMethods.HttpApi.HTTP_SERVER_PROPERTY.HttpServerBindingProperty, info, (uint)Marshal.SizeOf(typeof(UnsafeNclNativeMethods.HttpApi.HTTP_BINDING_INFO)));
	}

	private unsafe void DetachRequestQueueFromUrlGroup()
	{
		UnsafeNclNativeMethods.HttpApi.HTTP_BINDING_INFO hTTP_BINDING_INFO = new UnsafeNclNativeMethods.HttpApi.HTTP_BINDING_INFO
		{
			Flags = UnsafeNclNativeMethods.HttpApi.HTTP_FLAGS.NONE,
			RequestQueueHandle = IntPtr.Zero
		};
		uint num = UnsafeNclNativeMethods.HttpApi.HttpSetUrlGroupProperty(pPropertyInfo: new IntPtr(&hTTP_BINDING_INFO), urlGroupId: m_UrlGroupId, serverProperty: UnsafeNclNativeMethods.HttpApi.HTTP_SERVER_PROPERTY.HttpServerBindingProperty, propertyInfoLength: (uint)Marshal.SizeOf(typeof(UnsafeNclNativeMethods.HttpApi.HTTP_BINDING_INFO)));
		if (num != 0 && Logging.On)
		{
			Logging.PrintError(Logging.HttpListener, this, "DetachRequestQueueFromUrlGroup", SR.GetString("net_listener_detach_error", num));
		}
	}

	public void Stop()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Stop", "");
		}
		try
		{
			lock (m_InternalLock)
			{
				CheckDisposed();
				if (m_State == State.Stopped)
				{
					return;
				}
				RemoveAll(clear: false);
				DetachRequestQueueFromUrlGroup();
				CloseRequestQueueHandle();
				m_State = State.Stopped;
			}
			ClearDigestCache();
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "Stop", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "Stop", "");
			}
		}
	}

	private void CreateRequestQueueHandle()
	{
		uint num = 0u;
		HttpRequestQueueV2Handle pReqQueueHandle = null;
		num = UnsafeNclNativeMethods.SafeNetHandles.HttpCreateRequestQueue(UnsafeNclNativeMethods.HttpApi.Version, null, null, 0u, out pReqQueueHandle);
		if (num != 0)
		{
			throw new HttpListenerException((int)num);
		}
		if (SkipIOCPCallbackOnSuccess && !UnsafeNclNativeMethods.SetFileCompletionNotificationModes(pReqQueueHandle, UnsafeNclNativeMethods.FileCompletionNotificationModes.SkipCompletionPortOnSuccess | UnsafeNclNativeMethods.FileCompletionNotificationModes.SkipSetEventOnHandle))
		{
			throw new HttpListenerException(Marshal.GetLastWin32Error());
		}
		m_RequestQueueHandle = pReqQueueHandle;
	}

	private void CloseRequestQueueHandle()
	{
		if (m_RequestQueueHandle != null && !m_RequestQueueHandle.IsInvalid)
		{
			m_RequestQueueHandle.Close();
			m_RequestHandleBound = false;
		}
	}

	public void Abort()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Abort", "");
		}
		lock (m_InternalLock)
		{
			try
			{
				if (m_State != State.Closed)
				{
					if (m_State == State.Started)
					{
						DetachRequestQueueFromUrlGroup();
						CloseRequestQueueHandle();
					}
					CleanupV2Config();
					ClearDigestCache();
				}
			}
			catch (Exception e)
			{
				if (Logging.On)
				{
					Logging.Exception(Logging.HttpListener, this, "Abort", e);
				}
				throw;
			}
			finally
			{
				m_State = State.Closed;
				if (Logging.On)
				{
					Logging.Exit(Logging.HttpListener, this, "Abort", "");
				}
			}
		}
	}

	public void Close()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Close", "");
		}
		try
		{
			((IDisposable)this).Dispose();
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "Close", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "Close", "");
			}
		}
	}

	private void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "Dispose", "");
		}
		lock (m_InternalLock)
		{
			try
			{
				if (m_State != State.Closed)
				{
					Stop();
					CleanupV2Config();
				}
			}
			catch (Exception e)
			{
				if (Logging.On)
				{
					Logging.Exception(Logging.HttpListener, this, "Dispose", e);
				}
				throw;
			}
			finally
			{
				m_State = State.Closed;
				if (Logging.On)
				{
					Logging.Exit(Logging.HttpListener, this, "Dispose", "");
				}
			}
		}
	}

	void IDisposable.Dispose()
	{
		Dispose(disposing: true);
	}

	private uint InternalAddPrefix(string uriPrefix)
	{
		uint num = 0u;
		return UnsafeNclNativeMethods.HttpApi.HttpAddUrlToUrlGroup(m_UrlGroupId, uriPrefix, 0uL, 0u);
	}

	private bool InternalRemovePrefix(string uriPrefix)
	{
		uint num = 0u;
		num = UnsafeNclNativeMethods.HttpApi.HttpRemoveUrlFromUrlGroup(m_UrlGroupId, uriPrefix, 0u);
		if (num == 1168)
		{
			return false;
		}
		return true;
	}

	private void AddAllPrefixes()
	{
		if (m_UriPrefixes.Count <= 0)
		{
			return;
		}
		foreach (string value in m_UriPrefixes.Values)
		{
			uint num = InternalAddPrefix(value);
			switch (num)
			{
			case 183u:
				throw new HttpListenerException((int)num, SR.GetString("net_listener_already", value));
			default:
				throw new HttpListenerException((int)num);
			case 0u:
				break;
			}
		}
	}

	public unsafe HttpListenerContext GetContext()
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "GetContext", "");
		}
		SyncRequestContext syncRequestContext = null;
		HttpListenerContext httpListenerContext = null;
		bool stoleBlob = false;
		try
		{
			CheckDisposed();
			if (m_State == State.Stopped)
			{
				throw new InvalidOperationException(SR.GetString("net_listener_mustcall", "Start()"));
			}
			if (m_UriPrefixes.Count == 0)
			{
				throw new InvalidOperationException(SR.GetString("net_listener_mustcall", "AddPrefix()"));
			}
			uint num = 0u;
			uint num2 = 4096u;
			ulong num3 = 0uL;
			syncRequestContext = new SyncRequestContext((int)num2);
			while (true)
			{
				uint num4 = 0u;
				num = UnsafeNclNativeMethods.HttpApi.HttpReceiveHttpRequest(m_RequestQueueHandle, num3, 1u, syncRequestContext.RequestBlob, num2, &num4, null);
				if (num == 87 && num3 != 0L)
				{
					num3 = 0uL;
					continue;
				}
				switch (num)
				{
				case 234u:
					num2 = num4;
					num3 = syncRequestContext.RequestBlob->RequestId;
					syncRequestContext.Reset(checked((int)num2));
					break;
				default:
					throw new HttpListenerException((int)num);
				case 0u:
					if (ValidateRequest(syncRequestContext))
					{
						httpListenerContext = HandleAuthentication(syncRequestContext, out stoleBlob);
					}
					if (stoleBlob)
					{
						syncRequestContext = null;
						stoleBlob = false;
					}
					if (httpListenerContext != null)
					{
						return httpListenerContext;
					}
					if (syncRequestContext == null)
					{
						syncRequestContext = new SyncRequestContext(checked((int)num2));
					}
					num3 = 0uL;
					break;
				}
			}
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "GetContext", e);
			}
			throw;
		}
		finally
		{
			if (syncRequestContext != null && !stoleBlob)
			{
				syncRequestContext.ReleasePins();
				syncRequestContext.Close();
			}
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "GetContext", "HttpListenerContext#" + ValidationHelper.HashString(httpListenerContext) + " RequestTraceIdentifier#" + ((httpListenerContext != null) ? httpListenerContext.Request.RequestTraceIdentifier.ToString() : "<null>"));
			}
		}
	}

	internal unsafe bool ValidateRequest(RequestContextBase requestMemory)
	{
		if (requestMemory.RequestBlob->Headers.UnknownHeaderCount > 1000)
		{
			SendError(requestMemory.RequestBlob->RequestId, HttpStatusCode.BadRequest, null);
			return false;
		}
		return true;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public IAsyncResult BeginGetContext(AsyncCallback callback, object state)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "BeginGetContext", "");
		}
		ListenerAsyncResult listenerAsyncResult = null;
		try
		{
			CheckDisposed();
			if (m_State == State.Stopped)
			{
				throw new InvalidOperationException(SR.GetString("net_listener_mustcall", "Start()"));
			}
			listenerAsyncResult = new ListenerAsyncResult(this, state, callback);
			uint num = listenerAsyncResult.QueueBeginGetContext();
			if (num != 0 && num != 997)
			{
				throw new HttpListenerException((int)num);
			}
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "BeginGetContext", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Enter(Logging.HttpListener, this, "BeginGetContext", "IAsyncResult#" + ValidationHelper.HashString(listenerAsyncResult));
			}
		}
		return listenerAsyncResult;
	}

	public HttpListenerContext EndGetContext(IAsyncResult asyncResult)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, this, "EndGetContext", "IAsyncResult#" + ValidationHelper.HashString(asyncResult));
		}
		HttpListenerContext httpListenerContext = null;
		try
		{
			CheckDisposed();
			if (asyncResult == null)
			{
				throw new ArgumentNullException("asyncResult");
			}
			if (!(asyncResult is ListenerAsyncResult listenerAsyncResult) || listenerAsyncResult.AsyncObject != this)
			{
				throw new ArgumentException(SR.GetString("net_io_invalidasyncresult"), "asyncResult");
			}
			if (listenerAsyncResult.EndCalled)
			{
				throw new InvalidOperationException(SR.GetString("net_io_invalidendcall", "EndGetContext"));
			}
			listenerAsyncResult.EndCalled = true;
			httpListenerContext = listenerAsyncResult.InternalWaitForCompletion() as HttpListenerContext;
			if (httpListenerContext == null)
			{
				throw listenerAsyncResult.Result as Exception;
			}
		}
		catch (Exception e)
		{
			if (Logging.On)
			{
				Logging.Exception(Logging.HttpListener, this, "EndGetContext", e);
			}
			throw;
		}
		finally
		{
			if (Logging.On)
			{
				Logging.Exit(Logging.HttpListener, this, "EndGetContext", (httpListenerContext == null) ? "<no context>" : ("HttpListenerContext#" + ValidationHelper.HashString(httpListenerContext) + " RequestTraceIdentifier#" + httpListenerContext.Request.RequestTraceIdentifier.ToString()));
			}
		}
		return httpListenerContext;
	}

	[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
	public Task<HttpListenerContext> GetContextAsync()
	{
		return Task<HttpListenerContext>.Factory.FromAsync(BeginGetContext, EndGetContext, null);
	}

	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.UnmanagedCode)]
	[SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.ControlPrincipal)]
	internal static WindowsIdentity CreateWindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
	{
		return new WindowsIdentity(userToken, type, acctType, isAuthenticated);
	}

	internal unsafe HttpListenerContext HandleAuthentication(RequestContextBase memoryBlob, out bool stoleBlob)
	{
		string text = null;
		stoleBlob = false;
		string verb = UnsafeNclNativeMethods.HttpApi.GetVerb(memoryBlob.RequestBlob);
		string knownHeader = UnsafeNclNativeMethods.HttpApi.GetKnownHeader(memoryBlob.RequestBlob, 24);
		ulong connectionId = memoryBlob.RequestBlob->ConnectionId;
		ulong requestId = memoryBlob.RequestBlob->RequestId;
		bool isSecureConnection = memoryBlob.RequestBlob->pSslInfo != null;
		DisconnectAsyncResult disconnectResult = (DisconnectAsyncResult)DisconnectResults[connectionId];
		if (UnsafeConnectionNtlmAuthentication)
		{
			if (knownHeader == null)
			{
				WindowsPrincipal windowsPrincipal = disconnectResult?.AuthenticatedConnection;
				if (windowsPrincipal != null)
				{
					stoleBlob = true;
					HttpListenerContext httpListenerContext = new HttpListenerContext(this, memoryBlob);
					httpListenerContext.SetIdentity(windowsPrincipal, null);
					httpListenerContext.Request.ReleasePins();
					return httpListenerContext;
				}
			}
			else if (disconnectResult != null)
			{
				disconnectResult.AuthenticatedConnection = null;
			}
		}
		stoleBlob = true;
		HttpListenerContext httpContext = null;
		NTAuthentication nTAuthentication = null;
		NTAuthentication newContext = null;
		NTAuthentication nTAuthentication2 = null;
		AuthenticationSchemes authenticationSchemes = AuthenticationSchemes.None;
		AuthenticationSchemes authenticationSchemes2 = AuthenticationSchemes;
		ExtendedProtectionPolicy extendedProtectionPolicy = m_ExtendedProtectionPolicy;
		try
		{
			if (disconnectResult != null && !disconnectResult.StartOwningDisconnectHandling())
			{
				disconnectResult = null;
			}
			if (disconnectResult != null)
			{
				nTAuthentication = disconnectResult.Session;
			}
			httpContext = new HttpListenerContext(this, memoryBlob);
			AuthenticationSelectorInfo authenticationDelegate = m_AuthenticationDelegate;
			if (authenticationDelegate != null)
			{
				try
				{
					httpContext.Request.ReleasePins();
					authenticationSchemes2 = (httpContext.AuthenticationSchemes = authenticationDelegate.Delegate(httpContext.Request));
					if (!authenticationDelegate.AdvancedAuth && (authenticationSchemes2 & (AuthenticationSchemes.IntegratedWindowsAuthentication | AuthenticationSchemes.Digest)) != AuthenticationSchemes.None)
					{
						throw m_SecurityException;
					}
				}
				catch (Exception ex)
				{
					if (NclUtilities.IsFatal(ex))
					{
						throw;
					}
					if (Logging.On)
					{
						Logging.PrintError(Logging.HttpListener, this, "HandleAuthentication", SR.GetString("net_log_listener_delegate_exception", ex));
					}
					SendError(requestId, HttpStatusCode.InternalServerError, null);
					FreeContext(ref httpContext, memoryBlob);
					return null;
				}
			}
			else
			{
				stoleBlob = false;
			}
			ExtendedProtectionSelector extendedProtectionSelectorDelegate = m_ExtendedProtectionSelectorDelegate;
			if (extendedProtectionSelectorDelegate != null)
			{
				extendedProtectionPolicy = extendedProtectionSelectorDelegate(httpContext.Request);
				if (extendedProtectionPolicy == null)
				{
					extendedProtectionPolicy = new ExtendedProtectionPolicy(PolicyEnforcement.Never);
				}
				httpContext.ExtendedProtectionPolicy = extendedProtectionPolicy;
			}
			int i = -1;
			if (knownHeader != null && (authenticationSchemes2 & ~AuthenticationSchemes.Anonymous) != AuthenticationSchemes.None)
			{
				for (i = 0; i < knownHeader.Length && knownHeader[i] != ' ' && knownHeader[i] != '\t' && knownHeader[i] != '\r' && knownHeader[i] != '\n'; i++)
				{
				}
				if (i < knownHeader.Length)
				{
					if ((authenticationSchemes2 & AuthenticationSchemes.Negotiate) != AuthenticationSchemes.None && string.Compare(knownHeader, 0, "Negotiate", 0, i, StringComparison.OrdinalIgnoreCase) == 0)
					{
						authenticationSchemes = AuthenticationSchemes.Negotiate;
					}
					else if ((authenticationSchemes2 & AuthenticationSchemes.Ntlm) != AuthenticationSchemes.None && string.Compare(knownHeader, 0, "NTLM", 0, i, StringComparison.OrdinalIgnoreCase) == 0)
					{
						authenticationSchemes = AuthenticationSchemes.Ntlm;
					}
					else if ((authenticationSchemes2 & AuthenticationSchemes.Digest) != AuthenticationSchemes.None && string.Compare(knownHeader, 0, "Digest", 0, i, StringComparison.OrdinalIgnoreCase) == 0)
					{
						authenticationSchemes = AuthenticationSchemes.Digest;
					}
					else if ((authenticationSchemes2 & AuthenticationSchemes.Basic) != AuthenticationSchemes.None && string.Compare(knownHeader, 0, "Basic", 0, i, StringComparison.OrdinalIgnoreCase) == 0)
					{
						authenticationSchemes = AuthenticationSchemes.Basic;
					}
					else if (Logging.On)
					{
						Logging.PrintWarning(Logging.HttpListener, this, "HandleAuthentication", SR.GetString("net_log_listener_unsupported_authentication_scheme", knownHeader, authenticationSchemes2));
					}
				}
			}
			HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;
			bool flag = false;
			if (authenticationSchemes == AuthenticationSchemes.None)
			{
				if (Logging.On)
				{
					Logging.PrintWarning(Logging.HttpListener, this, "HandleAuthentication", SR.GetString("net_log_listener_unmatched_authentication_scheme", ValidationHelper.ToString(authenticationSchemes2), (knownHeader == null) ? "<null>" : knownHeader));
				}
				if ((authenticationSchemes2 & AuthenticationSchemes.Anonymous) != AuthenticationSchemes.None)
				{
					if (!stoleBlob)
					{
						stoleBlob = true;
						httpContext.Request.ReleasePins();
					}
					return httpContext;
				}
				httpStatusCode = HttpStatusCode.Unauthorized;
				FreeContext(ref httpContext, memoryBlob);
			}
			else
			{
				byte[] array = null;
				byte[] array2 = null;
				string text2 = null;
				for (i++; i < knownHeader.Length && (knownHeader[i] == ' ' || knownHeader[i] == '\t' || knownHeader[i] == '\r' || knownHeader[i] == '\n'); i++)
				{
				}
				string text3 = ((i < knownHeader.Length) ? knownHeader.Substring(i) : "");
				IPrincipal principal = null;
				SecurityStatus statusCode;
				object obj;
				string text4;
				switch (authenticationSchemes)
				{
				case AuthenticationSchemes.Digest:
				{
					ChannelBinding channelBinding = GetChannelBinding(connectionId, isSecureConnection, extendedProtectionPolicy);
					nTAuthentication2 = new NTAuthentication(isServer: true, "WDigest", null, GetContextFlags(extendedProtectionPolicy, isSecureConnection), channelBinding);
					text2 = nTAuthentication2.GetOutgoingDigestBlob(text3, verb, null, Realm, isClientPreAuth: false, throwOnError: false, out statusCode);
					if (statusCode == SecurityStatus.OK)
					{
						text2 = null;
					}
					if (nTAuthentication2.IsValidContext)
					{
						SafeCloseHandle safeCloseHandle2 = null;
						try
						{
							if (!CheckSpn(nTAuthentication2, isSecureConnection, extendedProtectionPolicy))
							{
								httpStatusCode = HttpStatusCode.Unauthorized;
							}
							else
							{
								httpContext.Request.ServiceName = nTAuthentication2.ClientSpecifiedSpn;
								safeCloseHandle2 = nTAuthentication2.GetContextToken(out statusCode);
								if (statusCode != SecurityStatus.OK)
								{
									httpStatusCode = HttpStatusFromSecurityStatus(statusCode);
								}
								else if (safeCloseHandle2 == null)
								{
									httpStatusCode = HttpStatusCode.Unauthorized;
								}
								else
								{
									principal = new WindowsPrincipal(CreateWindowsIdentity(safeCloseHandle2.DangerousGetHandle(), "Digest", WindowsAccountType.Normal, isAuthenticated: true));
								}
							}
						}
						finally
						{
							safeCloseHandle2?.Close();
						}
						newContext = nTAuthentication2;
						if (text2 != null)
						{
							text = "Digest " + text2;
						}
					}
					else
					{
						httpStatusCode = HttpStatusFromSecurityStatus(statusCode);
					}
					break;
				}
				case AuthenticationSchemes.Negotiate:
					obj = "Negotiate";
					goto IL_0518;
				case AuthenticationSchemes.Ntlm:
					obj = "NTLM";
					goto IL_0518;
				case AuthenticationSchemes.Basic:
					{
						try
						{
							array = Convert.FromBase64String(text3);
							text3 = WebHeaderCollection.HeaderEncoding.GetString(array, 0, array.Length);
							i = text3.IndexOf(':');
							if (i != -1)
							{
								string username = text3.Substring(0, i);
								string password = text3.Substring(i + 1);
								principal = new GenericPrincipal(new HttpListenerBasicIdentity(username, password), null);
							}
							else
							{
								httpStatusCode = HttpStatusCode.BadRequest;
							}
						}
						catch (FormatException)
						{
						}
						break;
					}
					IL_0518:
					text4 = (string)obj;
					if (nTAuthentication != null && nTAuthentication.Package == text4)
					{
						nTAuthentication2 = nTAuthentication;
					}
					else
					{
						ChannelBinding channelBinding = GetChannelBinding(connectionId, isSecureConnection, extendedProtectionPolicy);
						nTAuthentication2 = new NTAuthentication(isServer: true, text4, null, GetContextFlags(extendedProtectionPolicy, isSecureConnection), channelBinding);
					}
					try
					{
						array = Convert.FromBase64String(text3);
					}
					catch (FormatException)
					{
						httpStatusCode = HttpStatusCode.BadRequest;
						flag = true;
					}
					if (!flag)
					{
						array2 = nTAuthentication2.GetOutgoingBlob(array, throwOnError: false, out statusCode);
						flag = !nTAuthentication2.IsValidContext;
						if (flag)
						{
							if (statusCode == SecurityStatus.InvalidHandle && nTAuthentication == null && array != null && array.Length != 0)
							{
								statusCode = SecurityStatus.InvalidToken;
							}
							httpStatusCode = HttpStatusFromSecurityStatus(statusCode);
						}
					}
					if (array2 != null)
					{
						text2 = Convert.ToBase64String(array2);
					}
					if (flag)
					{
						break;
					}
					if (nTAuthentication2.IsCompleted)
					{
						SafeCloseHandle safeCloseHandle = null;
						try
						{
							if (!CheckSpn(nTAuthentication2, isSecureConnection, extendedProtectionPolicy))
							{
								httpStatusCode = HttpStatusCode.Unauthorized;
								break;
							}
							httpContext.Request.ServiceName = nTAuthentication2.ClientSpecifiedSpn;
							safeCloseHandle = nTAuthentication2.GetContextToken(out statusCode);
							if (statusCode != SecurityStatus.OK)
							{
								httpStatusCode = HttpStatusFromSecurityStatus(statusCode);
								break;
							}
							WindowsPrincipal windowsPrincipal2 = new WindowsPrincipal(CreateWindowsIdentity(safeCloseHandle.DangerousGetHandle(), nTAuthentication2.ProtocolName, WindowsAccountType.Normal, isAuthenticated: true));
							principal = windowsPrincipal2;
							if (!UnsafeConnectionNtlmAuthentication || !(nTAuthentication2.ProtocolName == "NTLM"))
							{
								break;
							}
							if (disconnectResult == null)
							{
								RegisterForDisconnectNotification(connectionId, ref disconnectResult);
							}
							if (disconnectResult == null)
							{
								break;
							}
							lock (DisconnectResults.SyncRoot)
							{
								if (UnsafeConnectionNtlmAuthentication)
								{
									disconnectResult.AuthenticatedConnection = windowsPrincipal2;
								}
							}
						}
						finally
						{
							safeCloseHandle?.Close();
						}
					}
					else
					{
						newContext = nTAuthentication2;
						text = ((authenticationSchemes == AuthenticationSchemes.Ntlm) ? "NTLM" : "Negotiate");
						if (!string.IsNullOrEmpty(text2))
						{
							text = text + " " + text2;
						}
					}
					break;
				}
				if (principal != null)
				{
					httpContext.SetIdentity(principal, text2);
				}
				else
				{
					if (Logging.On)
					{
						Logging.PrintWarning(Logging.HttpListener, this, "HandleAuthentication", SR.GetString("net_log_listener_create_valid_identity_failed"));
					}
					FreeContext(ref httpContext, memoryBlob);
				}
			}
			ArrayList challenges = null;
			if (httpContext == null)
			{
				if (text != null)
				{
					AddChallenge(ref challenges, text);
				}
				else
				{
					if (newContext != null)
					{
						if (newContext == nTAuthentication2)
						{
							nTAuthentication2 = null;
						}
						if (newContext != nTAuthentication)
						{
							NTAuthentication nTAuthentication3 = newContext;
							newContext = null;
							nTAuthentication3.CloseContext();
						}
						else
						{
							newContext = null;
						}
					}
					if (httpStatusCode != HttpStatusCode.Unauthorized)
					{
						SendError(requestId, httpStatusCode, null);
						return null;
					}
					challenges = BuildChallenge(authenticationSchemes2, connectionId, out newContext, extendedProtectionPolicy, isSecureConnection);
				}
			}
			if (disconnectResult == null && newContext != null)
			{
				RegisterForDisconnectNotification(connectionId, ref disconnectResult);
				if (disconnectResult == null)
				{
					if (newContext != null)
					{
						if (newContext == nTAuthentication2)
						{
							nTAuthentication2 = null;
						}
						if (newContext != nTAuthentication)
						{
							NTAuthentication nTAuthentication4 = newContext;
							newContext = null;
							nTAuthentication4.CloseContext();
						}
						else
						{
							newContext = null;
						}
					}
					SendError(requestId, HttpStatusCode.InternalServerError, null);
					FreeContext(ref httpContext, memoryBlob);
					return null;
				}
			}
			if (nTAuthentication != newContext)
			{
				if (nTAuthentication == nTAuthentication2)
				{
					nTAuthentication2 = null;
				}
				NTAuthentication nTAuthentication5 = nTAuthentication;
				nTAuthentication = newContext;
				disconnectResult.Session = newContext;
				if (nTAuthentication5 != null)
				{
					if ((authenticationSchemes2 & AuthenticationSchemes.Digest) != AuthenticationSchemes.None)
					{
						SaveDigestContext(nTAuthentication5);
					}
					else
					{
						nTAuthentication5.CloseContext();
					}
				}
			}
			if (httpContext == null)
			{
				SendError(requestId, (challenges != null && challenges.Count > 0) ? HttpStatusCode.Unauthorized : HttpStatusCode.Forbidden, challenges);
				return null;
			}
			if (!stoleBlob)
			{
				stoleBlob = true;
				httpContext.Request.ReleasePins();
			}
			return httpContext;
		}
		catch
		{
			FreeContext(ref httpContext, memoryBlob);
			if (newContext != null)
			{
				if (newContext == nTAuthentication2)
				{
					nTAuthentication2 = null;
				}
				if (newContext != nTAuthentication)
				{
					NTAuthentication nTAuthentication6 = newContext;
					newContext = null;
					nTAuthentication6.CloseContext();
				}
				else
				{
					newContext = null;
				}
			}
			throw;
		}
		finally
		{
			try
			{
				if (nTAuthentication != null && nTAuthentication != newContext)
				{
					if (newContext == null && disconnectResult != null)
					{
						disconnectResult.Session = null;
					}
					if ((authenticationSchemes2 & AuthenticationSchemes.Digest) != AuthenticationSchemes.None)
					{
						SaveDigestContext(nTAuthentication);
					}
					else
					{
						nTAuthentication.CloseContext();
					}
				}
				if (nTAuthentication2 != null && nTAuthentication != nTAuthentication2 && newContext != nTAuthentication2)
				{
					nTAuthentication2.CloseContext();
				}
			}
			finally
			{
				disconnectResult?.FinishOwningDisconnectHandling();
			}
		}
	}

	private static void FreeContext(ref HttpListenerContext httpContext, RequestContextBase memoryBlob)
	{
		if (httpContext != null)
		{
			httpContext.Request.DetachBlob(memoryBlob);
			httpContext.Close();
			httpContext = null;
		}
	}

	internal void SetAuthenticationHeaders(HttpListenerContext context)
	{
		HttpListenerRequest request = context.Request;
		HttpListenerResponse response = context.Response;
		NTAuthentication newContext;
		ArrayList arrayList = BuildChallenge(context.AuthenticationSchemes, request.m_ConnectionId, out newContext, context.ExtendedProtectionPolicy, request.IsSecureConnection);
		if (arrayList == null)
		{
			return;
		}
		if (newContext != null)
		{
			SaveDigestContext(newContext);
		}
		foreach (string item in arrayList)
		{
			response.Headers.AddInternal("WWW-Authenticate", item);
		}
	}

	private static bool ScenarioChecksChannelBinding(bool isSecureConnection, ProtectionScenario scenario)
	{
		if (isSecureConnection)
		{
			return scenario == ProtectionScenario.TransportSelected;
		}
		return false;
	}

	private ChannelBinding GetChannelBinding(ulong connectionId, bool isSecureConnection, ExtendedProtectionPolicy policy)
	{
		if (policy.PolicyEnforcement == PolicyEnforcement.Never)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_cbt_disabled"));
			}
			return null;
		}
		if (!isSecureConnection)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_cbt_http"));
			}
			return null;
		}
		if (!AuthenticationManager.OSSupportsExtendedProtection)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_cbt_platform"));
			}
			return null;
		}
		if (policy.ProtectionScenario == ProtectionScenario.TrustedProxy)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_cbt_trustedproxy"));
			}
			return null;
		}
		ChannelBinding channelBindingFromTls = GetChannelBindingFromTls(connectionId);
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_cbt"));
		}
		return channelBindingFromTls;
	}

	private bool CheckSpn(NTAuthentication context, bool isSecureConnection, ExtendedProtectionPolicy policy)
	{
		if (context.IsKerberos)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_spn_kerberos"));
			}
			return true;
		}
		if (policy.PolicyEnforcement == PolicyEnforcement.Never)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_spn_disabled"));
			}
			return true;
		}
		if (ScenarioChecksChannelBinding(isSecureConnection, policy.ProtectionScenario))
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_spn_cbt"));
			}
			return true;
		}
		if (!AuthenticationManager.OSSupportsExtendedProtection)
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_spn_platform"));
			}
			return true;
		}
		string clientSpecifiedSpn = context.ClientSpecifiedSpn;
		if (string.IsNullOrEmpty(clientSpecifiedSpn))
		{
			if (policy.PolicyEnforcement == PolicyEnforcement.WhenSupported)
			{
				if (Logging.On)
				{
					Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_spn_whensupported"));
				}
				return true;
			}
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_spn_failed_always"));
			}
			return false;
		}
		if (ServiceNameCollection.Match(clientSpecifiedSpn, "http/localhost"))
		{
			if (Logging.On)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_no_spn_loopback"));
			}
			return true;
		}
		if (Logging.On)
		{
			Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_spn", clientSpecifiedSpn));
		}
		ServiceNameCollection serviceNames = GetServiceNames(policy);
		bool flag = serviceNames.Contains(clientSpecifiedSpn);
		if (Logging.On)
		{
			if (flag)
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_spn_passed"));
			}
			else
			{
				Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_spn_failed"));
				if (serviceNames.Count == 0)
				{
					Logging.PrintWarning(Logging.HttpListener, this, "CheckSpn", SR.GetString("net_log_listener_spn_failed_empty"));
				}
				else
				{
					Logging.PrintInfo(Logging.HttpListener, this, SR.GetString("net_log_listener_spn_failed_dump"));
					foreach (string item in serviceNames)
					{
						Logging.PrintInfo(Logging.HttpListener, this, "\t" + item);
					}
				}
			}
		}
		return flag;
	}

	private ServiceNameCollection GetServiceNames(ExtendedProtectionPolicy policy)
	{
		if (policy.CustomServiceNames == null)
		{
			if (m_DefaultServiceNames.ServiceNames.Count == 0)
			{
				throw new InvalidOperationException(SR.GetString("net_listener_no_spns"));
			}
			return m_DefaultServiceNames.ServiceNames;
		}
		return policy.CustomServiceNames;
	}

	private ContextFlags GetContextFlags(ExtendedProtectionPolicy policy, bool isSecureConnection)
	{
		ContextFlags contextFlags = ContextFlags.Connection;
		if (policy.PolicyEnforcement != PolicyEnforcement.Never)
		{
			if (policy.PolicyEnforcement == PolicyEnforcement.WhenSupported)
			{
				contextFlags |= ContextFlags.AllowMissingBindings;
			}
			if (policy.ProtectionScenario == ProtectionScenario.TrustedProxy)
			{
				contextFlags |= ContextFlags.ProxyBindings;
			}
		}
		return contextFlags;
	}

	private static void AddChallenge(ref ArrayList challenges, string challenge)
	{
		if (challenge == null)
		{
			return;
		}
		challenge = challenge.Trim();
		if (challenge.Length > 0)
		{
			if (challenges == null)
			{
				challenges = new ArrayList(4);
			}
			challenges.Add(challenge);
		}
	}

	private ArrayList BuildChallenge(AuthenticationSchemes authenticationScheme, ulong connectionId, out NTAuthentication newContext, ExtendedProtectionPolicy policy, bool isSecureConnection)
	{
		ArrayList challenges = null;
		newContext = null;
		if ((authenticationScheme & AuthenticationSchemes.Negotiate) != AuthenticationSchemes.None)
		{
			AddChallenge(ref challenges, "Negotiate");
		}
		if ((authenticationScheme & AuthenticationSchemes.Ntlm) != AuthenticationSchemes.None)
		{
			AddChallenge(ref challenges, "NTLM");
		}
		if ((authenticationScheme & AuthenticationSchemes.Digest) != AuthenticationSchemes.None)
		{
			NTAuthentication nTAuthentication = null;
			try
			{
				string text = null;
				ChannelBinding channelBinding = GetChannelBinding(connectionId, isSecureConnection, policy);
				nTAuthentication = new NTAuthentication(isServer: true, "WDigest", null, GetContextFlags(policy, isSecureConnection), channelBinding);
				text = nTAuthentication.GetOutgoingDigestBlob(null, null, null, Realm, isClientPreAuth: false, throwOnError: false, out var _);
				if (nTAuthentication.IsValidContext)
				{
					newContext = nTAuthentication;
				}
				AddChallenge(ref challenges, "Digest" + (string.IsNullOrEmpty(text) ? "" : (" " + text)));
			}
			finally
			{
				if (nTAuthentication != null && newContext != nTAuthentication)
				{
					nTAuthentication.CloseContext();
				}
			}
		}
		if ((authenticationScheme & AuthenticationSchemes.Basic) != AuthenticationSchemes.None)
		{
			AddChallenge(ref challenges, "Basic realm=\"" + Realm + "\"");
		}
		return challenges;
	}

	private unsafe void RegisterForDisconnectNotification(ulong connectionId, ref DisconnectAsyncResult disconnectResult)
	{
		try
		{
			DisconnectAsyncResult disconnectAsyncResult = new DisconnectAsyncResult(this, connectionId);
			EnsureBoundHandle();
			uint num = UnsafeNclNativeMethods.HttpApi.HttpWaitForDisconnect(m_RequestQueueHandle, connectionId, disconnectAsyncResult.NativeOverlapped);
			if (num == 0 || num == 997)
			{
				disconnectResult = disconnectAsyncResult;
				DisconnectResults[connectionId] = disconnectResult;
			}
			if (num == 0 && SkipIOCPCallbackOnSuccess)
			{
				disconnectAsyncResult.IOCompleted(num, 0u, disconnectAsyncResult.NativeOverlapped);
			}
		}
		catch (Win32Exception ex)
		{
			uint nativeErrorCode = (uint)ex.NativeErrorCode;
		}
	}

	private unsafe void SendError(ulong requestId, HttpStatusCode httpStatusCode, ArrayList challenges)
	{
		UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE hTTP_RESPONSE = default(UnsafeNclNativeMethods.HttpApi.HTTP_RESPONSE);
		hTTP_RESPONSE.Version = default(UnsafeNclNativeMethods.HttpApi.HTTP_VERSION);
		hTTP_RESPONSE.Version.MajorVersion = 1;
		hTTP_RESPONSE.Version.MinorVersion = 1;
		hTTP_RESPONSE.StatusCode = (ushort)httpStatusCode;
		string s = HttpStatusDescription.Get(httpStatusCode);
		uint num = 0u;
		byte[] bytes = Encoding.Default.GetBytes(s);
		uint num2;
		fixed (byte* pReason = bytes)
		{
			hTTP_RESPONSE.pReason = (sbyte*)pReason;
			hTTP_RESPONSE.ReasonLength = (ushort)bytes.Length;
			byte[] bytes2 = Encoding.Default.GetBytes("0");
			fixed (byte* pRawValue = bytes2)
			{
				(&hTTP_RESPONSE.Headers.KnownHeaders)[11].pRawValue = (sbyte*)pRawValue;
				(&hTTP_RESPONSE.Headers.KnownHeaders)[11].RawValueLength = (ushort)bytes2.Length;
				hTTP_RESPONSE.Headers.UnknownHeaderCount = checked((ushort)(challenges?.Count ?? 0));
				GCHandle[] array = null;
				UnsafeNclNativeMethods.HttpApi.HTTP_UNKNOWN_HEADER[] array2 = null;
				GCHandle gCHandle = default(GCHandle);
				GCHandle gCHandle2 = default(GCHandle);
				if (hTTP_RESPONSE.Headers.UnknownHeaderCount > 0)
				{
					array = new GCHandle[hTTP_RESPONSE.Headers.UnknownHeaderCount];
					array2 = new UnsafeNclNativeMethods.HttpApi.HTTP_UNKNOWN_HEADER[hTTP_RESPONSE.Headers.UnknownHeaderCount];
				}
				try
				{
					if (hTTP_RESPONSE.Headers.UnknownHeaderCount > 0)
					{
						gCHandle = GCHandle.Alloc(array2, GCHandleType.Pinned);
						hTTP_RESPONSE.Headers.pUnknownHeaders = (UnsafeNclNativeMethods.HttpApi.HTTP_UNKNOWN_HEADER*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)array2, 0);
						gCHandle2 = GCHandle.Alloc(s_WwwAuthenticateBytes, GCHandleType.Pinned);
						sbyte* pName = (sbyte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)s_WwwAuthenticateBytes, 0);
						for (int i = 0; i < array.Length; i++)
						{
							byte[] bytes3 = Encoding.Default.GetBytes((string)challenges[i]);
							array[i] = GCHandle.Alloc(bytes3, GCHandleType.Pinned);
							array2[i].pName = pName;
							array2[i].NameLength = (ushort)s_WwwAuthenticateBytes.Length;
							array2[i].pRawValue = (sbyte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement((Array)bytes3, 0);
							array2[i].RawValueLength = checked((ushort)bytes3.Length);
						}
					}
					num2 = UnsafeNclNativeMethods.HttpApi.HttpSendHttpResponse(m_RequestQueueHandle, requestId, 0u, &hTTP_RESPONSE, null, &num, SafeLocalFree.Zero, 0u, null, null);
				}
				finally
				{
					if (gCHandle.IsAllocated)
					{
						gCHandle.Free();
					}
					if (gCHandle2.IsAllocated)
					{
						gCHandle2.Free();
					}
					if (array != null)
					{
						for (int j = 0; j < array.Length; j++)
						{
							if (array[j].IsAllocated)
							{
								array[j].Free();
							}
						}
					}
				}
			}
		}
		if (num2 != 0)
		{
			HttpListenerContext.CancelRequest(m_RequestQueueHandle, requestId);
		}
	}

	private static int GetTokenOffsetFromBlob(IntPtr blob)
	{
		IntPtr a = Marshal.ReadIntPtr(blob, (int)Marshal.OffsetOf(ChannelBindingStatusType, "ChannelToken"));
		return (int)IntPtrHelper.Subtract(a, blob);
	}

	private static int GetTokenSizeFromBlob(IntPtr blob)
	{
		return Marshal.ReadInt32(blob, (int)Marshal.OffsetOf(ChannelBindingStatusType, "ChannelTokenSize"));
	}

	internal unsafe ChannelBinding GetChannelBindingFromTls(ulong connectionId)
	{
		if (Logging.On)
		{
			Logging.Enter(Logging.HttpListener, "HttpListener#" + ValidationHelper.HashString(this) + "::GetChannelBindingFromTls() connectionId: " + connectionId);
		}
		int num = RequestChannelBindStatusSize + 128;
		byte[] array = null;
		SafeLocalFreeChannelBinding safeLocalFreeChannelBinding = null;
		uint num2 = 0u;
		uint num3;
		do
		{
			array = new byte[num];
			fixed (byte* ptr = array)
			{
				num3 = UnsafeNclNativeMethods.HttpApi.HttpReceiveClientCertificate(RequestQueueHandle, connectionId, 1u, ptr, (uint)num, &num2, null);
				switch (num3)
				{
				case 0u:
				{
					int tokenOffsetFromBlob = GetTokenOffsetFromBlob((IntPtr)ptr);
					int tokenSizeFromBlob = GetTokenSizeFromBlob((IntPtr)ptr);
					safeLocalFreeChannelBinding = SafeLocalFreeChannelBinding.LocalAlloc(tokenSizeFromBlob);
					if (safeLocalFreeChannelBinding.IsInvalid)
					{
						throw new OutOfMemoryException();
					}
					Marshal.Copy(array, tokenOffsetFromBlob, safeLocalFreeChannelBinding.DangerousGetHandle(), tokenSizeFromBlob);
					break;
				}
				case 234u:
				{
					int tokenSizeFromBlob2 = GetTokenSizeFromBlob((IntPtr)ptr);
					num = RequestChannelBindStatusSize + tokenSizeFromBlob2;
					break;
				}
				case 87u:
					if (Logging.On)
					{
						Logging.PrintError(Logging.HttpListener, "HttpListener#" + ValidationHelper.HashString(this) + "::GetChannelBindingFromTls() " + SR.GetString("net_ssp_dont_support_cbt"));
					}
					return null;
				default:
					throw new HttpListenerException((int)num3);
				}
			}
		}
		while (num3 != 0);
		return safeLocalFreeChannelBinding;
	}

	internal void CheckDisposed()
	{
		if (m_State == State.Closed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	private HttpStatusCode HttpStatusFromSecurityStatus(SecurityStatus status)
	{
		if (NclUtilities.IsCredentialFailure(status))
		{
			return HttpStatusCode.Unauthorized;
		}
		if (NclUtilities.IsClientFault(status))
		{
			return HttpStatusCode.BadRequest;
		}
		return HttpStatusCode.InternalServerError;
	}

	private void SaveDigestContext(NTAuthentication digestContext)
	{
		if (m_SavedDigests == null)
		{
			Interlocked.CompareExchange(ref m_SavedDigests, new DigestContext[1024], null);
		}
		NTAuthentication nTAuthentication = null;
		ArrayList arrayList = null;
		lock (m_SavedDigests)
		{
			if (!IsListening)
			{
				digestContext.CloseContext();
				return;
			}
			int num = (((num = Environment.TickCount) == 0) ? 1 : num);
			m_NewestContext = (m_NewestContext + 1) & 0x3FF;
			int timestamp = m_SavedDigests[m_NewestContext].timestamp;
			nTAuthentication = m_SavedDigests[m_NewestContext].context;
			m_SavedDigests[m_NewestContext].timestamp = num;
			m_SavedDigests[m_NewestContext].context = digestContext;
			if (m_OldestContext == m_NewestContext)
			{
				m_OldestContext = (m_NewestContext + 1) & 0x3FF;
			}
			while (num - m_SavedDigests[m_OldestContext].timestamp >= 300 && m_SavedDigests[m_OldestContext].context != null)
			{
				if (arrayList == null)
				{
					arrayList = new ArrayList();
				}
				arrayList.Add(m_SavedDigests[m_OldestContext].context);
				m_SavedDigests[m_OldestContext].context = null;
				m_OldestContext = (m_OldestContext + 1) & 0x3FF;
			}
			if (nTAuthentication != null && num - timestamp <= 10000)
			{
				if (m_ExtraSavedDigests == null || num - m_ExtraSavedDigestsTimestamp > 10000)
				{
					arrayList = m_ExtraSavedDigestsBaking;
					m_ExtraSavedDigestsBaking = m_ExtraSavedDigests;
					m_ExtraSavedDigestsTimestamp = num;
					m_ExtraSavedDigests = new ArrayList();
				}
				m_ExtraSavedDigests.Add(nTAuthentication);
				nTAuthentication = null;
			}
		}
		nTAuthentication?.CloseContext();
		if (arrayList != null)
		{
			for (int i = 0; i < arrayList.Count; i++)
			{
				((NTAuthentication)arrayList[i]).CloseContext();
			}
		}
	}

	private void ClearDigestCache()
	{
		if (m_SavedDigests == null)
		{
			return;
		}
		ArrayList[] array = new ArrayList[3];
		lock (m_SavedDigests)
		{
			array[0] = m_ExtraSavedDigestsBaking;
			m_ExtraSavedDigestsBaking = null;
			array[1] = m_ExtraSavedDigests;
			m_ExtraSavedDigests = null;
			m_NewestContext = 0;
			m_OldestContext = 0;
			array[2] = new ArrayList();
			for (int i = 0; i < 1024; i++)
			{
				if (m_SavedDigests[i].context != null)
				{
					array[2].Add(m_SavedDigests[i].context);
					m_SavedDigests[i].context = null;
				}
				m_SavedDigests[i].timestamp = 0;
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			if (array[j] != null)
			{
				for (int k = 0; k < array[j].Count; k++)
				{
					((NTAuthentication)array[j][k]).CloseContext();
				}
			}
		}
	}
}
