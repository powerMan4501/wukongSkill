using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_CameraState
{
	public FVector DefaultArmTargetOffset;

	public FVector Rt_ArmTargetOffset;

	public FVector Rt_PreviousDesiredLoc;

	public FVector Rt_PreviousArmOrigin;

	public FRotator Rt_PreviousDesiredRot;

	public int WukongResID { get; set; }

	public int PlayerResId { get; set; }

	public int CurrentCameraGroupId { get; set; }

	public int CurrentCameraID { get; set; }

	public int DefaultCameraId { get; set; }

	public int LockTargetId { get; set; }

	public int DefaultLockCameraId { get; set; }

	public int CurrentLockCameraID { get; set; }

	public int MultiLockCameraID { get; set; }

	public int FinalLockCameraID { get; set; }

	public List<int> PlayerSkillCameraIdOverrides { get; } = new List<int>();

	public Dictionary<int, int> LockCameraIdOverrides { get; } = new Dictionary<int, int>();

	public int DefaultCameraIDForWalk { get; set; } = 9999;

	public int DefaultCameraIDForRun { get; set; }

	public int DefaultCameraIDForSprint { get; set; }

	public int DefaultCameraIDForHardMove { get; set; }

	public int DefaultCameraIDForGlideMoving { get; set; }

	public int DefaultCameraIDForJump { get; set; }

	public int DefaultCameraIDForSplineMove { get; set; }

	public bool HasSASOCurve { get; set; }

	public bool HasArmLengthCurve { get; set; }

	public bool HasPitchCurve { get; set; }

	public bool HasArmLocationZCurve { get; set; }

	public bool IsLocked { get; set; }

	public bool IsUseGuiBeiCamera { get; set; }

	public bool IsAutoMoveTrailEnabled { get; set; }

	public FVector AutoMoveTargetDir { get; set; }

	public bool IsWithCamLockEx { get; set; }

	public bool Has232Buff { get; set; }

	public bool Has275Buff { get; set; }

	public bool Has907Buff { get; set; }

	public bool IsFalling { get; set; }

	public bool IsFlying { get; set; }

	public bool IsJumping { get; set; }

	public bool IsCloudVerticalLifting { get; set; }

	public EDefaultCamArmMode CameraArmMode { get; set; }

	public EDefaultCamArmMode LockCameraArmMode { get; set; }

	public EPlayerFreeCameraType FreeCameraMode { get; set; } = EPlayerFreeCameraType.AutoTrail;

	public ELockCamMode LockCamMode { get; set; }

	public int FixedCameraParamFlags { get; set; }

	public bool bUseTraceVelocityCamera { get; set; }

	public float LastCameraInputTimer { get; set; }

	public bool bPlayerDead { get; set; }

	public bool bUseSplineMoveCamera { get; set; }

	public bool bUsePlayerSkillCamera { get; set; }

	public bool bUseMonsterSkillCamera { get; set; }

	public bool bPlayerDuringRebirth { get; set; }

	public EResetSpringArmRotationWay ResetSpringArmRotationWay { get; set; }

	public FRotator CustomSpringArmRotation { get; set; }

	public bool bHasTarget { get; set; }

	public bool bNotInitial { get; set; }

	public bool bEnableAutoTrail { get; set; } = true;

	public float DefaultArmLengthDefault { get; set; }

	public float DefaultArmLengthClose { get; set; }

	public float DefaultArmLengthNormal { get; set; }

	public float DefaultArmLengthFar { get; set; }

	public float DefaultArmLengthLerpSpeed { get; set; }

	public float DefaultFreeCameraArmLength_Min { get; set; }

	public float DefaultFreeCameraArmLength_Max { get; set; }

	public GSLocation DefaultArmLocation { get; } = new GSLocation();

	public float DefaultArmLocationLerpSpeed { get; set; }

	public GSLocation DefaultArmSocketOffset { get; } = new GSLocation();

	public float DefaultArmSocketOffsetLerpSpeed { get; set; }

	public GSLocation DefaultInverseOffset { get; } = new GSLocation();

	public GSLocation DefaultInverseOffsetSpeed { get; } = new GSLocation();

	public GSLocation DefaultInverseOffsetResetSpeed { get; } = new GSLocation();

	public float DefaultMeshZOffsetLimit { get; set; }

	public float DefaultFocalDistance { get; set; }

	public float DefaultDepthBlurKM { get; set; }

	public float DefaultDepthBlurRadius { get; set; }

	public float DefaultFOV { get; set; }

	public float DefaultFOVLerpSpeed { get; set; }

	public float DefaultPitchMin { get; set; }

	public float DefaultPitchMax { get; set; }

	public float DefaultYawMin { get; set; }

	public float DefaultYawMax { get; set; }

	public GSLocation SASOCurveValue { get; } = new GSLocation();

	public float ArmLengthCurveValue { get; set; }

	public float PitchCurveValue { get; set; }

	public float ArmLocationZCurveValue { get; set; }

	public string LockTargetSocketName { get; set; }

	public bool bTargetSupportMultiPointLock { get; set; }

	public TStrongObjectPtr<UCurveFloat> FoliageFadeScaleCurve { get; } = new TStrongObjectPtr<UCurveFloat>();

	public float FoliageFadeDistanceLerpSpeed { get; set; }

	public ECamRefType CamRefType { get; set; }

	public FName PPointSocketName { get; set; }

	public FName RPointSocketName { get; set; }

	public FName SPointSocketName { get; set; }

	public FName ZPointSocketName { get; set; }

	public int StraightArmLengthMode { get; set; }

	public bool bResetStraightPlayerRefCache { get; set; }

	public bool bResetGiantPlayerRefCache { get; set; }

	public float StraightArmLengthDefault { get; set; }

	public float StraightArmLengthClose { get; set; }

	public float StraightArmLengthMid { get; set; }

	public float StraightArmLengthFar { get; set; }

	public float StraightArmLengthSpeed { get; set; }

	public float StraightTargetRefHeightOffset { get; set; }

	public float StraightTargetRefHeightOffsetSpeed { get; set; }

	public float StraightPlayerRefHeightOffset { get; set; }

	public float StraightPlayerRefHeightOffsetSpeed { get; set; }

	public float StraightHeightThreshold { get; set; }

	public ESlowTraceSolution StraightTraceSolution { get; set; }

	public float StraightMaxTraceTargetRefDist { get; set; }

	public float StraightTraceTargetRefSpeed { get; set; }

	public float StraightYawTraceSpeed { get; set; }

	public float StraightPitchTraceSpeed { get; set; }

	public float StraightSlowTraceTargetRefMaxYaw { get; set; }

	public TStrongObjectPtr<UCurveVector> StraightTraceSpeedCurve { get; } = new TStrongObjectPtr<UCurveVector>();

	public float StraightMinPitch { get; set; }

	public float StraightMaxPitch { get; set; }

	public TStrongObjectPtr<UCurveVector> StraightOffsetCurve { get; } = new TStrongObjectPtr<UCurveVector>();

	public TStrongObjectPtr<UCurveFloat> StraightFovOffsetCurve { get; } = new TStrongObjectPtr<UCurveFloat>();

	public float StraightHeightScaleFactor { get; set; }

	public float StraightClosestDist { get; set; }

	public float StraightHeightScaleFurthestDist { get; set; }

	public int[] StraightCameraParamInts { get; set; }

	public float[] StraightCameraParamFloats { get; set; }

	public string[] StraightCameraParamStrings { get; set; }

	public float StraightFovOffset { get; set; }

	public bool bDiagonalIgnoreLerp { get; set; }

	public float Diagonal_PlayerRefOffset { get; set; }

	public float Diagonal_TargetRefOffset { get; set; }

	public float Diagonal_RefOffsetBase { get; set; }

	public float Diagonal_RefOffsetDistance { get; set; }

	public float Diagonal_P2TRatio { get; set; }

	public float Diagonal_PosLerpSpeed { get; set; }

	public float Diagonal_AngleOffset { get; set; }

	public float Diagonal_PitchBase { get; set; }

	public float Diagonal_PitchFadeDistance { get; set; }

	public float Diagonal_RotLerpSpeedLow { get; set; }

	public float Diagonal_RotLerpSpeedHigh { get; set; }

	public float Diagonal_ArmLengthMin { get; set; }

	public float Diagonal_ArmLengthMax { get; set; }

	public float Diagonal_ArmLengthChangeValue { get; set; }

	public float Diagonal_ArmLengthLerpSpeed { get; set; }

	public float GiantArmLength { get; set; }

	public float GiantArmLengthLerpSpeed { get; set; }

	public float GiantTargetRefHeightOffset { get; set; }

	public float GiantPlayerRefHeightOffset { get; set; }

	public float GiantTargetRefHeightOffsetLerpSpeed { get; set; }

	public float GiantPlayerRefHeightOffsetLerpSpeed { get; set; }

	public float GiantHeightThreshold { get; set; }

	public float GiantMinPitch { get; set; }

	public float GiantMaxPitch { get; set; }

	public float GiantPitchLerpSpeed { get; set; }

	public float GiantPlayerScreenRatio { get; set; }

	public float GiantCameraOffsetLerpSpeed { get; set; }

	public float GiantTargetScreenMinRatio { get; set; }

	public float GiantTargetScreenMaxRatio { get; set; }

	public TStrongObjectPtr<UCurveFloat> GiantTargetRefHeightOffsetCurve { get; } = new TStrongObjectPtr<UCurveFloat>();

	public BUC_CameraBlendCache CameraBlendCache { get; } = new BUC_CameraBlendCache();

	public GSLocation Rt_CameraWorldPosition { get; } = new GSLocation();

	public GSRotation Rt_CameraWorldRotation { get; } = new GSRotation();

	public GSRotation Rt_CameraRotation { get; } = new GSRotation();

	public GSRotation Rt_ControllerRotation { get; } = new GSRotation();

	public GSLocation Rt_ArmWorldLocation { get; } = new GSLocation();

	public GSLocation Rt_ArmLocation { get; } = new GSLocation();

	public GSLocation Rt_ArmSocketOffset { get; } = new GSLocation();

	public float Rt_ArmLength { get; set; }

	public bool Rt_IsXAxisSmoothed { get; set; }

	public bool Rt_IsYAxisSmoothed { get; set; }

	public bool Rt_IsZAxisSmoothed { get; set; }

	public GSLocation Rt_CameraLagSpeed { get; } = new GSLocation();

	public GSLocation Rt_CameraLagInverseSpeed { get; } = new GSLocation();

	public GSLocation Rt_CameraLagMaxDistance { get; } = new GSLocation();

	public float Rt_FieldOfView { get; set; }

	public float Rt_FocalDistance { get; set; }

	public float Rt_DepthBlurKm { get; set; }

	public float Rt_DepthBlurRadius { get; set; }

	public float Rt_FoliageFadeDistance { get; set; }

	public float Rt_ViewPitchMin { get; set; }

	public float Rt_ViewPitchMax { get; set; }

	public float Rt_AxisMoveForward { get; set; }

	public float Rt_AxisMoveRight { get; set; }

	public float Rt_FreeCameraArmLength { get; set; }

	public float Rt_ControllerRotationLerpSpeed { get; set; }

	public GSLocation Rt_DmcActorLocation { get; } = new GSLocation();

	public GSLocation Rt_DmcActorForwardVector { get; } = new GSLocation();

	public GSRotation Rt_DmcActorRotation { get; } = new GSRotation();

	public float Rt_DmcArmLength { get; set; }

	public float PitchCurveTime { get; set; }

	public float PitchCurveBlendTimer { get; set; }

	public float ArmLengthCurveTime { get; set; }

	public float ArmLengthCurveBlendTimer { get; set; }

	public float ArmLengthCurveBlendOutTime { get; set; }

	public float SASOCurveTime { get; set; }

	public float SASOCurveBlendTimer { get; set; }

	public float SASOCurveBlendOutTime { get; set; }

	public float ArmLocationZCurveTime { get; set; }

	public float ArmLocationZCurveBlendTime { get; set; }

	public float ArmLocationZCurveBlendOutTime { get; set; }

	public FGSFloatCurveToParam ArmLocationZCurve { get; set; }

	public FGSFloatCurveToParam PitchCurve { get; set; }

	public FGSFloatCurveToParam ArmLengthCurve { get; set; }

	public UCurveVector SASOCurve { get; set; }

	public float ArmLocationZCurveOriValue { get; set; }

	public GSRotation PitchCurveOriValue { get; set; }

	public float ArmLengthCurveOriValue { get; set; }

	public GSLocation SASOCurveOriValue { get; set; }

	public GSLocation ControllerForwardVector { get; } = new GSLocation();

	public GSLocation PlayerRefBase { get; } = new GSLocation();

	public GSLocation PlayerPreviousPos { get; } = new GSLocation();

	public GSLocation PlayerRootPos { get; } = new GSLocation();

	public GSLocation PlayerPos { get; } = new GSLocation();

	public GSLocation PlayerPelvisPos { get; } = new GSLocation();

	public GSLocation PlayerVelocity { get; } = new GSLocation();

	public GSLocation PlayerForwardVector { get; } = new GSLocation();

	public GSRotation PlayerPreviousControlRot { get; } = new GSRotation();

	public bool PlayerIsAttacking { get; set; }

	public bool PlayerIsGlideMoving { get; set; }

	[UProperty]
	[BlueprintReadWrite]
	public bool PlayerIsInAir { get; set; }

	public bool PlayerCanMove { get; set; }

	public bool bCastRollingSkill { get; set; }

	public GSLocation PlayerMeshOffset { get; } = new GSLocation();

	public GSLocation TargetRootPos { get; } = new GSLocation();

	public GSLocation TargetPos { get; } = new GSLocation();

	public GSLocation TargetSoulFocusPos { get; } = new GSLocation();

	public int TargetResID { get; set; }

	public int TargetExtendID { get; set; }

	public float DmcP2TDistance { get; set; }

	public float DmcP2THeightDistance { get; set; }

	public GSLocation DmcPlayerRef { get; } = new GSLocation();

	public GSLocation DmcTargetRef { get; } = new GSLocation();

	public float DmcRefOffset { get; set; }

	public float DmcRefOffsetClamped { get; set; }

	public float DmcRotationLerpSpeed { get; set; }

	public float Ex_ArmLengthOffset { get; set; }

	public float Ex_FovOffset { get; set; }

	public bool IsTurning { get; set; }

	public float G4TurnRunTime { get; set; }

	public float TickTotalTime { get; set; }

	public GSRotation TargetRotation { get; } = new GSRotation();

	public GSRotation BeginRotation { get; } = new GSRotation();

	public GSRotation DeltaRotation { get; } = new GSRotation();

	public float G4RotateSpeed { get; set; }

	public bool bInputAxisLookUpByGamePad { get; set; }

	public float InputAxisLookUp { get; set; }

	public bool bInputAxisTurnRightByGamePad { get; set; }

	public float InputAxisTurnRight { get; set; }

	public GSLocation ShootSuctionTargetDir { get; } = new GSLocation();

	public GSRotation CurInverseAnimRotator { get; } = new GSRotation();

	public GSRotation LastInverseAnimRotator { get; } = new GSRotation();

	public float TraceVelocitySpeedRate { get; set; }

	public bool bTraceVelocityOnlyYaw { get; set; }

	public float TraceVelocityInverseAngle { get; set; }

	public float TraceVelocityPauseTimeWhenCameraInput { get; set; }

	public GSRotation SplineMoveRotation { get; } = new GSRotation();

	public bool bIsCloudMovePitchLimitEnabled { get; set; }

	public float CurCloudMovePitchMax { get; set; }

	public bool bIsCloudMoving { get; set; }

	public TStrongObjectPtr<UCurveFloat> CloudFoliageFadeScaleCurve { get; } = new TStrongObjectPtr<UCurveFloat>();

	public bool bEnablePlayerCameraConversionParam { get; set; }

	public bool bEnableStraightCameraConversionParam { get; set; }

	public FCameraConversionParams ConversionParams { get; } = new FCameraConversionParams();

	public float OriginStraightCameraArmLengthDefault { get; set; }

	public float OriginDefaultMeshZOffsetLimit { get; set; }

	public float OriginDefaultArmLengthDefault { get; set; }

	public float OriginDefaultArmLocationZ { get; set; }

	public float OriginDefaultArmSocketOffsetZ { get; set; }

	public float OriginStraightPlayerRefHeightOffset { get; set; }
}
