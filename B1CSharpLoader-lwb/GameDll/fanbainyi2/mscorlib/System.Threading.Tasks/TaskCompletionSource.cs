using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Security.Permissions;

namespace System.Threading.Tasks;

[__DynamicallyInvokable]
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public class TaskCompletionSource<TResult>
{
	private readonly Task<TResult> m_task;

	[__DynamicallyInvokable]
	public Task<TResult> Task
	{
		[__DynamicallyInvokable]
		get
		{
			return m_task;
		}
	}

	[__DynamicallyInvokable]
	public TaskCompletionSource()
	{
		m_task = new Task<TResult>();
	}

	[__DynamicallyInvokable]
	public TaskCompletionSource(TaskCreationOptions creationOptions)
		: this((object)null, creationOptions)
	{
	}

	[__DynamicallyInvokable]
	public TaskCompletionSource(object state)
		: this(state, TaskCreationOptions.None)
	{
	}

	[__DynamicallyInvokable]
	public TaskCompletionSource(object state, TaskCreationOptions creationOptions)
	{
		m_task = new Task<TResult>(state, creationOptions);
	}

	private void SpinUntilCompleted()
	{
		SpinWait spinWait = default(SpinWait);
		while (!m_task.IsCompleted)
		{
			spinWait.SpinOnce();
		}
	}

	[__DynamicallyInvokable]
	public bool TrySetException(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		bool flag = m_task.TrySetException(exception);
		if (!flag && !m_task.IsCompleted)
		{
			SpinUntilCompleted();
		}
		return flag;
	}

	[__DynamicallyInvokable]
	public bool TrySetException(IEnumerable<Exception> exceptions)
	{
		if (exceptions == null)
		{
			throw new ArgumentNullException("exceptions");
		}
		List<Exception> list = new List<Exception>();
		foreach (Exception exception in exceptions)
		{
			if (exception == null)
			{
				throw new ArgumentException(Environment.GetResourceString("TaskCompletionSourceT_TrySetException_NullException"), "exceptions");
			}
			list.Add(exception);
		}
		if (list.Count == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("TaskCompletionSourceT_TrySetException_NoExceptions"), "exceptions");
		}
		bool flag = m_task.TrySetException(list);
		if (!flag && !m_task.IsCompleted)
		{
			SpinUntilCompleted();
		}
		return flag;
	}

	internal bool TrySetException(IEnumerable<ExceptionDispatchInfo> exceptions)
	{
		bool flag = m_task.TrySetException(exceptions);
		if (!flag && !m_task.IsCompleted)
		{
			SpinUntilCompleted();
		}
		return flag;
	}

	[__DynamicallyInvokable]
	public void SetException(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		if (!TrySetException(exception))
		{
			throw new InvalidOperationException(Environment.GetResourceString("TaskT_TransitionToFinal_AlreadyCompleted"));
		}
	}

	[__DynamicallyInvokable]
	public void SetException(IEnumerable<Exception> exceptions)
	{
		if (!TrySetException(exceptions))
		{
			throw new InvalidOperationException(Environment.GetResourceString("TaskT_TransitionToFinal_AlreadyCompleted"));
		}
	}

	[__DynamicallyInvokable]
	public bool TrySetResult(TResult result)
	{
		bool flag = m_task.TrySetResult(result);
		if (!flag && !m_task.IsCompleted)
		{
			SpinUntilCompleted();
		}
		return flag;
	}

	[__DynamicallyInvokable]
	public void SetResult(TResult result)
	{
		if (!TrySetResult(result))
		{
			throw new InvalidOperationException(Environment.GetResourceString("TaskT_TransitionToFinal_AlreadyCompleted"));
		}
	}

	[__DynamicallyInvokable]
	public bool TrySetCanceled()
	{
		return TrySetCanceled(default(CancellationToken));
	}

	[__DynamicallyInvokable]
	public bool TrySetCanceled(CancellationToken cancellationToken)
	{
		bool flag = m_task.TrySetCanceled(cancellationToken);
		if (!flag && !m_task.IsCompleted)
		{
			SpinUntilCompleted();
		}
		return flag;
	}

	[__DynamicallyInvokable]
	public void SetCanceled()
	{
		if (!TrySetCanceled())
		{
			throw new InvalidOperationException(Environment.GetResourceString("TaskT_TransitionToFinal_AlreadyCompleted"));
		}
	}
}
