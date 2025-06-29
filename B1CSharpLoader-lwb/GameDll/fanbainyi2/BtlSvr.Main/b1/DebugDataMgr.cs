using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.Runtime;

namespace b1;

public class DebugDataMgr
{
	private UObject WorldContext;

	private Dictionary<ETrackerType, DataTrackerBase> TrackerDic = new Dictionary<ETrackerType, DataTrackerBase>();

	private List<DataTrackerBase> ActiveTrackerList = new List<DataTrackerBase>();

	public DebugDataMgr(UObject InWorldContext)
	{
		WorldContext = InWorldContext;
		SeqDataTracker seqDataTracker = new SeqDataTracker(WorldContext);
		TrackerDic.Add(seqDataTracker.GetTrackerType(), seqDataTracker);
		UIDataTracker uIDataTracker = new UIDataTracker(WorldContext);
		TrackerDic.Add(uIDataTracker.GetTrackerType(), uIDataTracker);
		MemoryDataTracker memoryDataTracker = new MemoryDataTracker(WorldContext);
		TrackerDic.Add(memoryDataTracker.GetTrackerType(), memoryDataTracker);
	}

	public void OnTick(float InDetaTime)
	{
		CheckInitTracker();
		foreach (DataTrackerBase activeTracker in ActiveTrackerList)
		{
			activeTracker.OnTick(InDetaTime);
		}
	}

	private void CheckInitTracker()
	{
		List<DataTrackerBase> list = new List<DataTrackerBase>();
		if (DebugConfig.IsShowDebugDrawUI)
		{
			string[] array = DebugConfig.DebugDrawTag.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				if (Enum.TryParse<ETrackerType>(array[i], ignoreCase: true, out var result) && TrackerDic.TryGetValue(result, out var value))
				{
					list.Add(value);
				}
			}
		}
		IEnumerable<DataTrackerBase> enumerable = ActiveTrackerList.Except(list);
		if (enumerable != null)
		{
			foreach (DataTrackerBase item in enumerable)
			{
				item.Reset();
				item.Stop();
			}
		}
		if (list.Except(ActiveTrackerList) != null)
		{
			foreach (DataTrackerBase item2 in enumerable)
			{
				item2.Start();
			}
		}
		ActiveTrackerList = list;
	}

	public static bool GetIsTrackerOpen(ETrackerType InTrackerType)
	{
		if (DebugConfig.IsShowDebugDrawUI)
		{
			string[] array = DebugConfig.DebugDrawTag.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				if (Enum.TryParse<ETrackerType>(array[i], ignoreCase: true, out var result) && result == InTrackerType)
				{
					return true;
				}
			}
		}
		return false;
	}
}
