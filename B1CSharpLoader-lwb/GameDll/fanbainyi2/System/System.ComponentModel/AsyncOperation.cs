using System.Security.Permissions;
using System.Threading;

namespace System.ComponentModel;

[global::__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
public sealed class AsyncOperation
{
	private SynchronizationContext syncContext;

	private object userSuppliedState;

	private bool alreadyCompleted;

	[global::__DynamicallyInvokable]
	public object UserSuppliedState
	{
		[global::__DynamicallyInvokable]
		get
		{
			return userSuppliedState;
		}
	}

	[global::__DynamicallyInvokable]
	public SynchronizationContext SynchronizationContext
	{
		[global::__DynamicallyInvokable]
		get
		{
			return syncContext;
		}
	}

	private AsyncOperation(object userSuppliedState, SynchronizationContext syncContext)
	{
		this.userSuppliedState = userSuppliedState;
		this.syncContext = syncContext;
		alreadyCompleted = false;
		this.syncContext.OperationStarted();
	}

	~AsyncOperation()
	{
		if (!alreadyCompleted && syncContext != null)
		{
			syncContext.OperationCompleted();
		}
	}

	[global::__DynamicallyInvokable]
	public void Post(SendOrPostCallback d, object arg)
	{
		VerifyNotCompleted();
		VerifyDelegateNotNull(d);
		syncContext.Post(d, arg);
	}

	[global::__DynamicallyInvokable]
	public void PostOperationCompleted(SendOrPostCallback d, object arg)
	{
		Post(d, arg);
		OperationCompletedCore();
	}

	[global::__DynamicallyInvokable]
	public void OperationCompleted()
	{
		VerifyNotCompleted();
		OperationCompletedCore();
	}

	private void OperationCompletedCore()
	{
		try
		{
			syncContext.OperationCompleted();
		}
		finally
		{
			alreadyCompleted = true;
			GC.SuppressFinalize(this);
		}
	}

	private void VerifyNotCompleted()
	{
		if (alreadyCompleted)
		{
			throw new InvalidOperationException(SR.GetString("Async_OperationAlreadyCompleted"));
		}
	}

	private void VerifyDelegateNotNull(SendOrPostCallback d)
	{
		if (d == null)
		{
			throw new ArgumentNullException(SR.GetString("Async_NullDelegate"), "d");
		}
	}

	internal static AsyncOperation CreateOperation(object userSuppliedState, SynchronizationContext syncContext)
	{
		return new AsyncOperation(userSuppliedState, syncContext);
	}
}
