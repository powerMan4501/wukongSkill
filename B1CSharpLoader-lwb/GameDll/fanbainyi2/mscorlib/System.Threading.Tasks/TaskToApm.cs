using System.IO;

namespace System.Threading.Tasks;

internal static class TaskToApm
{
	private sealed class TaskWrapperAsyncResult : IAsyncResult
	{
		internal readonly Task Task;

		private readonly object m_state;

		private readonly bool m_completedSynchronously;

		object IAsyncResult.AsyncState => m_state;

		bool IAsyncResult.CompletedSynchronously => m_completedSynchronously;

		bool IAsyncResult.IsCompleted => Task.IsCompleted;

		WaitHandle IAsyncResult.AsyncWaitHandle => ((IAsyncResult)Task).AsyncWaitHandle;

		internal TaskWrapperAsyncResult(Task task, object state, bool completedSynchronously)
		{
			Task = task;
			m_state = state;
			m_completedSynchronously = completedSynchronously;
		}
	}

	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state)
	{
		IAsyncResult asyncResult;
		if (task.IsCompleted)
		{
			asyncResult = new TaskWrapperAsyncResult(task, state, completedSynchronously: true);
			callback?.Invoke(asyncResult);
		}
		else
		{
			IAsyncResult asyncResult3;
			if (task.AsyncState != state)
			{
				IAsyncResult asyncResult2 = new TaskWrapperAsyncResult(task, state, completedSynchronously: false);
				asyncResult3 = asyncResult2;
			}
			else
			{
				IAsyncResult asyncResult2 = task;
				asyncResult3 = asyncResult2;
			}
			asyncResult = asyncResult3;
			if (callback != null)
			{
				InvokeCallbackWhenTaskCompletes(task, callback, asyncResult);
			}
		}
		return asyncResult;
	}

	public static void End(IAsyncResult asyncResult)
	{
		Task task = ((!(asyncResult is TaskWrapperAsyncResult taskWrapperAsyncResult)) ? (asyncResult as Task) : taskWrapperAsyncResult.Task);
		if (task == null)
		{
			__Error.WrongAsyncResult();
		}
		task.GetAwaiter().GetResult();
	}

	public static TResult End<TResult>(IAsyncResult asyncResult)
	{
		Task<TResult> task = ((!(asyncResult is TaskWrapperAsyncResult taskWrapperAsyncResult)) ? (asyncResult as Task<TResult>) : (taskWrapperAsyncResult.Task as Task<TResult>));
		if (task == null)
		{
			__Error.WrongAsyncResult();
		}
		return task.GetAwaiter().GetResult();
	}

	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult)
	{
		antecedent.ConfigureAwait(continueOnCapturedContext: false).GetAwaiter().OnCompleted(delegate
		{
			callback(asyncResult);
		});
	}
}
