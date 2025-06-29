using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_BattleTriggerMgr")]
public class BGW_BattleTriggerMgr : GameInstanceSystemBaseUObj
{
	private Dictionary<string, List<string>> BattleTriggerControlUnits = new Dictionary<string, List<string>>();

	public static BGW_BattleTriggerMgr Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_BattleTriggerMgr>(WorldContext);
	}

	public void BattleTriggerMarkUnitControl(string BattleTriggerGuid, ICollection<string> UnitGuids)
	{
		if (BattleTriggerControlUnits.ContainsKey(BattleTriggerGuid))
		{
			BattleTriggerControlUnits[BattleTriggerGuid] = new List<string>(UnitGuids);
		}
		else
		{
			BattleTriggerControlUnits.Add(BattleTriggerGuid, new List<string>(UnitGuids));
		}
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection == null)
		{
			return;
		}
		foreach (string UnitGuid in UnitGuids)
		{
			bGS_GSEventCollection.Evt_MarkTamerAlwaysSpawn.Invoke(UnitGuid);
		}
	}

	public void BattleTriggerUnMarkUnitControl(string BattleTriggerGuid)
	{
		if (!BattleTriggerControlUnits.ContainsKey(BattleTriggerGuid))
		{
			return;
		}
		List<string> list = BattleTriggerControlUnits[BattleTriggerGuid];
		BattleTriggerControlUnits.Remove(BattleTriggerGuid);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection == null)
		{
			return;
		}
		foreach (KeyValuePair<string, List<string>> BattleTriggerMarks in BattleTriggerControlUnits)
		{
			list.RemoveAll((string r) => BattleTriggerMarks.Value.Contains(r));
		}
		foreach (string item in list)
		{
			bGS_GSEventCollection.Evt_UnMarkTamerAlwaysSpawn.Invoke(item);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_BattleTriggerMgr");
	}

	static BGW_BattleTriggerMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_BattleTriggerMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_BattleTriggerMgr));
	}
}
