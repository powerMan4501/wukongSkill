using b1.GSMUI;

namespace b1.GSMUICore.Event;

public abstract class GSMUIEventBase : IGSMUITickable
{
	private static int GID;

	protected int ID;

	protected float RunTime;

	protected string EventName;

	private GSMUIEventStat EventStat;

	public GSMUIEventBase(string EventName)
	{
		GID++;
		ID = GID;
		EventStat = GSMUIEventStat.WORKING;
		this.EventName = EventName;
	}

	public virtual bool IsGSNeedTick()
	{
		if (EventStat == GSMUIEventStat.WORKING)
		{
			return true;
		}
		return false;
	}

	public void BindTickMgr(GSMUITickMgr _TickMgr)
	{
	}

	public void DoGSTick(float DeltaTime)
	{
		RunTime += DeltaTime;
		if (DoTickImpl(DeltaTime) == GSMUITickableStat.TICKING)
		{
			EventStat = GSMUIEventStat.WORKING;
		}
		else
		{
			EventStat = GSMUIEventStat.FINISH;
		}
	}

	public GSMUITickableStat GetCurrentTickState()
	{
		if (EventStat == GSMUIEventStat.WORKING)
		{
			return GSMUITickableStat.TICKING;
		}
		return GSMUITickableStat.IDLE;
	}

	public virtual void JumpToEnd()
	{
		DoGSTick(1E+09f);
	}

	public virtual void Stop()
	{
		RunTime += 1E+09f;
		EventStat = GSMUIEventStat.FINISH;
	}

	public bool IsUObjectDestroyed()
	{
		return false;
	}

	protected virtual GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		return GSMUITickableStat.IDLE;
	}
}
