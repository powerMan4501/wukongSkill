using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security;

namespace System.Threading;

[Serializable]
[__DynamicallyInvokable]
public sealed class ExecutionContext : IDisposable, ISerializable
{
	private enum Flags
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4
	}

	internal struct Reader
	{
		private ExecutionContext m_ec;

		public bool IsNull => m_ec == null;

		public bool IsFlowSuppressed
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				if (!IsNull)
				{
					return m_ec.isFlowSuppressed;
				}
				return false;
			}
		}

		public SynchronizationContext SynchronizationContext
		{
			get
			{
				if (!IsNull)
				{
					return m_ec.SynchronizationContext;
				}
				return null;
			}
		}

		public SynchronizationContext SynchronizationContextNoFlow
		{
			get
			{
				if (!IsNull)
				{
					return m_ec.SynchronizationContextNoFlow;
				}
				return null;
			}
		}

		public SecurityContext.Reader SecurityContext
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[SecurityCritical]
			get
			{
				return new SecurityContext.Reader(IsNull ? null : m_ec.SecurityContext);
			}
		}

		public LogicalCallContext.Reader LogicalCallContext
		{
			[SecurityCritical]
			get
			{
				return new LogicalCallContext.Reader(IsNull ? null : m_ec.LogicalCallContext);
			}
		}

		public IllogicalCallContext.Reader IllogicalCallContext
		{
			[SecurityCritical]
			get
			{
				return new IllogicalCallContext.Reader(IsNull ? null : m_ec.IllogicalCallContext);
			}
		}

		public Reader(ExecutionContext ec)
		{
			m_ec = ec;
		}

		public ExecutionContext DangerousGetRawExecutionContext()
		{
			return m_ec;
		}

		[SecurityCritical]
		public bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			return m_ec.IsDefaultFTContext(ignoreSyncCtx);
		}

		public bool IsSame(Reader other)
		{
			return m_ec == other.m_ec;
		}

		[SecurityCritical]
		public object GetLocalValue(IAsyncLocal local)
		{
			if (IsNull)
			{
				return null;
			}
			if (m_ec._localValues == null)
			{
				return null;
			}
			m_ec._localValues.TryGetValue(local, out var value);
			return value;
		}

		[SecurityCritical]
		public bool HasSameLocalValues(ExecutionContext other)
		{
			IAsyncLocalValueMap asyncLocalValueMap = (IsNull ? null : m_ec._localValues);
			IAsyncLocalValueMap asyncLocalValueMap2 = other?._localValues;
			return asyncLocalValueMap == asyncLocalValueMap2;
		}

		[SecurityCritical]
		public bool HasLocalValues()
		{
			if (!IsNull)
			{
				return m_ec._localValues != null;
			}
			return false;
		}
	}

	[Flags]
	internal enum CaptureOptions
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2
	}

	private HostExecutionContext _hostExecutionContext;

	private SynchronizationContext _syncContext;

	private SynchronizationContext _syncContextNoFlow;

	private SecurityContext _securityContext;

	[SecurityCritical]
	private LogicalCallContext _logicalCallContext;

	private IllogicalCallContext _illogicalCallContext;

	private Flags _flags;

	private IAsyncLocalValueMap _localValues;

	private IAsyncLocal[] _localChangeNotifications;

	private static readonly ExecutionContext s_dummyDefaultEC = new ExecutionContext(isPreAllocatedDefault: true);

	internal bool isNewCapture
	{
		get
		{
			return (_flags & (Flags)5) != 0;
		}
		set
		{
			if (value)
			{
				_flags |= Flags.IsNewCapture;
			}
			else
			{
				_flags &= (Flags)(-2);
			}
		}
	}

	internal bool isFlowSuppressed
	{
		get
		{
			return (_flags & Flags.IsFlowSuppressed) != 0;
		}
		set
		{
			if (value)
			{
				_flags |= Flags.IsFlowSuppressed;
			}
			else
			{
				_flags &= (Flags)(-3);
			}
		}
	}

	internal static ExecutionContext PreAllocatedDefault
	{
		[SecuritySafeCritical]
		get
		{
			return s_dummyDefaultEC;
		}
	}

	internal bool IsPreAllocatedDefault
	{
		get
		{
			if ((_flags & Flags.IsPreAllocatedDefault) != Flags.None)
			{
				return true;
			}
			return false;
		}
	}

	internal LogicalCallContext LogicalCallContext
	{
		[SecurityCritical]
		get
		{
			if (_logicalCallContext == null)
			{
				_logicalCallContext = new LogicalCallContext();
			}
			return _logicalCallContext;
		}
		[SecurityCritical]
		set
		{
			_logicalCallContext = value;
		}
	}

	internal IllogicalCallContext IllogicalCallContext
	{
		get
		{
			if (_illogicalCallContext == null)
			{
				_illogicalCallContext = new IllogicalCallContext();
			}
			return _illogicalCallContext;
		}
		set
		{
			_illogicalCallContext = value;
		}
	}

	internal SynchronizationContext SynchronizationContext
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return _syncContext;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
			_syncContext = value;
		}
	}

	internal SynchronizationContext SynchronizationContextNoFlow
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return _syncContextNoFlow;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
			_syncContextNoFlow = value;
		}
	}

	internal HostExecutionContext HostExecutionContext
	{
		get
		{
			return _hostExecutionContext;
		}
		set
		{
			_hostExecutionContext = value;
		}
	}

	internal SecurityContext SecurityContext
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return _securityContext;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
			_securityContext = value;
			if (value != null)
			{
				_securityContext.ExecutionContext = this;
			}
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext(bool isPreAllocatedDefault)
	{
		if (isPreAllocatedDefault)
		{
			_flags = Flags.IsPreAllocatedDefault;
		}
	}

	[SecurityCritical]
	internal static object GetLocalValue(IAsyncLocal local)
	{
		return Thread.CurrentThread.GetExecutionContextReader().GetLocalValue(local);
	}

	[SecurityCritical]
	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications)
	{
		ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
		object value = null;
		bool flag = mutableExecutionContext._localValues != null && mutableExecutionContext._localValues.TryGetValue(local, out value);
		if (value == newValue)
		{
			return;
		}
		IAsyncLocalValueMap localValues = mutableExecutionContext._localValues;
		localValues = ((localValues != null) ? localValues.Set(local, newValue, !needChangeNotifications) : AsyncLocalValueMap.Create(local, newValue, !needChangeNotifications));
		mutableExecutionContext._localValues = localValues;
		if (!needChangeNotifications)
		{
			return;
		}
		if (!flag)
		{
			IAsyncLocal[] array = mutableExecutionContext._localChangeNotifications;
			if (array == null)
			{
				array = new IAsyncLocal[1] { local };
			}
			else
			{
				int num = array.Length;
				Array.Resize(ref array, num + 1);
				array[num] = local;
			}
			mutableExecutionContext._localChangeNotifications = array;
		}
		local.OnValueChanged(value, newValue, contextChanged: false);
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
	{
		IAsyncLocal[] array = previous?._localChangeNotifications;
		if (array != null)
		{
			IAsyncLocal[] array2 = array;
			foreach (IAsyncLocal asyncLocal in array2)
			{
				object value = null;
				if (previous != null && previous._localValues != null)
				{
					previous._localValues.TryGetValue(asyncLocal, out value);
				}
				object value2 = null;
				if (current != null && current._localValues != null)
				{
					current._localValues.TryGetValue(asyncLocal, out value2);
				}
				if (value != value2)
				{
					asyncLocal.OnValueChanged(value, value2, contextChanged: true);
				}
			}
		}
		IAsyncLocal[] array3 = current?._localChangeNotifications;
		if (array3 == null || array3 == array)
		{
			return;
		}
		try
		{
			IAsyncLocal[] array4 = array3;
			foreach (IAsyncLocal asyncLocal2 in array4)
			{
				object value3 = null;
				if (previous == null || previous._localValues == null || !previous._localValues.TryGetValue(asyncLocal2, out value3))
				{
					object value4 = null;
					if (current != null && current._localValues != null)
					{
						current._localValues.TryGetValue(asyncLocal2, out value4);
					}
					if (value3 != value4)
					{
						asyncLocal2.OnValueChanged(value3, value4, contextChanged: true);
					}
				}
			}
		}
		catch (Exception exception)
		{
			Environment.FailFast(Environment.GetResourceString("ExecutionContext_ExceptionInAsyncLocalNotification"), exception);
		}
	}

	public void Dispose()
	{
		if (!IsPreAllocatedDefault)
		{
			if (_hostExecutionContext != null)
			{
				_hostExecutionContext.Dispose();
			}
			if (_securityContext != null)
			{
				_securityContext.Dispose();
			}
		}
	}

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
	{
		if (executionContext == null)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NullContext"));
		}
		if (!executionContext.isNewCapture)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_NotNewCaptureContext"));
		}
		Run(executionContext, callback, state, preserveSyncCtx: false);
	}

	[SecurityCritical]
	[FriendAccessAllowed]
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
	{
		RunInternal(executionContext, callback, state, preserveSyncCtx);
	}

	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
	{
		if (!executionContext.IsPreAllocatedDefault)
		{
			executionContext.isNewCapture = false;
		}
		Thread currentThread = Thread.CurrentThread;
		ExecutionContextSwitcher ecsw = default(ExecutionContextSwitcher);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			Reader executionContextReader = currentThread.GetExecutionContextReader();
			if ((executionContextReader.IsNull || executionContextReader.IsDefaultFTContext(preserveSyncCtx)) && SecurityContext.CurrentlyInDefaultFTSecurityContext(executionContextReader) && executionContext.IsDefaultFTContext(preserveSyncCtx) && executionContextReader.HasSameLocalValues(executionContext))
			{
				EstablishCopyOnWriteScope(currentThread, knownNullWindowsIdentity: true, ref ecsw);
			}
			else
			{
				if (executionContext.IsPreAllocatedDefault)
				{
					executionContext = new ExecutionContext();
				}
				ecsw = SetExecutionContext(executionContext, preserveSyncCtx);
			}
			callback(state);
		}
		finally
		{
			ecsw.Undo();
		}
	}

	[SecurityCritical]
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
	{
		EstablishCopyOnWriteScope(Thread.CurrentThread, knownNullWindowsIdentity: false, ref ecsw);
	}

	[SecurityCritical]
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
	{
		ecsw.outerEC = currentThread.GetExecutionContextReader();
		ecsw.outerECBelongsToScope = currentThread.ExecutionContextBelongsToCurrentScope;
		ecsw.cachedAlwaysFlowImpersonationPolicy = SecurityContext.AlwaysFlowImpersonationPolicy;
		if (!knownNullWindowsIdentity)
		{
			ecsw.wi = SecurityContext.GetCurrentWI(ecsw.outerEC, ecsw.cachedAlwaysFlowImpersonationPolicy);
		}
		ecsw.wiIsValid = true;
		currentThread.ExecutionContextBelongsToCurrentScope = false;
		ecsw.thread = currentThread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecurityCritical]
	[HandleProcessCorruptedStateExceptions]
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		ExecutionContextSwitcher result = default(ExecutionContextSwitcher);
		Thread currentThread = Thread.CurrentThread;
		Reader executionContextReader = currentThread.GetExecutionContextReader();
		result.thread = currentThread;
		result.outerEC = executionContextReader;
		result.outerECBelongsToScope = currentThread.ExecutionContextBelongsToCurrentScope;
		if (preserveSyncCtx)
		{
			executionContext.SynchronizationContext = executionContextReader.SynchronizationContext;
		}
		executionContext.SynchronizationContextNoFlow = executionContextReader.SynchronizationContextNoFlow;
		currentThread.SetExecutionContext(executionContext, belongsToCurrentScope: true);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			OnAsyncLocalContextChanged(executionContextReader.DangerousGetRawExecutionContext(), executionContext);
			SecurityContext securityContext = executionContext.SecurityContext;
			if (securityContext != null)
			{
				SecurityContext.Reader securityContext2 = executionContextReader.SecurityContext;
				result.scsw = SecurityContext.SetSecurityContext(securityContext, securityContext2, modifyCurrentExecutionContext: false, ref stackMark);
			}
			else if (!SecurityContext.CurrentlyInDefaultFTSecurityContext(result.outerEC))
			{
				SecurityContext.Reader securityContext3 = executionContextReader.SecurityContext;
				result.scsw = SecurityContext.SetSecurityContext(SecurityContext.FullTrustSecurityContext, securityContext3, modifyCurrentExecutionContext: false, ref stackMark);
			}
			HostExecutionContext hostExecutionContext = executionContext.HostExecutionContext;
			if (hostExecutionContext != null)
			{
				result.hecsw = HostExecutionContextManager.SetHostExecutionContextInternal(hostExecutionContext);
			}
		}
		catch
		{
			result.UndoNoThrow();
			throw;
		}
		return result;
	}

	[SecuritySafeCritical]
	public ExecutionContext CreateCopy()
	{
		if (!isNewCapture)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotCopyUsedContext"));
		}
		ExecutionContext executionContext = new ExecutionContext();
		executionContext.isNewCapture = true;
		executionContext._syncContext = ((_syncContext == null) ? null : _syncContext.CreateCopy());
		executionContext._localValues = _localValues;
		executionContext._localChangeNotifications = _localChangeNotifications;
		executionContext._hostExecutionContext = ((_hostExecutionContext == null) ? null : _hostExecutionContext.CreateCopy());
		if (_securityContext != null)
		{
			executionContext._securityContext = _securityContext.CreateCopy();
			executionContext._securityContext.ExecutionContext = executionContext;
		}
		if (_logicalCallContext != null)
		{
			executionContext.LogicalCallContext = (LogicalCallContext)LogicalCallContext.Clone();
		}
		return executionContext;
	}

	[SecuritySafeCritical]
	internal ExecutionContext CreateMutableCopy()
	{
		ExecutionContext executionContext = new ExecutionContext();
		executionContext._syncContext = _syncContext;
		executionContext._syncContextNoFlow = _syncContextNoFlow;
		executionContext._hostExecutionContext = ((_hostExecutionContext == null) ? null : _hostExecutionContext.CreateCopy());
		if (_securityContext != null)
		{
			executionContext._securityContext = _securityContext.CreateMutableCopy();
			executionContext._securityContext.ExecutionContext = executionContext;
		}
		if (_logicalCallContext != null)
		{
			executionContext.LogicalCallContext = (LogicalCallContext)LogicalCallContext.Clone();
		}
		if (_illogicalCallContext != null)
		{
			executionContext.IllogicalCallContext = IllogicalCallContext.CreateCopy();
		}
		executionContext._localValues = _localValues;
		executionContext._localChangeNotifications = _localChangeNotifications;
		executionContext.isFlowSuppressed = isFlowSuppressed;
		return executionContext;
	}

	[SecurityCritical]
	public static AsyncFlowControl SuppressFlow()
	{
		if (IsFlowSuppressed())
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotSupressFlowMultipleTimes"));
		}
		AsyncFlowControl result = default(AsyncFlowControl);
		result.Setup();
		return result;
	}

	[SecuritySafeCritical]
	public static void RestoreFlow()
	{
		ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
		if (!mutableExecutionContext.isFlowSuppressed)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_CannotRestoreUnsupressedFlow"));
		}
		mutableExecutionContext.isFlowSuppressed = false;
	}

	public static bool IsFlowSuppressed()
	{
		return Thread.CurrentThread.GetExecutionContextReader().IsFlowSuppressed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static ExecutionContext Capture()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Capture(ref stackMark, CaptureOptions.None);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SecuritySafeCritical]
	[FriendAccessAllowed]
	internal static ExecutionContext FastCapture()
	{
		StackCrawlMark stackMark = StackCrawlMark.LookForMyCaller;
		return Capture(ref stackMark, CaptureOptions.IgnoreSyncCtx | CaptureOptions.OptimizeDefaultCase);
	}

	[SecurityCritical]
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options)
	{
		Reader executionContextReader = Thread.CurrentThread.GetExecutionContextReader();
		if (executionContextReader.IsFlowSuppressed)
		{
			return null;
		}
		SecurityContext securityContext = SecurityContext.Capture(executionContextReader, ref stackMark);
		HostExecutionContext hostExecutionContext = HostExecutionContextManager.CaptureHostExecutionContext();
		SynchronizationContext synchronizationContext = null;
		LogicalCallContext logicalCallContext = null;
		if (!executionContextReader.IsNull)
		{
			if ((options & CaptureOptions.IgnoreSyncCtx) == 0)
			{
				synchronizationContext = ((executionContextReader.SynchronizationContext == null) ? null : executionContextReader.SynchronizationContext.CreateCopy());
			}
			if (executionContextReader.LogicalCallContext.HasInfo)
			{
				logicalCallContext = executionContextReader.LogicalCallContext.Clone();
			}
		}
		IAsyncLocalValueMap asyncLocalValueMap = null;
		IAsyncLocal[] array = null;
		if (!executionContextReader.IsNull)
		{
			asyncLocalValueMap = executionContextReader.DangerousGetRawExecutionContext()._localValues;
			array = executionContextReader.DangerousGetRawExecutionContext()._localChangeNotifications;
		}
		if ((options & CaptureOptions.OptimizeDefaultCase) != CaptureOptions.None && securityContext == null && hostExecutionContext == null && synchronizationContext == null && (logicalCallContext == null || !logicalCallContext.HasInfo) && asyncLocalValueMap == null && array == null)
		{
			return s_dummyDefaultEC;
		}
		ExecutionContext executionContext = new ExecutionContext();
		executionContext.SecurityContext = securityContext;
		if (executionContext.SecurityContext != null)
		{
			executionContext.SecurityContext.ExecutionContext = executionContext;
		}
		executionContext._hostExecutionContext = hostExecutionContext;
		executionContext._syncContext = synchronizationContext;
		executionContext.LogicalCallContext = logicalCallContext;
		executionContext._localValues = asyncLocalValueMap;
		executionContext._localChangeNotifications = array;
		executionContext.isNewCapture = true;
		return executionContext;
	}

	[SecurityCritical]
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		if (_logicalCallContext != null)
		{
			info.AddValue("LogicalCallContext", _logicalCallContext, typeof(LogicalCallContext));
		}
	}

	[SecurityCritical]
	private ExecutionContext(SerializationInfo info, StreamingContext context)
	{
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Name.Equals("LogicalCallContext"))
			{
				_logicalCallContext = (LogicalCallContext)enumerator.Value;
			}
		}
	}

	[SecurityCritical]
	internal bool IsDefaultFTContext(bool ignoreSyncCtx)
	{
		if (_hostExecutionContext != null)
		{
			return false;
		}
		if (!ignoreSyncCtx && _syncContext != null)
		{
			return false;
		}
		if (_securityContext != null && !_securityContext.IsDefaultFTSecurityContext())
		{
			return false;
		}
		if (_logicalCallContext != null && _logicalCallContext.HasInfo)
		{
			return false;
		}
		if (_illogicalCallContext != null && _illogicalCallContext.HasUserData)
		{
			return false;
		}
		return true;
	}
}
