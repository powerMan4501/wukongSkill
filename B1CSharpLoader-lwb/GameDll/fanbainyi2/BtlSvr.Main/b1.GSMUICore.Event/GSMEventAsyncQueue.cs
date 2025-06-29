using System.Collections.Generic;

namespace b1.GSMUICore.Event;

public class GSMEventAsyncQueue : GSMUIEventBase
{
	public List<GSMUIEventBase> EventSeq = new List<GSMUIEventBase>();

	public GSMEventAsyncQueue()
		: base("GSMEventAsyncQueue")
	{
	}

	public void AddEvent(GSMUIEventBase OneEvent)
	{
		EventSeq.Insert(0, OneEvent);
	}

	public void Clear()
	{
		EventSeq.Clear();
	}

	public bool IsWorking()
	{
		if (EventSeq.Count > 0)
		{
			return true;
		}
		return false;
	}

	protected override GSMUITickableStat DoTickImpl(float DeltaTime)
	{
		if (EventSeq.Count == 0)
		{
			return GSMUITickableStat.IDLE;
		}
		for (int num = EventSeq.Count - 1; num >= 0; num--)
		{
			EventSeq[num].DoGSTick(DeltaTime);
			if (EventSeq[num].GetCurrentTickState() == GSMUITickableStat.IDLE)
			{
				EventSeq.RemoveAt(num);
			}
		}
		return GSMUITickableStat.TICKING;
	}
}
