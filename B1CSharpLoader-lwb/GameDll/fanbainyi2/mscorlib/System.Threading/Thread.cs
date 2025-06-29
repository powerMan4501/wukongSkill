using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;

namespace System.Threading;

[ClassInterface(ClassInterfaceType.None)]
[ComDefaultInterface(typeof(_Thread))]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class Thread : CriticalFinalizerObject, _Thread
{
	private Context m_Context;

	private ExecutionContext m_ExecutionContext;

	private string m_Name;

	private Delegate m_Delegate;

	private CultureInfo m_CurrentCulture;

	private CultureInfo m_CurrentUICulture;

	private object m_ThreadStartArg;

	private IntPtr DONT_USE_InternalThread;

	private int m_Priority;

	private int m_ManagedThreadId;

	private bool m_ExecutionContextBelongsToOuterScope;

	private static LocalDataStoreMgr s_LocalDataStoreMgr;

	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore;

	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

	[ThreadStatic]
	private static int t_currentProcessorIdCache;

	private const int ProcessorIdCacheShift = 16;

	private const int ProcessorIdCacheCountDownMask = 65535;

	private const int ProcessorIdRefreshRate = 5000;

	[__DynamicallyInvokable]
	public extern int ManagedThreadId
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get;
	}

	internal bool ExecutionContextBelongsToCurrentScope
	{
		get
		{
			return !m_ExecutionContextBelongsToOuterScope;
		}
		set
		{
			m_ExecutionContextBelongsToOuterScope = !value;
		}
	}

	public ExecutionContext ExecutionContext
	{
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		get
		{
			if (this == CurrentThread)
			{
				return GetMutableExecutionContext();
			}
			return m_ExecutionContext;
		}
	}

	public ThreadPriority Priority
	{
		[SecuritySafeCritical]
		get
		{
			return (ThreadPriority)GetPriorityNative();
		}
		[SecuritySafeCritical]
		[HostProtection(SecurityAction.LinkDemand, SelfAffectingThreading = true)]
		set
		{
			SetPriorityNative((int)value);
		}
	}

	public extern bool IsAlive
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		get;
	}

	public extern bool IsThreadPoolThread
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[SecuritySafeCritical]
		get;
	}

	[__DynamicallyInvokable]
	public static Thread CurrentThread
	{
		[SecuritySafeCritical]
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[__DynamicallyInvokable]
		get
		{
			return GetCurrentThreadNative();
		}
	}

	public bool IsBackground
	{
		[SecuritySafeCritical]
		get
		{
			return IsBackgroundNative();
		}
		[SecuritySafeCritical]
		[HostProtection(SecurityAction.LinkDemand, SelfAffectingThreading = true)]
		set
		{
			SetBackgroundNative(value);
		}
	}

	public ThreadState ThreadState
	{
		[SecuritySafeCritical]
		get
		{
			return (ThreadState)GetThreadStateNative();
		}
	}

	[Obsolete("The ApartmentState property has been deprecated.  Use GetApartmentState, SetApartmentState or TrySetApartmentState instead.", false)]
	public ApartmentState ApartmentState
	{
		[SecuritySafeCritical]
		get
		{
			return (ApartmentState)GetApartmentStateNative();
		}
		[SecuritySafeCritical]
		[HostProtection(SecurityAction.LinkDemand, Synchronization = true, SelfAffectingThreading = true)]
		set
		{
			SetApartmentStateNative((int)value, fireMDAOnMismatch: true);
		}
	}

	[__DynamicallyInvokable]
	public CultureInfo CurrentUICulture
	{
		[__DynamicallyInvokable]
		get
		{
			if (AppDomain.IsAppXModel())
			{
				return CultureInfo.GetCultureInfoForUserPreferredLanguageInAppX() ?? GetCurrentUICultureNoAppX();
			}
			return GetCurrentUICultureNoAppX();
		}
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			CultureInfo.VerifyCultureName(value, throwException: true);
			if (!nativeSetThreadUILocale(value.SortName))
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidResourceCultureName", value.Name));
			}
			value.StartCrossDomainTracking();
			if (!AppContextSwitches.NoAsyncCurrentCulture)
			{
				if (s_asyncLocalCurrentUICulture == null)
				{
					Interlocked.CompareExchange(ref s_asyncLocalCurrentUICulture, new AsyncLocal<CultureInfo>(AsyncLocalSetCurrentUICulture), null);
				}
				s_asyncLocalCurrentUICulture.Value = value;
			}
			else
			{
				m_CurrentUICulture = value;
			}
		}
	}

	[__DynamicallyInvokable]
	public CultureInfo CurrentCulture
	{
		[__DynamicallyInvokable]
		get
		{
			if (AppDomain.IsAppXModel())
			{
				return CultureInfo.GetCultureInfoForUserPreferredLanguageInAppX() ?? GetCurrentCultureNoAppX();
			}
			return GetCurrentCultureNoAppX();
		}
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			CultureInfo.nativeSetThreadLocale(value.SortName);
			value.StartCrossDomainTracking();
			if (!AppContextSwitches.NoAsyncCurrentCulture)
			{
				if (s_asyncLocalCurrentCulture == null)
				{
					Interlocked.CompareExchange(ref s_asyncLocalCurrentCulture, new AsyncLocal<CultureInfo>(AsyncLocalSetCurrentCulture), null);
				}
				s_asyncLocalCurrentCulture.Value = value;
			}
			else
			{
				m_CurrentCulture = value;
			}
		}
	}

	public static Context CurrentContext
	{
		[SecurityCritical]
		get
		{
			return CurrentThread.GetCurrentContextInternal();
		}
	}

	public static IPrincipal CurrentPrincipal
	{
		[SecuritySafeCritical]
		get
		{
			lock (CurrentThread)
			{
				IPrincipal principal = CallContext.Principal;
				if (principal == null)
				{
					principal = (CallContext.Principal = GetDomain().GetThreadPrincipal());
				}
				return principal;
			}
		}
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlPrincipal)]
		set
		{
			CallContext.Principal = value;
		}
	}

	public string Name
	{
		get
		{
			return m_Name;
		}
		[SecuritySafeCritical]
		[HostProtection(SecurityAction.LinkDemand, ExternalThreading = true)]
		set
		{
			lock (this)
			{
				if (m_Name != null)
				{
					throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_WriteOnce"));
				}
				m_Name = value;
				InformThreadNameChange(GetNativeHandle(), value, value?.Length ?? 0);
			}
		}
	}

	internal object AbortReason
	{
		[SecurityCritical]
		get
		{
			object obj = null;
			try
			{
				return GetAbortReason();
			}
			catch (Exception innerException)
			{
				throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ExceptionStateCrossAppDomain"), innerException);
			}
		}
		[SecurityCritical]
		set
		{
			SetAbortReason(value);
		}
	}

	private static LocalDataStoreMgr LocalDataStoreManager
	{
		get
		{
			if (s_LocalDataStoreMgr == null)
			{
				Interlocked.CompareExchange(ref s_LocalDataStoreMgr, new LocalDataStoreMgr(), null);
			}
			return s_LocalDataStoreMgr;
		}
	}

	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args)
	{
		CurrentThread.m_CurrentCulture = args.CurrentValue;
	}

	private static void AsyncLocalSetCurrentUICulture(AsyncLocalValueChangedArgs<CultureInfo> args)
	{
		CurrentThread.m_CurrentUICulture = args.CurrentValue;
	}

	[SecuritySafeCritical]
	public Thread(ThreadStart start)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		SetStartHelper(start, 0);
	}

	[SecuritySafeCritical]
	public Thread(ThreadStart start, int maxStackSize)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		if (0 > maxStackSize)
		{
			throw new ArgumentOutOfRangeException("maxStackSize", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		SetStartHelper(start, maxStackSize);
	}

	[SecuritySafeCritical]
	public Thread(ParameterizedThreadStart start)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		SetStartHelper(start, 0);
	}

	[SecuritySafeCritical]
	public Thread(ParameterizedThreadStart start, int maxStackSize)
	{
		if (start == null)
		{
			throw new ArgumentNullException("start");
		}
		if (0 > maxStackSize)
		{
			throw new ArgumentOutOfRangeException("maxStackSize", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegNum"));
		}
		SetStartHelper(start, maxStackSize);
	}

	[ComVisible(false)]
	public override int GetHashCode()
	{
		return m_ManagedThreadId;
	}

	internal ThreadHandle GetNativeHandle()
	{
		IntPtr dONT_USE_InternalThread = DONT_USE_InternalThread;
		if (dONT_USE_InternalThread.IsNull())
		{
			throw new ArgumentException(null, Environment.GetResourceString("Argument_InvalidHandle"));
		}
		return new ThreadHandle(dONT_USE_InternalThread);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public void Start()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Start(ref stackMark);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public void Start(object parameter)
	{
		if (m_Delegate is ThreadStart)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ThreadWrongThreadStart"));
		}
		m_ThreadStartArg = parameter;
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		Start(ref stackMark);
	}

	[SecuritySafeCritical]
	private void Start(ref StackCrawlMark stackMark)
	{
		StartupSetApartmentStateInternal();
		if ((object)m_Delegate != null)
		{
			ThreadHelper threadHelper = (ThreadHelper)m_Delegate.Target;
			ExecutionContext executionContextHelper = ExecutionContext.Capture(ref stackMark, ExecutionContext.CaptureOptions.IgnoreSyncCtx);
			threadHelper.SetExecutionContextHelper(executionContextHelper);
		}
		IPrincipal principal = CallContext.Principal;
		StartInternal(principal, ref stackMark);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext.Reader GetExecutionContextReader()
	{
		return new ExecutionContext.Reader(m_ExecutionContext);
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal ExecutionContext GetMutableExecutionContext()
	{
		if (m_ExecutionContext == null)
		{
			m_ExecutionContext = new ExecutionContext();
		}
		else if (!ExecutionContextBelongsToCurrentScope)
		{
			ExecutionContext executionContext = m_ExecutionContext.CreateMutableCopy();
			m_ExecutionContext = executionContext;
		}
		ExecutionContextBelongsToCurrentScope = true;
		return m_ExecutionContext;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
	{
		m_ExecutionContext = value;
		ExecutionContextBelongsToCurrentScope = belongsToCurrentScope;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
	{
		m_ExecutionContext = value.DangerousGetRawExecutionContext();
		ExecutionContextBelongsToCurrentScope = belongsToCurrentScope;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark);

	[SecurityCritical]
	[Obsolete("Thread.SetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
	public void SetCompressedStack(CompressedStack stack)
	{
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ThreadAPIsNotSupported"));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal extern IntPtr SetAppDomainStack(SafeCompressedStackHandle csHandle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal extern void RestoreAppDomainStack(IntPtr appDomainStack);

	[SecurityCritical]
	[Obsolete("Thread.GetCompressedStack is no longer supported. Please use the System.Threading.CompressedStack class")]
	public CompressedStack GetCompressedStack()
	{
		throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ThreadAPIsNotSupported"));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern IntPtr InternalGetCurrentThread();

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public void Abort(object stateInfo)
	{
		AbortReason = stateInfo;
		AbortInternal();
	}

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public void Abort()
	{
		AbortInternal();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void AbortInternal();

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void ResetAbort()
	{
		Thread currentThread = CurrentThread;
		if ((currentThread.ThreadState & ThreadState.AbortRequested) == 0)
		{
			throw new ThreadStateException(Environment.GetResourceString("ThreadState_NoAbortRequested"));
		}
		currentThread.ResetAbortNative();
		currentThread.ClearAbortReason();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void ResetAbortNative();

	[SecuritySafeCritical]
	[Obsolete("Thread.Suspend has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public void Suspend()
	{
		SuspendInternal();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void SuspendInternal();

	[SecuritySafeCritical]
	[Obsolete("Thread.Resume has been deprecated.  Please use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.  http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public void Resume()
	{
		ResumeInternal();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void ResumeInternal();

	[SecuritySafeCritical]
	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public void Interrupt()
	{
		InterruptInternal();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void InterruptInternal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern int GetPriorityNative();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void SetPriorityNative(int priority);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern bool JoinInternal(int millisecondsTimeout);

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public void Join()
	{
		JoinInternal(-1);
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public bool Join(int millisecondsTimeout)
	{
		return JoinInternal(millisecondsTimeout);
	}

	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public bool Join(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		return Join((int)num);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void SleepInternal(int millisecondsTimeout);

	[SecuritySafeCritical]
	public static void Sleep(int millisecondsTimeout)
	{
		SleepInternal(millisecondsTimeout);
		if (AppDomainPauseManager.IsPaused)
		{
			AppDomainPauseManager.ResumeEvent.WaitOneWithoutFAS();
		}
	}

	public static void Sleep(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num < -1 || num > int.MaxValue)
		{
			throw new ArgumentOutOfRangeException("timeout", Environment.GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1"));
		}
		Sleep((int)num);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	private static extern int GetCurrentProcessorNumber();

	private static int RefreshCurrentProcessorId()
	{
		int num = GetCurrentProcessorNumber();
		if (num < 0)
		{
			num = Environment.CurrentManagedThreadId;
		}
		num += 100;
		t_currentProcessorIdCache = ((num << 16) & 0x7FFFFFFF) | 0x1388;
		return num;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetCurrentProcessorId()
	{
		int num = t_currentProcessorIdCache--;
		if ((num & 0xFFFF) == 0)
		{
			return RefreshCurrentProcessorId();
		}
		return num >> 16;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	private static extern void SpinWaitInternal(int iterations);

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public static void SpinWait(int iterations)
	{
		SpinWaitInternal(iterations);
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	private static extern bool YieldInternal();

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public static bool Yield()
	{
		return YieldInternal();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static extern Thread GetCurrentThreadNative();

	[SecurityCritical]
	private void SetStartHelper(Delegate start, int maxStackSize)
	{
		ulong processDefaultStackSize = GetProcessDefaultStackSize();
		if ((uint)maxStackSize > processDefaultStackSize)
		{
			try
			{
				CodeAccessPermission.Demand(PermissionType.FullTrust);
			}
			catch (SecurityException)
			{
				maxStackSize = (int)Math.Min(processDefaultStackSize, 2147483647uL);
			}
		}
		ThreadHelper threadHelper = new ThreadHelper(start);
		if (start is ThreadStart)
		{
			SetStart(new ThreadStart(threadHelper.ThreadStart), maxStackSize);
		}
		else
		{
			SetStart(new ParameterizedThreadStart(threadHelper.ThreadStart), maxStackSize);
		}
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern ulong GetProcessDefaultStackSize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void SetStart(Delegate start, int maxStackSize);

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	~Thread()
	{
		InternalFinalize();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private extern void InternalFinalize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public extern void DisableComObjectEagerCleanup();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern bool IsBackgroundNative();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void SetBackgroundNative(bool isBackground);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern int GetThreadStateNative();

	[SecuritySafeCritical]
	public ApartmentState GetApartmentState()
	{
		return (ApartmentState)GetApartmentStateNative();
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, SelfAffectingThreading = true)]
	public bool TrySetApartmentState(ApartmentState state)
	{
		return SetApartmentStateHelper(state, fireMDAOnMismatch: false);
	}

	[SecuritySafeCritical]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, SelfAffectingThreading = true)]
	public void SetApartmentState(ApartmentState state)
	{
		if (!SetApartmentStateHelper(state, fireMDAOnMismatch: true))
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ApartmentStateSwitchFailed"));
		}
	}

	[SecurityCritical]
	private bool SetApartmentStateHelper(ApartmentState state, bool fireMDAOnMismatch)
	{
		ApartmentState apartmentState = (ApartmentState)SetApartmentStateNative((int)state, fireMDAOnMismatch);
		if (state == ApartmentState.Unknown && apartmentState == ApartmentState.MTA)
		{
			return true;
		}
		if (apartmentState != state)
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern int GetApartmentStateNative();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern int SetApartmentStateNative(int state, bool fireMDAOnMismatch);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern void StartupSetApartmentStateInternal();

	[HostProtection(SecurityAction.LinkDemand, SharedState = true, ExternalThreading = true)]
	public static LocalDataStoreSlot AllocateDataSlot()
	{
		return LocalDataStoreManager.AllocateDataSlot();
	}

	[HostProtection(SecurityAction.LinkDemand, SharedState = true, ExternalThreading = true)]
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
	{
		return LocalDataStoreManager.AllocateNamedDataSlot(name);
	}

	[HostProtection(SecurityAction.LinkDemand, SharedState = true, ExternalThreading = true)]
	public static LocalDataStoreSlot GetNamedDataSlot(string name)
	{
		return LocalDataStoreManager.GetNamedDataSlot(name);
	}

	[HostProtection(SecurityAction.LinkDemand, SharedState = true, ExternalThreading = true)]
	public static void FreeNamedDataSlot(string name)
	{
		LocalDataStoreManager.FreeNamedDataSlot(name);
	}

	[HostProtection(SecurityAction.LinkDemand, SharedState = true, ExternalThreading = true)]
	public static object GetData(LocalDataStoreSlot slot)
	{
		LocalDataStoreHolder localDataStoreHolder = s_LocalDataStore;
		if (localDataStoreHolder == null)
		{
			LocalDataStoreManager.ValidateSlot(slot);
			return null;
		}
		return localDataStoreHolder.Store.GetData(slot);
	}

	[HostProtection(SecurityAction.LinkDemand, SharedState = true, ExternalThreading = true)]
	public static void SetData(LocalDataStoreSlot slot, object data)
	{
		LocalDataStoreHolder localDataStoreHolder = s_LocalDataStore;
		if (localDataStoreHolder == null)
		{
			localDataStoreHolder = (s_LocalDataStore = LocalDataStoreManager.CreateLocalDataStore());
		}
		localDataStoreHolder.Store.SetData(slot, data);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool nativeGetSafeCulture(Thread t, int appDomainId, bool isUI, ref CultureInfo safeCulture);

	[SecuritySafeCritical]
	internal CultureInfo GetCurrentUICultureNoAppX()
	{
		if (m_CurrentUICulture == null)
		{
			CultureInfo defaultThreadCurrentUICulture = CultureInfo.DefaultThreadCurrentUICulture;
			if (defaultThreadCurrentUICulture == null)
			{
				return CultureInfo.UserDefaultUICulture;
			}
			return defaultThreadCurrentUICulture;
		}
		CultureInfo safeCulture = null;
		if (!nativeGetSafeCulture(this, GetDomainID(), isUI: true, ref safeCulture) || safeCulture == null)
		{
			return CultureInfo.UserDefaultUICulture;
		}
		return safeCulture;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern bool nativeSetThreadUILocale(string locale);

	[SecuritySafeCritical]
	private CultureInfo GetCurrentCultureNoAppX()
	{
		if (m_CurrentCulture == null)
		{
			CultureInfo defaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentCulture;
			if (defaultThreadCurrentCulture == null)
			{
				return CultureInfo.UserDefaultCulture;
			}
			return defaultThreadCurrentCulture;
		}
		CultureInfo safeCulture = null;
		if (!nativeGetSafeCulture(this, GetDomainID(), isUI: false, ref safeCulture) || safeCulture == null)
		{
			return CultureInfo.UserDefaultCulture;
		}
		return safeCulture;
	}

	[SecurityCritical]
	internal Context GetCurrentContextInternal()
	{
		if (m_Context == null)
		{
			m_Context = Context.DefaultContext;
		}
		return m_Context;
	}

	[SecurityCritical]
	private void SetPrincipalInternal(IPrincipal principal)
	{
		GetMutableExecutionContext().LogicalCallContext.SecurityData.Principal = principal;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern Context GetContextInternal(IntPtr id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern object InternalCrossContextCallback(Context ctx, IntPtr ctxID, int appDomainID, InternalCrossContextDelegate ftnToCall, object[] args);

	[SecurityCritical]
	internal object InternalCrossContextCallback(Context ctx, InternalCrossContextDelegate ftnToCall, object[] args)
	{
		return InternalCrossContextCallback(ctx, ctx.InternalContextID, 0, ftnToCall, args);
	}

	private static object CompleteCrossContextCallback(InternalCrossContextDelegate ftnToCall, object[] args)
	{
		return ftnToCall(args);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern AppDomain GetDomainInternal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern AppDomain GetFastDomainInternal();

	[SecuritySafeCritical]
	public static AppDomain GetDomain()
	{
		AppDomain appDomain = GetFastDomainInternal();
		if (appDomain == null)
		{
			appDomain = GetDomainInternal();
		}
		return appDomain;
	}

	public static int GetDomainID()
	{
		return GetDomain().GetId();
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	private static extern void InformThreadNameChange(ThreadHandle t, string name, int len);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public static extern void BeginCriticalRegion();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
	public static extern void EndCriticalRegion();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static extern void BeginThreadAffinity();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static extern void EndThreadAffinity();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte VolatileRead(ref byte address)
	{
		byte result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static short VolatileRead(ref short address)
	{
		short result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int VolatileRead(ref int address)
	{
		int result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static long VolatileRead(ref long address)
	{
		long result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static sbyte VolatileRead(ref sbyte address)
	{
		sbyte result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static ushort VolatileRead(ref ushort address)
	{
		ushort result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static uint VolatileRead(ref uint address)
	{
		uint result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IntPtr VolatileRead(ref IntPtr address)
	{
		IntPtr result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static UIntPtr VolatileRead(ref UIntPtr address)
	{
		UIntPtr result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static ulong VolatileRead(ref ulong address)
	{
		ulong result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float VolatileRead(ref float address)
	{
		float result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static double VolatileRead(ref double address)
	{
		double result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static object VolatileRead(ref object address)
	{
		object result = address;
		MemoryBarrier();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref byte address, byte value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref short address, short value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref int address, int value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref long address, long value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static void VolatileWrite(ref sbyte address, sbyte value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static void VolatileWrite(ref ushort address, ushort value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static void VolatileWrite(ref uint address, uint value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref IntPtr address, IntPtr value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static void VolatileWrite(ref UIntPtr address, UIntPtr value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CLSCompliant(false)]
	public static void VolatileWrite(ref ulong address, ulong value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref float address, float value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref double address, double value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void VolatileWrite(ref object address, object value)
	{
		MemoryBarrier();
		address = value;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern void MemoryBarrier();

	void _Thread.GetTypeInfoCount(out uint pcTInfo)
	{
		throw new NotImplementedException();
	}

	void _Thread.GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo)
	{
		throw new NotImplementedException();
	}

	void _Thread.GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId)
	{
		throw new NotImplementedException();
	}

	void _Thread.Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr)
	{
		throw new NotImplementedException();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void SetAbortReason(object o);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern object GetAbortReason();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void ClearAbortReason();
}
