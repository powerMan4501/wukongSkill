using System;

namespace b1;

public class FCameraBlend_Player : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		if (!base.CameraState.bUsePlayerSkillCamera)
		{
			BlendPlayerCamera();
		}
	}

	protected void BlendPlayerCamera()
	{
		base.CameraControlData.ArmLocationLerpSpeed = base.CameraState.DefaultArmLocationLerpSpeed;
		base.CameraControlData.ArmSocketOffsetLerpSpeed = base.CameraState.DefaultArmSocketOffsetLerpSpeed;
		base.CameraControlData.FovLerpSpeed = base.CameraState.DefaultFOVLerpSpeed;
		base.CameraControlData.ArmLengthLerpSpeed = base.CameraState.DefaultArmLengthLerpSpeed;
		base.CameraControlData.FocalDistance = base.CameraState.DefaultFocalDistance;
		base.CameraControlData.DepthBlurKm = base.CameraState.DefaultDepthBlurKM;
		base.CameraControlData.DepthBlurRadius = base.CameraState.DefaultDepthBlurRadius;
		GSLocation B = GSLocationPool.New();
		B.SetValue(0f, 0f, base.CameraState.PlayerMeshOffset.Z);
		if (Math.Abs(B.Z) < base.CameraState.DefaultMeshZOffsetLimit)
		{
			B.Z = 0f;
		}
		base.CameraControlData.ViewPitchMin = base.CameraState.DefaultPitchMin;
		base.CameraControlData.ViewPitchMax = base.CameraState.DefaultPitchMax;
		base.CameraControlData.ViewYawMin = base.CameraState.DefaultYawMin;
		base.CameraControlData.ViewYawMax = base.CameraState.DefaultYawMax;
		base.CameraControlData.Target_ArmLength = GetDefaultArmLength() + base.CameraState.Ex_ArmLengthOffset;
		base.CameraControlData.Target_ArmSocketOffset.SetValue(base.CameraState.DefaultArmSocketOffset);
		if (base.CameraState.bPlayerDuringRebirth || base.CameraState.bNotInitial)
		{
			base.CameraControlData.ArmLocation.SetValue(base.CameraState.DefaultArmLocation);
			base.CameraControlData.ArmLength = base.CameraControlData.Target_ArmLength;
			base.CameraControlData.ArmSocketOffset.SetValue(base.CameraControlData.Target_ArmSocketOffset);
			base.CameraControlData.FieldOfView = base.CameraState.DefaultFOV;
			base.CameraControlData.ArmTargetOffset = base.CameraState.DefaultArmTargetOffset;
			base.CameraState.bNotInitial = false;
		}
		else
		{
			base.CameraControlData.ArmLocation.SetValue(MathLib.VInterpTo(base.CameraState.Rt_ArmLocation, base.CameraState.DefaultArmLocation + B, base.DeltaTime, base.CameraState.DefaultArmLocationLerpSpeed));
			base.CameraControlData.ArmLength = MathLib.FInterpTo(base.CameraState.Rt_ArmLength, base.CameraControlData.Target_ArmLength, base.DeltaTime, base.CameraControlData.ArmLengthLerpSpeed);
			base.CameraControlData.ArmTargetOffset = MathLib.VInterpTo(base.CameraState.Rt_ArmTargetOffset, base.CameraState.DefaultArmTargetOffset, base.DeltaTime, 5f);
			base.CameraControlData.ArmSocketOffset.SetValue(MathLib.VInterpTo(base.CameraState.Rt_ArmSocketOffset, base.CameraControlData.Target_ArmSocketOffset, base.DeltaTime, base.CameraState.DefaultArmSocketOffsetLerpSpeed));
			base.CameraControlData.FieldOfView = MathLib.FInterpTo(base.CameraState.Rt_FieldOfView, base.CameraState.DefaultFOV, base.DeltaTime, base.CameraState.DefaultFOVLerpSpeed);
		}
		base.CameraControlData.FoliageFadeDistance = MathLib.FInterpTo(base.CameraState.Rt_FoliageFadeDistance, 750f, base.DeltaTime, base.CameraState.FoliageFadeDistanceLerpSpeed);
		base.CameraControlData.FieldOfView = MathLib.FInterpTo(base.CameraState.Rt_FieldOfView, base.CameraState.DefaultFOV + base.CameraState.Ex_FovOffset + base.CameraState.StraightFovOffset, base.DeltaTime, base.CameraState.DefaultFOVLerpSpeed);
		base.CameraControlData.FocalDistance = MathLib.FInterpTo(base.CameraState.Rt_FocalDistance, base.CameraState.DefaultFocalDistance, base.DeltaTime, 5f);
		base.CameraControlData.DepthBlurKm = MathLib.FInterpTo(base.CameraState.Rt_DepthBlurKm, base.CameraState.DefaultDepthBlurKM, base.DeltaTime, 5f);
		base.CameraControlData.DepthBlurRadius = MathLib.FInterpTo(base.CameraState.Rt_DepthBlurRadius, base.CameraState.DefaultDepthBlurRadius, base.DeltaTime, 5f);
	}

	public FCameraBlend_Player(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
