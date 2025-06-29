using System.Collections.Generic;

namespace b1.GSMUICore.Event;

public class GSMUIEventSequence : GSMUIEventBase
{
	public List<GSMUIEventBase> EventSeq = new List<GSMUIEventBase>();

	public GSMUIEventSequence()
		: base("GSMUIEventSequence")
	{
	}

	public void Clear()
	{
		EventSeq.Clear();
	}

	public void AddEvent(GSMUIEventBase OneEvent)
	{
		EventSeq.Insert(0, OneEvent);
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
		int index = EventSeq.Count - 1;
		EventSeq[index].DoGSTick(DeltaTime);
		if (!EventSeq[index].IsGSNeedTick())
		{
			EventSeq.RemoveAt(index);
		}
		return GSMUITickableStat.TICKING;
	}
}
