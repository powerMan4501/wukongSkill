using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.DonAINavigation;
using b1.Prediction;
using BtlB1;
using BtlShare;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MovementSystem")]
public class BUS_MovementSystem : UActorCompBaseUObj
{
	private int LogLvl;

	internal UBUC_ACharacterComponent CharacterComps;

	internal BUC_ActionRequestData ActionRequestData;

	internal BUC_MovementData MovementData;

	protected BUC_MovementModes MoveModes;

	private BUC_AITransformModifyBySplineData AITransformModifyBySplineData;

	internal IBUC_TargetInfoData TargetInfoData;

	internal BUC_PlayerCameraData CameraData;

	protected IBUC_SimpleStateData SimpleStateData;

	internal IBUC_UnitStateData UnitStateData;

	internal BUC_AIData AIData;

	private IBUC_AINodeData AINodeData;

	internal IBUC_EnvironmentInteractionMgrData SurfaceCheckData;

	internal IBUC_GlideMoveData GlideMoveData;

	private IBUC_SplineFlyMoveData SplineFlyMoveData;

	private IBUC_ABPBodyBlendData BodyBlendData;

	internal IBUC_ABPCommonSettingData CommonData;

	internal IBUC_ABPHelperData AnimHumanoidHelperData;

	internal IBUC_ABPMotionMatchingData MMData;

	internal IBUC_ABPBasicData BasicData;

	internal IBUC_ABPCharacterData ChrData;

	internal IBUC_ABPPlayerLocomotionData PlayerLocomotionData;

	internal IBUC_ABPAdvancedMonsterLocomotionData AdvancedMonsterLocomotionData;

	internal IBUC_ABPSplineMoveData SplineMoveData;

	internal IBUC_ActorBasicData ActorBasicData;

	internal IBUC_PropMgrData PropMgrData;

	protected IBUC_TickRateData TickRateData;

	protected IBUC_BattleStateData BattleStateData;

	private IBGC_CircusControlData CircusControlData;

	protected IBUC_ControllerData ControllerData;

	private IBUC_PatrolData PatrolData;

	internal IBUC_AttrContainer AttrContainer;

	internal IBUC_ActorTransformInfoData ActorTransformInfoData;

	internal IBUC_ManualSplineMoveData ManualSplineMoveData;

	internal IBUC_ABPJumpV2Data JumpV2Data;

	internal IBUC_ParkourMoveData ParkourMoveData;

	internal IBUC_TurretControlData TurretControlData;

	internal IBUC_CloudMoveData CloudMoveData;

	internal IBUC_AnimationSyncHostData AnimationSyncData;

	private IBUC_GuidData GuidData;

	private IBUC_FsmData FsmData;

	public float NavWalkOpt_MassiveMode_NeedScore = 30f;

	public float NavWalkOpt_MassiveMode_Level0Score = 5f;

	public float NavWalkOpt_MassiveMode_Level1Score = 3f;

	public float NavWalkOpt_MassiveMode_Level2Score = 0.7f;

	private uint OrientRotationToMovementHandleID;

	private static bool PlayerCameraManager_IsValid;

	private static int PlayerCameraManager_Offset;

	private static bool CppCharacterMovementComp_IsValid;

	private static int CppCharacterMovementComp_Offset;

	private static bool CrowdFollowComp_IsValid;

	private static int CrowdFollowComp_Offset;

	private static bool OnAIPathMoveModeMoveComplete_IsValid;

	private static IntPtr OnAIPathMoveModeMoveComplete_FunctionAddress;

	private static int OnAIPathMoveModeMoveComplete_ParamsSize;

	private static bool OnAIPathMoveModeMoveComplete_MoveRequestID_IsValid;

	private static int OnAIPathMoveModeMoveComplete_MoveRequestID_Offset;

	private static bool OnAIPathMoveModeMoveComplete_Result_IsValid;

	private static int OnAIPathMoveModeMoveComplete_Result_Offset;

	private static FFieldAddress OnAIPathMoveModeMoveComplete_Result_PropertyAddress;

	private static bool AIFlyPathMoveMode_Pathfinding_OnFinish_IsValid;

	private static IntPtr AIFlyPathMoveMode_Pathfinding_OnFinish_FunctionAddress;

	private static int AIFlyPathMoveMode_Pathfinding_OnFinish_ParamsSize;

	private static bool AIFlyPathMoveMode_Pathfinding_OnFinish_Data_IsValid;

	private static int AIFlyPathMoveMode_Pathfinding_OnFinish_Data_Offset;

	private static FFieldAddress AIFlyPathMoveMode_Pathfinding_OnFinish_Data_PropertyAddress;

	private static bool AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_IsValid;

	private static IntPtr AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_FunctionAddress;

	private static int AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_ParamsSize;

	private static bool AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_IsValid;

	private static int AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_Offset;

	private static FFieldAddress AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_PropertyAddress;

	private IBUC_PointSetsData PointSetsData { get; set; }

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_MovementSystem:PlayerCameraManager")]
	public APlayerCameraManager PlayerCameraManager
	{
		get
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MovementSystem:PlayerCameraManager");
				return null;
			}
			return UObjectMarshaler<APlayerCameraManager>.FromNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerCameraManager_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MovementSystem:PlayerCameraManager");
			}
			else
			{
				UObjectMarshaler<APlayerCameraManager>.ToNative(IntPtr.Add(base.Address, PlayerCameraManager_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_MovementSystem:CppCharacterMovementComp")]
	private UBGUCharacterMovementComponent CppCharacterMovementComp
	{
		get
		{
			CheckDestroyed();
			if (!CppCharacterMovementComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MovementSystem:CppCharacterMovementComp");
				return null;
			}
			return UObjectMarshaler<UBGUCharacterMovementComponent>.FromNative(IntPtr.Add(base.Address, CppCharacterMovementComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CppCharacterMovementComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MovementSystem:CppCharacterMovementComp");
			}
			else
			{
				UObjectMarshaler<UBGUCharacterMovementComponent>.ToNative(IntPtr.Add(base.Address, CppCharacterMovementComp_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_MovementSystem:CrowdFollowComp")]
	private UBGUCrowdFollowingComponent CrowdFollowComp
	{
		get
		{
			CheckDestroyed();
			if (!CrowdFollowComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MovementSystem:CrowdFollowComp");
				return null;
			}
			return UObjectMarshaler<UBGUCrowdFollowingComponent>.FromNative(IntPtr.Add(base.Address, CrowdFollowComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CrowdFollowComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MovementSystem:CrowdFollowComp");
			}
			else
			{
				UObjectMarshaler<UBGUCrowdFollowingComponent>.ToNative(IntPtr.Add(base.Address, CrowdFollowComp_Offset), value);
			}
		}
	}

	public override void OnAttach()
	{
		CharacterComps = RequireWritableData<UBUC_ACharacterComponent>();
		MovementData = RequireWritableData<BUC_MovementData>();
		MoveModes = RequireWritableData<BUC_MovementModes>();
		ActionRequestData = RequireWritableData<BUC_ActionRequestData>();
		AIData = RequireWritableData<BUC_AIData>();
		PointSetsData = RequireReadOnlyData<IBUC_PointSetsData, BUC_PointSetsData>();
		AITransformModifyBySplineData = RequireWritableData<BUC_AITransformModifyBySplineData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		CameraData = RequireWritableData<BUC_PlayerCameraData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SurfaceCheckData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		GlideMoveData = RequireReadOnlyData<IBUC_GlideMoveData, b1.BUC_GlideMoveData>();
		SplineFlyMoveData = RequireReadOnlyData<IBUC_SplineFlyMoveData, b1.BUC_SplineFlyMoveData>();
		BodyBlendData = RequireReadOnlyData<IBUC_ABPBodyBlendData, BUC_ABPBodyBlendData>();
		CommonData = RequireReadOnlyData<IBUC_ABPCommonSettingData, BUC_ABPCommonSettingData>();
		AnimHumanoidHelperData = RequireReadOnlyData<IBUC_ABPHelperData, BUC_ABPHelperData>();
		MMData = RequireReadOnlyData<IBUC_ABPMotionMatchingData, BUC_ABPMotionMatchingData>();
		BasicData = RequireReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>();
		ChrData = RequireReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>();
		PlayerLocomotionData = RequireReadOnlyData<IBUC_ABPPlayerLocomotionData, BUC_ABPPlayerLocomotionData>();
		AdvancedMonsterLocomotionData = RequireReadOnlyData<IBUC_ABPAdvancedMonsterLocomotionData, BUC_ABPAdvancedMonsterLocomotionData>();
		SplineMoveData = RequireReadOnlyData<IBUC_ABPSplineMoveData, BUC_ABPSplineMoveData>();
		ActorBasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
		PropMgrData = RequireReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		ManualSplineMoveData = RequireReadOnlyData<IBUC_ManualSplineMoveData, BUC_ManualSplineMoveData>();
		JumpV2Data = RequireReadOnlyData<IBUC_ABPJumpV2Data, BUC_ABPJumpV2Data>();
		ParkourMoveData = RequireReadOnlyData<IBUC_ParkourMoveData, b1.BUC_ParkourMoveData>();
		CircusControlData = RequireReadOnlyGameStateData<IBGC_CircusControlData, BGC_CircusControlData>();
		TurretControlData = RequireReadOnlyData<IBUC_TurretControlData, BUC_TurretControlData>();
		ControllerData = RequireReadOnlyData<IBUC_ControllerData, BUC_ControllerData>();
		PatrolData = RequireReadOnlyData<IBUC_PatrolData, BUC_PatrolData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		ActorTransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		CloudMoveData = RequireReadOnlyData<IBUC_CloudMoveData, BUC_CloudMoveData>();
		AINodeData = RequireReadOnlyData<IBUC_AINodeData, BUC_AINodeData>();
		AnimationSyncData = RequireReadOnlyData<IBUC_AnimationSyncHostData, BUC_AnimationSyncHostData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		FsmData = RequireReadOnlyData<IBUC_FsmData, BUC_FsmData>();
		base.BUSEventCollection.Evt_InputMoveForward += new Del_InputMove(MoveForward);
		base.BUSEventCollection.Evt_InputMoveRight += new Del_InputMove(MoveRight);
		base.BUSEventCollection.Evt_InputMoveForwardFinish += new Del_Void(MoveForwardFinish);
		base.BUSEventCollection.Evt_InputMoveRightFinish += new Del_Void(MoveRightFinish);
		base.BUSEventCollection.Evt_AIMoveTo += new Del_AIMoveTo(OnAIMoveTo);
		base.BUSEventCollection.Evt_AttackRotateToPos += new Del_MovementRotateToPos(OnAttackRotateToPos);
		base.BUSEventCollection.Evt_ActorRotateToPos += new Del_MovementRotateToPos(OnActorRotateToPos);
		base.BUSEventCollection.Evt_ActorRotateToTarget += new Del_MovementRotateToTarget(OnActorRotateToTarget);
		base.BUSEventCollection.Evt_ForceSetAIMoveFacingTargetRotation += new Del_Void_InRotator(OnForceSetAIMoveFacingTargetRotation);
		base.BUSEventCollection.Evt_AIWallAndCellMoveTo += new Del_AIWallAndCellMoveTo(OnAIWallAndCellMoveTo);
		base.BUSEventCollection.Evt_TPSRotateToPos += new Del_MovementRotateToPos(OnTPSRotateToPos);
		base.BUSEventCollection.Evt_PlayerSkillDirFixed += new Del_Void_Float(PlayerSkillDirFixed);
		base.BUSEventCollection.Evt_SkillRotateTraceActor += new Del_SkillRotateTraceActor(OnSkillRotateTraceActor);
		base.BUSEventCollection.Evt_SkillRotateTraceLocation += new Del_SkillRotateTraceLocation(OnSkillRotateTraceLocation);
		base.BUSEventCollection.Evt_MontageRotateTraceActor += new Del_MontageRotateTraceActor(OnMontageRotateTraceActor);
		base.BUSEventCollection.Evt_MontageRotateAroundLocation += new Del_MontageRotateAroundLocation(OnMontageRotateAroundLocation);
		base.BUSEventCollection.Evt_FinishRotateMoveMode += new Del_Void(OnFinishRotateMoveMode);
		base.BUSEventCollection.Evt_SwitchToCamera4GMode += new Del_Void_Float(OnSwitchToCamera4GMode);
		base.BUSEventCollection.Evt_MoveWithAnimMontage += new Del_MoveWithAnimMontage(OnMoveWithAnimMontage);
		base.BUSEventCollection.Evt_MoveWithAnimMontageCMultiCast.Predict += new GSDel_MoveWithAnimMontage_IPK_Del.Del_Predict(OnMoveWithAnimMontage_Predict);
		base.BUSEventCollection.Evt_MoveWithAnimMontageCMultiCast.Cue += new GSDel_MoveWithAnimMontage_IPK_Del.Del_Predict(OnMoveWithAnimMontage);
		base.BUSEventCollection.Evt_MoveWithAnimMontage_BeAttackedClient += new Del_MoveWithAnimMontage(OnMoveWithAnimMontage);
		base.BUSEventCollection.Evt_CastSkillWithAnimMontage.Predict += new GSDel_CastSkillWithAnimMontage_IPK_Del.Del_Predict(OnSkillWithAnimMontage_Predict);
		base.BUSEventCollection.Evt_CastSkillWithAnimMontage.Cue += new GSDel_CastSkillWithAnimMontage_IPK_Del.Del_Predict(OnSkillWithAnimMontage);
		base.BUSEventCollection.Evt_SetOffsetRotationAxis += new Del_SetOffsetRotationAxis(OnSetOffsetRotationAxis);
		base.BUSEventCollection.Evt_SetOffsetRotationAxisComp += new Del_SetOffsetRotationAxisComp(OnSetOffsetRotationAxisComp);
		base.BUSEventCollection.Evt_AISideWalk += new Del_Void_FloatFloat(OnAISideWalk);
		base.BUSEventCollection.Evt_MovementSwitchWalkType += new Del_Void_Bool(OnSwitchWalkType);
		base.BUSEventCollection.Evt_MovementForceStop += new Del_Void(ForceStopCurrentMove);
		base.BUSEventCollection.Evt_MovementStopWithIdx += new Del_Void_Int(StopMoveWithRequestIdx);
		base.BUSEventCollection.Evt_StopCurrentMove += new Del_Void(StopCurrentMove);
		base.BUSEventCollection.Evt_SetAMSectionSpeedRate += new Del_Void_IntFloatFloat(OnSetAMSectionSpeedRate);
		base.BUSEventCollection.Evt_OnMontagePausePlaying += new Del_Bool(OnMontagePausePlaying);
		base.BUSEventCollection.Evt_SetAMScaleRateByPosMultiCast += new Del_SetAMScaleRateByPosMultCast(OnSetAMScaleRateByPosMultiCast);
		base.BUSEventCollection.Evt_SetAMScaleMaxRate += new Del_Void_Float(OnSetAMScaleMaxRate);
		base.BUSEventCollection.Evt_OnTeleport += new Del_OnTeleport(OnTeleport);
		base.BUSEventCollection.Evt_TeleportMove += new Del_TeleportMove(OnTeleportBeginEQS);
		base.BUSEventCollection.Evt_TeleportMoveByTrans += new Del_Void_Transform(OnTeleportMoveByTrans);
		base.BUSEventCollection.Evt_MatchingPositionMove += new Del_MatchingPositionMove(OnMatchingPositionMove);
		base.BUSEventCollection.Evt_SetMatchingPosInterpInfo += new Del_SetMatchingPosInterpInfo(OnSetMatchingPosInterpInfo);
		base.BUSEventCollection.Evt_InterpolationMove += new Del_InterpolationMove(OnInterpolationMove);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_InputRotforMM += new Del_Void_Rotator(OnSetTargetRotforMM);
		base.BUSEventCollection.Evt_SetSplineFlyControlInfo += new Del_SetSplineFlyControlInfo(OnSetSplineFlyControlInfo);
		base.BUSEventCollection.Evt_SetNpcGuideSplineMoveInfo += new Del_SetNpcGuideSplineMoveInfo(OnSetNpcGuideSplineMoveInfo);
		base.BUSEventCollection.Evt_AISpiderMoveTo += new Del_AISpiderMoveTo(OnAISpiderMoveTo);
		base.BUSEventCollection.Evt_SetCurveMoveInfo += new Del_SetCurveMoveInfo(OnSetCurveMoveInfo);
		base.BUSEventCollection.Evt_SetCurveMoveBeHitInfo += new Del_SetCurveMoveBeHitInfo(OnSetCurveMoveBeHitInfo);
		base.BUSEventCollection.Evt_SetCurveMoveScaleInfo += new Del_SetCurveMoveScaleInfo(OnSetCurveMoveScaleInfo);
		base.BUSEventCollection.Evt_BeginFloatingHit += new Del_BeginFloatingHit(OnBeginFloatingHit);
		base.BUSEventCollection.Evt_AdditionFloatingHit += new Del_AdditionFloatingHit(OnAdditionFloatingHit);
		base.BUSEventCollection.Evt_OnSetCurveMoveEnd += new Del_Void(OnSetCurveMoveEnded);
		base.BUSEventCollection.Evt_OnRotateWithCam += new Del_OnRotateWithCam(OnRotateWithCam);
		base.BUSEventCollection.Evt_OnRotateWithCamEnded += new Del_Void(OnRotateWithCamEnded);
		base.BUSEventCollection.Evt_OnPlayRotAMByCamRotBegin += new Del_OnPlayRotAMByCamRotBegind(OnPlayRotAM_ByCamRotBegin);
		base.BUSEventCollection.Evt_OnPlayRotAMByCamRotEnded += new Del_Void(OnPlayRotAM_ByCamRotEnded);
		base.BUSEventCollection.Evt_SetMovementInput += new Del_SetMovementInput(OnSetMovementInput);
		base.BUSEventCollection.Evt_SetMoveModeActive += new Del_SetMoveModeActive(OnSetMoveModeActive);
		base.BUSEventCollection.Evt_SwitchMoveAIType += new Del_SwitchMoveAIType(OnSwitchMoveAIType);
		base.BUSEventCollection.Evt_AIChangeCrowdParam += new Del_AIChangeCrowdParam(OnAIChangeCrowdParam);
		base.BUSEventCollection.Evt_AIResetCrowdParam += new Del_Void(OnAIResetCrowdParam);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallBack);
		base.BUSEventCollection.Evt_FallingStart += new Del_Void(OnFallingStart);
		base.BUSEventCollection.Evt_InputSwitchCloudMoveFreeLook += new Del_Void_Bool(InputSwitchCloudMoveFreeLook);
		base.BUSEventCollection.Evt_InputCloudMoveLift += new Del_Void_Bool(InputCloudMoveLift);
		base.BUSEventCollection.Evt_AITransformBySplineChange += new Del_AITransformBySplineChange(OnTransformBySplineChange);
		base.BUSEventCollection.Evt_AITransformBySplineStop += new Del_AITransformBySplineStop(OnTransformBySplineStop);
		base.BUSEventCollection.Evt_OnSceneItemMatchTransformBegin += new Del_OnSceneItemMatchTransformBegin(OnSceneItemMatchTransformBegin);
		base.BUSEventCollection.Evt_OnSceneItemMatchTransformEnd += new Del_OnSceneItemMatchTransformEnd(OnSceneItemMatchTransformEnd);
		base.BUSEventCollection.Evt_OnSceneItemAttackRotationBegin += new Del_OnSceneItemAttackRotationBegin(OnSceneItemAttackRotationBegin);
		base.BUSEventCollection.Evt_OnSceneItemAttackRotationEnd += new Del_OnSceneItemAttackRotationEnd(OnSceneItemAttackRotationEnd);
		CppCharacterMovementComp = CharacterComps.OwnerMovement;
		if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			base.BGSEventCollection.Evt_BGS_OnNavWalkOptLevelChange += new Del_Void_ActorInt(OnNavWalkOptLevelChange);
			return;
		}
		base.BGSEventCollection.Evt_BGS_OnNavWalkOptMassiveModeChange += new Del_Void_Bool(OnNavWalkOptMassiveModeChange);
		base.BUSEventCollection.Evt_OnNavWalkOptMassiveModeChange += new Del_Bool(OnNavWalkOptMassiveModeChange);
	}

	private void OnSceneItemAttackRotationBegin(AActor SceneItem, int AMID, int NotifyID)
	{
		if (MovementData != null)
		{
			MovementData.AttackRotation_SceneItem = SceneItem;
			MovementData.AttackRotation_SceneItemAMID = AMID;
			MovementData.AttackRotation_SceneItemNotifyID = NotifyID;
		}
	}

	private void OnSceneItemAttackRotationEnd(int AMID, int NotifyID, bool bForceMatch, float RotateDeflectionAngle)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (MovementData == null || bGUCharacterCS == null || MovementData.AttackRotation_SceneItemAMID != AMID || MovementData.AttackRotation_SceneItemNotifyID != NotifyID)
		{
			return;
		}
		AActor attackRotation_SceneItem = MovementData.AttackRotation_SceneItem;
		if (bForceMatch && attackRotation_SceneItem != null)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(attackRotation_SceneItem);
			BUC_SceneItemCommData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(attackRotation_SceneItem);
			if (readOnlyData != null)
			{
				fVector = readOnlyData.TeleportTransform.GetLocation();
			}
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
			FRotator targetRot = (fVector - fVector2).Rotation();
			targetRot.Yaw += RotateDeflectionAngle;
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_InterpolationMove.Invoke(fVector2, targetRot, 0f, EnableZAxisMove: false, IgnoreLocation: true, IgnoreLocationRotation: false, ForceUpdate: true);
		}
		MovementData.AttackRotation_SceneItem = null;
		MovementData.AttackRotation_SceneItemAMID = -1;
		MovementData.AttackRotation_SceneItemNotifyID = -1;
	}

	private void OnSceneItemMatchTransformBegin(AActor SceneItem, int AMID, int NotifyID)
	{
		if (MovementData != null)
		{
			MovementData.MatchTransform_SceneItem = SceneItem;
			MovementData.MatchTransform_SceneItemAMID = AMID;
			MovementData.MatchTransform_SceneItemNotifyID = NotifyID;
		}
	}

	private void OnSceneItemMatchTransformEnd(int AMID, int NotifyID, bool bForceMatch, bool bBowl)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (MovementData == null || bGUCharacterCS == null || MovementData.MatchTransform_SceneItemAMID != AMID || MovementData.MatchTransform_SceneItemNotifyID != NotifyID)
		{
			return;
		}
		AActor matchTransform_SceneItem = MovementData.MatchTransform_SceneItem;
		if (bForceMatch && matchTransform_SceneItem != null && BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(matchTransform_SceneItem) != null)
		{
			FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(matchTransform_SceneItem);
			FVector fVector = fTransform.GetLocation();
			if (bBowl)
			{
				UCapsuleComponent uCapsuleComponent = bGUCharacterCS.GetRootComponent() as UCapsuleComponent;
				if (uCapsuleComponent != null)
				{
					float scaledCapsuleHalfHeight = uCapsuleComponent.GetScaledCapsuleHalfHeight();
					float scaledCapsuleHalfHeight2 = uCapsuleComponent.GetScaledCapsuleHalfHeight();
					float num = 2.4f;
					FVector start = fVector + FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
					FVector end = fVector - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
					if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(this, start, end, scaledCapsuleHalfHeight2, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, bGUCharacterCS, out var OutHitLocation))
					{
						fVector = OutHitLocation + num + FVector.UpVector * scaledCapsuleHalfHeight;
					}
				}
			}
			FRotator targetRot = fTransform.GetRotation().Rotator();
			BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_InterpolationMove.Invoke(fVector, targetRot, 0f, EnableZAxisMove: false, IgnoreLocation: false, IgnoreLocationRotation: true, ForceUpdate: true);
		}
		MovementData.MatchTransform_SceneItem = null;
		MovementData.MatchTransform_SceneItemAMID = -1;
		MovementData.MatchTransform_SceneItemNotifyID = -1;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		MoveModes?.ReleaseMoveMode();
		if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			base.BGSEventCollection.Evt_BGS_OnNavWalkOptLevelChange -= new Del_Void_ActorInt(OnNavWalkOptLevelChange);
		}
		else
		{
			base.BGSEventCollection.Evt_BGS_OnNavWalkOptMassiveModeChange -= new Del_Void_Bool(OnNavWalkOptMassiveModeChange);
		}
	}

	public override void PreBeginPlay()
	{
		MovementData.TargetRot = default(FRotator);
		MoveModes.Parent = this;
		MovementData.bEnableWalk = true;
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(GetActorResID(), Owner);
		if (playerCommDesc != null)
		{
			MovementData.bEnableWalk = playerCommDesc.DisableWalk == EGSYesNo.No;
		}
	}

	public override void OnBeginPlay()
	{
		InitForCrowdComp();
		PlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(GetOwner());
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer)
		{
			if (CppCharacterMovementComp != null)
			{
				string finalGuid = GuidData.GetFinalGuid();
				bool flag = BGW_GameDB.IsBossGuid(finalGuid);
				if (flag)
				{
					CppCharacterMovementComp.SetDisableNavWalkOptByWhiteList(flag);
				}
				else
				{
					FUStMovementOptStrategyConfigDesc movementOptStrategyConfigDesc = BGW_GameDB.GetMovementOptStrategyConfigDesc(finalGuid);
					if (movementOptStrategyConfigDesc != null)
					{
						bool disableNavWalkOptByWhiteList = movementOptStrategyConfigDesc.Disable == EGSYesNo.Yes;
						CppCharacterMovementComp.SetDisableNavWalkOptByWhiteList(disableNavWalkOptByWhiteList);
					}
					else
					{
						CppCharacterMovementComp.SetDisableNavWalkOptByWhiteList(bDisable: false);
					}
				}
			}
			if (CharacterComps.OwnerCharacter != null && CharacterComps.OwnerCharacter.Mesh != null)
			{
				CharacterComps.OwnerCharacter.Mesh.DeferKinematicBoneUpdate = true;
			}
		}
		else if (CppCharacterMovementComp != null)
		{
			CppCharacterMovementComp.EnableSimplifiedMove = false;
		}
	}

	private void InitForCrowdComp()
	{
		AController instigatorController = GetOwner().GetInstigatorController();
		if (!(instigatorController != null))
		{
			return;
		}
		AIController aIController = instigatorController as AIController;
		if (!(aIController != null))
		{
			return;
		}
		UPathFollowingComponent pathFollowingComponent = aIController.GetPathFollowingComponent();
		if (pathFollowingComponent != null)
		{
			CrowdFollowComp = pathFollowingComponent as UBGUCrowdFollowingComponent;
			if (CrowdFollowComp != null)
			{
				FUStAICrowdDetourLevelConfigDesc unitAICrowdDetourlevelConfigDesc = BGW_GameDB.GetUnitAICrowdDetourlevelConfigDesc(AIData.DetourCrowdType);
				CrowdFollowComp.SetCrowdFollowingParam(unitAICrowdDetourlevelConfigDesc.SeparationWeight, unitAICrowdDetourlevelConfigDesc.CollisionQueryRange, unitAICrowdDetourlevelConfigDesc.PathOptimizationRange, (int)unitAICrowdDetourlevelConfigDesc.UnitAICrowdQualityLevel);
			}
		}
	}

	private void OnSwitchToCamera4GMode(float RotateSpeed)
	{
		MovementData.SetCameraG4RotateSpeed(RotateSpeed);
	}

	private void OnSetTargetRotforMM(FRotator TargetRot)
	{
		MovementData.TargetRot = TargetRot;
	}

	private EMovementMode GetMovementMode()
	{
		return CppCharacterMovementComp.MovementMode;
	}

	private void OnSetCurveMoveInfo(UCurveFloat MoveCurveXAxis, UCurveFloat MoveCurveZAxis, EBGUMoveCurveType MoveCurveType, FVector CurveMoveDirInfo, float CurveMoveTotalTime, bool bAutoResetMovementMode, bool EnableCurveMove = true, bool bShouldClearVelocityOnEnd = false)
	{
		MovementData.EnableCurveMove = EnableCurveMove;
		MovementData.MoveCurveXAxis = MoveCurveXAxis;
		MovementData.MoveCurveZAxis = MoveCurveZAxis;
		MovementData.MoveCurveType = MoveCurveType;
		MovementData.CurveMoveDirInfo = CurveMoveDirInfo;
		MovementData.bAutoResetMovementMode = bAutoResetMovementMode;
		MovementData.bShouldClearVelocityOnCurveMoveEnd = bShouldClearVelocityOnEnd;
		MovementData.CurveMoveTimer = 0f;
		MovementData.CurveMoveLastCalcTime = 0f;
	}

	private void OnSetCurveMoveEnded()
	{
		BGUCharacterCS bGUCharacterCS = CharacterComps.OwnerCharacter as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		MovementData.EnableCurveMove = false;
		FVector zeroVector = FVector.ZeroVector;
		foreach (FVector item in MovementData.CurveMoveQueue)
		{
			zeroVector += item;
		}
		bGUCharacterCS.LaunchCharacter(zeroVector / MovementData.CurveMoveQueue.Count, bXYOverride: true, bZOverride: true);
		if (MovementData.bShouldClearVelocityOnCurveMoveEnd)
		{
			CppCharacterMovementComp.StopMovementImmediately();
			CppCharacterMovementComp.ClearAccumulatedForces();
		}
		MovementData.CurveMoveQueue.Clear();
		if (MovementData.MoveCurveZAxis != null && MovementData.bAutoResetMovementMode)
		{
			base.BUSEventCollection.Evt_ResetProperty.Invoke(MovementData.CurveMovementModeHandleID);
			MovementData.CurveMovementModeHandleID = 0u;
		}
		OnSetCurveMoveBeHitInfo(UseBeHitDir: false, UseAttractionDir: false);
		OnSetCurveMoveScaleInfo(IsScaleToTarget: false, 0f, IsScaleToAttractionLocation: false);
		OnSetCurveMoveInfo(null, null, EBGUMoveCurveType.None, FVector.ZeroVector, 0f, bAutoResetMovementMode: true, EnableCurveMove: false);
	}

	private void OnSetCurveMoveBeHitInfo(bool UseBeHitDir, bool UseAttractionDir)
	{
		MovementData.CurveMoveUseBeHitDir = UseBeHitDir;
		MovementData.CurveMoveUseAttractionDir = UseAttractionDir;
	}

	private void OnSetCurveMoveScaleInfo(bool IsScaleToTarget, float ScaleOffset, bool IsScaleToAttractionLocation)
	{
		MovementData.CurveMoveIsScaleToTarget = IsScaleToTarget;
		MovementData.CurveMoveScaleOffset = ScaleOffset;
		MovementData.CurveMoveIsScaleToAttractionLocation = IsScaleToAttractionLocation;
		MovementData.CurveMoveScaleTimesToTarget = 1f;
	}

	private void OnBeginFloatingHit(float FloatingHeight, float RiseTime, float DeclineSpd)
	{
		MovementData.CurrentHeight = 0f;
		MovementData.FloatingHitTimer = 0f;
		MovementData.CurrentRiseSummHeight = 0f;
		MovementData.IsInRiseStage = true;
		MovementData.FloatingHitHeight = 500f;
		MovementData.FloatingHitRiseSpd = 2000f;
		MovementData.FloatingHitRiseTime = MovementData.FloatingHitHeight / MovementData.FloatingHitRiseSpd;
		MovementData.FloatingHitDeclineSpd = 2000f;
		MovementData.FloatingExtraHitTime = 0f;
		MovementData.FloatingExtraHitHeight = 0f;
		MovementData.FloatingExtraHitRiseSpd = 0f;
		MovementData.ExtraCurrentRiseSummHeight = 0f;
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.BeginFloatingHit, -1f);
		if (MovementData.FloatingMovementModeHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "OnBeginFloatingHit");
			MovementData.FloatingMovementModeHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, MovementData.FloatingMovementModeHandleID, 0u, bSetDefaultProperty: false, "OnBeginFloatingHit");
		}
	}

	private void OnEndFloatingHit()
	{
		MovementData.CurrentHeight = 0f;
		MovementData.FloatingHitTimer = 0f;
		MovementData.FloatingHitHeight = 0f;
		MovementData.FloatingHitRiseTime = 0f;
		MovementData.FloatingHitRiseSpd = 0f;
		MovementData.FloatingHitDeclineSpd = 0f;
		MovementData.FloatingExtraHitHeight = 0f;
		MovementData.FloatingExtraHitTime = 0f;
		MovementData.FloatingExtraHitRiseSpd = 0f;
		MovementData.ExtraCurrentRiseSummHeight = 0f;
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EndFloatingHit, -1f);
		base.BUSEventCollection.Evt_ResetProperty.Invoke(MovementData.FloatingMovementModeHandleID);
		MovementData.FloatingMovementModeHandleID = 0u;
	}

	private void OnAdditionFloatingHit(float AdditionHeight, float AdditionTime)
	{
		MovementData.FloatingExtraHitHeight = 100f;
		MovementData.FloatingExtraHitRiseSpd = 1000f;
		MovementData.FloatingExtraHitTime = MovementData.FloatingExtraHitHeight / MovementData.FloatingExtraHitRiseSpd;
		MovementData.IsInRiseStage = false;
		MovementData.FloatingHitTimer = 0f;
		MovementData.ExtraCurrentRiseSummHeight = 0f;
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool bStopMove = SimpleStateData.HasSimpleState(EBGUSimpleState.CantMove) || (JumpV2Data != null && JumpV2Data.bIsInLandCantMoveTime);
		bool bNeedPauseMoveModeUpdate = SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen);
		TickForMonster(DeltaTime, bStopMove, bNeedPauseMoveModeUpdate);
	}

	protected void TickForEnvironmentInteraction()
	{
		if (CppCharacterMovementComp != null)
		{
			MovementData.SetCanUseSurfaceTypeFromMovementComp(CppCharacterMovementComp.CanGetNormalAndSurfaceTypeInfoFromMovement());
			if (MovementData.CanUseSurfaceTypeFromMovementComp())
			{
				MovementData.CurFloorNormal = CppCharacterMovementComp.TryGetCurNormalFromMovement();
				MovementData.CurFloorHitPoint = CppCharacterMovementComp.TryGetCurHitPointFromMovement();
				MovementData.CurSurfaceType = (ESceneItemSurfaceType)CppCharacterMovementComp.TryGetCurSurfaceTypeFromMovement();
			}
		}
	}

	private void TickForMonsterNavWalkOptLevel()
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer && !CppCharacterMovementComp.IsNullOrDestroyed())
		{
			MovementData.NavWalkOptimizeDistanceLevel1 = CppCharacterMovementComp.FinalNavWalkOptDistanceLevel1;
			MovementData.NavWalkOptimizeDistanceLevel2 = CppCharacterMovementComp.FinalNavWalkOptDistanceLevel2;
			float distanceToPlayer = TickRateData.GetDistanceToPlayer();
			int num = 0;
			num = ((!(distanceToPlayer <= MovementData.NavWalkOptimizeDistanceLevel1)) ? ((distanceToPlayer <= MovementData.NavWalkOptimizeDistanceLevel2) ? 1 : 2) : 0);
			if (CppCharacterMovementComp.MovementMode == EMovementMode.MOVE_Walking)
			{
				num = 0;
			}
			MovementData.NavWalkOptLevel = num;
			if (num != CppCharacterMovementComp.NavWalkOptLevel)
			{
				CppCharacterMovementComp.SetNavWalkOptLevel(num);
				base.BGSEventCollection.Evt_BGS_OnNavWalkOptLevelChange.Invoke(Owner, num);
			}
		}
	}

	private void OnNavWalkOptMassiveModeChange(bool bOpen)
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer && !this.IsNullOrDestroyed() && !CppCharacterMovementComp.IsNullOrDestroyed())
		{
			CppCharacterMovementComp.SetNavWalkOptMassiveMode(bOpen);
		}
	}

	private void OnNavWalkOptLevelChange(AActor Actor, int OptLevel)
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (this.IsNullOrDestroyed() || !(bGUCharacterCS != null) || MovementData == null)
		{
			return;
		}
		if (MovementData.CharNavWalkOptLevelMap == null)
		{
			MovementData.CharNavWalkOptLevelMap = new Dictionary<TWeakObject<BGUCharacterCS>, int>();
		}
		if (USystemLibrary.IsValid(bGUCharacterCS))
		{
			TWeakObject<BGUCharacterCS> key = new TWeakObject<BGUCharacterCS>(bGUCharacterCS);
			if (MovementData.CharNavWalkOptLevelMap.ContainsKey(key))
			{
				MovementData.CharNavWalkOptLevelMap[key] = OptLevel;
				return;
			}
			MovementData.CharNavWalkOptLevelMap.Add(key, OptLevel);
			BUS_EventCollectionCS.Get(key.Get())?.Evt_OnNavWalkOptMassiveModeChange.Invoke(MovementData.NavWalkOpt_MassiveModeON);
		}
	}

	private void TickForMonster(float DeltaTime, bool bStopMove, bool bNeedPauseMoveModeUpdate)
	{
		bool flag = BattleStateData.IsUnitInBattle();
		bool flag2 = PatrolData != null && PatrolData.bIsPatroling && PatrolData.PatrolType != EPatrolType.Leisure;
		float AccumulatedDeltaTime;
		float DifferenceTimeToLast100ms;
		float DifferenceTimeToLast200ms;
		float DifferenceTimeToLast500ms;
		float DifferenceTimeToLast1000ms;
		bool flag3 = TickRateData.CanTickFor100msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
		float AccumulatedDeltaTime2;
		bool flag4 = TickRateData.CanTickFor200msInterval(out AccumulatedDeltaTime2, out DifferenceTimeToLast1000ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast100ms);
		float AccumulatedDeltaTime3;
		bool flag5 = TickRateData.CanTickFor500msInterval(out AccumulatedDeltaTime3, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms);
		bool flag6 = TickRateData.CanTickFor1000Distance();
		TickForEnvironmentInteraction();
		TickForMonsterNavWalkOptLevel();
		if (TickRateData.bEnableUROFromConfig)
		{
			if (FsmData != null && FsmData.IsInFsmState(EBGUFSMStateName.FSM_STATE_REVOLVEAROUND))
			{
				flag = true;
				flag3 = true;
				flag4 = true;
				flag5 = true;
				AccumulatedDeltaTime = DeltaTime;
				AccumulatedDeltaTime2 = DeltaTime;
				AccumulatedDeltaTime3 = DeltaTime;
			}
		}
		else
		{
			flag = true;
			flag3 = true;
			flag4 = true;
			flag5 = true;
			AccumulatedDeltaTime = DeltaTime;
			AccumulatedDeltaTime2 = DeltaTime;
			AccumulatedDeltaTime3 = DeltaTime;
		}
		if (flag && flag5)
		{
			TickOnLandEvent();
		}
		if (bStopMove)
		{
			MoveStop();
			return;
		}
		if (flag4)
		{
			TickMoveMode();
		}
		bool flag7 = true;
		float deltaTime = DeltaTime;
		if (!flag)
		{
			flag7 = flag4;
			deltaTime = AccumulatedDeltaTime2;
			if (flag6)
			{
				flag7 = flag3;
				deltaTime = AccumulatedDeltaTime;
			}
		}
		if (flag7)
		{
			if (!bNeedPauseMoveModeUpdate)
			{
				TickForInterpolationMove(deltaTime);
			}
			TickSplineFlyDistance(deltaTime);
			TickTransformModifyBySpline(deltaTime);
			TickForAMCurveMove(deltaTime);
		}
		TickForRecoverAMScaleRate(DeltaTime);
		TickForRecoverAMSpeedRate(DeltaTime);
		if (flag)
		{
			flag7 = flag3;
			deltaTime = AccumulatedDeltaTime;
			if (flag6)
			{
				flag7 = true;
				deltaTime = DeltaTime;
			}
			if (flag7)
			{
				TickForBlendAnimRootMotion();
			}
			flag7 = flag5;
			deltaTime = AccumulatedDeltaTime3;
			if (flag6)
			{
				flag7 = flag4;
				deltaTime = AccumulatedDeltaTime2;
			}
			if (flag7)
			{
				TickForAlignCapsuleToSurface(deltaTime);
			}
		}
		if (MoveModes.ActiveMover == null)
		{
			return;
		}
		flag7 = true;
		deltaTime = DeltaTime;
		if (!flag)
		{
			flag7 = flag4;
			deltaTime = AccumulatedDeltaTime2;
			if (flag2 && flag6)
			{
				flag7 = flag3;
				deltaTime = AccumulatedDeltaTime;
			}
		}
		if (flag7 && !bNeedPauseMoveModeUpdate)
		{
			MoveModes.ActiveMover.DoUpdate(deltaTime);
		}
	}

	protected void TickForBlendAnimRootMotion()
	{
		if (MovementData.MontageInstanceIDWithBodySeparation != -1 && !AnimFuncLib.IsMontageInstancePlaying(Owner.Address, MovementData.MontageInstanceIDWithBodySeparation))
		{
			MovementData.MontageInstanceIDWithBodySeparation = -1;
		}
		else if ((BodyBlendData == null || BodyBlendData.bEnableAnimCurveBodySeparation) && ChrData != null && ChrData.IsMontageRealTime && !ChrData.MoveAcceleration.IsNearlyZero() && CheckCanRun())
		{
			OnMoveWithAnimBodySeparation();
		}
	}

	private void OnFallingStart()
	{
		MovementData.bWalkOnLand = false;
	}

	private void InputSwitchCloudMoveFreeLook(bool IsEnabled)
	{
		MovementData.IsCloudFreeLookEnabled = IsEnabled;
		if (IsEnabled)
		{
			ACharacter aCharacter = Owner as ACharacter;
			MovementData.CloudFreeLookMoveRotation = aCharacter.GetControlRotation();
		}
	}

	private void InputCloudMoveLift(bool IsEnabled)
	{
		MovementData.IsCloudMoveLift = IsEnabled;
	}

	protected void TickOnLandEvent()
	{
		FFindFloorResult currentFloor = CppCharacterMovementComp.CurrentFloor;
		bool jumpOff = CppCharacterMovementComp.JumpOff;
		MovementData.bWalkOnDitch = CppCharacterMovementComp.IsWalkOnDitch();
		if (MovementData.bWalkOnLand)
		{
			if (!currentFloor.BlockingHit)
			{
				MovementData.bWalkOnLand = false;
			}
		}
		else if (currentFloor.BlockingHit)
		{
			MovementData.bWalkOnLand = true;
			base.BUSEventCollection?.Evt_OnLanded.Invoke();
		}
		else if (MovementData.bWalkOnDitch)
		{
			base.BUSEventCollection?.Evt_OnLanded.Invoke();
		}
		else if (jumpOff)
		{
			base.BUSEventCollection?.Evt_OnJumpOff.Invoke();
		}
	}

	protected void TickForAlignCapsuleToSurface(float DeltaTime)
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreAlignCapsule2Surface) && !SimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.InInteractAnimationSyncing))
		{
			FRotator Current = (CharacterComps.OwnerShapeComponent as UCapsuleComponent).GetWorldRotation();
			if (UnitStateData.HasState(EBGUUnitState.AttackAlignWholeBodyToSlope) && SurfaceCheckData.bNearGround)
			{
				FRotator Target = SurfaceCheckData.ChrRotAlignSurface;
				Target.Roll = 0f;
				Target = MathLib.RInterpTo(in Current, in Target, DeltaTime, 5f);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Owner, Target, bTeleportPhysics: false);
			}
			else if (Current.Pitch != 0f)
			{
				FRotator Target2 = Current;
				Target2.Pitch = 0f;
				Target2.Roll = 0f;
				Target2 = MathLib.RInterpTo(in Current, in Target2, DeltaTime, 5f);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Owner, Target2, bTeleportPhysics: false);
			}
		}
	}

	protected void TickForRecoverAMSpeedRate(float DeltaTime)
	{
		if (!(Owner as ACharacter == null) && !(MovementData.AMCaleSpeedRateTime <= 0f) && MovementData.AMCaleSpeedRateTime > 0f)
		{
			MovementData.AMCaleSpeedRateTime -= DeltaTime;
			if (MovementData.AMCaleSpeedRateTime <= 0f && MathLib.Abs(MovementData.AMSpeedRate - 1f) > 1E-05f)
			{
				MovementData.AMSpeedRate = 1f;
				MovementData.AMSpeedRateNotifyStateID = -1;
				UGSE_CharacterFuncLib.SetMontagePlayRate(CharacterComps.OwnerCharacter, 1f);
			}
		}
	}

	protected void TickForRecoverAMScaleRate(float DeltaTime)
	{
		if (Owner as ACharacter == null || (MovementData.AMMoveScaleXTime <= 0f && MovementData.AMMoveScaleYTime <= 0f && MovementData.AMMoveScaleZTime <= 0f))
		{
			return;
		}
		bool flag = false;
		if (MovementData.AMMoveScaleXTime > 0f)
		{
			MovementData.AMMoveScaleXTime -= DeltaTime;
			if (MovementData.AMMoveScaleXTime <= 0f)
			{
				MovementData.IsAMMoveScaleX = false;
				MovementData.AMScaleVec.X = 1f;
				MovementData.AMMoveScaleXTime = 0f;
				flag = true;
			}
		}
		if (MovementData.AMMoveScaleYTime > 0f)
		{
			MovementData.AMMoveScaleYTime -= DeltaTime;
			if (MovementData.AMMoveScaleYTime <= 0f)
			{
				MovementData.IsAMMoveScaleY = false;
				MovementData.AMScaleVec.Y = 1f;
				MovementData.AMMoveScaleYTime = 0f;
				flag = true;
			}
		}
		if (MovementData.AMMoveScaleZTime > 0f)
		{
			MovementData.AMMoveScaleZTime -= DeltaTime;
			if (MovementData.AMMoveScaleZTime <= 0f)
			{
				MovementData.IsAMMoveScaleZ = false;
				MovementData.AMScaleVec.Z = 1f;
				MovementData.AMMoveScaleZTime = 0f;
				flag = true;
			}
		}
		if (flag)
		{
			CppCharacterMovementComp.RootMotionTranslationScale = MovementData.AMScaleVec;
		}
	}

	private void TickForFloatingHit(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner == null || !UnitStateData.HasState(EBGUUnitState.FloatingHit))
		{
			return;
		}
		if (MovementData.FloatingExtraHitTime > 0f)
		{
			if (MovementData.FloatingHitTimer >= MovementData.FloatingExtraHitTime)
			{
				MovementData.IsInRiseStage = false;
				MovementData.FloatingHitTimer = 0f;
				MovementData.FloatingExtraHitTime = 0f;
			}
			else
			{
				float num = MovementData.FloatingExtraHitRiseSpd * DeltaTime;
				if (MovementData.ExtraCurrentRiseSummHeight + num > MovementData.FloatingExtraHitHeight)
				{
					num = MovementData.FloatingExtraHitHeight - MovementData.ExtraCurrentRiseSummHeight;
				}
				MovementData.ExtraCurrentRiseSummHeight += num;
				MovementData.CurrentHeight += num;
				if (num > 0f)
				{
					owner.AddActorLocalOffset(new FVector(0.0, 0.0, num), bSweep: true, out var _, bTeleport: true);
				}
			}
		}
		else if (MovementData.IsInRiseStage)
		{
			if (MovementData.FloatingHitTimer >= MovementData.FloatingHitRiseTime)
			{
				MovementData.IsInRiseStage = false;
				MovementData.FloatingHitTimer = 0f;
			}
			else
			{
				float num2 = MovementData.FloatingHitRiseSpd * DeltaTime;
				if (MovementData.CurrentRiseSummHeight + num2 > MovementData.FloatingHitHeight)
				{
					num2 = MovementData.FloatingHitHeight - MovementData.CurrentRiseSummHeight;
				}
				MovementData.CurrentRiseSummHeight += num2;
				MovementData.CurrentHeight += num2;
				if (num2 > 0f)
				{
					owner.AddActorLocalOffset(new FVector(0.0, 0.0, num2), bSweep: true, out var _, bTeleport: true);
				}
			}
		}
		else
		{
			float num3 = MovementData.FloatingHitDeclineSpd * DeltaTime;
			if (MovementData.CurrentHeight - num3 < 0f)
			{
				num3 = MovementData.CurrentHeight;
			}
			MovementData.CurrentHeight -= num3;
			if (MovementData.CurrentHeight <= 0f)
			{
				OnEndFloatingHit();
			}
			else
			{
				owner.AddActorLocalOffset(new FVector(0.0, 0.0, 0f - num3), bSweep: true, out var _, bTeleport: true);
			}
		}
		MovementData.FloatingHitTimer += DeltaTime;
	}

	protected void TickForAMCurveMove(float DeltaTime)
	{
		if (!MovementData.EnableCurveMove || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || bGUCharacterCS.Mesh == null || CppCharacterMovementComp.HasAnimRootMotion_CS())
		{
			return;
		}
		if (MovementData.CurveMoveTimer == 0f)
		{
			CalcCurveMoveScaleToTargetTimes(bGUCharacterCS);
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
		FVector curveMoveDirForCurveMove = GetCurveMoveDirForCurveMove(bGUCharacterCS);
		FVector fVector2 = fVector;
		FVector safeNormal2D = curveMoveDirForCurveMove.GetSafeNormal2D();
		FVector fVector3 = new FVector(0.0, 0.0, (curveMoveDirForCurveMove.Z > 0f) ? 1 : ((curveMoveDirForCurveMove.Z < 0f) ? (-1) : 0));
		MovementData.CurveMoveLastCalcTime = MovementData.CurveMoveTimer;
		MovementData.CurveMoveTimer += DeltaTime;
		if (MovementData.MoveCurveType == EBGUMoveCurveType.SpeedCurve)
		{
			FVector fVector4 = FVector.ZeroVector;
			FVector fVector5 = FVector.ZeroVector;
			if (MovementData.MoveCurveXAxis != null)
			{
				float floatValue = MovementData.MoveCurveXAxis.GetFloatValue(MovementData.CurveMoveTimer);
				fVector4 = safeNormal2D * floatValue;
			}
			if (MovementData.MoveCurveZAxis != null)
			{
				float floatValue2 = MovementData.MoveCurveZAxis.GetFloatValue(MovementData.CurveMoveTimer);
				fVector5 = fVector3 * floatValue2;
				if (MovementData.CurveMovementModeHandleID == 0)
				{
					base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "TickForAMCurveMove_SpeedCurve");
					MovementData.CurveMovementModeHandleID = PropMgrData.GetLastHandleID();
				}
				else
				{
					base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, MovementData.CurveMovementModeHandleID, 0u, bSetDefaultProperty: false, "TickForAMCurveMove_SpeedCurve");
				}
			}
			fVector2 += fVector4 * DeltaTime;
			fVector2 += fVector5 * DeltaTime;
		}
		else if (MovementData.MoveCurveType == EBGUMoveCurveType.DistanceCurve)
		{
			FVector fVector6 = FVector.ZeroVector;
			FVector fVector7 = FVector.ZeroVector;
			if (MovementData.MoveCurveXAxis != null)
			{
				float floatValue3 = MovementData.MoveCurveXAxis.GetFloatValue(MovementData.CurveMoveLastCalcTime);
				float num = MovementData.MoveCurveXAxis.GetFloatValue(MovementData.CurveMoveTimer) - floatValue3;
				fVector6 = safeNormal2D * (num * MovementData.CurveMoveScaleTimesToTarget);
			}
			if (MovementData.MoveCurveZAxis != null)
			{
				float floatValue4 = MovementData.MoveCurveZAxis.GetFloatValue(MovementData.CurveMoveLastCalcTime);
				float num2 = MovementData.MoveCurveZAxis.GetFloatValue(MovementData.CurveMoveTimer) - floatValue4;
				fVector7 = fVector3 * num2;
				if (MovementData.CurveMovementModeHandleID == 0)
				{
					base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, 0u, bSetDefaultProperty: false, "TickForAMCurveMove_DistanceCurve");
					MovementData.CurveMovementModeHandleID = PropMgrData.GetLastHandleID();
				}
				else
				{
					base.BUSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, MovementData.CurveMovementModeHandleID, 0u, bSetDefaultProperty: false, "TickForAMCurveMove_DistanceCurve");
				}
			}
			fVector2 = fVector2 + fVector6 + fVector7;
		}
		FVector fVector8 = (fVector2 - fVector) / DeltaTime;
		MovementData.CurveMoveQueue.Enqueue(fVector8);
		if (MovementData.CurveMoveQueue.Count > 2)
		{
			MovementData.CurveMoveQueue.Dequeue();
		}
		SetCharacterVelocity_Flying(fVector8);
	}

	private void SetCharacterVelocity_Flying(FVector NewVelocity)
	{
		CppCharacterMovementComp.Velocity = NewVelocity;
	}

	private float GetCurveScaleTimesForTimeAxis(UCurveFloat MoveCurve, float MoveTotalTime)
	{
		float MinTime = 0f;
		float MaxTime = 0f;
		if (MoveCurve != null)
		{
			MoveCurve.GetTimeRange(out MinTime, out MaxTime);
		}
		float num = MaxTime - MinTime;
		float result = 1f;
		if (num > 0f)
		{
			result = MoveTotalTime / num;
			result = ((result > 0f) ? result : 1f);
		}
		return result;
	}

	private FVector GetCurveMoveDirForCurveMove(BGUCharacterCS Chr)
	{
		if (MovementData.CurveMoveUseBeHitDir)
		{
			BUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BeAttackData>(Chr);
			if (readOnlyData != null)
			{
				AActor attacker = readOnlyData.GetAttacker();
				if (!attacker.IsNullOrDestroyed())
				{
					FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(attacker);
					return (BGUFuncLibActorTransformCS.BGUGetActorLocation(Chr) - fVector).GetSafeNormal();
				}
			}
		}
		else if (MovementData.CurveMoveUseAttractionDir)
		{
			BUC_BeAttackData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_BeAttackData>(Chr);
			if (readOnlyData2 != null)
			{
				FVector attractionLocation = readOnlyData2.GetAttractionLocation();
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Chr);
				return (attractionLocation - fVector2).GetSafeNormal();
			}
		}
		FVector fVector3 = Chr.GetActorForwardVector() * MovementData.CurveMoveDirInfo.X;
		FVector fVector4 = Chr.GetActorRightVector() * MovementData.CurveMoveDirInfo.Y;
		FVector fVector5 = Chr.GetActorUpVector() * MovementData.CurveMoveDirInfo.Z;
		return (fVector3 + fVector4 + fVector5).GetSafeNormal();
	}

	private void CalcCurveMoveScaleToTargetTimes(AActor OwnerActor)
	{
		if (MovementData.CurveMoveIsScaleToTarget)
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(OwnerActor);
			if (aActor != null)
			{
				if (MovementData.MoveCurveXAxis != null)
				{
					UCurveFloat moveCurveXAxis = MovementData.MoveCurveXAxis;
					moveCurveXAxis.GetTimeRange(out var MinTime, out var MaxTime);
					float floatValue = moveCurveXAxis.GetFloatValue(MinTime);
					float num = moveCurveXAxis.GetFloatValue(MaxTime) - floatValue;
					FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor);
					FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
					float num2 = FVector.Dist2D(v, v2) - MovementData.CurveMoveScaleOffset;
					num2 = ((num2 > 0f) ? num2 : 0f);
					float curveMoveScaleTimesToTarget = num2 / num;
					MovementData.CurveMoveScaleTimesToTarget = curveMoveScaleTimesToTarget;
				}
			}
			else
			{
				OnSetCurveMoveScaleInfo(IsScaleToTarget: false, 0f, IsScaleToAttractionLocation: false);
			}
		}
		else if (MovementData.CurveMoveIsScaleToAttractionLocation && MovementData.MoveCurveXAxis != null)
		{
			UCurveFloat moveCurveXAxis2 = MovementData.MoveCurveXAxis;
			moveCurveXAxis2.GetTimeRange(out var MinTime2, out var MaxTime2);
			float floatValue2 = moveCurveXAxis2.GetFloatValue(MinTime2);
			float num3 = moveCurveXAxis2.GetFloatValue(MaxTime2) - floatValue2;
			FVector v3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor);
			FVector attractionLocation = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>().GetAttractionLocation();
			float num4 = FVector.Dist2D(v3, attractionLocation);
			num4 = ((num4 > 0f) ? num4 : 0f);
			float curveMoveScaleTimesToTarget2 = num4 / num3;
			MovementData.CurveMoveScaleTimesToTarget = curveMoveScaleTimesToTarget2;
		}
	}

	internal void Reset()
	{
		if (MoveModes.ActiveMover != null)
		{
			MoveModes.ActiveMover.TriggerOnEnd();
			ActionRequestData.ReleaseMoveIdx();
			MovementData.SetMoveType(EBGUMoveMode.None);
			if (MoveModes.ActiveMover != null)
			{
				MoveModes.ActiveMover.SetActive(bVal: false);
				MoveModes.ActiveMover = null;
			}
			MovementData.NormalMoveSpeed = 0f;
		}
	}

	internal void MoveStop(bool bShouldRestoreLastMoveMode = false)
	{
		if (MoveModes.ActiveMover == null)
		{
			return;
		}
		MoveModes.ActiveMover.TriggerOnEnd();
		ActionRequestData.ReleaseMoveIdx();
		MovementData.SetMoveType(EBGUMoveMode.None);
		MovementData.NormalMoveSpeed = 0f;
		if (MovementData.MoveModeStack.Count > 0)
		{
			MovementData.MoveModeStack.Pop();
		}
		if (bShouldRestoreLastMoveMode)
		{
			if (MovementData.MoveModeStack.Count > 0)
			{
				BUC_MoveModeBase type = MovementData.MoveModeStack.Peek();
				SwitchMoverIfNeeded(type, bAlwaysGenIdx: true);
			}
			else
			{
				MovementData.MoveModeStack.Clear();
				MoveModes.ActiveMover = null;
			}
		}
		else
		{
			if (MovementData.MoveModeStack.Count > 0)
			{
				MovementData.MoveModeStack.Pop();
			}
			MoveModes.ActiveMover = null;
		}
	}

	private void StopMoveWithRequestIdx(int RequestIdx)
	{
		if (ActionRequestData.GetLastMoveIdx() == RequestIdx)
		{
			MoveStop();
		}
	}

	private void StopCurrentMove()
	{
		if (ActionRequestData.GetLastMoveIdx() > 0)
		{
			MoveStop();
		}
	}

	private void ForceStopCurrentMove()
	{
		MoveStop();
	}

	private void SwitchMoverIfNeeded<T>(T Type, bool bAlwaysGenIdx) where T : BUC_MoveModeBase, new()
	{
		T moveMode = MoveModes.GetMoveMode<T>();
		if (moveMode == null)
		{
			BGW_LogUtil.LogError($"切换了一个不存在的MoveMode，T = {typeof(T)}");
			return;
		}
		if (moveMode != MoveModes.ActiveMover)
		{
			Reset();
			MovementData.MoveModeStack.Push(moveMode);
			ActionRequestData.RequestMoveIdx();
			if (moveMode is BGU_FlyControlMoveMode bGU_FlyControlMoveMode)
			{
				bGU_FlyControlMoveMode.ResetVelocity();
			}
		}
		else if (bAlwaysGenIdx)
		{
			Reset();
			ActionRequestData.RequestMoveIdx();
			if (moveMode is BGU_FlyControlMoveMode bGU_FlyControlMoveMode2)
			{
				bGU_FlyControlMoveMode2.ResetVelocity();
			}
		}
		MoveModes.ActiveMover = moveMode;
		MoveModes.ActiveMover.SetActive(bVal: true);
		MovementData.SetMoveType(moveMode.GetMoveMode());
	}

	protected void SwitchMoverIfNeeded<T>(bool bAlwaysGenIdx) where T : BUC_MoveModeBase, new()
	{
		T moveMode = MoveModes.GetMoveMode<T>();
		if (moveMode == null)
		{
			BGW_LogUtil.LogError($"切换了一个不存在的MoveMode，T = {typeof(T)}");
			return;
		}
		if (moveMode != MoveModes.ActiveMover)
		{
			Reset();
			MovementData.MoveModeStack.Push(moveMode);
			ActionRequestData.RequestMoveIdx();
			if (moveMode is BGU_FlyControlMoveMode bGU_FlyControlMoveMode)
			{
				bGU_FlyControlMoveMode.ResetVelocity();
			}
		}
		else if (bAlwaysGenIdx)
		{
			Reset();
			ActionRequestData.RequestMoveIdx();
			if (moveMode is BGU_FlyControlMoveMode bGU_FlyControlMoveMode2)
			{
				bGU_FlyControlMoveMode2.ResetVelocity();
			}
		}
		MoveModes.ActiveMover = moveMode;
		MoveModes.ActiveMover.SetActive(bVal: true);
		MovementData.SetMoveType(moveMode.GetMoveMode());
	}

	private void MoveForward(float Value)
	{
		MovementData.SetCurrentInputVecX(Value);
		if (Value != 0f && CheckCanRun())
		{
			bool flag = true;
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.FlyControlMode))
			{
				SwitchMoverIfNeeded<BGU_FlyControlMoveMode>(bAlwaysGenIdx: false);
			}
			else if (SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
			{
				SwitchMoverIfNeeded<BGU_CloudMoveMode>(bAlwaysGenIdx: false);
			}
			else if (UnitStateData.HasState(EBGUUnitState.JumpMoving))
			{
				SwitchMoverIfNeeded<BGU_JumpMoveMode>(bAlwaysGenIdx: false);
			}
			else if (MovementData.IsMoveModeActive(EBGUMoveMode.SplineFlyControl))
			{
				SwitchMoverIfNeeded<BGU_SplineFlyControlMoveMode>(bAlwaysGenIdx: false);
			}
			else if (ParkourMoveData.IsPakourMoving)
			{
				SwitchMoverIfNeeded<BGU_ParkourMoveMode>(bAlwaysGenIdx: false);
			}
			else if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
			{
				SwitchMoverIfNeeded<BGU_GlideMoveMode>(bAlwaysGenIdx: false);
			}
			else if (SimpleStateData.HasSimpleState(EBGUSimpleState.UseCarMontageMoveMode))
			{
				SwitchMoverIfNeeded<BGU_CarMontageMoveMode>(bAlwaysGenIdx: false);
			}
			else if (UnitStateData.HasState(EBGUUnitState.SideWalking))
			{
				SwitchMoverIfNeeded<BGU_SideWalkMoveMode>(bAlwaysGenIdx: false);
			}
			else if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode))
			{
				SwitchMoverIfNeeded<BGU_PhysicsSimulationMoveMode>(bAlwaysGenIdx: false);
			}
			else if (ManualSplineMoveData.bManualSplineMoving)
			{
				SwitchMoverIfNeeded<BGU_ManualSplineMoveMode>(bAlwaysGenIdx: false);
			}
			else if (MovementData.IsMoveModeActive(EBGUMoveMode.NpcGuideSplineMove))
			{
				SwitchMoverIfNeeded<BGU_NpcGuideSplineMoveMode>(bAlwaysGenIdx: false);
				flag = false;
			}
			else if (MovementData.IsMoveModeActive(EBGUMoveMode.AISpiderMove))
			{
				SwitchMoverIfNeeded<BGU_AISpiderMoveMode>(bAlwaysGenIdx: false);
				flag = false;
			}
			else
			{
				SwitchMoverIfNeeded<BGU_NormalMoveMode>(bAlwaysGenIdx: false);
			}
			if (flag)
			{
				MoveModes.ActiveMover?.MoveForward(Value);
			}
		}
	}

	private void MoveRight(float Value)
	{
		MovementData.SetCurrentInputVecY(Value);
		if (Value != 0f && CheckCanRun())
		{
			bool flag = true;
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.FlyControlMode))
			{
				SwitchMoverIfNeeded<BGU_FlyControlMoveMode>(bAlwaysGenIdx: false);
			}
			else if (SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
			{
				SwitchMoverIfNeeded<BGU_CloudMoveMode>(bAlwaysGenIdx: false);
			}
			else if (UnitStateData.HasState(EBGUUnitState.JumpMoving))
			{
				SwitchMoverIfNeeded<BGU_JumpMoveMode>(bAlwaysGenIdx: false);
			}
			else if (MovementData.IsMoveModeActive(EBGUMoveMode.SplineFlyControl))
			{
				SwitchMoverIfNeeded<BGU_SplineFlyControlMoveMode>(bAlwaysGenIdx: false);
			}
			else if (ParkourMoveData.IsPakourMoving)
			{
				SwitchMoverIfNeeded<BGU_ParkourMoveMode>(bAlwaysGenIdx: false);
			}
			else if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
			{
				SwitchMoverIfNeeded<BGU_GlideMoveMode>(bAlwaysGenIdx: false);
			}
			else if (SimpleStateData.HasSimpleState(EBGUSimpleState.UseCarMontageMoveMode) || GetActorResID() == 2)
			{
				SwitchMoverIfNeeded<BGU_CarMontageMoveMode>(bAlwaysGenIdx: false);
			}
			else if (UnitStateData.HasState(EBGUUnitState.SideWalking))
			{
				SwitchMoverIfNeeded<BGU_SideWalkMoveMode>(bAlwaysGenIdx: false);
			}
			else if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode))
			{
				SwitchMoverIfNeeded<BGU_PhysicsSimulationMoveMode>(bAlwaysGenIdx: false);
			}
			else if (ManualSplineMoveData.bManualSplineMoving)
			{
				SwitchMoverIfNeeded<BGU_ManualSplineMoveMode>(bAlwaysGenIdx: false);
			}
			else if (MovementData.IsMoveModeActive(EBGUMoveMode.NpcGuideSplineMove))
			{
				SwitchMoverIfNeeded<BGU_NpcGuideSplineMoveMode>(bAlwaysGenIdx: false);
				flag = false;
			}
			else if (MovementData.IsMoveModeActive(EBGUMoveMode.AISpiderMove))
			{
				SwitchMoverIfNeeded<BGU_AISpiderMoveMode>(bAlwaysGenIdx: false);
				flag = false;
			}
			else
			{
				SwitchMoverIfNeeded<BGU_NormalMoveMode>(bAlwaysGenIdx: false);
			}
			if (flag)
			{
				MoveModes.ActiveMover?.MoveRight(Value);
			}
		}
	}

	private void MoveForwardFinish()
	{
		MovementData.SetCurrentInputVecX(0f);
	}

	private void MoveRightFinish()
	{
		MovementData.SetCurrentInputVecY(0f);
	}

	protected void TickForInterpolationMove(float DeltaTime, bool bForceUpdate = false)
	{
		if (!MovementData.IM_EnableMove)
		{
			return;
		}
		if (MovementData.IM_TotalTime > 0f)
		{
			if (!MovementData.IM_IgnoreRotation)
			{
				FRotator Current = BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner());
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(CharacterComps.OwnerCharacter);
				FVector2D unitRotateAimDir = new FVector2D(v);
				FVector2D unit2TargetDir = new FVector2D(MovementData.IM_TargetRotation.Vector().GetSafeNormal());
				float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
				FRotator Target = Current;
				if (BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir))
				{
					Target.Yaw = MathLib.NormalizeAxis(Target.Yaw + rotateAngle2D);
				}
				else
				{
					Target.Yaw = MathLib.NormalizeAxis(Target.Yaw - rotateAngle2D);
				}
				float interpSpeed = rotateAngle2D / MovementData.IM_TotalTime;
				Target = MathLib.RInterpConstantTo(in Current, in Target, DeltaTime, interpSpeed);
				BGUFuncLibActorTransformCS.BGUSetActorRotation(CharacterComps.OwnerCharacter, Target, bTeleportPhysics: false, bForceUpdate);
			}
			if (!MovementData.IM_IgnoreLocation)
			{
				FVector Current2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner());
				FVector Target2 = MovementData.IM_TargetLoction;
				float interpSpeed2;
				if (!MovementData.IM_EnableZAxisMove)
				{
					interpSpeed2 = FVector.Dist2D(Current2, Target2) / MovementData.IM_TotalTime;
					Target2.Z = Current2.Z;
				}
				else
				{
					interpSpeed2 = FVector.Dist(Current2, Target2) / MovementData.IM_TotalTime;
				}
				FVector newLocation = MathLib.VInterpConstantTo(in Current2, in Target2, DeltaTime, interpSpeed2);
				BGUFuncLibActorTransformCS.BGUSetActorLocation(GetOwner(), newLocation, bSweep: false, bTeleport: false, NeedReturnHitResult: false, bForceUpdate);
			}
			MovementData.IM_TotalTime -= DeltaTime;
			return;
		}
		MovementData.IM_EnableMove = false;
		if (MovementData.bMatchingPosition)
		{
			FTransform p = default(FTransform);
			FVector iM_TargetLoction = MovementData.IM_TargetLoction;
			iM_TargetLoction.Z = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()).Z;
			p.SetLocation(iM_TargetLoction);
			p.SetRotation(MovementData.IM_TargetRotation.Conv_RotatorToQuaternion());
			base.BUSEventCollection.Evt_TeleportMoveByTrans.Invoke(p);
			MovementData.bMatchingPosition = false;
			MovementData.MatchingPosInterpMoveCallback?.Invoke(bSuccess: true);
			if (!MovementData.bMatchingPosition)
			{
				MovementData.MatchingPosAIPathMoveCallback = null;
				MovementData.MatchingPosInterpMoveCallback = null;
			}
			return;
		}
		if (!MovementData.IM_IgnoreRotation)
		{
			FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner());
			FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(CharacterComps.OwnerCharacter);
			FVector2D unitRotateAimDir2 = new FVector2D(v2);
			FVector2D unit2TargetDir2 = new FVector2D(MovementData.IM_TargetRotation.Vector().GetSafeNormal());
			float rotateAngle2D2 = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir2, unit2TargetDir2);
			FRotator newRotation = fRotator;
			if (BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir2, unit2TargetDir2))
			{
				newRotation.Yaw = MathLib.NormalizeAxis(newRotation.Yaw + rotateAngle2D2);
			}
			else
			{
				newRotation.Yaw = MathLib.NormalizeAxis(newRotation.Yaw - rotateAngle2D2);
			}
			BGUFuncLibActorTransformCS.BGUSetActorRotation(CharacterComps.OwnerCharacter, newRotation, bTeleportPhysics: false, bForceUpdate);
		}
		if (!MovementData.IM_IgnoreLocation)
		{
			FVector iM_TargetLoction2 = MovementData.IM_TargetLoction;
			if (!MovementData.IM_EnableZAxisMove)
			{
				iM_TargetLoction2.Z = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner()).Z;
			}
			BGUFuncLibActorTransformCS.BGUSetActorLocation(GetOwner(), iM_TargetLoction2, bSweep: false, bTeleport: false, NeedReturnHitResult: false, bForceUpdate);
		}
	}

	protected void OnRotateWithCam(FVector CamDirInXYPlane, float TurnSpeed)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner() as ACharacter) + CamDirInXYPlane * 1000.0;
		MovementData.SetRotateInfo(fVector, TurnSpeed);
		SwitchMoverIfNeeded<BGU_RotateWithCamMoveMode>(bAlwaysGenIdx: true);
		if (MoveModes.ActiveMover is BGU_RotateWithCamMoveMode bGU_RotateWithCamMoveMode)
		{
			bGU_RotateWithCamMoveMode.BeginRotateToPos(TurnSpeed, fVector);
		}
	}

	private void OnRotateWithCamEnded()
	{
		if (MoveModes.ActiveMover is BGU_RotateWithCamMoveMode bGU_RotateWithCamMoveMode)
		{
			bGU_RotateWithCamMoveMode.StopMove();
		}
	}

	private void OnAIMoveTo(FVector TargetLocation, AActor Target, EAIMoveSpeedType SpeedRateType, float AcceptableRadius, EBGUMoveAIType MoveAIType, bool IncludeSelfRadius, bool IncludeTargetRadius, string SceneCompName = "", string SocketName = "")
	{
		base.BUSEventCollection.Evt_SetMoveToTarget.Invoke(Target, TargetLocation, ETargetSourceType.Target_AutoMoveTo, SceneCompName, SocketName);
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.PhysicsSimulationMoveMode))
		{
			SwitchMoverIfNeeded<BGU_PhysicsSimulationMoveMode>(bAlwaysGenIdx: true);
			if (MoveModes.ActiveMover is BGU_PhysicsSimulationMoveMode bGU_PhysicsSimulationMoveMode)
			{
				if (Target == null)
				{
					bGU_PhysicsSimulationMoveMode.BeginMoveToLocation(in TargetLocation, SpeedRateType, AcceptableRadius, IncludeSelfRadius, IncludeTargetRadius);
				}
				else
				{
					bGU_PhysicsSimulationMoveMode.BeginMoveToActor(Target, SpeedRateType, AcceptableRadius, IncludeSelfRadius, IncludeTargetRadius);
				}
			}
		}
		else if (GetMovementMode() == EMovementMode.MOVE_Flying)
		{
			SwitchMoverIfNeeded<BGU_AIFlyPathMoveMode>(bAlwaysGenIdx: true);
			if (MoveModes.ActiveMover is BGU_AIFlyPathMoveMode bGU_AIFlyPathMoveMode)
			{
				if (Target == null)
				{
					bGU_AIFlyPathMoveMode.BeginMoveToLocation(TargetLocation, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
				}
				else
				{
					bGU_AIFlyPathMoveMode.BeginMoveToActor(Target, SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
				}
			}
		}
		else
		{
			SwitchMoverIfNeeded<BGU_AIPathMoveMode>(bAlwaysGenIdx: true);
			if (MoveModes.ActiveMover is BGU_AIPathMoveMode bGU_AIPathMoveMode)
			{
				bGU_AIPathMoveMode.BeginMove(SpeedRateType, AcceptableRadius, MoveAIType, IncludeSelfRadius, IncludeTargetRadius);
				AIData.SetIsMoveInvalidByNav(bGU_AIPathMoveMode.IsOutOfRange());
			}
		}
	}

	private void OnForceSetAIMoveFacingTargetRotation(in FRotator TargetRotation)
	{
		switch (MoveModes.ActiveMover?.GetMoveMode() ?? EBGUMoveMode.None)
		{
		case EBGUMoveMode.AIPathMove:
			if (MoveModes.ActiveMover is BGU_AIPathMoveMode bGU_AIPathMoveMode)
			{
				bGU_AIPathMoveMode.SetFacingTargetRotation(in TargetRotation);
			}
			break;
		case EBGUMoveMode.AIFlyMove:
			if (MoveModes.ActiveMover is BGU_AIFlyPathMoveMode bGU_AIFlyPathMoveMode)
			{
				bGU_AIFlyPathMoveMode.SetFacingTargetRotation(in TargetRotation);
			}
			break;
		}
	}

	private void OnAIWallAndCellMoveTo(FVector TargetLocation, EAIMoveSpeedType SpeedRateType, float TurnSpeed, float AcceptableRadius, bool IncludeSelfRadius)
	{
		SwitchMoverIfNeeded<BGU_AIWallAndCellMove>(bAlwaysGenIdx: true);
		if (MoveModes.ActiveMover is BGU_AIWallAndCellMove bGU_AIWallAndCellMove)
		{
			bGU_AIWallAndCellMove.BeginMoveToLocation(TargetLocation, SpeedRateType, TurnSpeed, AcceptableRadius, IncludeSelfRadius);
		}
	}

	private void OnAttackRotateToPos(FVector TargetLocation, float TurnSpeed, bool bForceUpdate)
	{
		MovementData.SetRotateInfo(TargetLocation, TurnSpeed);
		SwitchMoverIfNeeded<BGU_AttackRotateMoveMode>(bAlwaysGenIdx: true);
		if (MoveModes.ActiveMover is BGU_AttackRotateMoveMode bGU_AttackRotateMoveMode)
		{
			bGU_AttackRotateMoveMode.BeginRotateToPos(TurnSpeed, TargetLocation, bForceUpdate);
		}
	}

	private void OnTPSRotateToPos(FVector TargetLocation, float TurnSpeed, bool bForceUpdate)
	{
		MovementData.SetRotateInfo(TargetLocation, TurnSpeed);
		SwitchMoverIfNeeded<BGU_TPSRotateMoveMode>(bAlwaysGenIdx: true);
		if (MoveModes.ActiveMover is BGU_TPSRotateMoveMode bGU_TPSRotateMoveMode)
		{
			bGU_TPSRotateMoveMode.BeginRotateToPos(TurnSpeed, TargetLocation, bForceUpdate);
		}
	}

	private void OnActorRotateToPos(FVector TargetLocation, float TurnSpeed, bool bForceUpdate)
	{
		if (!CheckCanRotate())
		{
			return;
		}
		EBGUMoveMode moveType = MovementData.GetMoveType();
		if (moveType == EBGUMoveMode.None || moveType == EBGUMoveMode.Normal || moveType == EBGUMoveMode.SideWalk)
		{
			MovementData.SetRotateInfo(TargetLocation, TurnSpeed);
			SwitchMoverIfNeeded<BGU_StandAndRotateMoveMode>(bAlwaysGenIdx: true);
			if (MoveModes.ActiveMover is BGU_StandAndRotateMoveMode bGU_StandAndRotateMoveMode)
			{
				bGU_StandAndRotateMoveMode.BeginRotateToPos(TurnSpeed, TargetLocation);
			}
		}
	}

	private void OnActorRotateToTarget(AActor TargetActor, float TurnSpeed)
	{
		if (!CheckCanRotate())
		{
			return;
		}
		EBGUMoveMode moveType = MovementData.GetMoveType();
		if (moveType == EBGUMoveMode.None || moveType == EBGUMoveMode.Normal || moveType == EBGUMoveMode.SideWalk)
		{
			FVector targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor);
			MovementData.SetRotateInfo(targetPos, TurnSpeed);
			SwitchMoverIfNeeded<BGU_StandAndRotateMoveMode>(bAlwaysGenIdx: true);
			if (MoveModes.ActiveMover is BGU_StandAndRotateMoveMode bGU_StandAndRotateMoveMode)
			{
				bGU_StandAndRotateMoveMode.BeginRotateToTarget(TurnSpeed, TargetActor);
			}
		}
	}

	private void PlayerSkillDirFixed(float RotateDeflectionAngle)
	{
		if (MoveModes.ActiveMover is BGU_AttackRotateMoveMode bGU_AttackRotateMoveMode)
		{
			bGU_AttackRotateMoveMode.PlayerRotDeflectionAngleFixed(RotateDeflectionAngle);
		}
	}

	private void OnAISideWalk(float VValue, float HValue)
	{
		MoveForward(VValue);
		MoveRight(HValue);
	}

	private void OnSkillRotateTraceLocation(FVector TargetLocation, float TurnSpeed)
	{
		MovementData.SetRotateInfo(TargetLocation, TurnSpeed);
		SwitchMoverIfNeeded<BGU_AnimMontageMoveMode>(bAlwaysGenIdx: true);
		if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
		{
			bGU_AnimMontageMoveMode.BeginRotateToPos(TurnSpeed, TargetLocation);
		}
	}

	private void OnSkillRotateTraceActor(AActor TargetActor, float TurnSpeed)
	{
		if (TargetActor == null)
		{
			return;
		}
		MovementData.SetRotateInfo(BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetActor), TurnSpeed);
		SwitchMoverIfNeeded<BGU_AnimMontageMoveMode>(bAlwaysGenIdx: true);
		if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
		{
			UnitLockTargetInfo unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(TargetActor, ETargetSourceType.None, ELockTargetWayType.Auto);
			if (unitLockTargetInfo != null)
			{
				bGU_AnimMontageMoveMode.BeginRotateToTarget(TurnSpeed, unitLockTargetInfo);
			}
		}
	}

	private void OnMontageRotateTraceActor(UnitLockTargetInfo LockTargetInfo, float TurnSpeed, float RotateDeflectionAngle, float MaxRotateAngle, string TraceSocket, bool bIncludeAutoLockPoint, ERotateDirection RotateDirection, bool bStillRotateWhenAboveMaxRotateAngle, float DeadzoneAngle, bool EnableDebug)
	{
		if (LockTargetInfo == null || LockTargetInfo.LockTargetActor == null)
		{
			return;
		}
		AActor lockTargetActor = LockTargetInfo.LockTargetActor;
		IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(lockTargetActor);
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.RefuseAttackRotation))
		{
			return;
		}
		FVector targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor);
		if (TraceSocket.Length > 0)
		{
			ACharacter aCharacter = lockTargetActor as ACharacter;
			if (aCharacter != null && aCharacter.Mesh != null)
			{
				targetPos = aCharacter.Mesh.GetSocketLocation(new FName(TraceSocket));
			}
		}
		SwitchMoverIfNeeded<BGU_AnimMontageMoveMode>(bAlwaysGenIdx: false);
		MovementData.SetRotateInfo(targetPos, TurnSpeed);
		if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
		{
			bGU_AnimMontageMoveMode.BeginRotateToTarget(TurnSpeed, LockTargetInfo, RotateDeflectionAngle, MaxRotateAngle, TraceSocket, bIncludeAutoLockPoint, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, EnableDebug);
		}
	}

	private void OnMontageRotateAroundLocation(FVector TargetPos, float TurnSpeed, float RotateDeflectionAngle, float MaxRotateAngle, ERotateDirection RotateDirection, bool bStillRotateWhenAboveMaxRotateAngle, float DeadzoneAngle, bool EnableDebug)
	{
		SwitchMoverIfNeeded<BGU_AnimMontageMoveMode>(bAlwaysGenIdx: false);
		MovementData.SetRotateInfo(TargetPos, TurnSpeed);
		if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
		{
			bGU_AnimMontageMoveMode.BeginRotateToPos(TurnSpeed, TargetPos, bForceUpdate: false, RotateDeflectionAngle, MaxRotateAngle, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, EnableDebug);
		}
	}

	private void OnFinishRotateMoveMode()
	{
		if (MoveModes.ActiveMover is BUC_MoveModeWithRotateBase bUC_MoveModeWithRotateBase)
		{
			bUC_MoveModeWithRotateBase.FinishRotate();
		}
	}

	private void OnSwitchWalkType(bool bSideWalk)
	{
	}

	private void OnSetAMSectionSpeedRate(int NotifyStateID, float SpeedRate, float DurationTime = 0f)
	{
		if (GSGameplayCVar.CVar_AnimDisableAMSpeedRate.GetValueInGameThread() == 1)
		{
			return;
		}
		if (DurationTime > 0f)
		{
			MovementData.AMCaleSpeedRateTime = DurationTime;
			MovementData.AMSpeedRate = ((SpeedRate > 0f) ? SpeedRate : 1f);
			MovementData.IsAMCalcSpeedRate = true;
			MovementData.AMSpeedRateNotifyStateID = NotifyStateID;
			USkeletalMeshComponent mesh = CharacterComps.OwnerCharacter.Mesh;
			if (mesh != null)
			{
				UAnimInstance animInstance = mesh.GetAnimInstance();
				if (animInstance != null && animInstance.IsAnyMontagePlaying())
				{
					UGSE_CharacterFuncLib.SetMontagePlayRate(CharacterComps.OwnerCharacter, MovementData.AMSpeedRate);
					if (AnimationSyncData.Guest != null)
					{
						BUS_EventCollectionCS.Get(AnimationSyncData.Guest)?.Evt_SetAMSectionSpeedRate.Invoke(NotifyStateID, SpeedRate, DurationTime);
					}
				}
			}
		}
		else if (MovementData.AMSpeedRateNotifyStateID == NotifyStateID)
		{
			MovementData.AMCaleSpeedRateTime = DurationTime;
			MovementData.AMSpeedRate = 1f;
			MovementData.IsAMCalcSpeedRate = false;
			UGSE_CharacterFuncLib.SetMontagePlayRate(CharacterComps.OwnerCharacter, MovementData.AMSpeedRate);
			if (AnimationSyncData.Guest != null)
			{
				BUS_EventCollectionCS.Get(AnimationSyncData.Guest)?.Evt_SetAMSectionSpeedRate.Invoke(NotifyStateID, SpeedRate, DurationTime);
			}
		}
		base.BUSEventCollection.Evt_OnDummyMeshSpeedRateChange.Invoke();
	}

	private void OnMontagePausePlaying(bool bPause)
	{
		MovementData.IsAMPause = bPause;
		if (AnimationSyncData != null)
		{
			if (AnimationSyncData.Guest != null)
			{
				BUS_EventCollectionCS.Get(AnimationSyncData.Guest)?.Evt_OnMontagePausePlaying.Invoke(bPause);
			}
			base.BUSEventCollection.Evt_OnDummyMeshSpeedRateChange.Invoke();
		}
	}

	private void OnSetAMScaleMaxRate(float AMScaleMaxRate)
	{
		MovementData.AMScaleMaxRate = AMScaleMaxRate;
	}

	private void SetAMSectionScaleAxisRate(FVector ScaleVec, float DurationTime, EAMScaleRateAxis AMScaleRateAxis = EAMScaleRateAxis.All)
	{
		USkeletalMeshComponent mesh = CharacterComps.OwnerCharacter.Mesh;
		if (!(mesh != null))
		{
			return;
		}
		UAnimInstance animInstance = mesh.GetAnimInstance();
		if (!(animInstance != null) || !animInstance.IsAnyMontagePlaying() || !CharacterComps.OwnerCharacter.HasAnyRootMotion())
		{
			return;
		}
		switch (AMScaleRateAxis)
		{
		case EAMScaleRateAxis.AllByScaleRateAxisX:
		case EAMScaleRateAxis.All:
			if (DurationTime > 0f)
			{
				ScaleVec.X = ((ScaleVec.X > 0f) ? ScaleVec.X : 1f);
				ScaleVec.Y = ((ScaleVec.Y > 0f) ? ScaleVec.Y : 1f);
				ScaleVec.Z = ((ScaleVec.Z > 0f) ? ScaleVec.Z : 1f);
				MovementData.AMScaleVec = ScaleVec;
				MovementData.IsAMMoveScaleX = true;
				MovementData.IsAMMoveScaleY = true;
				MovementData.IsAMMoveScaleZ = true;
				MovementData.AMMoveScaleXTime = DurationTime;
				MovementData.AMMoveScaleYTime = DurationTime;
				MovementData.AMMoveScaleZTime = DurationTime;
			}
			break;
		case EAMScaleRateAxis.AxisX:
			if (DurationTime > 0f)
			{
				ScaleVec.X = ((ScaleVec.X > 0f) ? ScaleVec.X : 1f);
				MovementData.AMScaleVec.X = ScaleVec.X;
				MovementData.IsAMMoveScaleX = true;
				MovementData.AMMoveScaleXTime = DurationTime;
			}
			break;
		case EAMScaleRateAxis.AxisY:
			if (DurationTime > 0f)
			{
				ScaleVec.Y = ((ScaleVec.Y > 0f) ? ScaleVec.Y : 1f);
				MovementData.AMScaleVec.Y = ScaleVec.Y;
				MovementData.IsAMMoveScaleY = true;
				MovementData.AMMoveScaleYTime = DurationTime;
			}
			break;
		case EAMScaleRateAxis.AxisZ:
			if (DurationTime > 0f)
			{
				ScaleVec.Z = ((ScaleVec.Z > 0f) ? ScaleVec.Z : 1f);
				MovementData.AMScaleVec.Z = ScaleVec.Z;
				MovementData.IsAMMoveScaleZ = true;
				MovementData.AMMoveScaleZTime = DurationTime;
			}
			break;
		}
		CppCharacterMovementComp.RootMotionTranslationScale = MovementData.AMScaleVec;
	}

	private FVector GetMeshLocalRot(ACharacter Unit)
	{
		USkeletalMeshComponent mesh = Unit.Mesh;
		if (mesh != null)
		{
			return mesh.RelativeRotation.Vector();
		}
		return FVector.OneVector;
	}

	private AActor GetCurrentTarget(bool IsUseSkillBaseTarget, out FVector TargetLoc)
	{
		TargetLoc = FVector.ZeroVector;
		UnitLockTargetInfo TargetInfo = (IsUseSkillBaseTarget ? TargetInfoData.GetSkillBaseTarget() : TargetInfoData.GetTargetInfo());
		AActor aActor = null;
		if (TargetInfo != null && TargetInfo.LockTargetActor != null)
		{
			aActor = TargetInfo.LockTargetActor;
			if (aActor != null)
			{
				IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(aActor);
				if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.RefuseAMScale))
				{
					return null;
				}
			}
			TargetLoc = BGU_SelectTargetUtil.GetTargetPositionByTargetInfo(in TargetInfo, out var _);
		}
		return aActor;
	}

	private void OnSetAMScaleRateByPosMultiCast(EAMScaleType AMScaleType, EAMScaleRateAxis AMScaleAxis, float LandingTraceLength, float PureScaleValue, int CachedDataID, bool AttackRangeLimit, bool DebugMode, float TotalDuration, float NotifyBeginTime, float NotifyEndTime, float AMScaleMinRate = 0f, float AMScaleMaxRate = 0f, float AMScaleMoveOffset = 0f, float AMScaleMoveOffsetZ = 0f)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (bGUCharacterCS == null || !bGUCharacterCS.IsPlayingRootMotion())
		{
			return;
		}
		bool flag = false;
		FVector fVector = FVector.OneVector;
		FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
		if (AMScaleAxis == EAMScaleRateAxis.AxisZLanding)
		{
			FVector fVector3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			FVector fVector4 = Owner.GetVelocity().GetSafeNormal() * LandingTraceLength;
			List<EObjectTypeQuery> objectTypes = new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery1 };
			FHitResultSimple HitResult;
			int num = UBGUSelectUtil.LineTraceForObjects(Owner, fVector3, fVector3 + fVector4, objectTypes, DebugMode, out HitResult);
			if (num <= 0)
			{
				double num2 = MathLib.DegAcos((float)fVector4.Dot_VectorVector(new FVector(0.0, 0.0, -1.0)) / fVector4.Size());
				for (float num3 = 10f; (double)num3 < num2; num3 += 10f)
				{
					if (num > 0)
					{
						break;
					}
					FVector fVector5 = fVector4.RotateAngleAxis(num3, Owner.GetActorRightVector());
					num = UBGUSelectUtil.LineTraceForObjects(Owner, fVector3, fVector3 + fVector5, objectTypes, DebugMode, out HitResult);
				}
			}
			if (num <= 0)
			{
				num = UBGUSelectUtil.LineTraceForObjects(EndTrace: fVector3 + new FVector(0.0, 0.0, 0f - LandingTraceLength), WorldContextObject: Owner, StartTrace: fVector3, ObjectTypes: objectTypes, bDebug: DebugMode, HitResult: out HitResult);
			}
			if (num > 0)
			{
				flag = true;
				fVector2 = HitResult.HitLocation;
			}
		}
		else
		{
			switch (AMScaleType)
			{
			case EAMScaleType.UsePureScale:
				flag = false;
				fVector = new FVector(PureScaleValue);
				break;
			case EAMScaleType.ScaleForTarget:
			case EAMScaleType.UseSkillBaseTarget:
			{
				if (GetCurrentTarget(AMScaleType == EAMScaleType.UseSkillBaseTarget, out var TargetLoc) != null)
				{
					flag = true;
					fVector2 = TargetLoc;
				}
				else if (!DebugMode && GSGameplayCVar.CVar_NSDebug_ShowAMScaleDebugInfo.GetValueInGameThread() == 0)
				{
				}
				break;
			}
			case EAMScaleType.ScaleForSceneItem:
			{
				BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(bGUCharacterCS);
				if (readOnlyData == null)
				{
					break;
				}
				BGUSceneItemBase sceneItemCatch = readOnlyData.SceneItemCatch;
				if (sceneItemCatch != null)
				{
					flag = true;
					fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(sceneItemCatch);
					BUC_SceneItemCommData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(sceneItemCatch);
					if (readOnlyData2 != null)
					{
						fVector2 = readOnlyData2.TeleportTransform.GetLocation();
					}
				}
				break;
			}
			case EAMScaleType.ScaleForCachedPoint:
			{
				List<FVector> list = BGUFunctionLibraryCS.BGUGetCachedPointSet(bGUCharacterCS, CachedDataID);
				if (list.Count > 0)
				{
					flag = true;
					fVector2 = list[0];
				}
				else if (!DebugMode)
				{
					GSGameplayCVar.CVar_NSDebug_ShowAMScaleDebugInfo.GetValueInGameThread();
				}
				break;
			}
			}
		}
		if (flag)
		{
			if (AttackRangeLimit)
			{
				FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(BGUFuncLibSkillCS.BGUGetCastingSkillID(bGUCharacterCS), bGUCharacterCS);
				float num4 = (fVector2 - BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS)).Size();
				if (playerSkillCtrlDesc != null && playerSkillCtrlDesc.AttackRange < num4)
				{
					if (!DebugMode)
					{
						GSGameplayCVar.CVar_NSDebug_ShowAMScaleDebugInfo.GetValueInGameThread();
					}
					return;
				}
			}
			float x = bGUCharacterCS.GetActorScale3D().X;
			AMScaleMoveOffset *= x;
			AMScaleMoveOffsetZ *= x;
			bool enableDebug = DebugMode || GSGameplayCVar.CVar_NSDebug_ShowAMScaleDebugInfo.GetValueInGameThread() != 0;
			fVector = BGUFuncLibSkillCS.BGUCalcSkillMontageScaleRate(bGUCharacterCS, fVector2, NotifyBeginTime, NotifyEndTime, AMScaleMinRate, AMScaleMaxRate, AMScaleMoveOffset, AMScaleMoveOffsetZ, enableDebug);
		}
		float aMScaleMaxRate = MovementData.AMScaleMaxRate;
		FVector meshLocalRot = GetMeshLocalRot(bGUCharacterCS);
		if (AMScaleAxis == EAMScaleRateAxis.AxisX || AMScaleAxis == EAMScaleRateAxis.All)
		{
			fVector.X = ((aMScaleMaxRate > 0f) ? FMath.Min(fVector.X, aMScaleMaxRate) : fVector.X);
			FVector scaleVec = meshLocalRot * fVector.X;
			SetAMSectionScaleAxisRate(scaleVec, TotalDuration, EAMScaleRateAxis.AxisX);
		}
		if (AMScaleAxis == EAMScaleRateAxis.AxisZ || AMScaleAxis == EAMScaleRateAxis.All || AMScaleAxis == EAMScaleRateAxis.AxisZLanding)
		{
			fVector.Z = ((aMScaleMaxRate > 0f) ? FMath.Min(fVector.Z, aMScaleMaxRate) : fVector.Z);
			FVector fVector6 = new FVector(1f);
			fVector6.Z = fVector.Z;
			FVector scaleVec2 = fVector6;
			SetAMSectionScaleAxisRate(scaleVec2, TotalDuration, EAMScaleRateAxis.AxisZ);
		}
		if (AMScaleAxis == EAMScaleRateAxis.AxisY)
		{
			fVector.Y = ((aMScaleMaxRate > 0f) ? FMath.Min(fVector.Y, aMScaleMaxRate) : fVector.Y);
			FVector fVector6 = new FVector(1f);
			fVector6.Y = fVector.Y;
			FVector scaleVec3 = fVector6;
			SetAMSectionScaleAxisRate(scaleVec3, TotalDuration, EAMScaleRateAxis.AxisY);
		}
		if (AMScaleAxis == EAMScaleRateAxis.AllByScaleRateAxisX)
		{
			fVector.X = ((aMScaleMaxRate > 0f) ? FMath.Min(fVector.X, aMScaleMaxRate) : fVector.X);
			FVector scaleVec4 = new FVector(fVector.X);
			SetAMSectionScaleAxisRate(scaleVec4, TotalDuration, EAMScaleRateAxis.AllByScaleRateAxisX);
		}
		if ((DebugMode || GSGameplayCVar.CVar_NSDebug_ShowAMScaleDebugInfo.GetValueInGameThread() != 0) && flag)
		{
			USystemLibrary.DrawDebugSphere(bGUCharacterCS, fVector2, 100f, 20, FLinearColor.Orange, 20f, 10f);
			USystemLibrary.DrawDebugArrow(bGUCharacterCS, fVector2, fVector2 + new FVector(0.0, 0.0, 500.0), 30f, FLinearColor.Black, 20f, 20f);
		}
	}

	private void OnTeleport(AActor Querier, int TeleportType, int TeleportIntParam, string TeleportStrParam, string ActorSocketName, bool SelectRandom, float MinDistInRandom, bool IsKeepFacingCurTarget, int SelectType, bool bFindFloor)
	{
		switch (TeleportType)
		{
		case 0:
			OnTeleportBeginEQS(Querier, TeleportStrParam, SelectRandom);
			break;
		case 1:
			OnTeleportByGuidActorSocketPos(Querier, TeleportStrParam, ActorSocketName, IsKeepFacingCurTarget, bFindFloor);
			break;
		case 2:
			OnTeleportByTagActorSocketPos(Querier, TeleportStrParam, SelectRandom, MinDistInRandom, SelectType == 1, ActorSocketName, IsKeepFacingCurTarget, bFindFloor);
			break;
		case 3:
			OnTeleportToLastDeadUnitPosInFamily(Querier, ActorSocketName, IsKeepFacingCurTarget);
			break;
		case 4:
			OnTeleportToPointSet(Querier, TeleportIntParam, IsKeepFacingCurTarget);
			break;
		}
	}

	private void OnTeleportByGuidActorSocketPos(AActor Querier, string ActorGuid, string ActorSocketName, bool IsKeepFacingCurTarget, bool bFindFloor)
	{
		UWorld world = Querier.World;
		if (world == null)
		{
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(world, ActorGuid);
		if (actorByGuid == null)
		{
			return;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Querier);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid);
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(actorByGuid);
		ACharacter aCharacter = actorByGuid as ACharacter;
		if (aCharacter != null && aCharacter.Mesh != null)
		{
			FName inSocketName = new FName(ActorSocketName);
			fVector = aCharacter.Mesh.GetSocketLocation(inSocketName);
			newRotation = aCharacter.Mesh.GetSocketRotation(inSocketName);
		}
		if (IsKeepFacingCurTarget && aActor != null)
		{
			newRotation.Yaw = MathLib.FindLookAtRotation(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)).Yaw;
		}
		if (bFindFloor && Querier is ACharacter aCharacter2)
		{
			UCapsuleComponent capsuleComponent = aCharacter2.CapsuleComponent;
			float scaledCapsuleHalfHeight = capsuleComponent.GetScaledCapsuleHalfHeight();
			float scaledCapsuleRadius = capsuleComponent.GetScaledCapsuleRadius();
			FVector start = fVector + FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			FVector end = fVector - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(Owner, start, end, scaledCapsuleRadius, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, Querier, out var OutHitLocation))
			{
				fVector = OutHitLocation;
			}
		}
		BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(Owner, fVector, newRotation, bSweep: false, bTeleport: true, NeedReturnHitResult: false, bForceUpdate: true);
	}

	private void OnTeleportByTagActorSocketPos(AActor Querier, string ActorTag, bool bSelectRandom, float MinDistInRandom, bool bNearestOrFarthest, string ActorSocketName, bool IsKeepFacingCurTarget, bool bFindFloor)
	{
		if (Querier.World == null)
		{
			return;
		}
		AActor aActor = null;
		UGameplayStatics.GetAllActorsWithTag(Querier, new FName(ActorTag), out var OutActors);
		if (bSelectRandom)
		{
			if (MinDistInRandom > 0f)
			{
				for (int num = OutActors.Count - 1; num > -1; num--)
				{
					if (OutActors[num].GetDistanceTo(Querier) < MinDistInRandom)
					{
						OutActors.RemoveAt(num);
					}
				}
			}
			int index = MathLib.RandomIntInRange(0, OutActors.Count - 1);
			aActor = ((OutActors.Count != 0) ? OutActors[index] : null);
		}
		else if (bNearestOrFarthest)
		{
			float num2 = float.MaxValue;
			foreach (AActor item in OutActors)
			{
				float distanceTo = item.GetDistanceTo(Querier);
				if (distanceTo < num2)
				{
					num2 = distanceTo;
					aActor = item;
				}
			}
		}
		else
		{
			float num3 = -1f;
			foreach (AActor item2 in OutActors)
			{
				float distanceTo2 = item2.GetDistanceTo(Querier);
				if (distanceTo2 > num3)
				{
					num3 = distanceTo2;
					aActor = item2;
				}
			}
		}
		if (aActor == null)
		{
			return;
		}
		AActor aActor2 = BGUFunctionLibraryCS.BGUGetTarget(Querier);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor);
		ACharacter aCharacter = aActor as ACharacter;
		if (aCharacter != null && aCharacter.Mesh != null)
		{
			FName inSocketName = new FName(ActorSocketName);
			fVector = aCharacter.Mesh.GetSocketLocation(inSocketName);
			newRotation = aCharacter.Mesh.GetSocketRotation(inSocketName);
		}
		if (IsKeepFacingCurTarget && aActor2 != null)
		{
			newRotation.Yaw = MathLib.FindLookAtRotation(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor2)).Yaw;
		}
		if (bFindFloor && Querier is ACharacter aCharacter2)
		{
			UCapsuleComponent capsuleComponent = aCharacter2.CapsuleComponent;
			float scaledCapsuleHalfHeight = capsuleComponent.GetScaledCapsuleHalfHeight();
			float scaledCapsuleRadius = capsuleComponent.GetScaledCapsuleRadius();
			FVector start = fVector + FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			FVector end = fVector - FVector.UpVector * scaledCapsuleHalfHeight * 2.0;
			if (UGSE_TraceFuncLib.CharacterCapsuleTraceSingleByProfile(Owner, start, end, scaledCapsuleRadius, scaledCapsuleHalfHeight, B1GlobalFNames.Pawn, bTraceComplex: false, Querier, out var OutHitLocation))
			{
				fVector = OutHitLocation;
			}
		}
		BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(Owner, fVector, newRotation, bSweep: false, bTeleport: true, NeedReturnHitResult: false, bForceUpdate: true);
	}

	private void OnTeleportToLastDeadUnitPosInFamily(AActor Querier, string ActorSocketName, bool IsKeepFacingCurTarget)
	{
		UWorld world = Querier.World;
		if (world == null)
		{
			return;
		}
		CircusMember circusRootMember = CircusControlData.GetCircusRootMember(Querier);
		if (circusRootMember == null)
		{
			return;
		}
		string lastDeadUnit = CircusControlData.GetLastDeadUnit(circusRootMember.ActorGuid);
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(world, lastDeadUnit);
		if (actorByGuid == null)
		{
			return;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Querier);
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(actorByGuid);
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(actorByGuid);
		ACharacter aCharacter = actorByGuid as ACharacter;
		if (aCharacter != null && aCharacter.Mesh != null)
		{
			if (ActorSocketName != string.Empty)
			{
				FName inSocketName = new FName(ActorSocketName);
				fVector = aCharacter.Mesh.GetSocketLocation(inSocketName);
				newRotation = aCharacter.Mesh.GetSocketRotation(inSocketName);
			}
			if (aCharacter.CapsuleComponent != null && Querier is ACharacter aCharacter2)
			{
				fVector.Z -= aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
				fVector.Z += aCharacter2.CapsuleComponent.GetScaledCapsuleHalfHeight();
			}
		}
		if (IsKeepFacingCurTarget && aActor != null)
		{
			newRotation.Yaw = MathLib.FindLookAtRotation(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)).Yaw;
		}
		BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(Owner, fVector, newRotation, bSweep: false, bTeleport: true, NeedReturnHitResult: false, bForceUpdate: true);
	}

	private void OnTeleportToPointSet(AActor Querier, int PointSetID, bool IsKeepFacingCurTarget)
	{
		if (Querier.World == null || PointSetsData == null || !PointSetsData.PointQueneMap.ContainsKey(PointSetID) || PointSetsData.PointQueneMap[PointSetID].Count < 1)
		{
			return;
		}
		FVector fVector = PointSetsData.PointQueneMap[PointSetID][0];
		FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
		if (PointSetsData.PointQueneMap_Rot.ContainsKey(PointSetID) && PointSetsData.PointQueneMap_Rot[PointSetID].Count > 0)
		{
			newRotation = PointSetsData.PointQueneMap_Rot[PointSetID][0];
		}
		if (IsKeepFacingCurTarget)
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Querier);
			if (aActor != null)
			{
				newRotation.Yaw = MathLib.FindLookAtRotation(fVector, BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)).Yaw;
			}
		}
		BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(Owner, fVector, newRotation, bSweep: false, bTeleport: true, NeedReturnHitResult: false, bForceUpdate: true);
	}

	private void OnTeleportBeginEQS(UObject Querier, string EQSPath, bool SelectRandom)
	{
		UEnvQuery uEnvQuery = PreloadAssetMgr.TryGetCachedResourceObj<UEnvQuery>(EQSPath, ELoadResourceType.SyncLoadAndCache);
		if (uEnvQuery != null)
		{
			base.BGSEventCollection.Evt_BGS_EQSObjRun.Invoke(uEnvQuery, Owner, EBGURunEQSObjReason.Teleport, new FGSEQSExParam
			{
				ExParam_Bool = SelectRandom
			}, OnEQSFinish);
		}
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (ExParam.RunEQSObjReason != EBGURunEQSObjReason.Teleport)
		{
			return;
		}
		UGSE_EngineFuncLib.LogDbg($"传送可选点数量: {Result.Count}", bPrintScreen: true);
		if (Result.Count != 0)
		{
			int index = 0;
			if (ExParam.ExParam_Bool)
			{
				index = UB1Util.GetRandomNumberInt(0, Result.Count - 1);
			}
			ACharacter ownerCharacter = CharacterComps.OwnerCharacter;
			FVector newLocation = Result[index];
			FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(ownerCharacter);
			BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(Owner, newLocation, newRotation, bSweep: false, bTeleport: true, NeedReturnHitResult: false, bForceUpdate: true);
		}
	}

	private void OnMoveWithAnimMontage_Predict(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason, GSPredictionKey PredictionKey)
	{
		OnMoveWithAnimMontage(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason, null);
	}

	private void OnMoveWithAnimMontage(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason, GSPredictionKey PredictionKey)
	{
		if (PredictionKey == null)
		{
			OnMoveWithAnimMontage(Montage, Scale, PlayTimeRate, MontagePosOffset, StartSectionName, Reason);
		}
	}

	private void OnMoveWithAnimMontage(UAnimMontage Montage, float Scale, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason)
	{
		FName montageSlotName = UGSE_AnimFuncLib.GetMontageSlotName(Montage, 0);
		if (!montageSlotName.Equals(B1GlobalFNames.UpperBody) && !montageSlotName.Equals(B1GlobalFNames.LeftArm) && !montageSlotName.Equals(B1GlobalFNames.RightArm) && !UGSE_AnimFuncLib.MontageIsValidAdditive(Montage))
		{
			SwitchMoverIfNeeded<BGU_AnimMontageMoveMode>(bAlwaysGenIdx: true);
			if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
			{
				bGU_AnimMontageMoveMode.BeginMove(Montage, PlayTimeRate, MontagePosOffset, StartSectionName, Reason);
			}
		}
		else
		{
			USkeletalMeshComponent uSkeletalMeshComponent = (GetOwner() as ACharacter)?.Mesh;
			if (uSkeletalMeshComponent != null)
			{
				BGS_GSEventCollection.Get(Owner).Evt_BGS_CreateBGUPlayMontageCallbackProxy.Invoke(Reason, uSkeletalMeshComponent, Montage, PlayTimeRate, MontagePosOffset, StartSectionName);
			}
		}
	}

	private void OnSkillWithAnimMontage_Predict(UAnimMontage Montage, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason, GSPredictionKey PredictionKey)
	{
		OnSkillWithAnimMontage(Montage, PlayTimeRate, MontagePosOffset, StartSectionName, Reason, null);
	}

	private void OnSkillWithAnimMontage(UAnimMontage Montage, float PlayTimeRate, float MontagePosOffset, FName StartSectionName, EMontageBindReason Reason, GSPredictionKey PredictionKey)
	{
		if (PredictionKey == null)
		{
			SwitchMoverIfNeeded<BGU_AnimMontageMoveMode>(bAlwaysGenIdx: false);
			if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
			{
				bGU_AnimMontageMoveMode.BeginMove(Montage, PlayTimeRate, MontagePosOffset, StartSectionName, Reason);
			}
		}
	}

	private void OnSetOffsetRotationAxis(FVector OffsetRotationAxis)
	{
		if (MoveModes.ActiveMover != null)
		{
			if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
			{
				bGU_AnimMontageMoveMode.SetOffsetRotationAxis(OffsetRotationAxis);
			}
			else if (MoveModes.ActiveMover is BGU_AttackRotateMoveMode bGU_AttackRotateMoveMode)
			{
				bGU_AttackRotateMoveMode.SetOffsetRotationAxis(OffsetRotationAxis);
			}
		}
	}

	private void OnSetOffsetRotationAxisComp(USceneComponent RotationAxisComp)
	{
		if (MoveModes.ActiveMover != null)
		{
			if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
			{
				bGU_AnimMontageMoveMode.SetOffsetRotationAxisComp(RotationAxisComp);
			}
			else if (MoveModes.ActiveMover is BGU_AttackRotateMoveMode bGU_AttackRotateMoveMode)
			{
				bGU_AttackRotateMoveMode.SetOffsetRotationAxisComp(RotationAxisComp);
			}
		}
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter != null)
		{
			MoveStop();
			aCharacter.StopAnimMontage(null);
			aCharacter.CharacterMovement.StopMovementImmediately();
		}
		OrientRotationToMovementHandleID = 0u;
	}

	private void OnTeleportMoveByTrans(FTransform TeleportTrans)
	{
		ACharacter ownerCharacter = CharacterComps.OwnerCharacter;
		BGUFuncLibActorTransformCS.BGUGetActorLocation(ownerCharacter);
		FVector location = TeleportTrans.GetLocation();
		FRotator destRotation = TeleportTrans.GetRotation().Rotator();
		ownerCharacter.Teleport(location, destRotation);
	}

	private void OnMatchingPositionMove(in FMatchingPositionMoveParam Param)
	{
		FTransform targetTrans = Param.TargetTrans;
		if (!targetTrans.IsValid())
		{
			Param.AIPathMoveCallbackFunc?.Invoke(bSuccess: false);
			Param.InterpMoveCallbackFunc?.Invoke(bSuccess: false);
			return;
		}
		EBGUMoveAIType moveAIType = (Param.bFacingTargetRotation ? EBGUMoveAIType.KeepFacingTarget : EBGUMoveAIType.None);
		int lastMoveIdx = ActionRequestData.GetLastMoveIdx();
		OnAIMoveTo(targetTrans.GetLocation(), null, Param.MoveSpeedType, Param.AcceptableRadius, moveAIType, Param.bIncludeSelfRadius, IncludeTargetRadius: false);
		int lastMoveIdx2 = ActionRequestData.GetLastMoveIdx();
		if (lastMoveIdx2 > 0 && lastMoveIdx2 != lastMoveIdx)
		{
			MovementData.bMatchingPosition = true;
			MovementData.MatchingPosMoveIdx = lastMoveIdx2;
			base.BUSEventCollection.Evt_AIPathMoveComplete += new Del_AIPathMoveComplete(OnMatchingPositionAIMoveComplete);
			if (Param.bFacingTargetRotation)
			{
				OnForceSetAIMoveFacingTargetRotation(targetTrans.Rotator());
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.ShooterModeTrigger, -1f);
			}
			MovementData.MatchingPosAIPathMoveCallback = Param.AIPathMoveCallbackFunc;
			MovementData.MatchingPosInterpMoveCallback = Param.InterpMoveCallbackFunc;
			bool flag = true;
			BUMatchingPosTypeTemplate matchingPosTypeTemplate = BGW_EffectTemplateList.Get(GetOwner()).GetMatchingPosTypeTemplate(Param.MatchingPosType);
			if (matchingPosTypeTemplate != null)
			{
				flag = matchingPosTypeTemplate.TriggerMatchingPos(GetOwner(), in Param);
			}
			if (!flag)
			{
				MoveStop();
				MovementData.bMatchingPosition = false;
			}
		}
		else
		{
			Param.AIPathMoveCallbackFunc?.Invoke(bSuccess: false);
			Param.InterpMoveCallbackFunc?.Invoke(bSuccess: false);
		}
	}

	private void OnMatchingPositionAIMoveComplete(int MoveIdx, EPathFollowingResult Result)
	{
		if (MovementData.MatchingPosMoveIdx != MoveIdx)
		{
			return;
		}
		base.BUSEventCollection.Evt_ClearMoveToTarget.Invoke();
		if (UnitStateData.HasState(EBGUUnitState.ShooterMode))
		{
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.ShooterModeTrigger, 0.1f);
		}
		base.BUSEventCollection.Evt_AIPathMoveComplete -= new Del_AIPathMoveComplete(OnMatchingPositionAIMoveComplete);
		if (Result != EPathFollowingResult.Success)
		{
			MovementData.bMatchingPosition = false;
			MovementData.MatchingPosAIPathMoveCallback?.Invoke(bSuccess: false);
			MovementData.MatchingPosInterpMoveCallback?.Invoke(bSuccess: false);
			if (!MovementData.bMatchingPosition)
			{
				MovementData.MatchingPosMoveIdx = -1;
				MovementData.MatchingPosAIPathMoveCallback = null;
				MovementData.MatchingPosInterpMoveCallback = null;
			}
			return;
		}
		MovementData.MatchingPosAIPathMoveCallback?.Invoke(bSuccess: true);
		if (MovementData.IM_TotalTime > 0f)
		{
			MovementData.IM_EnableMove = true;
			MovementData.MatchingPosMoveIdx = -1;
			return;
		}
		MovementData.IM_EnableMove = false;
		MovementData.bMatchingPosition = false;
		MovementData.MatchingPosInterpMoveCallback?.Invoke(bSuccess: true);
		if (!MovementData.bMatchingPosition)
		{
			MovementData.MatchingPosAIPathMoveCallback = null;
			MovementData.MatchingPosInterpMoveCallback = null;
		}
	}

	private void OnSetMatchingPosInterpInfo(FTransform TargetTrans, float InterpTime, bool bEnableZAxisMove)
	{
		MovementData.IM_EnableMove = false;
		MovementData.IM_TargetLoction = TargetTrans.GetLocation();
		MovementData.IM_TargetRotation = TargetTrans.Rotator();
		MovementData.IM_TotalTime = InterpTime;
		MovementData.IM_EnableZAxisMove = bEnableZAxisMove;
	}

	private void OnInterpolationMove(FVector TargetLoc, FRotator TargetRot, float TotalTime, bool EnableZAxisMove, bool IgnoreLocation, bool IgnoreRotation, bool bForceUpdate)
	{
		MovementData.IM_EnableMove = true;
		MovementData.IM_TotalTime = TotalTime;
		MovementData.IM_TargetLoction = TargetLoc;
		MovementData.IM_TargetRotation = TargetRot;
		MovementData.IM_EnableZAxisMove = EnableZAxisMove;
		MovementData.IM_IgnoreLocation = IgnoreLocation;
		MovementData.IM_IgnoreRotation = IgnoreRotation;
		TickForInterpolationMove(0.016f, bForceUpdate);
	}

	private void OnSetSplineFlyControlInfo(BGUSplineActor SplineActor, FGSSplineFlyMoveInfo SplineFlyMoveInfo)
	{
		if (!(SplineActor == null))
		{
			MovementData.FlyControlSpline = SplineActor.SplineComp;
			MovementData.SplineFlyWaitPointDict = SplineFlyMoveInfo.WaitPointDict;
			MovementData.SplineFlyWaitTime = -1f;
			MovementData.TransitionInterpSpeed = 2f;
			MovementData.RotationInterpSpeed = 2f;
		}
	}

	private void OnSetNpcGuideSplineMoveInfo(string SplineGuid, bool NeedSwitchSpeedByDistanceToPlayer, EAIMoveSpeedType SplineMoveSpeed, float MaxDistance_Sprint, float MaxDistance_Run, float MaxDistance_Jog, float DistanceBuffer)
	{
		MovementData.NpcGuideSplineGuid = SplineGuid;
		MovementData.NeedSwitchSpeedByDistanceToPlayer = NeedSwitchSpeedByDistanceToPlayer;
		MovementData.SplineMoveSpeed = SplineMoveSpeed;
		MovementData.MaxDistance_Sprint = MaxDistance_Sprint;
		MovementData.MaxDistance_Run = MaxDistance_Run;
		MovementData.MaxDistance_Jog = MaxDistance_Jog;
		MovementData.DistanceBuffer = DistanceBuffer;
	}

	private void OnAISpiderMoveTo(FVector TargetPos, FVector TargetNormal, ESpiderNavPositionType TargetPosType, float AcceptableRadius, EAIMoveSpeedType SplineMoveSpeed)
	{
		MovementData.AISpiderMovePath.Clear();
		MovementData.AISpiderMoveTargetPos = TargetPos;
		MovementData.AISpiderMoveTargetNormal = TargetNormal;
		MovementData.AISpiderMoveTargetPosType = TargetPosType;
		MovementData.AISpiderMoveSpeed = SplineMoveSpeed;
		MovementData.AISpiderMoveAcceptableRadius = AcceptableRadius;
		MovementData.IsSpiderMoveReached = false;
	}

	protected void TickMoveMode()
	{
		if (MoveModes.ActiveMover != null)
		{
			if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.FlyControl && !SimpleStateData.HasSimpleState(EBGUSimpleState.FlyControlMode))
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.CloudMove && !SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.TurretRotate && !TurretControlData.bEnableTurretRotate)
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.JumpMove && !UnitStateData.HasState(EBGUUnitState.JumpMoving))
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.SplineFlyControl && !MovementData.IsMoveModeActive(EBGUMoveMode.SplineFlyControl))
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.GlideMove && !UnitStateData.HasState(EBGUUnitState.GlideMoving))
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.ParkourMove && !ParkourMoveData.IsPakourMoving)
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.NpcGuideSplineMove && !MovementData.IsMoveModeActive(EBGUMoveMode.NpcGuideSplineMove))
			{
				MoveStop();
			}
			else if (MoveModes.ActiveMover.GetMoveMode() == EBGUMoveMode.AISpiderMove && !MovementData.IsMoveModeActive(EBGUMoveMode.AISpiderMove))
			{
				MoveStop();
			}
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.FlyControlMode))
		{
			SwitchMoverIfNeeded<BGU_FlyControlMoveMode>(bAlwaysGenIdx: false);
		}
		else if (SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
		{
			SwitchMoverIfNeeded<BGU_CloudMoveMode>(bAlwaysGenIdx: false);
		}
		else if (TurretControlData != null && TurretControlData.bEnableTurretRotate)
		{
			SwitchMoverIfNeeded<BGU_TurretRotateMoveMode>(bAlwaysGenIdx: false);
		}
		else if (UnitStateData.HasState(EBGUUnitState.JumpMoving))
		{
			SwitchMoverIfNeeded<BGU_JumpMoveMode>(bAlwaysGenIdx: false);
		}
		else if (MovementData.IsMoveModeActive(EBGUMoveMode.SplineFlyControl))
		{
			SwitchMoverIfNeeded<BGU_SplineFlyControlMoveMode>(bAlwaysGenIdx: false);
		}
		else if (ParkourMoveData != null && ParkourMoveData.IsPakourMoving)
		{
			SwitchMoverIfNeeded<BGU_ParkourMoveMode>(bAlwaysGenIdx: false);
		}
		else if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			SwitchMoverIfNeeded<BGU_GlideMoveMode>(bAlwaysGenIdx: false);
		}
		else if (MovementData.IsMoveModeActive(EBGUMoveMode.RelativeFloatMove))
		{
			SwitchMoverIfNeeded<BGU_RelativeFloatMoveMode>(bAlwaysGenIdx: false);
		}
		else if (MovementData.IsMoveModeActive(EBGUMoveMode.NpcGuideSplineMove))
		{
			SwitchMoverIfNeeded<BGU_NpcGuideSplineMoveMode>(bAlwaysGenIdx: false);
		}
		else if (MovementData.IsMoveModeActive(EBGUMoveMode.AISpiderMove))
		{
			SwitchMoverIfNeeded<BGU_AISpiderMoveMode>(bAlwaysGenIdx: false);
		}
	}

	protected void TickSplineFlyDistance(float DeltaTime)
	{
		if (MoveModes.ActiveMover == null || MoveModes.ActiveMover.GetMoveMode() != EBGUMoveMode.SplineFlyControl)
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.SplineFlyWaiting))
			{
				MovementData.SplineFlyDistance = 0f;
				MovementData.CurSplineFlyPoint = 0;
				MovementData.SplineFlyWaitTime = -1f;
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.SplineFlyWaiting, IsRemove: true);
			}
		}
		else if (!SimpleStateData.HasSimpleState(EBGUSimpleState.SplineFlyWaiting))
		{
			if (MovementData.SplineFlyWaitTime > 0f)
			{
				MovementData.SplineFlyWaitTime = -1f;
				MovementData.SplineFlyDistance += MovementData.SplineFlyWaitPointDict[MovementData.LastSplineFlyPoint].ForwardSplineRangeAfterWaiting;
			}
			MovementData.SplineFlyDistance += CppCharacterMovementComp.MaxFlySpeed * SplineFlyMoveData.CurFlySpeedRate * DeltaTime;
			if (!MovementData.FlyControlSpline.IsNullOrDestroyed() && MovementData.SplineFlyDistance > MovementData.FlyControlSpline.GetDistanceAlongSplineAtSplinePoint(MovementData.CurSplineFlyPoint))
			{
				if (MovementData.SplineFlyWaitPointDict != null && MovementData.SplineFlyWaitPointDict.ContainsKey(MovementData.CurSplineFlyPoint))
				{
					base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.SplineFlyWaiting);
					FGSSplineFlyMoveWaitPoint fGSSplineFlyMoveWaitPoint = MovementData.SplineFlyWaitPointDict[MovementData.CurSplineFlyPoint];
					if (fGSSplineFlyMoveWaitPoint.IsUnlimitedNeedWaitTime)
					{
						MovementData.SplineFlyWaitTime = 1f;
					}
					else
					{
						MovementData.SplineFlyWaitTime = fGSSplineFlyMoveWaitPoint.WaitTime;
					}
					MovementData.TransitionInterpSpeed = fGSSplineFlyMoveWaitPoint.TransitionInterpSpeed;
					MovementData.RotationInterpSpeed = fGSSplineFlyMoveWaitPoint.RotationInterpSpeed;
					if (fGSSplineFlyMoveWaitPoint.WaitAM != null)
					{
						BGUFuncLibAnim.BGUActorTryPlayMontage(GetOwner(), fGSSplineFlyMoveWaitPoint.WaitAM, FName.None);
					}
				}
				int num = (MovementData.FlyControlSpline.IsClosedLoop() ? (MovementData.FlyControlSpline.GetNumberOfSplinePoints() + 1) : MovementData.FlyControlSpline.GetNumberOfSplinePoints());
				MovementData.LastSplineFlyPoint = MovementData.CurSplineFlyPoint;
				MovementData.CurSplineFlyPoint = (MovementData.CurSplineFlyPoint + 1) % num;
			}
			if (MovementData.FlyControlSpline != null && MovementData.FlyControlSpline.IsClosedLoop() && MovementData.SplineFlyDistance > MovementData.FlyControlSpline.GetSplineLength())
			{
				MovementData.SplineFlyDistance %= MovementData.FlyControlSpline.GetSplineLength();
			}
		}
		else if (!MovementData.SplineFlyWaitPointDict[MovementData.LastSplineFlyPoint].IsUnlimitedNeedWaitTime)
		{
			MovementData.SplineFlyWaitTime -= DeltaTime;
			if (MovementData.SplineFlyWaitTime < 0f)
			{
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.SplineFlyWaiting, IsRemove: true);
				MovementData.SplineFlyDistance += MovementData.SplineFlyWaitPointDict[MovementData.LastSplineFlyPoint].ForwardSplineRangeAfterWaiting;
			}
		}
	}

	private void OnPlayRotAM_ByCamRotBegin(UAnimMontage TurnR_AM, UAnimMontage TurnL_AM, float BlendInTime, float BlendOutTime, float AngleThreshold, float TurnSpd, float RotateWithCamSpeed, ERotTypeInSmallAngle RotTypeInSmallAngle, ERotTypeInLargeAngle RotTypeInLargeAngle)
	{
		if (!MovementData.PlayRotAMByCamRot_Enable && !(TurnR_AM == null) && (!(TurnL_AM == null) || !(AngleThreshold < 180f)))
		{
			MovementData.PlayRotAMByCamRot_Enable = true;
			MovementData.PlayRotAMByCamRot_TurnR_AM = TurnR_AM;
			MovementData.PlayRotAMByCamRot_TurnL_AM = TurnL_AM;
			MovementData.PlayRotAMByCamRot_BlendInTime = BlendInTime;
			MovementData.PlayRotAMByCamRot_BlendOutTime = BlendOutTime;
			MovementData.PlayRotAMByCamRot_TurnSpeed = TurnSpd;
			MovementData.PlayRotAMByCamRot_RotateWithCamSpeed = RotateWithCamSpeed;
			MovementData.PlayRotAMByCamRot_AngleThreshold = AngleThreshold;
			MovementData.RotTypeInSmallAngle = RotTypeInSmallAngle;
			MovementData.RotTypeInLargeAngle = RotTypeInLargeAngle;
		}
	}

	private void OnPlayRotAM_ByCamRotEnded()
	{
		MovementData.PlayRotAMByCamRot_Enable = false;
		MovementData.PlayRotAMByCamRot_TurnR_AM = null;
		MovementData.PlayRotAMByCamRot_TurnL_AM = null;
		MovementData.PlayRotAMByCamRot_BlendInTime = 0f;
		MovementData.PlayRotAMByCamRot_BlendOutTime = 0f;
		MovementData.PlayRotAMByCamRot_TurnSpeed = 0f;
		MovementData.PlayRotAMByCamRot_RotateWithCamSpeed = 0f;
		MovementData.PlayRotAMByCamRot_AngleThreshold = 0f;
		MovementData.RotTypeInSmallAngle = ERotTypeInSmallAngle.None;
		MovementData.RotTypeInLargeAngle = ERotTypeInLargeAngle.None;
		base.BUSEventCollection.Evt_SetUpperBodyAO.Invoke(Enable: false, EBTTargetType.None);
		base.BUSEventCollection.Evt_SetAnimHumanoidAMMatryoshka.Invoke(0f);
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (!bGUCharacterCS.IsNullOrDestroyed())
		{
			UAnimInstance animInstance = bGUCharacterCS.Mesh.GetAnimInstance();
			if (animInstance != null && MovementData.PlayRotAMByCamRot_CurRotAM != null)
			{
				animInstance.Montage_Stop(0f, MovementData.PlayRotAMByCamRot_CurRotAM);
			}
		}
		MovementData.PlayRotAMByCamRot_CurRotAM = null;
	}

	private void OnSetMovementInput(FVector Direction, float Value, bool FromSvr)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter != null && aCharacter.IsLocallyControlled())
		{
			aCharacter.AddMovementInput(Direction, Value);
		}
	}

	private void OnSetMoveModeActive(EBGUMoveMode MoveMode, bool SetActive)
	{
		if (MovementData.MoveModeActivation.ContainsKey(MoveMode))
		{
			MovementData.MoveModeActivation[MoveMode] = SetActive;
		}
		else
		{
			MovementData.MoveModeActivation.Add(MoveMode, SetActive);
		}
	}

	private void OnSwitchMoveAIType(EBGUMoveAIType MoveAIType)
	{
		MovementData.MoveAIType = MoveAIType;
		bool value = MovementData.MoveAIType != EBGUMoveAIType.KeepFacingTarget && MovementData.MoveAIType != EBGUMoveAIType.FacingVelocity;
		if (OrientRotationToMovementHandleID == 0)
		{
			base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value);
			OrientRotationToMovementHandleID = PropMgrData.GetLastHandleID();
		}
		else
		{
			base.BUSEventCollection.Evt_SetBoolProperty.Invoke(EPropType.Movement_OrientRotationToMovement, value, OrientRotationToMovementHandleID);
		}
	}

	private void OnAIChangeCrowdParam(float SeparationWeight, float CollisionQueryRange, float PathOptimizationRange, EUnitAICrowdQualityLevel AvoidanceQualityLevel)
	{
		if (CrowdFollowComp != null)
		{
			FUStAICrowdDetourLevelConfigDesc unitAICrowdDetourlevelConfigDesc = BGW_GameDB.GetUnitAICrowdDetourlevelConfigDesc(AIData.DetourCrowdType);
			float fSeparationWeight = ((SeparationWeight > 0f) ? SeparationWeight : unitAICrowdDetourlevelConfigDesc.SeparationWeight);
			float fCollisionQueryRange = ((CollisionQueryRange > 0f) ? CollisionQueryRange : unitAICrowdDetourlevelConfigDesc.CollisionQueryRange);
			float fPathOptimizationRange = ((PathOptimizationRange > 0f) ? PathOptimizationRange : unitAICrowdDetourlevelConfigDesc.PathOptimizationRange);
			CrowdFollowComp.SetCrowdFollowingParam(fSeparationWeight, fCollisionQueryRange, fPathOptimizationRange, (int)AvoidanceQualityLevel);
		}
	}

	private void OnAIResetCrowdParam()
	{
		if (CrowdFollowComp != null)
		{
			FUStAICrowdDetourLevelConfigDesc unitAICrowdDetourlevelConfigDesc = BGW_GameDB.GetUnitAICrowdDetourlevelConfigDesc(AIData.DetourCrowdType);
			CrowdFollowComp.SetCrowdFollowingParam(unitAICrowdDetourlevelConfigDesc.SeparationWeight, unitAICrowdDetourlevelConfigDesc.CollisionQueryRange, unitAICrowdDetourlevelConfigDesc.PathOptimizationRange, (int)unitAICrowdDetourlevelConfigDesc.UnitAICrowdQualityLevel);
		}
	}

	private void OnMoveWithAnimBodySeparation()
	{
		if (MovementData.MontageInstanceIDWithBodySeparation == -1)
		{
			ACharacter aCharacter = Owner as ACharacter;
			if (!(aCharacter == null))
			{
				MovementData.MontageInstanceIDWithBodySeparation = UGSE_AnimFuncLib.GetCurrentActiveMontageInstanceID(aCharacter);
				UGSE_AnimFuncLib.DisableMontageRootMotionByInstanceID(aCharacter, MovementData.MontageInstanceIDWithBodySeparation);
			}
		}
	}

	private void EnableBlendAnimRootMotion(UAnimMontage Montage)
	{
		if (!(Montage == null))
		{
			MovementData.CurrentActiveMontage = Montage;
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_MovementSystem:OnAIPathMoveModeMoveComplete")]
	public void OnAIPathMoveModeMoveComplete(int MoveRequestID, EPathFollowingResult Result)
	{
		if (MoveModes.ActiveMover is BGU_AIPathMoveMode bGU_AIPathMoveMode)
		{
			bGU_AIPathMoveMode.OnAIPathMoveComplete(MoveRequestID, Result);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_MovementSystem:AIFlyPathMoveMode_Pathfinding_OnFinish")]
	public void AIFlyPathMoveMode_Pathfinding_OnFinish(FDoNNavigationQueryData Data)
	{
		if (MoveModes.ActiveMover is BGU_AIFlyPathMoveMode bGU_AIFlyPathMoveMode)
		{
			bGU_AIFlyPathMoveMode.Pathfinding_OnFinish(ref Data);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_MovementSystem:AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert")]
	public void AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert(FDonNavigationDynamicCollisionPayload Data)
	{
		if (MoveModes.ActiveMover is BGU_AIFlyPathMoveMode bGU_AIFlyPathMoveMode)
		{
			bGU_AIFlyPathMoveMode.Pathfinding_OnDynamicCollisionAlert(in Data);
		}
	}

	internal void MakeNoise()
	{
		CharacterComps.OwnerCharacter.PawnMakeNoise(1f, BGUFuncLibActorTransformCS.BGUGetActorLocation(CharacterComps.OwnerCharacter), bUseNoiseMakerLocation: false, CharacterComps.OwnerCharacter);
	}

	internal bool CheckCanRun()
	{
		return BGUFunctionLibraryCS.BGUCanMoveRun(GetOwner());
	}

	internal bool CheckCanRotate()
	{
		return BGUFunctionLibraryCS.BGUCanMoveRotate(GetOwner());
	}

	private void OnPlayMontageCallBack(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		switch (State)
		{
		case EMontageCallbackState.OnBlendOut:
			if (MoveModes.ActiveMover is BGU_AnimMontageMoveMode bGU_AnimMontageMoveMode)
			{
				bGU_AnimMontageMoveMode.OnMontageBlendingOut(Montage);
			}
			EnableBlendAnimRootMotion(Montage);
			break;
		case EMontageCallbackState.OnCompleted:
		case EMontageCallbackState.OnInterrupted:
			MovementData.CurrentActiveMontage = null;
			if (!CharacterComps.OwnerCharacter.IsNullOrDestroyed() && CharacterComps.OwnerCharacter.Mesh != null)
			{
				CppCharacterMovementComp.EnableBlendAnimRootMotion = false;
			}
			break;
		}
	}

	private bool CheckCanTickTranform()
	{
		if (AITransformModifyBySplineData == null)
		{
			return false;
		}
		if (AITransformModifyBySplineData.bCanAdjust && AITransformModifyBySplineData.RemainTime > 1E-08f && AITransformModifyBySplineData.SplineActorRef != null && AITransformModifyBySplineData.SplineActorRef.IsValidLowLevelFast())
		{
			switch (AITransformModifyBySplineData.SourceType)
			{
			case ETransformBySplineType.None:
				return false;
			case ETransformBySplineType.ByBAIT:
				if (AITransformModifyBySplineData.BAITRef != null)
				{
					return AITransformModifyBySplineData.BAITRef.IsValidLowLevelFast();
				}
				return false;
			case ETransformBySplineType.ByBANS:
				if (AITransformModifyBySplineData.BANSRef != null)
				{
					return AITransformModifyBySplineData.BANSRef.IsValidLowLevelFast();
				}
				return false;
			default:
				return false;
			}
		}
		return false;
	}

	private void TickTransformModifyBySpline(float DeltaTime)
	{
		if (!CheckCanTickTranform())
		{
			return;
		}
		AActor owner = GetOwner();
		if (!AITransformModifyBySplineData.bCanAdjust)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
		FRotator current = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
		FVector newLocation = UMathLibrary.VInterpTo(fVector, AITransformModifyBySplineData.TargetTransform.GetLocation(), DeltaTime, 1f / AITransformModifyBySplineData.RemainTime);
		FRotator newRotation = AITransformModifyBySplineData.TargetTransform.GetRotation().Rotator();
		if (AITransformModifyBySplineData.RotateType == ETransformBySplineRotateType.RotateToTarget)
		{
			if (AITransformModifyBySplineData.Target != null)
			{
				newRotation = UMathLibrary.RInterpTo(current, MathLib.Conv_VectorToRotator(BGUFuncLibActorTransformCS.BGUGetActorLocation(AITransformModifyBySplineData.Target) - fVector), DeltaTime, 1f / AITransformModifyBySplineData.RemainTime);
			}
		}
		else
		{
			newRotation = UMathLibrary.RInterpTo(current, AITransformModifyBySplineData.TargetTransform.GetRotation().Rotator(), DeltaTime, 1f / AITransformModifyBySplineData.RemainTime);
		}
		newLocation.Z = fVector.Z;
		BGUFuncLibActorTransformCS.BGUSetActorLocationAndRotation(owner, newLocation, newRotation, bSweep: false, bTeleport: false);
		AITransformModifyBySplineData.RemainTime -= DeltaTime;
		if (AITransformModifyBySplineData.RemainTime < 1E-08f)
		{
			ClearTransformModifyBySplineData();
		}
	}

	private void ClearTransformModifyBySplineData()
	{
		if (AITransformModifyBySplineData.SourceType == ETransformBySplineType.ByBAIT && AINodeData.ActionType == EAINodeActionType.AdjustTransformBySpline)
		{
			base.BUSEventCollection.Evt_SetAINodeActionStop.Invoke();
		}
		AITransformModifyBySplineData.bShowDebug = false;
		AITransformModifyBySplineData.SplineGuid = default(FGameplayTag);
		AITransformModifyBySplineData.RemainTime = 0f;
		AITransformModifyBySplineData.Target = null;
		AITransformModifyBySplineData.bCanAdjust = false;
		AITransformModifyBySplineData.SplineActorRef = null;
		AITransformModifyBySplineData.BANSRef = null;
	}

	private ETransformBySplineType OnTransformBySplineDataReload()
	{
		if (Owner == null)
		{
			ClearTransformModifyBySplineData();
			return ETransformBySplineType.None;
		}
		BGUSplineActor bGUSplineActor = BGU_DataUtil.GetActorByGuid(Owner, AITransformModifyBySplineData.SplineGuid.TagName.ToString()) as BGUSplineActor;
		if (bGUSplineActor == null)
		{
			ClearTransformModifyBySplineData();
			return ETransformBySplineType.None;
		}
		if (AITransformModifyBySplineData.RemainTime <= 0f)
		{
			ClearTransformModifyBySplineData();
			return ETransformBySplineType.None;
		}
		AITransformModifyBySplineData.SplineActorRef = bGUSplineActor;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		AITransformModifyBySplineData.TargetTransform = AITransformModifyBySplineData.SplineActorRef.SplineComp.FindTransformClosestToWorldLocation(fVector, ESplineCoordinateSpace.World);
		FVector location = AITransformModifyBySplineData.TargetTransform.GetLocation();
		FRotator fRotator = AITransformModifyBySplineData.TargetTransform.GetRotation().Rotator();
		AActor target = AITransformModifyBySplineData.Target;
		switch (AITransformModifyBySplineData.RotateType)
		{
		case ETransformBySplineRotateType.RotateToSplineTangentByTargetSide:
			if (target != null && (BGUFuncLibActorTransformCS.BGUGetActorLocation(target) - fVector).GetSafeNormal2D().Dot_VectorVector(fRotator.Vector().GetSafeNormal2D()) < 0.0)
			{
				AITransformModifyBySplineData.TargetTransform = new FTransform((fRotator + new FRotator(0.0, 180.0, 0.0)).Quaternion(), location);
			}
			break;
		case ETransformBySplineRotateType.RotateToSplineTangentByCurSide:
			if (BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner).Vector().GetSafeNormal2D()
				.Dot_VectorVector(fRotator.Vector().GetSafeNormal2D()) < 0.0)
			{
				AITransformModifyBySplineData.TargetTransform = new FTransform((fRotator + new FRotator(0.0, 180.0, 0.0)).Quaternion(), location);
			}
			break;
		case ETransformBySplineRotateType.RotateToTarget:
			if (target == null)
			{
				ClearTransformModifyBySplineData();
				return ETransformBySplineType.None;
			}
			break;
		}
		if (AITransformModifyBySplineData.BANSRef != null)
		{
			if (AITransformModifyBySplineData.BANSRef.IsValidLowLevelFast())
			{
				AITransformModifyBySplineData.bCanAdjust = true;
				return ETransformBySplineType.ByBANS;
			}
		}
		else if (AITransformModifyBySplineData.BAITRef != null)
		{
			if (AITransformModifyBySplineData.BAITRef.IsValidLowLevelFast())
			{
				AITransformModifyBySplineData.bCanAdjust = true;
			}
			return ETransformBySplineType.ByBAIT;
		}
		ClearTransformModifyBySplineData();
		return ETransformBySplineType.None;
	}

	private void OnTransformBySplineChange(float _RemainTime, ETransformBySplineRotateType _RotateType, in AActor _Target, in FGameplayTag SplineGuid, bool bShowDebug = false, in BAIT_Base _BAITRef = null, in BANS_GSBase _BANSRef = null)
	{
		AITransformModifyBySplineData.SplineGuid = SplineGuid;
		AITransformModifyBySplineData.Target = _Target;
		AITransformModifyBySplineData.RemainTime = _RemainTime;
		AITransformModifyBySplineData.BANSRef = _BANSRef;
		AITransformModifyBySplineData.bShowDebug = bShowDebug;
		AITransformModifyBySplineData.BAITRef = _BAITRef;
		AITransformModifyBySplineData.RotateType = _RotateType;
		AITransformModifyBySplineData.SourceType = OnTransformBySplineDataReload();
	}

	private void OnTransformBySplineStop(in AActor _Target, in BAIT_Base _BAITRef = null, in BANS_GSBase _BANSRef = null)
	{
		if (!AITransformModifyBySplineData.bCanAdjust)
		{
			return;
		}
		if (_BAITRef != null)
		{
			if (_BAITRef == AITransformModifyBySplineData.BAITRef && _Target == AITransformModifyBySplineData.Target)
			{
				ClearTransformModifyBySplineData();
			}
		}
		else if (_BANSRef != null && _BANSRef == AITransformModifyBySplineData.BANSRef && _Target == AITransformModifyBySplineData.Target)
		{
			ClearTransformModifyBySplineData();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_MovementSystem:OnAIPathMoveModeMoveComplete")]
	private static void OnAIPathMoveModeMoveComplete__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_MovementSystem bUS_MovementSystem = GCHelper.Find<BUS_MovementSystem>(obj);
		int moveRequestID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, OnAIPathMoveModeMoveComplete_MoveRequestID_Offset));
		EPathFollowingResult result = EnumMarshaler<EPathFollowingResult>.FromNative(IntPtr.Add(buffer, OnAIPathMoveModeMoveComplete_Result_Offset), 0, OnAIPathMoveModeMoveComplete_Result_PropertyAddress.Address);
		bUS_MovementSystem.OnAIPathMoveModeMoveComplete(moveRequestID, result);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_MovementSystem:AIFlyPathMoveMode_Pathfinding_OnFinish")]
	private static void AIFlyPathMoveMode_Pathfinding_OnFinish__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_MovementSystem bUS_MovementSystem = GCHelper.Find<BUS_MovementSystem>(obj);
		FDoNNavigationQueryData data = FDoNNavigationQueryData.FromNative(IntPtr.Add(buffer, AIFlyPathMoveMode_Pathfinding_OnFinish_Data_Offset));
		bUS_MovementSystem.AIFlyPathMoveMode_Pathfinding_OnFinish(data);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_MovementSystem:AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert")]
	private static void AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_MovementSystem bUS_MovementSystem = GCHelper.Find<BUS_MovementSystem>(obj);
		FDonNavigationDynamicCollisionPayload data = FDonNavigationDynamicCollisionPayload.FromNative(IntPtr.Add(buffer, AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_Offset));
		bUS_MovementSystem.AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert(data);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_MovementSystem");
		PlayerCameraManager_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerCameraManager");
		PlayerCameraManager_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerCameraManager", Classes.FObjectProperty);
		CppCharacterMovementComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CppCharacterMovementComp");
		CppCharacterMovementComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CppCharacterMovementComp", Classes.FObjectProperty);
		CrowdFollowComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CrowdFollowComp");
		CrowdFollowComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CrowdFollowComp", Classes.FObjectProperty);
		OnAIPathMoveModeMoveComplete_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAIPathMoveModeMoveComplete");
		OnAIPathMoveModeMoveComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAIPathMoveModeMoveComplete_FunctionAddress);
		OnAIPathMoveModeMoveComplete_MoveRequestID_Offset = NativeReflection.GetPropertyOffset(OnAIPathMoveModeMoveComplete_FunctionAddress, "MoveRequestID");
		OnAIPathMoveModeMoveComplete_MoveRequestID_IsValid = NativeReflection.ValidatePropertyClass(OnAIPathMoveModeMoveComplete_FunctionAddress, "MoveRequestID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OnAIPathMoveModeMoveComplete_Result_PropertyAddress, OnAIPathMoveModeMoveComplete_FunctionAddress, "Result");
		OnAIPathMoveModeMoveComplete_Result_Offset = NativeReflection.GetPropertyOffset(OnAIPathMoveModeMoveComplete_FunctionAddress, "Result");
		OnAIPathMoveModeMoveComplete_Result_IsValid = NativeReflection.ValidatePropertyClass(OnAIPathMoveModeMoveComplete_FunctionAddress, "Result", Classes.FEnumProperty);
		OnAIPathMoveModeMoveComplete_IsValid = OnAIPathMoveModeMoveComplete_FunctionAddress != IntPtr.Zero && OnAIPathMoveModeMoveComplete_MoveRequestID_IsValid && OnAIPathMoveModeMoveComplete_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_MovementSystem:OnAIPathMoveModeMoveComplete", OnAIPathMoveModeMoveComplete_IsValid);
		AIFlyPathMoveMode_Pathfinding_OnFinish_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AIFlyPathMoveMode_Pathfinding_OnFinish");
		AIFlyPathMoveMode_Pathfinding_OnFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(AIFlyPathMoveMode_Pathfinding_OnFinish_FunctionAddress);
		NativeReflection.GetPropertyRef(ref AIFlyPathMoveMode_Pathfinding_OnFinish_Data_PropertyAddress, AIFlyPathMoveMode_Pathfinding_OnFinish_FunctionAddress, "Data");
		AIFlyPathMoveMode_Pathfinding_OnFinish_Data_Offset = NativeReflection.GetPropertyOffset(AIFlyPathMoveMode_Pathfinding_OnFinish_FunctionAddress, "Data");
		AIFlyPathMoveMode_Pathfinding_OnFinish_Data_IsValid = NativeReflection.ValidatePropertyClass(AIFlyPathMoveMode_Pathfinding_OnFinish_FunctionAddress, "Data", Classes.FStructProperty);
		AIFlyPathMoveMode_Pathfinding_OnFinish_IsValid = AIFlyPathMoveMode_Pathfinding_OnFinish_FunctionAddress != IntPtr.Zero && AIFlyPathMoveMode_Pathfinding_OnFinish_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_MovementSystem:AIFlyPathMoveMode_Pathfinding_OnFinish", AIFlyPathMoveMode_Pathfinding_OnFinish_IsValid);
		AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert");
		AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_ParamsSize = NativeReflection.GetFunctionParamsSize(AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_FunctionAddress);
		NativeReflection.GetPropertyRef(ref AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_PropertyAddress, AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_FunctionAddress, "Data");
		AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_Offset = NativeReflection.GetPropertyOffset(AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_FunctionAddress, "Data");
		AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_IsValid = NativeReflection.ValidatePropertyClass(AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_FunctionAddress, "Data", Classes.FStructProperty);
		AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_IsValid = AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_FunctionAddress != IntPtr.Zero && AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_MovementSystem:AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert", AIFlyPathMoveMode_Pathfinding_OnDynamicCollisionAlert_IsValid);
	}

	static BUS_MovementSystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MovementSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MovementSystem));
	}
}
