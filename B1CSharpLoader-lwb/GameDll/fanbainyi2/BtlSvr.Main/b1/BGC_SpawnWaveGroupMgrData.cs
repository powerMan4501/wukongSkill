using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_SpawnWaveGroupMgrData : IBGC_SpawnWaveGroupMgrData, IPersistentECSData
{
	public Dictionary<int, float> GroupCD_Dic { get; set; }

	public BGC_SpawnWaveGroupMgrData()
	{
		GroupCD_Dic = new Dictionary<int, float>();
	}

	public bool IsInCD(int GroupID)
	{
		return GroupCD_Dic.ContainsKey(GroupID);
	}

	public float GetGroupGlobleCD(int GroupID)
	{
		if (GroupCD_Dic.ContainsKey(GroupID))
		{
			return GroupCD_Dic[GroupID];
		}
		return -1f;
	}
}
