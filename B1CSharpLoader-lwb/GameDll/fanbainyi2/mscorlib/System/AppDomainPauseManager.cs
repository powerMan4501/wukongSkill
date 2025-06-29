using System.Security;
using System.Threading;

namespace System;

[SecurityCritical]
internal class AppDomainPauseManager
{
	private static readonly AppDomainPauseManager instance;

	private static volatile bool isPaused;

	internal static AppDomainPauseManager Instance
	{
		[SecurityCritical]
		get
		{
			return instance;
		}
	}

	internal static bool IsPaused
	{
		[SecurityCritical]
		get
		{
			return isPaused;
		}
	}

	internal static ManualResetEvent ResumeEvent
	{
		[SecurityCritical]
		get;
		[SecurityCritical]
		set;
	}

	[SecurityCritical]
	public AppDomainPauseManager()
	{
		isPaused = false;
	}

	[SecurityCritical]
	static AppDomainPauseManager()
	{
		instance = new AppDomainPauseManager();
	}

	[SecurityCritical]
	public void Pausing()
	{
	}

	[SecurityCritical]
	public void Paused()
	{
		if (ResumeEvent == null)
		{
			ResumeEvent = new ManualResetEvent(initialState: false);
		}
		else
		{
			ResumeEvent.Reset();
		}
		Timer.Pause();
		isPaused = true;
	}

	[SecurityCritical]
	public void Resuming()
	{
		isPaused = false;
		ResumeEvent.Set();
	}

	[SecurityCritical]
	public void Resumed()
	{
		Timer.Resume();
	}
}
