using BtlShare;

namespace b1;

public class FCameraBlend_Default : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		base.CameraControlData.Target_ArmSocketOffset.SetValue(base.CameraState.Rt_ArmSocketOffset);
		base.CameraControlData.Target_ArmLength = base.CameraState.Rt_ArmLength;
		base.CameraControlData.ControllerRotation.SetValue(base.CameraState.Rt_ControllerRotation);
		base.CameraControlData.ArmLocation.SetValue(base.CameraState.Rt_ArmLocation);
		base.CameraControlData.ArmTargetOffset = base.CameraState.Rt_ArmTargetOffset;
		base.CameraControlData.ArmSocketOffset.SetValue(base.CameraState.Rt_ArmSocketOffset);
		base.CameraControlData.ArmLength = base.CameraState.Rt_ArmLength;
		base.CameraControlData.IsXAxisFixed = base.CameraState.Rt_IsXAxisSmoothed;
		base.CameraControlData.IsYAxisFixed = base.CameraState.Rt_IsYAxisSmoothed;
		base.CameraControlData.IsZAxisFixed = base.CameraState.Rt_IsZAxisSmoothed;
		base.CameraControlData.CameraLagSpeed.SetValue(base.CameraState.Rt_CameraLagSpeed);
		base.CameraControlData.CameraLagInverseSpeed.SetValue(base.CameraState.Rt_CameraLagInverseSpeed);
		base.CameraControlData.CameraLagMaxDistance.SetValue(base.CameraState.Rt_CameraLagMaxDistance);
		base.CameraControlData.FieldOfView = base.CameraState.Rt_FieldOfView;
		base.CameraControlData.FocalDistance = base.CameraState.Rt_FocalDistance;
		base.CameraControlData.DepthBlurKm = base.CameraState.Rt_DepthBlurKm;
		base.CameraControlData.DepthBlurRadius = base.CameraState.Rt_DepthBlurRadius;
		base.CameraControlData.ViewPitchMin = base.CameraState.Rt_ViewPitchMin;
		base.CameraControlData.ViewPitchMax = base.CameraState.Rt_ViewPitchMax;
		base.CameraControlData.ControllerYawInput = base.CameraState.InputAxisTurnRight;
		if (base.CameraState.bInputAxisTurnRightByGamePad)
		{
			base.CameraControlData.ControllerYawInput *= base.DeltaTime * 60f;
		}
		base.CameraControlData.ControllerPitchInput = base.CameraState.InputAxisLookUp * -0.3f;
		if (base.CameraState.bInputAxisLookUpByGamePad)
		{
			base.CameraControlData.ControllerPitchInput *= base.DeltaTime * 60f;
		}
		base.CameraControlData.ControllerRotationLerpSpeed = base.CameraState.Rt_ControllerRotationLerpSpeed;
		if (base.CameraState.IsLocked && base.CameraState.LockCamMode == ELockCamMode.Dmc)
		{
			base.CameraControlData.DmcActorLocation.SetValue(base.CameraState.Rt_DmcActorLocation);
			base.CameraControlData.DmcActorRotation.SetValue(base.CameraState.Rt_DmcActorRotation);
			base.CameraControlData.DmcArmLength = base.CameraState.Rt_DmcArmLength;
		}
		base.CameraControlData.FoliageFadeDistance = base.CameraState.Rt_FoliageFadeDistance;
	}

	public FCameraBlend_Default(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
