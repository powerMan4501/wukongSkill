using System.Collections.Generic;
using System.Threading;

namespace b1;

public class GSThreadPool
{
	public delegate void Del_VoidObj(object Arg);

	public class ThreadParam
	{
		public GSThreadPool MySelf;

		public int ThreadIdx;

		public ThreadParam(GSThreadPool mySelf, int threadIdx)
		{
			MySelf = mySelf;
			ThreadIdx = threadIdx;
		}
	}

	public struct TaskData
	{
		private long TaskMask;

		public void AddPrerequiste(ref TaskData Pre)
		{
		}

		public bool HasPrerequiste()
		{
			return TaskMask != 0;
		}
	}

	private struct TaskItem
	{
		public Del_VoidObj Func;

		public object Arg;
	}

	private class TaskThreadData
	{
		public Queue<TaskItem> TaskQueue = new Queue<TaskItem>();

		public AutoResetEvent SleepEvent = new AutoResetEvent(initialState: false);

		public Thread ThreadInst;

		public bool Running;
	}

	private TaskThreadData SlowTaskThreadData = new TaskThreadData();

	private TaskThreadData FastTaskThreadData = new TaskThreadData();

	public const int ThreadCount = 3;

	private static bool DestroyThread;

	public static GSThreadPool Instance { get; private set; }

	static GSThreadPool()
	{
		Instance = new GSThreadPool();
	}

	public GSThreadPool()
	{
		SlowTaskThreadData.ThreadInst = new Thread(SlowTaskThreadFunc);
		SlowTaskThreadData.ThreadInst.Priority = ThreadPriority.BelowNormal;
		SlowTaskThreadData.ThreadInst.Start(new ThreadParam(this, 0));
		FastTaskThreadData.ThreadInst = new Thread(FastTaskThreadFunc);
		FastTaskThreadData.ThreadInst.Start(new ThreadParam(this, 0));
	}

	public TaskData QueueFastTask(TaskData Prerequiste, Del_VoidObj TaskFunc, object TaskArg)
	{
		TaskData result = default(TaskData);
		lock (FastTaskThreadData.TaskQueue)
		{
			FastTaskThreadData.TaskQueue.Enqueue(new TaskItem
			{
				Func = TaskFunc,
				Arg = TaskArg
			});
		}
		FastTaskThreadData.SleepEvent.Set();
		return result;
	}

	public void QueueSlowTask(Del_VoidObj TaskFunc, object TaskArg)
	{
		lock (SlowTaskThreadData.TaskQueue)
		{
			SlowTaskThreadData.TaskQueue.Enqueue(new TaskItem
			{
				Func = TaskFunc,
				Arg = TaskArg
			});
		}
		SlowTaskThreadData.SleepEvent.Set();
	}

	public void GameThread_FlushFastTasks()
	{
		_ = FastTaskThreadData.TaskQueue.Count;
		int num = 0;
		while (FastTaskThreadData.TaskQueue.Count > 0 || FastTaskThreadData.Running)
		{
			FastTaskThreadData.SleepEvent.Set();
			Thread.Sleep(1);
			num++;
		}
	}

	private static void RunTaskThreadFuncImpl(TaskThreadData Data, int WaitTime)
	{
		Queue<TaskItem> queue = new Queue<TaskItem>();
		while (!DestroyThread)
		{
			lock (Data.TaskQueue)
			{
				while (Data.TaskQueue.Count > 0)
				{
					Data.Running = true;
					queue.Enqueue(Data.TaskQueue.Dequeue());
				}
			}
			while (queue.Count > 0)
			{
				TaskItem taskItem = queue.Dequeue();
				if (taskItem.Func != null)
				{
					taskItem.Func(taskItem.Arg);
				}
				taskItem.Func = null;
				taskItem.Arg = null;
			}
			Data.Running = false;
			if (Data.TaskQueue.Count == 0)
			{
				Data.SleepEvent.WaitOne(WaitTime);
			}
		}
	}

	private static void FastTaskThreadFunc(object Data)
	{
		RunTaskThreadFuncImpl(((ThreadParam)Data).MySelf.FastTaskThreadData, 1);
	}

	private static void SlowTaskThreadFunc(object Data)
	{
		RunTaskThreadFuncImpl(((ThreadParam)Data).MySelf.SlowTaskThreadData, 100);
	}
}
