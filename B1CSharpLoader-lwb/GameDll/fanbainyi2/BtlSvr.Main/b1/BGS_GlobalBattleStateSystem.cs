using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGS_GlobalBattleStateSystem : GameStateSystemBase
{
	private readonly float TICK_DURATION = 1f;

	private float TickTimer;

	private BGC_GlobalBattleStateData GlobalBattleStateData;

	private IBIC_BossRushBattleData BossRushBattleData;

	public override void OnAttach()
	{
		GlobalBattleStateData = RequireWritableData<BGC_GlobalBattleStateData>();
		BossRushBattleData = RequireReadonlyGameInstanceData<IBIC_BossRushBattleData, BIC_BossRushBattleData>();
		if (base.BGSEventCollection != null)
		{
			base.BGSEventCollection.Evt_BGS_UnitInBattle += new Del_UnitInBattle(OnUnitInBattle);
			base.BGSEventCollection.Evt_BGS_UnitLeaveBattle += new Del_Void_StringInt(OnUnitLeaveBattle);
			base.BGSEventCollection.Evt_BGS_RemoveForceLeaveBattleUnit += new Del_Void_String(OnRemoveForceLeaveBattleUnit);
		}
	}

	public override void OnBeginPlay()
	{
		IBIC_LevelData iBIC_LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		if (iBIC_LevelData == null)
		{
			return;
		}
		int currentLevelID = iBIC_LevelData.CurrentLevelID;
		Dictionary<int, List<string>> dictionary = ((currentLevelID >= 0) ? BGW_GameDB.GetAllBossRoomsInLevel(currentLevelID) : BGW_GameDB.GetAllBossRoomsInAllLevel());
		if (dictionary == null)
		{
			return;
		}
		foreach (KeyValuePair<int, List<string>> item in dictionary)
		{
			FBossRoom fBossRoom = new FBossRoom();
			foreach (string item2 in item.Value)
			{
				fBossRoom.BossBattleState.Add(item2, value: false);
			}
			GlobalBattleStateData.BossRooms.Add(fBossRoom);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		TickTimer -= DeltaTime;
		if (!(TickTimer <= 0f))
		{
			return;
		}
		TickTimer = TICK_DURATION;
		if (GlobalBattleStateData.InBattleUnitMultiMap.Count > 0)
		{
			foreach (KeyValuePair<EBGUBloodBarType, List<Entity>> item in GlobalBattleStateData.InBattleUnitMultiMap)
			{
				List<Entity> value = item.Value;
				for (int num = value.Count - 1; num >= 0; num--)
				{
					AActor aActor = ECSExtension.ToActor(value[num]);
					if (aActor == null || aActor.IsPendingKill || aActor.IsNullOrDestroyed())
					{
						value.RemoveAt(num);
					}
				}
			}
		}
		if (GlobalBattleStateData.IntoBattleUnits.GetSize() <= 0)
		{
			return;
		}
		GlobalBattleStateData.IntoBattleUnits.BeginItr();
		while (true)
		{
			GlobalBattleStateData.IntoBattleUnits.NextItr(out var output);
			if (!(output == null))
			{
				if (output.IsPendingKill || output.IsNullOrDestroyed())
				{
					GlobalBattleStateData.IntoBattleUnits.Remove();
				}
				continue;
			}
			break;
		}
	}

	private void OnUnitInBattle(BGUCharacterCS BGUChr, string UnitGuid, int BattleInfoExtendID, bool CanForceLeaveBattle)
	{
		if (BGUChr != null)
		{
			GlobalBattleStateData.IntoBattleUnits[UnitGuid] = BGUChr;
			if (CanForceLeaveBattle)
			{
				GlobalBattleStateData.CanForceLeaveBattleUnits[UnitGuid] = BGUChr;
			}
			if (BGUChr.IsPlayerControlled())
			{
				base.BGWEventCollection.Evt_NotifyPlayerInBattle();
			}
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BattleInfoExtendID);
		if (unitBattleInfoExtendDesc != null)
		{
			GlobalBattleStateData.AddInBattleUnitInMultiMap(unitBattleInfoExtendDesc.BloodBarType, ECSExtension.ToEntity(BGUChr));
		}
		if (GlobalBattleStateData.CurrentBossRoom == null)
		{
			if (B1Global.GIsBossRushMode && BossRushBattleData.BossRushRoom != null && BossRushBattleData.BossRushRoom.IsInBossRoom(UnitGuid))
			{
				TriggerEnterBossRoom(BossRushBattleData.BossRushRoom);
			}
			else
			{
				foreach (FBossRoom bossRoom in GlobalBattleStateData.BossRooms)
				{
					if (bossRoom.IsInBossRoom(UnitGuid))
					{
						TriggerEnterBossRoom(bossRoom);
						break;
					}
				}
			}
		}
		FBossRoom currentBossRoom = GlobalBattleStateData.CurrentBossRoom;
		if (currentBossRoom != null && currentBossRoom.BossBattleState.ContainsKey(UnitGuid))
		{
			currentBossRoom.BossBattleState[UnitGuid] = true;
		}
	}

	private void OnUnitLeaveBattle(string UnitGuid, int BattleInfoExtendID)
	{
		BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(Owner, UnitGuid) as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (GlobalBattleStateData.IntoBattleUnits.Find(UnitGuid, out var _))
			{
				GlobalBattleStateData.IntoBattleUnits.Remove(UnitGuid);
			}
			if (GlobalBattleStateData.CanForceLeaveBattleUnits.ContainsKey(UnitGuid))
			{
				GlobalBattleStateData.CanForceLeaveBattleUnits.Remove(UnitGuid);
			}
			if (bGUCharacterCS.IsPlayerControlled())
			{
				base.BGWEventCollection.Evt_NotifyPlayerLeaveBattle();
			}
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BattleInfoExtendID);
		if (unitBattleInfoExtendDesc != null)
		{
			GlobalBattleStateData.RemoveInBattleUnitInMultiMap(unitBattleInfoExtendDesc.BloodBarType, ECSExtension.ToEntity(bGUCharacterCS));
		}
		FBossRoom currentBossRoom = GlobalBattleStateData.CurrentBossRoom;
		if (currentBossRoom != null && currentBossRoom.BossBattleState.ContainsKey(UnitGuid))
		{
			currentBossRoom.BossBattleState[UnitGuid] = false;
			if (currentBossRoom.IsAllLeaveBattle())
			{
				TriggerExitBossRoom();
			}
		}
	}

	private void OnRemoveForceLeaveBattleUnit(string UnitGuid)
	{
		if (GlobalBattleStateData.CanForceLeaveBattleUnits.ContainsKey(UnitGuid))
		{
			GlobalBattleStateData.CanForceLeaveBattleUnits.Remove(UnitGuid);
		}
	}

	private void TriggerEnterBossRoom(FBossRoom InBossRoom)
	{
		if (GlobalBattleStateData.CurrentBossRoom != null)
		{
			ExitCurrentBossRoom();
		}
		EnterBossRoom(InBossRoom);
	}

	private void EnterBossRoom(FBossRoom InBossRoom)
	{
		GlobalBattleStateData.CurrentBossRoom = InBossRoom;
		if (!B1Global.GIsBossRushMode)
		{
			base.BGSEventCollection.Evt_EnableTamerOnlyMode.Invoke(InBossRoom.BossBattleState.Keys.ToList());
		}
	}

	private void TriggerExitBossRoom()
	{
		ExitCurrentBossRoom();
	}

	private void ExitCurrentBossRoom()
	{
		if (!B1Global.GIsBossRushMode)
		{
			base.BGSEventCollection.Evt_DisableTamerOnlyMode.Invoke(GlobalBattleStateData.CurrentBossRoom.BossBattleState.Keys.ToList());
		}
		GlobalBattleStateData.CurrentBossRoom = null;
	}
}
