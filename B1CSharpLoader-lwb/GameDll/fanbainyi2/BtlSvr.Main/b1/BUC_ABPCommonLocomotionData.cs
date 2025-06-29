using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPCommonLocomotionData : IBUC_ABPCommonLocomotionData
{
	public float LeanAngle { get; set; }

	public float SlopeRightAngle { get; set; }

	public float SlopeForwardAngle { get; set; }

	public float BSStartX { get; set; }

	public float BSStartY { get; set; }

	public float BSStopX { get; set; }

	public float BSStopY { get; set; }

	public float BSStopNoBreakX { get; set; }

	public float BSStopNoBreakY { get; set; }

	public FVector RelativeAcceleration { get; set; }

	public EMoveDirectionFive MoveInputDirectionFive { get; set; }

	public void Init()
	{
	}

	public void Update1(IBUC_ABPBGUCharacterData BGUData, IBUC_ABPCommonSettingData CommonData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (CommonData.FinalABPMoveMode == EABPMoveMode.Locomotion_Simple4Dir)
		{
			BSStartX = BGUData.BSStartMode * 50f;
			BSStartY = 50f;
			switch (BGUData.BSEndMode)
			{
			case 0:
				BSStopX = 0f;
				break;
			case 1:
				BSStopX = 50f;
				break;
			default:
				BSStopX = 100f;
				break;
			}
			BSStopY = 50f;
			BSStopNoBreakX = 100f;
			BSStopNoBreakY = 50f;
		}
	}

	public void Update2(AActor Owner, IBUC_ABPCommonSettingData CommonData, IBUC_ABPCharacterData ChrData)
	{
		if (CommonData.FinalABPMoveMode == EABPMoveMode.PlayerLocomotion || CommonData.FinalABPMoveMode == EABPMoveMode.MonsterLocomotion || CommonData.FinalABPMoveMode == EABPMoveMode.AdvancedMonsterLocomotion || CommonData.FinalABPMoveMode == EABPMoveMode.QuadrupedLocomotion)
		{
			UpdateRelativeAcceleration(Owner, ChrData);
			UpdateInputMoveDirection(Owner, ChrData);
		}
	}

	private void UpdateRelativeAcceleration(AActor Owner, IBUC_ABPCharacterData ChrData)
	{
		float num = ((FVector.DotProduct(ChrData.RealAcceleration, ChrData.Velocity) > 0f) ? ChrData.MovementComp.GetMaxAcceleration() : ChrData.MovementComp.GetMaxBrakingDeceleration());
		if (FMath.Abs(num) > 1E-06f)
		{
			RelativeAcceleration = ChrData.ActorRotation.UnrotateVector(ChrData.RealAcceleration / num);
		}
	}

	private void UpdateInputMoveDirection(AActor Owner, IBUC_ABPCharacterData ChrData)
	{
		float num = FMath.Cos(FMath.DegreesToRadians(45f));
		float num2 = FMath.Cos(FMath.DegreesToRadians(135f));
		float num3 = FMath.Cos(FMath.DegreesToRadians(45f));
		float num4 = FMath.Cos(FMath.DegreesToRadians(135f));
		FVector moveAcceleration = ChrData.MoveAcceleration;
		if (moveAcceleration.Size() == 0f)
		{
			return;
		}
		moveAcceleration.Normalize();
		float num5 = FVector.DotProduct(moveAcceleration, ChrData.ForwardVector);
		float num6 = FVector.DotProduct(moveAcceleration, ChrData.RightVector);
		if (num5 >= num)
		{
			MoveInputDirectionFive = EMoveDirectionFive.F;
		}
		if (num5 <= num2)
		{
			if (FVector.DotProduct(FVector.CrossProduct(ChrData.ForwardVector, moveAcceleration), ChrData.UpVector) <= 0f)
			{
				MoveInputDirectionFive = EMoveDirectionFive.BL;
			}
			else
			{
				MoveInputDirectionFive = EMoveDirectionFive.BR;
			}
		}
		if (num6 > num3)
		{
			MoveInputDirectionFive = EMoveDirectionFive.R;
		}
		if (num6 < num4)
		{
			MoveInputDirectionFive = EMoveDirectionFive.L;
		}
	}
}
