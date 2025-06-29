using System;
using b1.BGU.BUAnim;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPJogData : IBUC_ABPJogData
{
	public bool MoveIsAccelerate { get; set; }

	public ECardinalDir LocomotionCardinalDirection { get; set; }

	public float LocomotionOrientationAngle { get; set; }

	public bool MoveIsDeccelerate { get; set; }

	public bool MoveIsPivot { get; set; }

	public float InputAndVelocityAngleDelta { get; set; }

	private int RotateAlpha(FVector Parent, FVector Input)
	{
		if (Parent.Y * Input.X - Parent.X * Input.Y >= 0f)
		{
			return -1;
		}
		return 1;
	}

	private void UpdateJogPivot(IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData)
	{
		MoveIsPivot = MathLib.Abs(InputAndVelocityAngleDelta) > 100f && BasicData.Speed > 100f && ChrData.MoveAcceleration.Size() > 0.2f * ChrData.MaxAcceleration;
	}

	private void UpdateOrientationAngle(IBUC_ABPCharacterData ChrData)
	{
		FVector parent = default(FVector);
		switch (LocomotionCardinalDirection)
		{
		case ECardinalDir.Default:
			parent = ChrData.ForwardVector;
			break;
		case ECardinalDir.E:
			parent = ChrData.RightVector;
			break;
		case ECardinalDir.S:
			parent = -ChrData.ForwardVector;
			break;
		case ECardinalDir.W:
			parent = -ChrData.RightVector;
			break;
		}
		LocomotionOrientationAngle = FMath.Acos(parent.CosineAngle2D(ChrData.Velocity)) / (float)Math.PI * 180f * (float)RotateAlpha(parent, ChrData.Velocity);
	}

	private void UpdateJogStart(IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData)
	{
		float moveDir = 0f;
		if (ChrData.MoveAcceleration.Size() > 0f)
		{
			moveDir = MathLib.MakeRotFromX(ChrData.MoveAcceleration).Yaw - ChrData.ActorRotation.Yaw;
			moveDir = MathLib.NormalizeAxis(moveDir);
		}
		BUAnimUtil.GetOrientWarpAngle(moveDir, out var _, out var DirEnum);
		if (!MoveIsDeccelerate && !MoveIsPivot)
		{
			LocomotionCardinalDirection = DirEnum;
		}
		MoveIsAccelerate = ChrData.MoveAcceleration.Size() > 0f && ChrData.Velocity.Size() < ChrData.MaxSpeed * 0.9f;
	}

	private void UpdateJogStop(IBUC_ABPCharacterData ChrData)
	{
		MoveIsDeccelerate = ChrData.MoveAcceleration.Size() == 0f && ChrData.Velocity.Size() > 0f;
	}

	public void Update(IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPCommonSettingData CommonData, IBUC_ABPHelperData HelperData, float DeltaTime)
	{
		if (CommonData.FinalABPMoveMode == EABPMoveMode.Locomotion_Simple4Dir)
		{
			UpdateJogPivot(BasicData, ChrData);
			UpdateJogStop(ChrData);
			UpdateJogStart(BasicData, ChrData);
			UpdateOrientationAngle(ChrData);
		}
	}
}
