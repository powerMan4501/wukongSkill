namespace b1;

public class FCameraBlend_Dead : FCameraBlendBase
{
	public float ArmLength { get; set; }

	public float ArmLengthInterpSpeed { get; set; }

	public float CameraPitch { get; set; }

	public float CameraPitchInterpSpeed { get; set; }

	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.bPlayerDead)
		{
			base.CameraControlData.Target_ArmLength = ArmLength;
			base.CameraControlData.ArmLength = MathLib.FInterpTo(base.CameraState.Rt_ArmLength, base.CameraControlData.Target_ArmLength, base.DeltaTime, ArmLengthInterpSpeed);
			GSRotation Target = GSRotation.CreateByPool();
			Target.Pitch = CameraPitch;
			Target.Yaw = base.CameraState.Rt_ControllerRotation.Yaw;
			Target.Roll = 0f;
			base.CameraControlData.ControllerRotation.Pitch = MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in Target, base.DeltaTime, CameraPitchInterpSpeed).Pitch;
		}
	}

	public FCameraBlend_Dead(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
