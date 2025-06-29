using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUS_SummonBehaviorComp : UActorCompBaseCS
{
	private b1.BUC_SummonBehaviorData SummonBehaviorData;

	private IBUC_MasterData MasterData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_SimpleStateData SimpleStatData;

	private IBUC_PropMgrData PropMgrData;

	private const int SummonCopySkillBuff = 278;

	private const string CopySkillTeleportDBCPath = "BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FenShen/DBC/DBC_fenshen_disappear.DBC_fenshen_disappear'";

	public override void OnAttach()
	{
		SummonBehaviorData = RequireWritableData<b1.BUC_SummonBehaviorData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		SimpleStatData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		base.BUSEventCollection.Evt_SetSummonBehaviorState += new Del_SetSummonBehaviorState(OnSetSummonBehaviorState);
		base.BUSEventCollection.Evt_SetSummonStateBehaviorTree += new Del_SetSummonStateBehaviorTree(OnSetSummonStateBehaviorTree);
		base.BUSEventCollection.Evt_CallSummonUseSkill += new Del_Void_Int(OnCallSummonUseSkill);
		base.BUSEventCollection.Evt_SummonBehaviorUseSkill += new Del_Void(OnSummonBehaviorUseSkill);
		base.BUSEventCollection.Evt_PhantomRushSummonBehavior += new Del_PhantomRushSummonBehavior(OnPhantomRushSummonBehavior);
		base.BUSEventCollection.Evt_CopySkillSummonBehavior += new Del_CopySkillSummonBehavior(OnCopySkillSummonBehavior);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		base.BUSEventCollection.Evt_MarkAsServant += new Del_MarkAsServant(MarkAsServant);
		base.BUSEventCollection.Evt_MarkSummonCantLifeOver += new Del_Void_Bool(MarkSummonCantLifeOver);
	}

	private void MarkSummonCantLifeOver(bool bCantLifeOver)
	{
		FServantInstanceBase servantInstance = SummonBehaviorData.ServantInstance;
		if (servantInstance != null)
		{
			servantInstance.bCantAliveTimeOver = bCantLifeOver;
		}
	}

	private void MarkAsServant(FServantInstanceBase ServantInstance)
	{
		SummonBehaviorData.ServantInstance = ServantInstance;
	}

	public override void PreBeginPlay()
	{
		SummonBehaviorData.InitSummonBehaviorData();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!SummonBehaviorData.bNeedUpdateForSetBTActive)
		{
			UpdateForSummonBehaviorUsingSkill();
		}
	}

	private void UpdateForSummonBehaviorUsingSkill()
	{
		if (SummonBehaviorData.bSummonBehaviorUsingSkill && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			if (SummonBehaviorData.QueueSkillID.Count == 0)
			{
				SummonBehaviorData.bSummonBehaviorUsingSkill = false;
			}
			else if (UpdateSummonBehaviorUseSkill())
			{
				SummonBehaviorData.QueueSkillID.Dequeue();
			}
		}
	}

	private bool UpdateSummonBehaviorUseSkill()
	{
		int skillID = SummonBehaviorData.QueueSkillID.Peek();
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(skillID);
		if (skillAIDesc == null)
		{
			return true;
		}
		AActor masterActor = MasterData.GetMasterActor();
		if (masterActor == null)
		{
			return true;
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(masterActor);
		if (readOnlyData == null)
		{
			return true;
		}
		base.BUSEventCollection?.Evt_AICatchTarget.Invoke(readOnlyData.GetTargetInfo().LockTargetActor, ETargetSourceType.Target_SummonAssignMasterTarget);
		UnitLockTargetInfo targetInfo = TargetInfoData.GetTargetInfo();
		if (targetInfo == null || targetInfo.LockTargetActor == null)
		{
			base.BUSEventCollection?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(skillID, ECastSkillSourceType.SummonBehavior));
			return SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK;
		}
		FVector fVector = BGUFuncLibAICS.BGUAIGetTargetInfoRealLockPoint(targetInfo);
		float num = MathLib.Abs((BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()) - fVector).Size2D());
		float num2 = MathLib.Abs(BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()).Z - fVector.Z);
		if (num <= skillAIDesc.OptimalDisMax && num2 <= skillAIDesc.PreferHeightDis)
		{
			BGUFuncLibForMove.CancelMove(Owner);
			base.BUSEventCollection?.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(skillID, ECastSkillSourceType.SummonBehavior));
			return SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK;
		}
		if (!BGUFuncLibForMove.IsMoveActive(Owner))
		{
			BGUFuncLibForMove.BeginMoveToTarget(Owner, targetInfo, 1f, EAIMoveSpeedType.SPRINT, EBGUMoveAIType.None, IncludeSelfRadius: true, IncludeTargetRadius: false, out var _);
			return false;
		}
		return false;
	}

	private void OnSetSummonBehaviorState(ESummonBehaviorState State, bool NeedForceSet = false)
	{
		if (!(MasterData.GetMasterActor() == null) && (SummonBehaviorData.BehaviorState != State || NeedForceSet))
		{
			SummonBehaviorData.BehaviorState = State;
			if (SummonBehaviorData.MapStateBehaviorTree.TryGetValue(State, out var value))
			{
				base.BUSEventCollection?.Evt_SetBT.Invoke(value);
			}
		}
	}

	private void OnSetSummonStateBehaviorTree(ESummonBehaviorState State, UBehaviorTree BT)
	{
		if (SummonBehaviorData.MapStateBehaviorTree.ContainsKey(State))
		{
			SummonBehaviorData.MapStateBehaviorTree[State] = BT;
		}
	}

	private void OnCallSummonUseSkill(int SkillID)
	{
		SummonBehaviorData.QueueSkillID.Enqueue(SkillID);
	}

	private void OnSummonBehaviorUseSkill()
	{
		SummonBehaviorData.bSummonBehaviorUsingSkill = true;
	}

	private void OnPhantomRushSummonBehavior(FContinueBehaviorInfo CBI)
	{
		if (GetOwner() as ACharacter == null)
		{
			return;
		}
		SummonBehaviorData.CBI = CBI;
		SummonBehaviorData.bNeedUpdateForSetBTActive = false;
		SummonBehaviorData.bNeedUpdateForContinueBehavior = false;
		SummonBehaviorData.SpecialSummonBehaviorType = b1.ESpecialSummonBehaviorType.PhantomRush;
		if (CBI.CBT == EContinueBehaviorType.AnimationSyncing)
		{
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, CBI.BeatbackMontage, FName.None, EMontageBindReason.SummonBehavior, 1f, 1f, CBI.MontagePos);
		}
		else
		{
			IBUC_PhantomRushData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PhantomRushData, BUC_PhantomRushData>(MasterData.GetMasterActor());
			if (readOnlyData != null)
			{
				base.BUSEventCollection.Evt_OnToggleSnapshotPose.Invoke(bEnable: true, readOnlyData.PoseSnapshot, 0f);
			}
		}
		base.BUSEventCollection.Evt_SetBT.Invoke(null);
		base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "OnPhantomRushSummonBehavior");
	}

	private void OnCopySkillSummonBehavior(UAnimMontage CopyAnim, in FTransform TeleportTrans)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		SummonBehaviorData.bNeedUpdateForSetBTActive = false;
		SummonBehaviorData.bNeedUpdateForContinueBehavior = false;
		SummonBehaviorData.SpecialSummonBehaviorType = b1.ESpecialSummonBehaviorType.CopySkill;
		base.BUSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke("BGWDataAsset_B1DBC'/Game/00Main/VFX/Characters/sunwukong/Niagara/FenShen/DBC/DBC_fenshen_disappear.DBC_fenshen_disappear'", out var _, null, NeedSetSpawnTransform: true, BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter));
		base.BUSEventCollection.Evt_TeleportMoveByTrans.Invoke(TeleportTrans);
		AActor masterActor = MasterData.GetMasterActor();
		if (masterActor != null)
		{
			AActor lockTargetActor = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(masterActor).GetTargetInfo().LockTargetActor;
			if (lockTargetActor != null)
			{
				base.BUSEventCollection.Evt_AICatchTarget.Invoke(lockTargetActor, ETargetSourceType.Target_SummonAssignMasterTarget, SkipWakeUp: true);
			}
			else
			{
				base.BUSEventCollection.Evt_ClearTargetInfo.Invoke();
			}
		}
		SetCopySkillState(bCopySkill: true);
		BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, CopyAnim, FName.None, EMontageBindReason.SummonBehavior);
	}

	private void SetCopySkillState(bool bCopySkill)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null))
		{
			if (bCopySkill)
			{
				base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
				base.BUSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: false);
				base.BUSEventCollection.Evt_BuffAdd.Invoke(278, aCharacter, aCharacter, 0f, EBuffSourceType.SummonBehavior);
				SummonBehaviorData.ServantInstance.bPausedAliveTime = true;
			}
			else
			{
				base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
				base.BUSEventCollection.Evt_AIPerceptionSetting.Invoke(P1: true);
				base.BUSEventCollection.Evt_BuffRemove.Invoke(278, EBuffEffectTriggerType.None, 1);
				SummonBehaviorData.ServantInstance.bPausedAliveTime = false;
			}
		}
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (Reason != EMontageBindReason.SummonBehavior || (State != EMontageCallbackState.OnBlendOut && State != EMontageCallbackState.OnInterrupted))
		{
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (!(mesh == null))
		{
			switch (SummonBehaviorData.SpecialSummonBehaviorType)
			{
			case b1.ESpecialSummonBehaviorType.PhantomRush:
			{
				FPoseSnapshot Snapshot = default(FPoseSnapshot);
				mesh.SnapshotPose(ref Snapshot);
				base.BUSEventCollection?.Evt_OnToggleSnapshotPose.Invoke(bEnable: true, Snapshot, 0f);
				break;
			}
			case b1.ESpecialSummonBehaviorType.CopySkill:
				SetCopySkillState(bCopySkill: false);
				break;
			}
			SummonBehaviorData.SpecialSummonBehaviorType = b1.ESpecialSummonBehaviorType.None;
		}
	}
}
