using System.Collections.Generic;
using b1.EventDelDefine;

namespace b1;

public class BGS_BattleTriggerMgr : GameStateSystemBase
{
	private Dictionary<string, List<string>> BattleTriggerControlUnits = new Dictionary<string, List<string>>();

	public override void OnAttach()
	{
		base.BGSEventCollection.Evt_BGS_BattleTriggerMarkUnitControl += new Del_MarkUnitControl(BattleTriggerMarkUnitControl);
		base.BGSEventCollection.Evt_BGS_BattleTriggerUnMarkUnitControl += new Del_Void_String(BattleTriggerUnMarkUnitControl);
	}

	public override void OnBeginPlay()
	{
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
		foreach (string UnitGuid in UnitGuids)
		{
			base.BGSEventCollection.Evt_MarkTamerAlwaysSpawn.Invoke(UnitGuid);
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
		foreach (KeyValuePair<string, List<string>> BattleTriggerMarks in BattleTriggerControlUnits)
		{
			list.RemoveAll((string r) => BattleTriggerMarks.Value.Contains(r));
		}
		foreach (string item in list)
		{
			base.BGSEventCollection.Evt_UnMarkTamerAlwaysSpawn.Invoke(item);
		}
	}
}
