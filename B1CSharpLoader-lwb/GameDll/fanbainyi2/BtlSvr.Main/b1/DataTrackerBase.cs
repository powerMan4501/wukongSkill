using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public abstract class DataTrackerBase
{
	protected UObject WorldContext;

	protected BGW_UIEventCollection UIEventCollection;

	protected List<int> ReqList = new List<int>();

	public DataTrackerBase(UObject InWorldContext)
	{
		WorldContext = InWorldContext;
		UIEventCollection = BGW_UIEventCollection.Get(WorldContext);
	}

	public abstract ETrackerType GetTrackerType();

	public virtual void Start()
	{
	}

	public virtual void OnTick(float InDeltaTime)
	{
	}

	public virtual void Stop()
	{
	}

	public virtual void Reset()
	{
		int[] array = ReqList.ToArray();
		foreach (int reqId in array)
		{
			Release(reqId);
		}
	}

	public int Request(DebugDataBase DebugData)
	{
		int num = UIEventCollection.Evt_UI_DrawDebugData(DebugData);
		ReqList.Add(num);
		return num;
	}

	public void Reuse(int ReqId, DebugDataBase DebugData)
	{
		UIEventCollection.Evt_UI_ResetDebugData(ReqId, DebugData);
	}

	public void Release(int ReqId)
	{
		UIEventCollection.Evt_UI_StopDrawDebugData(ReqId);
		ReqList.Remove(ReqId);
	}

	public UObject GetWorldContext()
	{
		return WorldContext;
	}
}
