using b1.EventDelDefine;

namespace b1;

internal class BGS_LevelBattleSystem : GameStateSystemBase
{
	private BGC_LevelBattleData LevelBattleData;

	public override void OnAttach()
	{
		LevelBattleData = RequireWritableData<BGC_LevelBattleData>();
		BGS_GSEventCollection.Get(this).Evt_BGS_PlayerKillMonster += new Del_Void(OnRecvPlayerKillMonster);
		BGS_GSEventCollection.Get(this).Evt_BGS_PlayerGainItem += new Del_Void_IntInt(OnRecvPlayerGainItem);
	}

	private void OnRecvPlayerKillMonster()
	{
		LevelBattleData.KillMonsterCount++;
	}

	private void OnRecvPlayerGainItem(int ItemId, int AddItemNum)
	{
		if (LevelBattleData.ItemNumDict.TryGetValue(ItemId, out var value))
		{
			value += AddItemNum;
		}
		else
		{
			LevelBattleData.ItemNumDict.Add(ItemId, AddItemNum);
		}
	}
}
