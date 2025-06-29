using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace System.Threading;

[__DynamicallyInvokable]
[SecurityPermission(SecurityAction.InheritanceDemand, Flags = (SecurityPermissionFlag.ControlEvidence | SecurityPermissionFlag.ControlPolicy))]
public class SynchronizationContext
{
	private delegate int WaitDelegate(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout);

	private SynchronizationContextProperties _props;

	private static Type s_cachedPreparedType1;

	private static Type s_cachedPreparedType2;

	private static Type s_cachedPreparedType3;

	private static Type s_cachedPreparedType4;

	private static Type s_cachedPreparedType5;

	[SecurityCritical]
	private static WinRTSynchronizationContextFactoryBase s_winRTContextFactory;

	[__DynamicallyInvokable]
	public static SynchronizationContext Current
	{
		[__DynamicallyInvokable]
		get
		{
			return Thread.CurrentThread.GetExecutionContextReader().SynchronizationContext ?? GetThreadLocalContext();
		}
	}

	internal static SynchronizationContext CurrentNoFlow
	{
		[FriendAccessAllowed]
		get
		{
			return Thread.CurrentThread.GetExecutionContextReader().SynchronizationContextNoFlow ?? GetThreadLocalContext();
		}
	}

	[__DynamicallyInvokable]
	public SynchronizationContext()
	{
	}

	[SecuritySafeCritical]
	protected void SetWaitNotificationRequired()
	{
		Type type = GetType();
		if (s_cachedPreparedType1 != type && s_cachedPreparedType2 != type && s_cachedPreparedType3 != type && s_cachedPreparedType4 != type && s_cachedPreparedType5 != type)
		{
			RuntimeHelpers.PrepareDelegate(new WaitDelegate(Wait));
			if (s_cachedPreparedType1 == null)
			{
				s_cachedPreparedType1 = type;
			}
			else if (s_cachedPreparedType2 == null)
			{
				s_cachedPreparedType2 = type;
			}
			else if (s_cachedPreparedType3 == null)
			{
				s_cachedPreparedType3 = type;
			}
			else if (s_cachedPreparedType4 == null)
			{
				s_cachedPreparedType4 = type;
			}
			else if (s_cachedPreparedType5 == null)
			{
				s_cachedPreparedType5 = type;
			}
		}
		_props |= SynchronizationContextProperties.RequireWaitNotification;
	}

	public bool IsWaitNotificationRequired()
	{
		return (_props & SynchronizationContextProperties.RequireWaitNotification) != 0;
	}

	[__DynamicallyInvokable]
	public virtual void Send(SendOrPostCallback d, object state)
	{
		d(state);
	}

	[__DynamicallyInvokable]
	public virtual void Post(SendOrPostCallback d, object state)
	{
		ThreadPool.QueueUserWorkItem(d.Invoke, state);
	}

	[__DynamicallyInvokable]
	public virtual void OperationStarted()
	{
	}

	[__DynamicallyInvokable]
	public virtual void OperationCompleted()
	{
	}

	[SecurityCritical]
	[CLSCompliant(false)]
	[PrePrepareMethod]
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
	{
		if (waitHandles == null)
		{
			throw new ArgumentNullException("waitHandles");
		}
		return WaitHelper(waitHandles, waitAll, millisecondsTimeout);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[CLSCompliant(false)]
	[PrePrepareMethod]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected static extern int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout);

	[SecurityCritical]
	[__DynamicallyInvokable]
	public static void SetSynchronizationContext(SynchronizationContext syncContext)
	{
		ExecutionContext mutableExecutionContext = Thread.CurrentThread.GetMutableExecutionContext();
		mutableExecutionContext.SynchronizationContext = syncContext;
		mutableExecutionContext.SynchronizationContextNoFlow = syncContext;
	}

	private static SynchronizationContext GetThreadLocalContext()
	{
		SynchronizationContext synchronizationContext = null;
		if (synchronizationContext == null && Environment.IsWinRTSupported)
		{
			synchronizationContext = GetWinRTContext();
		}
		return synchronizationContext;
	}

	[SecuritySafeCritical]
	private static SynchronizationContext GetWinRTContext()
	{
		if (!AppDomain.IsAppXModel())
		{
			return null;
		}
		object winRTDispatcherForCurrentThread = GetWinRTDispatcherForCurrentThread();
		if (winRTDispatcherForCurrentThread != null)
		{
			return GetWinRTSynchronizationContextFactory().Create(winRTDispatcherForCurrentThread);
		}
		return null;
	}

	[SecurityCritical]
	private static WinRTSynchronizationContextFactoryBase GetWinRTSynchronizationContextFactory()
	{
		WinRTSynchronizationContextFactoryBase winRTSynchronizationContextFactoryBase = s_winRTContextFactory;
		if (winRTSynchronizationContextFactoryBase == null)
		{
			Type type = Type.GetType("System.Threading.WinRTSynchronizationContextFactory, System.Runtime.WindowsRuntime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", throwOnError: true);
			winRTSynchronizationContextFactoryBase = (s_winRTContextFactory = (WinRTSynchronizationContextFactoryBase)Activator.CreateInstance(type, nonPublic: true));
		}
		return winRTSynchronizationContextFactoryBase;
	}

	[DllImport("QCall", CharSet = CharSet.Unicode)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Interface)]
	private static extern object GetWinRTDispatcherForCurrentThread();

	[__DynamicallyInvokable]
	public virtual SynchronizationContext CreateCopy()
	{
		return new SynchronizationContext();
	}

	[SecurityCritical]
	private static int InvokeWaitMethodHelper(SynchronizationContext syncContext, IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
	{
		return syncContext.Wait(waitHandles, waitAll, millisecondsTimeout);
	}
}
