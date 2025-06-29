using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_AutoMoveTrail : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.IsAutoMoveTrailEnabled)
		{
			FRotator a = MathLib.Conv_VectorToRotator(base.CameraState.AutoMoveTargetDir);
			FRotator fRotator = MathLib.NormalizedDeltaRotator(a, base.CameraState.Rt_ControllerRotation.ToRotator());
			base.CameraControlData.ControllerYawInput = fRotator.Yaw * base.DeltaTime;
			base.CameraControlData.ControllerPitchInput = (0f - fRotator.Pitch) * base.DeltaTime;
		}
	}

	public FCameraBlend_AutoMoveTrail(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
