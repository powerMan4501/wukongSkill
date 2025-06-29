using System;
using System.Threading;

namespace b1;

public class ThreadTickDispatcher
{
	public delegate void Del_VoidInt(int Arg);

	public class ThreadParam
	{
		public ThreadTickDispatcher MySelf;

		public int ThreadIdx;

		public ThreadParam(ThreadTickDispatcher mySelf, int threadIdx)
		{
			MySelf = mySelf;
			ThreadIdx = threadIdx;
		}
	}

	public const int MAX_THREADCOUNT = 4;

	private Thread[] Threads;

	private AutoResetEvent[] BeginEvents;

	private AutoResetEvent[] EndEvents;

	private bool HasBegun;

	private bool Destroyed;

	private Del_VoidInt Func;

	public void OnDestroy()
	{
		Destroyed = false;
	}

	private void InitThreadsIfNeeded()
	{
		if (Threads == null)
		{
			Threads = new Thread[4];
			BeginEvents = new AutoResetEvent[4];
			EndEvents = new AutoResetEvent[4];
			for (int i = 0; i < 4; i++)
			{
				BeginEvents[i] = new AutoResetEvent(initialState: false);
				EndEvents[i] = new AutoResetEvent(initialState: false);
				Threads[i] = new Thread(ThreadFunc);
				Threads[i].Start(new ThreadParam(this, i));
			}
		}
	}

	private static void ThreadFunc(object Data)
	{
		ThreadParam threadParam = (ThreadParam)Data;
		while (!threadParam.MySelf.Destroyed)
		{
			threadParam.MySelf.BeginEvents[threadParam.ThreadIdx].WaitOne();
			threadParam.MySelf.Func(threadParam.ThreadIdx);
			threadParam.MySelf.EndEvents[threadParam.ThreadIdx].Set();
		}
	}

	public void BeginThreadGroup(Del_VoidInt TickFunc)
	{
		InitThreadsIfNeeded();
		if (HasBegun)
		{
			throw new Exception("not support begin thread overlapping");
		}
		HasBegun = true;
		Func = TickFunc;
		for (int i = 0; i < 4; i++)
		{
			BeginEvents[i].Set();
		}
	}

	public void EndThreadGroup()
	{
		if (HasBegun)
		{
			for (int i = 0; i < 4; i++)
			{
				EndEvents[i].WaitOne();
			}
			HasBegun = false;
		}
	}
}
