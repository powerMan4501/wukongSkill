using b1.EventDelDefine;

namespace b1;

public class BPS_PlayerAttrSystem : PlayerControllerSystemBase
{
	private BPC_PlayerAttrData PlayerAttrData;

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		InitPlayerAttrList();
	}

	private void InitPlayerAttrList()
	{
		BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>((Owner as BGP_PlayerControllerCS).GetControlledPawn());
	}

	public override void OnAttach()
	{
		PlayerAttrData = RequireWritablePlayerStateData<BPC_PlayerAttrData>();
		BPS_GSEventCollection playerEventCollection = GetPlayerEventCollection();
		if (playerEventCollection != null)
		{
			playerEventCollection.Evt_PlayerActorSpawn += new Del_Void(OnPlayerActorSpawn);
			playerEventCollection.Evt_BPS_OnKeyMonsterFightWithLocalPlayer += new Del_Void_String(OnKeyMonsterMeet);
			playerEventCollection.Evt_BPS_OnPlayerDeadWhenBattleWithKeyMonster += new Del_Void_String(OnPlayerDeadWhenBattleWithKeyMonster);
		}
	}

	private void OnPlayerActorSpawn()
	{
		InitPlayerAttrList();
	}

	private void OnKeyMonsterMeet(string Guid)
	{
		if (PlayerAttrData.KeyMonsterMeetCount.ContainsKey(Guid))
		{
			PlayerAttrData.KeyMonsterMeetCount[Guid]++;
		}
		else
		{
			PlayerAttrData.KeyMonsterMeetCount.Add(Guid, 1);
		}
	}

	private void OnPlayerDeadWhenBattleWithKeyMonster(string Guid)
	{
		if (PlayerAttrData.KeyMonsterBattlePlayerDieTimes.ContainsKey(Guid))
		{
			PlayerAttrData.KeyMonsterBattlePlayerDieTimes[Guid]++;
		}
		else
		{
			PlayerAttrData.KeyMonsterBattlePlayerDieTimes.Add(Guid, 1);
		}
	}
}
