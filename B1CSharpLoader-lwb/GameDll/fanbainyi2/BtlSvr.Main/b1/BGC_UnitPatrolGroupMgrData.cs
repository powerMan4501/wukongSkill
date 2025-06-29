using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BGC_UnitPatrolGroupMgrData : IBGC_UnitPatrolGroupMgrData, IPersistentECSData
{
	public bool IsPatrolGroupMgrInited;

	public List<PatrolGroupInfo> PatrolGroups;

	public BGWDataAsset_PatrolGroupSettings PatrolGroupDA;

	public Dictionary<string, PatrolUnitInfo> ActivatedUnitInfoCache;

	public List<int> ActivatedGroupsIndex;

	public PatrolUnitInfo TryFindPatrolUnitInfo(string UnitGuid)
	{
		if (PatrolGroups == null)
		{
			return null;
		}
		for (int i = 0; i < PatrolGroups.Count; i++)
		{
			List<string> groupMembersGuid = PatrolGroups[i].GroupMembersGuid;
			for (int j = 0; j < groupMembersGuid.Count; j++)
			{
				if (groupMembersGuid[j] == UnitGuid)
				{
					return new PatrolUnitInfo(i, j);
				}
			}
		}
		return null;
	}
}
