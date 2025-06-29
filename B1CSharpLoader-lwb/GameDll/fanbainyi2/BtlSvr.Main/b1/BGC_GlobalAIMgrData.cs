using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_GlobalAIMgrData : IBGC_GlobalAIMgrData, IPersistentECSData
{
	public Dictionary<int, Dictionary<int, (float, string)>> GroupUnitCastSkillInfo = new Dictionary<int, Dictionary<int, (float, string)>>();

	public bool CheckSkillIsInGroup(int UnitResID, string UnitGuid, int SkillID, out float GroupLastCastTime)
	{
		GroupLastCastTime = -1f;
		if (GroupUnitCastSkillInfo.TryGetValue(UnitResID, out var value) && value.TryGetValue(SkillID, out var value2) && !value2.Item2.Equals(UnitGuid))
		{
			(GroupLastCastTime, _) = value2;
			return true;
		}
		return false;
	}

	public void MarkGroupCastSkill(int UnitResID, string UnitGuid, int SkillID, float NowTime)
	{
		if (GroupUnitCastSkillInfo.TryGetValue(UnitResID, out var _))
		{
			GroupUnitCastSkillInfo[UnitResID][SkillID] = (NowTime, UnitGuid);
			return;
		}
		GroupUnitCastSkillInfo[UnitResID] = new Dictionary<int, (float, string)> { 
		{
			SkillID,
			(NowTime, UnitGuid)
		} };
	}
}
