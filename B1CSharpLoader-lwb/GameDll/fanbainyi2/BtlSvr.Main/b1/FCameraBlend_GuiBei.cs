namespace b1;

public class FCameraBlend_GuiBei : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (!base.CameraState.IsUseGuiBeiCamera)
		{
			base.CameraControlData.ControllerRotation.SetValue(base.CameraControlData.ControllerRotation - base.CameraState.LastInverseAnimRotator);
			return;
		}
		base.CameraControlData.IsZAxisFixed = false;
		base.CameraControlData.ControllerRotation.SetValue(base.CameraControlData.ControllerRotation - base.CameraState.LastInverseAnimRotator + base.CameraState.CurInverseAnimRotator);
	}

	public FCameraBlend_GuiBei(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
