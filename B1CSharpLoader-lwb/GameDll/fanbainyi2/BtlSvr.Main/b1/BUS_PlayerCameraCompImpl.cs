using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.ConsoleVariableManager;
using b1.Plugins.GSEngineExtent;
using b1.Plugins.GSInput;
using BtlB1;
using BtlShare;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_PlayerCameraCompImpl : UActorCompBaseCS
{
	private AActor _target;

	private const bool bEnableThreadTick = true;

	private int CVarHandle;

	private bool HasSetCVar;

	private readonly string DLSS_SCENECOLOR_CVAR_NAME = "r.DOF.DLSS.SceneColor.TAA";

	private int LastUpdateViewPortWidth = -1;

	private int LastUpdateViewPortHeight = -1;

	private EGSForceRatioType LastUpdateForceRatioType;

	private BGUCharacterCS Player { get; set; }

	private BUS_SpringArmComponent SpringArmComponent { get; set; }

	private UCameraComponent CameraComponent { get; set; }

	private AActor Target
	{
		get
		{
			return _target;
		}
		set
		{
			_target = value;
			if (_target != null)
			{
				CameraState.bHasTarget = true;
			}
			else
			{
				CameraState.bHasTarget = false;
			}
		}
	}

	private USceneComponent SoulFocusSceneComponent { get; set; }

	private USceneComponent SoulFocusZSceneComponent { get; set; }

	private APlayerCameraManager PlayerCameraManager { get; set; }

	private ABGPPlayerController PlayerController { get; set; }

	private BUC_PlayerCameraData PlayerCameraData { get; set; }

	private IBUC_HardMoveData HardMoveData { get; set; }

	private IBUC_RollData RollData { get; set; }

	private BUC_CameraState CameraState => PlayerCameraData?.CameraState;

	private IBUC_BuffData PlayerBuffData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	private IBUC_SimpleStateData SimpleStateData { get; set; }

	private IBUC_TargetInfoData TargetInfoData { get; set; }

	private IBUC_JumpData JumpData { get; set; }

	private IBUC_ManualSplineMoveData ManualSplineMoveData { get; set; }

	private IBUC_MovementData MovementData { get; set; }

	private b1.IBPC_PlayerCameraData ControllerCameraData { get; set; }

	private IBPC_PlayerPerformData PlayerPerformData { get; set; }

	private IBPC_FoliageCameraFadeData FoliageCameraFadeData { get; set; }

	private IBPC_InputData InputData { get; set; }

	private IBIC_CheatData CheatData { get; set; }

	private BPS_GSEventCollection BPSEventCollection { get; set; }

	private BGW_SettingMgrV2 SettingMgr { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		PlayerCameraData = RequireWritableData<BUC_PlayerCameraData>();
		HardMoveData = RequireReadOnlyData<IBUC_HardMoveData, b1.BUC_HardMoveData>();
		RollData = RequireReadOnlyData<IBUC_RollData, BUC_RollData>();
		PlayerBuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		TargetInfoData = RequireReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>();
		JumpData = RequireReadOnlyData<IBUC_JumpData, b1.BUC_JumpData>();
		ManualSplineMoveData = RequireReadOnlyData<IBUC_ManualSplineMoveData, BUC_ManualSplineMoveData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		ControllerCameraData = RequireReadOnlyControledPlayerStateData<b1.IBPC_PlayerCameraData, BPC_PlayerCameraData>();
		PlayerPerformData = RequireReadOnlyControledPlayerStateData<IBPC_PlayerPerformData, BPC_PlayerPerformData>();
		FoliageCameraFadeData = RequireReadOnlyControledPlayerStateData<IBPC_FoliageCameraFadeData, BPC_FoliageCameraFadeData>();
		InputData = RequireReadOnlyControlledPlayerControlData<IBPC_InputData, BPC_InputData>();
		CheatData = RequireReadonlyGameInstanceData<IBIC_CheatData, BIC_CheatData>();
		base.BUSEventCollection.Evt_SetCameraArmMode += new Del_SetCameraArmMode(OnSetArmMode);
		base.BUSEventCollection.Evt_SetLockCameraArmMode += new Del_SetCameraArmMode(OnSetLockArmMode);
		base.BUSEventCollection.Evt_EnableCustomFOV += new Del_Void_Bool(OnEnableCustomFOV);
		base.BUSEventCollection.Evt_EnableCustomCamPitch += new Del_Void_BoolFloat(OnEnableCustomCameraPitch);
		base.BUSEventCollection.Evt_ForceSetFreeCameraArmLength += new Del_Void_Float(ForceSetFreeCameraArmLength);
		base.BUSEventCollection.Evt_DecreaseFreeCameraArmLength += new Del_Void_Float(DecreaseFreeCameraArmLength);
		base.BUSEventCollection.Evt_InputCameraTurnRight += new Del_InputMove(OnInputAxisTurnRight);
		base.BUSEventCollection.Evt_InputCameraLookUp += new Del_InputMove(OnInputAxisUp);
		base.BUSEventCollection.Evt_Camera_ManualLock += new Del_Void_ActorString(OnLockTarget);
		base.BUSEventCollection.Evt_Camera_ClearCamLock += new Del_Void(OnClearLock);
		base.BUSEventCollection.Evt_Camera_EnableGuiBeiCamera += new Del_Camera_EnableGuiBeiCamera(OnEnableGuiBeiCamera);
		base.BUSEventCollection.Evt_Camera_DisableGuiBeiCamera += new Del_Void(OnDisableGuiBeiCamera);
		base.BUSEventCollection.Evt_Camera_EnableAutoMoveTrail += new Del_Void_FVector(OnEnableAutoMoveTrail);
		base.BUSEventCollection.Evt_Camera_DisableAutoMoveTrail += new Del_Void(OnDisableAutoMoveTrail);
		base.BUSEventCollection.Evt_EnableCameraPitchCurve += new Del_FloatCurve(OnEnablePitchCurve);
		base.BUSEventCollection.Evt_DisableCameraPitchCurve += new Del_Void(OnDisablePitchCurve);
		base.BUSEventCollection.Evt_EnableCameraArmLengthCurve += new Del_FloatCurve(OnEnableArmLengthCurve);
		base.BUSEventCollection.Evt_DisableCameraArmLengthCurve += new Del_Void_Float(OnDisableArmLengthCurve);
		base.BUSEventCollection.Evt_EnableCameraSASOCurve += new Del_VectorCurve(OnEnableSASOCurve);
		base.BUSEventCollection.Evt_DisableCameraSASOCurve += new Del_Void_Float(OnDisableSASOCurve);
		base.BUSEventCollection.Evt_EnableCameraArmLocationZCurve += new Del_FloatCurve(OnEnableArmLocationZCurve);
		base.BUSEventCollection.Evt_DisableCameraArmLocationZCurve += new Del_Void_Float(OnDisableArmLocationZCurve);
		base.BUSEventCollection.Evt_SwitchFreeCameraMode += new Del_Void_FreeCameraMode(OnSwitchFreeCameraMode);
		base.BUSEventCollection.Evt_G4CameraTurnToLocation += new Del_Bool_Vector(OnCameraTurnBack);
		base.BUSEventCollection.Evt_SetShootSuctionTargetDir += new Del_Void_Vector(OnSetShootSuctionTargetDir);
		base.BUSEventCollection.Evt_SetTraceVelocityCameraInfo += new Del_SetTraceVelocityCameraInfo(OnSetTraceVelocityCameraInfo);
		base.BUSEventCollection.Evt_ResetCameraSpringArmRot += new Del_Void(OnResetCameraSpringArmRot);
		base.BUSEventCollection.Evt_MoveCameraSpringArmRot2Nearest += new Del_Void(OnMoveCameraSpringArmRot2Nearest);
		base.BUSEventCollection.Evt_MoveCameraSpringArm2CustomRotation += new Del_Void_Rotator(OnMoveCameraSpringArm2CustomRotation);
		base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimit += new Del_Void_Float(OnSetCloudMoveCameraPitchLimit);
		base.BUSEventCollection.Evt_Camera_SetCloudMoveCameraPitchLimitEnabled += new Del_Void_Bool(OnSetCloudMoveCameraPitchLimitEnabled);
		base.BUSEventCollection.Evt_SetCloudMoveEnabled += new Del_Void_Bool(OnSetCloudMoveEnabled);
		base.BUSEventCollection.Evt_AddFixedCameraParam += new Del_Void_CameraParamType(OnAddFixedCameraParam);
		base.BUSEventCollection.Evt_RemoveFixedCameraParam += new Del_Void_CameraParamType(OnRemoveFixedCameraParam);
		base.BUSEventCollection.Evt_G4CameraTurnToTarget += new Del_Void_Transform(OnCameraG4AutoTrace);
		base.BUSEventCollection.Evt_SetPlayerCameraParam += new Del_Void_PlayerCameraParam(OnSetPlayerCameraParam);
		base.BUSEventCollection.Evt_SetStraightCameraParam += new Del_Void_StraightCameraParam(OnSetStraightCameraParam);
		base.BUSEventCollection.Evt_SetDiagonalCameraParam += new Del_Void_DiagonalCameraParam(OnSetDiagonalCameraParam);
		base.BUSEventCollection.Evt_SetGiantCameraParam += new Del_Void_GiantCameraParam(OnSetGiantCameraParam);
		base.BUSEventCollection.Evt_StartCamOffsetTick += new Del_StartCamOffsetTick(OnStartCameraOffsetTick);
		base.BUSEventCollection.Evt_StopCamOffsetTick += new Del_Void(OnStopCameraOffsetTick);
		base.BUSEventCollection.Evt_EnterSkillCam += new Del_Void_Actor(EnterSkillCamera);
		base.BUSEventCollection.Evt_ExitSkillCam += new Del_Void_Actor(ExitSkillCamera);
		base.BUSEventCollection.Evt_EnterPlayerSkillCamera += new Del_Void_Int(OnEnterPlayerSkillCamera);
		base.BUSEventCollection.Evt_ExitPlayerSkillCamera += new Del_Void(OnExitPlayerSkillCamera);
		base.BUSEventCollection.Evt_DetachCameraFromPlayer += new Del_Void(DetachCameraFromPlayer);
		base.BUSEventCollection.Evt_ReAttachCameraToPlayer += new Del_Void(ReAttachCameraToPlayer);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnPlayerRebirth);
		base.BUSEventCollection.Evt_UnitRebirth += new Del_UnitRebirth(OnUnitRebirth);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(AfterUnitRebirth);
		base.BUSEventCollection.Evt_UnitStateUpdated += new Del_UnitStateUpdated(OnUnitStateUpdated);
		base.BUSEventCollection.Evt_SetSyncCamera += new Del_SetSyncCamera(OnSetSyncCamera);
		base.BUSEventCollection.Evt_SyncCameraSwitchSyncPoint += new Del_Void_FNameFloat(OnSyncCameraSwitchSyncPoint);
		Player = GetOwner() as BGUCharacterCS;
		if (Player == null)
		{
			BGW_LogUtil.LogError("BUS_PlayerCameraComp OnBeginPlay Failed, GetPlayer Failed");
			return;
		}
		SpringArmComponent = Player.GetComponentByClass<BUS_SpringArmComponent>();
		CameraComponent = Player.GetComponentByClass<UCameraComponent>();
		PlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(Player);
		PlayerController = UGameplayStatics.GetPlayerController(Player, 0) as ABGPPlayerController;
		BPSEventCollection = BPS_GSEventCollection.Get(PlayerController);
		SettingMgr = BGW_SettingMgrV2.Get(GetOwner());
	}

	public override void PreBeginPlay()
	{
		FCameraDefaultData.ViewPitchMin = PlayerCameraManager.ViewPitchMin;
		FCameraDefaultData.ViewPitchMax = PlayerCameraManager.ViewPitchMax;
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Combine(bGW_EventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(PostSeamlessTravel));
		CameraState.bNotInitial = true;
	}

	public void PostSeamlessTravel()
	{
	}

	public override void OnBeginPlay()
	{
		InitializeCameraState();
	}

	private void OnAddFixedCameraParam(ECameraParamType CameraParamType)
	{
		CameraState.FixedCameraParamFlags |= 1 << (int)CameraParamType;
	}

	private void OnRemoveFixedCameraParam(ECameraParamType CameraParamType)
	{
		CameraState.FixedCameraParamFlags &= ~(1 << (int)CameraParamType);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(Owner);
		bGW_EventCollection.Evt_PostSeamlessTravel = (BGW_EventCollection.Del_BGW_Void)Delegate.Remove(bGW_EventCollection.Evt_PostSeamlessTravel, new BGW_EventCollection.Del_BGW_Void(PostSeamlessTravel));
		base.BUSEventCollection.Evt_SetCameraArmMode -= new Del_SetCameraArmMode(OnSetArmMode);
		base.BUSEventCollection.Evt_EnableCustomFOV -= new Del_Void_Bool(OnEnableCustomFOV);
		base.BUSEventCollection.Evt_EnableCustomCamPitch -= new Del_Void_BoolFloat(OnEnableCustomCameraPitch);
		base.BUSEventCollection.Evt_ForceSetFreeCameraArmLength -= new Del_Void_Float(ForceSetFreeCameraArmLength);
		base.BUSEventCollection.Evt_DecreaseFreeCameraArmLength -= new Del_Void_Float(DecreaseFreeCameraArmLength);
		base.BUSEventCollection.Evt_InputCameraTurnRight -= new Del_InputMove(OnInputAxisTurnRight);
		base.BUSEventCollection.Evt_InputCameraLookUp -= new Del_InputMove(OnInputAxisUp);
		base.BUSEventCollection.Evt_Camera_ManualLock -= new Del_Void_ActorString(OnLockTarget);
		base.BUSEventCollection.Evt_Camera_ClearCamLock -= new Del_Void(OnClearLock);
		base.BUSEventCollection.Evt_Camera_EnableGuiBeiCamera -= new Del_Camera_EnableGuiBeiCamera(OnEnableGuiBeiCamera);
		base.BUSEventCollection.Evt_Camera_DisableGuiBeiCamera -= new Del_Void(OnDisableGuiBeiCamera);
		base.BUSEventCollection.Evt_EnableCameraPitchCurve -= new Del_FloatCurve(OnEnablePitchCurve);
		base.BUSEventCollection.Evt_DisableCameraPitchCurve -= new Del_Void(OnDisablePitchCurve);
		base.BUSEventCollection.Evt_EnableCameraArmLengthCurve -= new Del_FloatCurve(OnEnableArmLengthCurve);
		base.BUSEventCollection.Evt_DisableCameraArmLengthCurve -= new Del_Void_Float(OnDisableArmLengthCurve);
		base.BUSEventCollection.Evt_EnableCameraSASOCurve -= new Del_VectorCurve(OnEnableSASOCurve);
		base.BUSEventCollection.Evt_DisableCameraSASOCurve -= new Del_Void_Float(OnDisableSASOCurve);
		base.BUSEventCollection.Evt_SwitchFreeCameraMode -= new Del_Void_FreeCameraMode(OnSwitchFreeCameraMode);
		base.BUSEventCollection.Evt_G4CameraTurnToLocation -= new Del_Bool_Vector(OnCameraTurnBack);
		base.BUSEventCollection.Evt_SetShootSuctionTargetDir -= new Del_Void_Vector(OnSetShootSuctionTargetDir);
		base.BUSEventCollection.Evt_AddFixedCameraParam -= new Del_Void_CameraParamType(OnAddFixedCameraParam);
		base.BUSEventCollection.Evt_RemoveFixedCameraParam -= new Del_Void_CameraParamType(OnRemoveFixedCameraParam);
		base.BUSEventCollection.Evt_G4CameraTurnToTarget -= new Del_Void_Transform(OnCameraG4AutoTrace);
		base.BUSEventCollection.Evt_StartCamOffsetTick -= new Del_StartCamOffsetTick(OnStartCameraOffsetTick);
		base.BUSEventCollection.Evt_StopCamOffsetTick -= new Del_Void(OnStopCameraOffsetTick);
		base.BUSEventCollection.Evt_EnterSkillCam -= new Del_Void_Actor(EnterSkillCamera);
		base.BUSEventCollection.Evt_ExitSkillCam -= new Del_Void_Actor(ExitSkillCamera);
		base.BUSEventCollection.Evt_EnterPlayerSkillCamera -= new Del_Void_Int(OnEnterPlayerSkillCamera);
		base.BUSEventCollection.Evt_ExitPlayerSkillCamera -= new Del_Void(OnExitPlayerSkillCamera);
		base.BUSEventCollection.Evt_SetSyncCamera -= new Del_SetSyncCamera(OnSetSyncCamera);
		base.BUSEventCollection.Evt_SyncCameraSwitchSyncPoint -= new Del_Void_FNameFloat(OnSyncCameraSwitchSyncPoint);
		Player = null;
		SpringArmComponent = null;
		CameraComponent = null;
		Target = null;
		SoulFocusSceneComponent = null;
		SoulFocusZSceneComponent = null;
		PlayerCameraManager = null;
		PlayerController = null;
	}

	public override bool CanTickForDebug()
	{
		return true;
	}

	public override int GetTickGroupMask()
	{
		return 10;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		switch (TickGroup)
		{
		case 2:
			PlayerCameraData.CurrentDeltaTime = DeltaTime;
			TickExCamOffset(DeltaTime);
			UpdateCameraState_GameThread(DeltaTime);
			UpdateCameraState_AnyThread(DeltaTime);
			GSThreadPool.Instance.QueueFastTask(default(GSThreadPool.TaskData), OnThreadTick, null);
			break;
		case 8:
			GSThreadPool.Instance.GameThread_FlushFastTasks();
			ApplyCameraControlData(PlayerCameraData.ControlData, DeltaTime);
			OnTickForIbmCamera(DeltaTime);
			break;
		}
	}

	private void OnThreadTick(object State)
	{
		try
		{
			float currentDeltaTime = PlayerCameraData.CurrentDeltaTime;
			BlendCameraParams(currentDeltaTime);
			ConstructMonitorData(PlayerCameraData.ControlData, PlayerCameraData.MonitorData);
		}
		catch (Exception)
		{
		}
	}

	private void OnTickForIbmCamera(float DeltaTime)
	{
		ACameraActor syncCamera = PlayerCameraData.SyncCamera;
		if (syncCamera == null)
		{
			return;
		}
		USceneComponent dummyMeshComp = PlayerCameraData.DummyMeshComp;
		if (dummyMeshComp == null)
		{
			return;
		}
		FTransform socketTransform = dummyMeshComp.GetSocketTransform(PlayerCameraData.CameraSyncPointOnHost);
		if (PlayerCameraData.SwitchSyncPointBlendTime > 0f)
		{
			PlayerCameraData.SwitchSyncPointBlendTimer += DeltaTime;
			float alpha = FMath.Clamp(PlayerCameraData.SwitchSyncPointBlendTimer / PlayerCameraData.SwitchSyncPointBlendTime, 0f, 1f);
			FTransform socketTransform2 = dummyMeshComp.GetSocketTransform(PlayerCameraData.LastCameraSyncPointOnHost);
			socketTransform.SetLocation(FMath.Lerp(socketTransform2.GetLocation(), socketTransform.GetLocation(), alpha));
			socketTransform.SetRotation(FMath.Lerp(socketTransform2.GetRotation(), socketTransform.GetRotation(), alpha));
			if (PlayerCameraData.SwitchSyncPointBlendTimer >= PlayerCameraData.SwitchSyncPointBlendTime)
			{
				PlayerCameraData.SwitchSyncPointBlendTime = 0f;
				PlayerCameraData.SwitchSyncPointBlendTimer = 0f;
				PlayerCameraData.LastCameraSyncPointOnHost = PlayerCameraData.CameraSyncPointOnHost;
			}
		}
		syncCamera.SetActorLocationAndRotation(socketTransform.GetLocation(), socketTransform.Rotator(), bSweep: false, out var _, bTeleport: false);
	}

	private void InitializeCameraState()
	{
		CameraState.WukongResID = BGW_GameDB.GetGlobalConfigByAliasChecked(B1GlobalConfigFNames.WukongResID).IntValue;
		CameraState.PlayerResId = Player.GetResID();
		CameraState.CurrentCameraID = -1;
		CameraState.CurrentCameraGroupId = -1;
		CameraState.Rt_ControllerRotationLerpSpeed = 6f;
		CameraState.StraightMinPitch = -40f;
		CameraState.StraightMaxPitch = 20f;
		CameraState.CameraArmMode = EDefaultCamArmMode.Default;
		CameraState.PlayerPos.SetValue(BGUFuncLibActorTransformCS.BGUGetActorLocation(Player));
		int actorResID = BGU_DataUtil.GetActorResID(Player);
		if (ControllerCameraData != null)
		{
			FUStCameraGroupDesc cameraGroupDesc = BGW_GameDB.GetCameraGroupDesc(ControllerCameraData.GetCameraGroupID(), actorResID);
			if (cameraGroupDesc != null && cameraGroupDesc.PlayerStateCameraIDList.Count >= 5)
			{
				CameraState.DefaultCameraIDForWalk = cameraGroupDesc.PlayerStateCameraIDList[0];
				CameraState.DefaultCameraIDForRun = cameraGroupDesc.PlayerStateCameraIDList[1];
				CameraState.DefaultCameraIDForSprint = cameraGroupDesc.PlayerStateCameraIDList[2];
				CameraState.DefaultCameraIDForHardMove = cameraGroupDesc.PlayerStateCameraIDList[3];
				CameraState.DefaultCameraIDForGlideMoving = cameraGroupDesc.PlayerStateCameraIDList[4];
			}
		}
		CameraState.FoliageFadeDistanceLerpSpeed = 1f;
		CameraState.G4RotateSpeed = (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.G4RotateSpeed, out var ConfigInfo) ? ConfigInfo.FloatValue : 6f);
		BPSEventCollection.Evt_SetResIDCameraConversionParam.Invoke(CameraState.PlayerResId);
	}

	protected virtual void UpdateCameraState_GameThread(float DeltaTime)
	{
		ApplyCameraGroup();
		CameraState.ConversionParams.CopyFromOther(ControllerCameraData.CurrentParams);
	}

	protected virtual void UpdateCameraState_AnyThread(float DeltaTime)
	{
		CameraState.Rt_FoliageFadeDistance = FoliageCameraFadeData.GetCurrentFoliageFadeDistance();
		CameraState.IsFalling = Player.GetMovementComponent().IsFalling();
		CameraState.IsFlying = Player.GetMovementComponent().IsFlying();
		CameraState.IsJumping = JumpData.IsInJump();
		CameraState.IsCloudVerticalLifting = SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove) && MovementData.IsCloudMoveVerticalLift;
		CameraState.bUseSplineMoveCamera = ManualSplineMoveData.IsManuaslSplineMovingWithSpecialAnimation() && ManualSplineMoveData.GetCameraType() == EManualSplineMoveCameraType.AlongSpline;
		CheckPlayerCameraId();
		OnApplyCameraId();
		CameraState.Has232Buff = PlayerBuffData.HasBuff(232);
		CameraState.Has275Buff = PlayerBuffData.HasBuff(275);
		CameraState.Has907Buff = PlayerBuffData.HasBuff(907);
		Func<float, float> func = (float InValue) => (float)FMath.RoundToInt(InValue / 10f) * 10f;
		FCameraConversionParams conversionParams = CameraState.ConversionParams;
		if (CameraState.bEnableStraightCameraConversionParam || ControllerCameraData.SkillTargetParams != null)
		{
			CameraState.StraightArmLengthDefault = func(conversionParams.UnitScaleRate * (conversionParams.UnitMeshHeightRate * (CameraState.OriginStraightCameraArmLengthDefault - conversionParams.WukongRearFootOffset) + conversionParams.UnitRearFootOffset));
			CameraState.StraightPlayerRefHeightOffset = func(conversionParams.UnitScaleRate * (conversionParams.UnitMeshHeight - conversionParams.WukongCapsuleHalfHeight) - (conversionParams.UnitMeshHeight - conversionParams.UnitCapsuleHalfHeight) + CameraState.OriginStraightPlayerRefHeightOffset);
		}
		else
		{
			CameraState.StraightArmLengthDefault = CameraState.OriginStraightCameraArmLengthDefault;
			CameraState.StraightPlayerRefHeightOffset = CameraState.OriginStraightPlayerRefHeightOffset;
		}
		if (CameraState.bEnablePlayerCameraConversionParam || ControllerCameraData.SkillTargetParams != null)
		{
			CameraState.DefaultMeshZOffsetLimit = func(conversionParams.UnitScaleRate * (conversionParams.UnitPelvisHeightRate * CameraState.OriginDefaultMeshZOffsetLimit));
			CameraState.DefaultArmLengthDefault = func(conversionParams.UnitScaleRate * (conversionParams.UnitMeshHeightRate * (CameraState.OriginDefaultArmLengthDefault - conversionParams.WukongRearFootOffset) + conversionParams.UnitRearFootOffset));
			CameraState.DefaultArmLocation.Z = func(conversionParams.UnitScaleRate * conversionParams.UnitMeshHeightRate * (CameraState.OriginDefaultArmLocationZ + conversionParams.WukongCapsuleHalfHeight) - conversionParams.UnitScaleRate * conversionParams.UnitCapsuleHalfHeight);
			CameraState.DefaultArmSocketOffset.Z = func(conversionParams.UnitScaleRate * (conversionParams.UnitMeshHeightRate * CameraState.OriginDefaultArmSocketOffsetZ));
		}
		else
		{
			CameraState.DefaultMeshZOffsetLimit = CameraState.OriginDefaultMeshZOffsetLimit;
			CameraState.DefaultArmLengthDefault = CameraState.OriginDefaultArmLengthDefault;
			CameraState.DefaultArmLocation.Z = CameraState.OriginDefaultArmLocationZ;
			CameraState.DefaultArmSocketOffset.Z = CameraState.OriginDefaultArmSocketOffsetZ;
		}
		CameraState.DefaultArmTargetOffset = FVector.ZeroVector;
		CameraState.LastCameraInputTimer += DeltaTime;
		CameraState.PlayerRootPos.SetValue(Player.Mesh.GetSocketLocation(B1GlobalFNames.root));
		FVector socketLocation = Player.Mesh.GetSocketLocation(B1GlobalFNames.pelvis);
		FVector actorLocation = Player.GetActorLocation();
		GSLocation gSLocation = CameraState.PlayerPelvisPos - CameraState.PlayerRootPos;
		CameraState.PlayerPreviousPos.SetValue(CameraState.PlayerPos);
		if ((CameraState.FixedCameraParamFlags & 0x20000) == 0)
		{
			CameraState.PlayerPelvisPos.X = socketLocation.X;
			CameraState.PlayerPelvisPos.Y = socketLocation.Y;
			CameraState.PlayerMeshOffset.X = gSLocation.X;
			CameraState.PlayerMeshOffset.Y = gSLocation.Y;
			CameraState.PlayerPos.X = actorLocation.X;
			CameraState.PlayerPos.Y = actorLocation.Y;
		}
		if ((CameraState.FixedCameraParamFlags & 0x40000) == 0)
		{
			CameraState.PlayerPelvisPos.Z = socketLocation.Z;
			CameraState.PlayerMeshOffset.Z = gSLocation.Z;
			CameraState.PlayerPos.Z = actorLocation.Z;
		}
		if (CameraState.Has275Buff)
		{
			CameraState.PlayerRefBase.SetValue(CameraState.PlayerPelvisPos);
			CameraState.PlayerRefBase.Z -= conversionParams.UnitCapsuleHalfHeight;
		}
		else
		{
			CameraState.PlayerRefBase.SetValue(CameraState.PlayerRootPos);
		}
		socketLocation.Normalize();
		FRotator controlRotation = PlayerController.GetControlRotation();
		CameraState.PlayerVelocity.SetValue(Player.GetVelocity());
		CameraState.PlayerForwardVector.SetValue(Player.GetActorForwardVector());
		CameraState.PlayerForwardVector.Normalize();
		CameraState.PlayerPreviousControlRot.SetValue(Player.GetControlRotation());
		CameraState.PlayerIsAttacking = UnitStateData.HasState(EBGUUnitState.Attacking);
		CameraState.PlayerIsGlideMoving = UnitStateData.HasState(EBGUUnitState.GlideMoving);
		CameraState.PlayerIsInAir = Player.CharacterMovement.IsFalling();
		CameraState.PlayerCanMove = CheckPlayerCanMove();
		CameraState.bCastRollingSkill = RollData.bCastRollingSkill;
		CameraState.bPlayerDead = UnitStateData.HasState(EBGUUnitState.Dead);
		CameraState.SplineMoveRotation.SetValue(ManualSplineMoveData.CurSplineMoveForwardDir.Rotation());
		if (PlayerController != null)
		{
			CameraState.Rt_ControllerRotation.SetValue(controlRotation.GetNormalized());
			CameraState.ControllerForwardVector.SetValue(PlayerController.GetActorForwardVector());
		}
		if (SpringArmComponent != null)
		{
			CameraState.Rt_ArmWorldLocation.SetValue(SpringArmComponent.GetWorldLocation());
			CameraState.Rt_ArmLocation.SetValue(SpringArmComponent.RelativeLocation);
			CameraState.Rt_ArmSocketOffset.SetValue(SpringArmComponent.SocketOffset);
			CameraState.Rt_ArmTargetOffset = SpringArmComponent.TargetOffset;
			CameraState.Rt_ArmLength = SpringArmComponent.TargetArmLength;
			CameraState.Rt_CameraLagSpeed.SetValue(SpringArmComponent.CameraLagSpeed3Axis);
			CameraState.Rt_CameraLagInverseSpeed.SetValue(SpringArmComponent.CameraLagInverseSpeed3Axis);
			CameraState.Rt_CameraLagMaxDistance.SetValue(SpringArmComponent.CameraLagMaxDistance3Axis);
			CameraState.Rt_IsXAxisSmoothed = SpringArmComponent.IsXSmoothFixed;
			CameraState.Rt_IsYAxisSmoothed = SpringArmComponent.IsYSmoothFixed;
			CameraState.Rt_IsZAxisSmoothed = SpringArmComponent.IsZSmoothFixed;
			SpringArmComponent.GetPreviousValues(out var OutPreviousDesiredLoc, out var OutPreviousArmOrigin, out var OutPreviousDesiredRot);
			CameraState.Rt_PreviousDesiredLoc = OutPreviousDesiredLoc;
			CameraState.Rt_PreviousArmOrigin = OutPreviousArmOrigin;
			CameraState.Rt_PreviousDesiredRot = OutPreviousDesiredRot;
		}
		if (CameraComponent != null)
		{
			CameraState.Rt_CameraWorldPosition.SetValue(CameraComponent.GetWorldLocation());
			CameraState.Rt_CameraWorldRotation.SetValue(CameraComponent.GetWorldRotation());
			CameraState.Rt_CameraRotation.SetValue(CameraComponent.RelativeRotation);
			CameraState.Rt_FieldOfView = CameraComponent.FieldOfView;
			UGSE_CameraUtilFuncLib.GetCameraFocalParams(CameraComponent, out var OutFocalDistance, out var OutDepthBlurKm, out var OutDepthBlurRadius);
			CameraState.Rt_FocalDistance = OutFocalDistance;
			CameraState.Rt_DepthBlurKm = OutDepthBlurKm;
			CameraState.Rt_DepthBlurRadius = OutDepthBlurRadius;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CloudMove))
		{
			CameraState.Rt_AxisMoveForward = InputData.GetInputValue(GSBattleActionEn.Cloud_MoveForward);
			CameraState.Rt_AxisMoveRight = InputData.GetInputValue(GSBattleActionEn.Cloud_MoveSideways);
		}
		else
		{
			CameraState.Rt_AxisMoveForward = InputData.GetInputValue(GSBattleActionEn.MoveForward);
			CameraState.Rt_AxisMoveRight = InputData.GetInputValue(GSBattleActionEn.MoveSideways);
		}
		if (Target != null)
		{
			if (Target is BGUCharacterCS bGUCharacterCS)
			{
				FVector worldLocation = bGUCharacterCS.Mesh.GetWorldLocation();
				FVector fVector = ((!(CameraState.SPointSocketName == FName.None)) ? bGUCharacterCS.Mesh.GetSocketLocation(CameraState.SPointSocketName) : ((SoulFocusSceneComponent == null) ? bGUCharacterCS.Mesh.GetSocketLocation(CameraState.PPointSocketName) : SoulFocusSceneComponent.GetWorldLocation()));
				FVector fVector2 = ((!(CameraState.ZPointSocketName == FName.None)) ? bGUCharacterCS.Mesh.GetSocketLocation(CameraState.ZPointSocketName) : ((SoulFocusZSceneComponent == null) ? bGUCharacterCS.Mesh.GetSocketLocation(CameraState.PPointSocketName) : SoulFocusZSceneComponent.GetWorldLocation()));
				if ((CameraState.FixedCameraParamFlags & 0x80000) == 0)
				{
					CameraState.TargetPos.X = worldLocation.X;
					CameraState.TargetPos.Y = worldLocation.Y;
					CameraState.TargetSoulFocusPos.X = fVector.X;
					CameraState.TargetSoulFocusPos.Y = fVector.Y;
				}
				if ((CameraState.FixedCameraParamFlags & 0x100000) == 0)
				{
					CameraState.TargetPos.Z = worldLocation.Z;
					CameraState.TargetSoulFocusPos.Z = fVector2.Z;
				}
				CameraState.TargetRootPos.SetValue(bGUCharacterCS.Mesh.GetSocketLocation(CameraState.RPointSocketName));
			}
			else
			{
				FVector actorLocation2 = Target.GetActorLocation();
				FVector fVector3 = ((SoulFocusSceneComponent == null) ? actorLocation2 : SoulFocusSceneComponent.GetWorldLocation());
				FVector fVector4 = ((SoulFocusZSceneComponent == null) ? actorLocation2 : SoulFocusZSceneComponent.GetWorldLocation());
				if ((CameraState.FixedCameraParamFlags & 0x80000) == 0)
				{
					CameraState.TargetPos.X = actorLocation2.X;
					CameraState.TargetPos.Y = actorLocation2.Y;
					CameraState.TargetSoulFocusPos.X = fVector3.X;
					CameraState.TargetSoulFocusPos.Y = fVector3.Y;
				}
				if ((CameraState.FixedCameraParamFlags & 0x100000) == 0)
				{
					CameraState.TargetPos.Z = actorLocation2.Z;
					CameraState.TargetSoulFocusPos.Z = fVector4.Z;
				}
				CameraState.TargetRootPos.SetValue(actorLocation2);
			}
		}
		if (PlayerCameraManager != null)
		{
			CameraState.Rt_ViewPitchMin = PlayerCameraManager.ViewPitchMin;
			CameraState.Rt_ViewPitchMax = PlayerCameraManager.ViewPitchMax;
		}
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			if (CameraState.HasPitchCurve)
			{
				CameraState.PitchCurveValue = CameraState.PitchCurve.CurveFloat.GetFloatValue(CameraState.PitchCurveTime);
				CameraState.PitchCurveTime += DeltaTime;
				CameraState.PitchCurveBlendTimer -= DeltaTime;
			}
			if (CameraState.HasArmLengthCurve)
			{
				CameraState.ArmLengthCurveValue = CameraState.ArmLengthCurve.CurveFloat.GetFloatValue(CameraState.ArmLengthCurveTime);
				CameraState.ArmLengthCurveTime += DeltaTime;
				CameraState.ArmLengthCurveBlendTimer -= DeltaTime;
			}
			else if (CameraState.ArmLengthCurveBlendOutTime > 0f)
			{
				CameraState.ArmLengthCurveBlendTimer -= DeltaTime;
				if (CameraState.ArmLengthCurveBlendTimer <= 0f)
				{
					CameraState.ArmLengthCurveBlendOutTime = 0f;
					CameraState.ArmLengthCurveBlendTimer = 0f;
				}
			}
			if (CameraState.HasSASOCurve)
			{
				CameraState.SASOCurveValue.SetValue(CameraState.SASOCurve.GetVectorValue(CameraState.SASOCurveTime));
				CameraState.SASOCurveTime += DeltaTime;
				CameraState.SASOCurveBlendTimer -= DeltaTime;
			}
			else if (CameraState.SASOCurveBlendOutTime > 0f)
			{
				CameraState.SASOCurveBlendTimer -= DeltaTime;
				if (CameraState.SASOCurveBlendTimer <= 0f)
				{
					CameraState.SASOCurveBlendOutTime = 0f;
					CameraState.SASOCurveBlendTimer = 0f;
				}
			}
			if (CameraState.HasArmLocationZCurve)
			{
				CameraState.ArmLocationZCurveValue = CameraState.ArmLocationZCurve.CurveFloat.GetFloatValue(CameraState.ArmLocationZCurveTime);
				CameraState.ArmLocationZCurveTime += DeltaTime;
				CameraState.ArmLocationZCurveBlendTime -= DeltaTime;
			}
			else if (CameraState.ArmLocationZCurveBlendOutTime > 0f)
			{
				CameraState.ArmLocationZCurveBlendTime -= DeltaTime;
				if (CameraState.ArmLocationZCurveBlendTime <= 0f)
				{
					CameraState.ArmLocationZCurveBlendOutTime = 0f;
					CameraState.ArmLocationZCurveBlendTime = 0f;
				}
			}
		}
		CameraState.StraightFovOffset = 0f;
		if (PlayerCameraManager != null)
		{
			ControllerCameraData.CameraManagerWorldPos = PlayerCameraManager.GetActorLocation();
		}
		CameraState.bEnableAutoTrail = SettingMgr.GetCVBoolByType(UISettingConfigType.LensRotation);
	}

	private bool CheckPlayerCanMove()
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.CantMove) || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return false;
		}
		if (UnitStateData.HasState(EBGUUnitState.Dead) || SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		if (!UnitStateData.HasState(EBGUUnitState.InMoveWindow))
		{
			if (UnitStateData.HasState(EBGUUnitState.Beatback))
			{
				return false;
			}
			if (UnitStateData.HasState(EBGUUnitState.Attacking) && !UnitStateData.HasState(EBGUUnitState.AttackMoving))
			{
				return false;
			}
		}
		return true;
	}

	private void BlendCameraParams(float InDeltaTime)
	{
		if (PlayerCameraData.CameraGraph == null)
		{
			BGW_LogUtil.LogError("BUS_PlayerCameraComp Failed, PlayerCameraData.CameraGraph is null");
		}
		else
		{
			PlayerCameraData.CameraGraph.Tick(InDeltaTime, CameraState, PlayerCameraData.ControlData, PlayerCameraData.MonitorData);
		}
	}

	private void ApplyCameraControlData(GSCameraControlData InControlData, float InDeltaTime)
	{
		if (InControlData == null)
		{
			BGW_LogUtil.LogError("BUS_PlayerCameraComp ApplyCameraControlData Failed, InControlData is null");
			return;
		}
		BPSEventCollection.Evt_BPS_SetCameraFoliageFadeValue.Invoke(InControlData.FoliageFadeDistance);
		if (!InControlData.bUseCustomFov)
		{
			CameraComponent.SetFieldOfView(InControlData.FieldOfView);
		}
		UGSE_CameraUtilFuncLib.SetCameraFocalParams(CameraComponent, InControlData.FocalDistance, InControlData.DepthBlurKm, InControlData.DepthBlurRadius);
		if (InControlData.DepthBlurRadius >= 1f)
		{
			if (!HasSetCVar)
			{
				HasSetCVar = true;
				CVarHandle = CVarFuncLib.CreateHandle(DLSS_SCENECOLOR_CVAR_NAME);
				CVarFuncLib.SetByHandleWithPriority(CVarHandle, 1f, EConsoleVariablePriority.SetByCode, 0);
			}
		}
		else if (HasSetCVar)
		{
			HasSetCVar = false;
			CVarFuncLib.DestroyHandle(CVarHandle);
		}
		if (CameraState.ResetSpringArmRotationWay != EResetSpringArmRotationWay.None)
		{
			InControlData.ArmLocation.X = 0f;
			InControlData.ArmLocation.Y = 0f;
		}
		if (SpringArmComponent != null)
		{
			SpringArmComponent.SetRelativeLocation(InControlData.ArmLocation.ToVector(), bSweep: false, out var _, bTeleport: false);
			SpringArmComponent.TargetArmLength = InControlData.ArmLength;
			SpringArmComponent.SocketOffset = InControlData.ArmSocketOffset.ToVector();
			SpringArmComponent.TargetOffset = InControlData.ArmTargetOffset;
			SpringArmComponent.IsXSmoothFixed = InControlData.IsXAxisFixed;
			SpringArmComponent.IsYSmoothFixed = InControlData.IsYAxisFixed;
			SpringArmComponent.IsZSmoothFixed = InControlData.IsZAxisFixed;
			SpringArmComponent.CameraLagSpeed3Axis = InControlData.CameraLagSpeed.ToVector();
			SpringArmComponent.CameraLagInverseSpeed3Axis = InControlData.CameraLagInverseSpeed.ToVector();
			SpringArmComponent.CameraLagMaxDistance3Axis = InControlData.CameraLagMaxDistance.ToVector();
			_ = InControlData.bUseCustomCameraPitch;
		}
		if (PlayerController != null)
		{
			if (CameraState.ResetSpringArmRotationWay != EResetSpringArmRotationWay.None)
			{
				switch (CameraState.ResetSpringArmRotationWay)
				{
				case EResetSpringArmRotationWay.Reset2PlayerRotation:
					PlayerController.SetControlRotation(Player.GetActorRotation());
					break;
				case EResetSpringArmRotationWay.Reset2NearestRotation:
				{
					FVector cameraLocation = PlayerCameraManager.GetCameraLocation();
					FVector safeNormal2D = PlayerCameraManager.GetCameraRotation().GetForwardVector().GetSafeNormal2D();
					float rt_ArmLength = CameraState.Rt_ArmLength;
					FVector fVector = CameraState.PlayerPos.ToVector();
					FVector safeNormal2D2 = (fVector - cameraLocation).GetSafeNormal2D();
					float num = FVector.DotProduct(safeNormal2D, safeNormal2D2);
					FVector fVector2 = cameraLocation;
					if (num < 0f)
					{
						fVector2 += ((0f - num) * rt_ArmLength + (fVector - cameraLocation).Size2D()) * safeNormal2D2;
					}
					else
					{
						fVector2 += num * rt_ArmLength * -safeNormal2D;
					}
					FRotator controlRotation = MathLib.MakeRotFromX(fVector - fVector2);
					PlayerController.SetControlRotation(controlRotation);
					break;
				}
				case EResetSpringArmRotationWay.UseCustomRotation:
					PlayerController.SetControlRotation(CameraState.CustomSpringArmRotation);
					break;
				}
				SpringArmComponent?.ResetArmLengthLerpCache();
				CameraState.ResetSpringArmRotationWay = EResetSpringArmRotationWay.None;
			}
			else if (!InControlData.bUseCustomCameraPitch)
			{
				PlayerController.SetControlRotation(InControlData.ControllerRotation.ToRotator());
			}
			else
			{
				FRotator controlRotation2 = PlayerController.GetControlRotation();
				controlRotation2.Pitch = InControlData.CustomCameraPitch;
				PlayerController.SetControlRotation(controlRotation2);
			}
			if (PlayerController.GetPendingViewTarget() == null)
			{
				if (FMath.Abs(InControlData.ControllerYawInput) > 1E-08f)
				{
					Player.AddControllerYawInput(InControlData.ControllerYawInput);
				}
				if (FMath.Abs(InControlData.ControllerPitchInput) > 1E-08f)
				{
					Player.AddControllerPitchInput(InControlData.ControllerPitchInput);
				}
			}
		}
		if (PlayerCameraManager != null)
		{
			PlayerCameraManager.ViewPitchMin = InControlData.ViewPitchMin;
			PlayerCameraManager.ViewPitchMax = InControlData.ViewPitchMax;
		}
		if (CameraState.TickTotalTime > 1E-08f)
		{
			if (CameraState.G4TurnRunTime >= CameraState.TickTotalTime)
			{
				CameraState.TickTotalTime = 0f;
				if (CameraState.IsTurning)
				{
					CameraState.IsTurning = false;
				}
			}
			else
			{
				CameraState.G4TurnRunTime += InDeltaTime;
			}
		}
		CameraState.InputAxisTurnRight = 0f;
		CameraState.InputAxisLookUp = 0f;
		CameraState.ShootSuctionTargetDir.SetValue(FVector.ZeroVector);
		CameraState.LastInverseAnimRotator.SetValue(CameraState.CurInverseAnimRotator);
		CameraState.CurInverseAnimRotator.SetValue(FRotator.ZeroRotator);
		CameraState.bDiagonalIgnoreLerp = false;
		if (GSGameplayCVar.CVar_EnableSoulCurveDebug.GetValueInGameThread() == 1)
		{
			GSCameraMonitorData monitorData = PlayerCameraData.MonitorData;
			float keepTime = 0.5f;
			float raidus = 10f;
			UWorld world = Owner.World;
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(world, monitorData.StraightTargetRefPos.ToVector(), raidus, keepTime, FColor.Orange);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(world, monitorData.StraightCameraRefPos.ToVector(), raidus, keepTime, FColor.BlueViolet);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(world, monitorData.StraightPlayerRefPos.ToVector(), raidus, keepTime, FColor.GreenYellow);
			USystemLibrary.DrawDebugArrow(Owner, monitorData.StraightPlayerRefPos.ToVector(), monitorData.StraightCameraRefPos.ToVector(), 7.5f, FLinearColor.GreenYellow);
			USystemLibrary.DrawDebugArrow(Owner, monitorData.StraightCameraRefPos.ToVector(), monitorData.StraightTargetRefPos.ToVector(), 7.5f, FLinearColor.BlueViolet);
			USystemLibrary.DrawDebugArrow(Owner, monitorData.StraightPlayerRefPos.ToVector(), monitorData.StraightTargetRefPos.ToVector(), 7.5f, FLinearColor.OrangeRed);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(world, CameraState.TargetSoulFocusPos.ToVector(), raidus, keepTime, FColor.Purple);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(world, CameraState.PlayerPelvisPos.ToVector(), raidus, keepTime, FColor.DarkRed);
			if (PlayerCameraManager != null && SpringArmComponent != null)
			{
				USystemLibrary.DrawDebugArrow(Owner, PlayerCameraManager.GetCameraLocation(), PlayerCameraManager.GetCameraLocation() + PlayerCameraManager.GetCameraRotation().Vector() * SpringArmComponent.TargetArmLength, 7.5f, FLinearColor.Red);
			}
		}
	}

	private void DetachCameraFromPlayer()
	{
		if (!CameraComponent.IsNullOrDestroyed() && !SpringArmComponent.IsNullOrDestroyed())
		{
			CameraComponent.DetachFromComponent(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}
	}

	private void ReAttachCameraToPlayer()
	{
		if (!CameraComponent.IsNullOrDestroyed() && !SpringArmComponent.IsNullOrDestroyed())
		{
			CameraComponent.AttachToComponent(SpringArmComponent, B1GlobalFNames.SpringEndpoint, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
		}
	}

	private void OnPlayerRebirth(ERebirthType Rebirthtype)
	{
		OnResetCameraSpringArmRot();
	}

	private void SetStraightCamera(int CameraId)
	{
		CameraState.PPointSocketName = B1GlobalFNames.pelvis;
		CameraState.RPointSocketName = B1GlobalFNames.root;
		CameraState.SPointSocketName = FName.None;
		CameraState.ZPointSocketName = FName.None;
		CameraState.MultiLockCameraID = 0;
		if (CameraState.bTargetSupportMultiPointLock)
		{
			FUStMultiPointLockCameraConfigDesc multiPointLockCameraConfigDesc = BGW_GameDB.GetMultiPointLockCameraConfigDesc(CameraId, CameraState.LockTargetSocketName);
			if (multiPointLockCameraConfigDesc != null)
			{
				CameraState.PPointSocketName = new FName(multiPointLockCameraConfigDesc.PelvisSocket);
				CameraState.RPointSocketName = new FName(multiPointLockCameraConfigDesc.RootSocket);
				CameraState.SPointSocketName = (string.IsNullOrEmpty(multiPointLockCameraConfigDesc.SoulFocusSocket) ? CameraState.PPointSocketName : new FName(multiPointLockCameraConfigDesc.SoulFocusSocket));
				CameraState.ZPointSocketName = (string.IsNullOrEmpty(multiPointLockCameraConfigDesc.SoulFocusZSocket) ? CameraState.PPointSocketName : new FName(multiPointLockCameraConfigDesc.SoulFocusZSocket));
				CameraState.MultiLockCameraID = CameraId;
				CameraId = multiPointLockCameraConfigDesc.CameraID;
			}
			else
			{
				BGW_LogUtil.LogError($"多点锁定表MultiPointLockCameraConfigDesc 未找到ID={CameraId} SocketName={CameraState.LockTargetSocketName}的数据");
			}
		}
		CameraState.FinalLockCameraID = CameraId;
		CameraState.bEnableStraightCameraConversionParam = false;
		FUStStraightCamDesc straightCamDescDesc = BGW_GameDB.GetStraightCamDescDesc(CameraId, CameraState.PlayerResId);
		if (straightCamDescDesc == null)
		{
			straightCamDescDesc = BGW_GameDB.GetStraightCamDescDesc(CameraId, CameraState.WukongResID);
			CameraState.bEnableStraightCameraConversionParam = true;
		}
		if (straightCamDescDesc != null)
		{
			CameraState.CamRefType = straightCamDescDesc.CamRefType;
			CameraState.OriginStraightCameraArmLengthDefault = straightCamDescDesc.ArmLengthDefault;
			CameraState.StraightArmLengthDefault = straightCamDescDesc.ArmLengthDefault;
			CameraState.StraightArmLengthClose = straightCamDescDesc.ArmLengthClose;
			CameraState.StraightArmLengthMid = straightCamDescDesc.ArmLengthMid;
			CameraState.StraightArmLengthFar = straightCamDescDesc.ArmLengthFar;
			CameraState.StraightArmLengthSpeed = straightCamDescDesc.ArmLengthSpeed;
			CameraState.StraightTargetRefHeightOffset = straightCamDescDesc.TargetRefHeightOffset;
			CameraState.OriginStraightPlayerRefHeightOffset = straightCamDescDesc.PlayerRefHeightOffset;
			CameraState.StraightTargetRefHeightOffsetSpeed = straightCamDescDesc.TargetRefHeightOffsetSpeed;
			CameraState.StraightPlayerRefHeightOffsetSpeed = straightCamDescDesc.PlayerRefHeightOffsetSpeed;
			CameraState.StraightHeightThreshold = straightCamDescDesc.HeightThreshold;
			CameraState.StraightMaxTraceTargetRefDist = straightCamDescDesc.MaxTraceTargetRefDist;
			CameraState.StraightTraceTargetRefSpeed = straightCamDescDesc.TraceTargetRefSpeed;
			CameraState.StraightYawTraceSpeed = straightCamDescDesc.YawTraceSpeed;
			CameraState.StraightPitchTraceSpeed = straightCamDescDesc.PitchTraceSpeed;
			CameraState.StraightMinPitch = straightCamDescDesc.MinPitch;
			CameraState.StraightMaxPitch = straightCamDescDesc.MaxPitch;
			CameraState.StraightHeightScaleFactor = straightCamDescDesc.HeightScaleFactor;
			CameraState.StraightClosestDist = straightCamDescDesc.ClosestDist;
			CameraState.StraightHeightScaleFurthestDist = straightCamDescDesc.HeightScaleFurthestDist;
			CameraState.StraightCameraParamInts = straightCamDescDesc.CameraParamInt.ToArray();
			CameraState.StraightCameraParamFloats = straightCamDescDesc.CameraParamFloat.ToArray();
			CameraState.StraightCameraParamStrings = straightCamDescDesc.CameraParamString.ToArray();
			CameraState.StraightTraceSolution = straightCamDescDesc.SlowTraceSolution;
			CameraState.StraightSlowTraceTargetRefMaxYaw = straightCamDescDesc.SlowTraceTargetRefMaxYaw;
			CameraState.StraightTraceSpeedCurve.Set(BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveVector>(straightCamDescDesc.SlowTraceSpeedCurve, ELoadResourceType.SyncLoadAndCache));
			if (CameraState.StraightCameraParamStrings != null && CameraState.StraightCameraParamStrings.Length >= 1)
			{
				CameraState.StraightOffsetCurve.Set(BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveVector>(CameraState.StraightCameraParamStrings[0], ELoadResourceType.SyncLoadAndCache));
			}
			else
			{
				CameraState.StraightOffsetCurve.Set(null);
			}
			if (CameraState.StraightCameraParamStrings != null && CameraState.StraightCameraParamStrings.Length >= 2)
			{
				CameraState.StraightFovOffsetCurve.Set(BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveFloat>(CameraState.StraightCameraParamStrings[1], ELoadResourceType.SyncLoadAndCache));
			}
			else
			{
				CameraState.StraightFovOffsetCurve.Set(null);
			}
		}
	}

	private void SetGiantCamera(int CameraId)
	{
		CameraState.PPointSocketName = B1GlobalFNames.pelvis;
		CameraState.RPointSocketName = B1GlobalFNames.root;
		CameraState.SPointSocketName = FName.None;
		CameraState.ZPointSocketName = FName.None;
		CameraState.MultiLockCameraID = 0;
		if (CameraState.bTargetSupportMultiPointLock)
		{
			FUStMultiPointLockCameraConfigDesc multiPointLockCameraConfigDesc = BGW_GameDB.GetMultiPointLockCameraConfigDesc(CameraId, CameraState.LockTargetSocketName);
			if (multiPointLockCameraConfigDesc != null)
			{
				CameraState.PPointSocketName = new FName(multiPointLockCameraConfigDesc.PelvisSocket);
				CameraState.RPointSocketName = new FName(multiPointLockCameraConfigDesc.RootSocket);
				CameraState.SPointSocketName = (string.IsNullOrEmpty(multiPointLockCameraConfigDesc.SoulFocusSocket) ? CameraState.PPointSocketName : new FName(multiPointLockCameraConfigDesc.SoulFocusSocket));
				CameraState.ZPointSocketName = (string.IsNullOrEmpty(multiPointLockCameraConfigDesc.SoulFocusZSocket) ? CameraState.PPointSocketName : new FName(multiPointLockCameraConfigDesc.SoulFocusZSocket));
				CameraState.MultiLockCameraID = CameraId;
				CameraId = multiPointLockCameraConfigDesc.CameraID;
			}
			else
			{
				BGW_LogUtil.LogError($"多点锁定表MultiPointLockCameraConfigDesc 未找到ID={CameraId} SocketName={CameraState.LockTargetSocketName}的数据");
			}
		}
		CameraState.FinalLockCameraID = CameraId;
		FUStGiantLockCameraDesc giantCamDescDesc = BGW_GameDB.GetGiantCamDescDesc(CameraId, CameraState.PlayerResId);
		if (giantCamDescDesc != null)
		{
			CameraState.GiantArmLength = FMath.Max(giantCamDescDesc.ArmLength, 10f);
			CameraState.GiantArmLengthLerpSpeed = giantCamDescDesc.ArmLengthSpeed;
			CameraState.GiantTargetRefHeightOffset = giantCamDescDesc.TargetRefHeightOffset;
			CameraState.GiantPlayerRefHeightOffset = giantCamDescDesc.PlayerRefHeightOffset;
			CameraState.GiantTargetRefHeightOffsetLerpSpeed = giantCamDescDesc.TargetRefHeightOffsetSpeed;
			CameraState.GiantPlayerRefHeightOffsetLerpSpeed = giantCamDescDesc.PlayerRefHeightOffsetSpeed;
			CameraState.GiantHeightThreshold = giantCamDescDesc.TargetHeightThreshold;
			CameraState.GiantCameraOffsetLerpSpeed = giantCamDescDesc.CameraOffsetLerpSpeed;
			CameraState.GiantTargetScreenMaxRatio = FMath.Clamp(giantCamDescDesc.TargetScreenMaxRatio, 0f, 1f);
			CameraState.GiantTargetScreenMinRatio = 0f - CameraState.GiantTargetScreenMaxRatio;
			CameraState.GiantMinPitch = giantCamDescDesc.MinPitch;
			CameraState.GiantMaxPitch = giantCamDescDesc.MaxPitch;
			CameraState.GiantPitchLerpSpeed = giantCamDescDesc.PitchLerpSpeed;
			CameraState.GiantPlayerScreenRatio = FMath.Clamp(giantCamDescDesc.PlayerScreenRatio, -1f, 1f);
			if (string.IsNullOrEmpty(giantCamDescDesc.TargetRefHeightOffsetCurve))
			{
				CameraState.GiantTargetRefHeightOffsetCurve.Set(null);
			}
			else
			{
				CameraState.GiantTargetRefHeightOffsetCurve.Set(BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveFloat>(giantCamDescDesc.TargetRefHeightOffsetCurve, ELoadResourceType.SyncLoadAndCache));
			}
			CameraState.CameraBlendCache.ClearGiantCache();
		}
	}

	private void ExitSkillCamera(AActor InSkillCaster)
	{
		if (!(InSkillCaster == null) && Target == InSkillCaster)
		{
			ExitCurrentTargetSkillCamera();
		}
	}

	private void EnterSkillCamera(AActor InSkillCaster)
	{
		if (!(InSkillCaster == null) && InSkillCaster == Target)
		{
			EnterCurrentTargetSkillCamera(ControllerCameraData.SkillCameraDictionary[InSkillCaster]);
		}
	}

	private void EnterCurrentTargetSkillCamera(int SkillCamID)
	{
		CameraState.bUseMonsterSkillCamera = true;
		SetGiantCamera(SkillCamID);
		if (CameraState.LockCamMode == ELockCamMode.Soul)
		{
			SetStraightCamera(SkillCamID);
		}
		else if (CameraState.LockCamMode == ELockCamMode.Dmc)
		{
			SetDiagonalCamera(SkillCamID);
		}
	}

	private void ExitCurrentTargetSkillCamera()
	{
		CameraState.bUseMonsterSkillCamera = false;
		SetGiantCamera(CameraState.CurrentLockCameraID);
		if (CameraState.LockCamMode == ELockCamMode.Soul)
		{
			SetStraightCamera(CameraState.CurrentLockCameraID);
		}
		else if (CameraState.LockCamMode == ELockCamMode.Dmc)
		{
			SetDiagonalCamera(CameraState.CurrentLockCameraID);
		}
	}

	private bool OnCameraTurnBack(FVector TargetLocation)
	{
		if (!PlayerCameraData.IsInG4Mode())
		{
			return false;
		}
		if (CameraState.IsTurning)
		{
			return false;
		}
		CameraState.BeginRotation.SetValue(0f, CameraState.Rt_ControllerRotation.Yaw, 0f);
		CameraState.TargetRotation.SetValue(0f, MathLib.MakeRotFromX(TargetLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner())).Yaw, 0f);
		CameraState.DeltaRotation.SetValue((CameraState.TargetRotation - CameraState.BeginRotation).Clamp());
		float num = MathLib.Abs(UBUS_UtilComm.CalcDegreeFromRotatorsInYaw(CameraState.BeginRotation.ToRotator(), CameraState.TargetRotation.ToRotator()));
		CameraState.G4TurnRunTime = 0f;
		CameraState.TickTotalTime = MathLib.Abs(num / -360f);
		CameraState.IsTurning = true;
		return true;
	}

	private void OnCameraG4AutoTrace(FTransform TargetTransform)
	{
		if (CameraState.FreeCameraMode == EPlayerFreeCameraType.G4Mode || CameraState.FreeCameraMode == EPlayerFreeCameraType.SeqMatch)
		{
			CameraState.BeginRotation.SetValue(0f, CameraState.Rt_ControllerRotation.Yaw, 0f);
			CameraState.TargetRotation.SetValue(0f, MathLib.MakeRotFromX(TargetTransform.GetLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(GetOwner())).Yaw, 0f);
			CameraState.DeltaRotation.SetValue((CameraState.TargetRotation - CameraState.BeginRotation).Normalize());
			float num = MathLib.Abs(UBUS_UtilComm.CalcDegreeFromRotatorsInYaw(CameraState.BeginRotation.ToRotator(), CameraState.TargetRotation.ToRotator()));
			if (!(num <= 10f))
			{
				CameraState.G4TurnRunTime = 0f;
				CameraState.TickTotalTime = MathLib.Abs(num / 20f);
				CameraState.IsTurning = false;
			}
		}
	}

	private void OnSetShootSuctionTargetDir(FVector Dir)
	{
		CameraState.ShootSuctionTargetDir.SetValue(Dir);
	}

	private void OnSetTraceVelocityCameraInfo(bool bUseTraceVelocityCamera, float TraceSpeedRate, bool bOnlyYaw, float InverseTraceAngle, float PauseTimeWhenCameraInput)
	{
		CameraState.bUseTraceVelocityCamera = bUseTraceVelocityCamera;
		CameraState.TraceVelocitySpeedRate = TraceSpeedRate;
		CameraState.bTraceVelocityOnlyYaw = bOnlyYaw;
		CameraState.TraceVelocityInverseAngle = InverseTraceAngle;
		CameraState.TraceVelocityPauseTimeWhenCameraInput = PauseTimeWhenCameraInput;
	}

	private void OnMoveCameraSpringArm2CustomRotation(FRotator InCustomRotation)
	{
		CameraState.ResetSpringArmRotationWay = EResetSpringArmRotationWay.UseCustomRotation;
		CameraState.CustomSpringArmRotation = InCustomRotation;
	}

	private void OnResetCameraSpringArmRot()
	{
		CameraState.ResetSpringArmRotationWay = EResetSpringArmRotationWay.Reset2PlayerRotation;
	}

	private void OnMoveCameraSpringArmRot2Nearest()
	{
		CameraState.ResetSpringArmRotationWay = EResetSpringArmRotationWay.Reset2NearestRotation;
	}

	private void OnSwitchFreeCameraMode(EPlayerFreeCameraType InFreeCameraType)
	{
		if (InFreeCameraType == EPlayerFreeCameraType.None)
		{
			if (PlayerCameraData.IsInG4Mode())
			{
				OnMoveCameraSpringArmRot2Nearest();
				InFreeCameraType = EPlayerFreeCameraType.AutoTrail;
			}
			else
			{
				InFreeCameraType = EPlayerFreeCameraType.G4Mode;
			}
		}
		CameraState.FreeCameraMode = InFreeCameraType;
	}

	private void ApplyLockCamera()
	{
		if (CameraState.IsLocked)
		{
			OnGiantLockTarget();
			if (CameraState.LockCamMode == ELockCamMode.Soul)
			{
				OnStraightLockTarget();
			}
			else if (CameraState.LockCamMode == ELockCamMode.Dmc)
			{
				OnDiagonalLockTarget();
			}
		}
	}

	private void OnEnableArmLengthCurve(FGSFloatCurveToParam InArmLengthCurve, float BlendInTime)
	{
		if (!(InArmLengthCurve.CurveFloat == null))
		{
			CameraState.ArmLengthCurve = InArmLengthCurve;
			CameraState.ArmLengthCurveTime = 0f;
			CameraState.ArmLengthCurveBlendTimer = BlendInTime;
			CameraState.ArmLengthCurveOriValue = CameraState.Rt_ArmLength;
			CameraState.HasArmLengthCurve = true;
		}
	}

	private void OnDisableArmLengthCurve(float BlendOutTime)
	{
		if (CameraState.HasArmLengthCurve)
		{
			CameraState.ArmLengthCurveBlendOutTime = BlendOutTime;
			CameraState.ArmLengthCurveBlendTimer = BlendOutTime;
			CameraState.HasArmLengthCurve = false;
		}
	}

	private void OnEnableSASOCurve(UCurveVector InSASOCurve, float BlendInTime)
	{
		if (!(InSASOCurve == null))
		{
			CameraState.SASOCurve = InSASOCurve;
			CameraState.SASOCurveTime = 0f;
			CameraState.SASOCurveBlendTimer = BlendInTime;
			CameraState.SASOCurveOriValue = GSLocationPool.New();
			CameraState.SASOCurveOriValue.SetValue(CameraState.Rt_ArmSocketOffset);
			CameraState.HasSASOCurve = true;
		}
	}

	private void OnDisableSASOCurve(float BlendOutTime)
	{
		if (CameraState.HasSASOCurve)
		{
			CameraState.SASOCurveBlendOutTime = BlendOutTime;
			CameraState.SASOCurveBlendTimer = BlendOutTime;
			CameraState.HasSASOCurve = false;
		}
	}

	private void OnEnablePitchCurve(FGSFloatCurveToParam InPitchCurve, float BlendInTime)
	{
		if (!(InPitchCurve.CurveFloat == null))
		{
			CameraState.PitchCurve = InPitchCurve;
			CameraState.PitchCurveTime = 0f;
			CameraState.PitchCurveBlendTimer = BlendInTime;
			CameraState.PitchCurveOriValue = GSRotationPool.New();
			CameraState.PitchCurveOriValue.SetValue(CameraState.Rt_ControllerRotation);
			CameraState.HasPitchCurve = true;
		}
	}

	private void OnDisablePitchCurve()
	{
		CameraState.HasPitchCurve = false;
	}

	private void OnEnableArmLocationZCurve(FGSFloatCurveToParam InArmLocationZCurve, float BlendInTime)
	{
		if (!(InArmLocationZCurve.CurveFloat == null))
		{
			CameraState.ArmLocationZCurve = InArmLocationZCurve;
			CameraState.ArmLocationZCurveTime = 0f;
			CameraState.ArmLocationZCurveBlendTime = BlendInTime;
			CameraState.ArmLocationZCurveOriValue = CameraState.Rt_ArmLocation.Z;
			CameraState.HasArmLocationZCurve = true;
		}
	}

	private void OnDisableArmLocationZCurve(float BlendOutTime)
	{
		if (CameraState.HasArmLocationZCurve)
		{
			CameraState.ArmLocationZCurveBlendOutTime = BlendOutTime;
			CameraState.ArmLocationZCurveBlendTime = BlendOutTime;
			CameraState.HasArmLocationZCurve = false;
		}
	}

	private void CheckPlayerCameraId()
	{
		if (CameraState.FreeCameraMode == EPlayerFreeCameraType.G4Mode || CameraState.FreeCameraMode == EPlayerFreeCameraType.SeqMatch)
		{
			if (CameraState.DefaultCameraId != CameraState.DefaultCameraIDForWalk)
			{
				CameraState.DefaultCameraId = CameraState.DefaultCameraIDForWalk;
			}
		}
		else if (CameraState.IsJumping || CameraState.IsCloudVerticalLifting || (!CameraState.Has907Buff && CameraState.IsFalling))
		{
			if (CameraState.DefaultCameraId != CameraState.DefaultCameraIDForJump)
			{
				CameraState.DefaultCameraId = CameraState.DefaultCameraIDForJump;
			}
		}
		else if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			if (CameraState.DefaultCameraId != CameraState.DefaultCameraIDForGlideMoving)
			{
				CameraState.DefaultCameraId = CameraState.DefaultCameraIDForGlideMoving;
			}
		}
		else if (CameraState.bUseSplineMoveCamera)
		{
			if (CameraState.DefaultCameraId != CameraState.DefaultCameraIDForSplineMove)
			{
				CameraState.DefaultCameraId = CameraState.DefaultCameraIDForSplineMove;
			}
		}
		else if (UnitStateData.HasState(EBGUUnitState.Sprinting) && !UnitStateData.HasState(EBGUUnitState.Attacking) && MovementData.bInputMoving && (CameraState.DefaultCameraId == CameraState.DefaultCameraIDForSprint || CameraState.PlayerVelocity.Size() > 10f))
		{
			if (CameraState.DefaultCameraId != CameraState.DefaultCameraIDForSprint)
			{
				CameraState.DefaultCameraId = CameraState.DefaultCameraIDForSprint;
			}
		}
		else if (!PlayerBuffData.HasBuff(306))
		{
			if (CameraState.DefaultCameraId != CameraState.DefaultCameraIDForRun)
			{
				CameraState.DefaultCameraId = CameraState.DefaultCameraIDForRun;
			}
		}
		else if (HardMoveData.IsHardMoving() && CameraState.DefaultCameraId != CameraState.DefaultCameraIDForHardMove)
		{
			CameraState.DefaultCameraId = CameraState.DefaultCameraIDForHardMove;
		}
	}

	private void OnInputAxisTurnRight(float AxisVal)
	{
		if (!CameraState.IsLocked)
		{
			float num = 1f;
			int num2 = 1;
			CameraState.bInputAxisTurnRightByGamePad = false;
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.CameraMoveSpeedBase);
			float num3 = (float)GameDBRuntime.GetCommLogicCfgValue(CommCfgType.CameraMoveSpeedCoefficiet) * 0.0001f;
			if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
			{
				num2 = ((!SettingMgr.GetCVBoolByType(UISettingConfigType.MouseReverseHorControl)) ? 1 : (-1));
				int cVValueleByType = SettingMgr.GetCVValueleByType(UISettingConfigType.MouseHorRotateSpeed);
				num = ((float)commLogicCfgValue + (float)(cVValueleByType - commLogicCfgValue) * num3) / 100f;
			}
			else if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
			{
				num2 = ((!SettingMgr.GetCVBoolByType(UISettingConfigType.ReverseHorControl)) ? 1 : (-1));
				int cVValueleByType2 = SettingMgr.GetCVValueleByType(UISettingConfigType.HorRotateSpeed);
				num = ((float)commLogicCfgValue + (float)(cVValueleByType2 - commLogicCfgValue) * num3) / 100f;
				CameraState.bInputAxisTurnRightByGamePad = true;
			}
			if (AxisVal != 0f)
			{
				CameraState.InputAxisTurnRight = AxisVal * num * (float)num2;
				CameraState.LastCameraInputTimer = 0f;
			}
		}
	}

	private void OnInputAxisUp(float AxisVal)
	{
		if (!CameraState.IsLocked)
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(GetOwner());
			float num = 1f;
			int num2 = 1;
			CameraState.bInputAxisLookUpByGamePad = false;
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.CameraMoveSpeedBase);
			float num3 = (float)GameDBRuntime.GetCommLogicCfgValue(CommCfgType.CameraMoveSpeedCoefficiet) * 0.0001f;
			if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.KeyboardMouse)
			{
				num2 = ((!bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.MouseReverseVerControl)) ? 1 : (-1));
				int cVValueleByType = bGW_SettingMgrV.GetCVValueleByType(UISettingConfigType.MouseVerRotateSpeed);
				num = ((float)commLogicCfgValue + (float)(cVValueleByType - commLogicCfgValue) * num3) / 100f;
			}
			else if (BGW_EnhancedInputMgrV2.GetCurrentInputType() == EGSInputType.Gamepad)
			{
				num2 = ((!bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.ReverseVerControl)) ? 1 : (-1));
				int cVValueleByType2 = bGW_SettingMgrV.GetCVValueleByType(UISettingConfigType.VerRotateSpeed);
				num = ((float)commLogicCfgValue + (float)(cVValueleByType2 - commLogicCfgValue) * num3) / 100f;
				CameraState.bInputAxisLookUpByGamePad = true;
			}
			if (AxisVal != 0f)
			{
				CameraState.InputAxisLookUp = AxisVal * num * (float)num2;
				CameraState.LastCameraInputTimer = 0f;
			}
		}
	}

	private void OnEnableCustomCameraPitch(bool bInUseCustomPitch, float InCustomPitch)
	{
		PlayerCameraData.ControlData.bUseCustomCameraPitch = bInUseCustomPitch;
		PlayerCameraData.ControlData.CustomCameraPitch = InCustomPitch;
	}

	private void OnEnableCustomFOV(bool bInUseCustomFov)
	{
		PlayerCameraData.ControlData.bUseCustomFov = bInUseCustomFov;
	}

	private void OnClearLock()
	{
		Target = null;
		CameraState.TargetResID = 0;
		CameraState.TargetExtendID = 0;
		CameraState.IsLocked = false;
		CameraState.MultiLockCameraID = 0;
		CameraState.CurrentLockCameraID = 0;
		SetViewTargetTo_DEPRECATED(Player);
	}

	private void OnUnitRebirth(ERebirthType RebirthType)
	{
		CameraState.bPlayerDuringRebirth = true;
		SpringArmComponent.EnableCameraLag = false;
	}

	private void AfterUnitRebirth(ERebirthType RebirthType)
	{
		CameraState.bPlayerDuringRebirth = false;
		SpringArmComponent.EnableCameraLag = true;
	}

	private void OnUnitStateUpdated(EBUStateTrigger TriggerID)
	{
		switch (TriggerID)
		{
		case EBUStateTrigger.TeleportBegin:
			CameraState.bPlayerDuringRebirth = true;
			SpringArmComponent.EnableCameraLag = false;
			break;
		case EBUStateTrigger.TeleportEnd:
			CameraState.bPlayerDuringRebirth = false;
			SpringArmComponent.EnableCameraLag = true;
			break;
		}
	}

	private void OnSetSyncCamera(USceneComponent SocketOwnerComp, ACameraActor NewCamera, FName InCameraSyncPointOnHost)
	{
		PlayerCameraData.DummyMeshComp = SocketOwnerComp;
		PlayerCameraData.SyncCamera = NewCamera;
		PlayerCameraData.CameraSyncPointOnHost = InCameraSyncPointOnHost;
		PlayerCameraData.LastCameraSyncPointOnHost = InCameraSyncPointOnHost;
		PlayerCameraData.SwitchSyncPointBlendTime = 0f;
		PlayerCameraData.SwitchSyncPointBlendTimer = 0f;
	}

	private void OnSyncCameraSwitchSyncPoint(FName InCameraSyncPointOnHost, float BlendTime)
	{
		if (!(PlayerCameraData.SwitchSyncPointBlendTime > 0f))
		{
			PlayerCameraData.CameraSyncPointOnHost = InCameraSyncPointOnHost;
			PlayerCameraData.SwitchSyncPointBlendTime = BlendTime;
			PlayerCameraData.SwitchSyncPointBlendTimer = 0f;
		}
	}

	private void OnStraightLockTarget()
	{
		SetStraightCamera(CameraState.CurrentLockCameraID);
		CameraState.LockCamMode = ELockCamMode.Soul;
		SetViewTargetTo_DEPRECATED(Player);
	}

	private void OnDiagonalLockTarget()
	{
		int currentLockCameraID = CameraState.CurrentLockCameraID;
		SetDiagonalCamera(currentLockCameraID);
	}

	private void OnGiantLockTarget()
	{
		SetGiantCamera(CameraState.CurrentLockCameraID);
		SetViewTargetTo_DEPRECATED(Player);
	}

	private void OnSetPlayerCameraParam(EPlayerCameraTableParamType ParamType, float ParamValue)
	{
		switch (ParamType)
		{
		case EPlayerCameraTableParamType.ArmLengthDefault:
			CameraState.OriginDefaultArmLengthDefault = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmLengthSpeed:
			CameraState.DefaultArmLengthLerpSpeed = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmRelativeLocationX:
			CameraState.DefaultArmLocation.X = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmRelativeLocationY:
			CameraState.DefaultArmLocation.Y = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmRelativeLocationZ:
			CameraState.OriginDefaultArmLocationZ = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmRelativeLocationLerpSpeed:
			CameraState.DefaultArmLocationLerpSpeed = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmSocketOffsetX:
			CameraState.DefaultArmSocketOffset.X = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmSocketOffsetY:
			CameraState.DefaultArmSocketOffset.Y = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmSocketOffsetZ:
			CameraState.OriginDefaultArmSocketOffsetZ = ParamValue;
			break;
		case EPlayerCameraTableParamType.ArmSocketOffsetLerpSpeed:
			CameraState.DefaultArmSocketOffsetLerpSpeed = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetX:
			CameraState.DefaultInverseOffset.X = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetY:
			CameraState.DefaultInverseOffset.Y = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetZ:
			CameraState.DefaultInverseOffset.Z = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetSpeedX:
			CameraState.DefaultInverseOffsetSpeed.X = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetSpeedY:
			CameraState.DefaultInverseOffsetSpeed.Y = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetSpeedZ:
			CameraState.DefaultInverseOffsetSpeed.Z = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetResetSpeedX:
			CameraState.DefaultInverseOffsetResetSpeed.X = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetResetSpeedY:
			CameraState.DefaultInverseOffsetResetSpeed.Y = ParamValue;
			break;
		case EPlayerCameraTableParamType.InverseOffsetResetSpeedZ:
			CameraState.DefaultInverseOffsetResetSpeed.Z = ParamValue;
			break;
		case EPlayerCameraTableParamType.MeshZOffsetLimit:
			CameraState.OriginDefaultMeshZOffsetLimit = ParamValue;
			break;
		case EPlayerCameraTableParamType.FocalDistance:
			CameraState.DefaultFocalDistance = ParamValue;
			break;
		case EPlayerCameraTableParamType.DepthBlurKm:
			CameraState.DefaultDepthBlurKM = ParamValue;
			break;
		case EPlayerCameraTableParamType.DepthBlurRadius:
			CameraState.DefaultDepthBlurRadius = ParamValue;
			break;
		case EPlayerCameraTableParamType.Fov:
			CameraState.DefaultFOV = ParamValue;
			break;
		case EPlayerCameraTableParamType.FovSpeed:
			CameraState.DefaultFOVLerpSpeed = ParamValue;
			break;
		case EPlayerCameraTableParamType.PitchMin:
			CameraState.DefaultPitchMin = ParamValue;
			break;
		case EPlayerCameraTableParamType.PitchMax:
			CameraState.DefaultPitchMax = ParamValue;
			break;
		case EPlayerCameraTableParamType.YawMin:
			CameraState.DefaultYawMin = ParamValue;
			break;
		case EPlayerCameraTableParamType.YawMax:
			CameraState.DefaultYawMax = ParamValue;
			break;
		}
	}

	private void OnSetStraightCameraParam(EStraightCameraTableParamType ParamType, float ParamValue)
	{
		switch (ParamType)
		{
		case EStraightCameraTableParamType.ArmLength:
			CameraState.OriginStraightCameraArmLengthDefault = ParamValue;
			break;
		case EStraightCameraTableParamType.ArmLengthSpeed:
			CameraState.StraightArmLengthSpeed = ParamValue;
			break;
		case EStraightCameraTableParamType.RefType:
			CameraState.CamRefType = (ECamRefType)(int)ParamValue;
			break;
		case EStraightCameraTableParamType.TargetRefHeight:
			CameraState.StraightTargetRefHeightOffset = ParamValue;
			break;
		case EStraightCameraTableParamType.PlayerRefHeight:
			CameraState.OriginStraightPlayerRefHeightOffset = ParamValue;
			break;
		case EStraightCameraTableParamType.TargetRefHeightSpeed:
			CameraState.StraightTargetRefHeightOffsetSpeed = ParamValue;
			break;
		case EStraightCameraTableParamType.PlayerRefHeightSpeed:
			CameraState.StraightPlayerRefHeightOffsetSpeed = ParamValue;
			break;
		case EStraightCameraTableParamType.HeightThreshold:
			CameraState.StraightHeightThreshold = ParamValue;
			break;
		case EStraightCameraTableParamType.TraceSolution:
			CameraState.StraightTraceSolution = (ESlowTraceSolution)(int)ParamValue;
			break;
		case EStraightCameraTableParamType.SlowTraceMaxYaw:
			CameraState.StraightSlowTraceTargetRefMaxYaw = ParamValue;
			break;
		case EStraightCameraTableParamType.SlowTraceMaxDistance:
			CameraState.StraightMaxTraceTargetRefDist = ParamValue;
			break;
		case EStraightCameraTableParamType.SlowTraceTargetRefSpeed:
			CameraState.StraightTraceTargetRefSpeed = ParamValue;
			break;
		case EStraightCameraTableParamType.SlowTraceYawSpeed:
			CameraState.StraightYawTraceSpeed = ParamValue;
			break;
		case EStraightCameraTableParamType.SlowTracePitchSpeed:
			CameraState.StraightPitchTraceSpeed = ParamValue;
			break;
		case EStraightCameraTableParamType.MinPitch:
			CameraState.StraightMinPitch = ParamValue;
			break;
		case EStraightCameraTableParamType.MaxPitch:
			CameraState.StraightMaxPitch = ParamValue;
			break;
		case EStraightCameraTableParamType.HeightScaleFactor:
			CameraState.StraightHeightScaleFactor = ParamValue;
			break;
		case EStraightCameraTableParamType.HeightScaleMaxDistance:
			CameraState.StraightHeightScaleFurthestDist = ParamValue;
			break;
		}
	}

	private void OnSetDiagonalCameraParam(EDiagonalCameraTableParamType ParamType, float ParamValue)
	{
		switch (ParamType)
		{
		case EDiagonalCameraTableParamType.PlayerRefOffset:
			CameraState.Diagonal_PlayerRefOffset = ParamValue;
			break;
		case EDiagonalCameraTableParamType.TargetRefOffset:
			CameraState.Diagonal_TargetRefOffset = ParamValue;
			break;
		case EDiagonalCameraTableParamType.RefOffsetBase:
			CameraState.Diagonal_RefOffsetBase = ParamValue;
			break;
		case EDiagonalCameraTableParamType.RefOffsetDistance:
			CameraState.Diagonal_RefOffsetDistance = ParamValue;
			break;
		case EDiagonalCameraTableParamType.P2TRatio:
			CameraState.Diagonal_P2TRatio = ParamValue;
			break;
		case EDiagonalCameraTableParamType.PosLerpSpeed:
			CameraState.Diagonal_PosLerpSpeed = ParamValue;
			break;
		case EDiagonalCameraTableParamType.AngleOffset:
			CameraState.Diagonal_AngleOffset = ParamValue;
			break;
		case EDiagonalCameraTableParamType.PitchBase:
			CameraState.Diagonal_PitchBase = ParamValue;
			break;
		case EDiagonalCameraTableParamType.PitchFadeDistance:
			CameraState.Diagonal_PitchFadeDistance = ParamValue;
			break;
		case EDiagonalCameraTableParamType.RotationLerpSpeedLow:
			CameraState.Diagonal_RotLerpSpeedLow = ParamValue;
			break;
		case EDiagonalCameraTableParamType.RotationLerpSpeedHigh:
			CameraState.Diagonal_RotLerpSpeedHigh = ParamValue;
			break;
		case EDiagonalCameraTableParamType.ArmLengthMin:
			CameraState.Diagonal_ArmLengthMin = ParamValue;
			break;
		case EDiagonalCameraTableParamType.ArmLengthMax:
			CameraState.Diagonal_ArmLengthMax = ParamValue;
			break;
		case EDiagonalCameraTableParamType.ArmLengthChangeValue:
			CameraState.Diagonal_ArmLengthChangeValue = ParamValue;
			break;
		case EDiagonalCameraTableParamType.ArmLengthLerpSpeed:
			CameraState.Diagonal_ArmLengthLerpSpeed = ParamValue;
			break;
		}
	}

	private void OnSetGiantCameraParam(EGiantCameraTableParamType ParamType, float ParamValue)
	{
		switch (ParamType)
		{
		case EGiantCameraTableParamType.ArmLength:
			CameraState.GiantArmLength = ParamValue;
			break;
		case EGiantCameraTableParamType.ArmLengthSpeed:
			CameraState.GiantArmLengthLerpSpeed = ParamValue;
			break;
		case EGiantCameraTableParamType.TargetRefHeightOffset:
			CameraState.GiantTargetRefHeightOffset = ParamValue;
			break;
		case EGiantCameraTableParamType.PlayerRefHeightOffset:
			CameraState.GiantPlayerRefHeightOffset = ParamValue;
			break;
		case EGiantCameraTableParamType.TargetRefHeightOffsetSpeed:
			CameraState.GiantTargetRefHeightOffsetLerpSpeed = ParamValue;
			break;
		case EGiantCameraTableParamType.PlayerRefHeightOffsetSpeed:
			CameraState.GiantPlayerRefHeightOffsetLerpSpeed = ParamValue;
			break;
		case EGiantCameraTableParamType.TargetHeightThreshold:
			CameraState.GiantHeightThreshold = ParamValue;
			break;
		case EGiantCameraTableParamType.MinPitch:
			CameraState.GiantMinPitch = ParamValue;
			break;
		case EGiantCameraTableParamType.MaxPitch:
			CameraState.GiantMaxPitch = ParamValue;
			break;
		case EGiantCameraTableParamType.PitchLerpSpeed:
			CameraState.GiantPitchLerpSpeed = ParamValue;
			break;
		case EGiantCameraTableParamType.TargetScreenMaxRatio:
			CameraState.GiantTargetScreenMaxRatio = ParamValue;
			break;
		case EGiantCameraTableParamType.PlayerScreenRatio:
			CameraState.GiantPlayerScreenRatio = ParamValue;
			break;
		case EGiantCameraTableParamType.CameraOffsetLerpSpeed:
			CameraState.GiantCameraOffsetLerpSpeed = ParamValue;
			break;
		}
	}

	private bool SetDiagonalCamera(int CameraId)
	{
		FUStDiagonalCamDesc diagonalCamDescDesc = BGW_GameDB.GetDiagonalCamDescDesc(CameraId, CameraState.PlayerResId);
		if (diagonalCamDescDesc == null)
		{
			BGW_LogUtil.LogError($"BUS_PlayerCameraComp Warning: 切换Diagonal锁定失败：未找到CameraId = {CameraId}, PlayerId = {CameraState.PlayerResId}的镜头", P1: true, Player, 2f, EBGULogColor.Red);
			return false;
		}
		CameraState.LockCamMode = ELockCamMode.Dmc;
		CameraState.Diagonal_PlayerRefOffset = diagonalCamDescDesc.PRef;
		CameraState.Diagonal_TargetRefOffset = diagonalCamDescDesc.ERef;
		CameraState.Diagonal_RefOffsetBase = diagonalCamDescDesc.RefOffsetBase;
		CameraState.Diagonal_RefOffsetDistance = diagonalCamDescDesc.RefOffsetDis;
		CameraState.Diagonal_P2TRatio = diagonalCamDescDesc.P2TRatio;
		CameraState.Diagonal_PosLerpSpeed = diagonalCamDescDesc.PosLerpSpd;
		CameraState.Diagonal_AngleOffset = diagonalCamDescDesc.AngleOffset;
		CameraState.Diagonal_PitchBase = diagonalCamDescDesc.PitchBase;
		CameraState.Diagonal_PitchFadeDistance = diagonalCamDescDesc.PitchFadeDis;
		CameraState.Diagonal_RotLerpSpeedLow = diagonalCamDescDesc.RotLerpSpdLow;
		CameraState.Diagonal_RotLerpSpeedHigh = diagonalCamDescDesc.RotLerpSpdHigh;
		CameraState.Diagonal_ArmLengthMin = diagonalCamDescDesc.ArmMin;
		CameraState.Diagonal_ArmLengthMax = diagonalCamDescDesc.ArmMax;
		CameraState.Diagonal_ArmLengthChangeValue = diagonalCamDescDesc.ArmChangeValue;
		CameraState.Diagonal_ArmLengthLerpSpeed = diagonalCamDescDesc.ArmLerpSpd;
		return true;
	}

	private void OnLockTarget(AActor InTarget, string LockedSocketName)
	{
		if (InTarget == null)
		{
			BGW_LogUtil.LogError("BUS_PlayerCameraComp OnLockTarget Failed: 目标不存在");
			return;
		}
		if (Target != null && InTarget != Target && ControllerCameraData.SkillCameraDictionary.ContainsKey(Target))
		{
			ExitCurrentTargetSkillCamera();
		}
		Target = InTarget;
		FUStUnitCommDesc fUStUnitCommDesc = null;
		FUStUnitBattleInfoExtendDesc fUStUnitBattleInfoExtendDesc = null;
		int num;
		if (InTarget is BGUCharacterCS)
		{
			TargetInfoData = BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(Target);
			if (TargetInfoData == null)
			{
				return;
			}
			CameraState.bTargetSupportMultiPointLock = TargetInfoData.IsSupportMultiLockTarget();
			num = BGU_DataUtil.GetActorResID(InTarget);
			fUStUnitCommDesc = BGW_GameDB.GetUnitCommDesc(num);
			if (fUStUnitCommDesc == null)
			{
				return;
			}
			CameraState.TargetResID = num;
			CameraState.TargetExtendID = BGU_DataUtil.GetFinalBattleInfoExtendID(InTarget);
			fUStUnitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(CameraState.TargetExtendID);
			if (fUStUnitBattleInfoExtendDesc != null && !string.IsNullOrEmpty(fUStUnitBattleInfoExtendDesc.FoliageFadeScaleCurve))
			{
				CameraState.FoliageFadeScaleCurve.Set(BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(fUStUnitBattleInfoExtendDesc.FoliageFadeScaleCurve, ELoadResourceType.SyncLoadAndCache));
			}
			else
			{
				CameraState.FoliageFadeScaleCurve.Set(null);
			}
		}
		else
		{
			CameraState.bTargetSupportMultiPointLock = false;
			num = CameraState.PlayerResId;
			fUStUnitCommDesc = BGW_GameDB.GetUnitCommDesc(num);
			if (fUStUnitCommDesc == null)
			{
				return;
			}
			fUStUnitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BGU_DataUtil.GetFinalBattleInfoExtendID(Owner));
		}
		if (fUStUnitBattleInfoExtendDesc == null)
		{
			BGW_LogUtil.LogError($"BUS_PlayerCameraComp OnLockTarget Failed: 该单位缺少BattleExtend表 UnitResID：{fUStUnitCommDesc.ID}");
			return;
		}
		if (fUStUnitBattleInfoExtendDesc.LockCamMode != ELockCamMode.Soul && fUStUnitBattleInfoExtendDesc.LockCamMode != ELockCamMode.Dmc)
		{
			BGW_LogUtil.LogError($"BUS_PlayerCameraComp OnLockTarget Failed: 未知ELockCamMode值：{fUStUnitBattleInfoExtendDesc.LockCamMode}");
			return;
		}
		CameraState.IsLocked = true;
		CameraState.bResetStraightPlayerRefCache = true;
		CameraState.LockTargetId = num;
		CameraState.DefaultLockCameraId = fUStUnitBattleInfoExtendDesc.DefaultCamID;
		if (CameraState.LockCameraIdOverrides.ContainsKey(num))
		{
			CameraState.CurrentLockCameraID = CameraState.LockCameraIdOverrides[num];
		}
		else
		{
			CameraState.CurrentLockCameraID = CameraState.DefaultLockCameraId;
		}
		if (string.IsNullOrEmpty(LockedSocketName))
		{
			LockedSocketName = "CAMERA_LOCK";
		}
		CameraState.LockTargetSocketName = LockedSocketName;
		if (ControllerCameraData.SkillCameraDictionary.TryGetValue(Target, out var value))
		{
			EnterCurrentTargetSkillCamera(value);
		}
		else
		{
			OnGiantLockTarget();
			if (fUStUnitBattleInfoExtendDesc.LockCamMode == ELockCamMode.Soul)
			{
				OnStraightLockTarget();
			}
			else if (fUStUnitBattleInfoExtendDesc.LockCamMode == ELockCamMode.Dmc)
			{
				OnDiagonalLockTarget();
			}
		}
		List<UActorComponent> componentsByTag = Target.GetComponentsByTag(UClass.GetClass<USceneComponent>(), FCameraDefaultData.SoulFocusName);
		SoulFocusSceneComponent = ((componentsByTag.Count > 0) ? (componentsByTag[0] as USceneComponent) : null);
		componentsByTag = Target.GetComponentsByTag(UClass.GetClass<USceneComponent>(), FCameraDefaultData.SoulFocusZName);
		SoulFocusZSceneComponent = ((componentsByTag.Count > 0) ? (componentsByTag[0] as USceneComponent) : null);
	}

	private void OnEnableAutoMoveTrail(FVector AutoMoveTargetDir)
	{
		CameraState.IsAutoMoveTrailEnabled = true;
		CameraState.AutoMoveTargetDir = AutoMoveTargetDir;
	}

	private void OnDisableAutoMoveTrail()
	{
		CameraState.IsAutoMoveTrailEnabled = false;
	}

	private void OnEnableGuiBeiCamera(FRotator InverseAnimRotator)
	{
		CameraState.IsUseGuiBeiCamera = true;
		CameraState.CurInverseAnimRotator.SetValue(InverseAnimRotator);
	}

	private void OnDisableGuiBeiCamera()
	{
		CameraState.IsUseGuiBeiCamera = false;
	}

	private void OnSetCloudMoveCameraPitchLimit(float PitchMax)
	{
		CameraState.CurCloudMovePitchMax = PitchMax;
	}

	private void OnSetCloudMoveCameraPitchLimitEnabled(bool bIsEnabled)
	{
		CameraState.bIsCloudMovePitchLimitEnabled = bIsEnabled;
	}

	private void OnSetCloudMoveEnabled(bool bIsEnabled)
	{
		CameraState.bIsCloudMoving = bIsEnabled;
		CameraState.CloudFoliageFadeScaleCurve.Set(BGW_PreloadAssetMgr.Get(Owner).CloudMoveConfig?.CloudFoliageFadeScaleCurve);
	}

	private void SetViewTargetTo_DEPRECATED(AActor InViewTarget)
	{
	}

	private void ApplyCameraGroup()
	{
		int cameraGroupID = ControllerCameraData.GetCameraGroupID();
		if (CameraState.CurrentCameraGroupId == cameraGroupID)
		{
			return;
		}
		foreach (KeyValuePair<int, int> lockCameraIdOverride in CameraState.LockCameraIdOverrides)
		{
			if (lockCameraIdOverride.Key == CameraState.LockTargetId)
			{
				CameraState.CurrentLockCameraID = CameraState.DefaultLockCameraId;
				ApplyLockCamera();
			}
		}
		CameraState.CurrentCameraGroupId = cameraGroupID;
		FUStCameraGroupDesc cameraGroupDesc = BGW_GameDB.GetCameraGroupDesc(CameraState.CurrentCameraGroupId, CameraState.PlayerResId);
		if (cameraGroupDesc == null)
		{
			cameraGroupDesc = BGW_GameDB.GetCameraGroupDesc(0, CameraState.PlayerResId);
		}
		if (cameraGroupDesc == null)
		{
			return;
		}
		if (cameraGroupDesc.PlayerStateCameraIDList.Count >= 6)
		{
			CameraState.DefaultCameraIDForWalk = cameraGroupDesc.PlayerStateCameraIDList[0];
			CameraState.DefaultCameraIDForRun = cameraGroupDesc.PlayerStateCameraIDList[1];
			CameraState.DefaultCameraIDForSprint = cameraGroupDesc.PlayerStateCameraIDList[2];
			CameraState.DefaultCameraIDForHardMove = cameraGroupDesc.PlayerStateCameraIDList[3];
			CameraState.DefaultCameraIDForGlideMoving = cameraGroupDesc.PlayerStateCameraIDList[4];
			CameraState.DefaultCameraIDForJump = cameraGroupDesc.PlayerStateCameraIDList[5];
			CameraState.DefaultCameraIDForSplineMove = cameraGroupDesc.PlayerStateCameraIDList[6];
		}
		CameraState.PlayerSkillCameraIdOverrides.Clear();
		int count = cameraGroupDesc.PlayerSkillCameraIDList.Count;
		for (int i = 0; i < count; i++)
		{
			CameraState.PlayerSkillCameraIdOverrides.Add(cameraGroupDesc.PlayerSkillCameraIDList[i]);
		}
		CameraState.LockCameraIdOverrides.Clear();
		foreach (FUStUnitSoulCamera relativeUnit in cameraGroupDesc.RelativeUnitList)
		{
			int resID = relativeUnit.ResID;
			CameraState.LockCameraIdOverrides.Add(resID, relativeUnit.SoulCameraID);
			if (resID == CameraState.LockTargetId)
			{
				CameraState.CurrentLockCameraID = relativeUnit.SoulCameraID;
				ApplyLockCamera();
			}
		}
	}

	private void OnApplyCameraId()
	{
		CameraState.bUsePlayerSkillCamera = ControllerCameraData.SkillCameraIdOverride >= 0;
		int num = (CameraState.bUsePlayerSkillCamera ? ControllerCameraData.SkillCameraIdOverride : CameraState.DefaultCameraId);
		if (CameraState.CurrentCameraID != num || CheckViewPortORRatioChanged())
		{
			CameraState.bEnablePlayerCameraConversionParam = false;
			CameraState.CurrentCameraID = num;
			FUStPlayerCameraDesc playerCameraDesc = BGW_GameDB.GetPlayerCameraDesc(Player.GetResID(), CameraState.CurrentCameraID);
			if (playerCameraDesc == null)
			{
				playerCameraDesc = BGW_GameDB.GetPlayerCameraDesc(CameraState.WukongResID, CameraState.CurrentCameraID);
				CameraState.bEnablePlayerCameraConversionParam = true;
			}
			if (playerCameraDesc != null)
			{
				CameraState.DefaultArmLengthClose = playerCameraDesc.ArmLengthClose;
				CameraState.DefaultArmLengthNormal = playerCameraDesc.ArmLengthMid;
				CameraState.DefaultArmLengthFar = playerCameraDesc.ArmLengthFar;
				CameraState.DefaultArmLengthDefault = playerCameraDesc.ArmLengthDefault;
				CameraState.DefaultArmLengthLerpSpeed = playerCameraDesc.ArmLengthSpeed;
				CameraState.DefaultFreeCameraArmLength_Min = playerCameraDesc.FreeCameraArmLengthMin;
				CameraState.DefaultFreeCameraArmLength_Max = playerCameraDesc.FreeCameraArmLengthMax;
				CameraState.DefaultArmLocation.SetValue(playerCameraDesc.ArmRelativeLocationX, playerCameraDesc.ArmRelativeLocationY, playerCameraDesc.ArmRelativeLocationZ);
				CameraState.DefaultArmLocationLerpSpeed = playerCameraDesc.ArmRelativeLocationSpeed;
				CameraState.DefaultArmSocketOffset.SetValue(playerCameraDesc.ArmSocketOffsetX, playerCameraDesc.ArmSocketOffsetY, playerCameraDesc.ArmSocketOffsetZ);
				CameraState.DefaultArmSocketOffsetLerpSpeed = playerCameraDesc.ArmSocketOffsetSpeed;
				CameraState.DefaultInverseOffset.SetValue(playerCameraDesc.InverseOffsetX, playerCameraDesc.InverseOffsetY, playerCameraDesc.InverseOffsetZ);
				CameraState.DefaultInverseOffsetSpeed.SetValue(playerCameraDesc.InverseOffsetSpeedX, playerCameraDesc.InverseOffsetSpeedY, playerCameraDesc.InverseOffsetSpeedZ);
				CameraState.DefaultInverseOffsetResetSpeed.SetValue(playerCameraDesc.InverseOffsetResetSpeedX, playerCameraDesc.InverseOffsetResetSpeedY, playerCameraDesc.InverseOffsetResetSpeedZ);
				CameraState.DefaultMeshZOffsetLimit = playerCameraDesc.MeshZOffsetLimit;
				CameraState.DefaultFocalDistance = playerCameraDesc.FocalDistance;
				CameraState.DefaultDepthBlurKM = playerCameraDesc.DepthBlurKM;
				CameraState.DefaultDepthBlurRadius = playerCameraDesc.DepthBlurRadius;
				CameraState.DefaultFOV = BGU_CameraAdapterUtilV2.QuickCalcCameraAdapterFOV(PlayerController, playerCameraDesc.FOV);
				CameraState.DefaultFOVLerpSpeed = playerCameraDesc.FOVSpeed * (CameraState.DefaultFOV / playerCameraDesc.FOV);
				CameraState.DefaultPitchMin = playerCameraDesc.MinPitch;
				CameraState.DefaultPitchMax = playerCameraDesc.MaxPitch;
				CameraState.DefaultYawMin = playerCameraDesc.MinYaw;
				CameraState.DefaultYawMax = playerCameraDesc.MaxYaw;
				CameraState.OriginDefaultArmLengthDefault = playerCameraDesc.ArmLengthDefault;
				CameraState.OriginDefaultMeshZOffsetLimit = playerCameraDesc.MeshZOffsetLimit;
				CameraState.OriginDefaultArmLocationZ = playerCameraDesc.ArmRelativeLocationZ;
				CameraState.OriginDefaultArmSocketOffsetZ = playerCameraDesc.ArmSocketOffsetZ;
			}
		}
	}

	private bool CheckViewPortORRatioChanged()
	{
		if (PlayerController == null)
		{
			return false;
		}
		PlayerController.GetViewportSize(out var SizeX, out var SizeY);
		if (SizeX == 0 && SizeY == 0)
		{
			return false;
		}
		if (SizeX == LastUpdateViewPortWidth && SizeY == LastUpdateViewPortHeight && LastUpdateForceRatioType == BGU_CameraAdapterUtilV2.GetForceRatioType())
		{
			return false;
		}
		LastUpdateForceRatioType = BGU_CameraAdapterUtilV2.GetForceRatioType();
		LastUpdateViewPortWidth = SizeX;
		LastUpdateViewPortHeight = SizeY;
		return true;
	}

	private void OnEnterPlayerSkillCamera(int SkillCameraIndex)
	{
		if (CameraState.PlayerSkillCameraIdOverrides.Count > SkillCameraIndex)
		{
			ControllerCameraData.SkillCameraIdOverride = CameraState.PlayerSkillCameraIdOverrides[SkillCameraIndex];
		}
	}

	private void OnExitPlayerSkillCamera()
	{
		ControllerCameraData.SkillCameraIdOverride = -1;
	}

	private void OnSetArmMode(EDefaultCamArmMode CamArmMode)
	{
		CameraState.CameraArmMode = CamArmMode;
	}

	private void OnSetLockArmMode(EDefaultCamArmMode CamArmMode)
	{
		CameraState.LockCameraArmMode = CamArmMode;
	}

	private void DecreaseFreeCameraArmLength(float DecreaseValue)
	{
		if (CameraState.CameraArmMode == EDefaultCamArmMode.Free)
		{
			float x = CameraState.Rt_FreeCameraArmLength - DecreaseValue * 100f;
			x = FMath.Clamp(x, CameraState.DefaultFreeCameraArmLength_Min, CameraState.DefaultFreeCameraArmLength_Max);
			CameraState.Rt_FreeCameraArmLength = x;
		}
	}

	private void ForceSetFreeCameraArmLength(float NewFreeArmLength)
	{
		if (CameraState.CameraArmMode == EDefaultCamArmMode.Free)
		{
			CameraState.Rt_FreeCameraArmLength = NewFreeArmLength;
		}
	}

	private void OnStartCameraOffsetTick(FGSCameraOffsetSetting CameraOffsetSetting, float TotalTime)
	{
		PlayerCameraData.CameraOffsetData.EnableCamOffsetTick = true;
		PlayerCameraData.CameraOffsetData.CamOffsetTickTotalTime = TotalTime;
		PlayerCameraData.CameraOffsetData.CameraOffsetSetting = CameraOffsetSetting;
	}

	private void OnStopCameraOffsetTick()
	{
		PlayerCameraData.CameraOffsetData.Reset();
		CameraState.Ex_ArmLengthOffset = 0f;
		CameraState.Ex_FovOffset = 0f;
	}

	private void TickExCamOffset(float DeltaTime)
	{
		if (!PlayerCameraData.CameraOffsetData.EnableCamOffsetTick)
		{
			return;
		}
		PlayerCameraData.CameraOffsetData.CamOffsetTickTimer += DeltaTime;
		if (PlayerCameraData.CameraOffsetData.CamOffsetTickTimer > PlayerCameraData.CameraOffsetData.CamOffsetTickTotalTime)
		{
			OnStopCameraOffsetTick();
			return;
		}
		float inTime = PlayerCameraData.CameraOffsetData.CamOffsetTickTimer / PlayerCameraData.CameraOffsetData.CamOffsetTickTotalTime;
		if (PlayerCameraData.CameraOffsetData.CameraOffsetSetting.EnableFOVOffset)
		{
			float floatValue = PlayerCameraData.CameraOffsetData.CameraOffsetSetting.FOVOffsetCurve.GetFloatValue(inTime);
			CameraState.Ex_FovOffset = floatValue;
		}
		if (PlayerCameraData.CameraOffsetData.CameraOffsetSetting.EnableArmLength)
		{
			float floatValue2 = PlayerCameraData.CameraOffsetData.CameraOffsetSetting.ArmLengthOffsetCurve.GetFloatValue(inTime);
			CameraState.Ex_ArmLengthOffset = floatValue2;
		}
	}

	private void ConstructMonitorData(in GSCameraControlData ControlData, in GSCameraMonitorData MonitorData)
	{
		if (CheatData.CanSendData())
		{
			FDownloadInfo_CameraMonitor cameraMonitorData = default(FDownloadInfo_CameraMonitor);
			FVector inVector = FVector.CrossProduct(-PlayerCameraManager.GetCameraRotation().Vector(), CameraState.PlayerForwardVector.ToVector()) + PlayerCameraManager.GetCameraLocation();
			cameraMonitorData.CameraFacePos = BGWCheatManageExtensions.ToNetStruct(inVector);
			cameraMonitorData.CameraPos = BGWCheatManageExtensions.ToNetStruct(PlayerCameraManager.GetCameraLocation());
			cameraMonitorData.ArmPos = BGWCheatManageExtensions.ToNetStruct(SpringArmComponent.GetWorldLocation());
			cameraMonitorData.CameraPitchPos.UpdateData((CameraState.TargetPos.ToVector() - CameraState.PlayerPos.ToVector()).Size2D(), PlayerCameraManager.GetCameraRotation().Pitch, 0f);
			cameraMonitorData.PlayerRoot = BGWCheatManageExtensions.ToNetStruct(CameraState.PlayerRootPos);
			cameraMonitorData.PlayerPelvis = BGWCheatManageExtensions.ToNetStruct(CameraState.PlayerPelvisPos);
			cameraMonitorData.TargetRoot = BGWCheatManageExtensions.ToNetStruct(CameraState.TargetRootPos);
			cameraMonitorData.TargetPelvis = BGWCheatManageExtensions.ToNetStruct(CameraState.TargetSoulFocusPos);
			cameraMonitorData.PlayerPos = BGWCheatManageExtensions.ToNetStruct(CameraState.PlayerPos);
			cameraMonitorData.TargetPos = BGWCheatManageExtensions.ToNetStruct(CameraState.TargetPos);
			cameraMonitorData.ControllerInput.UpdateData(ControlData.ControllerYawInput, ControlData.ControllerPitchInput);
			cameraMonitorData.ControllerRotation = BGWCheatManageExtensions.ToNetStruct(ControlData.ControllerRotation);
			cameraMonitorData.ControllerRotationSpeed = ControlData.ControllerRotationLerpSpeed;
			cameraMonitorData.MaxControllerPitch = ControlData.ViewPitchMax;
			cameraMonitorData.MinControllerPitch = ControlData.ViewPitchMin;
			cameraMonitorData.ArmLocation = BGWCheatManageExtensions.ToNetStruct(ControlData.ArmLocation);
			cameraMonitorData.ArmLocationSpeed = ControlData.ArmLocationLerpSpeed;
			cameraMonitorData.ArmSocketOffset = BGWCheatManageExtensions.ToNetStruct(ControlData.ArmSocketOffset);
			cameraMonitorData.ArmSocketOffsetSpeed = ControlData.ArmSocketOffsetLerpSpeed;
			cameraMonitorData.ArmLength = ControlData.ArmLength;
			cameraMonitorData.ArmLengthSpeed = ControlData.ArmLengthLerpSpeed;
			cameraMonitorData.Fov = ControlData.FieldOfView;
			cameraMonitorData.FovSpeed = ControlData.FovLerpSpeed;
			cameraMonitorData.PlayerRef = BGWCheatManageExtensions.ToNetStruct(MonitorData.StraightPlayerRefPos);
			cameraMonitorData.TargetRef = BGWCheatManageExtensions.ToNetStruct(MonitorData.StraightTargetRefPos);
			cameraMonitorData.CameraRef = BGWCheatManageExtensions.ToNetStruct(MonitorData.StraightCameraRefPos);
			PlayerCameraData.CameraMonitorData = cameraMonitorData;
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(" X : ");
			stringBuilder.Append(ControlData.IsXAxisFixed ? "Fixed" : "Smooth");
			stringBuilder.Append(" Y : ");
			stringBuilder.Append(ControlData.IsYAxisFixed ? "Fixed" : "Smooth");
			stringBuilder.Append(" Z : ");
			stringBuilder.Append(ControlData.IsZAxisFixed ? "Fixed" : "Smooth");
			FDownloadInfo_PlayerCamera playerCameraMonitorData = new FDownloadInfo_PlayerCamera
			{
				MonitorData = new Dictionary<EPlayerCameraMonitorParamType, string>
				{
					[EPlayerCameraMonitorParamType.CameraID] = CameraState.CurrentCameraID.ToString(),
					[EPlayerCameraMonitorParamType.ArmLength] = ControlData.ArmLength.ToString("F3"),
					[EPlayerCameraMonitorParamType.ArmRelativeLocation] = ControlData.ArmLocation.ToString(),
					[EPlayerCameraMonitorParamType.ArmSocketOffset] = ControlData.ArmSocketOffset.ToString(),
					[EPlayerCameraMonitorParamType.Fov] = ControlData.FieldOfView.ToString("F3"),
					[EPlayerCameraMonitorParamType.AxisFixed] = stringBuilder.ToString(),
					[EPlayerCameraMonitorParamType.CameraLagEnabled] = SpringArmComponent.EnableCameraLag.ToString(),
					[EPlayerCameraMonitorParamType.CameraLagMaxDistance] = ControlData.CameraLagMaxDistance.ToString(),
					[EPlayerCameraMonitorParamType.CameraLagSpeed] = ControlData.CameraLagSpeed.ToString(),
					[EPlayerCameraMonitorParamType.CameraLagInverseSpeed] = ControlData.CameraLagInverseSpeed.ToString(),
					[EPlayerCameraMonitorParamType.DepthBlurKm] = ControlData.DepthBlurKm.ToString("F3"),
					[EPlayerCameraMonitorParamType.DepthBlurRadius] = ControlData.DepthBlurRadius.ToString("F3"),
					[EPlayerCameraMonitorParamType.FoliageFadeDistance] = ControlData.FoliageFadeDistance.ToString("F3")
				},
				TableData = new Dictionary<EPlayerCameraTableParamType, float>
				{
					[EPlayerCameraTableParamType.ArmLengthDefault] = CameraState.DefaultArmLengthDefault,
					[EPlayerCameraTableParamType.ArmLengthSpeed] = CameraState.DefaultArmLengthLerpSpeed,
					[EPlayerCameraTableParamType.ArmRelativeLocationX] = CameraState.DefaultArmLocation.X,
					[EPlayerCameraTableParamType.ArmRelativeLocationY] = CameraState.DefaultArmLocation.Y,
					[EPlayerCameraTableParamType.ArmRelativeLocationZ] = CameraState.DefaultArmLocation.Z,
					[EPlayerCameraTableParamType.ArmRelativeLocationLerpSpeed] = CameraState.DefaultArmLengthDefault,
					[EPlayerCameraTableParamType.ArmSocketOffsetX] = CameraState.DefaultArmSocketOffset.X,
					[EPlayerCameraTableParamType.ArmSocketOffsetY] = CameraState.DefaultArmSocketOffset.Y,
					[EPlayerCameraTableParamType.ArmSocketOffsetZ] = CameraState.DefaultArmSocketOffset.Z,
					[EPlayerCameraTableParamType.ArmSocketOffsetLerpSpeed] = CameraState.DefaultArmSocketOffsetLerpSpeed,
					[EPlayerCameraTableParamType.InverseOffsetX] = CameraState.DefaultInverseOffset.X,
					[EPlayerCameraTableParamType.InverseOffsetY] = CameraState.DefaultInverseOffset.Y,
					[EPlayerCameraTableParamType.InverseOffsetZ] = CameraState.DefaultInverseOffset.Z,
					[EPlayerCameraTableParamType.InverseOffsetSpeedX] = CameraState.DefaultInverseOffsetSpeed.X,
					[EPlayerCameraTableParamType.InverseOffsetSpeedY] = CameraState.DefaultInverseOffsetSpeed.Y,
					[EPlayerCameraTableParamType.InverseOffsetSpeedZ] = CameraState.DefaultInverseOffsetSpeed.Z,
					[EPlayerCameraTableParamType.InverseOffsetResetSpeedX] = CameraState.DefaultInverseOffsetResetSpeed.X,
					[EPlayerCameraTableParamType.InverseOffsetResetSpeedY] = CameraState.DefaultInverseOffsetResetSpeed.Y,
					[EPlayerCameraTableParamType.InverseOffsetResetSpeedZ] = CameraState.DefaultInverseOffsetResetSpeed.Z,
					[EPlayerCameraTableParamType.MeshZOffsetLimit] = CameraState.DefaultMeshZOffsetLimit,
					[EPlayerCameraTableParamType.FocalDistance] = CameraState.DefaultFocalDistance,
					[EPlayerCameraTableParamType.DepthBlurKm] = CameraState.DefaultDepthBlurKM,
					[EPlayerCameraTableParamType.DepthBlurRadius] = CameraState.DefaultDepthBlurRadius,
					[EPlayerCameraTableParamType.Fov] = CameraState.DefaultFOV,
					[EPlayerCameraTableParamType.FovSpeed] = CameraState.DefaultFOVLerpSpeed,
					[EPlayerCameraTableParamType.PitchMin] = CameraState.DefaultPitchMin,
					[EPlayerCameraTableParamType.PitchMax] = CameraState.DefaultPitchMax,
					[EPlayerCameraTableParamType.YawMin] = CameraState.DefaultYawMin,
					[EPlayerCameraTableParamType.YawMax] = CameraState.DefaultYawMax
				}
			};
			PlayerCameraData.PlayerCameraMonitorData = playerCameraMonitorData;
			FDownloadInfo_StraightCamera straightCameraMonitorData = new FDownloadInfo_StraightCamera
			{
				MonitorData = new Dictionary<EStraightCameraMonitorParamType, string>
				{
					[EStraightCameraMonitorParamType.CameraID] = CameraState.FinalLockCameraID.ToString(),
					[EStraightCameraMonitorParamType.ArmLength] = ControlData.ArmLength.ToString("F3"),
					[EStraightCameraMonitorParamType.PlayerRef] = MonitorData.StraightPlayerRefPos.ToString(),
					[EStraightCameraMonitorParamType.TargetRef] = MonitorData.StraightTargetRefPos.ToString(),
					[EStraightCameraMonitorParamType.CameraRef] = MonitorData.StraightCameraRefPos.ToString(),
					[EStraightCameraMonitorParamType.OriginRotation] = MonitorData.StraightOriginControllerRotation.ToString(),
					[EStraightCameraMonitorParamType.ActualRotation] = ControlData.ControllerRotation.ToString(),
					[EStraightCameraMonitorParamType.P2TDistance] = MonitorData.StraightP2TDistance.ToString("F3"),
					[EStraightCameraMonitorParamType.HeightDistance] = MonitorData.StraightHeightDistance.ToString("F3"),
					[EStraightCameraMonitorParamType.OffsetCurve] = MonitorData.StraightOffsetCurveValue.ToString(),
					[EStraightCameraMonitorParamType.FovOffsetCurve] = CameraState.StraightFovOffset.ToString("F3")
				},
				TableData = new Dictionary<EStraightCameraTableParamType, float>
				{
					[EStraightCameraTableParamType.ArmLength] = CameraState.StraightArmLengthDefault,
					[EStraightCameraTableParamType.ArmLengthSpeed] = CameraState.StraightArmLengthSpeed,
					[EStraightCameraTableParamType.RefType] = (int)CameraState.CamRefType,
					[EStraightCameraTableParamType.TargetRefHeight] = CameraState.StraightTargetRefHeightOffset,
					[EStraightCameraTableParamType.PlayerRefHeight] = CameraState.OriginStraightPlayerRefHeightOffset,
					[EStraightCameraTableParamType.TargetRefHeightSpeed] = CameraState.StraightTargetRefHeightOffsetSpeed,
					[EStraightCameraTableParamType.PlayerRefHeightSpeed] = CameraState.StraightPlayerRefHeightOffsetSpeed,
					[EStraightCameraTableParamType.HeightThreshold] = CameraState.StraightHeightThreshold,
					[EStraightCameraTableParamType.TraceSolution] = (int)CameraState.StraightTraceSolution,
					[EStraightCameraTableParamType.SlowTraceMaxYaw] = CameraState.StraightSlowTraceTargetRefMaxYaw,
					[EStraightCameraTableParamType.SlowTraceMaxDistance] = CameraState.StraightMaxTraceTargetRefDist,
					[EStraightCameraTableParamType.SlowTraceTargetRefSpeed] = CameraState.StraightTraceTargetRefSpeed,
					[EStraightCameraTableParamType.SlowTraceYawSpeed] = CameraState.StraightYawTraceSpeed,
					[EStraightCameraTableParamType.SlowTracePitchSpeed] = CameraState.StraightPitchTraceSpeed,
					[EStraightCameraTableParamType.MinPitch] = CameraState.StraightMinPitch,
					[EStraightCameraTableParamType.MaxPitch] = CameraState.StraightMaxPitch,
					[EStraightCameraTableParamType.HeightScaleFactor] = CameraState.StraightHeightScaleFactor,
					[EStraightCameraTableParamType.HeightScaleMaxDistance] = CameraState.StraightHeightScaleFurthestDist
				}
			};
			int num = MonitorData.StraightParams.AllParams.Length;
			straightCameraMonitorData.StepParams = new string[num];
			Array.Copy(MonitorData.StraightParams.AllParams, straightCameraMonitorData.StepParams, num);
			PlayerCameraData.StraightCameraMonitorData = straightCameraMonitorData;
			FDownloadInfo_DiagonalCamera diagonalCameraMonitorData = new FDownloadInfo_DiagonalCamera
			{
				MonitorData = new Dictionary<EDiagonalCameraMonitorParamType, string>
				{
					[EDiagonalCameraMonitorParamType.Location] = ControlData.DmcActorLocation.ToString(),
					[EDiagonalCameraMonitorParamType.Rotation] = ControlData.DmcActorRotation.ToString(),
					[EDiagonalCameraMonitorParamType.ArmLength] = ControlData.DmcArmLength.ToString("F3"),
					[EDiagonalCameraMonitorParamType.Fov] = ControlData.FieldOfView.ToString("F"),
					[EDiagonalCameraMonitorParamType.P2TDistance] = CameraState.DmcP2TDistance.ToString("F3"),
					[EDiagonalCameraMonitorParamType.P2THeightDistance] = CameraState.DmcP2THeightDistance.ToString("F3"),
					[EDiagonalCameraMonitorParamType.PlayerRef] = CameraState.DmcPlayerRef.ToString(),
					[EDiagonalCameraMonitorParamType.TargetRef] = CameraState.DmcTargetRef.ToString(),
					[EDiagonalCameraMonitorParamType.RefOffset] = CameraState.DmcRefOffset.ToString("F3"),
					[EDiagonalCameraMonitorParamType.RefOffsetClamped] = CameraState.DmcRefOffsetClamped.ToString("F3"),
					[EDiagonalCameraMonitorParamType.RotationLerpSpeed] = CameraState.DmcRotationLerpSpeed.ToString("F3")
				},
				TableData = new Dictionary<EDiagonalCameraTableParamType, float>
				{
					[EDiagonalCameraTableParamType.PlayerRefOffset] = CameraState.Diagonal_PlayerRefOffset,
					[EDiagonalCameraTableParamType.TargetRefOffset] = CameraState.Diagonal_TargetRefOffset,
					[EDiagonalCameraTableParamType.RefOffsetBase] = CameraState.Diagonal_RefOffsetBase,
					[EDiagonalCameraTableParamType.RefOffsetDistance] = CameraState.Diagonal_RefOffsetDistance,
					[EDiagonalCameraTableParamType.P2TRatio] = CameraState.Diagonal_P2TRatio,
					[EDiagonalCameraTableParamType.PosLerpSpeed] = CameraState.Diagonal_PosLerpSpeed,
					[EDiagonalCameraTableParamType.AngleOffset] = CameraState.Diagonal_AngleOffset,
					[EDiagonalCameraTableParamType.PitchBase] = CameraState.Diagonal_PitchBase,
					[EDiagonalCameraTableParamType.PitchFadeDistance] = CameraState.Diagonal_PitchFadeDistance,
					[EDiagonalCameraTableParamType.RotationLerpSpeedLow] = CameraState.Diagonal_RotLerpSpeedLow,
					[EDiagonalCameraTableParamType.RotationLerpSpeedHigh] = CameraState.Diagonal_RotLerpSpeedHigh,
					[EDiagonalCameraTableParamType.ArmLengthMin] = CameraState.Diagonal_ArmLengthMin,
					[EDiagonalCameraTableParamType.ArmLengthMax] = CameraState.Diagonal_ArmLengthMax,
					[EDiagonalCameraTableParamType.ArmLengthChangeValue] = CameraState.Diagonal_ArmLengthChangeValue,
					[EDiagonalCameraTableParamType.ArmLengthLerpSpeed] = CameraState.Diagonal_ArmLengthLerpSpeed
				}
			};
			PlayerCameraData.DiagonalCameraMonitorData = diagonalCameraMonitorData;
			FDownloadInfo_GiantCamera giantCameraMonitorData = new FDownloadInfo_GiantCamera
			{
				MonitorData = new Dictionary<EGiantCameraMonitorParamType, string>
				{
					[EGiantCameraMonitorParamType.CameraID] = CameraState.FinalLockCameraID.ToString(),
					[EGiantCameraMonitorParamType.ArmLength] = ControlData.ArmLength.ToString("F3"),
					[EGiantCameraMonitorParamType.ArmRelativeLocation] = ControlData.ArmLocation.ToString(),
					[EGiantCameraMonitorParamType.ArmSocketOffset] = ControlData.ArmSocketOffset.ToString(),
					[EGiantCameraMonitorParamType.Fov] = ControlData.FieldOfView.ToString("F3"),
					[EGiantCameraMonitorParamType.PlayerRef] = MonitorData.GiantPlayerRefPos.ToString(),
					[EGiantCameraMonitorParamType.TargetRef] = MonitorData.GiantTargetRefPos.ToString(),
					[EGiantCameraMonitorParamType.CameraRef] = MonitorData.GiantCameraRefPos.ToString(),
					[EGiantCameraMonitorParamType.OriginRotation] = MonitorData.GiantOriginControllerRotation.ToString(),
					[EGiantCameraMonitorParamType.ActualRotation] = ControlData.ControllerRotation.ToString(),
					[EGiantCameraMonitorParamType.P2TDistance] = MonitorData.GiantP2TDistance.ToString("F3"),
					[EGiantCameraMonitorParamType.HeightDistance] = MonitorData.GiantHeightDistance.ToString("F3")
				},
				TableData = new Dictionary<EGiantCameraTableParamType, float>
				{
					[EGiantCameraTableParamType.ArmLength] = CameraState.GiantArmLength,
					[EGiantCameraTableParamType.ArmLengthSpeed] = CameraState.GiantArmLengthLerpSpeed,
					[EGiantCameraTableParamType.TargetRefHeightOffset] = CameraState.GiantTargetRefHeightOffset,
					[EGiantCameraTableParamType.PlayerRefHeightOffset] = CameraState.GiantPlayerRefHeightOffset,
					[EGiantCameraTableParamType.TargetRefHeightOffsetSpeed] = CameraState.GiantTargetRefHeightOffsetLerpSpeed,
					[EGiantCameraTableParamType.PlayerRefHeightOffsetSpeed] = CameraState.GiantPlayerRefHeightOffsetLerpSpeed,
					[EGiantCameraTableParamType.TargetHeightThreshold] = CameraState.GiantHeightThreshold,
					[EGiantCameraTableParamType.MinPitch] = CameraState.GiantMinPitch,
					[EGiantCameraTableParamType.MaxPitch] = CameraState.GiantMaxPitch,
					[EGiantCameraTableParamType.PitchLerpSpeed] = CameraState.GiantPitchLerpSpeed,
					[EGiantCameraTableParamType.TargetScreenMaxRatio] = CameraState.GiantTargetScreenMaxRatio,
					[EGiantCameraTableParamType.PlayerScreenRatio] = CameraState.GiantPlayerScreenRatio,
					[EGiantCameraTableParamType.CameraOffsetLerpSpeed] = CameraState.GiantCameraOffsetLerpSpeed
				}
			};
			PlayerCameraData.GiantCameraMonitorData = giantCameraMonitorData;
		}
	}
}
