using System;
using System.Collections.Generic;
using b1.BGU.BUAnim;
using b1.BGW;
using b1.ECS;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_ABPHelperComp : UActorCompBaseCS
{
	private FName speed = B1GlobalFNames.speed;

	private FName WalkRotationAlpha = B1GlobalFNames.WalkRotationAlpha;

	private FName RunRotationAlpha = B1GlobalFNames.RunRotationAlpha;

	private FName RushRotationAlpha = B1GlobalFNames.RushRotationAlpha;

	private FName LoopLean = B1GlobalFNames.LoopLean;

	private FName ChangeAnimRate = B1GlobalFNames.ChangeAnimRate;

	private FName Distance = B1GlobalFNames.Distance;

	private FName YawRotationSpeed = B1GlobalFNames.YawRotationSpeed;

	private FName FootIKMaskValue = B1GlobalFNames.FootIKMaskValue;

	private FName UpperBodyBlendWeight = B1GlobalFNames.UpperBodyBlendWeight;

	private FName LeftArmBlendWeight = B1GlobalFNames.LeftArmBlendWeight;

	private FName RightArmBlendWeight = B1GlobalFNames.RightArmBlendWeight;

	private FName LeftLegBlendWeight = B1GlobalFNames.LeftLegBlendWeight;

	private FName RightLegBlendWeight = B1GlobalFNames.RightLegBlendWeight;

	private FName Quadruped_IKFootRAlpha = B1GlobalFNames.Quadruped_IKFootRAlpha;

	private FName Quadruped_IKFootLAlpha = B1GlobalFNames.Quadruped_IKFootLAlpha;

	private FName Quadruped_IKHandRAlpha = B1GlobalFNames.Quadruped_IKHandRAlpha;

	private FName Quadruped_IKHandLAlpha = B1GlobalFNames.Quadruped_IKHandLAlpha;

	private FName Quadruped_SpineIKAlpha = B1GlobalFNames.Quadruped_SpineIKAlpha;

	private FName LimbIKAlpha = B1GlobalFNames.LimbIKAlpha;

	private FName PhysWeight = B1GlobalFNames.PhysWeight;

	private FName FootLock_L = B1GlobalFNames.FootLock_L;

	private FName FootLock_R = B1GlobalFNames.FootLock_R;

	private FName FootLockZ_L = B1GlobalFNames.FootLockZ_L;

	private FName FootLockZ_R = B1GlobalFNames.FootLockZ_R;

	private FName AddMaxSpeed = B1GlobalFNames.AddMaxSpeed;

	private FName MaxAcceleration = B1GlobalFNames.MaxAcceleration;

	private FName BrakingDecelerationWalking = B1GlobalFNames.BrakingDecelerationWalking;

	private FName GroundFriction = B1GlobalFNames.GroundFriction;

	private FName ForwardMovementSpeed = B1GlobalFNames.ForwardMovementSpeed;

	private FName RightMovementSpeed = B1GlobalFNames.RightMovementSpeed;

	private FName UpMovementSpeed = B1GlobalFNames.UpMovementSpeed;

	private FName DisableProceduralFootStep = B1GlobalFNames.DisableProceduralFootStep;

	private FName SkillCastTimeRange = B1GlobalFNames.SkillCastTimeRange;

	private FName BodySplit_Leg = B1GlobalFNames.BodySplit_Leg;

	private FName BodySplit_Pelvis = B1GlobalFNames.BodySplit_Pelvis;

	private FName BodySplit_Spine = B1GlobalFNames.BodySplit_Spine;

	private FName BodySplit_Head = B1GlobalFNames.BodySplit_Head;

	private FName BodySplit_ArmL = B1GlobalFNames.BodySplit_ArmL;

	private FName BodySplit_ArmR = B1GlobalFNames.BodySplit_ArmR;

	private FName BodySplit_ArmL_LS = B1GlobalFNames.BodySplit_ArmL_LS;

	private FName BodySplit_ArmR_LS = B1GlobalFNames.BodySplit_ArmR_LS;

	private FName MonsterLocomotionLockStopSlotName = B1GlobalFNames.Flat;

	private FName CurveMoveRootMotionSourceInstanceName = B1GlobalFNames.CommonCurveMoveRootMotionSourceObject;

	private FName MoveGrounded_FreeNew = B1GlobalFNames.MoveGrounded_FreeNew;

	private FName WalkFree = B1GlobalFNames.WalkFree;

	private FName RunFree = B1GlobalFNames.RunFree;

	private FName RushFree = B1GlobalFNames.RushFree;

	private FName StopFree = B1GlobalFNames.StopFree;

	private FName RunState = B1GlobalFNames.RunState;

	private FName SharpTurn = B1GlobalFNames.SharpTurn;

	private FName RushState = B1GlobalFNames.RushState;

	private FName RushLoop = B1GlobalFNames.RushLoop;

	private FName MoveGrounded_LockNew = B1GlobalFNames.MoveGrounded_LockNew;

	private FName LockMoveState = B1GlobalFNames.LockMoveState;

	private FName LockGroundedLayerMain = B1GlobalFNames.LockGroundedLayerMain;

	private FName SpecialMove = B1GlobalFNames.SpecialMove;

	private FName SplineMoveBaseLayer = B1GlobalFNames.SplineMoveBaseLayer;

	private FName Fwd = B1GlobalFNames.Fwd;

	private FName Bwd = B1GlobalFNames.Bwd;

	private FName Left_f = B1GlobalFNames.Left_f;

	private FName Left_b = B1GlobalFNames.Left_b;

	private FName Right_f = B1GlobalFNames.Right_f;

	private FName Right_b = B1GlobalFNames.Right_b;

	private FName CloudFlySM = B1GlobalFNames.CloudFlySM;

	private FName MoveGrounded = B1GlobalFNames.MoveGrounded;

	private FName Move = B1GlobalFNames.Move;

	private FName UpperBody = B1GlobalFNames.UpperBody;

	private FName LeftArm = B1GlobalFNames.LeftArm;

	private FName RightArm = B1GlobalFNames.RightArm;

	private FName Facial = B1GlobalFNames.Facial;

	private FName StandRotate = B1GlobalFNames.StandRotate;

	private FName Rotate = B1GlobalFNames.Rotate;

	private const float NormalScreenSizeThresholdNear = 0.1f;

	private const float NormalScreenSizeThresholdFar = 0.05f;

	private const float SmallScreenSizeThresholdNear = 0.08f;

	private const float SmallScreenSizeThresholdFar = 0.04f;

	private BUC_ABPCharacterData ChrData;

	private BUC_ABPBGUCharacterData BGUData;

	private BUC_ABPBasicData BasicData;

	private BUC_ABPJogData HumanoidJogData;

	private BUC_ABPJumpV2Data JumpV2Data;

	private BUC_ABPFootIKData FootIKData;

	private BUC_ABPSpineIKData SpineIKData;

	private BUC_ABPAttackIKData AttackIKData;

	private BUC_ABPHeadAimingData HeadAimingData;

	private BUC_ABPUpperBodyAimingData UpperBodyAimingData;

	private BUC_ABPMMFixedData MMFixedData;

	private BUC_ABPBodyBlendData BodyBlendData;

	private BUC_ABPCommonSettingData CommonData;

	private BUC_ABPMotionMatchingData MMData;

	private BUC_ABPPatrolData PatrolData;

	private BUC_ABPNPCAnimData NPCAnimData;

	private BUC_ABPCommonLocomotionData LocomotionData;

	private BUC_ABPFlyControlData FlyControlData;

	private BUC_ABPPoseSnapshotData PoseSnapshotData;

	private BUC_ABPPlayerLocomotionData PlayerLocomotionData;

	private BUC_ABPAdvancedMonsterLocomotionData AdvancedMonsterLocomotionData;

	private BUC_ABPGlideMoveData GlideMoveData;

	private BUC_ABPAimOffsetData AimOffsetData;

	private BUC_ABPWeaponAimData WeaponAimData;

	private BUC_ABPSpecialMoveData SpecialMoveData;

	private BUC_ABPParkourMoveData ParkourMoveData;

	private BUC_ABPAMMatryoshkaData AMMatryoshkaData;

	private BUC_ABPMonsterLocomotionData MonsterLocomotionData;

	private BUC_ABPAttackOffsetData AttackOffsetData;

	private BUC_ABPSlowIKData SlowIKData;

	private BUC_ABPSplineMoveData SplineMoveData;

	private BUC_ABPCloudLocomotionData CloudLocomotionData;

	private BUC_ABPSpeicalAdditiveData SpecialAdditiveData;

	private BUC_ABPHelperData ABPHelperData;

	private BUC_ABPWheelMoveData WheelMoveData;

	private BUC_ABPQuadrupedLocomotionData QuadrupedLocomotionData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_EnvironmentInteractionMgrData SurfaceCheckData;

	private IBUC_TickRateData TickRateData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SpeedCtrlData SpeedCtrlData;

	private IBUC_PlayerCameraData CameraData;

	private IBUC_ActorBasicData ActorBasicData;

	private IBUC_MovementData MovementData;

	private IBUC_HardMoveData HardMoveData;

	private IBUC_TargetInfoData TargetInfoData;

	private IBUC_SceneItemData SceneItemData;

	private IBUC_SplineFlyMoveData SplineFlyMoveData;

	private IBUC_GlideMoveData GlideMoveLogicData;

	private IBUC_ParkourMoveData ParkourMoveLogicData;

	private IBUC_AIData AIData;

	private IBUC_PatrolData PatrolLogicData;

	private IBUC_NPCAnimData NPCAnimLogicData;

	private IBUC_PropMgrData PropMgrData;

	private IBUC_BattleStateData BattleStateData;

	private IBUC_JumpData JumpData;

	private IBUC_SimpleJumpData SimpleJumpData;

	private IBUC_ManualSplineMoveData ManualSplineMoveData;

	private IBUC_ControllerData ControllerData;

	private IBUC_CloudMoveData CloudMoveData;

	private const int ProfileStatCount = 12;

	private static int[] ProfileStats;

	private TStrongObjectPtr<UBGUCharacterMovementComponent> mCppCharacterMovementComp = new TStrongObjectPtr<UBGUCharacterMovementComponent>();

	private BUC_ABPEventCollection ABPEventCollection;

	private TStrongObjectPtr<UAnimInstance> CachedPlayerLocomotionAnimInst { get; set; } = new TStrongObjectPtr<UAnimInstance>();

	private TStrongObjectPtr<UAnimInstance> CachedAdvancedMonsterLocomotionAnimInst { get; set; } = new TStrongObjectPtr<UAnimInstance>();

	private TStrongObjectPtr<UAnimInstance> CachedCloudLocomotionAnimInst { get; set; } = new TStrongObjectPtr<UAnimInstance>();

	private TStrongObjectPtr<UAnimInstance> CachedSpecialMoveAnimInst { get; set; } = new TStrongObjectPtr<UAnimInstance>();

	private TStrongObjectPtr<UAnimInstance> CachedMoveAnimInst { get; set; } = new TStrongObjectPtr<UAnimInstance>();

	private UBGUCharacterMovementComponent CppCharacterMovementComp
	{
		get
		{
			return mCppCharacterMovementComp.Get();
		}
		set
		{
			mCppCharacterMovementComp.Set(value);
		}
	}

	public override void OnAttach()
	{
		ChrData = RequireWritableData<BUC_ABPCharacterData>();
		BGUData = RequireWritableData<BUC_ABPBGUCharacterData>();
		BasicData = RequireWritableData<BUC_ABPBasicData>();
		HumanoidJogData = RequireWritableData<BUC_ABPJogData>();
		JumpV2Data = RequireWritableData<BUC_ABPJumpV2Data>();
		FootIKData = RequireWritableData<BUC_ABPFootIKData>();
		SpineIKData = RequireWritableData<BUC_ABPSpineIKData>();
		AttackIKData = RequireWritableData<BUC_ABPAttackIKData>();
		HeadAimingData = RequireWritableData<BUC_ABPHeadAimingData>();
		UpperBodyAimingData = RequireWritableData<BUC_ABPUpperBodyAimingData>();
		MMFixedData = RequireWritableData<BUC_ABPMMFixedData>();
		BodyBlendData = RequireWritableData<BUC_ABPBodyBlendData>();
		AimOffsetData = RequireWritableData<BUC_ABPAimOffsetData>();
		WeaponAimData = RequireWritableData<BUC_ABPWeaponAimData>();
		CommonData = RequireWritableData<BUC_ABPCommonSettingData>();
		MMData = RequireWritableData<BUC_ABPMotionMatchingData>();
		PatrolData = RequireWritableData<BUC_ABPPatrolData>();
		NPCAnimData = RequireWritableData<BUC_ABPNPCAnimData>();
		LocomotionData = RequireWritableData<BUC_ABPCommonLocomotionData>();
		FlyControlData = RequireWritableData<BUC_ABPFlyControlData>();
		PoseSnapshotData = RequireWritableData<BUC_ABPPoseSnapshotData>();
		PlayerLocomotionData = RequireWritableData<BUC_ABPPlayerLocomotionData>();
		AdvancedMonsterLocomotionData = RequireWritableData<BUC_ABPAdvancedMonsterLocomotionData>();
		GlideMoveData = RequireWritableData<BUC_ABPGlideMoveData>();
		SpecialMoveData = RequireWritableData<BUC_ABPSpecialMoveData>();
		ParkourMoveData = RequireWritableData<BUC_ABPParkourMoveData>();
		AMMatryoshkaData = RequireWritableData<BUC_ABPAMMatryoshkaData>();
		MonsterLocomotionData = RequireWritableData<BUC_ABPMonsterLocomotionData>();
		AttackOffsetData = RequireWritableData<BUC_ABPAttackOffsetData>();
		SlowIKData = RequireWritableData<BUC_ABPSlowIKData>();
		SplineMoveData = RequireWritableData<BUC_ABPSplineMoveData>();
		CloudLocomotionData = RequireWritableData<BUC_ABPCloudLocomotionData>();
		SpecialAdditiveData = RequireWritableData<BUC_ABPSpeicalAdditiveData>();
		ABPHelperData = RequireWritableData<BUC_ABPHelperData>();
		WheelMoveData = RequireWritableData<BUC_ABPWheelMoveData>();
		QuadrupedLocomotionData = RequireWritableData<BUC_ABPQuadrupedLocomotionData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SurfaceCheckData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SpeedCtrlData = RequireReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>();
		CameraData = RequireReadOnlyData<IBUC_PlayerCameraData, BUC_PlayerCameraData>();
		ActorBasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		HardMoveData = RequireReadOnlyData<IBUC_HardMoveData, b1.BUC_HardMoveData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		SceneItemData = RequireReadOnlyData<IBUC_SceneItemData, BUC_SceneItemData>();
		SplineFlyMoveData = RequireReadOnlyData<IBUC_SplineFlyMoveData, b1.BUC_SplineFlyMoveData>();
		GlideMoveLogicData = RequireReadOnlyData<IBUC_GlideMoveData, b1.BUC_GlideMoveData>();
		ParkourMoveLogicData = RequireReadOnlyData<IBUC_ParkourMoveData, b1.BUC_ParkourMoveData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		PatrolLogicData = RequireReadOnlyData<IBUC_PatrolData, BUC_PatrolData>();
		NPCAnimLogicData = RequireReadOnlyData<IBUC_NPCAnimData, BUC_NPCAnimData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		JumpData = RequireReadOnlyData<IBUC_JumpData, b1.BUC_JumpData>();
		SimpleJumpData = RequireReadOnlyData<IBUC_SimpleJumpData, BUC_SimpleJumpData>();
		ManualSplineMoveData = RequireReadOnlyData<IBUC_ManualSplineMoveData, BUC_ManualSplineMoveData>();
		ControllerData = RequireReadOnlyData<IBUC_ControllerData, BUC_ControllerData>();
		CloudMoveData = RequireReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>();
		ABPEventCollection = BUC_ABPEventCollection.Get(this);
		base.BUSEventCollection.Evt_OnChangeABP += new Del_OnChangeABP(OnChangeABP);
		base.BUSEventCollection.Evt_ChangeSkeletalMeshWithABP += new Del_ChangeSkeletalMeshWithABP(OnChangeSkeletalMeshWithABP);
		base.BUSEventCollection.Evt_ChangeAnimMode += new Del_ChangeAnimMode(OnChangeAnimMode);
		base.BUSEventCollection.Evt_ChangeABPSetting += new Del_ChangeABPSetting(OnChangeABPSetting);
		base.BUSEventCollection.Evt_ResetABPSetting += new Del_Void(OnResetABPSetting);
		base.BUSEventCollection.Evt_ChangeMotionMatchingState += new Del_ChangeMotionMatchingState(OnChangeMotionMatchingState);
		base.BUSEventCollection.Evt_MotionMatchingAnimLoadFinished += new Del_AAMotionMatchAssetPreloadRequireFinished(OnMotionMatchingAnimLoadFinished);
		base.BUSEventCollection.Evt_MotionMatchingAnimUsingPreLoad += new Del_AAMotionMatchAssetPreloadRequire(OnMotionMatchingAnimUsingPreLoad);
		base.BUSEventCollection.Evt_SetRecordMMAnimData += new Del_Void_Bool(OnSetRecordMMAnimData);
		base.BUSEventCollection.Evt_SetDisableLocomotionIdle += new Del_Void_Bool(OnSetDisableLocomotionIdle);
		base.BUSEventCollection.Evt_SetTouchIKActive += new Del_Void_BoolBool(OnSetTouchIKActive);
		base.BUSEventCollection.Evt_SetTouchIKInfo += new Del_SetTouchIKInfo(OnSetTouchIKInfo);
		base.BUSEventCollection.Evt_SetTouchIKTargetActor += new Del_Void_Actor(OnSetTouchIKTargetActor);
		base.BUSEventCollection.Evt_DoJumpAnim += new Del_DoJumpAnim(TriggerJumpAnim);
		base.BUSEventCollection.Evt_NotifyStrideJumpHeight += new Del_Void_Float(OnSetStrideJumpHeight);
		base.BUSEventCollection.Evt_NotifyAnimFallHeight += new Del_Void_Float(OnSetFallHeight);
		base.BUSEventCollection.Evt_CheckLittleFall += new Del_Void_Float(CheckLittleFall);
		base.BUSEventCollection.Evt_SetEnableIK += new Del_Void_BoolBool(OnSetEnableIK);
		base.BUSEventCollection.Evt_SetEnableSpineIK += new Del_Void_Bool(OnSetEnableSpineIK);
		base.BUSEventCollection.Evt_OnToggleSnapshotPose += new Del_ToggleSnapshotPose(OnToggleSnapshotPose);
		base.BUSEventCollection.Evt_SetPlayerLocomotionLockMoveDirection += new Del_SetPlayerLocomotionLockMoveDirection(OnSetPlayerLocomotionLockMoveDirection);
		base.BUSEventCollection.Evt_PlayerLocomotionStartIdle += new Del_Void(OnPlayerLocomotionStartIdle);
		base.BUSEventCollection.Evt_SetPlayerLocomotionLockTurnStopDirection += new Del_SetPlayerLocomotionLockMoveDirection(OnSetPlayerLocomotionLockTurnStopDirection);
		base.BUSEventCollection.Evt_PlayerLocomotionEnterLockMoveState += new Del_Void(OnPlayerLocomotionEnterLockMoveState);
		base.BUSEventCollection.Evt_SetAimOffsetBlend += new Del_SetAimOffsetBlend(OnSetAimOffsetBlend);
		base.BUSEventCollection.Evt_UnitSkillBreak += new Del_UnitSkillBreak(OnUnitSkillBreak);
		base.BUSEventCollection.Evt_SetUpperBodyAO += new Del_SetUpperBodyAO(SetUpperBodyAO);
		base.BUSEventCollection.Evt_SetForceMMToIdle += new Del_Void_Bool(OnSetForceMMToIdle);
		base.BUSEventCollection.Evt_OnAimToBegin += new Del_OnAimToBegin(OnAimToBegin);
		base.BUSEventCollection.Evt_OnAimToEnd += new Del_Void(OnAimToEnd);
		base.BUSEventCollection.Evt_SetSpecialMovementMode += new Del_SetSpecialMovementMode(OnSetSpecialMovementMode);
		base.BUSEventCollection.Evt_SetGlideMoveAnimState += new Del_SetGlideMoveAnimState(OnSetGlideMoveAnimState);
		base.BUSEventCollection.Evt_NotifyEnterGlideMove += new Del_Void(OnEnterGlideMove);
		base.BUSEventCollection.Evt_SetParkourLandCanMove += new Del_Void(OnSetParkourLandCanMove);
		base.BUSEventCollection.Evt_SetAnimHumanoidAMMatryoshka += new Del_Void_Float(OnSetAnimHumanoidAMMatryoshka);
		base.BUSEventCollection.Evt_SetMonsterLocomotionLockMoveDir += new Del_SetMonsterLocomotionLockMoveDir(OnSetMonsterLocomotionLockMoveDir);
		base.BUSEventCollection.Evt_MonsterLocomotionLockStopLeft += new Del_Void_AnimInstance(OnMonsterLocomotionLockStopLeft);
		base.BUSEventCollection.Evt_MonsterLocomotionLockStopRight += new Del_Void_AnimInstance(OnMonsterLocomotionLockStopRight);
		base.BUSEventCollection.Evt_MonsterLocomotionEnterMoveLoop += new Del_Void_AnimInstance(OnMonsterLocomotionEnterMoveLoop);
		base.BUSEventCollection.Evt_SplineMoveEnterStopState += new Del_Void(OnSplineMoveEnterStopState);
		base.BUSEventCollection.Evt_SetAttackOffset += new Del_SetAttackOffset(OnSetAttackOffset);
		base.BUSEventCollection.Evt_SetAttackOffsetAlpha += new Del_Void_Float(OnSetAttackOffsetAlpha);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_ChangeAimOffset += new Del_ChangeAimOffset(OnChangeAimOffset);
		base.BUSEventCollection.Evt_ResetAimOffset += new Del_Void_Bool(OnResetAimOffset);
		base.BUSEventCollection.Evt_SetAttackIKTargetActor += new Del_SetAttackIKTargetActor(OnSetAttackIKTargetActor);
		base.BUSEventCollection.Evt_SetAttackIKAlpha += new Del_SetAttackIKAlpha(OnSetAttackIKAlpha);
		base.BUSEventCollection.Evt_SetAttackIKFishSpike += new Del_SetAttackIKFishSpike(OnSetAttackIKFishSpike);
		base.BUSEventCollection.Evt_SetAttackIKFishSpikeAlpha += new Del_SetAttackIKFishSpikeAlpha(OnSetAttackIKFishSpikeAlpha);
		base.BUSEventCollection.Evt_DisableTargetAttackIK += new Del_DisableTargetAttackIK(OnDisableTargetAttackIK);
		base.BUSEventCollection.Evt_SetAttackIKBoneScale += new Del_SetAttackIKBoneScale(OnSetAttackIKBoneScale);
		base.BUSEventCollection.Evt_SetAttackIKBoneScaleAlpha += new Del_SetAttackIKBoneScaleAlpha(OnSetAttackIKBoneScaleAlpha);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		base.BUSEventCollection.Evt_NotifyBattleStateChange += new Del_NotifyBattleStateChange(OnNotifyBattleStateChange);
		base.BUSEventCollection.Evt_SetEnableAnimCurveBodyBlend += new Del_SetEnableAnimCurveBodyBlend(OnSetEnableAnimCurveBodyBlend);
		base.BUSEventCollection.Evt_CachePlayerLocomotionAnimInst += new Del_Void_AnimInstance(OnCachePlayerLocomotionAnimInst);
		base.BUSEventCollection.Evt_CacheAdvancedMonsterLocomotionAnimInst += new Del_Void_AnimInstance(OnCacheAdvancedMonsterLocomotionAnimInst);
		base.BUSEventCollection.Evt_CacheCloudLocomotionAnimInst += new Del_Void_AnimInstance(OnCacheCloudLocomotionAnimInst);
		base.BUSEventCollection.Evt_CacheSpecialMoveAnimInst += new Del_Void_AnimInstance(OnCacheSpecialMoveAnimInst);
		base.BUSEventCollection.Evt_NPCReplaceIdleAnim += new Del_Void_AnimSequence(OnNPCReplaceIdleAnim);
		base.BUSEventCollection.Evt_SetSplineMoveAnimConfig += new Del_SetSplineMoveAnimConfig(OnSetSplineMoveAnimConfig);
		base.BUSEventCollection.Evt_SetPlayerLocomotionInSequenceTransition += new Del_Bool(OnSetPlayerLocomotionInSequenceTransition);
		base.BUSEventCollection.Evt_HandleSlowIK += new Del_HandleSlowIK(HandleSlowIK);
		base.BUSEventCollection.Evt_SetFootIKManualUpdateMode += new Del_Void_Bool(SetFootIKManualUpdateMode);
		base.BUSEventCollection.Evt_ManualUpdateFootIKByZOffset += new Del_Void_Vector(ManualUpdateFootIKByZOffset);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_OnSetBattlePause = (Del_Void_Bool)Delegate.Combine(bGWEventCollection.Evt_OnSetBattlePause, new Del_Void_Bool(OnSetBattlePause));
		ABPHelperData.OnABPSettingPathChg += OnABPSettingPathChg;
		CppCharacterMovementComp = OwnerAsCharacterCS.CharacterMovement as UBGUCharacterMovementComponent;
		if (ProfileStats == null)
		{
			ProfileStats = new int[12];
			for (int i = 0; i < 12; i++)
			{
				ProfileStats[i] = ProfilerFuncLib.CreateStatID($"AnimThreadTick{i}");
			}
		}
	}

	public override void OnNetActive()
	{
		base.OnNetActive();
		if (!BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()))
		{
			base.BUSEventCollection.Evt_ChangeABPSetting -= new Del_ChangeABPSetting(OnChangeABPSetting);
			base.BUSEventCollection.Evt_ResetABPSetting -= new Del_Void(OnResetABPSetting);
		}
	}

	public void OnABPSettingPathChg(string OldValue, string NewValue)
	{
		BGW_PreloadAssetMgr.Get(this).TryRecyclingCachedResourceObj(OldValue);
		if (string.IsNullOrEmpty(NewValue))
		{
			OnResetABPSettingLocal();
			return;
		}
		BGWDataAsset_AbpHumanoidSetting aBPSetting = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_AbpHumanoidSetting>(NewValue, ELoadResourceType.SyncLoadAndCache);
		OnChangeABPSettingLocal(aBPSetting);
	}

	private void OnTick(float DeltaTime)
	{
		TickDebugInfo();
		FootIKData.GameThreadUpdate(Owner, DeltaTime);
		UpdateCanTickForAnimData(DeltaTime);
		bool flag = true;
		if ((!TickRateData.CanTickFor3000Distance()) ? TickRateData.CanTickFor500msInterval(out var AccumulatedDeltaTime, out var DifferenceTimeToLast100ms, out var DifferenceTimeToLast200ms, out var DifferenceTimeToLast500ms, out var DifferenceTimeToLast1000ms) : TickRateData.CanTickFor200msInterval(out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms, out AccumulatedDeltaTime))
		{
			TickMovingRotationRate();
			TickQuadrupedMove();
		}
	}

	private void TickDebugInfo()
	{
		if (DebugConfig.ABPHelperInfo)
		{
			float num = FMath.Sqrt(ActorFuncLib.CalculateMaxDistanceFactor(Owner.Address));
			string arg = "<Normal_Green>";
			if (num < ABPHelperData.ScreenSizeThresholdFar)
			{
				arg = "<Normal_Red>";
			}
			else if (num < ABPHelperData.ScreenSizeThresholdNear)
			{
				arg = "<Normal_Yellow>";
			}
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("ABPHelperInfo", $"ScreenSize：{arg}{ABPHelperData.ScreenSize}</>");
		}
	}

	private void UpdateCanTickForAnimData(float DeltaTime)
	{
		bool bCanTickForAnimData = true;
		bool flag = ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer;
		bool flag2 = BattleStateData.IsUnitInBattle();
		bool bIsPatroling = PatrolLogicData.bIsPatroling;
		bool bIsInLeisure = PatrolLogicData.bIsInLeisure;
		bool flag3 = BasicData.Speed > 10f;
		bool flag4 = TargetInfoData.GetAOTarget().LockTargetEntity != Entity.Null;
		bool num = !TickRateData.bEnableUROFromConfig || flag || flag2 || bIsPatroling || bIsInLeisure || flag3 || flag4;
		float AccumulatedDeltaTime = DeltaTime;
		float DifferenceTimeToLast1000ms;
		float DifferenceTimeToLast500ms;
		float DifferenceTimeToLast200ms;
		float DifferenceTimeToLast100ms;
		if (!num)
		{
			bCanTickForAnimData = (TickRateData.CanTickFor3000Distance() ? TickRateData.CanTickFor200msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms) : (TickRateData.CanTickFor6000Distance() && TickRateData.CanTickFor500msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms)));
		}
		else if (!TickRateData.CanTickFor6000Distance())
		{
			bCanTickForAnimData = TickRateData.CanTickFor100msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
		}
		ABPHelperData.bCanTickForAnimData = bCanTickForAnimData;
		ABPHelperData.AccumulatedDeltaTimeForAnimData = AccumulatedDeltaTime;
	}

	private void OnTickImpl(float DeltaTime, bool IsThreadTick)
	{
		if (ABPHelperData.ABPSettingData == null || !ABPHelperData.bABPDataInited)
		{
			return;
		}
		AActor owner = GetOwner();
		bool flag = ABPHelperData.bDataFirstUpdate || !TickRateData.bEnableUROFromConfig || GSGameplayCVar.CVar_AnimEnableABPHelperCompLODOptimize.GetValueInGameThread() == 0;
		bool bIsPatroling = PatrolLogicData.bIsPatroling;
		bool bIsInLeisure = PatrolLogicData.bIsInLeisure;
		bool num = ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer;
		bool flag2 = BattleStateData.IsUnitInBattle();
		bool flag3 = TargetInfoData.GetAOTarget().LockTargetEntity != Entity.Null;
		bool flag4 = num || flag2 || bIsPatroling || bIsInLeisure || flag3;
		bool flag5 = true;
		float num2 = 1f;
		if (!flag)
		{
			float DifferenceTimeToLast100ms;
			float DifferenceTimeToLast200ms;
			float DifferenceTimeToLast500ms;
			float DifferenceTimeToLast1000ms;
			if (!ControllerData.GetIsLocalControlled())
			{
				if (owner.WasRecentlyRendered())
				{
					if (TickRateData.CanTickFor200msInterval(out var _, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms))
					{
						ABPHelperData.ScreenSize = FMath.Sqrt(ActorFuncLib.CalculateMaxDistanceFactor(owner.Address));
					}
					num2 = ABPHelperData.ScreenSize;
				}
				else
				{
					num2 = 0f;
				}
			}
			if (!flag4)
			{
				flag5 = ((num2 < ABPHelperData.ScreenSizeThresholdFar) ? TickRateData.CanTickFor1000msInterval(out DeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms) : ((!(num2 < ABPHelperData.ScreenSizeThresholdNear)) ? TickRateData.CanTickFor100msInterval(out DeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms) : TickRateData.CanTickFor500msInterval(out DeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms)));
			}
			else if (num2 < ABPHelperData.ScreenSizeThresholdFar)
			{
				flag5 = TickRateData.CanTickFor200msInterval(out DeltaTime, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms);
			}
			else if (num2 < ABPHelperData.ScreenSizeThresholdNear)
			{
				flag5 = TickRateData.CanTickFor100msInterval(out DeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
			}
			if (!flag5)
			{
				return;
			}
		}
		ChrData.Update_GameThread(owner, ABPHelperData, DeltaTime);
		BGUData.Update_GameThread(owner, ChrData, SpeedCtrlData, DeltaTime);
		BasicData.Update_WorkThread(owner, ChrData, BGUData, SpeedCtrlData, DeltaTime);
		MMData.Update1(owner, ABPHelperData, BasicData, DeltaTime);
		CommonData.Update(owner, ABPHelperData, PatrolData, NPCAnimData, MMData, DeltaTime);
		MMData.Update2(owner, ABPHelperData, CommonData, BasicData, ChrData, DeltaTime);
		FootIKData.bCanGameThreadUpdateByOptimize = false;
		FootIKData.bCanThreadSafeUpdateAnimationByOptimize = false;
		if (flag || num2 > ABPHelperData.ScreenSizeThresholdFar || flag4)
		{
			FootIKData.bCanThreadSafeUpdateAnimationByOptimize = true;
			SpecialMoveData.Update(owner, ActorBasicData, ChrData);
			HumanoidJogData.Update(BasicData, ChrData, CommonData, ABPHelperData, DeltaTime);
			LocomotionData.Update1(BGUData, CommonData, ChrData, DeltaTime);
			LocomotionData.Update2(owner, CommonData, ChrData);
			PlayerLocomotionData.Update(owner, CommonData, BasicData, ChrData, BGUData, LocomotionData, SpecialMoveData, ABPHelperData, DeltaTime);
			AdvancedMonsterLocomotionData.Update(owner, CommonData, BasicData, ChrData, BGUData, LocomotionData, SpecialMoveData, ABPHelperData, DeltaTime);
			WheelMoveData.Update(owner, BasicData, ChrData, DeltaTime);
			GlideMoveData.Update(owner, ActorBasicData, SpecialMoveData, BasicData, ChrData, DeltaTime);
			ParkourMoveData.Update(owner, SpecialMoveData);
			SplineMoveData.Update(ActorBasicData, SpecialMoveData, ChrData, ABPHelperData, DeltaTime);
			MonsterLocomotionData.Update(owner, CommonData, ChrData, BGUData, LocomotionData, DeltaTime);
			QuadrupedLocomotionData.Update(owner, ChrData, BasicData, CommonData, LocomotionData, DeltaTime);
			FlyControlData.Update(owner, CommonData, ChrData, DeltaTime);
			BodyBlendData.Update(owner, BasicData, ChrData, CommonData, MonsterLocomotionData, ABPHelperData, DeltaTime);
			UpperBodyAimingData.Update(owner, ChrData, DeltaTime);
			CloudLocomotionData.Update(CommonData, ChrData, BasicData);
			if (SpineIKData != null)
			{
				UpdateSpineIKAlpha();
				UpdateLimbIKAlpha();
				SpineIKData.Update(owner, SpecialMoveData, DeltaTime);
				UpdateQuadrupedIKAlpha();
				AttackIKData.Update(owner, DeltaTime);
			}
			WeaponAimData.Update(owner, DeltaTime);
		}
		if (flag || num2 > ABPHelperData.ScreenSizeThresholdNear || !FootIKData.bIKOffsetValid)
		{
			FootIKData.bCanGameThreadUpdateByOptimize = true;
			FootIKData.Update(owner, ChrData, SpecialMoveData, DeltaTime);
		}
		if (flag || num2 > ABPHelperData.ScreenSizeThresholdNear)
		{
			JumpV2Data.Update(owner, ActorBasicData, ChrData, BasicData, SpecialMoveData, DeltaTime);
			HeadAimingData.Update(owner, ChrData, DeltaTime);
			MMFixedData.Update(owner, CommonData);
			AimOffsetData.Update(ChrData, DeltaTime);
			SpecialAdditiveData.Update(owner);
			if (SlowIKData != null)
			{
				SlowIKData.Update(owner, DeltaTime);
			}
		}
		ABPHelperData.bDataFirstUpdate = false;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return;
		}
		if (8 == TickGroup)
		{
			if (ABPHelperData.bCanTickForAnimData)
			{
				TickForAnimData();
				TickForWheelMove();
				CheckAndApplyCurveMoveRootMotionSource();
				CheckAndRemoveCurveMoveRootMotionSource();
			}
		}
		else if (1024 == TickGroup)
		{
			OnTick(DeltaTime);
			AttackIKFishSpikePostProcess();
		}
		if (GSGameplayCVar.CVar_AnimEnableThreadTick.GetValueInGameThread() == 1)
		{
			if (16 == TickGroup)
			{
				OnTickImpl(DeltaTime, IsThreadTick: true);
			}
		}
		else if (8 == TickGroup)
		{
			OnTickImpl(DeltaTime, IsThreadTick: false);
		}
	}

	private void TickForAnimData()
	{
		if (ABPHelperData.bCanTickForAnimData)
		{
			TickForAnimCurveValue();
			TickForStateMachineWeight();
			TickForBodySeparation();
			UpdateFootLock();
			TickForCurveMoving(ABPHelperData.AccumulatedDeltaTimeForAnimData);
		}
	}

	public override int GetTickGroupMask()
	{
		if (GSGameplayCVar.CVar_AnimEnableThreadTick.GetValueInGameThread() == 1)
		{
			return 1048;
		}
		return 1032;
	}

	public override void PreBeginPlay()
	{
		ABPHelperData.bDataFirstUpdate = true;
		ABPHelperData.bABPDataInited = false;
		ABPHelperData.bHasCurveMoveRMS = false;
		ABPHelperData.bShouldRemoveCurveMoveRMS = false;
		ABPHelperData.ScreenSizeThresholdFar = 0.05f;
		ABPHelperData.ScreenSizeThresholdNear = 0.1f;
		ABPHelperData.IntDefaultAnimTickOption = -1;
		ABPHelperData.CurveMovementVelocity = FVector.ZeroVector;
		InitCachedAnimInst();
		InitRootMotionSourceObject();
		(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityInitFinish();
		ABPHelperData.ABPSettingPath = ABPHelperData.ABPSettingData?.ABPSettingPath;
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(GetActorResID());
		if (unitCommDesc != null && unitCommDesc.UnitBodyType == EUnitBodyType.Small)
		{
			ABPHelperData.ScreenSizeThresholdFar = 0.04f;
			ABPHelperData.ScreenSizeThresholdNear = 0.08f;
		}
	}

	public override void OnBeginPlay()
	{
	}

	private void InitCachedAnimInst()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = aCharacter.Mesh;
		if (mesh == null)
		{
			return;
		}
		ABPHelperData.AnimInst = mesh.GetAnimInstance();
		if (!(ABPHelperData.AnimInst == null) && ABPHelperData.AnimInst is BUAnimHumanoidCS bUAnimHumanoidCS)
		{
			UAnimInstance linkedAnimGraphInstanceByTag = bUAnimHumanoidCS.GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.Move);
			if (!linkedAnimGraphInstanceByTag.IsNullOrDestroyed())
			{
				CachedMoveAnimInst.Set(linkedAnimGraphInstanceByTag);
				CachedPlayerLocomotionAnimInst.Set(linkedAnimGraphInstanceByTag.GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.PlayerLocomotion));
				CachedAdvancedMonsterLocomotionAnimInst.Set(linkedAnimGraphInstanceByTag.GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.AdvancedMonsterLocomotion));
				CachedCloudLocomotionAnimInst.Set(linkedAnimGraphInstanceByTag.GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.CloudLocomotion));
			}
			UAnimInstance linkedAnimGraphInstanceByTag2 = bUAnimHumanoidCS.GetLinkedAnimGraphInstanceByTag(B1GlobalFNames.SpecialMove);
			if (!linkedAnimGraphInstanceByTag2.IsNullOrDestroyed())
			{
				CachedSpecialMoveAnimInst.Set(linkedAnimGraphInstanceByTag2);
			}
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		BGW_PreloadAssetMgr.Get(this).TryRecyclingCachedResourceObj(ABPHelperData.ABPSettingPath);
		(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityEndPlay(EndPlayReason);
		ClearCachedAnimInst();
		base.BUSEventCollection.Evt_ChangeABPSetting -= new Del_ChangeABPSetting(OnChangeABPSetting);
		base.BUSEventCollection.Evt_ResetABPSetting -= new Del_Void(OnResetABPSetting);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_OnSetBattlePause = (Del_Void_Bool)Delegate.Remove(bGWEventCollection.Evt_OnSetBattlePause, new Del_Void_Bool(OnSetBattlePause));
		if (ABPHelperData.CurveMoveRMS != null)
		{
			ABPHelperData.CurveMoveRMS.MarkPendingKill();
			ABPHelperData.CurveMoveRMS = null;
		}
	}

	private void ClearCachedAnimInst()
	{
		ABPHelperData.AnimInst = null;
		CachedMoveAnimInst?.SetNull();
		CachedPlayerLocomotionAnimInst?.SetNull();
		CachedAdvancedMonsterLocomotionAnimInst?.SetNull();
		CachedCloudLocomotionAnimInst?.SetNull();
		CachedSpecialMoveAnimInst?.SetNull();
	}

	private void InitRootMotionSourceObject()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null))
		{
			ABPHelperData.CurveMoveRMS = UObject.NewObject<UBGURootMotionSourceObject_ConstantForce>(aCharacter);
			ABPHelperData.CurveMoveRMS.Init(CppCharacterMovementComp, CurveMoveRootMotionSourceInstanceName);
		}
	}

	private void InitAnimHumanoidData()
	{
		BUABPSettingData aBPSettingData = ABPHelperData.ABPSettingData;
		if (aBPSettingData != null)
		{
			bool isAI = AIData.IsAI;
			MMData.Init(Owner, aBPSettingData, UnitStateData, CameraData, ActorBasicData, MovementData, HardMoveData, TargetInfoData);
			CommonData.Init(aBPSettingData, PatrolLogicData, NPCAnimLogicData, MMData);
			PatrolData.Init(aBPSettingData, CommonData);
			NPCAnimData.Init(CommonData);
			BGUData.Init(Owner, UnitStateData, MovementData, SpeedCtrlData);
			BasicData.Init(Owner, CommonData, MovementData, UnitStateData, SimpleStateData, SpeedCtrlData);
			ChrData.Init(Owner);
			JumpV2Data.Init(aBPSettingData, ActorBasicData, MovementData, JumpData, UnitStateData);
			UpperBodyAimingData.Init(SceneItemData);
			HeadAimingData.Init(aBPSettingData);
			SpineIKData.Init(Owner, aBPSettingData);
			AttackIKData.Init();
			FootIKData.Init(Owner, aBPSettingData);
			BodyBlendData.Init(SimpleStateData);
			LocomotionData.Init();
			PlayerLocomotionData.Init(Owner, aBPSettingData, MovementData, isAI);
			AdvancedMonsterLocomotionData.Init(Owner, aBPSettingData, MovementData, isAI);
			FlyControlData.Init(SplineFlyMoveData);
			WheelMoveData.Init(aBPSettingData, SimpleStateData, SpeedCtrlData);
			GlideMoveData.Init(aBPSettingData, ActorBasicData, SurfaceCheckData, GlideMoveLogicData);
			ParkourMoveData.Init(ParkourMoveLogicData);
			AimOffsetData.Init(aBPSettingData);
			WeaponAimData.Init();
			SpecialMoveData.Init(UnitStateData, ManualSplineMoveData);
			MonsterLocomotionData.Init(MovementData, isAI);
			MMFixedData.Init(SimpleStateData);
			AMMatryoshkaData.Init();
			AttackOffsetData.Init();
			SlowIKData.Init();
			SplineMoveData.Init(ManualSplineMoveData, UnitStateData);
			CloudLocomotionData.Init(aBPSettingData, CloudMoveData);
			QuadrupedLocomotionData.Init(Owner, aBPSettingData, SimpleJumpData, isAI);
			SpecialAdditiveData.Init(aBPSettingData, SurfaceCheckData);
			ABPHelperData.bABPDataInited = true;
			TickMovingRotationRate();
		}
	}

	private void OnCachePlayerLocomotionAnimInst(UAnimInstance AnimInst)
	{
		if (!(CachedPlayerLocomotionAnimInst != null) || !CachedPlayerLocomotionAnimInst.IsValid())
		{
			CachedPlayerLocomotionAnimInst.Set(AnimInst);
		}
	}

	private void OnCacheAdvancedMonsterLocomotionAnimInst(UAnimInstance AnimInst)
	{
		if (!(CachedAdvancedMonsterLocomotionAnimInst != null) || !CachedAdvancedMonsterLocomotionAnimInst.IsValid())
		{
			CachedAdvancedMonsterLocomotionAnimInst.Set(AnimInst);
		}
	}

	private void OnCacheCloudLocomotionAnimInst(UAnimInstance AnimInst)
	{
		if (!(CachedCloudLocomotionAnimInst != null) || !CachedCloudLocomotionAnimInst.IsValid())
		{
			CachedCloudLocomotionAnimInst.Set(AnimInst);
		}
	}

	private void OnCacheSpecialMoveAnimInst(UAnimInstance AnimInst)
	{
		if (!(CachedSpecialMoveAnimInst != null) || !CachedSpecialMoveAnimInst.IsValid())
		{
			CachedSpecialMoveAnimInst.Set(AnimInst);
		}
	}

	private void OnNPCReplaceIdleAnim(UAnimSequence AnimSeq)
	{
		NPCAnimData.AnimIdleList = new List<UAnimSequence>();
		if (AnimSeq != null)
		{
			NPCAnimData.AnimIdleList.Add(AnimSeq);
		}
		CommonData.Update(Owner, ABPHelperData, PatrolData, NPCAnimData, MMData, 0f);
		ABPEventCollection.Evt_RefreshABP();
	}

	private void OnSetEnableAnimCurveBodyBlend(ECurveBodyBlendType BodyType, bool bEnable, UAnimSequenceBase Animation)
	{
		switch (BodyType)
		{
		case ECurveBodyBlendType.UpperBody:
			BodyBlendData.bEnableCurveBodyBlendUpperBody = bEnable;
			if (bEnable)
			{
				BodyBlendData.AnimCurveBodyBlendUpperBody = Animation;
			}
			break;
		case ECurveBodyBlendType.LeftArm:
			BodyBlendData.bEnableCurveBodyBlendLeftArm = bEnable;
			if (bEnable)
			{
				BodyBlendData.AnimCurveBodyBlendLeftArm = Animation;
			}
			break;
		case ECurveBodyBlendType.RightArm:
			BodyBlendData.bEnableCurveBodyBlendRightArm = bEnable;
			if (bEnable)
			{
				BodyBlendData.AnimCurveBodyBlendRightArm = Animation;
			}
			break;
		case ECurveBodyBlendType.LeftLeg:
			BodyBlendData.bEnableCurveBodyBlendLeftLeg = bEnable;
			if (bEnable)
			{
				BodyBlendData.AnimCurveBodyBlendLeftLeg = Animation;
			}
			break;
		case ECurveBodyBlendType.RightLeg:
			BodyBlendData.bEnableCurveBodyBlendRightLeg = bEnable;
			if (bEnable)
			{
				BodyBlendData.AnimCurveBodyBlendRightLeg = Animation;
			}
			break;
		}
	}

	private void OnChangeSkeletalMeshWithABP(USkeletalMesh NewMesh, TSubclassOf<UAnimInstance> NewABPClass)
	{
		if (!(NewMesh == null))
		{
			(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityEndPlay(EEndPlayReason.Destroyed);
			ClearCachedAnimInst();
			OwnerAsCharacterCS.Mesh.SetSkeletalMesh(NewMesh);
			OnChangeABP(NewABPClass);
		}
	}

	private void OnChangeAnimMode(EAnimationMode AnimMode, TSubclassOf<UAnimInstance> ABPClass)
	{
		(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityEndPlay(EEndPlayReason.Destroyed);
		ABPHelperData.AnimInst = null;
		OwnerAsCharacterCS.Mesh.SetAnimationMode(AnimMode);
		if (AnimMode == EAnimationMode.AnimationBlueprint)
		{
			OnChangeABP(ABPClass);
		}
	}

	private void OnChangeABP(TSubclassOf<UAnimInstance> NewABPClass)
	{
		if (!(NewABPClass == null))
		{
			CommonData.FinalABPMoveMode = EABPMoveMode.None;
			(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityEndPlay(EEndPlayReason.Destroyed);
			ClearCachedAnimInst();
			OwnerAsCharacterCS.Mesh.SetAnimClass(NewABPClass.Value);
			InitCachedAnimInst();
			(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityInitFinish();
			OnResetABPSetting();
		}
	}

	private void OnChangeABPSetting(BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		UAnimSequence animSeqIdle = ABPSetting.CommonSetting.AnimSeqIdle;
		if (!(animSeqIdle == null) && UGSE_AnimFuncLib.GetSkeleton(animSeqIdle) != OwnerAsCharacterCS.Mesh?.SkeletalMesh?.GetSkeleton())
		{
			BGW_LogUtil.LogError("[" + Owner.GetName() + "] Change ABPSetting(" + ABPSetting.GetName() + ") failed! Skeleton is not compatible!");
		}
		else if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()))
		{
			ABPHelperData.ABPSettingPath = ABPSetting.GetPathName();
		}
	}

	private void OnResetABPSetting()
	{
		if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()))
		{
			OnResetABPSettingLocal();
		}
	}

	private void OnChangeABPSettingLocal(BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		ABPHelperData.bABPDataInited = false;
		ABPEventCollection.Evt_ChangeABPSetting(ABPSetting);
		InitAnimHumanoidData();
		ABPEventCollection.Evt_InitABPSetting();
	}

	private void OnResetABPSettingLocal()
	{
		ABPEventCollection.Evt_ResetABPSetting();
	}

	private void OnChangeMotionMatchingState(EState_MM MMState)
	{
		BUABPSettingData aBPSettingData = ABPHelperData.ABPSettingData;
		if (aBPSettingData != null && aBPSettingData.CommonSetting.ABPMoveMode == EABPMoveMode.MotionMatching)
		{
			MMData.TargetMMState = MMState;
			MMData.CurUsingAnimSoftPath.Reset();
		}
	}

	private void OnMotionMatchingAnimUsingPreLoad(FSoftObjectPath Path, Action<int, UObject> CB)
	{
		BUABPSettingData aBPSettingData = ABPHelperData.ABPSettingData;
		if (aBPSettingData != null && aBPSettingData.CommonSetting.ABPMoveMode == EABPMoveMode.MotionMatching && !MMData.RequestAnimationAsycLoadMap.ContainsKey(Path))
		{
			MMData.RequestAnimationAsycLoadMap.Add(Path, CB);
		}
	}

	private void OnMotionMatchingAnimLoadFinished(FSoftObjectPath Path)
	{
		if (MMData.RequestAnimationAsycLoadMap != null && MMData.RequestAnimationAsycLoadMap.ContainsKey(Path))
		{
			MMData.RequestAnimationAsycLoadMap.Remove(Path);
		}
	}

	private void OnSetRecordMMAnimData(bool bEnable)
	{
		MMData.bRecordMMAnimData = bEnable;
	}

	private void OnSetForceMMToIdle(bool bEnable)
	{
		MMData.bForceMMToIdle = bEnable;
	}

	private void OnAimToBegin(FAimToConfig AimToConfig)
	{
		WeaponAimData.OnAimToBegin(Owner, AimToConfig);
	}

	private void OnAimToEnd()
	{
		WeaponAimData.OnAimToEnd();
	}

	private void OnSetDisableLocomotionIdle(bool bDisable)
	{
		MMData.bDisableLocomotionIdle = bDisable;
	}

	private void OnSetTouchIKActive(bool bActive, bool bUseFullBodyIK)
	{
		FootIKData.bActiveTouchIK = bActive;
		FootIKData.bRHandUseFBIK = bUseFullBodyIK;
		FootIKData.bLHandUseFBIK = bUseFullBodyIK;
	}

	private void OnSetTouchIKInfo(ETouchIKType Type, FVector IKOffset, FVector EffectorOffset, float Alpha)
	{
		FootIKData.SetTouchIKInfo(Type, IKOffset, EffectorOffset, Alpha);
	}

	private void OnSetTouchIKTargetActor(AActor TargetActor)
	{
		FootIKData.TouchIKTargetActor = TargetActor;
	}

	private void TriggerJumpAnim(bool bIsJumping, ESkillDirection StartJumpDir = ESkillDirection.None, EStartJumpSpdState StartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Zero, EJumpType JumpType = EJumpType.Normal)
	{
		if (!bIsJumping)
		{
			return;
		}
		JumpV2Data.StartJumpDir = StartJumpDir;
		JumpV2Data.JumpType = JumpType;
		if (JumpType == EJumpType.Normal)
		{
			switch (StartJumpDir)
			{
			case ESkillDirection.None:
				JumpV2Data.AnimGroundJumpStart = JumpV2Data.AnimJumpStart_N;
				JumpV2Data.AnimFallStart = JumpV2Data.AnimFallStart_N;
				break;
			case ESkillDirection.Forward:
				JumpV2Data.AnimGroundJumpStart = JumpV2Data.AnimJumpStart_F;
				JumpV2Data.AnimFallStart = JumpV2Data.AnimFallStart_F;
				break;
			case ESkillDirection.Backward:
				JumpV2Data.AnimGroundJumpStart = JumpV2Data.AnimJumpStart_B;
				JumpV2Data.AnimFallStart = JumpV2Data.AnimFallStart_B;
				break;
			case ESkillDirection.Left:
				JumpV2Data.AnimGroundJumpStart = JumpV2Data.AnimJumpStart_L;
				JumpV2Data.AnimFallStart = JumpV2Data.AnimFallStart_L;
				break;
			case ESkillDirection.Right:
				JumpV2Data.AnimGroundJumpStart = JumpV2Data.AnimJumpStart_R;
				JumpV2Data.AnimFallStart = JumpV2Data.AnimFallStart_R;
				break;
			default:
				JumpV2Data.AnimGroundJumpStart = JumpV2Data.AnimJumpStart_N;
				JumpV2Data.AnimFallStart = JumpV2Data.AnimFallStart_N;
				break;
			}
		}
		JumpV2Data.StartJumpSpdState = EStartJumpSpdState.StartJumpSpdState_Zero;
		if (JumpV2Data.StartJumpDir == ESkillDirection.Forward)
		{
			JumpV2Data.StartJumpSpdState = StartJumpSpdState;
		}
		if (JumpV2Data.StartJumpDir == ESkillDirection.Left)
		{
			JumpV2Data.AimOffsetForJumpEnableX = -1f;
		}
		else if (JumpV2Data.StartJumpDir == ESkillDirection.Right)
		{
			JumpV2Data.AimOffsetForJumpEnableX = 1f;
		}
		else
		{
			JumpV2Data.AimOffsetForJumpEnableX = 0f;
		}
	}

	private void OnSetStrideJumpHeight(float Height)
	{
		ParkourMoveData.StrideHeight = Height;
	}

	private void OnSetFallHeight(float FallHeight)
	{
		JumpV2Data.FallHeight = FallHeight;
		if (FallHeight <= JumpV2Data.TriggerLandHeight)
		{
			JumpV2Data.FallHeightType = EFallHeightType_V2.FallHeight_Little;
		}
		else if (FallHeight <= JumpV2Data.HeightDividingLine_Low)
		{
			JumpV2Data.FallHeightType = EFallHeightType_V2.FallHeight_Low;
		}
		else if (FallHeight <= JumpV2Data.HeightDividingLine_Mid)
		{
			JumpV2Data.FallHeightType = EFallHeightType_V2.FallHeight_Mid;
		}
		else
		{
			JumpV2Data.FallHeightType = EFallHeightType_V2.FallHeight_High;
		}
		if (UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			return;
		}
		BUABPJump_LandSettingData bUABPJump_LandSettingData = null;
		if (CloudLocomotionData.bCloudFall)
		{
			if (CloudLocomotionData.CloudBreakAnimId >= 0 && (CloudLocomotionData.CloudBreakAnimSettings.TryGetValue(CloudLocomotionData.CloudBreakAnimId, out var value) || CloudLocomotionData.CloudBreakAnimSettings.TryGetValue(0, out value)))
			{
				bUABPJump_LandSettingData = new BUABPJump_LandSettingData(CloudLocomotionData.bIsCloudFallInLowAirArea ? value.CloudBreakAnimSetting_Low.LandSetting : value.CloudBreakAnimSetting_High.LandSetting);
			}
			else
			{
				switch (JumpV2Data.FallHeightType)
				{
				case EFallHeightType_V2.FallHeight_Little:
				case EFallHeightType_V2.FallHeight_Low:
				case EFallHeightType_V2.FallHeight_Mid:
					bUABPJump_LandSettingData = CloudLocomotionData.CloudLand_Low;
					break;
				case EFallHeightType_V2.FallHeight_High:
					bUABPJump_LandSettingData = CloudLocomotionData.CloudLand_High;
					break;
				}
			}
		}
		else
		{
			switch (JumpV2Data.StartJumpDir)
			{
			default:
				switch (JumpV2Data.FallHeightType)
				{
				case EFallHeightType_V2.FallHeight_Low:
					bUABPJump_LandSettingData = JumpV2Data.Land_F_Low;
					break;
				case EFallHeightType_V2.FallHeight_Mid:
					bUABPJump_LandSettingData = JumpV2Data.Land_F_Mid;
					break;
				case EFallHeightType_V2.FallHeight_High:
					bUABPJump_LandSettingData = JumpV2Data.Land_F_High;
					break;
				}
				break;
			case ESkillDirection.Left:
				bUABPJump_LandSettingData = JumpV2Data.Land_L;
				break;
			case ESkillDirection.Right:
				bUABPJump_LandSettingData = JumpV2Data.Land_R;
				break;
			case ESkillDirection.Backward:
				bUABPJump_LandSettingData = JumpV2Data.Land_B;
				break;
			}
		}
		if (bUABPJump_LandSettingData != null)
		{
			JumpV2Data.WalkAnimLand_MoveTime = bUABPJump_LandSettingData.WalkAnimLand_MoveTime;
			JumpV2Data.AnimLand_MoveTime = bUABPJump_LandSettingData.AnimLand_MoveTime;
			JumpV2Data.AnimLand_JumpTime = bUABPJump_LandSettingData.AnimLand_JumpTime;
			JumpV2Data.AnimLand_AttackTime = bUABPJump_LandSettingData.AnimLand_AttackTime;
			JumpV2Data.AnimLand_DodgeTime = bUABPJump_LandSettingData.AnimLand_DodgeTime;
		}
	}

	private void OnEnterGlideMove()
	{
		JumpV2Data.LandAnimCantJumpTimer_Glide = 0.6f;
		GlideMoveData.OnEnterGlideMove(ChrData);
	}

	private void CheckLittleFall(float StartFallHeight)
	{
		if (StartFallHeight < 0f)
		{
			JumpV2Data.bIsLittleFall = false;
			return;
		}
		JumpV2Data.bIsLittleFall = StartFallHeight <= JumpV2Data.TriggerLandHeight;
		if (JumpV2Data.bIsLittleFall && BasicData.Speed >= BasicData.RunSpeed)
		{
			float value = ((OwnerAsCharacterCS.CharacterMovement != null) ? OwnerAsCharacterCS.CharacterMovement.GetGravityZ() : (-980f));
			float num = MathLib.Sqrt(JumpV2Data.TriggerLandHeight * 2f / FMath.Abs(value));
			float num2 = BasicData.Speed * num;
			float num3 = ((OwnerAsCharacterCS.CapsuleComponent != null) ? OwnerAsCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight() : 0f);
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			fVector += BGUFuncLibActorTransformCS.BGUGetActorForwardVector(Owner) * num2;
			fVector.Z -= num3;
			FVector end = fVector;
			end.Z -= JumpV2Data.TriggerLandHeight;
			if (!USystemLibrary.LineTraceSingleByProfile(Owner, fVector, end, B1GlobalFNames.Pawn, bTraceComplex: false, new List<AActor>(), EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Blue, 10f))
			{
				JumpV2Data.bIsLittleFall = false;
			}
			else if (OwnerAsCharacterCS.CharacterMovement != null && !OwnerAsCharacterCS.CharacterMovement.IsWalkable(OutHit))
			{
				JumpV2Data.bIsLittleFall = false;
			}
		}
	}

	private void OnSetEnableIK(bool bEnableIK, bool bEnableForefootIK)
	{
		FootIKData.bEnableIK = bEnableIK;
		FootIKData.bEnableForefootIK = bEnableForefootIK;
		BUC_ABPFootIKData footIKData = FootIKData;
		bool bCanGameThreadUpdateByOptimize = (FootIKData.bCanThreadSafeUpdateAnimationByOptimize = true);
		footIKData.bCanGameThreadUpdateByOptimize = bCanGameThreadUpdateByOptimize;
		FootIKData.Update(Owner, ChrData, SpecialMoveData, 0f);
		FootIKData.GameThreadUpdate(Owner, 0f);
		FootIKData.ThreadSafeUpdateAnimation(Owner, 0f);
	}

	private void OnSetEnableSpineIK(bool bEnableSpineIK)
	{
		SpineIKData.SetEnableSpineIK(bEnableSpineIK);
	}

	private void OnToggleSnapshotPose(bool bEnable, FPoseSnapshot PoseSnapshot, float BlendTime)
	{
		PoseSnapshotData.bUsePoseOverride = bEnable;
		if (bEnable)
		{
			PoseSnapshotData.PoseSnapshot = PoseSnapshot;
			PoseSnapshotData.EnableSnapshotBlendTime = BlendTime;
		}
		else
		{
			PoseSnapshotData.DisableSnapshotBlendTime = BlendTime;
		}
	}

	private void OnSetPlayerLocomotionLockMoveDirection(ELockMoveDirectionSix Direction)
	{
		PlayerLocomotionData.LastLockMoveDirection = PlayerLocomotionData.LockMoveDirection;
		PlayerLocomotionData.LockMoveDirection = Direction;
	}

	private void OnPlayerLocomotionStartIdle()
	{
		PlayerLocomotionData.RandomIdleIndex = FMath.RandRange(0, 3);
	}

	private void OnSetPlayerLocomotionLockTurnStopDirection(ELockMoveDirectionSix Direction)
	{
		PlayerLocomotionData.LockTurnStopDir = Direction;
		PlayerLocomotionData.EnterLockTurnStopState();
	}

	private void OnPlayerLocomotionEnterLockMoveState()
	{
		PlayerLocomotionData.EnterLockMoveState();
	}

	private void OnSetAimOffsetBlend(bool IsEnable, float BlendInTime, float BlendOutTime, float BlendTime)
	{
		AimOffsetData.IsUseThisAlpha = IsEnable;
		if (IsEnable)
		{
			AimOffsetData.IsBlendToOne = false;
			AimOffsetData.BlendSpd = ((BlendOutTime > 0f) ? (1f / BlendOutTime) : 1f);
			AimOffsetData.BlendInTime = BlendInTime;
			AimOffsetData.BlendOutTime = BlendOutTime;
			AimOffsetData.BlendTime = BlendTime;
		}
		else
		{
			AimOffsetData.AOAlpha = 1f;
		}
	}

	private void OnUnitSkillBreak(int SkillID, string Reason)
	{
		OnSetAimOffsetBlend(IsEnable: false, -1f, -1f, -1f);
	}

	private void SetUpperBodyAO(bool Enable, EBTTargetType TargetType, FVector InnerTargetPosition = default(FVector))
	{
		UpperBodyAimingData.Enable = TargetType != EBTTargetType.None && Enable;
		UpperBodyAimingData.TargetType = (Enable ? TargetType : EBTTargetType.None);
		UpperBodyAimingData.InnerTargetPosition = InnerTargetPosition;
		if (!UpperBodyAimingData.Enable)
		{
			UpperBodyAimingData.NeedReset = true;
		}
	}

	private void OnSetSpecialMovementMode(ESpecialMovementMode MovementMode)
	{
	}

	private void OnSetGlideMoveAnimState(EGlideMoveAnimState State)
	{
		GlideMoveData.GlideMoveAnimState = State;
	}

	private void OnSetParkourLandCanMove()
	{
		ParkourMoveData.bParkourLandCanMove = true;
	}

	private void OnSetAnimHumanoidAMMatryoshka(float Alpha)
	{
		AMMatryoshkaData.Alpha = Alpha;
	}

	private void OnSetMonsterLocomotionLockMoveDir(EMoveDirectionEight MoveDir)
	{
		MonsterLocomotionData.CurLockMoveDirection = MoveDir;
	}

	private void OnMonsterLocomotionLockStopLeft(UAnimInstance MonsterLocomotionInst)
	{
		if (!(MonsterLocomotionInst == null))
		{
			BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData stopLeftBlendAnim = ABPHelperData.ABPSettingData.MonsterLocomotionSetting.Lock.StopLeftBlendAnim;
			if (!(stopLeftBlendAnim.ASStopBlendAnim == null))
			{
				MonsterLocomotionInst.PlaySlotAnimationAsDynamicMontage(stopLeftBlendAnim.ASStopBlendAnim, MonsterLocomotionLockStopSlotName, stopLeftBlendAnim.BlendInTime, stopLeftBlendAnim.BlendOutTime, stopLeftBlendAnim.PlayRate, 1, -1f, stopLeftBlendAnim.StartPosition);
			}
		}
	}

	private void OnMonsterLocomotionLockStopRight(UAnimInstance MonsterLocomotionInst)
	{
		if (!(MonsterLocomotionInst == null))
		{
			BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData stopRightBlendAnim = ABPHelperData.ABPSettingData.MonsterLocomotionSetting.Lock.StopRightBlendAnim;
			if (!(stopRightBlendAnim.ASStopBlendAnim == null))
			{
				MonsterLocomotionInst.PlaySlotAnimationAsDynamicMontage(stopRightBlendAnim.ASStopBlendAnim, MonsterLocomotionLockStopSlotName, stopRightBlendAnim.BlendInTime, stopRightBlendAnim.BlendOutTime, stopRightBlendAnim.PlayRate, 1, -1f, stopRightBlendAnim.StartPosition);
			}
		}
	}

	private void OnMonsterLocomotionEnterMoveLoop(UAnimInstance MonsterLocomotionInst)
	{
		if (!(MonsterLocomotionInst == null))
		{
			BUABPMonsterLocomotion_Lock_StopBlendAnimSettingData stopLeftBlendAnim = ABPHelperData.ABPSettingData.MonsterLocomotionSetting.Lock.StopLeftBlendAnim;
			if (!(stopLeftBlendAnim.ASStopBlendAnim == null))
			{
				MonsterLocomotionInst.StopSlotAnimation(stopLeftBlendAnim.BlendOutTime, MonsterLocomotionLockStopSlotName);
			}
		}
	}

	private void OnSplineMoveEnterStopState()
	{
		SplineMoveData.SplineMoveStopTimer = 0f;
	}

	private void OnSetAttackIKTargetActor(AActor CharacterCS, bool enableAttackPlaneIK, EAttackIKType attackIKType, TArrayReadWrite<FAttackIKBonePairs> attackIKBonePairList)
	{
		AttackIKData.SetAttackIKTargetActor(CharacterCS, enableAttackPlaneIK, attackIKType, attackIKBonePairList);
	}

	private void OnSetAttackIKAlpha(float alpha)
	{
		AttackIKData.SetAttackIKAlpha(alpha);
	}

	private void OnSetAttackIKFishSpike(AActor CharacterCS, AActor TargetCharacterCS, bool enableAttackPlaneIK, float FishSpikeDistance, float JumpMax, FishSpikeJumpType JumpType, bool DebugEnable)
	{
		AttackIKData.SetAttackIKFishSpike(CharacterCS, TargetCharacterCS, enableAttackPlaneIK, FishSpikeDistance, JumpMax, JumpType, DebugEnable);
	}

	private void OnSetAttackIKFishSpikeAlpha(float alpha)
	{
		AttackIKData.SetAttackIKFishSpikeAlpha(alpha);
	}

	private void OnDisableTargetAttackIK(bool enable)
	{
		AttackIKData.DisableTargetAttackIK(enable);
	}

	private void OnSetAttackIKBoneScale(AActor Actor, bool InBoneScaleEnable, FAttackIKBoneScale InBoneScaleData)
	{
		AttackIKData.SetAttackIKBoneScale(Actor, InBoneScaleEnable, InBoneScaleData);
	}

	private void OnSetAttackIKBoneScaleAlpha(float alpha)
	{
		AttackIKData.SetAttackIKBoneScaleAlpha(alpha);
	}

	private void OnSetSplineMoveAnimConfig(BGWDataAsset_ManualSplineMoveAnimConfig MoveAnimConfig)
	{
		ABPEventCollection.Evt_SetSplineMoveAnimConfig(MoveAnimConfig);
	}

	private void OnSetPlayerLocomotionInSequenceTransition(bool bValue)
	{
		PlayerLocomotionData.SetInSequenceTransition(bValue, ChrData);
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (State == EMontageCallbackState.OnStarted)
		{
			BodyBlendData.bNewMontageStarted = true;
		}
	}

	private void TickForWheelMove()
	{
		if (WheelMoveData.MoveParamCurve == null)
		{
			return;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly))
		{
			if (WheelMoveData.CustomTimeDilationHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, WheelMoveData.MoveSpeedRate);
				WheelMoveData.CustomTimeDilationHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Actor_CustomTimeDilation, WheelMoveData.MoveSpeedRate, WheelMoveData.CustomTimeDilationHandleID);
			}
		}
		else if (WheelMoveData.CustomTimeDilationHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(WheelMoveData.CustomTimeDilationHandleID);
			WheelMoveData.CustomTimeDilationHandleID = 0u;
		}
	}

	private void TickQuadrupedMove()
	{
		if (UGSE_EngineFuncLib.IsStandAlone(GetOwner().World) || !(CppCharacterMovementComp != null))
		{
			return;
		}
		if (CommonData.FinalABPMoveMode == EABPMoveMode.QuadrupedLocomotion && !ABPHelperData.bReplicateRootMotionMove)
		{
			ABPHelperData.bReplicateRootMotionMove = true;
			CppCharacterMovementComp.ReplicateRootMotionMove = true;
			if (Owner.GetLocalRole() != ENetRole.ROLE_SimulatedProxy)
			{
				UGSE_AnimFuncLib.SetRootMotionFromEverythingSwitch(OwnerAsCharacterCS, IsOpen: true);
			}
		}
		if (CommonData.FinalABPMoveMode != EABPMoveMode.QuadrupedLocomotion && ABPHelperData.bReplicateRootMotionMove)
		{
			ABPHelperData.bReplicateRootMotionMove = false;
			CppCharacterMovementComp.ReplicateRootMotionMove = false;
			UGSE_AnimFuncLib.SetRootMotionFromEverythingSwitch(OwnerAsCharacterCS, IsOpen: false);
		}
	}

	private void TickMovingRotationRate()
	{
		if (ABPHelperData.ABPSettingData != null)
		{
			bool flag = false;
			EABPMoveMode finalABPMoveMode = CommonData.FinalABPMoveMode;
			if (finalABPMoveMode == EABPMoveMode.Locomotion_Simple4Dir || finalABPMoveMode == EABPMoveMode.SimpleFlyControl || finalABPMoveMode == EABPMoveMode.ComplexFlyControl)
			{
				flag = true;
			}
			if (flag && ABPHelperData.RotationRateHandleID != 0)
			{
				base.BUSEventCollection.Evt_ResetProperty.Invoke(ABPHelperData.RotationRateHandleID);
				ABPHelperData.RotationRateHandleID = 0u;
			}
			if (!flag && ABPHelperData.RotationRateHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetRotatorProperty.Invoke(EPropType.Movement_RotationRate, in FRotator.ZeroRotator);
				ABPHelperData.RotationRateHandleID = PropMgrData.GetLastHandleID();
			}
		}
	}

	private void TickForAnimCurveValue()
	{
		UAnimInstance animInst = ABPHelperData.AnimInst;
		if (animInst.IsNullOrDestroyed())
		{
			return;
		}
		if (SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.GroundMove)
		{
			switch (CommonData.FinalABPMoveMode)
			{
			case EABPMoveMode.PlayerLocomotion:
				CacheAnimFloatCurveValue(animInst, ref speed);
				CacheAnimFloatCurveValue(animInst, ref WalkRotationAlpha);
				CacheAnimFloatCurveValue(animInst, ref RunRotationAlpha);
				CacheAnimFloatCurveValue(animInst, ref RushRotationAlpha);
				CacheAnimFloatCurveValue(animInst, ref LoopLean);
				CacheAnimFloatCurveValue(animInst, ref ChangeAnimRate);
				break;
			case EABPMoveMode.AdvancedMonsterLocomotion:
				CacheAnimFloatCurveValue(animInst, ref RunRotationAlpha);
				CacheAnimFloatCurveValue(animInst, ref Distance);
				break;
			case EABPMoveMode.MotionMatching:
			case EABPMoveMode.MonsterLocomotion:
				CacheAnimFloatCurveValue(animInst, ref YawRotationSpeed);
				break;
			}
		}
		else if (SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.SplineMove)
		{
			CacheAnimFloatCurveValue(animInst, ref RunRotationAlpha);
		}
		if (BasicData.IsStandRotate)
		{
			CacheAnimFloatCurveValue(animInst, ref RunRotationAlpha);
		}
		if (FootIKData.bActiveFootIK)
		{
			CacheAnimFloatCurveValue(animInst, ref FootIKMaskValue);
		}
		if (BodyBlendData.bEnableCurveBodyBlendUpperBody)
		{
			CacheAnimFloatCurveValue(animInst, ref UpperBodyBlendWeight);
		}
		if (BodyBlendData.bEnableCurveBodyBlendLeftArm)
		{
			CacheAnimFloatCurveValue(animInst, ref LeftArmBlendWeight);
		}
		if (BodyBlendData.bEnableCurveBodyBlendRightArm)
		{
			CacheAnimFloatCurveValue(animInst, ref RightArmBlendWeight);
		}
		if (BodyBlendData.bEnableCurveBodyBlendLeftLeg)
		{
			CacheAnimFloatCurveValue(animInst, ref LeftLegBlendWeight);
		}
		if (BodyBlendData.bEnableCurveBodyBlendRightLeg)
		{
			CacheAnimFloatCurveValue(animInst, ref RightLegBlendWeight);
		}
		if (SpineIKData.bEnableSpineIK)
		{
			CacheAnimFloatCurveValue(animInst, ref Quadruped_IKFootRAlpha);
			CacheAnimFloatCurveValue(animInst, ref Quadruped_IKFootLAlpha);
			CacheAnimFloatCurveValue(animInst, ref Quadruped_IKHandRAlpha);
			CacheAnimFloatCurveValue(animInst, ref Quadruped_IKHandLAlpha);
			CacheAnimFloatCurveValue(animInst, ref Quadruped_SpineIKAlpha);
			CacheAnimFloatCurveValue(animInst, ref LimbIKAlpha);
			if (SpineIKData.EnableCustomLimbIK)
			{
				for (int i = 0; i < SpineIKData.LimbsCurveNames.Count; i++)
				{
					FName CurveName = SpineIKData.LimbsCurveNames[i];
					CacheAnimFloatCurveValue(animInst, ref CurveName);
				}
			}
		}
		if (ChrData.IsMontage)
		{
			CacheAnimFloatCurveValue(animInst, ref BodySplit_Leg);
			CacheAnimFloatCurveValue(animInst, ref BodySplit_Pelvis);
			CacheAnimFloatCurveValue(animInst, ref BodySplit_Spine);
			CacheAnimFloatCurveValue(animInst, ref BodySplit_Head);
			CacheAnimFloatCurveValue(animInst, ref BodySplit_ArmL);
			CacheAnimFloatCurveValue(animInst, ref BodySplit_ArmR);
			CacheAnimFloatCurveValue(animInst, ref BodySplit_ArmL_LS);
			CacheAnimFloatCurveValue(animInst, ref BodySplit_ArmR_LS);
		}
		if (FootIKData.bActiveFootIK)
		{
			CacheAnimFloatCurveValue(animInst, ref FootLock_L);
			CacheAnimFloatCurveValue(animInst, ref FootLock_R);
			CacheAnimFloatCurveValue(animInst, ref FootLockZ_L);
			CacheAnimFloatCurveValue(animInst, ref FootLockZ_R);
		}
		CacheAnimFloatCurveValue(animInst, ref PhysWeight);
		CacheAnimFloatCurveValue(animInst, ref AddMaxSpeed);
		CacheAnimFloatCurveValue(animInst, ref MaxAcceleration);
		CacheAnimFloatCurveValue(animInst, ref BrakingDecelerationWalking);
		CacheAnimFloatCurveValue(animInst, ref GroundFriction);
		CacheAnimFloatCurveValue(animInst, ref ForwardMovementSpeed);
		CacheAnimFloatCurveValue(animInst, ref RightMovementSpeed);
		CacheAnimFloatCurveValue(animInst, ref UpMovementSpeed);
		CacheAnimFloatCurveValue(animInst, ref DisableProceduralFootStep);
		CacheAnimFloatCurveValue(animInst, ref SkillCastTimeRange);
	}

	private void CacheAnimFloatCurveValue(UAnimInstance AnimInstance, ref FName CurveName)
	{
		if (AnimInstance.IsNullOrDestroyed())
		{
			return;
		}
		AnimFuncLib.GetCurveValueFromAnimInstance(AnimInstance.Address, ref CurveName, out var OutIsActive, out var OutValue);
		if (OutIsActive)
		{
			if (ABPHelperData.FloatCurveValues.ContainsKey(CurveName))
			{
				ABPHelperData.FloatCurveValues[CurveName] = OutValue;
			}
			else
			{
				ABPHelperData.FloatCurveValues.Add(CurveName, OutValue);
			}
		}
		else
		{
			ABPHelperData.FloatCurveValues.Remove(CurveName);
		}
	}

	private void TickForStateMachineWeight()
	{
		UAnimInstance uAnimInstance = ((CachedPlayerLocomotionAnimInst != null && CachedPlayerLocomotionAnimInst.IsValid()) ? CachedPlayerLocomotionAnimInst.Get() : null);
		if (uAnimInstance != null && CommonData.FinalABPMoveMode == EABPMoveMode.PlayerLocomotion)
		{
			CacheStateMachineWeight(uAnimInstance, ref MoveGrounded_FreeNew, ref WalkFree);
			CacheStateMachineWeight(uAnimInstance, ref MoveGrounded_FreeNew, ref RunFree);
			CacheStateMachineWeight(uAnimInstance, ref MoveGrounded_FreeNew, ref RushFree);
			CacheStateMachineWeight(uAnimInstance, ref MoveGrounded_FreeNew, ref StopFree);
			CacheStateMachineWeight(uAnimInstance, ref MoveGrounded_LockNew, ref LockMoveState);
			CacheStateMachineWeight(uAnimInstance, ref RunState, ref SharpTurn);
			CacheStateMachineWeight(uAnimInstance, ref RushState, ref RushLoop);
			CacheStateMachineWeight(uAnimInstance, ref RushState, ref SharpTurn);
			if (PlayerLocomotionData.bInLockMoveState)
			{
				CacheStateMachineWeight(uAnimInstance, ref LockGroundedLayerMain, ref Fwd);
				CacheStateMachineWeight(uAnimInstance, ref LockGroundedLayerMain, ref Bwd);
				CacheStateMachineWeight(uAnimInstance, ref LockGroundedLayerMain, ref Left_f);
				CacheStateMachineWeight(uAnimInstance, ref LockGroundedLayerMain, ref Left_b);
				CacheStateMachineWeight(uAnimInstance, ref LockGroundedLayerMain, ref Right_f);
				CacheStateMachineWeight(uAnimInstance, ref LockGroundedLayerMain, ref Right_b);
			}
		}
		UAnimInstance uAnimInstance2 = ((CachedAdvancedMonsterLocomotionAnimInst != null && CachedAdvancedMonsterLocomotionAnimInst.IsValid()) ? CachedAdvancedMonsterLocomotionAnimInst.Get() : null);
		if (uAnimInstance2 != null && CommonData.FinalABPMoveMode == EABPMoveMode.AdvancedMonsterLocomotion)
		{
			CacheStateMachineWeight(uAnimInstance2, ref MoveGrounded, ref Move);
		}
		UAnimInstance uAnimInstance3 = ((CachedSpecialMoveAnimInst != null && CachedSpecialMoveAnimInst.IsValid()) ? CachedSpecialMoveAnimInst.Get() : null);
		if (uAnimInstance3 != null && SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.SplineMove)
		{
			CacheStateMachineWeight(uAnimInstance3, ref SplineMoveBaseLayer, ref SharpTurn);
		}
		UAnimInstance uAnimInstance4 = ((CachedMoveAnimInst != null && CachedMoveAnimInst.IsValid()) ? CachedMoveAnimInst.Get() : null);
		if (uAnimInstance4 != null && BasicData.IsStandRotate)
		{
			CacheStateMachineWeight(uAnimInstance4, ref StandRotate, ref Rotate);
		}
	}

	private void CacheStateMachineWeight(UAnimInstance AnimInstance, ref FName StateMachineName, ref FName StateName)
	{
		if (AnimInstance.IsNullOrDestroyed())
		{
			return;
		}
		float value = AnimFuncLib.ABPStateMachineGetGlobalWeight(AnimInstance.Address, ref StateMachineName, ref StateName);
		if (ABPHelperData.StateMachineWeights.ContainsKey(StateMachineName))
		{
			if (ABPHelperData.StateMachineWeights[StateMachineName].ContainsKey(StateName))
			{
				ABPHelperData.StateMachineWeights[StateMachineName][StateName] = value;
			}
			else
			{
				ABPHelperData.StateMachineWeights[StateMachineName].Add(StateName, value);
			}
		}
		else
		{
			ABPHelperData.StateMachineWeights.Add(StateMachineName, new Dictionary<FName, float> { { StateName, value } });
		}
	}

	private void TickForBodySeparation()
	{
		UAnimInstance animInst = ABPHelperData.AnimInst;
		if (!animInst.IsNullOrDestroyed())
		{
			if (!BodyBlendData.bHasUpperBodySlotMontage)
			{
				BodyBlendData.bHasUpperBodySlotMontage = AnimFuncLib.CalcSlotMontageLocalWeight(animInst.Address, ref UpperBody) > 0f;
			}
			if (!BodyBlendData.bHasLeftArmSlotMontage)
			{
				BodyBlendData.bHasLeftArmSlotMontage = AnimFuncLib.CalcSlotMontageLocalWeight(animInst.Address, ref LeftArm) > 0f;
			}
			if (!BodyBlendData.bHasRightArmSlotMontage)
			{
				BodyBlendData.bHasRightArmSlotMontage = AnimFuncLib.CalcSlotMontageLocalWeight(animInst.Address, ref RightArm) > 0f;
			}
			_ = BodyBlendData.bHasFacialAnim;
		}
	}

	private void TickForCurveMoving(float DeltaTime)
	{
		ABPHelperData.bShouldRemoveCurveMoveRMS = true;
		ABPHelperData.CurveMovementVelocity = FVector.ZeroVector;
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) && (!UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.AttackMoving)) && !UnitStateData.HasState(EBGUUnitState.Beatback))
		{
			ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.AddMaxSpeed, out var OutCurveValue);
			base.BUSEventCollection.Evt_SetMoveSpeedAddValue.Invoke(OutCurveValue);
			UpdateMovementParameter();
			UpdateCurveMovement();
			UpdateMovingRotation(DeltaTime);
		}
	}

	private void UpdateCurveMovement()
	{
		if (GetOwner().GetLocalRole() != ENetRole.ROLE_SimulatedProxy && SpecialMoveData.SpecialMovementMode != ESpecialMovementMode.ParkourMove && !ChrData.IsFalling)
		{
			if (ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.ForwardMovementSpeed, out var OutCurveValue))
			{
				ABPHelperData.CurveMovementVelocity += ChrData.ForwardVector * OutCurveValue;
			}
			if (ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.RightMovementSpeed, out var OutCurveValue2))
			{
				ABPHelperData.CurveMovementVelocity += ChrData.RightVector * OutCurveValue2;
			}
			if (ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.UpMovementSpeed, out var OutCurveValue3))
			{
				ABPHelperData.CurveMovementVelocity += ChrData.UpVector * OutCurveValue3;
			}
		}
	}

	private void CheckAndApplyCurveMoveRootMotionSource()
	{
		if (ABPHelperData.CurveMoveRMS != null && ABPHelperData.CurveMovementVelocity.Size2D() > 0.01f)
		{
			ABPHelperData.CurveMoveRMS.ApplyRootMotionSource(ABPHelperData.CurveMovementVelocity.GetSafeNormal(), ABPHelperData.CurveMovementVelocity.Size(), -1f, bIsAdditive: true, null, ERootMotionFinishVelocityMode.MaintainLastRootMotionVelocity, FVector.ZeroVector, 0f, bEnableGravity: false);
			ABPHelperData.bHasCurveMoveRMS = true;
			ABPHelperData.bShouldRemoveCurveMoveRMS = false;
		}
	}

	private void CheckAndRemoveCurveMoveRootMotionSource()
	{
		if (ABPHelperData.bHasCurveMoveRMS && ABPHelperData.bShouldRemoveCurveMoveRMS)
		{
			ABPHelperData.CurveMoveRMS.RemoveRootMotionSource();
			ABPHelperData.bHasCurveMoveRMS = false;
			ABPHelperData.bShouldRemoveCurveMoveRMS = false;
		}
	}

	private void UpdateFootLock()
	{
		if (!FootIKData.bActiveFootIK)
		{
			return;
		}
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.FootLock_L, out var OutCurveValue);
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.FootLock_R, out var OutCurveValue2);
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.FootLockZ_L, out var OutCurveValue3);
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.FootLockZ_R, out var OutCurveValue4);
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null))
		{
			USkeletalMeshComponent mesh = aCharacter.Mesh;
			if (!(mesh == null))
			{
				FootIKData.SetLeftFootLockAlpha(mesh, OutCurveValue);
				FootIKData.SetRightFootLockAlpha(mesh, OutCurveValue2);
				FootIKData.LeftFootLockZAlpha = OutCurveValue3;
				FootIKData.RightFootLockZAlpha = OutCurveValue4;
			}
		}
	}

	private void UpdateMovementParameter()
	{
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		FVector fVector = FVector.ZeroVector;
		float num = 0f;
		switch (SpecialMoveData.SpecialMovementMode)
		{
		case ESpecialMovementMode.GlideMove:
		{
			UCurveVector moveParamCurve2 = GlideMoveData.MoveParamCurve;
			if (moveParamCurve2 != null)
			{
				float inTime3 = FMath.RadiansToDegrees(FMath.Acos(FVector.DotProduct(SurfaceCheckData.SurfaceNormal_Normalized, FVector.UpVector)));
				fVector = moveParamCurve2.GetVectorValue(inTime3);
				flag = fVector.X > 0f;
				flag2 = fVector.Y > 0f;
				flag3 = fVector.Z > 0f;
				float num2 = 0.5f;
				if (GlideMoveData.EnterGlideTimer < num2)
				{
					float alpha = FMath.Clamp(GlideMoveData.EnterGlideTimer / num2, 0f, 1f);
					fVector.Z = FMath.Lerp(GlideMoveData.EnterGlideGroundFriction, fVector.Z, alpha);
				}
			}
			break;
		}
		case ESpecialMovementMode.SplineMove:
			if (ManualSplineMoveData != null)
			{
				fVector.X = ManualSplineMoveData.SplineMoveMaxAcceleration;
				flag = fVector.X > 0f;
			}
			break;
		case ESpecialMovementMode.GroundMove:
		{
			float mappedSpeed = BasicData.GetMappedSpeed();
			UCurveVector uCurveVector = (PlayerLocomotionData.bSwitchToLock ? PlayerLocomotionData.LockMovementCurve : PlayerLocomotionData.FreeMovementCurve);
			if (uCurveVector != null && CommonData.FinalABPMoveMode == EABPMoveMode.PlayerLocomotion)
			{
				float inTime = 0f;
				switch (BasicData.MoveSpeedState)
				{
				case EMoveSpeedLevel.Walk:
					inTime = 1f;
					break;
				case EMoveSpeedLevel.Run:
					inTime = 2f;
					break;
				case EMoveSpeedLevel.Sprint:
					inTime = 3f;
					break;
				}
				fVector = uCurveVector.GetVectorValue(inTime);
				flag = fVector.X > 0f;
				flag2 = fVector.Y > 0f;
				flag3 = fVector.Z > 0f;
			}
			if (CommonData.FinalABPMoveMode == EABPMoveMode.AdvancedMonsterLocomotion)
			{
				fVector.X = AdvancedMonsterLocomotionData.MaxAcceleration;
				fVector.Y = AdvancedMonsterLocomotionData.BrakingDecelerationWalking;
				num = AdvancedMonsterLocomotionData.BrakingFriction;
				flag = fVector.X > 0f;
				flag2 = fVector.Y > 0f;
				flag3 = false;
				flag4 = num > 0f;
			}
			UCurveVector moveParamCurve = WheelMoveData.MoveParamCurve;
			if (moveParamCurve != null)
			{
				float inTime2 = (BGU_CommonUtil.IsInFsmState(GetOwner(), EBGUFSMStateName.FSM_STATE_NONCOMBAT) ? 1.2f : mappedSpeed);
				fVector = moveParamCurve.GetVectorValue(inTime2);
				flag = fVector.X > 0f;
				flag2 = fVector.Y > 0f;
				flag3 = fVector.Z > 0f;
			}
			break;
		}
		case ESpecialMovementMode.FlyMove:
			if (CommonData.FinalABPMoveMode == EABPMoveMode.CloudLocomotion)
			{
				fVector.X = CloudLocomotionData.MaxAcceleration;
				flag = fVector.X > 0f;
			}
			break;
		}
		if (ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.MaxAcceleration, out var OutCurveValue))
		{
			fVector.X = OutCurveValue;
			flag = true;
		}
		if (ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.BrakingDecelerationWalking, out var OutCurveValue2))
		{
			fVector.Y = OutCurveValue2;
			flag2 = true;
		}
		if (ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.GroundFriction, out var OutCurveValue3))
		{
			fVector.Z = OutCurveValue3;
			flag3 = true;
		}
		if (flag)
		{
			if (ABPHelperData.MaxAccelerationHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxAcceleration, fVector.X);
				ABPHelperData.MaxAccelerationHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_MaxAcceleration, fVector.X, ABPHelperData.MaxAccelerationHandleID);
			}
		}
		else if (ABPHelperData.MaxAccelerationHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(ABPHelperData.MaxAccelerationHandleID);
			ABPHelperData.MaxAccelerationHandleID = 0u;
		}
		if (flag2)
		{
			if (ABPHelperData.BrakingDecelerationWalkingHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_BrakingDecelerationWalking, fVector.Y);
				ABPHelperData.BrakingDecelerationWalkingHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_BrakingDecelerationWalking, fVector.Y, ABPHelperData.BrakingDecelerationWalkingHandleID);
			}
		}
		else if (ABPHelperData.BrakingDecelerationWalkingHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(ABPHelperData.BrakingDecelerationWalkingHandleID);
			ABPHelperData.BrakingDecelerationWalkingHandleID = 0u;
		}
		if (flag3)
		{
			if (ABPHelperData.GroundFrictionHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GroundFriction, fVector.Z);
				ABPHelperData.GroundFrictionHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_GroundFriction, fVector.Z, ABPHelperData.GroundFrictionHandleID);
			}
		}
		else if (ABPHelperData.GroundFrictionHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(ABPHelperData.GroundFrictionHandleID);
			ABPHelperData.GroundFrictionHandleID = 0u;
		}
		if (flag4)
		{
			if (ABPHelperData.BrakingFrictionHandleID == 0)
			{
				if (CppCharacterMovementComp != null)
				{
					CppCharacterMovementComp.SetUseSeparateBrakingFriction(bUse: true);
				}
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_BrakingFriction, num);
				ABPHelperData.BrakingFrictionHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetFloatProperty.Invoke(EPropType.Movement_BrakingFriction, num, ABPHelperData.BrakingFrictionHandleID);
			}
		}
		else if (ABPHelperData.BrakingFrictionHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(ABPHelperData.BrakingFrictionHandleID);
			ABPHelperData.BrakingFrictionHandleID = 0u;
			if (CppCharacterMovementComp != null)
			{
				CppCharacterMovementComp.SetUseSeparateBrakingFriction(bUse: false);
			}
		}
	}

	private void UpdateMovingRotation(float DeltaTime)
	{
		EBGUMoveMode moveType = MovementData.GetMoveType();
		if ((moveType == EBGUMoveMode.AIPathMove && MovementData.MoveAIType != EBGUMoveAIType.None) || moveType == EBGUMoveMode.AttackRotate || moveType == EBGUMoveMode.StandRotate)
		{
			return;
		}
		FVector velocity = ChrData.Velocity;
		FVector moveAcceleration = ChrData.MoveAcceleration;
		FRotator fRotator = ChrData.ActorRotation;
		FRotator fRotator2 = velocity.Rotation();
		fRotator2.Roll = 0f;
		fRotator2.Pitch = 0f;
		bool flag = false;
		if (SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.GroundMove)
		{
			switch (CommonData.FinalABPMoveMode)
			{
			case EABPMoveMode.PlayerLocomotion:
				if (!PlayerLocomotionData.bSwitchToLock)
				{
					switch ((PlayerLocomotionData.bShouldWaitRotateFinished && ChrData.MoveAcceleration.IsZero()) ? PlayerLocomotionData.LastMoveGaitGroundedState : PlayerLocomotionData.GaitGroundedState)
					{
					case EGaitGroundedState.Walk:
						fRotator = PlayerLocomotionData.GetRotationTarget(EMoveSpeedLevel.Walk, ChrData, ABPHelperData, DeltaTime);
						flag = true;
						break;
					case EGaitGroundedState.Run:
						fRotator = PlayerLocomotionData.GetRotationTarget(EMoveSpeedLevel.Run, ChrData, ABPHelperData, DeltaTime);
						flag = true;
						break;
					case EGaitGroundedState.Rush:
						fRotator = PlayerLocomotionData.GetRotationTarget(EMoveSpeedLevel.Sprint, ChrData, ABPHelperData, DeltaTime);
						flag = true;
						break;
					}
				}
				break;
			case EABPMoveMode.AdvancedMonsterLocomotion:
				if (!AdvancedMonsterLocomotionData.bSwitchToLock && AdvancedMonsterLocomotionData.GaitGroundedState != EGaitGroundedState.None && AdvancedMonsterLocomotionData.GaitGroundedState != EGaitGroundedState.Idle)
				{
					fRotator = AdvancedMonsterLocomotionData.GetRotationTarget(ChrData, ABPHelperData, DeltaTime);
					flag = true;
				}
				break;
			case EABPMoveMode.MonsterLocomotion:
				if (!MonsterLocomotionData.bSwitchToLock && moveAcceleration.Size() > 0.01f && MonsterLocomotionData.bIdleToMove)
				{
					if (BasicData.Speed < 60f)
					{
						fRotator2.Yaw = moveAcceleration.Rotation().Yaw;
					}
					ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.YawRotationSpeed, out var OutCurveValue2);
					OutCurveValue2 = FMath.Abs(OutCurveValue2);
					float interpSpeed = FMath.Max(90f, OutCurveValue2);
					fRotator = FMath.RInterpConstantTo(fRotator, fRotator2, DeltaTime, interpSpeed);
					flag = true;
				}
				break;
			case EABPMoveMode.MotionMatching:
				if (!MMData.IsInLockState() && MMData.CurrentAA != null && MMData.CurrentAA.IsUseLMAnim() && moveAcceleration.Size() > 0.01f)
				{
					if (BasicData.Speed < 60f)
					{
						fRotator2.Yaw = moveAcceleration.Rotation().Yaw;
					}
					ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.YawRotationSpeed, out var OutCurveValue);
					float num = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, 180.0), new FVector2D(360.0, 0.0), FMath.Abs(OutCurveValue));
					if (OutCurveValue < 0f)
					{
						num *= -1f;
					}
					FRotator normalized = (fRotator2 - fRotator).GetNormalized();
					fRotator = ((OutCurveValue != 0f && !(FMath.Abs(normalized.Yaw) <= 5f)) ? RInterpConstToAlongSpeedDirection(fRotator, fRotator2, DeltaTime, num + OutCurveValue) : FMath.RInterpConstantTo(fRotator, fRotator2, DeltaTime, num));
					flag = true;
				}
				break;
			}
		}
		else if (CommonData.FinalABPMoveMode == EABPMoveMode.CloudLocomotion && CloudLocomotionData.GaitGroundedState != EGaitGroundedState.None && CloudLocomotionData.GaitGroundedState != EGaitGroundedState.Idle)
		{
			fRotator = CloudLocomotionData.GetRotationTarget(ChrData, BasicData, DeltaTime);
			flag = true;
		}
		if (flag)
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(GetOwner(), fRotator, bTeleportPhysics: false);
		}
	}

	private FRotator RInterpConstToAlongSpeedDirection(FRotator current, FRotator target, float deltaTime, float interpSpeed)
	{
		if (deltaTime == 0f || current == target)
		{
			return current;
		}
		if (interpSpeed == 0f)
		{
			return target;
		}
		float num = interpSpeed * deltaTime;
		FRotator normalized = (target - current).GetNormalized();
		FRotator fRotator = current;
		if (normalized.Pitch * num < 0f)
		{
			if (normalized.Pitch > 0f)
			{
				normalized.Pitch = -360f + normalized.Pitch;
			}
			else
			{
				normalized.Pitch = 360f + normalized.Pitch;
			}
		}
		if (normalized.Yaw * num < 0f)
		{
			if (normalized.Yaw > 0f)
			{
				normalized.Yaw = -360f + normalized.Yaw;
			}
			else
			{
				normalized.Yaw = 360f + normalized.Yaw;
			}
		}
		if (normalized.Yaw * num < 0f)
		{
			if (normalized.Roll > 0f)
			{
				normalized.Roll = -360f + normalized.Roll;
			}
			else
			{
				normalized.Roll = 360f + normalized.Roll;
			}
		}
		fRotator.Pitch += ((interpSpeed > 0f) ? FMath.Clamp(normalized.Pitch, 0f, num) : FMath.Clamp(normalized.Pitch, num, 0f));
		fRotator.Yaw += ((interpSpeed > 0f) ? FMath.Clamp(normalized.Yaw, 0f, num) : FMath.Clamp(normalized.Yaw, num, 0f));
		fRotator.Roll += ((interpSpeed > 0f) ? FMath.Clamp(normalized.Roll, 0f, num) : FMath.Clamp(normalized.Roll, num, 0f));
		return fRotator.GetNormalized();
	}

	private void OnSetAttackOffset(EAttackOffsetType Type, FQuat AttackOffset_WorldRotOffset)
	{
		AttackOffsetData.AttackOffset_AttackOffsetType = Type;
		AttackOffsetData.AttackOffset_WorldRotOffset = AttackOffset_WorldRotOffset;
	}

	private void OnSetAttackOffsetAlpha(float Alpha)
	{
		AttackOffsetData.Alpha = Alpha;
	}

	private bool IsOwnerOnMovingPlatform()
	{
		if (GetOwner().GetComponentByClass<UBGUCharacterMovementComponent>() == null)
		{
			return false;
		}
		return GetOwner().GetComponentByClass<UBGUCharacterMovementComponent>().OnMovingPlatform;
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		UGSE_AnimFuncLib.StopAllMontages(Owner, 0f);
		UGSE_AnimFuncLib.TickAnimationAndRefreshBone(Owner);
		(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityEndPlay(EEndPlayReason.Destroyed);
		ClearCachedAnimInst();
		UGSE_AnimFuncLib.ReinitAnim(Owner);
		ABPHelperData.bDataFirstUpdate = true;
		ABPHelperData.bABPDataInited = false;
		InitCachedAnimInst();
		(ABPHelperData.AnimInst as b1.BGU.BUAnim.IBUEnityAnim)?.OnEntityInitFinish();
		InitAnimHumanoidData();
		ABPEventCollection.Evt_InitABPSetting();
	}

	private void OnChangeAimOffset(bool bIsDefaultAO, UAimOffsetBlendSpace AimOffset)
	{
		if (bIsDefaultAO)
		{
			AimOffsetData.DefaultAimOffset = AimOffset;
		}
		else
		{
			AimOffsetData.AttackAimOffset = AimOffset;
		}
	}

	private void OnResetAimOffset(bool bIsDefaultAO)
	{
		if (bIsDefaultAO)
		{
			AimOffsetData.DefaultAimOffset = ABPHelperData.ABPSettingData?.AimOffsetSetting.DefaultAimOffset;
		}
		else
		{
			AimOffsetData.AttackAimOffset = ABPHelperData.ABPSettingData?.AimOffsetSetting.AttackAimOffset;
		}
	}

	private void UpdateSpineIKAlpha()
	{
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.Quadruped_SpineIKAlpha, out var OutCurveValue);
		SpineIKData.IKSpineAlpha = 1f - FMath.Clamp(OutCurveValue, 0f, 1f);
	}

	private void UpdateQuadrupedIKAlpha()
	{
		float OutCurveValue = 0f;
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.Quadruped_IKFootRAlpha, out OutCurveValue);
		SpineIKData.IKFootRAlpha *= 1f - FMath.Clamp(OutCurveValue, 0f, 1f);
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.Quadruped_IKFootLAlpha, out OutCurveValue);
		SpineIKData.IKFootLAlpha *= 1f - FMath.Clamp(OutCurveValue, 0f, 1f);
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.Quadruped_IKHandRAlpha, out OutCurveValue);
		SpineIKData.IKHandRAlpha *= 1f - FMath.Clamp(OutCurveValue, 0f, 1f);
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.Quadruped_IKHandLAlpha, out OutCurveValue);
		SpineIKData.IKHandLAlpha *= 1f - FMath.Clamp(OutCurveValue, 0f, 1f);
	}

	private void UpdateLimbIKAlpha()
	{
		float OutCurveValue = 0f;
		ABPHelperData.GetFloatAnimCurveValue(in B1GlobalFNames.LimbIKAlpha, out OutCurveValue);
		SpineIKData.LimbIKAlpha = 1f - FMath.Clamp(OutCurveValue, 0f, 1f);
		if (SpineIKData.EnableCustomLimbIK)
		{
			for (int i = 0; i < SpineIKData.LimbIKDataList.Count; i++)
			{
				LimbIKData limbIKData = SpineIKData.LimbIKDataList[i];
				ABPHelperData.GetFloatAnimCurveValue(in limbIKData.LimbCurveName, out OutCurveValue);
				SpineIKData.LimbsCurveAlphas[i] = 1f - FMath.Clamp(OutCurveValue, 0f, 1f);
			}
		}
	}

	private void AttackIKFishSpikePostProcess()
	{
		if (AttackIKData.AttackIKType == EAttackIKType.FishSpike && AttackIKData.EnableAttackIK)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				AttackIKData.FishSpikeCancel = true;
			}
			if (!AttackIKData.FishSpikeCancel)
			{
				BGUFuncLibActorTransformCS.BGUSetActorLocation(Owner, AttackIKData.FishSpikeWorldLocation, bSweep: true, bTeleport: false, out var _);
			}
			if (AttackIKData.DebugFishSpikeEnable && !AttackIKData.FishSpikeCancel)
			{
				USceneComponent rootComponent = Owner.GetRootComponent();
				USystemLibrary.DrawDebugBox(rootComponent, AttackIKData.FishSpikeWorldLocation, new FVector(30.0, 30.0, 30.0), FLinearColor.Yellow, rootComponent.GetWorldRotation(), 0.3f, 5f);
			}
		}
	}

	private void HandleSlowIK(bool Enable, ESlowIKType SlowIKType = ESlowIKType.None, float SlowTime = 0f)
	{
		if (Enable)
		{
			SlowIKData.EnableSlowIK(Owner, SlowIKType, SlowTime);
		}
		else
		{
			SlowIKData.DisableSlowIK();
		}
	}

	private void SetFootIKManualUpdateMode(bool bEnable)
	{
		FootIKData.bFootIKManualUpdateMode = bEnable;
		SpineIKData.bSpineIKManualUpdateMode = bEnable;
	}

	private void ManualUpdateFootIKByZOffset(FVector Offset)
	{
		FootIKData.ManualUpdateFootIKByZOffset(OwnerAsCharacterCS, in Offset);
		SpineIKData.ManualUpdateSpineIKByZOffset(OwnerAsCharacterCS, in Offset);
	}

	private void OnNotifyBattleStateChange(bool NewBattleState)
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer)
		{
			if (ABPHelperData.IntDefaultAnimTickOption < 0)
			{
				ABPHelperData.IntDefaultAnimTickOption = (int)(OwnerAsCharacterCS.Mesh?.VisibilityBasedAnimTickOption).Value;
			}
			OwnerAsCharacterCS.Mesh.VisibilityBasedAnimTickOption = ((!NewBattleState) ? ((EVisibilityBasedAnimTickOption)ABPHelperData.IntDefaultAnimTickOption) : EVisibilityBasedAnimTickOption.AlwaysTickPoseAndRefreshBones);
		}
	}

	private void OnSetBattlePause(bool bPause)
	{
		if (bPause)
		{
			if (ABPHelperData.PauseAnimsHandleID == 0)
			{
				base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_PauseAnims, Value: true);
				ABPHelperData.PauseAnimsHandleID = PropMgrData.GetLastHandleID();
			}
			else
			{
				base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Mesh_PauseAnims, Value: true, ABPHelperData.PauseAnimsHandleID);
			}
		}
		else if (ABPHelperData.PauseAnimsHandleID != 0)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(ABPHelperData.PauseAnimsHandleID);
			ABPHelperData.PauseAnimsHandleID = 0u;
		}
	}
}
