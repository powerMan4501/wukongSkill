using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.Security;

public sealed class SecurityContext : IDisposable
{
	internal struct Reader
	{
		private SecurityContext m_sc;

		public bool IsNull => m_sc == null;

		public CompressedStack CompressedStack
		{
			get
			{
				if (!IsNull)
				{
					return m_sc.CompressedStack;
				}
				return null;
			}
		}

		public WindowsIdentity WindowsIdentity
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (!IsNull)
				{
					return m_sc.WindowsIdentity;
				}
				return null;
			}
		}

		public Reader(SecurityContext sc)
		{
			m_sc = sc;
		}

		public SecurityContext DangerousGetRawSecurityContext()
		{
			return m_sc;
		}

		public bool IsSame(SecurityContext sc)
		{
			return m_sc == sc;
		}

		public bool IsSame(Reader sc)
		{
			return m_sc == sc.m_sc;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsFlowSuppressed(SecurityContextDisableFlow flags)
		{
			if (m_sc != null)
			{
				return (m_sc._disableFlow & flags) == flags;
			}
			return false;
		}
	}

	internal class SecurityContextRunData
	{
		internal SecurityContext sc;

		internal ContextCallback callBack;

		internal object state;

		internal SecurityContextSwitcher scsw;

		internal SecurityContextRunData(SecurityContext securityContext, ContextCallback cb, object state)
		{
			sc = securityContext;
			callBack = cb;
			this.state = state;
			scsw = default(SecurityContextSwitcher);
		}
	}

	private static bool _LegacyImpersonationPolicy = GetImpersonationFlowMode() == WindowsImpersonationFlowMode.IMP_NOFLOW;

	private static bool _alwaysFlowImpersonationPolicy = GetImpersonationFlowMode() == WindowsImpersonationFlowMode.IMP_ALWAYSFLOW;

	private ExecutionContext _executionContext;

	private volatile WindowsIdentity _windowsIdentity;

	private volatile CompressedStack _compressedStack;

	private static volatile SecurityContext _fullTrustSC;

	internal volatile bool isNewCapture;

	internal volatile SecurityContextDisableFlow _disableFlow;

	internal static volatile RuntimeHelpers.TryCode tryCode;

	internal static volatile RuntimeHelpers.CleanupCode cleanupCode;

	internal static SecurityContext FullTrustSecurityContext
	{
		[SecurityCritical]
		get
		{
			if (_fullTrustSC == null)
			{
				_fullTrustSC = CreateFullTrustSecurityContext();
			}
			return _fullTrustSC;
		}
	}

	internal ExecutionContext ExecutionContext
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
			_executionContext = value;
		}
	}

	internal WindowsIdentity WindowsIdentity
	{
		get
		{
			return _windowsIdentity;
		}
		set
		{
			_windowsIdentity = value;
		}
	}

	internal CompressedStack CompressedStack
	{
		get
		{
			return _compressedStack;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
			_compressedStack = value;
		}
	}

	internal static bool AlwaysFlowImpersonationPolicy => _alwaysFlowImpersonationPolicy;

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal SecurityContext()
	{
	}

	public void Dispose()
	{
		if (_windowsIdentity != null)
		{
			_windowsIdentity.Dispose();
		}
	}

	[SecurityCritical]
	public static AsyncFlowControl SuppressFlow()
	{
		return SuppressFlow(SecurityContextDisableFlow.All);
	}

	[SecurityCritical]
	public static AsyncFlowControl SuppressFlowWindowsIdentity()
	{
		return SuppressFlow(SecurityContextDisableFlow.WI);
	}

	[SecurityCritical]
	internal static AsyncFlowControl SuppressFlow(SecurityContextDisableFlow flags)
	{
		if (IsFlowSuppressed(flags))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotSupressFlowMultipleTimes"));
		}
		ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
		if (mutableExecutionContext.SecurityContext == null)
		{
			mutableExecutionContext.SecurityContext = new SecurityContext();
		}
		AsyncFlowControl result = default(AsyncFlowControl);
		result.Setup(flags);
		return result;
	}

	[SecuritySafeCritical]
	public static void RestoreFlow()
	{
		SecurityContext securityContext = Thread.CurrentThread.GetMutableExecutionContext().SecurityContext;
		if (securityContext == null || securityContext._disableFlow == SecurityContextDisableFlow.Nothing)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotRestoreUnsupressedFlow"));
		}
		securityContext._disableFlow = SecurityContextDisableFlow.Nothing;
	}

	public static bool IsFlowSuppressed()
	{
		return IsFlowSuppressed(SecurityContextDisableFlow.All);
	}

	public static bool IsWindowsIdentityFlowSuppressed()
	{
		if (!_LegacyImpersonationPolicy)
		{
			return IsFlowSuppressed(SecurityContextDisableFlow.WI);
		}
		return true;
	}

	[SecuritySafeCritical]
	internal static bool IsFlowSuppressed(SecurityContextDisableFlow flags)
	{
		return Thread.CurrentThread.GetExecutionContextReader().SecurityContext.IsFlowSuppressed(flags);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	public static void Run(SecurityContext securityContext, ContextCallback callback, object state)
	{
		if (securityContext == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullContext"));
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMe;
		if (!securityContext.isNewCapture)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotNewCaptureContext"));
		}
		securityContext.isNewCapture = false;
		ExecutionContext.Reader executionContextReader = Thread.CurrentThread.GetExecutionContextReader();
		if (CurrentlyInDefaultFTSecurityContext(executionContextReader) && securityContext.IsDefaultFTSecurityContext())
		{
			callback(state);
			if (GetCurrentWI(Thread.CurrentThread.GetExecutionContextReader()) != null)
			{
				WindowsIdentity.SafeRevertToSelf(ref stackMark);
			}
		}
		else
		{
			RunInternal(securityContext, callback, state);
		}
	}

	[SecurityCritical]
	internal static void RunInternal(SecurityContext securityContext, ContextCallback callBack, object state)
	{
		if (cleanupCode == null)
		{
			tryCode = runTryCode;
			cleanupCode = runFinallyCode;
		}
		SecurityContextRunData userData = new SecurityContextRunData(securityContext, callBack, state);
		RuntimeHelpers.ExecuteCodeWithGuaranteedCleanup(tryCode, cleanupCode, userData);
	}

	[SecurityCritical]
	internal static void runTryCode(object userData)
	{
		SecurityContextRunData securityContextRunData = (SecurityContextRunData)userData;
		securityContextRunData.scsw = SetSecurityContext(securityContextRunData.sc, Thread.CurrentThread.GetExecutionContextReader().SecurityContext, modifyCurrentExecutionContext: true);
		securityContextRunData.callBack(securityContextRunData.state);
	}

	[SecurityCritical]
	[PrePrepareMethod]
	internal static void runFinallyCode(object userData, bool exceptionThrown)
	{
		SecurityContextRunData securityContextRunData = (SecurityContextRunData)userData;
		securityContextRunData.scsw.Undo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[SecurityCritical]
	internal static SecurityContextSwitcher SetSecurityContext(SecurityContext sc, Reader prevSecurityContext, bool modifyCurrentExecutionContext)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return SetSecurityContext(sc, prevSecurityContext, modifyCurrentExecutionContext, ref stackMark);
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static SecurityContextSwitcher SetSecurityContext(SecurityContext sc, Reader prevSecurityContext, bool modifyCurrentExecutionContext, ref StackCrawlMark stackMark)
	{
		SecurityContextDisableFlow disableFlow = sc._disableFlow;
		sc._disableFlow = SecurityContextDisableFlow.Nothing;
		SecurityContextSwitcher result = new SecurityContextSwitcher
		{
			currSC = sc,
			prevSC = prevSecurityContext
		};
		if (modifyCurrentExecutionContext)
		{
			(result.currEC = Thread.CurrentThread.GetMutableExecutionContext()).SecurityContext = sc;
		}
		if (sc != null)
		{
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				result.wic = null;
				if (!_LegacyImpersonationPolicy)
				{
					if (sc.WindowsIdentity != null)
					{
						result.wic = sc.WindowsIdentity.Impersonate(ref stackMark);
					}
					else if ((disableFlow & SecurityContextDisableFlow.WI) == 0 && prevSecurityContext.WindowsIdentity != null)
					{
						result.wic = WindowsIdentity.SafeRevertToSelf(ref stackMark);
					}
				}
				result.cssw = CompressedStack.SetCompressedStack(sc.CompressedStack, prevSecurityContext.CompressedStack);
			}
			catch
			{
				result.UndoNoThrow();
				throw;
			}
		}
		return result;
	}

	[SecuritySafeCritical]
	public SecurityContext CreateCopy()
	{
		if (!isNewCapture)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotNewCaptureContext"));
		}
		SecurityContext securityContext = new SecurityContext();
		securityContext.isNewCapture = true;
		securityContext._disableFlow = _disableFlow;
		if (WindowsIdentity != null)
		{
			securityContext._windowsIdentity = new WindowsIdentity(WindowsIdentity.AccessToken);
		}
		if (_compressedStack != null)
		{
			securityContext._compressedStack = _compressedStack.CreateCopy();
		}
		return securityContext;
	}

	[SecuritySafeCritical]
	internal SecurityContext CreateMutableCopy()
	{
		SecurityContext securityContext = new SecurityContext();
		securityContext._disableFlow = _disableFlow;
		if (WindowsIdentity != null)
		{
			securityContext._windowsIdentity = new WindowsIdentity(WindowsIdentity.AccessToken);
		}
		if (_compressedStack != null)
		{
			securityContext._compressedStack = _compressedStack.CreateCopy();
		}
		return securityContext;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	public static SecurityContext Capture()
	{
		if (IsFlowSuppressed())
		{
			return null;
		}
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		SecurityContext securityContext = Capture(Thread.CurrentThread.GetExecutionContextReader(), ref stackMark);
		if (securityContext == null)
		{
			securityContext = CreateFullTrustSecurityContext();
		}
		return securityContext;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	internal static SecurityContext Capture(ExecutionContext.Reader currThreadEC, ref StackCrawlMark stackMark)
	{
		if (currThreadEC.SecurityContext.IsFlowSuppressed(SecurityContextDisableFlow.All))
		{
			return null;
		}
		if (CurrentlyInDefaultFTSecurityContext(currThreadEC))
		{
			return null;
		}
		return CaptureCore(currThreadEC, ref stackMark);
	}

	[SecurityCritical]
	private static SecurityContext CaptureCore(ExecutionContext.Reader currThreadEC, ref StackCrawlMark stackMark)
	{
		SecurityContext securityContext = new SecurityContext();
		securityContext.isNewCapture = true;
		if (!IsWindowsIdentityFlowSuppressed())
		{
			WindowsIdentity currentWI = GetCurrentWI(currThreadEC);
			if (currentWI != null)
			{
				securityContext._windowsIdentity = new WindowsIdentity(currentWI.AccessToken);
			}
		}
		else
		{
			securityContext._disableFlow = SecurityContextDisableFlow.WI;
		}
		securityContext.CompressedStack = CompressedStack.GetCompressedStack(ref stackMark);
		return securityContext;
	}

	[SecurityCritical]
	internal static SecurityContext CreateFullTrustSecurityContext()
	{
		SecurityContext securityContext = new SecurityContext();
		securityContext.isNewCapture = true;
		if (IsWindowsIdentityFlowSuppressed())
		{
			securityContext._disableFlow = SecurityContextDisableFlow.WI;
		}
		securityContext.CompressedStack = new CompressedStack(null);
		return securityContext;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	internal static WindowsIdentity GetCurrentWI(ExecutionContext.Reader threadEC)
	{
		return GetCurrentWI(threadEC, _alwaysFlowImpersonationPolicy);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	internal static WindowsIdentity GetCurrentWI(ExecutionContext.Reader threadEC, bool cachedAlwaysFlowImpersonationPolicy)
	{
		if (cachedAlwaysFlowImpersonationPolicy)
		{
			return WindowsIdentity.GetCurrentInternal(TokenAccessLevels.MaximumAllowed, threadOnly: true);
		}
		return threadEC.SecurityContext.WindowsIdentity;
	}

	[SecurityCritical]
	internal static void RestoreCurrentWI(ExecutionContext.Reader currentEC, ExecutionContext.Reader prevEC, WindowsIdentity targetWI, bool cachedAlwaysFlowImpersonationPolicy)
	{
		if (cachedAlwaysFlowImpersonationPolicy || prevEC.SecurityContext.WindowsIdentity != targetWI)
		{
			RestoreCurrentWIInternal(targetWI);
		}
	}

	[SecurityCritical]
	private static void RestoreCurrentWIInternal(WindowsIdentity targetWI)
	{
		int num = Win32.RevertToSelf();
		if (num < 0)
		{
			Environment.FailFast(Win32Native.GetMessage(num));
		}
		if (targetWI == null)
		{
			return;
		}
		SafeAccessTokenHandle accessToken = targetWI.AccessToken;
		if (accessToken != null && !accessToken.IsInvalid)
		{
			num = Win32.ImpersonateLoggedOnUser(accessToken);
			if (num < 0)
			{
				Environment.FailFast(Win32Native.GetMessage(num));
			}
		}
	}

	[SecurityCritical]
	internal bool IsDefaultFTSecurityContext()
	{
		if (WindowsIdentity == null)
		{
			if (CompressedStack != null)
			{
				return CompressedStack.CompressedStackHandle == null;
			}
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[SecurityCritical]
	internal static bool CurrentlyInDefaultFTSecurityContext(ExecutionContext.Reader threadEC)
	{
		if (IsDefaultThreadSecurityInfo())
		{
			return GetCurrentWI(threadEC) == null;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern WindowsImpersonationFlowMode GetImpersonationFlowMode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static extern bool IsDefaultThreadSecurityInfo();
}
