using System.Collections.Generic;
using System.Linq;
using b1.EventDelDefine;

namespace b1;

public class BGS_SpawnWaveGroupMgr : GameStateSystemBase
{
	private BGC_SpawnWaveGroupMgrData SpawnWaveGroupMgrData { get; set; }

	public override void OnAttach()
	{
		SpawnWaveGroupMgrData = RequireWritableData<BGC_SpawnWaveGroupMgrData>();
		base.BGSEventCollection.Evt_BGS_HandleSpawnWaveGroupCD += new Del_Void_IntFloat(HandleGroupCD);
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (SpawnWaveGroupMgrData.GroupCD_Dic.Count < 1)
		{
			return;
		}
		for (int num = SpawnWaveGroupMgrData.GroupCD_Dic.Count - 1; num >= 0; num--)
		{
			KeyValuePair<int, float> keyValuePair = SpawnWaveGroupMgrData.GroupCD_Dic.ElementAt(num);
			int key = keyValuePair.Key;
			float num2 = keyValuePair.Value - DeltaTime;
			if (num2 < 0f)
			{
				SpawnWaveGroupMgrData.GroupCD_Dic.Remove(key);
			}
			else
			{
				SpawnWaveGroupMgrData.GroupCD_Dic[key] = num2;
			}
		}
	}

	private void HandleGroupCD(int GroupID, float GlobleCD)
	{
		if (SpawnWaveGroupMgrData.GroupCD_Dic.ContainsKey(GroupID))
		{
			SpawnWaveGroupMgrData.GroupCD_Dic[GroupID] = GlobleCD;
		}
		else
		{
			SpawnWaveGroupMgrData.GroupCD_Dic.Add(GroupID, GlobleCD);
		}
	}
}
