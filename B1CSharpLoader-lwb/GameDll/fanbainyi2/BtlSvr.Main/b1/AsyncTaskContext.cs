using System;
using System.Threading.Tasks;

namespace b1;

public class AsyncTaskContext
{
	private ArchiveAsyncRequest WriteRequest;

	private Task<AsyncTaskRunResult> AsyncTaskThreadHandler;

	public void Clear()
	{
		WriteRequest = null;
		AsyncTaskThreadHandler = null;
	}

	public void StartRunNewTask(ArchiveAsyncRequest WriteRequest)
	{
		this.WriteRequest = WriteRequest;
		AsyncTaskThreadHandler = Task.Run(() => this.WriteRequest.RunTask());
	}

	public void CheckTaskComplete()
	{
		if (AsyncTaskThreadHandler != null && AsyncTaskThreadHandler.IsCompleted)
		{
			WriteRequest.OnTaskFinish(AsyncTaskThreadHandler.Result);
			Clear();
		}
	}

	public bool IsTaskEmpty()
	{
		return AsyncTaskThreadHandler == null;
	}

	public bool HaveRunningTask(Type CheckTaskType = null)
	{
		if (AsyncTaskThreadHandler != null)
		{
			if (CheckTaskType != null)
			{
				return WriteRequest.GetType() == CheckTaskType;
			}
			return true;
		}
		return false;
	}
}
