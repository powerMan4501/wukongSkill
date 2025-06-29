using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DumperTruckTriggerComp : BUS_StateMachineCompBase
{
	public class InActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DumperTruckTag.State_InActived;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.DumperTruckTag.State_WaitWakeUp);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DumperTruckTag.Event_JumpToWakeUp, BGW_FlowUtils.DumperTruckTag.State_WaitWakeUp);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_DumperTruckTriggerComp bUS_DumperTruckTriggerComp)
			{
				bUS_DumperTruckTriggerComp.UnMarkTamerAlwaysSpawn();
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			base.OnTickAction(InOwner, DeltaTime);
			_ = InOwner is BUS_DumperTruckTriggerComp;
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			_ = InOwner is BUS_DumperTruckTriggerComp;
		}
	}

	public class WaitWakeUpState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DumperTruckTag.State_WaitWakeUp;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Remove(BGW_FlowUtils.SceneObjCommonEventTagName.Next);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.DumperTruckTag.State_Activating);
			base.EventTransitDictionary.Remove(BGW_FlowUtils.DumperTruckTagName.Event_JumpToActivating);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DumperTruckTag.Event_JumpToActivating, BGW_FlowUtils.DumperTruckTag.State_Activating);
			base.EventTransitDictionary.Remove(BGW_FlowUtils.DumperTruckTagName.Event_JumpToInActived);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DumperTruckTag.Event_JumpToInActived, BGW_FlowUtils.DumperTruckTag.State_Actived);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_DumperTruckTriggerComp bUS_DumperTruckTriggerComp)
			{
				bUS_DumperTruckTriggerComp.MarkTamerAlwaysSpawn();
				bUS_DumperTruckTriggerComp.BindWakeUp();
			}
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_DumperTruckTriggerComp bUS_DumperTruckTriggerComp)
			{
				bUS_DumperTruckTriggerComp.UnBindWakeUp();
			}
		}
	}

	public class ActivatingState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DumperTruckTag.State_Activating;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DumperTruckTag.Event_JumpToActived, BGW_FlowUtils.DumperTruckTag.State_Actived);
			base.EventTransitDictionary.Add(BGW_FlowUtils.DumperTruckTag.Event_JumpToInActived, BGW_FlowUtils.DumperTruckTag.State_Actived);
			base.EventTransitDictionary.Add(BGW_FlowUtils.SceneObjCommonEventTag.Next, BGW_FlowUtils.DumperTruckTag.State_Actived);
			base.ExtraActionDictionary.Add(BGW_FlowUtils.DumperTruckTag.State_InActived, delegate(BUS_StateMachineCompBase InOwner)
			{
				BUS_EventCollectionCS.Get(InOwner).Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_NONCOMBAT_IDLE);
			});
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_DumperTruckTriggerComp bUS_DumperTruckTriggerComp)
			{
				bUS_DumperTruckTriggerComp.EnterActiving();
				bUS_DumperTruckTriggerComp.SetCanTickAfterAnim(CanTick: true);
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			base.OnTickAction(InOwner, DeltaTime);
			_ = InOwner is BUS_DumperTruckTriggerComp;
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_DumperTruckTriggerComp bUS_DumperTruckTriggerComp)
			{
				bUS_DumperTruckTriggerComp.ExitActiving();
				bUS_DumperTruckTriggerComp.SetCanTickAfterAnim(CanTick: false);
				bUS_DumperTruckTriggerComp.UnMarkTamerAlwaysSpawn();
			}
		}
	}

	public class ActivedState : GSStateBase
	{
		public override FGameplayTag StateTag => BGW_FlowUtils.DumperTruckTag.State_Actived;

		public override void OnInitialize()
		{
			base.OnInitialize();
			base.EventTransitDictionary.Add(BGW_FlowUtils.DumperTruckTag.Event_JumpToInActived, BGW_FlowUtils.DumperTruckTag.State_InActived);
			base.ExtraActionDictionary.Add(BGW_FlowUtils.DumperTruckTag.State_InActived, delegate(BUS_StateMachineCompBase InOwner)
			{
				BUS_EventCollectionCS.Get(InOwner).Evt_FSMEventTrigger.Invoke(EBGUFSMEventName.FSM_EVENT_LIFE_STANDBY);
			});
			base.ReactionDictionary.Add(BGW_FlowUtils.DumperTruckTag.Event_JumpToWakeUp, OnEnterAction);
		}

		public override void OnEnterAction(BUS_StateMachineCompBase InOwner)
		{
			if (InOwner is BUS_DumperTruckTriggerComp bUS_DumperTruckTriggerComp)
			{
				bUS_DumperTruckTriggerComp.UnMarkTamerAlwaysSpawn();
				bUS_DumperTruckTriggerComp.DestoryControlledUnit();
			}
		}

		public override void OnTickAction(BUS_StateMachineCompBase InOwner, float DeltaTime)
		{
			base.OnTickAction(InOwner, DeltaTime);
			_ = InOwner is BUS_DumperTruckTriggerComp;
		}

		public override void OnExitAction(BUS_StateMachineCompBase InOwner)
		{
			_ = InOwner is BUS_DumperTruckTriggerComp;
		}
	}

	private int CurrentMoveIdx = -1;

	private BUC_DumperTruckTriggerData DumperTruckTriggerData { get; set; }

	private IBUC_WakeUpData WakeUpData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBIC_StateMachineData StateMachineData { get; set; }

	private IBUC_TargetInfoData TargetInfoData { get; set; }

	private BUS_GSEventCollection BE { get; set; }

	private GSStateBase State_InActived { get; set; }

	private GSStateBase State_WaitWakeUp { get; set; }

	private GSStateBase State_Activating { get; set; }

	private GSStateBase State_Actived { get; set; }

	private float CurDistance { get; set; }

	private float WaitTime { get; set; }

	private float UseTime { get; set; }

	protected override void OnReset()
	{
		DumperTruckTriggerData.CurrentIndex = 0;
		DumperTruckTriggerData.NextIndex = 0;
		DumperTruckTriggerData.NeedUpdataSpline = false;
		DumperTruckTriggerData.IsForward = true;
	}

	public override void OnAttach()
	{
		base.OnAttach();
		DumperTruckTriggerData = RequireWritableData<BUC_DumperTruckTriggerData>();
		StateMachineData = RequireReadonlyGameInstanceData<IBIC_StateMachineData, BIC_StateMachineData>();
		base.GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		State_InActived = AddState(typeof(InActivedState), 0);
		State_WaitWakeUp = AddState(typeof(WaitWakeUpState), 1);
		State_Activating = AddState(typeof(ActivatingState), 2);
		State_Actived = AddState(typeof(ActivedState), 3);
		base.InitialState = State_InActived;
	}

	public void EnterActiving()
	{
		DumperTruckTriggerData.IsRotating = false;
		DumperTruckTriggerData.IsForward = DumperTruckTriggerData.IsStartForward;
		DumperTruckTriggerData.CurrentIndex = DumperTruckTriggerData.MultiSplineDefaultIndex;
		DumperTruckTriggerData.IsUseCurve = false;
		DumperTruckTriggerData.NextIndex = 0;
		DumperTruckTriggerData.CurrentAcceleration = 0f;
		DumperTruckTriggerData.CurrentSpeed = DumperTruckTriggerData.StartSpeed;
		DumperTruckTriggerData.IsActive = true;
		CurDistance = DumperTruckTriggerData.SplineList[DumperTruckTriggerData.CurrentIndex].GetDistanceAlongSplineAtSplineInputKey(DumperTruckTriggerData.StartPointIndex);
		if (DumperTruckTriggerData.ControlledUnit != null)
		{
			DumperTruckTriggerData.ABPClass = DumperTruckTriggerData.ControlledUnit.Mesh.GetAnimInstance().GetClass();
			BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit).Evt_ChangeAnimMode.Invoke(EAnimationMode.AnimationSingleNode);
			UAnimationAsset uAnimationAsset = null;
			uAnimationAsset = ((!(DumperTruckTriggerData.AnimationAsset != null)) ? BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimationAsset>("AnimSequence'/Game/00Main/Animation/HYS/HYS_Ball/AS_HYS_Ball_01_Atk_01.AS_HYS_Ball_01_Atk_01'", ELoadResourceType.SyncLoadAndCache) : DumperTruckTriggerData.AnimationAsset);
			DumperTruckTriggerData.ControlledUnit.Mesh.SetAnimation(uAnimationAsset);
			DumperTruckTriggerData.ControlledUnit.Mesh.Play(bLooping: true);
			USplineComponent uSplineComponent = DumperTruckTriggerData.SplineList[DumperTruckTriggerData.CurrentIndex];
			FRotator rotationAtDistanceAlongSpline = uSplineComponent.GetRotationAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World);
			FVector locationAtDistanceAlongSpline = uSplineComponent.GetLocationAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World);
			BGW_LogUtil.LogError($"{DumperTruckTriggerData.ControlledUnit.GetName()} DumperTruck Location is {locationAtDistanceAlongSpline} DumperTruck Rotation is {rotationAtDistanceAlongSpline}");
			BindResetActorStatus();
		}
	}

	public void ExitActiving()
	{
		DumperTruckTriggerData.IsActive = false;
	}

	private void DestoryControlledUnit()
	{
		if (DumperTruckTriggerData.ControlledUnit != null && !DumperTruckTriggerData.ControlledUnit.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit).Evt_UnitDead.Invoke(DumperTruckTriggerData.ControlledUnit, EDeadReason.Suicide);
		}
	}

	private void JumpToActivating()
	{
		JumpToState(State_Activating, bSaveState: false);
	}

	private void OnResetABP(EResetActorReason ResetReason)
	{
		if (DumperTruckTriggerData.ControlledUnit != null && ResetReason != EResetActorReason.NewSpawn)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit);
			bUS_GSEventCollection.Evt_ChangeAnimMode.Invoke(EAnimationMode.AnimationBlueprint, DumperTruckTriggerData.ABPClass);
			JumpToState(State_InActived, bSaveState: false);
			bUS_GSEventCollection.Evt_OnLeaveFight.Invoke();
			UnBindResetActorStatus();
		}
	}

	public void BindResetActorStatus()
	{
		BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit).Evt_ResetActorStatus += new Del_Void_ResetActorReason(OnResetABP);
	}

	public void UnBindResetActorStatus()
	{
		BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit).Evt_ResetActorStatus -= new Del_Void_ResetActorReason(OnResetABP);
	}

	public void BindWakeUp()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnWakeUp += new Del_Void(JumpToActivating);
		}
	}

	public void UnBindWakeUp()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnWakeUp -= new Del_Void(JumpToActivating);
		}
	}

	public void MarkTamerAlwaysSpawn()
	{
		base.BGSEventCollection.Evt_MarkTamerAlwaysSpawn.Invoke(BGU_DataUtil.GetActorGuid(DumperTruckTriggerData.ControlledUnit));
	}

	public void UnMarkTamerAlwaysSpawn()
	{
		base.BGSEventCollection.Evt_UnMarkTamerAlwaysSpawn.Invoke(BGU_DataUtil.GetActorGuid(DumperTruckTriggerData.ControlledUnit));
	}

	public void EnableSweepCheck()
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit);
		FSweepCheckParamter sweepCheckParamter = DumperTruckTriggerData.SweepCheckParamter;
		List<FUStCheckShape> list = new List<FUStCheckShape>();
		foreach (FUStCheckShape item in sweepCheckParamter.SweepCheckShape)
		{
			FUStCheckShape fUStCheckShape = default(FUStCheckShape);
			fUStCheckShape = item;
			fUStCheckShape.SKComp = BGU_ObjActorUtil.GetSocketBelongToSKComp(DumperTruckTriggerData.ControlledUnit, item.SocketName);
			list.Add(fUStCheckShape);
		}
		bUS_GSEventCollection.Evt_SweepCheckBegin.Invoke(DumperTruckTriggerData.ObjectID, sweepCheckParamter.WeaponIndex, list, sweepCheckParamter.EffectIDList, sweepCheckParamter.AbnormalStateEffectList, sweepCheckParamter.EffectIDListForSceneItem, sweepCheckParamter.HitDestructibleActorConfig, sweepCheckParamter.HitChrAudioID, sweepCheckParamter.HitChrFXWeight, sweepCheckParamter.HitCheckConfl, sweepCheckParamter.CanHitBackBullet, sweepCheckParamter.SweepCheckProtectTime, sweepCheckParamter.Animation, sweepCheckParamter.AtkReboundingAM, sweepCheckParamter.LowAtkReboundingAM, sweepCheckParamter.SweepCheckGroupID, DumperTruckTriggerData.FromInstanceID, sweepCheckParamter.EffectsWithCondition_Before, sweepCheckParamter.EffectsWithCondition_After, 0f);
	}

	public void TriggerBeginEvent()
	{
		BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit).Evt_PostAkEvent_AM.Invoke(UGSE_AnimFuncLib.GetCurrentActiveMontageInstanceID(DumperTruckTriggerData.ControlledUnit), DumperTruckTriggerData.ControlledUnit.Mesh, new FName(DumperTruckTriggerData.BeginAKEventParamter.AttachPointName), DumperTruckTriggerData.BeginAKEventParamter.AkStopEvent.Value, DumperTruckTriggerData.BeginAKEventParamter.AkEvent.Value, DumperTruckTriggerData.BeginAKEventParamter.Follow, DumperTruckTriggerData.BeginAKEventParamter.EventName, CanHandleStopRequest: false);
	}

	public void TriggerEndEvent()
	{
		BE.Evt_PostAkEvent_AM.Invoke(UGSE_AnimFuncLib.GetCurrentActiveMontageInstanceID(DumperTruckTriggerData.ControlledUnit), DumperTruckTriggerData.ControlledUnit.Mesh, new FName(DumperTruckTriggerData.EndAKEventParamter.AttachPointName), DumperTruckTriggerData.EndAKEventParamter.AkStopEvent.Value, DumperTruckTriggerData.EndAKEventParamter.AkEvent.Value, DumperTruckTriggerData.EndAKEventParamter.Follow, DumperTruckTriggerData.EndAKEventParamter.EventName, CanHandleStopRequest: false);
	}

	public void DisableSweepCheck()
	{
		BUS_EventCollectionCS.Get(DumperTruckTriggerData.ControlledUnit).Evt_SweepCheckEnd.Invoke(DumperTruckTriggerData.ObjectID, DumperTruckTriggerData.FromInstanceID, 0f);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		StateMachineData.GetCurrentSceneObjState(base.GuidData.GetFinalGuid(), out var GameplayTagContainerRef);
		if (!GameplayTagContainerRef.HasTag(BGW_FlowUtils.DumperTruckTag.State_Actived))
		{
			JumpToState(State_InActived, bSaveState: false);
		}
		base.OnEndPlay(EndPlayReason);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (DumperTruckTriggerData.CanTickAfterAnim)
		{
			PatrolTick(DeltaTime);
		}
	}

	public void SetCanTickAfterAnim(bool CanTick)
	{
		DumperTruckTriggerData.CanTickAfterAnim = CanTick;
	}

	private void PatrolTick(float DeltaTime)
	{
		if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(DumperTruckTriggerData.ControlledUnit, EBGUSimpleState.Immobilizing))
		{
			DumperTruckTriggerData.ControlledUnit.Mesh.SetPlayRate(0f);
			DisableSweepCheck();
			return;
		}
		if (DumperTruckTriggerData.IsRotating)
		{
			if (WaitTime < 0f)
			{
				DumperTruckTriggerData.IsRotating = false;
			}
			else
			{
				WaitTime -= DeltaTime;
			}
		}
		if (DumperTruckTriggerData.IsUseCurve)
		{
			if (UseTime < 0f)
			{
				DumperTruckTriggerData.IsUseCurve = false;
			}
			else
			{
				UseTime -= DeltaTime;
			}
		}
		if (DumperTruckTriggerData.ControlledUnit == null || DumperTruckTriggerData.ControlledUnit.IsNullOrDestroyed())
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, DumperTruckTriggerData.UnitGuid);
			if (actorByGuid != null)
			{
				IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(actorByGuid);
				BE = BUS_EventCollectionCS.Get(actorByGuid);
				if (readOnlyData.GetTargetInfo().LockTargetEntity == Entity.Null)
				{
					ACharacter playerCharacter = UBGUFunctionLibrary.GetPlayerCharacter(base.Owner);
					if (playerCharacter != null)
					{
						BE.Evt_AICatchTarget.Invoke(playerCharacter, ETargetSourceType.Target_AssignPlayerAsTarget);
					}
				}
				DumperTruckTriggerData.ControlledUnit = actorByGuid as ACharacter;
				DumperTruckTriggerData.ABPClass = DumperTruckTriggerData.ControlledUnit.Mesh.GetAnimInstance().GetClass();
				BE.Evt_ChangeAnimMode.Invoke(EAnimationMode.AnimationSingleNode);
				UAnimationAsset uAnimationAsset = null;
				uAnimationAsset = ((!(DumperTruckTriggerData.AnimationAsset != null)) ? BGW_PreloadAssetMgr.Get(base.Owner).TryGetCachedResourceObj<UAnimationAsset>("AnimSequence'/Game/00Main/Animation/HYS/HYS_Ball/AS_HYS_Ball_01_Atk_01.AS_HYS_Ball_01_Atk_01'", ELoadResourceType.SyncLoadAndCache) : DumperTruckTriggerData.AnimationAsset);
				DumperTruckTriggerData.ControlledUnit.Mesh.SetAnimation(uAnimationAsset);
				DumperTruckTriggerData.ControlledUnit.Mesh.Play(bLooping: true);
			}
		}
		if (DumperTruckTriggerData.ControlledUnit.IsNullOrDestroyed())
		{
			return;
		}
		if (BE == null)
		{
			BE = BUS_EventCollectionCS.Get(BGU_DataUtil.GetActorByGuid(base.Owner, DumperTruckTriggerData.UnitGuid));
		}
		if (DumperTruckTriggerData.SplineList != null && DumperTruckTriggerData.SplineList.Count != 0 && !DumperTruckTriggerData.IsRotating)
		{
			USplineComponent uSplineComponent = DumperTruckTriggerData.SplineList[DumperTruckTriggerData.CurrentIndex];
			FVector worldLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(DumperTruckTriggerData.ControlledUnit);
			float num = uSplineComponent.FindInputKeyClosestToWorldLocation(worldLocation);
			TargetInfoData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(DumperTruckTriggerData.ControlledUnit);
			AActor lockTargetActor = TargetInfoData.GetTargetInfo().LockTargetActor;
			if (num < (float)DumperTruckTriggerData.FirstAccelerationIndex)
			{
				if (!DumperTruckTriggerData.IsForward)
				{
					DumperTruckTriggerData.CurrentAcceleration = 0f - DumperTruckTriggerData.Acceleration;
				}
				else
				{
					DumperTruckTriggerData.CurrentAcceleration = DumperTruckTriggerData.Acceleration;
				}
			}
			else if (num > (float)DumperTruckTriggerData.SecondAccelerationIndex)
			{
				DumperTruckTriggerData.CurrentAcceleration = (DumperTruckTriggerData.IsForward ? (-1f) : (1f * DumperTruckTriggerData.Acceleration));
				if (DumperTruckTriggerData.IsForward)
				{
					DumperTruckTriggerData.CurrentAcceleration = 0f - DumperTruckTriggerData.Acceleration;
				}
				else
				{
					DumperTruckTriggerData.CurrentAcceleration = DumperTruckTriggerData.Acceleration;
				}
			}
			else
			{
				DumperTruckTriggerData.CurrentAcceleration = 0f;
			}
			if (DumperTruckTriggerData.NextIndex == DumperTruckTriggerData.CurrentIndex)
			{
				if (DumperTruckTriggerData.IsForward && DumperTruckTriggerData.CurrentAcceleration < 0f)
				{
					if (lockTargetActor != null)
					{
						FVector worldLocation2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor);
						if (uSplineComponent.FindInputKeyClosestToWorldLocation(worldLocation2) == (float)(uSplineComponent.GetNumberOfSplinePoints() - 1) && DumperTruckTriggerData.CurrentIndex + 1 < DumperTruckTriggerData.SplineList.Count)
						{
							DumperTruckTriggerData.CurrentAcceleration = 0f;
						}
					}
				}
				else if (!DumperTruckTriggerData.IsForward && DumperTruckTriggerData.CurrentAcceleration < 0f && lockTargetActor != null)
				{
					FVector worldLocation3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor);
					if (uSplineComponent.FindInputKeyClosestToWorldLocation(worldLocation3) == 0f && DumperTruckTriggerData.CurrentIndex - 1 >= 0)
					{
						DumperTruckTriggerData.CurrentAcceleration = 0f;
					}
				}
				DumperTruckTriggerData.CurrentSpeed += DumperTruckTriggerData.CurrentAcceleration * DeltaTime;
				DumperTruckTriggerData.CurrentSpeed = FMath.Clamp(DumperTruckTriggerData.CurrentSpeed, DumperTruckTriggerData.MinSpeed, DumperTruckTriggerData.MaxSpeed);
			}
			if (!DumperTruckTriggerData.IsRotating)
			{
				float num2 = (DumperTruckTriggerData.IsForward ? DumperTruckTriggerData.CurrentSpeed : (0f - DumperTruckTriggerData.CurrentSpeed)) * DeltaTime;
				CurDistance += num2;
				FTransform transformAtDistanceAlongSpline = uSplineComponent.GetTransformAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World);
				BGUFuncLibActorTransformCS.BGUSetActorLocation(DumperTruckTriggerData.ControlledUnit, transformAtDistanceAlongSpline.GetLocation(), bSweep: false, bTeleport: false);
				uSplineComponent.FindInputKeyClosestToWorldLocation(transformAtDistanceAlongSpline.GetLocation());
				if ((double)uSplineComponent.FindInputKeyClosestToWorldLocation(transformAtDistanceAlongSpline.GetLocation()) < 0.001 && !DumperTruckTriggerData.IsForward)
				{
					if (DumperTruckTriggerData.CurrentIndex - 1 >= 0 && uSplineComponent.FindInputKeyClosestToWorldLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor)) == 0f)
					{
						DumperTruckTriggerData.NextIndex = DumperTruckTriggerData.CurrentIndex - 1;
						DumperTruckTriggerData.NeedUpdataSpline = true;
					}
				}
				else if ((double)FMath.Abs(uSplineComponent.FindInputKeyClosestToWorldLocation(transformAtDistanceAlongSpline.GetLocation()) - (float)(uSplineComponent.GetNumberOfSplinePoints() - 1)) < 0.001 && DumperTruckTriggerData.IsForward && DumperTruckTriggerData.CurrentIndex + 1 < DumperTruckTriggerData.SplineList.Count && uSplineComponent.FindInputKeyClosestToWorldLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor)) == (float)(uSplineComponent.GetNumberOfSplinePoints() - 1))
				{
					DumperTruckTriggerData.NextIndex = DumperTruckTriggerData.CurrentIndex + 1;
					DumperTruckTriggerData.NeedUpdataSpline = true;
				}
				if (DumperTruckTriggerData.IsForward)
				{
					FRotator rotationAtDistanceAlongSpline = uSplineComponent.GetRotationAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World);
					BGUFuncLibActorTransformCS.BGUSetActorRotation(DumperTruckTriggerData.ControlledUnit, rotationAtDistanceAlongSpline, bTeleportPhysics: false);
				}
				else
				{
					FQuat fQuat = uSplineComponent.GetRotationAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World).Quaternion();
					BGUFuncLibActorTransformCS.BGUSetActorRotation(DumperTruckTriggerData.ControlledUnit, fQuat.Rotator(), bTeleportPhysics: false);
				}
				if (DumperTruckTriggerData.NeedUpdataSpline)
				{
					float num3 = CurDistance - num2;
					FRotator rotationAtDistanceAlongSpline2 = uSplineComponent.GetRotationAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World);
					if (DumperTruckTriggerData.NextIndex > DumperTruckTriggerData.CurrentIndex && DumperTruckTriggerData.IsForward)
					{
						DumperTruckTriggerData.CurrentIndex = DumperTruckTriggerData.NextIndex;
						DumperTruckTriggerData.NeedUpdataSpline = false;
						float distanceAlongSplineAtSplineInputKey = uSplineComponent.GetDistanceAlongSplineAtSplineInputKey(uSplineComponent.GetNumberOfSplinePoints() - 1);
						uSplineComponent = DumperTruckTriggerData.SplineList[DumperTruckTriggerData.CurrentIndex];
						CurDistance = num2 - (distanceAlongSplineAtSplineInputKey - num3);
						FTransform transformAtDistanceAlongSpline2 = uSplineComponent.GetTransformAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World);
						BGUFuncLibActorTransformCS.BGUSetActorLocation(DumperTruckTriggerData.ControlledUnit, transformAtDistanceAlongSpline2.GetLocation(), bSweep: false, bTeleport: false);
						BGUFuncLibActorTransformCS.BGUSetActorRotation(DumperTruckTriggerData.ControlledUnit, rotationAtDistanceAlongSpline2, bTeleportPhysics: false);
					}
					else if (DumperTruckTriggerData.NextIndex < DumperTruckTriggerData.CurrentIndex && !DumperTruckTriggerData.IsForward)
					{
						DumperTruckTriggerData.CurrentIndex = DumperTruckTriggerData.NextIndex;
						DumperTruckTriggerData.NeedUpdataSpline = false;
						uSplineComponent.GetDistanceAlongSplineAtSplineInputKey(0f);
						uSplineComponent = DumperTruckTriggerData.SplineList[DumperTruckTriggerData.CurrentIndex];
						CurDistance = uSplineComponent.GetDistanceAlongSplineAtSplineInputKey(uSplineComponent.GetNumberOfSplinePoints() - 1) - (num2 - num3);
						FTransform transformAtDistanceAlongSpline3 = uSplineComponent.GetTransformAtDistanceAlongSpline(CurDistance, ESplineCoordinateSpace.World);
						BGUFuncLibActorTransformCS.BGUSetActorLocation(DumperTruckTriggerData.ControlledUnit, transformAtDistanceAlongSpline3.GetLocation(), bSweep: false, bTeleport: false);
						FQuat fQuat2 = rotationAtDistanceAlongSpline2.Quaternion();
						BGUFuncLibActorTransformCS.BGUSetActorRotation(DumperTruckTriggerData.ControlledUnit, fQuat2.Rotator(), bTeleportPhysics: false);
					}
				}
				else
				{
					uSplineComponent.FindInputKeyClosestToWorldLocation(transformAtDistanceAlongSpline.GetLocation());
					if ((double)uSplineComponent.FindInputKeyClosestToWorldLocation(transformAtDistanceAlongSpline.GetLocation()) < 0.001 && !DumperTruckTriggerData.IsForward)
					{
						DumperTruckTriggerData.IsForward = true;
						DumperTruckTriggerData.IsRotating = true;
						DumperTruckTriggerData.RotateTargetPos = uSplineComponent.GetLocationAtSplineInputKey(0.3f, ESplineCoordinateSpace.World);
						BE.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f, NeedForceUpdate: true);
						BE.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackRotationBegin, -1f, NeedForceUpdate: true);
						BE.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AIInputRun, -1f, NeedForceUpdate: true);
						WaitTime = DumperTruckTriggerData.RotatorWaitTime;
						UseTime = DumperTruckTriggerData.UseCurveTime;
						DumperTruckTriggerData.IsUseCurve = true;
						BE.Evt_BuffAdd.Invoke(DumperTruckTriggerData.ForwardBuffID, base.Owner, base.Owner, -1f, EBuffSourceType.DumperTruckTrigger);
					}
					else if ((double)FMath.Abs(uSplineComponent.FindInputKeyClosestToWorldLocation(transformAtDistanceAlongSpline.GetLocation()) - (float)(uSplineComponent.GetNumberOfSplinePoints() - 1)) < 0.001 && DumperTruckTriggerData.IsForward)
					{
						DumperTruckTriggerData.IsForward = false;
						DumperTruckTriggerData.IsRotating = true;
						DumperTruckTriggerData.RotateTargetPos = uSplineComponent.GetLocationAtSplineInputKey((float)(uSplineComponent.GetNumberOfSplinePoints() - 1) - 0.3f, ESplineCoordinateSpace.World);
						BE.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackStateBegin, -1f, NeedForceUpdate: true);
						BE.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackRotationBegin, -1f, NeedForceUpdate: true);
						BE.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AIInputRun, -1f, NeedForceUpdate: true);
						WaitTime = DumperTruckTriggerData.RotatorWaitTime;
						UseTime = DumperTruckTriggerData.UseCurveTime;
						DumperTruckTriggerData.IsUseCurve = true;
						BE.Evt_BuffAdd.Invoke(DumperTruckTriggerData.BackBuffID, base.Owner, base.Owner, -1f, EBuffSourceType.DumperTruckTrigger);
					}
				}
			}
		}
		if (DumperTruckTriggerData.IsRotating || DumperTruckTriggerData.IsUseCurve)
		{
			DumperTruckTriggerData.CurrentSpeed = 0f;
			float floatValue = DumperTruckTriggerData.SpeedRateParamCurve.GetFloatValue(DumperTruckTriggerData.UseCurveTime - UseTime);
			float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, DumperTruckTriggerData.SpeedRateParam), new FVector2D(0.0, 1.0), floatValue);
			DumperTruckTriggerData.CurrentPlayRate = mappedRangeValueClamped;
			if (DumperTruckTriggerData.IsForward)
			{
				DumperTruckTriggerData.ControlledUnit.Mesh.SetPlayRate(mappedRangeValueClamped);
			}
			else
			{
				DumperTruckTriggerData.ControlledUnit.Mesh.SetPlayRate(0f - mappedRangeValueClamped);
			}
		}
		else
		{
			BE.Evt_BuffRemove.Invoke(DumperTruckTriggerData.ForwardBuffID, EBuffEffectTriggerType.None, 1);
			BE.Evt_BuffRemove.Invoke(DumperTruckTriggerData.BackBuffID, EBuffEffectTriggerType.None, 1);
			float mappedRangeValueClamped2 = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, DumperTruckTriggerData.SpeedRateParam), new FVector2D(0.0, 1.0), FMath.Abs(DumperTruckTriggerData.CurrentSpeed));
			DumperTruckTriggerData.CurrentPlayRate = mappedRangeValueClamped2;
			if (DumperTruckTriggerData.IsForward)
			{
				DumperTruckTriggerData.ControlledUnit.Mesh.SetPlayRate(mappedRangeValueClamped2);
			}
			else
			{
				DumperTruckTriggerData.ControlledUnit.Mesh.SetPlayRate(0f - mappedRangeValueClamped2);
			}
		}
		if (DumperTruckTriggerData.CurrentPlayRate > DumperTruckTriggerData.DamageAvailableSpeedThreshold)
		{
			EnableSweepCheck();
			TriggerBeginEvent();
		}
		else if (DumperTruckTriggerData.CurrentPlayRate < DumperTruckTriggerData.DamageDisableSpeedThreshold)
		{
			DisableSweepCheck();
			TriggerEndEvent();
		}
		bool flag = DumperTruckTriggerData.CurrentSpeed > DumperTruckTriggerData.ImmobilizeBuffSpeedThreshold;
		if (DumperTruckTriggerData.PreviousSpeedBiggerBuff != flag)
		{
			if (DumperTruckTriggerData.CurrentSpeed > DumperTruckTriggerData.ImmobilizeBuffSpeedThreshold)
			{
				BE.Evt_BuffAdd.Invoke(DumperTruckTriggerData.ImmobilizeBuffID, DumperTruckTriggerData.ControlledUnit, DumperTruckTriggerData.ControlledUnit, -1f, EBuffSourceType.DumperTruckTrigger);
			}
			else
			{
				BE.Evt_BuffRemove.Invoke(DumperTruckTriggerData.ImmobilizeBuffID, EBuffEffectTriggerType.Remove, -1);
			}
		}
		bool flag2 = DumperTruckTriggerData.CurrentSpeed < DumperTruckTriggerData.ImmobilizeDeBuffSpeedThreshold;
		if (DumperTruckTriggerData.PreviousSpeedSmallerDeBuff != flag2)
		{
			if (flag2)
			{
				BE.Evt_BuffAdd.Invoke(DumperTruckTriggerData.ImmobilizeDeBuffID, DumperTruckTriggerData.ControlledUnit, DumperTruckTriggerData.ControlledUnit, -1f, EBuffSourceType.DumperTruckTrigger);
			}
			else
			{
				BE.Evt_BuffRemove.Invoke(DumperTruckTriggerData.ImmobilizeDeBuffID, EBuffEffectTriggerType.Remove, -1);
			}
		}
		DumperTruckTriggerData.PreviousSpeedBiggerBuff = flag;
		DumperTruckTriggerData.PreviousSpeedSmallerDeBuff = flag2;
	}
}
