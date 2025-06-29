using System.Collections.Generic;
using b1.ECS;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MovementData : IBUC_MovementData, IPersistentECSData
{
	public FVector AMScaleVec;

	public float InputMovingTimer;

	public FVector LastMoveWorldInput;

	private FVector CurrentMoveInputVec;

	public Dictionary<EBGUMoveMode, bool> MoveModeActivation = new Dictionary<EBGUMoveMode, bool>();

	private int MoveType;

	private FVector CurRotateTargetPos;

	private float CurRotateSpeed;

	private float CameraG4RotateSpeed;

	private bool bNeedRotate;

	private EMovementMode TickSetMoveModePreMode;

	private float TickSetMoveModeDuration;

	public Dictionary<TWeakObject<BGUCharacterCS>, int> CharNavWalkOptLevelMap;

	public bool NavWalkOpt_MassiveModeON;

	public float FloatingHitTimer;

	public bool IsInRiseStage;

	public float CurrentHeight;

	public float CurrentRiseSummHeight;

	public float FloatingHitRiseTime;

	public float FloatingHitHeight;

	public float FloatingHitRiseSpd;

	public float FloatingHitDeclineSpd;

	public float FloatingExtraHitHeight;

	public float FloatingExtraHitTime;

	public float FloatingExtraHitRiseSpd;

	public float ExtraCurrentRiseSummHeight;

	public uint FloatingMovementModeHandleID;

	private TStrongObjectPtr<UCurveFloat> mMoveCurveXAxis = new TStrongObjectPtr<UCurveFloat>();

	private TStrongObjectPtr<UCurveFloat> mMoveCurveZAxis = new TStrongObjectPtr<UCurveFloat>();

	public bool bAutoResetMovementMode;

	public bool bShouldClearVelocityOnCurveMoveEnd;

	public bool EnableCurveMove;

	public FVector CurveMoveDirInfo;

	public EBGUMoveCurveType MoveCurveType;

	public float CurveMoveTimer;

	public float CurveMoveLastCalcTime;

	public bool CurveMoveUseBeHitDir;

	public bool CurveMoveUseAttractionDir;

	public bool CurveMoveIsScaleToTarget;

	public float CurveMoveScaleOffset;

	public float CurveMoveScaleTimesToTarget;

	public bool CurveMoveIsScaleToAttractionLocation;

	public uint CurveMovementModeHandleID;

	public bool PlayRotAMByCamRot_Enable;

	public float PlayRotAMByCamRot_CacheTime = 0.2f;

	public float PlayRotAMByCamRot_CacheTimer = -1f;

	public float PlayRotAMByCamRot_ProtectTimer = -1f;

	public float PlayRotAMByCamRot_ProtectTotalTime = -1f;

	public UAnimMontage PlayRotAMByCamRot_TurnR_AM;

	public UAnimMontage PlayRotAMByCamRot_TurnL_AM;

	public UAnimMontage PlayRotAMByCamRot_CurRotAM;

	public float PlayRotAMByCamRot_TurnSpeed;

	public float PlayRotAMByCamRot_RotateWithCamSpeed;

	public float PlayRotAMByCamRot_AngleThreshold;

	public ERotTypeInSmallAngle RotTypeInSmallAngle;

	public ERotTypeInLargeAngle RotTypeInLargeAngle;

	public float PlayRotAMByCamRot_BlendInTime = -1f;

	public float PlayRotAMByCamRot_BlendOutTime = -1f;

	public bool bMatchingPosition;

	public int MatchingPosMoveIdx = -1;

	public Del_MatchingPositionFinishCallback MatchingPosAIPathMoveCallback;

	public Del_MatchingPositionFinishCallback MatchingPosInterpMoveCallback;

	public FVector IM_TargetLoction;

	public FRotator IM_TargetRotation;

	public float IM_TotalTime;

	public bool IM_EnableMove;

	public bool IM_EnableZAxisMove;

	public bool IM_IgnoreLocation;

	public bool IM_IgnoreRotation;

	public AActor AttackRotation_SceneItem;

	public int AttackRotation_SceneItemAMID = -1;

	public int AttackRotation_SceneItemNotifyID = -1;

	public AActor MatchTransform_SceneItem;

	public int MatchTransform_SceneItemAMID = -1;

	public int MatchTransform_SceneItemNotifyID = -1;

	public USplineComponent FlyControlSpline;

	public float SplineFlyDistance;

	public int CurSplineFlyPoint;

	public int LastSplineFlyPoint;

	public float SplineFlyWaitTime;

	public Dictionary<int, FGSSplineFlyMoveWaitPoint> SplineFlyWaitPointDict;

	public UAnimationAsset FlyingAnimAsset;

	public float TransitionInterpSpeed;

	public float RotationInterpSpeed;

	public string NpcGuideSplineGuid;

	public bool NeedSwitchSpeedByDistanceToPlayer;

	public EAIMoveSpeedType SplineMoveSpeed;

	public float MaxDistance_Sprint;

	public float MaxDistance_Run;

	public float MaxDistance_Jog;

	public float DistanceBuffer;

	public FVector NpcLastLocation;

	public float NpcStuckTimer;

	public FVector AISpiderMoveTargetPos;

	public FVector AISpiderMoveTargetNormal;

	public ESpiderNavPositionType AISpiderMoveTargetPosType;

	public EAIMoveSpeedType AISpiderMoveSpeed;

	public float AISpiderMoveAcceptableRadius;

	public List<FSpiderNavPointInfo> AISpiderMovePath = new List<FSpiderNavPointInfo>();

	public Stack<BUC_MoveModeBase> MoveModeStack = new Stack<BUC_MoveModeBase>();

	public Queue<FVector> CurveMoveQueue = new Queue<FVector>();

	public bool bWalkOnLand { get; set; }

	public bool bWalkOnDitch { get; set; }

	public float AMSpeedRate { get; set; }

	public float AMScaleMaxRate { get; set; }

	public bool IsAMCalcSpeedRate { get; set; }

	public bool IsAMPause { get; set; }

	public float AMCaleSpeedRateTime { get; set; }

	public int AMSpeedRateNotifyStateID { get; set; }

	public bool IsAMMoveScaleZ { get; set; }

	public float AMMoveScaleZTime { get; set; }

	public bool IsAMMoveScaleX { get; set; }

	public float AMMoveScaleXTime { get; set; }

	public bool IsAMMoveScaleY { get; set; }

	public float AMMoveScaleYTime { get; set; }

	public FRotator TargetRot { get; set; }

	public EBGUMoveAIType MoveAIType { get; set; }

	public bool UseLockExForMM { get; set; }

	public bool UseFreeExForMM { get; set; }

	public bool bEnableWalk { get; set; }

	public bool bInputMoving { get; set; }

	public FVector LastMoveWorldInputNotZero { get; set; }

	public bool bJoypadTriggerWalk { get; set; }

	public bool bWaitingJoypadWalkRelease { get; set; }

	public uint AllowPhysicsRotationDuringAnimRootMotionHandleID { get; set; }

	public int MontageInstanceIDWithBodySeparation { get; set; }

	public UAnimMontage CurrentActiveMontage { get; set; }

	public float NormalMoveSpeed { get; set; }

	public int NavWalkOptLevel { get; set; }

	public float NavWalkOptimizeDistanceLevel1 { get; set; }

	public float NavWalkOptimizeDistanceLevel2 { get; set; }

	public UCurveFloat MoveCurveXAxis
	{
		get
		{
			return mMoveCurveXAxis.Get();
		}
		set
		{
			mMoveCurveXAxis.Set(value);
		}
	}

	public UCurveFloat MoveCurveZAxis
	{
		get
		{
			return mMoveCurveZAxis.Get();
		}
		set
		{
			mMoveCurveZAxis.Set(value);
		}
	}

	public bool IsSpiderMoveReached { get; set; }

	public ETurretRotateState CurrentState { get; set; }

	public float TotalDelayTime { get; set; }

	public bool IsCloudFreeLookEnabled { get; set; }

	public FRotator CloudFreeLookMoveRotation { get; set; }

	public bool IsCloudMoveLift { get; set; }

	public bool IsCloudMoveVerticalLift { get; set; }

	public FVector InputCloudMoveDir { get; set; }

	public FVector FinalCloudMoveDir { get; set; }

	public float VelocityAccelerationDegree { get; set; }

	public bool bCanUseSurfaceTypeFromMovementComp { get; set; }

	public FVector CurFloorNormal { get; set; }

	public FVector CurFloorHitPoint { get; set; }

	public ESceneItemSurfaceType CurSurfaceType { get; set; }

	public void GetInterpolationMoveTarget(out FVector TargetPos, out FRotator TargetRotator)
	{
		TargetPos = IM_TargetLoction;
		TargetRotator = IM_TargetRotation;
	}

	public BUC_MovementData()
	{
		CurRotateTargetPos = default(FVector);
		UseLockExForMM = false;
		UseFreeExForMM = false;
		EnableCurveMove = false;
		CurveMoveTimer = 0f;
		CurveMoveLastCalcTime = 0f;
		CurrentMoveInputVec = FVector.ZeroVector;
		bAutoResetMovementMode = true;
		bShouldClearVelocityOnCurveMoveEnd = false;
		AMScaleVec = FVector.OneVector;
		IsAMMoveScaleX = false;
		IsAMMoveScaleY = false;
		IsAMMoveScaleZ = false;
		AMMoveScaleXTime = 0f;
		AMMoveScaleYTime = 0f;
		AMMoveScaleZTime = 0f;
		MontageInstanceIDWithBodySeparation = -1;
		bCanUseSurfaceTypeFromMovementComp = false;
		CurFloorNormal = FVector.UpVector;
		CurFloorHitPoint = FVector.ZeroVector;
		CurSurfaceType = ESceneItemSurfaceType.DefaultSurface;
	}

	public EBGUMoveMode GetMoveType()
	{
		return (EBGUMoveMode)MoveType;
	}

	public int GetMoveTypeInt()
	{
		return MoveType;
	}

	public void SetMoveType(EBGUMoveMode NewMoveType)
	{
		MoveType = (int)NewMoveType;
	}

	public void SetRotateInfo(FVector TargetPos, float RotateSpeed)
	{
		CurRotateTargetPos = TargetPos;
		CurRotateSpeed = RotateSpeed;
		bNeedRotate = true;
	}

	public void GetRotateInfo(out FVector TargetPos, out float RotateSpeed)
	{
		TargetPos = CurRotateTargetPos;
		RotateSpeed = CurRotateSpeed;
	}

	public void SetCameraG4RotateSpeed(float RotateSpeed)
	{
		CameraG4RotateSpeed = RotateSpeed;
	}

	public float GetCameraG4RotateSpeed()
	{
		return CameraG4RotateSpeed;
	}

	public void SetRotateIsDone()
	{
		bNeedRotate = false;
	}

	public bool IsNeedRotate()
	{
		return bNeedRotate;
	}

	public float GetTickSetMoveModeDuration()
	{
		return TickSetMoveModeDuration;
	}

	public void SetTickSetMoveModeDuration(float Duration)
	{
		TickSetMoveModeDuration = Duration;
	}

	public EMovementMode GetTickSetMoveModePreMode()
	{
		return TickSetMoveModePreMode;
	}

	public void SetTickSetMoveModePreMode(EMovementMode InMode)
	{
		TickSetMoveModePreMode = InMode;
	}

	public void SetTargetRotforMM(FRotator targetRot)
	{
		TargetRot = targetRot;
	}

	public void SetCurrentInputVecX(float Value)
	{
		CurrentMoveInputVec.X = Value;
	}

	public void SetCurrentInputVecY(float Value)
	{
		CurrentMoveInputVec.Y = Value;
	}

	public FVector GetCurrentWorldInputVec(ACharacter OwnerChr)
	{
		ABGPPlayerController aBGPPlayerController = OwnerChr.GetController() as ABGPPlayerController;
		if (aBGPPlayerController == null)
		{
			return default(FVector);
		}
		AActor playerCameraManager = aBGPPlayerController.PlayerCameraManager;
		_ = FTransform.Default;
		FVector fVector = MathLib.TransformDirection(playerCameraManager.GetActorTransform(), CurrentMoveInputVec);
		fVector.Z = 0f;
		fVector = fVector.GetSafeNormal();
		return fVector * CurrentMoveInputVec.Size();
	}

	public bool IsMoveModeActive(EBGUMoveMode MoveMode)
	{
		if (MoveModeActivation.ContainsKey(MoveMode))
		{
			return MoveModeActivation[MoveMode];
		}
		return false;
	}

	public bool CanUseSurfaceTypeFromMovementComp()
	{
		return bCanUseSurfaceTypeFromMovementComp;
	}

	public void SetCanUseSurfaceTypeFromMovementComp(bool bCan)
	{
		bCanUseSurfaceTypeFromMovementComp = bCan;
		if (!bCanUseSurfaceTypeFromMovementComp)
		{
			ClearEnvironmentInteractionData();
		}
	}

	public void ClearEnvironmentInteractionData()
	{
		bCanUseSurfaceTypeFromMovementComp = false;
		CurFloorNormal = FVector.UpVector;
		CurFloorHitPoint = FVector.ZeroVector;
		CurSurfaceType = ESceneItemSurfaceType.DefaultSurface;
	}
}
