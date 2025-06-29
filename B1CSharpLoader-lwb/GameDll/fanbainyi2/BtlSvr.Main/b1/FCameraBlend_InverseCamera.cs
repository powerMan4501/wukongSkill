namespace b1;

public class FCameraBlend_InverseCamera : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.PlayerCanMove || base.CameraState.bCastRollingSkill)
		{
			_ = base.CameraState.FreeCameraMode;
			_ = 2;
		}
	}

	public FCameraBlend_InverseCamera(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
