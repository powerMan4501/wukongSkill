using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BPC_SyncTamerDataServer : IBPC_TamerSyncData, IPersistentECSData
{
	public List<FTamerRoleSync> GuidsWaingtingRoleSync = new List<FTamerRoleSync>();

	public List<string> TamerGuidWaitingSpawn = new List<string>();

	public void AddTamerSyncInfoWaitingSpawn(string Guid)
	{
		if (!TamerGuidWaitingSpawn.Contains(Guid))
		{
			TamerGuidWaitingSpawn.Add(Guid);
		}
		else
		{
			BGW_LogUtil.LogError("AddTamerSyncInfoWaitingSpawn " + Guid + " Duplicate");
		}
	}
}
