using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Security.Claims;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Principal;

[Serializable]
[ComVisible(true)]
public class WindowsIdentity : ClaimsIdentity, ISerializable, IDeserializationCallback, IDisposable
{
	[SecurityCritical]
	private static SafeAccessTokenHandle s_invalidTokenHandle;

	private string m_name;

	private SecurityIdentifier m_owner;

	private SecurityIdentifier m_user;

	private object m_groups;

	[SecurityCritical]
	private SafeAccessTokenHandle m_safeTokenHandle = SafeAccessTokenHandle.InvalidHandle;

	private string m_authType;

	private int m_isAuthenticated = -1;

	private volatile TokenImpersonationLevel m_impersonationLevel;

	private volatile bool m_impersonationLevelInitialized;

	private static RuntimeConstructorInfo s_specialSerializationCtor;

	[NonSerialized]
	public new const string DefaultIssuer = "AD AUTHORITY";

	[NonSerialized]
	private string m_issuerName = "AD AUTHORITY";

	[NonSerialized]
	private object m_claimsIntiailizedLock = new object();

	[NonSerialized]
	private volatile bool m_claimsInitialized;

	[NonSerialized]
	private List<Claim> m_deviceClaims;

	[NonSerialized]
	private List<Claim> m_userClaims;

	public sealed override string AuthenticationType
	{
		[SecuritySafeCritical]
		get
		{
			if (m_safeTokenHandle.IsInvalid)
			{
				return string.Empty;
			}
			if (m_authType == null)
			{
				Win32Native.LUID LogonId = GetLogonAuthId(m_safeTokenHandle);
				if (LogonId.LowPart == 998)
				{
					return string.Empty;
				}
				SafeLsaReturnBufferHandle ppLogonSessionData = SafeLsaReturnBufferHandle.InvalidHandle;
				try
				{
					int num = Win32Native.LsaGetLogonSessionData(ref LogonId, ref ppLogonSessionData);
					if (num < 0)
					{
						throw GetExceptionFromNtStatus(num);
					}
					ppLogonSessionData.Initialize((uint)Marshal.SizeOf(typeof(Win32Native.SECURITY_LOGON_SESSION_DATA)));
					return Marshal.PtrToStringUni(ppLogonSessionData.Read<Win32Native.SECURITY_LOGON_SESSION_DATA>(0uL).AuthenticationPackage.Buffer);
				}
				finally
				{
					if (!ppLogonSessionData.IsInvalid)
					{
						ppLogonSessionData.Dispose();
					}
				}
			}
			return m_authType;
		}
	}

	[ComVisible(false)]
	public TokenImpersonationLevel ImpersonationLevel
	{
		[SecuritySafeCritical]
		get
		{
			if (!m_impersonationLevelInitialized)
			{
				TokenImpersonationLevel tokenImpersonationLevel = TokenImpersonationLevel.None;
				if (m_safeTokenHandle.IsInvalid)
				{
					tokenImpersonationLevel = TokenImpersonationLevel.Anonymous;
				}
				else
				{
					TokenType tokenInformation = (TokenType)GetTokenInformation<int>(TokenInformationClass.TokenType);
					if (tokenInformation == TokenType.TokenPrimary)
					{
						tokenImpersonationLevel = TokenImpersonationLevel.None;
					}
					else
					{
						int tokenInformation2 = GetTokenInformation<int>(TokenInformationClass.TokenImpersonationLevel);
						tokenImpersonationLevel = (TokenImpersonationLevel)(tokenInformation2 + 1);
					}
				}
				m_impersonationLevel = tokenImpersonationLevel;
				m_impersonationLevelInitialized = true;
			}
			return m_impersonationLevel;
		}
	}

	public override bool IsAuthenticated
	{
		get
		{
			if (m_isAuthenticated == -1)
			{
				m_isAuthenticated = (CheckNtTokenForSid(new SecurityIdentifier(IdentifierAuthority.NTAuthority, new int[1] { 11 })) ? 1 : 0);
			}
			return m_isAuthenticated == 1;
		}
	}

	public virtual bool IsGuest
	{
		[SecuritySafeCritical]
		get
		{
			if (m_safeTokenHandle.IsInvalid)
			{
				return false;
			}
			return CheckNtTokenForSid(new SecurityIdentifier(IdentifierAuthority.NTAuthority, new int[2] { 32, 546 }));
		}
	}

	public virtual bool IsSystem
	{
		[SecuritySafeCritical]
		get
		{
			if (m_safeTokenHandle.IsInvalid)
			{
				return false;
			}
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(IdentifierAuthority.NTAuthority, new int[1] { 18 });
			return User == securityIdentifier;
		}
	}

	public virtual bool IsAnonymous
	{
		[SecuritySafeCritical]
		get
		{
			if (m_safeTokenHandle.IsInvalid)
			{
				return true;
			}
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(IdentifierAuthority.NTAuthority, new int[1] { 7 });
			return User == securityIdentifier;
		}
	}

	public override string Name
	{
		[SecuritySafeCritical]
		get
		{
			return GetName();
		}
	}

	[ComVisible(false)]
	public SecurityIdentifier Owner
	{
		[SecuritySafeCritical]
		get
		{
			if (m_safeTokenHandle.IsInvalid)
			{
				return null;
			}
			if (m_owner == null)
			{
				using SafeLocalAllocHandle safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, TokenInformationClass.TokenOwner);
				m_owner = new SecurityIdentifier(safeLocalAllocHandle.Read<IntPtr>(0uL), noDemand: true);
			}
			return m_owner;
		}
	}

	[ComVisible(false)]
	public SecurityIdentifier User
	{
		[SecuritySafeCritical]
		get
		{
			if (m_safeTokenHandle.IsInvalid)
			{
				return null;
			}
			if (m_user == null)
			{
				using SafeLocalAllocHandle safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, TokenInformationClass.TokenUser);
				m_user = new SecurityIdentifier(safeLocalAllocHandle.Read<IntPtr>(0uL), noDemand: true);
			}
			return m_user;
		}
	}

	public IdentityReferenceCollection Groups
	{
		[SecuritySafeCritical]
		get
		{
			if (m_safeTokenHandle.IsInvalid)
			{
				return null;
			}
			if (m_groups == null)
			{
				IdentityReferenceCollection identityReferenceCollection = new IdentityReferenceCollection();
				using (SafeLocalAllocHandle safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, TokenInformationClass.TokenGroups))
				{
					if (safeLocalAllocHandle.Read<uint>(0uL) != 0)
					{
						Win32Native.SID_AND_ATTRIBUTES[] array = new Win32Native.SID_AND_ATTRIBUTES[safeLocalAllocHandle.Read<Win32Native.TOKEN_GROUPS>(0uL).GroupCount];
						safeLocalAllocHandle.ReadArray((uint)Marshal.OffsetOf(typeof(Win32Native.TOKEN_GROUPS), "Groups").ToInt32(), array, 0, array.Length);
						Win32Native.SID_AND_ATTRIBUTES[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							Win32Native.SID_AND_ATTRIBUTES sID_AND_ATTRIBUTES = array2[i];
							uint num = 3221225492u;
							if ((sID_AND_ATTRIBUTES.Attributes & num) == 4)
							{
								identityReferenceCollection.Add(new SecurityIdentifier(sID_AND_ATTRIBUTES.Sid, noDemand: true));
							}
						}
					}
				}
				Interlocked.CompareExchange(ref m_groups, identityReferenceCollection, null);
			}
			return m_groups as IdentityReferenceCollection;
		}
	}

	public virtual IntPtr Token
	{
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		get
		{
			return m_safeTokenHandle.DangerousGetHandle();
		}
	}

	public SafeAccessTokenHandle AccessToken
	{
		[SecurityCritical]
		get
		{
			return m_safeTokenHandle;
		}
	}

	public virtual IEnumerable<Claim> UserClaims
	{
		get
		{
			InitializeClaims();
			return m_userClaims.AsReadOnly();
		}
	}

	public virtual IEnumerable<Claim> DeviceClaims
	{
		get
		{
			InitializeClaims();
			return m_deviceClaims.AsReadOnly();
		}
	}

	public override IEnumerable<Claim> Claims
	{
		get
		{
			if (!m_claimsInitialized)
			{
				InitializeClaims();
			}
			foreach (Claim claim in base.Claims)
			{
				yield return claim;
			}
			foreach (Claim userClaim in m_userClaims)
			{
				yield return userClaim;
			}
			foreach (Claim deviceClaim in m_deviceClaims)
			{
				yield return deviceClaim;
			}
		}
	}

	[SecuritySafeCritical]
	static WindowsIdentity()
	{
		s_invalidTokenHandle = SafeAccessTokenHandle.InvalidHandle;
		s_specialSerializationCtor = typeof(WindowsIdentity).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[1] { typeof(SerializationInfo) }, null) as RuntimeConstructorInfo;
	}

	[SecurityCritical]
	private WindowsIdentity()
		: base(null, null, null, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid")
	{
	}

	[SecurityCritical]
	internal WindowsIdentity(SafeAccessTokenHandle safeTokenHandle)
		: this(safeTokenHandle.DangerousGetHandle(), null, -1)
	{
		GC.KeepAlive(safeTokenHandle);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public WindowsIdentity(IntPtr userToken)
		: this(userToken, null, -1)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public WindowsIdentity(IntPtr userToken, string type)
		: this(userToken, type, -1)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType)
		: this(userToken, type, -1)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
		: this(userToken, type, isAuthenticated ? 1 : 0)
	{
	}

	[SecurityCritical]
	private WindowsIdentity(IntPtr userToken, string authType, int isAuthenticated)
		: base(null, null, null, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid")
	{
		CreateFromToken(userToken);
		m_authType = authType;
		m_isAuthenticated = isAuthenticated;
	}

	[SecurityCritical]
	private void CreateFromToken(IntPtr userToken)
	{
		if (userToken == IntPtr.Zero)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_TokenZero"));
		}
		uint ReturnLength = (uint)Marshal.SizeOf(typeof(uint));
		bool tokenInformation = Win32Native.GetTokenInformation(userToken, 8u, SafeLocalAllocHandle.InvalidHandle, 0u, out ReturnLength);
		if (Marshal.GetLastWin32Error() == 6)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidImpersonationToken"));
		}
		if (!Win32Native.DuplicateHandle(Win32Native.GetCurrentProcess(), userToken, Win32Native.GetCurrentProcess(), ref m_safeTokenHandle, 0u, bInheritHandle: true, 2u))
		{
			throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
		}
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public WindowsIdentity(string sUserPrincipalName)
		: this(sUserPrincipalName, null)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public WindowsIdentity(string sUserPrincipalName, string type)
		: base(null, null, null, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name", "http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid")
	{
		KerbS4ULogon(sUserPrincipalName, ref m_safeTokenHandle);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public WindowsIdentity(SerializationInfo info, StreamingContext context)
		: this(info)
	{
	}

	[SecurityCritical]
	private WindowsIdentity(SerializationInfo info)
		: base(info)
	{
		m_claimsInitialized = false;
		IntPtr intPtr = (IntPtr)info.GetValue("m_userToken", typeof(IntPtr));
		if (intPtr != IntPtr.Zero)
		{
			CreateFromToken(intPtr);
		}
	}

	[SecurityCritical]
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("m_userToken", m_safeTokenHandle.DangerousGetHandle());
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public static WindowsIdentity GetCurrent()
	{
		return GetCurrentInternal(TokenAccessLevels.MaximumAllowed, threadOnly: false);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public static WindowsIdentity GetCurrent(bool ifImpersonating)
	{
		return GetCurrentInternal(TokenAccessLevels.MaximumAllowed, ifImpersonating);
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
	public static WindowsIdentity GetCurrent(TokenAccessLevels desiredAccess)
	{
		return GetCurrentInternal(desiredAccess, threadOnly: false);
	}

	[SecuritySafeCritical]
	public static WindowsIdentity GetAnonymous()
	{
		return new WindowsIdentity();
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	private bool CheckNtTokenForSid(SecurityIdentifier sid)
	{
		if (m_safeTokenHandle.IsInvalid)
		{
			return false;
		}
		SafeAccessTokenHandle phNewToken = SafeAccessTokenHandle.InvalidHandle;
		TokenImpersonationLevel impersonationLevel = ImpersonationLevel;
		bool IsMember = false;
		try
		{
			if (impersonationLevel == TokenImpersonationLevel.None && !Win32Native.DuplicateTokenEx(m_safeTokenHandle, 8u, IntPtr.Zero, 2u, 2u, ref phNewToken))
			{
				throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
			}
			if (!Win32Native.CheckTokenMembership((impersonationLevel != TokenImpersonationLevel.None) ? m_safeTokenHandle : phNewToken, sid.BinaryForm, ref IsMember))
			{
				throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
			}
			return IsMember;
		}
		finally
		{
			if (phNewToken != SafeAccessTokenHandle.InvalidHandle)
			{
				phNewToken.Dispose();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	internal string GetName()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		if (m_safeTokenHandle.IsInvalid)
		{
			return string.Empty;
		}
		if (m_name == null)
		{
			using (SafeRevertToSelf(ref stackMark))
			{
				NTAccount nTAccount = User.Translate(typeof(NTAccount)) as NTAccount;
				m_name = nTAccount.ToString();
			}
		}
		return m_name;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static void RunImpersonated(SafeAccessTokenHandle safeAccessTokenHandle, Action action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		WindowsIdentity wi = null;
		if (!safeAccessTokenHandle.IsInvalid)
		{
			wi = new WindowsIdentity(safeAccessTokenHandle);
		}
		using (SafeImpersonate(safeAccessTokenHandle, wi, ref stackMark))
		{
			action();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static T RunImpersonated<T>(SafeAccessTokenHandle safeAccessTokenHandle, Func<T> func)
	{
		if (func == null)
		{
			throw new ArgumentNullException("func");
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		WindowsIdentity wi = null;
		if (!safeAccessTokenHandle.IsInvalid)
		{
			wi = new WindowsIdentity(safeAccessTokenHandle);
		}
		T val = default(T);
		using (SafeImpersonate(safeAccessTokenHandle, wi, ref stackMark))
		{
			return func();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public virtual WindowsImpersonationContext Impersonate()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Impersonate(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, Flags = (SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.ControlPrincipal))]
	public static WindowsImpersonationContext Impersonate(IntPtr userToken)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		if (userToken == IntPtr.Zero)
		{
			return SafeRevertToSelf(ref stackMark);
		}
		WindowsIdentity windowsIdentity = new WindowsIdentity(userToken, null, -1);
		return windowsIdentity.Impersonate(ref stackMark);
	}

	[SecurityCritical]
	internal WindowsImpersonationContext Impersonate(ref StackCrawlMark stackMark)
	{
		if (m_safeTokenHandle.IsInvalid)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_AnonymousCannotImpersonate"));
		}
		return SafeImpersonate(m_safeTokenHandle, this, ref stackMark);
	}

	[SecuritySafeCritical]
	[ComVisible(false)]
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && m_safeTokenHandle != null && !m_safeTokenHandle.IsClosed)
		{
			m_safeTokenHandle.Dispose();
		}
		m_name = null;
		m_owner = null;
		m_user = null;
	}

	[ComVisible(false)]
	public void Dispose()
	{
		Dispose(disposing: true);
	}

	[SecurityCritical]
	internal static WindowsImpersonationContext SafeRevertToSelf(ref StackCrawlMark stackMark)
	{
		return SafeImpersonate(s_invalidTokenHandle, null, ref stackMark);
	}

	[SecurityCritical]
	internal static WindowsImpersonationContext SafeImpersonate(SafeAccessTokenHandle userToken, WindowsIdentity wi, ref StackCrawlMark stackMark)
	{
		int hr = 0;
		bool isImpersonating;
		SafeAccessTokenHandle currentToken = GetCurrentToken(TokenAccessLevels.MaximumAllowed, threadOnly: false, out isImpersonating, out hr);
		if (currentToken == null || currentToken.IsInvalid)
		{
			throw new SecurityException(Win32Native.GetMessage(hr));
		}
		FrameSecurityDescriptor securityObjectForFrame = SecurityRuntime.GetSecurityObjectForFrame(ref stackMark, create: true);
		if (securityObjectForFrame == null)
		{
			throw new SecurityException(Environment.GetResourceString("ExecutionEngine_MissingSecurityDescriptor"));
		}
		WindowsImpersonationContext windowsImpersonationContext = new WindowsImpersonationContext(currentToken, GetCurrentThreadWI(), isImpersonating, securityObjectForFrame);
		if (userToken.IsInvalid)
		{
			hr = Win32.RevertToSelf();
			if (hr < 0)
			{
				Environment.FailFast(Win32Native.GetMessage(hr));
			}
			UpdateThreadWI(wi);
			securityObjectForFrame.SetTokenHandles(currentToken, wi?.AccessToken);
		}
		else
		{
			hr = Win32.RevertToSelf();
			if (hr < 0)
			{
				Environment.FailFast(Win32Native.GetMessage(hr));
			}
			hr = Win32.ImpersonateLoggedOnUser(userToken);
			if (hr < 0)
			{
				windowsImpersonationContext.Undo();
				throw new SecurityException(Environment.GetResourceString("Argument_ImpersonateUser"));
			}
			UpdateThreadWI(wi);
			securityObjectForFrame.SetTokenHandles(currentToken, wi?.AccessToken);
		}
		return windowsImpersonationContext;
	}

	[SecurityCritical]
	internal static WindowsIdentity GetCurrentThreadWI()
	{
		return SecurityContext.GetCurrentWI(Thread.CurrentThread.GetExecutionContextReader());
	}

	[SecurityCritical]
	internal static void UpdateThreadWI(WindowsIdentity wi)
	{
		Thread currentThread = Thread.CurrentThread;
		if (currentThread.GetExecutionContextReader().SecurityContext.WindowsIdentity != wi)
		{
			ExecutionContext mutableExecutionContext = currentThread.GetMutableExecutionContext();
			SecurityContext securityContext = mutableExecutionContext.SecurityContext;
			if (wi != null && securityContext == null)
			{
				securityContext = (mutableExecutionContext.SecurityContext = new SecurityContext());
			}
			if (securityContext != null)
			{
				securityContext.WindowsIdentity = wi;
			}
		}
	}

	[SecurityCritical]
	internal static WindowsIdentity GetCurrentInternal(TokenAccessLevels desiredAccess, bool threadOnly)
	{
		int hr = 0;
		bool isImpersonating;
		SafeAccessTokenHandle currentToken = GetCurrentToken(desiredAccess, threadOnly, out isImpersonating, out hr);
		if (currentToken == null || currentToken.IsInvalid)
		{
			if (threadOnly && !isImpersonating)
			{
				return null;
			}
			throw new SecurityException(Win32Native.GetMessage(hr));
		}
		WindowsIdentity windowsIdentity = new WindowsIdentity();
		windowsIdentity.m_safeTokenHandle.Dispose();
		windowsIdentity.m_safeTokenHandle = currentToken;
		return windowsIdentity;
	}

	internal static RuntimeConstructorInfo GetSpecialSerializationCtor()
	{
		return s_specialSerializationCtor;
	}

	private static int GetHRForWin32Error(int dwLastError)
	{
		if ((dwLastError & 0x80000000u) == 2147483648u)
		{
			return dwLastError;
		}
		return (dwLastError & 0xFFFF) | -2147024896;
	}

	[SecurityCritical]
	private static Exception GetExceptionFromNtStatus(int status)
	{
		switch (status)
		{
		case -1073741790:
			return new UnauthorizedAccessException();
		case -1073741801:
		case -1073741670:
			return new OutOfMemoryException();
		default:
		{
			int errorCode = Win32Native.LsaNtStatusToWinError(status);
			return new SecurityException(Win32Native.GetMessage(errorCode));
		}
		}
	}

	[SecurityCritical]
	private static SafeAccessTokenHandle GetCurrentToken(TokenAccessLevels desiredAccess, bool threadOnly, out bool isImpersonating, out int hr)
	{
		isImpersonating = true;
		SafeAccessTokenHandle safeAccessTokenHandle = GetCurrentThreadToken(desiredAccess, out hr);
		if (safeAccessTokenHandle == null && hr == GetHRForWin32Error(1008))
		{
			isImpersonating = false;
			if (!threadOnly)
			{
				safeAccessTokenHandle = GetCurrentProcessToken(desiredAccess, out hr);
			}
		}
		return safeAccessTokenHandle;
	}

	[SecurityCritical]
	private static SafeAccessTokenHandle GetCurrentProcessToken(TokenAccessLevels desiredAccess, out int hr)
	{
		hr = 0;
		if (!Win32Native.OpenProcessToken(Win32Native.GetCurrentProcess(), desiredAccess, out var TokenHandle))
		{
			hr = GetHRForWin32Error(Marshal.GetLastWin32Error());
		}
		return TokenHandle;
	}

	[SecurityCritical]
	internal static SafeAccessTokenHandle GetCurrentThreadToken(TokenAccessLevels desiredAccess, out int hr)
	{
		hr = Win32.OpenThreadToken(desiredAccess, WinSecurityContext.Both, out var phThreadToken);
		return phThreadToken;
	}

	[SecurityCritical]
	private T GetTokenInformation<T>(TokenInformationClass tokenInformationClass) where T : struct
	{
		using SafeLocalAllocHandle safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, tokenInformationClass);
		return safeLocalAllocHandle.Read<T>(0uL);
	}

	[SecurityCritical]
	internal static ImpersonationQueryResult QueryImpersonation()
	{
		SafeAccessTokenHandle phThreadToken = null;
		int num = Win32.OpenThreadToken(TokenAccessLevels.Query, WinSecurityContext.Thread, out phThreadToken);
		if (phThreadToken != null)
		{
			phThreadToken.Close();
			return ImpersonationQueryResult.Impersonated;
		}
		if (num == GetHRForWin32Error(5))
		{
			return ImpersonationQueryResult.Impersonated;
		}
		if (num == GetHRForWin32Error(1008))
		{
			return ImpersonationQueryResult.NotImpersonated;
		}
		return ImpersonationQueryResult.Failed;
	}

	[SecurityCritical]
	private static Win32Native.LUID GetLogonAuthId(SafeAccessTokenHandle safeTokenHandle)
	{
		using SafeLocalAllocHandle safeLocalAllocHandle = GetTokenInformation(safeTokenHandle, TokenInformationClass.TokenStatistics);
		return safeLocalAllocHandle.Read<Win32Native.TOKEN_STATISTICS>(0uL).AuthenticationId;
	}

	[SecurityCritical]
	private static SafeLocalAllocHandle GetTokenInformation(SafeAccessTokenHandle tokenHandle, TokenInformationClass tokenInformationClass)
	{
		SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
		uint ReturnLength = (uint)Marshal.SizeOf(typeof(uint));
		bool tokenInformation = Win32Native.GetTokenInformation(tokenHandle, (uint)tokenInformationClass, invalidHandle, 0u, out ReturnLength);
		int lastWin32Error = Marshal.GetLastWin32Error();
		switch (lastWin32Error)
		{
		case 24:
		case 122:
		{
			UIntPtr sizetdwBytes = new UIntPtr(ReturnLength);
			invalidHandle.Dispose();
			invalidHandle = Win32Native.LocalAlloc(0, sizetdwBytes);
			if (invalidHandle == null || invalidHandle.IsInvalid)
			{
				throw new OutOfMemoryException();
			}
			invalidHandle.Initialize(ReturnLength);
			if (!Win32Native.GetTokenInformation(tokenHandle, (uint)tokenInformationClass, invalidHandle, ReturnLength, out ReturnLength))
			{
				throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
			}
			return invalidHandle;
		}
		case 6:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidImpersonationToken"));
		default:
			throw new SecurityException(Win32Native.GetMessage(lastWin32Error));
		}
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	private unsafe static SafeAccessTokenHandle KerbS4ULogon(string upn, ref SafeAccessTokenHandle safeTokenHandle)
	{
		byte[] array = new byte[3] { 67, 76, 82 };
		UIntPtr sizetdwBytes = new UIntPtr((uint)(array.Length + 1));
		using SafeLocalAllocHandle safeLocalAllocHandle = Win32Native.LocalAlloc(64, sizetdwBytes);
		if (safeLocalAllocHandle == null || safeLocalAllocHandle.IsInvalid)
		{
			throw new OutOfMemoryException();
		}
		safeLocalAllocHandle.Initialize((ulong)array.Length + 1uL);
		safeLocalAllocHandle.WriteArray(0uL, array, 0, array.Length);
		Win32Native.UNICODE_INTPTR_STRING LogonProcessName = new Win32Native.UNICODE_INTPTR_STRING(array.Length, safeLocalAllocHandle);
		SafeLsaLogonProcessHandle LsaHandle = SafeLsaLogonProcessHandle.InvalidHandle;
		SafeLsaReturnBufferHandle ProfileBuffer = SafeLsaReturnBufferHandle.InvalidHandle;
		try
		{
			Privilege privilege = null;
			RuntimeHelpers.PrepareConstrainedRegions();
			int num;
			try
			{
				try
				{
					privilege = new Privilege("SeTcbPrivilege");
					privilege.Enable();
				}
				catch (PrivilegeNotHeldException)
				{
				}
				IntPtr SecurityMode = IntPtr.Zero;
				num = Win32Native.LsaRegisterLogonProcess(ref LogonProcessName, ref LsaHandle, ref SecurityMode);
				if (5 == Win32Native.LsaNtStatusToWinError(num))
				{
					num = Win32Native.LsaConnectUntrusted(ref LsaHandle);
				}
			}
			catch
			{
				privilege?.Revert();
				throw;
			}
			finally
			{
				privilege?.Revert();
			}
			if (num < 0)
			{
				throw GetExceptionFromNtStatus(num);
			}
			byte[] array2 = new byte["Kerberos".Length + 1];
			Encoding.ASCII.GetBytes("Kerberos", 0, "Kerberos".Length, array2, 0);
			sizetdwBytes = new UIntPtr((uint)array2.Length);
			using SafeLocalAllocHandle safeLocalAllocHandle2 = Win32Native.LocalAlloc(0, sizetdwBytes);
			if (safeLocalAllocHandle2 == null || safeLocalAllocHandle2.IsInvalid)
			{
				throw new OutOfMemoryException();
			}
			safeLocalAllocHandle2.Initialize((uint)array2.Length);
			safeLocalAllocHandle2.WriteArray(0uL, array2, 0, array2.Length);
			Win32Native.UNICODE_INTPTR_STRING PackageName = new Win32Native.UNICODE_INTPTR_STRING("Kerberos".Length, safeLocalAllocHandle2);
			uint AuthenticationPackage = 0u;
			num = Win32Native.LsaLookupAuthenticationPackage(LsaHandle, ref PackageName, ref AuthenticationPackage);
			if (num < 0)
			{
				throw GetExceptionFromNtStatus(num);
			}
			Win32Native.TOKEN_SOURCE SourceContext = default(Win32Native.TOKEN_SOURCE);
			if (!Win32Native.AllocateLocallyUniqueId(ref SourceContext.SourceIdentifier))
			{
				throw new SecurityException(Win32Native.GetMessage(Marshal.GetLastWin32Error()));
			}
			SourceContext.Name = new char[8];
			SourceContext.Name[0] = 'C';
			SourceContext.Name[1] = 'L';
			SourceContext.Name[2] = 'R';
			uint ProfileBufferLength = 0u;
			Win32Native.LUID LogonId = default(Win32Native.LUID);
			Win32Native.QUOTA_LIMITS Quotas = default(Win32Native.QUOTA_LIMITS);
			int SubStatus = 0;
			byte[] bytes = Encoding.Unicode.GetBytes(upn);
			uint num2 = (uint)(Marshal.SizeOf(typeof(Win32Native.KERB_S4U_LOGON)) + bytes.Length);
			using (SafeLocalAllocHandle safeLocalAllocHandle3 = Win32Native.LocalAlloc(64, new UIntPtr(num2)))
			{
				if (safeLocalAllocHandle3 == null || safeLocalAllocHandle3.IsInvalid)
				{
					throw new OutOfMemoryException();
				}
				safeLocalAllocHandle3.Initialize(num2);
				ulong num3 = (ulong)Marshal.SizeOf(typeof(Win32Native.KERB_S4U_LOGON));
				safeLocalAllocHandle3.WriteArray(num3, bytes, 0, bytes.Length);
				byte* pointer = null;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
					safeLocalAllocHandle3.AcquirePointer(ref pointer);
					safeLocalAllocHandle3.Write(0uL, new Win32Native.KERB_S4U_LOGON
					{
						MessageType = 12u,
						Flags = 0u,
						ClientUpn = new Win32Native.UNICODE_INTPTR_STRING(bytes.Length, new IntPtr(pointer + num3))
					});
					num = Win32Native.LsaLogonUser(LsaHandle, ref LogonProcessName, 3u, AuthenticationPackage, new IntPtr(pointer), (uint)safeLocalAllocHandle3.ByteLength, IntPtr.Zero, ref SourceContext, ref ProfileBuffer, ref ProfileBufferLength, ref LogonId, ref safeTokenHandle, ref Quotas, ref SubStatus);
					if (num == -1073741714 && SubStatus < 0)
					{
						num = SubStatus;
					}
					if (num < 0)
					{
						throw GetExceptionFromNtStatus(num);
					}
					if (SubStatus < 0)
					{
						throw GetExceptionFromNtStatus(SubStatus);
					}
				}
				finally
				{
					if (pointer != null)
					{
						safeLocalAllocHandle3.ReleasePointer();
					}
				}
			}
			return safeTokenHandle;
		}
		finally
		{
			if (!LsaHandle.IsInvalid)
			{
				LsaHandle.Dispose();
			}
			if (!ProfileBuffer.IsInvalid)
			{
				ProfileBuffer.Dispose();
			}
		}
	}

	[SecuritySafeCritical]
	protected WindowsIdentity(WindowsIdentity identity)
		: base(identity, null, identity.m_authType, null, null, checkAuthType: false)
	{
		if (identity == null)
		{
			throw new ArgumentNullException("identity");
		}
		bool success = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			if (!identity.m_safeTokenHandle.IsInvalid && identity.m_safeTokenHandle != SafeAccessTokenHandle.InvalidHandle && identity.m_safeTokenHandle.DangerousGetHandle() != IntPtr.Zero)
			{
				identity.m_safeTokenHandle.DangerousAddRef(ref success);
				if (!identity.m_safeTokenHandle.IsInvalid && identity.m_safeTokenHandle.DangerousGetHandle() != IntPtr.Zero)
				{
					CreateFromToken(identity.m_safeTokenHandle.DangerousGetHandle());
				}
				m_authType = identity.m_authType;
				m_isAuthenticated = identity.m_isAuthenticated;
			}
		}
		finally
		{
			if (success)
			{
				identity.m_safeTokenHandle.DangerousRelease();
			}
		}
	}

	[SecurityCritical]
	internal IntPtr GetTokenInternal()
	{
		return m_safeTokenHandle.DangerousGetHandle();
	}

	[SecurityCritical]
	internal WindowsIdentity(ClaimsIdentity claimsIdentity, IntPtr userToken)
		: base(claimsIdentity)
	{
		if (userToken != IntPtr.Zero && userToken.ToInt64() > 0)
		{
			CreateFromToken(userToken);
		}
	}

	internal ClaimsIdentity CloneAsBase()
	{
		return base.Clone();
	}

	public override ClaimsIdentity Clone()
	{
		return new WindowsIdentity(this);
	}

	[SecuritySafeCritical]
	private void InitializeClaims()
	{
		if (m_claimsInitialized)
		{
			return;
		}
		lock (m_claimsIntiailizedLock)
		{
			if (!m_claimsInitialized)
			{
				m_userClaims = new List<Claim>();
				m_deviceClaims = new List<Claim>();
				if (!string.IsNullOrEmpty(Name))
				{
					m_userClaims.Add(new Claim(base.NameClaimType, Name, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this));
				}
				AddPrimarySidClaim(m_userClaims);
				AddGroupSidClaims(m_userClaims);
				if (Environment.IsWindows8OrAbove)
				{
					AddDeviceGroupSidClaims(m_deviceClaims, TokenInformationClass.TokenDeviceGroups);
					AddTokenClaims(m_userClaims, TokenInformationClass.TokenUserClaimAttributes, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsuserclaim");
					AddTokenClaims(m_deviceClaims, TokenInformationClass.TokenDeviceClaimAttributes, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdeviceclaim");
				}
				m_claimsInitialized = true;
			}
		}
	}

	[SecurityCritical]
	private void AddDeviceGroupSidClaims(List<Claim> instanceClaims, TokenInformationClass tokenInformationClass)
	{
		if (m_safeTokenHandle.IsInvalid)
		{
			return;
		}
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		try
		{
			safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, tokenInformationClass);
			int num = Marshal.ReadInt32(safeLocalAllocHandle.DangerousGetHandle());
			IntPtr intPtr = new IntPtr((long)safeLocalAllocHandle.DangerousGetHandle() + (long)Marshal.OffsetOf(typeof(Win32Native.TOKEN_GROUPS), "Groups"));
			string text = null;
			for (int i = 0; i < num; i++)
			{
				Win32Native.SID_AND_ATTRIBUTES sID_AND_ATTRIBUTES = (Win32Native.SID_AND_ATTRIBUTES)Marshal.PtrToStructure(intPtr, typeof(Win32Native.SID_AND_ATTRIBUTES));
				uint num2 = 3221225492u;
				SecurityIdentifier securityIdentifier = new SecurityIdentifier(sID_AND_ATTRIBUTES.Sid, noDemand: true);
				if ((sID_AND_ATTRIBUTES.Attributes & num2) == 4)
				{
					text = "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowsdevicegroup";
					Claim claim = new Claim(text, securityIdentifier.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier.IdentifierAuthority, CultureInfo.InvariantCulture));
					claim.Properties.Add(text, "");
					instanceClaims.Add(claim);
				}
				else if ((sID_AND_ATTRIBUTES.Attributes & num2) == 16)
				{
					text = "http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlywindowsdevicegroup";
					Claim claim2 = new Claim(text, securityIdentifier.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier.IdentifierAuthority, CultureInfo.InvariantCulture));
					claim2.Properties.Add(text, "");
					instanceClaims.Add(claim2);
				}
				intPtr = new IntPtr((long)intPtr + Win32Native.SID_AND_ATTRIBUTES.SizeOf);
			}
		}
		finally
		{
			safeLocalAllocHandle.Close();
		}
	}

	[SecurityCritical]
	private void AddGroupSidClaims(List<Claim> instanceClaims)
	{
		if (m_safeTokenHandle.IsInvalid)
		{
			return;
		}
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		SafeLocalAllocHandle safeLocalAllocHandle2 = SafeLocalAllocHandle.InvalidHandle;
		try
		{
			safeLocalAllocHandle2 = GetTokenInformation(m_safeTokenHandle, TokenInformationClass.TokenPrimaryGroup);
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(((Win32Native.TOKEN_PRIMARY_GROUP)Marshal.PtrToStructure(safeLocalAllocHandle2.DangerousGetHandle(), typeof(Win32Native.TOKEN_PRIMARY_GROUP))).PrimaryGroup, noDemand: true);
			bool flag = false;
			safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, TokenInformationClass.TokenGroups);
			int num = Marshal.ReadInt32(safeLocalAllocHandle.DangerousGetHandle());
			IntPtr intPtr = new IntPtr((long)safeLocalAllocHandle.DangerousGetHandle() + (long)Marshal.OffsetOf(typeof(Win32Native.TOKEN_GROUPS), "Groups"));
			for (int i = 0; i < num; i++)
			{
				Win32Native.SID_AND_ATTRIBUTES sID_AND_ATTRIBUTES = (Win32Native.SID_AND_ATTRIBUTES)Marshal.PtrToStructure(intPtr, typeof(Win32Native.SID_AND_ATTRIBUTES));
				uint num2 = 3221225492u;
				SecurityIdentifier securityIdentifier2 = new SecurityIdentifier(sID_AND_ATTRIBUTES.Sid, noDemand: true);
				if ((sID_AND_ATTRIBUTES.Attributes & num2) == 4)
				{
					if (!flag && StringComparer.Ordinal.Equals(securityIdentifier2.Value, securityIdentifier.Value))
					{
						instanceClaims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid", securityIdentifier2.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier2.IdentifierAuthority, CultureInfo.InvariantCulture)));
						flag = true;
					}
					instanceClaims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/groupsid", securityIdentifier2.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier2.IdentifierAuthority, CultureInfo.InvariantCulture)));
				}
				else if ((sID_AND_ATTRIBUTES.Attributes & num2) == 16)
				{
					if (!flag && StringComparer.Ordinal.Equals(securityIdentifier2.Value, securityIdentifier.Value))
					{
						instanceClaims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarygroupsid", securityIdentifier2.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier2.IdentifierAuthority, CultureInfo.InvariantCulture)));
						flag = true;
					}
					instanceClaims.Add(new Claim("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/denyonlysid", securityIdentifier2.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier2.IdentifierAuthority, CultureInfo.InvariantCulture)));
				}
				intPtr = new IntPtr((long)intPtr + Win32Native.SID_AND_ATTRIBUTES.SizeOf);
			}
		}
		finally
		{
			safeLocalAllocHandle.Close();
			safeLocalAllocHandle2.Close();
		}
	}

	[SecurityCritical]
	private void AddPrimarySidClaim(List<Claim> instanceClaims)
	{
		if (m_safeTokenHandle.IsInvalid)
		{
			return;
		}
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		try
		{
			safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, TokenInformationClass.TokenUser);
			Win32Native.SID_AND_ATTRIBUTES sID_AND_ATTRIBUTES = (Win32Native.SID_AND_ATTRIBUTES)Marshal.PtrToStructure(safeLocalAllocHandle.DangerousGetHandle(), typeof(Win32Native.SID_AND_ATTRIBUTES));
			uint num = 16u;
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(sID_AND_ATTRIBUTES.Sid, noDemand: true);
			if (sID_AND_ATTRIBUTES.Attributes == 0)
			{
				instanceClaims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid", securityIdentifier.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier.IdentifierAuthority, CultureInfo.InvariantCulture)));
			}
			else if ((sID_AND_ATTRIBUTES.Attributes & num) == 16)
			{
				instanceClaims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/denyonlyprimarysid", securityIdentifier.Value, "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, "http://schemas.microsoft.com/ws/2008/06/identity/claims/windowssubauthority", Convert.ToString(securityIdentifier.IdentifierAuthority, CultureInfo.InvariantCulture)));
			}
		}
		finally
		{
			safeLocalAllocHandle.Close();
		}
	}

	[SecurityCritical]
	private void AddTokenClaims(List<Claim> instanceClaims, TokenInformationClass tokenInformationClass, string propertyValue)
	{
		if (m_safeTokenHandle.IsInvalid)
		{
			return;
		}
		SafeLocalAllocHandle safeLocalAllocHandle = SafeLocalAllocHandle.InvalidHandle;
		try
		{
			SafeLocalAllocHandle invalidHandle = SafeLocalAllocHandle.InvalidHandle;
			safeLocalAllocHandle = GetTokenInformation(m_safeTokenHandle, tokenInformationClass);
			Win32Native.CLAIM_SECURITY_ATTRIBUTES_INFORMATION cLAIM_SECURITY_ATTRIBUTES_INFORMATION = (Win32Native.CLAIM_SECURITY_ATTRIBUTES_INFORMATION)Marshal.PtrToStructure(safeLocalAllocHandle.DangerousGetHandle(), typeof(Win32Native.CLAIM_SECURITY_ATTRIBUTES_INFORMATION));
			long num = 0L;
			for (int i = 0; i < cLAIM_SECURITY_ATTRIBUTES_INFORMATION.AttributeCount; i++)
			{
				IntPtr ptr = new IntPtr(cLAIM_SECURITY_ATTRIBUTES_INFORMATION.Attribute.pAttributeV1.ToInt64() + num);
				Win32Native.CLAIM_SECURITY_ATTRIBUTE_V1 structure = (Win32Native.CLAIM_SECURITY_ATTRIBUTE_V1)Marshal.PtrToStructure(ptr, typeof(Win32Native.CLAIM_SECURITY_ATTRIBUTE_V1));
				switch (structure.ValueType)
				{
				case 3:
				{
					IntPtr[] array4 = new IntPtr[structure.ValueCount];
					Marshal.Copy(structure.Values.ppString, array4, 0, (int)structure.ValueCount);
					for (int m = 0; m < structure.ValueCount; m++)
					{
						instanceClaims.Add(new Claim(structure.Name, Marshal.PtrToStringAuto(array4[m]), "http://www.w3.org/2001/XMLSchema#string", m_issuerName, m_issuerName, this, propertyValue, string.Empty));
					}
					break;
				}
				case 1:
				{
					long[] array2 = new long[structure.ValueCount];
					Marshal.Copy(structure.Values.pInt64, array2, 0, (int)structure.ValueCount);
					for (int k = 0; k < structure.ValueCount; k++)
					{
						instanceClaims.Add(new Claim(structure.Name, Convert.ToString(array2[k], CultureInfo.InvariantCulture), "http://www.w3.org/2001/XMLSchema#integer64", m_issuerName, m_issuerName, this, propertyValue, string.Empty));
					}
					break;
				}
				case 2:
				{
					long[] array3 = new long[structure.ValueCount];
					Marshal.Copy(structure.Values.pUint64, array3, 0, (int)structure.ValueCount);
					for (int l = 0; l < structure.ValueCount; l++)
					{
						instanceClaims.Add(new Claim(structure.Name, Convert.ToString((ulong)array3[l], CultureInfo.InvariantCulture), "http://www.w3.org/2001/XMLSchema#uinteger64", m_issuerName, m_issuerName, this, propertyValue, string.Empty));
					}
					break;
				}
				case 6:
				{
					long[] array = new long[structure.ValueCount];
					Marshal.Copy(structure.Values.pUint64, array, 0, (int)structure.ValueCount);
					for (int j = 0; j < structure.ValueCount; j++)
					{
						instanceClaims.Add(new Claim(structure.Name, (array[j] == 0L) ? Convert.ToString(value: false, CultureInfo.InvariantCulture) : Convert.ToString(value: true, CultureInfo.InvariantCulture), "http://www.w3.org/2001/XMLSchema#boolean", m_issuerName, m_issuerName, this, propertyValue, string.Empty));
					}
					break;
				}
				}
				num += Marshal.SizeOf(structure);
			}
		}
		finally
		{
			safeLocalAllocHandle.Close();
		}
	}
}
