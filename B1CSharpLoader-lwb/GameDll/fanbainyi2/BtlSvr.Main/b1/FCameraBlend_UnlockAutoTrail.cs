using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_UnlockAutoTrail : FCameraBlendBase
{
	public float CameraRotationMaxVelocity { get; set; }

	public float CameraRotationRateAccelerate { get; set; }

	public float CameraRotationVelocityThreshold { get; set; }

	public float FallingAdjustAngleLimit { get; set; }

	public float FallingAdjustSpeedPercent { get; set; }

	protected override void BlendCamera()
	{
		base.BlendCamera();
		if (base.CameraState.FreeCameraMode == EPlayerFreeCameraType.AutoTrail && base.CameraState.bEnableAutoTrail)
		{
			FRotator inRot = new FRotator(0.0, base.CameraState.PlayerPreviousControlRot.Yaw, 0.0);
			FVector forwardVector = inRot.GetForwardVector();
			float rt_AxisMoveForward = base.CameraState.Rt_AxisMoveForward;
			float rt_AxisMoveRight = base.CameraState.Rt_AxisMoveRight;
			GSLocation gSLocation = GSLocationPool.New();
			if (base.CameraState.PlayerIsAttacking || base.CameraState.PlayerIsGlideMoving)
			{
				GSLocation playerVelocity = base.CameraState.PlayerVelocity;
				playerVelocity.Z = 0f;
				playerVelocity.Normalize();
				gSLocation = base.CameraState.PlayerForwardVector * MathLib.Abs(base.CameraState.PlayerForwardVector | playerVelocity);
			}
			else
			{
				gSLocation.SetValue(forwardVector * rt_AxisMoveForward + inRot.GetRightVector() * rt_AxisMoveRight);
				gSLocation.Normalize();
			}
			float num = base.CameraState.PlayerVelocity.Size2D();
			float x = ((!base.CameraState.PlayerIsAttacking && !base.CameraState.PlayerIsGlideMoving) ? (MathLib.Abs(rt_AxisMoveForward) + MathLib.Abs(rt_AxisMoveRight)) : num);
			if (num < CameraRotationVelocityThreshold)
			{
				x = 0f;
			}
			x = MathLib.Clamp(x, 0f, 1f);
			float Current = base.CameraBlendCache.LastCameraRotationVelocity;
			Current = ((!(x < 1E-06f)) ? MathLib.FInterpTo(in Current, CameraRotationMaxVelocity, base.DeltaTime, CameraRotationRateAccelerate) : 0f);
			base.CameraBlendCache.LastCameraRotationVelocity = Current;
			float num2 = 1f - MathLib.Abs(forwardVector | gSLocation.ToVector());
			num2 *= 0.8f;
			float num3;
			if (base.CameraState.PlayerIsInAir)
			{
				num3 = 0f;
			}
			else
			{
				num3 = Current * x * num2 * base.DeltaTime;
				num3 = MathLib.Clamp(num3, 0f, 1f);
			}
			float num4 = MathLib.NormalizedDeltaRotator(MathLib.Conv_VectorToRotator(gSLocation.ToVector()), base.CameraState.Rt_ControllerRotation.ToRotator()).Yaw;
			if (base.CameraState.PlayerIsAttacking)
			{
				num4 = MathLib.Clamp(num4, -45f, 45f);
			}
			base.CameraControlData.ControllerYawInput += num3 * num4;
		}
	}

	public FCameraBlend_UnlockAutoTrail(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
