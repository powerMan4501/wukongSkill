using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPCloudLocomotionData : IBUC_ABPCloudLocomotionData
{
	private IBUC_CloudMoveData CloudMoveData;

	public float InputVelocityAngle { get; set; }

	public bool bPlayStart { get; set; }

	public float StartAngle { get; set; }

	public FRotator PriTargetRotation { get; set; }

	public FRotator SecTargetRotation { get; set; }

	public EGaitGroundedState GaitGroundedState { get; set; }

	public EGaitGroundedState GaitGroundedStateTemp { get; set; }

	public UCurveFloat RotationSpeedCurve { get; set; }

	public float RotationSpeed { get; set; }

	public float MaxAcceleration { get; set; }

	public bool bCloudFall { get; set; }

	public bool bIsCloudFallInLowAirArea { get; set; }

	public int CloudBreakAnimId { get; set; }

	public UAnimSequence AnimCloudFallLoop { get; set; }

	public BUABPJump_LandSettingData CloudLand_Low { get; set; }

	public BUABPJump_LandSettingData CloudLand_High { get; set; }

	public Dictionary<int, FCloudBreakAnimSetting> CloudBreakAnimSettings { get; set; }

	public void Init(BUABPSettingData Setting, IBUC_CloudMoveData CloudMoveData)
	{
		this.CloudMoveData = CloudMoveData;
		RotationSpeedCurve = Setting.CloudLocomotionSetting.RotationSpeedCurve;
		AnimCloudFallLoop = Setting.CloudLocomotionSetting.CloudFallLoop;
		CloudLand_Low = Setting.CloudLocomotionSetting.CloudLand_Low;
		CloudLand_High = Setting.CloudLocomotionSetting.CloudLand_High;
		CloudBreakAnimSettings = Setting.CloudLocomotionSetting.CloudBreakAnimSettings;
		if (CloudMoveData != null)
		{
			bCloudFall = CloudMoveData.bCloudFall;
			bIsCloudFallInLowAirArea = CloudMoveData.bIsCloudFallInLowAirArea;
			CloudBreakAnimId = CloudMoveData.CloudBreakAnimId;
		}
		else
		{
			bCloudFall = false;
			bIsCloudFallInLowAirArea = false;
			CloudBreakAnimId = -1;
		}
	}

	public void Update(IBUC_ABPCommonSettingData CommonData, IBUC_ABPCharacterData ChrData, IBUC_ABPBasicData BasicData)
	{
		if (CloudMoveData != null)
		{
			bCloudFall = CloudMoveData.bCloudFall;
			bIsCloudFallInLowAirArea = CloudMoveData.bIsCloudFallInLowAirArea;
			CloudBreakAnimId = CloudMoveData.CloudBreakAnimId;
		}
		else
		{
			bCloudFall = false;
			bIsCloudFallInLowAirArea = false;
			CloudBreakAnimId = -1;
		}
		if (CommonData.FinalABPMoveMode != EABPMoveMode.CloudLocomotion)
		{
			GaitGroundedState = EGaitGroundedState.None;
			FRotator priTargetRotation = (SecTargetRotation = ChrData.ActorRotation);
			PriTargetRotation = priTargetRotation;
			return;
		}
		bPlayStart = false;
		if (!ChrData.MoveAcceleration.IsNearlyZero())
		{
			InputVelocityAngle = MathLib.NormalizedDeltaRotator(ChrData.MoveAcceleration.Rotation(), ChrData.Velocity.Rotation()).Yaw;
		}
		else
		{
			InputVelocityAngle = 0f;
		}
		UpdateGaitGrounded(BasicData, ChrData);
		FRotator fRotator = ChrData.MoveAcceleration.Rotation();
		fRotator.Pitch = 0f;
		fRotator.Roll = 0f;
		switch (GaitGroundedState)
		{
		case EGaitGroundedState.None:
		case EGaitGroundedState.Idle:
			GaitGroundedStateTemp = GaitGroundedState;
			StartAngle = 0f;
			break;
		case EGaitGroundedState.Walk:
		case EGaitGroundedState.Run:
		case EGaitGroundedState.Rush:
			if (GaitGroundedStateTemp == EGaitGroundedState.None || GaitGroundedStateTemp == EGaitGroundedState.Idle)
			{
				StartAngle = MathLib.NormalizedDeltaRotator(PriTargetRotation, ChrData.ActorRotation).Yaw;
				GaitGroundedStateTemp = GaitGroundedState;
				bPlayStart = true;
			}
			break;
		}
	}

	public FRotator GetRotationTarget(IBUC_ABPCharacterData ChrData, IBUC_ABPBasicData BasicData, float DeltaTime)
	{
		FRotator target = ((ChrData.MoveAcceleration.Size2D() < 1E-08f) ? ChrData.ForwardVector : ChrData.MoveAcceleration).Rotation();
		target.Pitch = 0f;
		target.Roll = 0f;
		float interpSpeed = ((RotationSpeedCurve == null) ? RotationSpeed : RotationSpeedCurve.GetFloatValue(BasicData.GetMappedSpeed()));
		PriTargetRotation = FMath.RInterpConstantTo(PriTargetRotation, target, DeltaTime, 1000f);
		SecTargetRotation = FMath.RInterpTo(SecTargetRotation, PriTargetRotation, DeltaTime, interpSpeed);
		return SecTargetRotation;
	}

	private void UpdateGaitGrounded(IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData)
	{
		if (ChrData.MoveAcceleration.IsNearlyZero())
		{
			if (GaitGroundedState != EGaitGroundedState.Idle)
			{
				GaitGroundedState = EGaitGroundedState.Idle;
			}
			return;
		}
		switch (BasicData.MoveSpeedState)
		{
		case EMoveSpeedLevel.Walk:
			if (GaitGroundedState != EGaitGroundedState.Walk)
			{
				GaitGroundedState = EGaitGroundedState.Walk;
			}
			break;
		case EMoveSpeedLevel.Run:
			if (GaitGroundedState != EGaitGroundedState.Run)
			{
				GaitGroundedState = EGaitGroundedState.Run;
			}
			break;
		case EMoveSpeedLevel.Sprint:
			if (GaitGroundedState != EGaitGroundedState.Rush)
			{
				GaitGroundedState = EGaitGroundedState.Rush;
			}
			break;
		}
	}
}
