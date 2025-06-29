using UnrealEngine.Runtime;

namespace b1;

public static class FCameraDefaultData
{
	public static float ViewPitchMin = -40f;

	public static float ViewPitchMax = 50f;

	public const int DefaultCameraGroupID = 0;

	public const float DefaultRotateSpeed = 6f;

	public const float DefaultArmLengthLerpSpeed = 800f;

	public const float TargetFlyHeightThreshold = 450f;

	public const float Straight_MinPitch = -40f;

	public const float Straight_MaxPitch = 20f;

	public const float FocalDistanceLerpSpeed = 5f;

	public const float DepthBlurKmLerpSpeed = 5f;

	public const float DepthBlurRadiusLerpSpeed = 5f;

	public const float ControllerPitchInputFactor = -0.3f;

	public const float G4_MinPitch = -45f;

	public const float G4_MaxPitch = 45f;

	public const float G4_PitchClampSpeed = 100f;

	public const float G4_TraceStartAngle = 10f;

	public const float TraceBlendSpeed = 20f;

	public const EGSBlendTypeG TraceBlendType = EGSBlendTypeG.GSEaseInOut;

	public const float TraceBlendExp = 1f;

	public const float SpotTurnBlendSpeed = -360f;

	public const EGSBlendTypeG SpotTurnBlendType = EGSBlendTypeG.GSEaseOut;

	public const float SpotTurnBlendExp = 1f;

	public const int DefaultAdaptFrameRate = 60;

	public const float DefaultCameraFadeDistance = 750f;

	public const float DefaultCameraFadeDistanceLerpSpeed = 1f;

	public const float DefaultArmTargetOffsetLerpSpeed = 5f;

	public const float DefaultStraightTraceTargetRefFastSpeed = 3f;

	public static FName PelvisName => B1GlobalFNames.pelvis;

	public static FName SoulFocusName => B1GlobalFNames.SoulFocus;

	public static FName SoulFocusZName => B1GlobalFNames.SoulFocusZ;
}
