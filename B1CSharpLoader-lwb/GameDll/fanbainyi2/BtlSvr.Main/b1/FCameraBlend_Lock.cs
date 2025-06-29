using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FCameraBlend_Lock : FCameraBlendBase
{
	protected override void BlendCamera()
	{
		if (!base.CameraState.bUseMonsterSkillCamera)
		{
			Blend2LockCamera();
		}
	}

	protected void Blend2LockCamera()
	{
		if (!base.CameraState.IsLocked)
		{
			return;
		}
		if (base.CameraState.FreeCameraMode == EPlayerFreeCameraType.G4Mode)
		{
			BlendG4LockCamera();
			return;
		}
		switch (base.CameraState.LockCamMode)
		{
		case ELockCamMode.Soul:
			if (GSGameplayCVar.CVar_StraightCameraVersion.GetValueInGameThread() == 2)
			{
				BlendStraightLockCameraV2();
			}
			else
			{
				BlendStraightLockCamera();
			}
			break;
		case ELockCamMode.Dmc:
			BlendDiagonalLockCamera();
			break;
		}
	}

	private GSLocation SlowTraceTargetRefPos(GSLocation InTargetRefPos, GSLocation InPlayerRefPos)
	{
		FStraightParams straightParams = base.MonitorData.StraightParams;
		straightParams.TargetRef_SlowTrace_Before = InTargetRefPos.ToVector();
		straightParams.TargetRef_SlowTrace_Input_StraightTraceSolution = base.CameraState.StraightTraceSolution;
		straightParams.TargetRef_SlowTrace_Input_StraightSlowTraceTargetRefMaxYaw = base.CameraState.StraightSlowTraceTargetRefMaxYaw;
		straightParams.TargetRef_SlowTrace_Input_StraightMaxTraceTargetRefDist = base.CameraState.StraightMaxTraceTargetRefDist;
		straightParams.TargetRef_SlowTrace_Input_StraightTraceTargetRefSpeed = base.CameraState.StraightTraceTargetRefSpeed;
		GSLocation gSLocation;
		if (base.CameraState.StraightTraceSolution == ESlowTraceSolution.Angle)
		{
			gSLocation = SlowTraceRefPosByAngle(InTargetRefPos, InPlayerRefPos);
			straightParams.TargetRef_SlowTrace_After = gSLocation.ToVector();
			return gSLocation;
		}
		gSLocation = SlowTraceTargetRefPosByDistance(InTargetRefPos, InPlayerRefPos);
		straightParams.TargetRef_SlowTrace_After = gSLocation.ToVector();
		return gSLocation;
	}

	private GSLocation SlowTraceTargetRefPosByDistance(GSLocation InTargetRefPos, GSLocation InPlayerRefPos)
	{
		GSLocation gSLocation = InTargetRefPos;
		if (GSLocation.DotProduct(base.CameraState.PlayerRootPos - base.CameraState.TargetRootPos, InPlayerRefPos - base.CameraBlendCache.LastTargetRefPos) < 0f)
		{
			gSLocation = InTargetRefPos;
		}
		else if ((base.CameraBlendCache.LastTargetRefPos - InTargetRefPos).Size2D() > base.CameraState.StraightMaxTraceTargetRefDist)
		{
			gSLocation = InTargetRefPos;
		}
		else
		{
			gSLocation.SetValue(MathLib.VInterpTo(base.CameraBlendCache.LastTargetRefPos, InTargetRefPos, base.DeltaTime, base.CameraState.StraightTraceTargetRefSpeed));
		}
		base.CameraBlendCache.LastTargetRefPos.SetValue(gSLocation);
		base.CameraBlendCache.LastPlayerRefPos.SetValue(InPlayerRefPos);
		return gSLocation;
	}

	private GSLocation SlowTraceRefPosByAngle(GSLocation InTargetRefPos, GSLocation InPlayerRefPos)
	{
		GSLocation gSLocation;
		if (GSLocation.DotProduct(base.CameraState.PlayerRootPos - base.CameraState.TargetRootPos, InPlayerRefPos - base.CameraBlendCache.LastTargetRefPos) < 0f)
		{
			gSLocation = InTargetRefPos;
		}
		else
		{
			float num = MathLib.DegAcos(GSLocation.DotProductNormalize(base.CameraBlendCache.LastTargetRefPos - InPlayerRefPos, InTargetRefPos - InPlayerRefPos));
			if (num > base.CameraState.StraightSlowTraceTargetRefMaxYaw)
			{
				gSLocation = InTargetRefPos;
			}
			else if (base.CameraState.StraightTraceSpeedCurve.IsValid())
			{
				float z = base.CameraState.StraightTraceSpeedCurve.Get().GetVectorValue(num).Z;
				float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, num), new FVector2D(0.0, (InTargetRefPos - base.CameraBlendCache.LastTargetRefPos).Size2D()), base.DeltaTime * z);
				gSLocation = base.CameraBlendCache.LastTargetRefPos + (InTargetRefPos - base.CameraBlendCache.LastTargetRefPos).GetSafeNormal2D() * mappedRangeValueClamped;
			}
			else
			{
				gSLocation = InTargetRefPos;
			}
		}
		base.CameraBlendCache.LastTargetRefPos.SetValue(gSLocation);
		base.CameraBlendCache.LastPlayerRefPos.SetValue(InPlayerRefPos);
		return gSLocation;
	}

	private void BlendStraightLockCamera()
	{
		FStraightParams straightParams = base.MonitorData.StraightParams;
		float num = (base.CameraState.PlayerRootPos - base.CameraState.TargetRootPos).Size2D();
		base.MonitorData.StraightP2TDistance = num;
		GSLocation B = GSLocationPool.New();
		straightParams.TargetRef_CurveStep_Before = B.ToVector();
		straightParams.TargetRef_CurveStep_Input_P2TDistance = num;
		float num2 = 0f;
		UCurveVector uCurveVector = base.CameraState.StraightOffsetCurve.Get();
		if (uCurveVector != null)
		{
			FVector vectorValue = uCurveVector.GetVectorValue(num);
			num2 = vectorValue.X;
			base.CameraControlData.ArmLocation.Z = MathLib.FInterpTo(base.CameraState.Rt_ArmLocation.Z, base.CameraState.DefaultArmLocation.Z + vectorValue.Y, base.DeltaTime, base.CameraState.DefaultArmLocationLerpSpeed);
			B.Z = vectorValue.Z;
			base.MonitorData.StraightOffsetCurveValue.SetValue(vectorValue);
		}
		else
		{
			base.MonitorData.StraightOffsetCurveValue.SetValue(0f);
		}
		straightParams.TargetRef_CurveStep_After = B.ToVector();
		GSRotation controllerRotation = base.CameraControlData.ControllerRotation;
		GSLocation gSLocation = GSLocationPool.New();
		straightParams.TargetRef_OffsetStep_Before = B.ToVector();
		straightParams.TargetRef_OffsetStep_Input_StraightTargetRefHeightOffset = base.CameraState.StraightTargetRefHeightOffset;
		straightParams.TargetRef_OffsetStep_Input_StraightTargetRefHeightOffsetSpeed = base.CameraState.StraightTargetRefHeightOffsetSpeed;
		if (base.CameraBlendCache.bRefPosUninitialized || base.CameraState.bResetStraightPlayerRefCache)
		{
			base.CameraState.bResetStraightPlayerRefCache = false;
			base.CameraBlendCache.bRefPosUninitialized = false;
			gSLocation.SetValue(0f, 0f, base.CameraState.StraightPlayerRefHeightOffset);
			base.CameraBlendCache.CurPlayerRefPos.SetValue(gSLocation);
			gSLocation.Z = base.CameraState.StraightTargetRefHeightOffset;
			base.CameraBlendCache.CurTargetRefPos.SetValue(gSLocation);
		}
		else
		{
			gSLocation.SetValue(0f, 0f, base.CameraState.StraightPlayerRefHeightOffset);
			base.CameraBlendCache.CurPlayerRefPos.SetValue(MathLib.VInterpTo(base.CameraBlendCache.CurPlayerRefPos, gSLocation, base.DeltaTime, base.CameraState.StraightPlayerRefHeightOffsetSpeed));
			gSLocation.Z = base.CameraState.StraightTargetRefHeightOffset;
			base.CameraBlendCache.CurTargetRefPos.SetValue(MathLib.VInterpTo(base.CameraBlendCache.CurTargetRefPos, gSLocation, base.DeltaTime, base.CameraState.StraightTargetRefHeightOffsetSpeed));
		}
		straightParams.TargetRef_OffsetStep_Procedure_TargetRefPos = base.CameraBlendCache.CurTargetRefPos.ToVector();
		GSLocation A = base.CameraState.PlayerRefBase + base.CameraBlendCache.CurPlayerRefPos;
		GSLocation A2 = base.CameraBlendCache.CurTargetRefPos + B;
		straightParams.TargetRef_OffsetStep_After = A2.ToVector();
		GSLocation A3 = GSLocationPool.New();
		float straightHeightScaleFactor = base.CameraState.StraightHeightScaleFactor;
		float straightClosestDist = base.CameraState.StraightClosestDist;
		float straightHeightScaleFurthestDist = base.CameraState.StraightHeightScaleFurthestDist;
		float alpha = (num - straightClosestDist) / (straightHeightScaleFurthestDist - straightClosestDist);
		float x = MathLib.Lerp(0f, straightHeightScaleFactor, alpha);
		x = ((!(straightHeightScaleFactor > 0f)) ? MathLib.Clamp(x, straightHeightScaleFactor, 0f) : MathLib.Clamp(x, 0f, straightHeightScaleFactor));
		float[] straightCameraParamFloats = base.CameraState.StraightCameraParamFloats;
		float num3 = ((straightCameraParamFloats != null && straightCameraParamFloats.Length != 0) ? base.CameraState.StraightCameraParamFloats[0] : (-1f));
		if (num < num3)
		{
			bool flag = false;
			GSLocation gSLocation2 = base.CameraState.TargetRootPos - base.CameraState.Rt_CameraWorldPosition;
			gSLocation2.Z = 0f;
			GSLocation gSLocation3 = base.CameraState.Rt_ControllerRotation.Vector();
			gSLocation3.Z = 0f;
			if (GSLocation.DotProduct(gSLocation3, gSLocation2) < 0f)
			{
				flag = true;
			}
			if (flag)
			{
				GSLocation gSLocation4 = base.CameraState.TargetRootPos - base.CameraState.PlayerRootPos;
				A += gSLocation4.GetSafeNormal2D() * 2f * gSLocation4.Size2D();
				num2 += gSLocation4.Size2D() * 2f;
			}
		}
		float num4 = FMath.Abs(base.CameraState.TargetSoulFocusPos.Z - base.CameraState.PlayerRootPos.Z);
		base.MonitorData.StraightHeightDistance = num4;
		straightParams.TargetRef_Threshold_Before = A2.ToVector();
		straightParams.TargetRef_Threshold_Input_CamRefType = base.CameraState.CamRefType;
		straightParams.TargetRef_Threshold_Input_StraightHeightThreshold = base.CameraState.StraightHeightThreshold;
		straightParams.TargetRef_Threshold_Input_SoulFocusPos = base.CameraState.TargetSoulFocusPos.ToVector();
		straightParams.TargetRef_Threshold_Procedure_HeightDistance = num4;
		straightParams.CameraRef_CalcWithRefType_Before = A3.ToVector();
		straightParams.CameraRef_CalcWithRefType_Input_CamRefType = base.CameraState.CamRefType;
		straightParams.CameraRef_HeightScale_Input_CamRefType = base.CameraState.CamRefType;
		straightParams.CameraRef_HeightScale_Input_StraightHeightScaleFactor = base.CameraState.StraightHeightScaleFactor;
		straightParams.CameraRef_HeightScale_Input_StraightClosestDist = base.CameraState.StraightClosestDist;
		straightParams.CameraRef_HeightScale_Input_StraightHeightScaleFurthestDist = base.CameraState.StraightHeightScaleFurthestDist;
		straightParams.CameraRef_HeightScale_Procedure_HeightScale = x;
		straightParams.CameraRef_HeightScale_Procedure_P2TDistance = num;
		GSLocation gSLocation5 = GSLocationPool.New();
		gSLocation5 = base.CameraState.TargetSoulFocusPos;
		switch (base.CameraState.CamRefType)
		{
		case ECamRefType.None:
		case ECamRefType.BigSize:
			if (num4 <= base.CameraState.StraightHeightThreshold)
			{
				gSLocation5.Z = base.CameraState.TargetRootPos.Z;
			}
			A2 += gSLocation5;
			straightParams.TargetRef_Threshold_After = A2.ToVector();
			A2 = SlowTraceTargetRefPos(A2, A);
			straightParams.CameraRef_CalcWithRefType_Procedure_TargetRef = A2.ToVector();
			A3 = (A2 + A) * 0.5f;
			straightParams.CameraRef_CalcWithRefType_After = A3.ToVector();
			straightParams.CameraRef_HeightScale_Before = A3.ToVector();
			A3 += GSLocation.UpVector * x;
			break;
		case ECamRefType.MiddlePoint:
			if (num4 <= base.CameraState.StraightHeightThreshold)
			{
				gSLocation5.Z = base.CameraState.TargetRootPos.Z;
				gSLocation5 += GSLocation.UpVector * base.CameraState.StraightHeightThreshold;
			}
			A2 += gSLocation5;
			straightParams.TargetRef_Threshold_After = A2.ToVector();
			A2 = SlowTraceTargetRefPos(A2, A);
			straightParams.CameraRef_CalcWithRefType_Procedure_TargetRef = A2.ToVector();
			A3 = (A2 + A) * 0.5f;
			straightParams.CameraRef_CalcWithRefType_After = A3.ToVector();
			straightParams.CameraRef_HeightScale_Before = A3.ToVector();
			A3 += GSLocation.UpVector * x;
			break;
		case ECamRefType.BothSide:
			if (num4 <= base.CameraState.StraightHeightThreshold)
			{
				gSLocation5.Z = base.CameraState.TargetRootPos.Z;
				gSLocation5 += GSLocation.UpVector * base.CameraState.StraightHeightThreshold;
			}
			A2 += gSLocation5;
			straightParams.TargetRef_Threshold_After = A2.ToVector();
			A2 = SlowTraceTargetRefPos(A2, A);
			straightParams.CameraRef_CalcWithRefType_Procedure_TargetRef = A2.ToVector();
			A3 = A2;
			straightParams.CameraRef_CalcWithRefType_After = A3.ToVector();
			straightParams.CameraRef_HeightScale_Before = A3.ToVector();
			break;
		}
		straightParams.CameraRef_CalcWithRefType_Procedure_PlayerRef = A.ToVector();
		straightParams.CameraRef_HeightScale_After = A3.ToVector();
		base.MonitorData.StraightPlayerRefPos.SetValue(A);
		base.MonitorData.StraightTargetRefPos.SetValue(A2);
		base.MonitorData.StraightCameraRefPos.SetValue(A3);
		straightParams.TargetRef_CurrentValue = A2.ToVector();
		straightParams.CameraRef_CurrentValue = A3.ToVector();
		straightParams.CameraRotation_MakeRotFromX_Before = base.CameraState.Rt_CameraRotation.ToRotator();
		straightParams.CameraRotation_MakeRotFromX_Input_CameraRefPos = A3.ToVector();
		straightParams.CameraRotation_MakeRotFromX_Input_PlayerRefPos = A.ToVector();
		FRotator fRotator = MathLib.MakeRotFromX((A3 - A).ToVector());
		controllerRotation.Yaw = fRotator.Yaw;
		base.MonitorData.StraightOriginControllerRotation.SetValue(fRotator);
		straightParams.CameraRotation_MakeRotFromX_After = fRotator;
		straightParams.CameraRotation_Clamp_Before = fRotator;
		straightParams.CameraRotation_Clamp_Input_StraightMinPitch = base.CameraState.StraightMinPitch;
		straightParams.CameraRotation_Clamp_Input_StraightMaxPitch = base.CameraState.StraightMaxPitch;
		controllerRotation.Pitch = MathLib.Clamp(fRotator.Pitch, base.CameraState.StraightMinPitch, base.CameraState.StraightMaxPitch);
		straightParams.CameraRotation_Clamp_After = controllerRotation.ToRotator();
		SlowTraceControllerRotation(controllerRotation);
		straightParams.CameraRotation_CurrentValue = base.CameraControlData.ControllerRotation.ToRotator();
		base.CameraControlData.ViewPitchMin = base.CameraState.StraightMinPitch;
		base.CameraControlData.ViewPitchMax = base.CameraState.StraightMaxPitch;
		float num5;
		if (base.CameraState.Has232Buff)
		{
			num5 = GetDefaultArmLength();
		}
		else
		{
			num5 = base.CameraState.StraightArmLengthDefault;
			switch (base.CameraState.LockCameraArmMode)
			{
			case EDefaultCamArmMode.Close:
				num5 = base.CameraState.StraightArmLengthClose;
				break;
			case EDefaultCamArmMode.Normal:
				num5 = base.CameraState.StraightArmLengthMid;
				break;
			case EDefaultCamArmMode.Far:
				num5 = base.CameraState.StraightArmLengthFar;
				break;
			}
		}
		base.CameraControlData.Target_ArmLength = num5 + num2;
		base.CameraControlData.ArmLength = MathLib.FInterpTo(base.CameraState.Rt_ArmLength, base.CameraControlData.Target_ArmLength, base.DeltaTime, base.CameraState.StraightArmLengthSpeed);
		if (base.CameraState.StraightFovOffsetCurve.IsValid())
		{
			base.CameraState.StraightFovOffset = base.CameraState.StraightFovOffsetCurve.Get().GetFloatValue(num);
		}
	}

	private void SlowTraceControllerRotation(GSRotation InTargetRotation)
	{
		FStraightParams straightParams = base.MonitorData.StraightParams;
		straightParams.CameraRotation_SlowTrace_Before = InTargetRotation.ToRotator();
		straightParams.CameraRotation_SlowTrace_Input_StraightTraceSolution = base.CameraState.StraightTraceSolution;
		straightParams.CameraRotation_SlowTrace_Input_StraightSlowTraceTargetRefMaxYaw = base.CameraState.StraightSlowTraceTargetRefMaxYaw;
		straightParams.CameraRotation_SlowTrace_Input_StraightYawTraceSpeed = base.CameraState.StraightYawTraceSpeed;
		straightParams.CameraRotation_SlowTrace_Input_StraightPitchTraceSpeed = base.CameraState.StraightPitchTraceSpeed;
		float yaw = InTargetRotation.Yaw;
		float num = FMath.ClampAngle(InTargetRotation.Pitch, base.CameraState.StraightMinPitch, base.CameraState.StraightMaxPitch);
		float yaw2 = base.CameraState.Rt_ControllerRotation.Yaw;
		float pitch = base.CameraState.Rt_ControllerRotation.Pitch;
		float inYaw = yaw;
		float inPitch = num;
		if (base.CameraState.StraightTraceSolution == ESlowTraceSolution.Angle)
		{
			if (base.CameraState.StraightTraceSpeedCurve.IsValid())
			{
				float value = FRotator.NormalizeAxis(yaw - yaw2);
				if (FMath.Abs(value) < 0.0001f)
				{
					inYaw = yaw;
				}
				else
				{
					float num2 = FMath.Abs(base.CameraState.StraightTraceSpeedCurve.Get().GetVectorValue(FMath.Abs(value)).X);
					inYaw = ((!((double)num2 < 0.01)) ? MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in InTargetRotation, base.DeltaTime, num2).Yaw : yaw2);
				}
				value = FRotator.NormalizeAxis(num - pitch);
				if (FMath.Abs(value) < 0.0001f)
				{
					inPitch = num;
				}
				else
				{
					float num3 = FMath.Abs(base.CameraState.StraightTraceSpeedCurve.Get().GetVectorValue(FMath.Abs(value)).Y);
					inPitch = ((!((double)num3 < 0.01)) ? MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in InTargetRotation, base.DeltaTime, num3).Pitch : pitch);
				}
			}
		}
		else
		{
			inYaw = MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in InTargetRotation, base.DeltaTime, base.CameraState.StraightYawTraceSpeed).Yaw;
			inPitch = MathLib.RInterpTo(base.CameraState.Rt_ControllerRotation, in InTargetRotation, base.DeltaTime, base.CameraState.StraightPitchTraceSpeed).Pitch;
		}
		base.CameraControlData.ControllerRotation.SetValue(inPitch, inYaw, 0f);
		straightParams.CameraRotation_SlowTrace_After = base.CameraControlData.ControllerRotation.ToRotator();
	}

	private void BlendG4LockCamera()
	{
		GSLocation A = base.CameraState.PlayerPos - base.CameraState.TargetRootPos;
		GSLocation B = A.Rotation().Add(0f, 90f, 0f).Vector() * base.CameraControlData.ArmSocketOffset.Y;
		B.Z = 0f;
		A += B;
		float num = A.Size2D();
		GSLocation B2 = GSLocationPool.New();
		float num2 = 0f;
		UCurveVector uCurveVector = base.CameraState.StraightOffsetCurve.Get();
		if (uCurveVector != null)
		{
			FVector vectorValue = uCurveVector.GetVectorValue(num);
			num2 = vectorValue.X;
			B2 = A.Rotation().Add(0f, 90f, 0f).Vector() * vectorValue.Y;
			B2.Z = vectorValue.Z;
		}
		GSRotation controllerRotation = base.CameraControlData.ControllerRotation;
		GSLocation Target = GSLocationPool.New();
		if (base.CameraBlendCache.bRefPosUninitialized || base.CameraState.bResetStraightPlayerRefCache)
		{
			base.CameraState.bResetStraightPlayerRefCache = false;
			base.CameraBlendCache.bRefPosUninitialized = false;
			Target.SetValue(0f, 0f, base.CameraState.StraightPlayerRefHeightOffset);
			base.CameraBlendCache.CurPlayerRefPos.SetValue(Target);
			Target.Z = base.CameraState.StraightTargetRefHeightOffset;
			base.CameraBlendCache.CurTargetRefPos.SetValue(Target);
		}
		else
		{
			Target.SetValue(0f, 0f, base.CameraState.StraightPlayerRefHeightOffset);
			base.CameraBlendCache.CurPlayerRefPos.SetValue(MathLib.VInterpConstantTo(base.CameraBlendCache.CurPlayerRefPos, in Target, base.DeltaTime, base.CameraState.StraightPlayerRefHeightOffsetSpeed));
			Target.Z = base.CameraState.StraightTargetRefHeightOffset;
			base.CameraBlendCache.CurTargetRefPos.SetValue(MathLib.VInterpConstantTo(base.CameraBlendCache.CurTargetRefPos, in Target, base.DeltaTime, base.CameraState.StraightTargetRefHeightOffsetSpeed));
		}
		GSLocation B3 = base.CameraState.PlayerPos + base.CameraBlendCache.CurPlayerRefPos - B;
		GSLocation A2 = base.CameraBlendCache.CurTargetRefPos + B2;
		GSLocation gSLocation = GSLocationPool.New();
		float straightHeightScaleFactor = base.CameraState.StraightHeightScaleFactor;
		float straightClosestDist = base.CameraState.StraightClosestDist;
		float straightHeightScaleFurthestDist = base.CameraState.StraightHeightScaleFurthestDist;
		float alpha = (num - straightClosestDist) / (straightHeightScaleFurthestDist - straightClosestDist);
		float x = MathLib.Lerp(0f, straightHeightScaleFactor, alpha);
		x = ((!(straightHeightScaleFactor > 0f)) ? MathLib.Clamp(x, straightHeightScaleFactor, 0f) : MathLib.Clamp(x, 0f, straightHeightScaleFactor));
		float num3 = FMath.Abs(base.CameraState.TargetSoulFocusPos.Z - base.CameraState.PlayerPos.Z);
		GSLocation gSLocation2 = GSLocationPool.New();
		gSLocation2 = base.CameraState.TargetSoulFocusPos;
		if (num3 <= base.CameraState.StraightHeightThreshold)
		{
			gSLocation2.Z = base.CameraState.TargetRootPos.Z;
			gSLocation2 += GSLocation.UpVector * base.CameraState.StraightHeightThreshold;
		}
		A2 += gSLocation2;
		A2 = SlowTraceTargetRefPos(A2, B3);
		gSLocation = (A2 + B3) * 0.5f + GSLocation.UpVector * x;
		base.MonitorData.StraightPlayerRefPos.SetValue(B3);
		base.MonitorData.StraightTargetRefPos.SetValue(A2);
		base.MonitorData.StraightCameraRefPos.SetValue(gSLocation);
		FRotator fRotator = MathLib.MakeRotFromX((gSLocation - B3 - base.CameraControlData.ArmSocketOffset).ToVector());
		controllerRotation.Yaw = fRotator.Yaw;
		controllerRotation.Pitch = MathLib.Clamp(fRotator.Pitch, base.CameraState.StraightMinPitch, base.CameraState.StraightMaxPitch);
		SlowTraceControllerRotation(controllerRotation);
		base.CameraControlData.ViewPitchMin = base.CameraState.StraightMinPitch;
		base.CameraControlData.ViewPitchMax = base.CameraState.StraightMaxPitch;
		float num4;
		if (base.CameraState.Has232Buff)
		{
			num4 = GetDefaultArmLength();
		}
		else
		{
			num4 = base.CameraState.StraightArmLengthDefault;
			switch (base.CameraState.LockCameraArmMode)
			{
			case EDefaultCamArmMode.Close:
				num4 = base.CameraState.StraightArmLengthClose;
				break;
			case EDefaultCamArmMode.Normal:
				num4 = base.CameraState.StraightArmLengthMid;
				break;
			case EDefaultCamArmMode.Far:
				num4 = base.CameraState.StraightArmLengthFar;
				break;
			}
		}
		base.CameraControlData.Target_ArmLength = num4 + num2;
		base.CameraControlData.ArmLength = MathLib.FInterpTo(base.CameraState.Rt_ArmLength, base.CameraControlData.Target_ArmLength, base.DeltaTime, base.CameraState.StraightArmLengthSpeed);
		if (base.CameraState.StraightFovOffsetCurve.IsValid())
		{
			base.CameraState.StraightFovOffset = base.CameraState.StraightFovOffsetCurve.Get().GetFloatValue(num);
		}
	}

	private void BlendDiagonalLockCamera()
	{
		float num = GSLocation.Dist2D(base.CameraState.PlayerPos, base.CameraState.TargetPos);
		float num2 = base.CameraState.TargetSoulFocusPos.Z - base.CameraState.PlayerPelvisPos.Z;
		base.CameraState.DmcP2TDistance = num;
		base.CameraState.DmcP2THeightDistance = num2;
		float num3 = base.CameraState.Diagonal_RefOffsetBase - base.CameraState.Diagonal_RefOffsetDistance / num * base.CameraState.Diagonal_RefOffsetBase;
		base.CameraState.DmcRefOffset = num3;
		num3 = MathLib.Clamp(num3, 30f, 100f);
		base.CameraState.DmcRefOffsetClamped = num3;
		GSLocation gSLocation = null;
		GSLocation gSLocation2 = null;
		if (FMath.Abs(num2) > 300f)
		{
			gSLocation2 = base.CameraState.PlayerPelvisPos + GSLocation.UpVector * (base.CameraState.Diagonal_PlayerRefOffset + num3);
			gSLocation = base.CameraState.TargetSoulFocusPos + GSLocation.UpVector * (base.CameraState.Diagonal_TargetRefOffset + num3);
		}
		else
		{
			gSLocation2 = base.CameraState.PlayerPos + GSLocation.UpVector * (base.CameraState.Diagonal_PlayerRefOffset + num3);
			gSLocation = base.CameraState.TargetPos + GSLocation.UpVector * (base.CameraState.Diagonal_TargetRefOffset + num3);
		}
		base.CameraState.DmcPlayerRef.SetValue(gSLocation2);
		base.CameraState.DmcTargetRef.SetValue(gSLocation);
		GSLocation gSLocation3 = gSLocation - gSLocation2;
		GSLocation Target = gSLocation2 + gSLocation3 * base.CameraState.Diagonal_P2TRatio;
		GSLocation value = (base.CameraState.bDiagonalIgnoreLerp ? Target : MathLib.VInterpConstantTo(base.CameraState.Rt_DmcActorLocation, in Target, base.DeltaTime, base.CameraState.Diagonal_PosLerpSpeed));
		base.CameraControlData.DmcActorLocation.SetValue(value);
		GSLocation safeNormal2D = gSLocation3.GetSafeNormal2D(0.0001f);
		GSLocation safeNormal2D2 = base.CameraState.Rt_DmcActorForwardVector.GetSafeNormal2D(0.0001f);
		float num4 = GSLocation.DotProduct(safeNormal2D, safeNormal2D2);
		float angleDeg = ((!(GSLocation.CrossProduct(safeNormal2D, safeNormal2D2).Z > 0f)) ? (0f - base.CameraState.Diagonal_AngleOffset) : base.CameraState.Diagonal_AngleOffset);
		GSRotation Target2 = gSLocation3.RotateAngleAxis(angleDeg, GSLocation.UpVector).Rotation();
		float pitch = base.CameraState.Diagonal_PitchBase - FMath.Clamp(num / base.CameraState.Diagonal_PitchFadeDistance, 0f, 1f) * 2f;
		if (FMath.Abs(num2) > 300f)
		{
			pitch = MathLib.MakeRotFromX((gSLocation - Target).ToVector()).Pitch;
			pitch = FMath.Clamp(pitch, -80f, base.CameraState.Diagonal_PitchBase);
		}
		Target2.Pitch = pitch;
		float num5 = base.CameraState.Diagonal_RotLerpSpeedLow;
		if (num4 * 100f < 70f)
		{
			num5 = base.CameraState.Diagonal_RotLerpSpeedHigh;
		}
		base.CameraState.DmcRotationLerpSpeed = num5;
		GSRotation value2 = (base.CameraState.bDiagonalIgnoreLerp ? Target2 : MathLib.RInterpTo(base.CameraState.Rt_DmcActorRotation, in Target2, base.DeltaTime, num5));
		base.CameraControlData.DmcActorRotation.SetValue(value2);
		float x = base.CameraState.Diagonal_ArmLengthMin + num / base.CameraState.Diagonal_ArmLengthMax * base.CameraState.Diagonal_ArmLengthChangeValue;
		x = MathLib.Clamp(x, base.CameraState.Diagonal_ArmLengthMin, base.CameraState.Diagonal_ArmLengthMax);
		base.CameraControlData.DmcArmLength = (base.CameraState.bDiagonalIgnoreLerp ? x : MathLib.FInterpConstantTo(base.CameraState.Rt_DmcArmLength, in x, base.DeltaTime, base.CameraState.Diagonal_ArmLengthLerpSpeed));
	}

	private FVector SlowTraceTargetRefPosV2(FVector LastTargetRefPos, FVector InTargetRefPos, FVector InPlayerRefPos)
	{
		if (base.CameraState.StraightTraceSolution == ESlowTraceSolution.Angle)
		{
			return SlowTraceRefPosByAngleV2(LastTargetRefPos, InTargetRefPos, InPlayerRefPos);
		}
		return SlowTraceTargetRefPosByDistanceV2(LastTargetRefPos, InTargetRefPos, InPlayerRefPos);
	}

	private FVector SlowTraceTargetRefPosByDistanceV2(FVector LastTargetRefPos, FVector InTargetRefPos, FVector InPlayerRefPos)
	{
		if (GSLocation.DotProduct(base.CameraState.PlayerRootPos - base.CameraState.TargetRootPos, InPlayerRefPos - LastTargetRefPos) < 0f)
		{
			return InTargetRefPos;
		}
		if ((LastTargetRefPos - InTargetRefPos).Size2D() > base.CameraState.StraightMaxTraceTargetRefDist)
		{
			return InTargetRefPos;
		}
		return MathLib.VSubStepInterpTo(LastTargetRefPos, InTargetRefPos, base.DeltaTime, base.CameraState.StraightTraceTargetRefSpeed);
	}

	private FVector SlowTraceRefPosByAngleV2(FVector LastTargetRefPos, FVector InTargetRefPos, FVector InPlayerRefPos)
	{
		if (((base.CameraState.PlayerRootPos - base.CameraState.TargetRootPos).ToVector() | (InPlayerRefPos - LastTargetRefPos)) < 0f)
		{
			return InTargetRefPos;
		}
		float num = MathLib.DegAcos((LastTargetRefPos - InPlayerRefPos).GetSafeNormal2D() | (InTargetRefPos - InPlayerRefPos).GetSafeNormal2D());
		if (num > base.CameraState.StraightSlowTraceTargetRefMaxYaw)
		{
			return InTargetRefPos;
		}
		if (base.CameraState.StraightTraceSpeedCurve.IsValid())
		{
			float z = base.CameraState.StraightTraceSpeedCurve.Get().GetVectorValue(num).Z;
			float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, num), new FVector2D(0.0, (InTargetRefPos - LastTargetRefPos).Size2D()), base.DeltaTime * z);
			return LastTargetRefPos + (InTargetRefPos - LastTargetRefPos).GetSafeNormal2D() * mappedRangeValueClamped;
		}
		return InTargetRefPos;
	}

	private void BlendStraightLockCameraV2()
	{
		float num = (base.CameraState.PlayerRootPos - base.CameraState.TargetSoulFocusPos).Size2D();
		base.MonitorData.StraightP2TDistance = num;
		FVector zeroVector = FVector.ZeroVector;
		float num2 = 0f;
		UCurveVector uCurveVector = base.CameraState.StraightOffsetCurve.Get();
		if (uCurveVector != null)
		{
			FVector vectorValue = uCurveVector.GetVectorValue(num);
			num2 = vectorValue.X;
			base.CameraControlData.ArmLocation.Z = MathLib.FInterpTo(base.CameraState.Rt_ArmLocation.Z, base.CameraState.DefaultArmLocation.Z + vectorValue.Y, base.DeltaTime, base.CameraState.DefaultArmLocationLerpSpeed);
			zeroVector.Z = vectorValue.Z;
			base.MonitorData.StraightOffsetCurveValue.SetValue(vectorValue);
		}
		else
		{
			base.MonitorData.StraightOffsetCurveValue.SetValue(0f);
		}
		float straightHeightScaleFactor = base.CameraState.StraightHeightScaleFactor;
		float straightClosestDist = base.CameraState.StraightClosestDist;
		float straightHeightScaleFurthestDist = base.CameraState.StraightHeightScaleFurthestDist;
		float alpha = (num - straightClosestDist) / (straightHeightScaleFurthestDist - straightClosestDist);
		float x = MathLib.Lerp(0f, straightHeightScaleFactor, alpha);
		x = ((!(straightHeightScaleFactor > 0f)) ? MathLib.Clamp(x, straightHeightScaleFactor, 0f) : MathLib.Clamp(x, 0f, straightHeightScaleFactor));
		float num3 = FMath.Abs(base.CameraState.TargetSoulFocusPos.Z - base.CameraState.PlayerRootPos.Z);
		base.MonitorData.StraightHeightDistance = num3;
		FVector fVector = base.CameraState.TargetSoulFocusPos.ToVector();
		ECamRefType camRefType = base.CameraState.CamRefType;
		if (camRefType > ECamRefType.MiddlePoint && camRefType == ECamRefType.BigSize)
		{
			if (num3 <= base.CameraState.StraightHeightThreshold)
			{
				fVector.Z = base.CameraState.TargetRootPos.Z;
			}
		}
		else if (num3 <= base.CameraState.StraightHeightThreshold)
		{
			fVector.Z = base.CameraState.TargetRootPos.Z;
			fVector += FVector.UpVector * base.CameraState.StraightHeightThreshold;
		}
		FVector zeroVector2 = FVector.ZeroVector;
		if (base.CameraBlendCache.bRefPosUninitialized || base.CameraState.bResetStraightPlayerRefCache)
		{
			zeroVector2.Z = base.CameraState.StraightTargetRefHeightOffset;
			base.CameraBlendCache.CurTargetRefPos.SetValue(zeroVector2);
		}
		else
		{
			zeroVector2.Z = base.CameraState.StraightTargetRefHeightOffset;
			base.CameraBlendCache.CurTargetRefPos.SetValue(MathLib.VSubStepInterpTo(base.CameraBlendCache.CurTargetRefPos.ToVector(), zeroVector2, base.DeltaTime, base.CameraState.StraightTargetRefHeightOffsetSpeed));
		}
		FVector fVector2 = base.CameraBlendCache.CurTargetRefPos.ToVector() + zeroVector;
		fVector2 += fVector;
		if (base.CameraBlendCache.bRefPosUninitialized || base.CameraState.bResetStraightPlayerRefCache)
		{
			zeroVector2.Z = base.CameraState.StraightTargetRefHeightOffset;
			FVector safeNormal2D = base.CameraState.Rt_CameraWorldRotation.ToRotator().Vector().GetSafeNormal2D();
			base.CameraBlendCache.LastTargetRefPos.SetValue(((fVector2 - base.CameraState.PlayerPos.ToVector()) | safeNormal2D) * safeNormal2D + base.CameraState.PlayerPos);
		}
		FVector fVector3 = base.CameraState.PlayerRefBase.ToVector();
		FVector fVector4 = FVector.ZeroVector;
		FVector fVector6;
		if (base.CameraBlendCache.bRefPosUninitialized || base.CameraState.bResetStraightPlayerRefCache)
		{
			zeroVector2.Z = base.CameraState.StraightPlayerRefHeightOffset;
			base.CameraBlendCache.CurPlayerRefPos.SetValue(zeroVector2);
			FVector fVector5 = base.CameraState.Rt_PreviousDesiredLoc - base.CameraState.Rt_PreviousArmOrigin + base.CameraState.Rt_ArmTargetOffset;
			base.CameraControlData.ArmTargetOffset = fVector5;
			base.CameraBlendCache.LastPlayerRefPos.SetValue(fVector3 + zeroVector2);
			base.CameraBlendCache.LastPlayerPos = base.CameraState.PlayerPos.ToVector();
			fVector6 = fVector3 + fVector5 + base.CameraBlendCache.CurPlayerRefPos.ToVector();
		}
		else
		{
			FVector fVector7 = base.CameraBlendCache.CurPlayerRefPos.ToVector();
			zeroVector2.Z = base.CameraState.StraightPlayerRefHeightOffset;
			base.CameraBlendCache.CurPlayerRefPos.SetValue(MathLib.VSubStepInterpTo(base.CameraBlendCache.CurPlayerRefPos.ToVector(), zeroVector2, base.DeltaTime, base.CameraState.StraightPlayerRefHeightOffsetSpeed));
			FVector target = fVector3;
			FVector current = base.CameraBlendCache.LastPlayerRefPos.ToVector() - fVector7;
			FVector interpSpeed = base.CameraState.DefaultInverseOffsetSpeed.ToVector();
			if ((base.CameraBlendCache.LastPlayerPos - base.CameraState.PlayerPos.ToVector()).Size() < 10f)
			{
				interpSpeed = base.CameraState.DefaultInverseOffsetResetSpeed.ToVector();
			}
			target = MathLib.VSubStepInterpTo(current, target, base.DeltaTime, interpSpeed);
			FVector fVector8 = target - fVector3;
			FVector safeNormal2D2 = (fVector2 - fVector3).GetSafeNormal2D();
			FVector fVector9 = safeNormal2D2.RotateAngleAxis(-90.0, FVector.UpVector);
			FVector fVector10 = -safeNormal2D2 ^ fVector9;
			float num4 = fVector8 | safeNormal2D2;
			if (base.CameraState.Rt_CameraLagMaxDistance.X > 0f && FMath.Square(num4) > FMath.Square(base.CameraState.Rt_CameraLagMaxDistance.X))
			{
				fVector4.X = num4;
				num4 = FMath.Min(base.CameraState.Rt_CameraLagMaxDistance.X, FMath.Abs(num4)) * (num4 / FMath.Abs(num4));
				fVector4.X -= num4;
			}
			float num5 = fVector8 | fVector9;
			if (base.CameraState.Rt_CameraLagMaxDistance.Y > 0f && FMath.Square(num5) > FMath.Square(base.CameraState.Rt_CameraLagMaxDistance.Y))
			{
				fVector4.Y = num5;
				num5 = FMath.Min(base.CameraState.Rt_CameraLagMaxDistance.Y, FMath.Abs(num5)) * (num5 / FMath.Abs(num5));
				fVector4.Y -= num5;
			}
			float num6 = fVector8 | fVector10;
			if (base.CameraState.Rt_CameraLagMaxDistance.Z > 0f && FMath.Square(num6) > FMath.Square(base.CameraState.Rt_CameraLagMaxDistance.Z))
			{
				fVector4.Z = num6;
				num6 = FMath.Min(base.CameraState.Rt_CameraLagMaxDistance.Z, FMath.Abs(num6)) * (num6 / FMath.Abs(num6));
				fVector4.Z -= num6;
			}
			fVector8 = num4 * safeNormal2D2 + num5 * fVector9 + num6 * fVector10;
			fVector4 = fVector4.X * safeNormal2D2 + fVector4.Y * fVector9 + fVector4.Z * fVector10;
			target = fVector3 + fVector8;
			base.CameraControlData.ArmTargetOffset = fVector8;
			fVector6 = target + base.CameraBlendCache.CurPlayerRefPos.ToVector();
		}
		FVector fVector11 = base.CameraState.Rt_ControllerRotation.ToRotator().Vector();
		float num7 = (fVector2 - fVector6).Size2D();
		FVector fVector12 = fVector6 + fVector11.GetSafeNormal2D() * num7;
		fVector12.Z = fVector2.Z;
		fVector12 = base.CameraBlendCache.LastTargetRefPos.ToVector();
		fVector2 += fVector4 * 2.0;
		fVector2 = SlowTraceTargetRefPosV2(fVector12, fVector2, fVector6);
		FVector fVector13;
		switch (base.CameraState.CamRefType)
		{
		case ECamRefType.None:
		case ECamRefType.BothSide:
			fVector13 = fVector2;
			break;
		default:
			fVector13 = (fVector2 + fVector6) * 0.5;
			fVector13 += FVector.UpVector * x;
			break;
		}
		if (!base.CameraBlendCache.bRefPosUninitialized && !base.CameraState.bResetStraightPlayerRefCache)
		{
			FRotator fRotator = base.CameraControlData.ControllerRotation.ToRotator();
			FRotator fRotator2 = MathLib.MakeRotFromX(fVector13 - fVector6);
			fRotator.Yaw = fRotator2.Yaw;
			fRotator.Pitch = MathLib.Clamp(fRotator2.Pitch, base.CameraState.StraightMinPitch, base.CameraState.StraightMaxPitch);
			base.MonitorData.StraightOriginControllerRotation.SetValue(fRotator);
			SlowTraceControllerRotationV2(fRotator);
		}
		base.CameraBlendCache.LastTargetRefPos.SetValue(fVector2);
		base.CameraBlendCache.LastPlayerRefPos.SetValue(fVector6);
		base.CameraBlendCache.LastCameraRefPos.SetValue(fVector13);
		if (base.CameraBlendCache.bRefPosUninitialized || base.CameraState.bResetStraightPlayerRefCache)
		{
			base.CameraState.bResetStraightPlayerRefCache = false;
			base.CameraBlendCache.bRefPosUninitialized = false;
		}
		base.MonitorData.StraightTargetRefPos.SetValue(fVector2);
		base.MonitorData.StraightPlayerRefPos.SetValue(fVector6);
		base.MonitorData.StraightCameraRefPos.SetValue(fVector13);
		float num8;
		if (base.CameraState.Has232Buff)
		{
			num8 = GetDefaultArmLength();
		}
		else
		{
			num8 = base.CameraState.StraightArmLengthDefault;
			switch (base.CameraState.LockCameraArmMode)
			{
			case EDefaultCamArmMode.Close:
				num8 = base.CameraState.StraightArmLengthClose;
				break;
			case EDefaultCamArmMode.Normal:
				num8 = base.CameraState.StraightArmLengthMid;
				break;
			case EDefaultCamArmMode.Far:
				num8 = base.CameraState.StraightArmLengthFar;
				break;
			}
		}
		base.CameraControlData.Target_ArmLength = num8 + num2;
		base.CameraControlData.ArmLength = MathLib.FInterpTo(base.CameraState.Rt_ArmLength, base.CameraControlData.Target_ArmLength, base.DeltaTime, base.CameraState.StraightArmLengthSpeed);
		if (base.CameraState.StraightFovOffsetCurve.IsValid())
		{
			base.CameraState.StraightFovOffset = base.CameraState.StraightFovOffsetCurve.Get().GetFloatValue(num);
		}
		base.CameraBlendCache.LastPlayerPos = base.CameraState.PlayerPos.ToVector();
	}

	private void SlowTraceControllerRotationV2(FRotator InTargetRotation)
	{
		float yaw = InTargetRotation.Yaw;
		float num = FMath.ClampAngle(InTargetRotation.Pitch, base.CameraState.StraightMinPitch, base.CameraState.StraightMaxPitch);
		float yaw2 = base.CameraState.Rt_ControllerRotation.Yaw;
		float pitch = base.CameraState.Rt_ControllerRotation.Pitch;
		FRotator current = base.CameraState.Rt_ControllerRotation.ToRotator();
		float inYaw = yaw;
		float inPitch = num;
		if (base.CameraState.StraightTraceSolution == ESlowTraceSolution.Angle)
		{
			if (base.CameraState.StraightTraceSpeedCurve.IsValid())
			{
				float value = FRotator.NormalizeAxis(yaw - yaw2);
				if (FMath.Abs(value) < 0.0001f)
				{
					inYaw = yaw;
				}
				else
				{
					float num2 = FMath.Abs(base.CameraState.StraightTraceSpeedCurve.Get().GetVectorValue(FMath.Abs(value)).X);
					inYaw = ((!((double)num2 < 0.01)) ? FMath.RInterpTo(current, InTargetRotation, base.DeltaTime, num2).Yaw : yaw2);
				}
				value = FRotator.NormalizeAxis(num - pitch);
				if (FMath.Abs(value) < 0.0001f)
				{
					inPitch = num;
				}
				else
				{
					float num3 = FMath.Abs(base.CameraState.StraightTraceSpeedCurve.Get().GetVectorValue(FMath.Abs(value)).Y);
					inPitch = ((!((double)num3 < 0.01)) ? FMath.RInterpTo(current, InTargetRotation, base.DeltaTime, num3).Pitch : pitch);
				}
			}
		}
		else
		{
			inYaw = MathLib.RSubStepInterpTo(current, InTargetRotation, base.DeltaTime, base.CameraState.StraightYawTraceSpeed).Yaw;
			inPitch = MathLib.RSubStepInterpTo(current, InTargetRotation, base.DeltaTime, base.CameraState.StraightPitchTraceSpeed).Pitch;
		}
		base.CameraControlData.ControllerRotation.SetValue(inPitch, inYaw, 0f);
	}

	public FCameraBlend_Lock(GSCameraGraph InCameraGraph)
		: base(InCameraGraph)
	{
	}
}
