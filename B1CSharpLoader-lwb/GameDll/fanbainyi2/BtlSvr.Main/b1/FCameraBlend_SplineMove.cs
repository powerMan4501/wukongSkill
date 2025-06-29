namespace b1;

public class FCameraBlend_SplineMove : FCameraBlendBase
{
	public float CameraPitchAdditive { get; set; }

	public float CameraYawAdditive { get; set; }

	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.bUseSplineMoveCamera)
		{
			base.CameraControlData.ControllerYawInput = 0f;
			base.CameraControlData.ControllerPitchInput = 0f;
			GSRotation splineMoveRotation = base.CameraState.SplineMoveRotation;
			splineMoveRotation.Pitch += CameraPitchAdditive;
			splineMoveRotation.Yaw += CameraYawAdditive;
			base.CameraControlData.ControllerRotation.SetValue(MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, base.CameraState.SplineMoveRotation, base.DeltaTime, 2f));
		}
	}

	public FCameraBlend_SplineMove(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
