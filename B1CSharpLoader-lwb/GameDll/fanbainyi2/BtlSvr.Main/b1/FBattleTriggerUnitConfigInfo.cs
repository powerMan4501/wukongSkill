using System.Collections.Generic;

namespace b1;

public class FBattleTriggerUnitConfigInfo
{
	public string UnitGuid;

	public int SwitchTeamID;

	public List<string> TargetUnitGuid;

	public FBattleTriggerUnitConfigInfo(FBattleTriggerUnitConfig BattleTriggerConfig)
	{
		UnitGuid = BattleTriggerConfig.Unit.ActorGuid;
		SwitchTeamID = BattleTriggerConfig.SwitchTeamID;
		TargetUnitGuid = new List<string>();
		foreach (FGsActorGuidReference item in BattleTriggerConfig.TargetUnit)
		{
			TargetUnitGuid.Add(item.ActorGuid);
		}
	}
}
