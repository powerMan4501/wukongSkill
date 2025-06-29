using UnrealEngine.Runtime;

namespace b1;

public static class BGU_MoveUtil
{
	public static float GetRotateAngle2D(FVector2D UnitRotateAimDir, FVector2D Unit2TargetDir)
	{
		UnitRotateAimDir.Normalize();
		Unit2TargetDir.Normalize();
		return MathLib.DegAcos(MathLib.DotProduct2D(UnitRotateAimDir, Unit2TargetDir));
	}

	public static bool IsRotateClockwise(FVector2D UnitRotateAimDir, FVector2D Unit2TargetDir)
	{
		UnitRotateAimDir.Normalize();
		Unit2TargetDir.Normalize();
		return Unit2TargetDir.Y * UnitRotateAimDir.X - UnitRotateAimDir.Y * Unit2TargetDir.X >= 0f;
	}

	public static bool IsBendDown(FVector StartLoc, FVector EndLoc, bool IsFlip)
	{
		float num = EndLoc.Z - StartLoc.Z;
		if (!(num <= 0f) || IsFlip)
		{
			return num > 0f && IsFlip;
		}
		return true;
	}

	public static FRotator RotateInterpConstantToBySingleDirection(in FVector2D CurrentDir, in FVector2D TargetDir, float DeltaTime, float InterpSpeed, bool bRotateClockwise)
	{
		FRotator fRotator = new FVector(CurrentDir.X, CurrentDir.Y, 0.0).Rotation();
		if (DeltaTime == 0f || CurrentDir == TargetDir)
		{
			return fRotator;
		}
		if (InterpSpeed <= 0f)
		{
			return new FVector(TargetDir.X, TargetDir.Y, 0.0).Rotation();
		}
		float num = InterpSpeed * DeltaTime;
		float num2 = GetRotateAngle2D(CurrentDir, TargetDir);
		bool flag = IsRotateClockwise(CurrentDir, TargetDir);
		if (bRotateClockwise && !flag)
		{
			num2 = 360f - num2;
		}
		else if (!bRotateClockwise && flag)
		{
			num2 -= 360f;
		}
		else if (!bRotateClockwise && !flag)
		{
			num2 *= -1f;
		}
		FRotator fRotator2 = fRotator;
		fRotator2.Yaw += FMath.Clamp(num2, 0f - num, num);
		return fRotator2.GetNormalized();
	}
}
