using System.Runtime.CompilerServices;
using System.Threading.NetCore;

namespace System.Threading;

internal sealed class TimerHolder
{
	private object m_timer;

	private TimerQueueTimer NetFxTimer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return (TimerQueueTimer)m_timer;
		}
	}

	private System.Threading.NetCore.TimerQueueTimer NetCoreTimer
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return (System.Threading.NetCore.TimerQueueTimer)m_timer;
		}
	}

	public TimerHolder(object timer)
	{
		m_timer = timer;
	}

	~TimerHolder()
	{
		if (!Environment.HasShutdownStarted && !AppDomain.CurrentDomain.IsFinalizingForUnload())
		{
			if (Timer.UseNetCoreTimer)
			{
				NetCoreTimer.Close();
			}
			else
			{
				NetFxTimer.Close();
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Change(uint dueTime, uint period)
	{
		if (!Timer.UseNetCoreTimer)
		{
			return NetFxTimer.Change(dueTime, period);
		}
		return NetCoreTimer.Change(dueTime, period);
	}

	public void Close()
	{
		if (Timer.UseNetCoreTimer)
		{
			NetCoreTimer.Close();
		}
		else
		{
			NetFxTimer.Close();
		}
		GC.SuppressFinalize(this);
	}

	public bool Close(WaitHandle notifyObject)
	{
		bool result = (Timer.UseNetCoreTimer ? NetCoreTimer.Close(notifyObject) : NetFxTimer.Close(notifyObject));
		GC.SuppressFinalize(this);
		return result;
	}
}
