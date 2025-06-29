using System.Threading;

namespace b1;

public class GSDeadlockDetector
{
	public const int CheckInterval = 10000;

	private long incrementCounter = 1L;

	private long incrementLast;

	private Thread mMainThread;

	public bool HaveDeadlock;

	public void Init()
	{
		mMainThread = Thread.CurrentThread;
		new Thread(ThreadFunc).Start();
	}

	private void ThreadFunc()
	{
		Runloop();
	}

	public void Increment()
	{
		incrementCounter++;
	}

	private void Runloop()
	{
		while (true)
		{
			incrementLast = incrementCounter;
		}
	}
}
