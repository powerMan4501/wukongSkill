using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_QuestTortoiseCtrlComp : BUS_StateMachineCompBase
{
	public class DefaultState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.OverlapTag.State_Disabled;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseEnterBox0, OnEnterBox0);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseEnterBox1, OnEnterBox1);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseEnterBox2, OnEnterBox2);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseEnterBox3, OnEnterBox3);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseEnterBox4, OnEnterBox4);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseExitBox0, OnExitBox0);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseExitBox1, OnExitBox1);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseExitBox2, OnExitBox2);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseExitBox3, OnExitBox3);
			base.ReactionDictionary.Add(BGW_FlowUtils.TortoiseEventTag.TortoiseExitBox4, OnExitBox4);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			_ = InOwner is BUS_QuestTortoiseCtrlComp;
		}

		public void DoEnterBoxLogic(int BoxID, BUS_StateMachineCompBase InOwner)
		{
			if (!(InOwner is BUS_QuestTortoiseCtrlComp bUS_QuestTortoiseCtrlComp) || !bUS_QuestTortoiseCtrlComp.TortoiseCtrlData.TortoiseRotateTriggerBoxInfoDict.ContainsKey(BoxID))
			{
				return;
			}
			if (!bUS_QuestTortoiseCtrlComp.CheckCanTortoiseRotate() || bUS_QuestTortoiseCtrlComp.TortoiseCtrlData.IsTortoiseRotating)
			{
				if (!bUS_QuestTortoiseCtrlComp.TortoiseCtrlData.RotateQueue.Contains(BoxID))
				{
					bUS_QuestTortoiseCtrlComp.TortoiseCtrlData.RotateQueue.Add(BoxID);
				}
			}
			else
			{
				bUS_QuestTortoiseCtrlComp.StartTortoiseRotate(BoxID);
			}
		}

		public void DoExitBoxLogic(int BoxID, BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_QuestTortoiseCtrlComp bUS_QuestTortoiseCtrlComp)
			{
				bUS_QuestTortoiseCtrlComp.TortoiseCtrlData.RotateQueue.Remove(BoxID);
			}
		}

		public void OnEnterBox0(BUS_StateMachineCompBase InOwner)
		{
			DoEnterBoxLogic(0, InOwner);
		}

		public void OnEnterBox1(BUS_StateMachineCompBase InOwner)
		{
			DoEnterBoxLogic(1, InOwner);
		}

		public void OnEnterBox2(BUS_StateMachineCompBase InOwner)
		{
			DoEnterBoxLogic(2, InOwner);
		}

		public void OnEnterBox3(BUS_StateMachineCompBase InOwner)
		{
			DoEnterBoxLogic(3, InOwner);
		}

		public void OnEnterBox4(BUS_StateMachineCompBase InOwner)
		{
			DoEnterBoxLogic(4, InOwner);
		}

		public void OnExitBox0(BUS_StateMachineCompBase InOwner)
		{
			DoExitBoxLogic(0, InOwner);
		}

		public void OnExitBox1(BUS_StateMachineCompBase InOwner)
		{
			DoExitBoxLogic(1, InOwner);
		}

		public void OnExitBox2(BUS_StateMachineCompBase InOwner)
		{
			DoExitBoxLogic(2, InOwner);
		}

		public void OnExitBox3(BUS_StateMachineCompBase InOwner)
		{
			DoExitBoxLogic(3, InOwner);
		}

		public void OnExitBox4(BUS_StateMachineCompBase InOwner)
		{
			DoExitBoxLogic(4, InOwner);
		}
	}

	private BUC_QuestTortoiseCtrlData TortoiseCtrlData { get; set; }

	private IBGC_UnrealGameplayData UnrealGameplayData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		TortoiseCtrlData = RequireWritableData<BUC_QuestTortoiseCtrlData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.SceneObjTag = BGW_FlowUtils.SceneObjTag.Trigger;
		GSStateBase initialState = AddState(typeof(DefaultState), 0);
		base.InitialState = initialState;
		base.BGSEventCollection.Evt_BGS_UnitBattleStateUpdate += new Del_BGS_UnitBattleStateUpdate(TortoiseUnitBattleStateUpdate);
		base.BGSEventCollection.Evt_BGS_UnitEnterFight += new Del_BGS_UnitEnterFight(OnTortoiseUnitEnterFight);
		base.BGSEventCollection.Evt_BGS_UnitLeaveFight += new Del_BGS_UnitLeaveFight(OnTortoiseUnitLeaveFight);
		base.BGSEventCollection.Evt_BGS_UnitDead += new Del_Void_StringDeadReason(OnUnitDead);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_BGS_UnitBattleStateUpdate -= new Del_BGS_UnitBattleStateUpdate(TortoiseUnitBattleStateUpdate);
		base.BGSEventCollection.Evt_BGS_UnitEnterFight -= new Del_BGS_UnitEnterFight(OnTortoiseUnitEnterFight);
		base.BGSEventCollection.Evt_BGS_UnitLeaveFight -= new Del_BGS_UnitLeaveFight(OnTortoiseUnitLeaveFight);
		base.BGSEventCollection.Evt_BGS_UnitDead -= new Del_Void_StringDeadReason(OnUnitDead);
	}

	private ACharacter GetPlayer()
	{
		if (UnrealGameplayData == null)
		{
			return UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner)?.GetControlledPawn() as ACharacter;
		}
		return UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn() as ACharacter;
	}

	public void TortoiseUnitBattleStateUpdate(BGUCharacterCS Unit, bool IsInBattle)
	{
		if (IsEntityTortoiseUnit(Unit))
		{
			if (IsInBattle)
			{
				OnTortoiseUnitEnterFight(Unit);
			}
			else
			{
				OnTortoiseUnitLeaveFight(Unit);
			}
		}
	}

	public bool IsEntityTortoiseUnit(AActor actor)
	{
		BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			return TortoiseCtrlData.TortoiseUnitResIDList.Contains(bGUCharacterCS.GetResID());
		}
		return false;
	}

	public void OnTortoiseUnitLeaveFight(AActor actor)
	{
		TortoiseCtrlData.TortoiseInBattleUnitActors.Remove(actor);
	}

	public void OnUnitDead(string UnitGuid, EDeadReason InDeadReason)
	{
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, UnitGuid);
		if (actorByGuid != null)
		{
			TortoiseCtrlData.TortoiseInBattleUnitActors.Remove(actorByGuid);
		}
	}

	public void OnTortoiseUnitEnterFight(AActor actor)
	{
		if (IsEntityTortoiseUnit(actor))
		{
			TortoiseCtrlData.TortoiseInBattleUnitActors.Add(actor);
		}
	}

	public void DisableUnitsEnterFight()
	{
		base.BGSEventCollection.Evt_BGS_TortoiseStartRotate.Invoke();
	}

	public void EnableUnitsEnterFight()
	{
		base.BGSEventCollection.Evt_BGS_TortoiseEndRotate.Invoke();
	}

	public void StartTortoiseRotate(int BoxID)
	{
		GetPlayer()?.CharacterMovement.Cast<UBGUCharacterMovementComponent>()?.SetOnMovingPlatform(bIsOnMovingPlatform: true);
		TortoiseCtrlData.IsTortoiseRotating = true;
		TortoiseCtrlData.CurTortoiseRotateID = BoxID;
		TortoiseCtrlData.CurRotateTime = 0f;
		TortoiseCtrlData.RotateStartTransform = TortoiseCtrlData.Tortoise.GetActorTransform();
		FTortoiseRotateTriggerBoxInfo fTortoiseRotateTriggerBoxInfo = TortoiseCtrlData.TortoiseRotateTriggerBoxInfoDict[BoxID];
		if (fTortoiseRotateTriggerBoxInfo.UseCurveSettings)
		{
			fTortoiseRotateTriggerBoxInfo.RotationCurve.GetTimeRange(out var _, out var MaxTime);
			fTortoiseRotateTriggerBoxInfo.TransitionCurve.GetTimeRange(out var _, out var MaxTime2);
			TortoiseCtrlData.TotalRotateTime = FMath.Max(MaxTime, MaxTime2);
			DisableUnitsEnterFight();
			return;
		}
		TortoiseCtrlData.TotalRotateTime = fTortoiseRotateTriggerBoxInfo.RotationAnimation.GetPlayLength();
		USkeletalMeshComponent componentByClass = TortoiseCtrlData.Tortoise.GetComponentByClass<USkeletalMeshComponent>();
		if (componentByClass != null)
		{
			componentByClass.PlayAnimation(fTortoiseRotateTriggerBoxInfo.RotationAnimation, bLooping: false);
			DisableUnitsEnterFight();
		}
	}

	public void EndTortoiseRotate()
	{
		TortoiseCtrlData.IsTortoiseRotating = false;
		GetPlayer()?.CharacterMovement.Cast<UBGUCharacterMovementComponent>()?.SetOnMovingPlatform(bIsOnMovingPlatform: false);
		EnableUnitsEnterFight();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		CheckPopRotateQueue();
		DoTickRotateLogic(DeltaTime);
	}

	public bool CheckCanTortoiseRotate()
	{
		return TortoiseCtrlData.TortoiseInBattleUnitActors.Count == 0;
	}

	public void CheckPopRotateQueue()
	{
		if (!TortoiseCtrlData.IsTortoiseRotating && TortoiseCtrlData.RotateQueue.Count > 0 && CheckCanTortoiseRotate())
		{
			StartTortoiseRotate(TortoiseCtrlData.RotateQueue[0]);
			TortoiseCtrlData.RotateQueue.RemoveAt(0);
		}
	}

	public void DoTickRotateLogic(float DeltaTime)
	{
		if (!TortoiseCtrlData.IsTortoiseRotating)
		{
			return;
		}
		if (TortoiseCtrlData.TortoiseRotateTriggerBoxInfoDict[TortoiseCtrlData.CurTortoiseRotateID].UseCurveSettings)
		{
			TortoiseCtrlData.CurRotateTime += DeltaTime;
			if (TortoiseCtrlData.CurRotateTime < TortoiseCtrlData.TotalRotateTime)
			{
				RotateToNewTransform(TortoiseCtrlData.CurRotateTime);
				return;
			}
			RotateToNewTransform(TortoiseCtrlData.TotalRotateTime);
			EndTortoiseRotate();
		}
		else
		{
			TortoiseCtrlData.CurRotateTime += DeltaTime;
			if (TortoiseCtrlData.Tortoise.GetComponentByClass<USkeletalMeshComponent>()?.GetAnimInstance() == null || TortoiseCtrlData.CurRotateTime > TortoiseCtrlData.TotalRotateTime)
			{
				EndTortoiseRotate();
			}
		}
	}

	public void RotateToNewTransform(float RotateTime)
	{
		FTortoiseRotateTriggerBoxInfo fTortoiseRotateTriggerBoxInfo = TortoiseCtrlData.TortoiseRotateTriggerBoxInfoDict[TortoiseCtrlData.CurTortoiseRotateID];
		FVector euler = TortoiseCtrlData.RotateStartTransform.Rotation.Euler() + fTortoiseRotateTriggerBoxInfo.RotationCurve.GetVectorValue(RotateTime);
		FVector newLocation = TortoiseCtrlData.RotateStartTransform.GetLocation() + fTortoiseRotateTriggerBoxInfo.TransitionCurve.GetVectorValue(RotateTime);
		TortoiseCtrlData.Tortoise.SetActorLocationAndRotation(newLocation, FRotator.MakeFromEuler(euler), bSweep: false, out var _, bTeleport: false);
	}
}
