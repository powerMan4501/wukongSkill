using System.Collections.Generic;

namespace b1.GSMUI;

public class GSMUITickMgr
{
	private List<IGSMUITickable> TickingQueue = new List<IGSMUITickable>();

	public int DoGSTicking(float DeltaTime)
	{
		int num = 0;
		for (int num2 = TickingQueue.Count - 1; num2 >= 0; num2--)
		{
			num++;
			if (TickingQueue[num2].IsUObjectDestroyed())
			{
				TickingQueue.RemoveAt(num2);
			}
			else
			{
				TickingQueue[num2].DoGSTick(DeltaTime);
				if (!TickingQueue[num2].IsGSNeedTick())
				{
					TickingQueue.RemoveAt(num2);
				}
			}
		}
		return num;
	}

	public bool RemoveTickingQueue(IGSMUITickable TickableObj)
	{
		return TickingQueue.Remove(TickableObj);
	}

	public void AppendTickingQueue(IGSMUITickable TickableObj)
	{
		SetTickingQueue(TickableObj);
	}

	public void SetTickingQueue(IGSMUITickable TickableObj)
	{
		for (int i = 0; i < TickingQueue.Count; i++)
		{
			if (TickingQueue[i] == TickableObj)
			{
				return;
			}
		}
		TickingQueue.Add(TickableObj);
	}

	public void Clear()
	{
		TickingQueue.Clear();
	}
}
