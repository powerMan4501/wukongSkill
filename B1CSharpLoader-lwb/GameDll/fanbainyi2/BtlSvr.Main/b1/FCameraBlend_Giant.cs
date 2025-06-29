using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_Giant : FCameraBlendBase
{
	public FCameraBlend_Giant(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}

	protected override void BlendCamera()
	{
		if (!base.CameraState.bUseMonsterSkillCamera)
		{
			Blend2GiantCamera();
		}
	}

	protected void Blend2GiantCamera()
	{
		CalcRefPositions(out var PlayerRefPos, out var TargetRefPos);
		float YOffset = 0f;
		float interpSpeed = 5f;
		float num = base.CameraState.GiantTargetScreenMaxRatio * base.CameraState.Rt_FieldOfView / 2f;
		GSRotation LookAtRotation;
		GSLocation AimRefPos2;
		GSRotation LookAtRotation2;
		if (base.CameraBlendCache.LastGiantTargetRefPos != null)
		{
			GSLocation gSLocation = base.CameraBlendCache.LastGiantTargetRefPos - base.CameraBlendCache.LastGiantPlayerRefPos + PlayerRefPos;
			gSLocation.Z = TargetRefPos.Z;
			CalcLookAtParam(PlayerRefPos, gSLocation, out var _, out var AimRefPos, out LookAtRotation);
			CalcLookAtParam(PlayerRefPos, TargetRefPos, out YOffset, out AimRefPos2, out LookAtRotation2);
			float num2 = FMath.FindDeltaAngleDegrees(LookAtRotation2.Yaw, LookAtRotation.Yaw);
			if (FMath.Abs(num2) >= num)
			{
				float angleDeg = num * FMath.Abs(num2) / num2;
				gSLocation = (TargetRefPos - PlayerRefPos).RotateAngleAxis(angleDeg, GSLocation.UpVector) + PlayerRefPos;
				CalcLookAtParam(PlayerRefPos, gSLocation, out YOffset, out AimRefPos2, out LookAtRotation2);
				base.CameraBlendCache.LastGiantTargetRefPos.SetValue(AimRefPos2);
				interpSpeed = 0f;
			}
			else
			{
				LookAtRotation2.Yaw = LookAtRotation.Yaw;
				base.CameraBlendCache.LastGiantTargetRefPos.SetValue(AimRefPos);
			}
			base.CameraBlendCache.LastGiantPlayerRefPos.SetValue(PlayerRefPos);
		}
		else
		{
			CalcLookAtParam(PlayerRefPos, TargetRefPos, out YOffset, out AimRefPos2, out LookAtRotation2);
			LookAtRotation = base.CameraState.Rt_ControllerRotation;
			if (FMath.Abs(FMath.FindDeltaAngleDegrees(LookAtRotation2.Yaw, LookAtRotation.Yaw)) < 0.001f)
			{
				base.CameraBlendCache.LastGiantTargetRefPos = TargetRefPos;
				base.CameraBlendCache.LastGiantPlayerRefPos = PlayerRefPos;
			}
		}
		GSRotation Target = base.CameraControlData.ControllerRotation;
		base.MonitorData.GiantOriginControllerRotation.SetValue(Target);
		Target.Pitch = MathLib.Clamp(LookAtRotation2.Pitch, base.CameraState.GiantMinPitch, base.CameraState.GiantMaxPitch);
		Target.Yaw = LookAtRotation2.Yaw;
		base.CameraControlData.Target_ArmSocketOffset.Y = YOffset;
		base.CameraControlData.Target_ArmLength = base.CameraState.GiantArmLength;
		base.CameraControlData.ControllerRotation.Yaw = MathLib.RInterpTo(in LookAtRotation, in Target, base.DeltaTime, interpSpeed).Yaw;
		base.CameraControlData.ControllerRotation.Pitch = MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in Target, base.DeltaTime, base.CameraState.GiantPitchLerpSpeed).Pitch;
		base.CameraControlData.ArmSocketOffset.Y = FMath.FInterpTo(base.CameraState.Rt_ArmSocketOffset.Y, base.CameraControlData.Target_ArmSocketOffset.Y, base.DeltaTime, base.CameraState.GiantCameraOffsetLerpSpeed);
		base.CameraControlData.ViewPitchMin = base.CameraState.GiantMinPitch;
		base.CameraControlData.ViewPitchMax = base.CameraState.GiantMaxPitch;
		base.CameraControlData.ArmLength = FMath.FInterpTo(base.CameraState.Rt_ArmLength, base.CameraControlData.Target_ArmLength, base.DeltaTime, base.CameraState.GiantArmLengthLerpSpeed);
	}

	private void CalcRefPositions(out GSLocation PlayerRefPos, out GSLocation TargetRefPos)
	{
		GSLocation gSLocation = GSLocationPool.New();
		if (base.CameraBlendCache.bRefPosUninitialized || base.CameraState.bResetGiantPlayerRefCache)
		{
			base.CameraState.bResetGiantPlayerRefCache = false;
			base.CameraBlendCache.bRefPosUninitialized = false;
			gSLocation.SetValue(0f, 0f, base.CameraState.GiantPlayerRefHeightOffset);
			base.CameraBlendCache.CurPlayerGiantRefPos.SetValue(gSLocation);
			gSLocation.SetValue(0f, 0f, base.CameraState.GiantTargetRefHeightOffset);
			base.CameraBlendCache.CurTargetGiantRefPos.SetValue(gSLocation);
		}
		else
		{
			gSLocation.SetValue(0f, 0f, base.CameraState.GiantPlayerRefHeightOffset);
			base.CameraBlendCache.CurPlayerGiantRefPos.SetValue(MathLib.VInterpTo(base.CameraBlendCache.CurPlayerGiantRefPos, gSLocation, base.DeltaTime, base.CameraState.GiantPlayerRefHeightOffsetLerpSpeed));
			gSLocation.SetValue(0f, 0f, base.CameraState.GiantTargetRefHeightOffset);
			base.CameraBlendCache.CurTargetGiantRefPos.SetValue(MathLib.VInterpTo(base.CameraBlendCache.CurTargetGiantRefPos, gSLocation, base.DeltaTime, base.CameraState.GiantTargetRefHeightOffsetLerpSpeed));
		}
		PlayerRefPos = base.CameraState.PlayerPos + base.CameraBlendCache.CurPlayerGiantRefPos;
		TargetRefPos = GSLocationPool.New();
		TargetRefPos = base.CameraBlendCache.CurTargetGiantRefPos;
		float num = (base.CameraState.TargetPos - base.CameraState.PlayerPos).Size2D();
		UCurveFloat uCurveFloat = base.CameraState.GiantTargetRefHeightOffsetCurve.Get();
		if (uCurveFloat != null)
		{
			TargetRefPos.Z += uCurveFloat.GetFloatValue(num);
		}
		GSLocation gSLocation2 = GSLocationPool.New();
		gSLocation2 = base.CameraState.TargetSoulFocusPos;
		float num2 = FMath.Abs(base.CameraState.TargetSoulFocusPos.Z - base.CameraState.PlayerPos.Z);
		base.MonitorData.GiantHeightDistance = num2;
		if (num2 <= base.CameraState.GiantHeightThreshold)
		{
			gSLocation2.Z = base.CameraState.TargetRootPos.Z;
			gSLocation2 += GSLocation.UpVector * base.CameraState.GiantHeightThreshold;
		}
		TargetRefPos += gSLocation2;
		base.MonitorData.GiantPlayerRefPos.SetValue(PlayerRefPos);
		base.MonitorData.GiantTargetRefPos.SetValue(TargetRefPos);
		base.MonitorData.GiantP2TDistance = num;
	}

	private void CalcLookAtParam(GSLocation PlayerRefPos, GSLocation TargetRefPos, out float YOffset, out GSLocation AimRefPos, out GSRotation LookAtRotation)
	{
		LookAtRotation = GSRotationPool.New();
		GSLocation gSLocation = CalcP2CVector2D(PlayerRefPos, TargetRefPos, base.CameraState.GiantArmLength, base.CameraState.GiantPlayerScreenRatio, out YOffset, out AimRefPos);
		GSLocation B = GSLocationPool.New();
		LookAtRotation.SetValue(MathLib.MakeRotFromX((AimRefPos - B).ToVector()));
		B = gSLocation * YOffset + PlayerRefPos;
		base.MonitorData.GiantCameraRefPos.SetValue(B);
		LookAtRotation.Yaw = MathLib.MakeRotFromX((AimRefPos - B).ToVector()).Yaw;
		LookAtRotation.Pitch = MathLib.MakeRotFromX((AimRefPos - B).ToVector()).Pitch;
		LookAtRotation.Roll = 0f;
	}

	private GSLocation CalcP2CVector2D(GSLocation PlayerRefPos, GSLocation TargetRefPos, float ArmLength, float DepartScreenRatio, out float YOffset, out GSLocation AimRefPos)
	{
		GSLocation gSLocation = PlayerRefPos - TargetRefPos;
		float num = gSLocation.Size();
		YOffset = (0f - ArmLength) * FMath.Sin(FMath.DegreesToRadians(base.CameraState.Rt_FieldOfView / 2f)) * DepartScreenRatio;
		float num2 = FMath.Max(num, YOffset * 1.1f);
		float num3 = FMath.RadiansToDegrees(FMath.Acos(FMath.Abs(YOffset) / num));
		if (DepartScreenRatio > 0f)
		{
			num3 = 0f - num3;
		}
		GSLocation result = gSLocation.GetSafeNormal2D().Rotation().Add(0f, 0f - num3, 0f)
			.Vector();
		AimRefPos = PlayerRefPos - gSLocation.GetSafeNormal() * num2;
		return result;
	}
}
