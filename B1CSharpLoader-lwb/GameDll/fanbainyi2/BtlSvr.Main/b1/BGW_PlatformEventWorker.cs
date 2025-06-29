using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace b1;

public class BGW_PlatformEventWorker
{
	public class AsyncTaskContext
	{
		public PlatformEvent Event;

		public Task AsyncTaskThreadHandler;
	}

	private BGW_PlatformEventExecMgr _Parent;

	private AsyncTaskContext _BackgroundRunningTask;

	private Queue<PlatformEvent> _PendingSendRequests = new Queue<PlatformEvent>();

	private double EventInterval;

	public BGW_PlatformEventWorker(BGW_PlatformEventExecMgr Parent)
	{
		_Parent = Parent;
	}

	private void ResetEventInterval()
	{
		EventInterval = DebugConfig.PlatformEventSendIntervalMilliSecond;
	}

	private PlatformEvent DequeueRequest()
	{
		if (_PendingSendRequests.Count > 0)
		{
			return _PendingSendRequests.Dequeue();
		}
		return null;
	}

	public void EnqueueRequest(List<PlatformEvent> TodoEventTasks)
	{
		foreach (PlatformEvent TodoEventTask in TodoEventTasks)
		{
			_PendingSendRequests.Enqueue(TodoEventTask);
		}
	}

	private void CheckTaskResult()
	{
		if (_BackgroundRunningTask != null && _BackgroundRunningTask.Event.IsCompleted && EventInterval <= 0.0)
		{
			_BackgroundRunningTask = null;
		}
		if (_BackgroundRunningTask == null && _PendingSendRequests.Count > 0 && EventInterval <= 0.0)
		{
			_BackgroundRunningTask = new AsyncTaskContext
			{
				Event = DequeueRequest()
			};
			_BackgroundRunningTask.AsyncTaskThreadHandler = Task.Run(_BackgroundRunningTask.Event.GetAction());
			ResetEventInterval();
		}
	}

	public void MarkTaskCompleted()
	{
		if (_BackgroundRunningTask == null)
		{
			BGW_LogUtil.LogError("MarkTaskCompleted But _BackgroundRunningTask == null");
			throw new Exception("MarkTaskCompleted But _BackgroundRunningTask == null");
		}
		_BackgroundRunningTask.Event.MarkCompleted();
	}

	private void TickRunAsyncTask(float DeltaTime)
	{
		CheckTaskResult();
	}

	private void TickCheckEventInterval(float DeltaTime)
	{
		if (_BackgroundRunningTask != null && _BackgroundRunningTask.Event.IsCompleted)
		{
			EventInterval -= DeltaTime * 1000f;
		}
	}

	public void Tick(float DeltaTime)
	{
		TickCheckEventInterval(DeltaTime);
		TickRunAsyncTask(DeltaTime);
	}
}
