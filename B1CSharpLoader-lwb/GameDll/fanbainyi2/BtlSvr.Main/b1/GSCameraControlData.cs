using UnrealEngine.Runtime;

namespace b1;

public class GSCameraControlData
{
	public FVector ArmTargetOffset;

	public GSLocation Target_ArmSocketOffset { get; } = new GSLocation();

	public float Target_ArmLength { get; set; }

	public GSRotation ControllerRotation { get; } = new GSRotation();

	public GSLocation ArmLocation { get; } = new GSLocation();

	public GSLocation ArmSocketOffset { get; } = new GSLocation();

	public float ArmLength { get; set; }

	public float ArmLocationLerpSpeed { get; set; }

	public float ControllerRotationLerpSpeed { get; set; }

	public float ArmSocketOffsetLerpSpeed { get; set; }

	public float FovLerpSpeed { get; set; }

	public float ArmLengthLerpSpeed { get; set; }

	public float FieldOfView { get; set; }

	public float FocalDistance { get; set; }

	public float DepthBlurKm { get; set; }

	public float DepthBlurRadius { get; set; }

	public float ControllerYawInput { get; set; }

	public float ControllerPitchInput { get; set; }

	public bool IsXAxisFixed { get; set; }

	public bool IsYAxisFixed { get; set; }

	public bool IsZAxisFixed { get; set; }

	public GSLocation CameraLagMaxDistance { get; } = new GSLocation();

	public GSLocation CameraLagSpeed { get; } = new GSLocation();

	public GSLocation CameraLagInverseSpeed { get; } = new GSLocation();

	public float ViewPitchMin { get; set; }

	public float ViewPitchMax { get; set; }

	public float ViewYawMin { get; set; }

	public float ViewYawMax { get; set; }

	public GSLocation DmcActorLocation { get; } = new GSLocation();

	public GSRotation DmcActorRotation { get; } = new GSRotation();

	public float DmcArmLength { get; set; }

	public float FoliageFadeDistance { get; set; }

	public bool bUseCustomFov { get; set; }

	public bool bUseCustomCameraPitch { get; set; }

	public float CustomCameraPitch { get; set; }
}
