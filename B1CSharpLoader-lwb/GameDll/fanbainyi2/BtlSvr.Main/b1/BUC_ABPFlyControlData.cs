using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPFlyControlData : IBUC_ABPFlyControlData
{
	private IBUC_SplineFlyMoveData SplineFlyMoveData;

	public float BSFlyX { get; set; }

	public float BSFlyY { get; set; }

	public float BSFlyLeanX { get; set; }

	public float BSFlyLeanY { get; set; }

	public bool bFlyUpward { get; set; }

	public void Init(IBUC_SplineFlyMoveData InSplineFlyMoveData)
	{
		SplineFlyMoveData = InSplineFlyMoveData;
	}

	public void Update(AActor Owner, IBUC_ABPCommonSettingData CommonData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (CommonData.FinalABPMoveMode != EABPMoveMode.SimpleFlyControl && CommonData.FinalABPMoveMode != EABPMoveMode.ComplexFlyControl)
		{
			return;
		}
		if (Owner as ACharacter != null && !ChrData.MoveAcceleration.IsNearlyZero())
		{
			FRotator fRotator = ChrData.ControlRotation - ChrData.ActorRotation;
			float target = FRotator.NormalizeAxis(fRotator.Yaw) / 30f;
			float target2 = FRotator.NormalizeAxis(fRotator.Pitch) / 30f;
			BSFlyX = FMath.FInterpTo(BSFlyX, target, DeltaTime, 5f);
			BSFlyY = FMath.FInterpTo(BSFlyY, target2, DeltaTime, 5f);
		}
		else
		{
			BSFlyX = FMath.FInterpTo(BSFlyX, 0f, DeltaTime, 5f);
			BSFlyY = FMath.FInterpTo(BSFlyY, 0f, DeltaTime, 5f);
		}
		FVector safeNormal = ChrData.Velocity.GetSafeNormal();
		FVector safeNormal2 = ChrData.LastVelocity.GetSafeNormal();
		float target3;
		if (safeNormal == FVector.ZeroVector || safeNormal2 == FVector.ZeroVector)
		{
			target3 = 0f;
		}
		else
		{
			FVector safeNormal3 = FVector.VectorPlaneProject(safeNormal, FVector.UpVector).GetSafeNormal();
			FVector safeNormal4 = FVector.VectorPlaneProject(safeNormal2, FVector.UpVector).GetSafeNormal();
			if (safeNormal3 == FVector.ZeroVector || safeNormal4 == FVector.ZeroVector)
			{
				target3 = 0f;
			}
			else
			{
				float num = MathLib.DegAcos(FVector.DotProduct(safeNormal3, safeNormal4)) / DeltaTime;
				if (FVector.CrossProduct(safeNormal4, safeNormal3).Z < 0f)
				{
					num *= -1f;
				}
				target3 = num / 60f;
			}
		}
		safeNormal = ChrData.RealWorldVelocity.GetSafeNormal();
		float target4;
		if (ChrData.RealWorldVelocity.Size() < 100f)
		{
			target4 = 0f;
		}
		else
		{
			FVector safeNormal5 = FVector.VectorPlaneProject(safeNormal, ChrData.RightVector).GetSafeNormal();
			float num2 = MathLib.DegAcos(FVector.DotProduct(safeNormal5, ChrData.ForwardVector));
			if (FVector.DotProduct(FVector.CrossProduct(safeNormal5, ChrData.ForwardVector), ChrData.RightVector) < 0f)
			{
				num2 *= -1f;
			}
			target4 = num2 / 90f;
		}
		BSFlyLeanX = FMath.FInterpTo(BSFlyLeanX, target3, DeltaTime, 3f);
		BSFlyLeanY = FMath.FInterpTo(BSFlyLeanY, target4, DeltaTime, 12f);
		float num3 = 0f;
		if (SplineFlyMoveData != null)
		{
			num3 = SplineFlyMoveData.FlyDownwardJudgeAngle;
		}
		if (ChrData.Velocity.IsNearlyZero())
		{
			bFlyUpward = true;
			return;
		}
		float num4 = MathLib.DegAcos(FVector.DotProduct(ChrData.Velocity.GetSafeNormal(), FVector.UpVector));
		bFlyUpward = num4 <= 90f + num3;
	}
}
