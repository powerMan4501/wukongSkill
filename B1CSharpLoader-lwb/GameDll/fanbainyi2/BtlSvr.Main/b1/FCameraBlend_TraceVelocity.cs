namespace b1;

public class FCameraBlend_TraceVelocity : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (!base.CameraState.bUseTraceVelocityCamera || base.CameraState.LastCameraInputTimer < base.CameraState.TraceVelocityPauseTimeWhenCameraInput)
		{
			return;
		}
		GSLocation playerVelocity = base.CameraState.PlayerVelocity;
		if (!playerVelocity.IsNearlyZero())
		{
			if (base.CameraState.TraceVelocityInverseAngle > 0f && GSLocation.DotProduct(playerVelocity.GetSafeNormal(), base.CameraState.Rt_ControllerRotation.Vector().GetSafeNormal()) < MathLib.DegAcos(base.CameraState.TraceVelocityInverseAngle))
			{
				playerVelocity *= -1f;
			}
			GSRotation Target = playerVelocity.Rotation();
			if (base.CameraState.bTraceVelocityOnlyYaw)
			{
				Target.Pitch = base.CameraState.Rt_ControllerRotation.Pitch;
				Target.Roll = base.CameraState.Rt_ControllerRotation.Roll;
			}
			base.CameraControlData.ControllerRotation.SetValue(MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in Target, base.DeltaTime, base.CameraState.TraceVelocitySpeedRate));
		}
	}

	public FCameraBlend_TraceVelocity(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
