namespace b1;

public class FCameraBlend_CloudMoveLimit : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.bIsCloudMovePitchLimitEnabled && base.CameraControlData.ControllerRotation.Pitch > base.CameraState.CurCloudMovePitchMax)
		{
			base.CameraControlData.ControllerRotation.Pitch = base.CameraState.CurCloudMovePitchMax;
		}
	}

	public FCameraBlend_CloudMoveLimit(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
