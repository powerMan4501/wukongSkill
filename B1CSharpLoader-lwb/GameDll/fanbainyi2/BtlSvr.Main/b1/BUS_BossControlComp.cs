using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_BossControlComp : BUS_StateMachineCompBase
{
	public class DisableState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.BossControlTag.State_Disable;

		public override void OnInitialize()
		{
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_Enable] = BGW_FlowUtils.BossControlTag.State_Idled;
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_BossControlComp bUS_BossControlComp)
			{
				bUS_BossControlComp.RemoveSafeStates();
			}
		}
	}

	public class IdledState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.BossControlTag.State_Idled;

		public override void OnInitialize()
		{
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_WakeUp] = BGW_FlowUtils.BossControlTag.State_Fought;
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_Disable] = BGW_FlowUtils.BossControlTag.State_Disable;
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_BossControlComp bUS_BossControlComp)
			{
				bUS_BossControlComp.AddSafeStates();
			}
		}
	}

	public class FoughtState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.BossControlTag.State_Fought;

		public override void OnInitialize()
		{
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_Kill] = BGW_FlowUtils.BossControlTag.State_Death;
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_Disable] = BGW_FlowUtils.BossControlTag.State_Disable;
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_GoHome] = BGW_FlowUtils.BossControlTag.State_Idled;
			base.EventTransitDictionary[BGW_FlowUtils.SceneObjCommonEventTag.Reset] = BGW_FlowUtils.BossControlTag.State_Idled;
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_BossControlComp bUS_BossControlComp)
			{
				bUS_BossControlComp.RemoveSafeStates();
			}
		}
	}

	public class DeathState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.BossControlTag.State_Death;

		public override void OnInitialize()
		{
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_Rebirth] = BGW_FlowUtils.BossControlTag.State_Idled;
			base.EventTransitDictionary[BGW_FlowUtils.BossControlTag.Event_Disable] = BGW_FlowUtils.BossControlTag.State_Disable;
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_BossControlComp bUS_BossControlComp)
			{
				bUS_BossControlComp.RemoveSafeStates();
			}
		}
	}

	private const int ImmuneDamageBuff = 920;

	private const int ImmuneSkillPerformBuff = 921;

	private const int CantBeTargetBuff = 922;

	private const int CantBeControlBuff = 923;

	private GSStateBase BossState_Disable { get; set; }

	private GSStateBase BossState_Idled { get; set; }

	private GSStateBase BossState_Fought { get; set; }

	private GSStateBase BossState_Death { get; set; }

	private BUC_BossControlData BossControlData { get; set; }

	private IBUC_BuffData BuffData { get; set; }

	private IBUC_AIData AIData { get; set; }

	private IBUC_BattleStateData BattleStateData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBGC_LevelActorData LevelActorData { get; set; }

	private float DeltaTimeAcumulate { get; set; }

	private float SuspectedOutOfBossRoomTime { get; set; }

	private bool bStartCheckOutOfBossRoom { get; set; }

	private bool bEnableCheckOutOfBossRoom { get; set; }

	private FName TeleportSceneItemTag { get; set; }

	private AActor CurUsingTeleportSceneItem { get; set; }

	private List<EObjectTypeQuery> AirWallObjectType { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.BossControl;
		BossControlData = RequireWritableData<BUC_BossControlData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		LevelActorData = RequireReadOnlyGameStateData<IBGC_LevelActorData, BGC_LevelActorData>();
		base.GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		BossState_Disable = AddState(typeof(DisableState), 0);
		BossState_Idled = AddState(typeof(IdledState), 1);
		BossState_Fought = AddState(typeof(FoughtState), 2);
		BossState_Death = AddState(typeof(DeathState), 3);
		base.InitialState = BossState_Idled;
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(OnBattleStateChange);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		bEnableCheckOutOfBossRoom = false;
		TeleportSceneItemTag = FName.None;
		DeltaTimeAcumulate = 0f;
		AirWallObjectType = new List<EObjectTypeQuery>();
		AirWallObjectType.Add(EObjectTypeQuery.ObjectTypeQuery15);
		SuspectedOutOfBossRoomTime = 0f;
		bStartCheckOutOfBossRoom = false;
		CurUsingTeleportSceneItem = null;
		if (base.GuidData == null)
		{
			return;
		}
		FUStBossRoomConfigDesc bossBossRoomConfig = BGW_GameDB.GetBossBossRoomConfig(base.GuidData.GetFinalGuid());
		if (bossBossRoomConfig != null)
		{
			bEnableCheckOutOfBossRoom = bossBossRoomConfig.IsEnableCheckOutOfBossRoom == EGSYesNo.Yes;
			if (bossBossRoomConfig.TeleportSceneItemTagName != null && bossBossRoomConfig.TeleportSceneItemTagName != "")
			{
				TeleportSceneItemTag = new FName(bossBossRoomConfig.TeleportSceneItemTagName);
			}
		}
	}

	protected override bool IsIgnoreSavedState()
	{
		return true;
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (DeadReason != EDeadReason.OnlyDestroyUnit)
		{
			OnEvent(BGW_FlowUtils.BossControlTag.Event_Kill);
		}
	}

	private void OnBattleStateChange(bool bIsIntoBattle)
	{
		if (bIsIntoBattle)
		{
			OnEvent(BGW_FlowUtils.BossControlTag.Event_WakeUp);
		}
		else
		{
			OnEvent(BGW_FlowUtils.BossControlTag.Event_GoHome);
		}
	}

	private void UpdateSafeStates()
	{
		BossControlData.bHasImmuneDamageBuff = BuffData.HasBuff(920);
		BossControlData.bHasImmuneSkillPerformBuff = BuffData.HasBuff(921);
		BossControlData.bHasCantBeTargetBuff = BuffData.HasBuff(922);
		BossControlData.bHasCantBeControlBuff = BuffData.HasBuff(923);
	}

	private void AddSafeStates()
	{
		UpdateSafeStates();
		if (!BossControlData.bHasImmuneDamageBuff)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(920, base.Owner, base.Owner, 0f, EBuffSourceType.BossRoom);
		}
		if (!BossControlData.bHasImmuneSkillPerformBuff)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(921, base.Owner, base.Owner, 0f, EBuffSourceType.BossRoom);
		}
		if (!BossControlData.bHasCantBeTargetBuff)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(922, base.Owner, base.Owner, 0f, EBuffSourceType.BossRoom);
		}
		if (!BossControlData.bHasCantBeControlBuff)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(923, base.Owner, base.Owner, 0f, EBuffSourceType.BossRoom);
		}
		BossControlData.bInSafeState = true;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!bEnableCheckOutOfBossRoom || AIData == null || BattleStateData == null || UnitStateData == null || !BattleStateData.IsUnitInBattle())
		{
			return;
		}
		DeltaTimeAcumulate += DeltaTime;
		if (DeltaTimeAcumulate < (float)(bStartCheckOutOfBossRoom ? 1 : 5))
		{
			return;
		}
		if (!CheckBossIsInBossRoom(DeltaTime))
		{
			SuspectedOutOfBossRoomTime = 0f;
			bStartCheckOutOfBossRoom = false;
			FVector newLocation = AIData.GetEnterBattlePosition();
			if (CurUsingTeleportSceneItem != null)
			{
				newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(CurUsingTeleportSceneItem);
				CurUsingTeleportSceneItem = null;
			}
			base.BUSEventCollection?.Evt_SetActorLocation.Invoke(newLocation, bSweep: false, bTeleport: true);
			base.BUSEventCollection?.Evt_ActorForceUpdateTransform.Invoke();
		}
		DeltaTimeAcumulate = 0f;
	}

	public bool CheckBossIsInBossRoom(float DeltaTime)
	{
		if (bEnableCheckOutOfBossRoom && OwnerAsCharacterCS != null)
		{
			if (AIData == null)
			{
				return true;
			}
			FVector enterBattlePosition = AIData.GetEnterBattlePosition();
			new UNavigationQueryFilter();
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS);
			FVector fVector2 = enterBattlePosition;
			if (TeleportSceneItemTag != FName.None && LevelActorData != null)
			{
				LevelActorData.GetSceneItemsByTag(TeleportSceneItemTag, out var OutSceneItems);
				int num = -1;
				double num2 = double.MaxValue;
				for (int i = 0; i < OutSceneItems.Count; i++)
				{
					AActor needGetInfoActor = OutSceneItems[i];
					double num3 = fVector.Vector_Distance2D(BGUFuncLibActorTransformCS.BGUGetActorLocation(needGetInfoActor));
					if (num3 < num2)
					{
						num2 = num3;
						num = i;
					}
				}
				if (num >= 0)
				{
					CurUsingTeleportSceneItem = OutSceneItems[num];
					fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(CurUsingTeleportSceneItem);
				}
			}
			if (UBGUFunctionLibrary.BGUNavigationRaycast(OwnerAsCharacterCS, fVector, fVector2, out var HitLocation, null, OwnerAsCharacterCS.GetController()))
			{
				double num4 = fVector.Vector_Distance2D(HitLocation);
				double num5 = HitLocation.Vector_Distance2D(fVector2);
				if (num4 < 1000.0 && num5 > 300.0)
				{
					fVector.Z += 300f;
					if (UBGUSelectUtil.LineTraceForObjects(OwnerAsCharacterCS, fVector, fVector2, AirWallObjectType, bDebug: true, out var _) > 0)
					{
						if (!bStartCheckOutOfBossRoom)
						{
							bStartCheckOutOfBossRoom = true;
						}
						SuspectedOutOfBossRoomTime += DeltaTimeAcumulate;
						if (SuspectedOutOfBossRoomTime > 10f)
						{
							return false;
						}
						return true;
					}
				}
				bStartCheckOutOfBossRoom = false;
				SuspectedOutOfBossRoomTime = 0f;
				CurUsingTeleportSceneItem = null;
			}
			else
			{
				UBGUFunctionLibrary.BGUNavigationCalPathCost(OwnerAsCharacterCS, fVector, fVector2, out var PathCost, OwnerAsCharacterCS.GetController());
				if (PathCost > 500000f)
				{
					fVector.Z += 300f;
					if (UBGUSelectUtil.LineTraceForObjects(OwnerAsCharacterCS, fVector, fVector2, AirWallObjectType, bDebug: true, out var _) > 0)
					{
						if (!bStartCheckOutOfBossRoom)
						{
							bStartCheckOutOfBossRoom = true;
						}
						SuspectedOutOfBossRoomTime += DeltaTimeAcumulate;
						if (SuspectedOutOfBossRoomTime > 10f)
						{
							return false;
						}
						return true;
					}
				}
				bStartCheckOutOfBossRoom = false;
				SuspectedOutOfBossRoomTime = 0f;
				CurUsingTeleportSceneItem = null;
			}
		}
		return true;
	}

	private void RemoveSafeStates()
	{
		UpdateSafeStates();
		if (BossControlData.bHasImmuneDamageBuff)
		{
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(920, EBuffEffectTriggerType.Remove);
		}
		if (BossControlData.bHasImmuneSkillPerformBuff)
		{
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(921, EBuffEffectTriggerType.Remove);
		}
		if (BossControlData.bHasCantBeTargetBuff)
		{
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(922, EBuffEffectTriggerType.Remove);
		}
		if (BossControlData.bHasCantBeControlBuff)
		{
			base.BUSEventCollection.Evt_BuffRemoveImmediately.Invoke(923, EBuffEffectTriggerType.Remove);
		}
		BossControlData.bInSafeState = false;
	}
}
