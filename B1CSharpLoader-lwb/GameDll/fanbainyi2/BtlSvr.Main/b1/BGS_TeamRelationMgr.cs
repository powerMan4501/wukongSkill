using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
public class BGS_TeamRelationMgr : GameStateSystemBase
{
	private BGC_TeamRelationData TeamRelationData;

	public override void OnAttach()
	{
		TeamRelationData = RequireWritableData<BGC_TeamRelationData>();
		Dictionary<int, FUStTeamRelationConfigDesc> allTeamRelationConfigDesc = BGW_GameDB.GetAllTeamRelationConfigDesc();
		foreach (KeyValuePair<int, FUStTeamRelationConfigDesc> item in allTeamRelationConfigDesc)
		{
			TeamRelationInfo teamRelationInfo = new TeamRelationInfo();
			string[] array = item.Value.AntiRuleTeamIDs.Split(',');
			List<int> list = new List<int>();
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				if (int.TryParse(array2[i], out var result))
				{
					list.Add(result);
				}
			}
			if (item.Value.RelationRuleType == 0)
			{
				foreach (KeyValuePair<int, FUStTeamRelationConfigDesc> item2 in allTeamRelationConfigDesc)
				{
					if (!list.Contains(item2.Key) && item2.Key != item.Key)
					{
						teamRelationInfo.HostileTeamIDs.Add(item2.Key);
					}
				}
			}
			else
			{
				teamRelationInfo.HostileTeamIDs.AddRange(list);
			}
			array2 = item.Value.TeamDamageReductionConfig.Split(new char[1] { ')' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(new char[2] { '(', ',' }, StringSplitOptions.RemoveEmptyEntries);
				if (array3.Length == 2 && int.TryParse(array3[0], out var result2) && int.TryParse(array3[1], out var result3))
				{
					teamRelationInfo.TeamDamageReductionRatios.Add(result2, result3);
				}
			}
			TeamRelationData.TeamHostileInfos.Add(item.Key, teamRelationInfo);
		}
	}
}
