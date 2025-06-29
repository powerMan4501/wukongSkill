namespace b1;

public class FCameraBlend_Curve : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.HasPitchCurve)
		{
			float alpha = ((base.CameraState.PitchCurveBlendTimer > 0f) ? (base.CameraState.PitchCurveTime / (base.CameraState.PitchCurveTime + base.CameraState.PitchCurveBlendTimer)) : 1f);
			GSRotation B = GSRotationPool.New();
			B.SetValue(base.CameraState.PitchCurveValue, base.CameraControlData.ControllerRotation.Yaw, base.CameraControlData.ControllerRotation.Roll);
			float pitch = MathLib.Lerp(base.CameraState.PitchCurveOriValue, in B, alpha).Pitch;
			base.CameraControlData.ControllerRotation.SetValue(pitch, base.CameraControlData.ControllerRotation.Yaw, base.CameraControlData.ControllerRotation.Roll);
		}
		if (base.CameraState.HasArmLengthCurve)
		{
			float alpha2 = ((base.CameraState.ArmLengthCurveBlendTimer > 0f) ? (base.CameraState.ArmLengthCurveTime / (base.CameraState.ArmLengthCurveTime + base.CameraState.ArmLengthCurveBlendTimer)) : 1f);
			base.CameraControlData.ArmLength = MathLib.Lerp(base.CameraState.ArmLengthCurveOriValue, base.CameraState.ArmLengthCurveValue, alpha2);
		}
		else if (base.CameraState.ArmLengthCurveBlendOutTime > 0f)
		{
			float alpha3 = ((base.CameraState.ArmLengthCurveBlendTimer > 0f) ? ((base.CameraState.ArmLengthCurveBlendOutTime - base.CameraState.ArmLengthCurveBlendTimer) / base.CameraState.ArmLengthCurveBlendOutTime) : 1f);
			base.CameraControlData.ArmLength = MathLib.Lerp(base.CameraState.ArmLengthCurveValue, base.CameraControlData.Target_ArmLength, alpha3);
		}
		if (base.CameraState.HasSASOCurve)
		{
			float alpha4 = ((base.CameraState.SASOCurveBlendTimer > 0f) ? (base.CameraState.SASOCurveTime / (base.CameraState.SASOCurveTime + base.CameraState.SASOCurveBlendTimer)) : 1f);
			base.CameraControlData.ArmSocketOffset.SetValue(MathLib.Lerp(base.CameraState.SASOCurveOriValue, base.CameraState.SASOCurveValue, alpha4));
		}
		else if (base.CameraState.SASOCurveBlendOutTime > 0f)
		{
			float alpha5 = ((base.CameraState.SASOCurveBlendTimer > 0f) ? ((base.CameraState.SASOCurveBlendOutTime - base.CameraState.SASOCurveBlendTimer) / base.CameraState.SASOCurveBlendOutTime) : 1f);
			base.CameraControlData.ArmSocketOffset.SetValue(MathLib.Lerp(base.CameraState.SASOCurveValue, base.CameraControlData.Target_ArmSocketOffset, alpha5));
		}
		if (base.CameraState.HasArmLocationZCurve)
		{
			float alpha6 = ((base.CameraState.ArmLocationZCurveBlendTime > 0f) ? (base.CameraState.ArmLocationZCurveTime / (base.CameraState.ArmLocationZCurveTime + base.CameraState.ArmLocationZCurveBlendTime)) : 1f);
			base.CameraControlData.ArmLocation.Z = MathLib.Lerp(base.CameraState.ArmLocationZCurveOriValue, base.CameraState.ArmLocationZCurveValue, alpha6);
		}
		else if (base.CameraState.ArmLocationZCurveBlendOutTime > 0f)
		{
			float alpha7 = ((base.CameraState.ArmLocationZCurveBlendTime > 0f) ? ((base.CameraState.ArmLocationZCurveBlendOutTime - base.CameraState.ArmLocationZCurveBlendTime) / base.CameraState.ArmLocationZCurveBlendOutTime) : 1f);
			base.CameraControlData.ArmLocation.Z = MathLib.Lerp(base.CameraState.ArmLocationZCurveValue, base.CameraControlData.ArmLocation.Z, alpha7);
		}
	}

	public FCameraBlend_Curve(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
