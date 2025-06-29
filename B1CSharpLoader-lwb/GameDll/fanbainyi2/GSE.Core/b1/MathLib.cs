using System;
using b1.CppExport;
using UnrealEngine.Runtime;

namespace b1;

public static class MathLib
{
	public const float PI = (float)Math.PI;

	public const float SMALL_NUMBER = 1E-08f;

	private const float MaxTimeStep = 1f / 60f;

	public static GSE_NativeMathFuncs.Del_RotateAngleAxis RotateAngleAxis;

	public static GSE_NativeMathFuncs.Del_MakeRotFromYZ MakeRotFromYZ;

	public static GSE_NativeMathFuncs.Del_GetRightVector GetRightVector;

	public static GSE_NativeMathFuncs.Del_GetForwardVector GetForwardVector;

	public static GSE_NativeMathFuncs.Del_InverseTransformRotation InverseTransformRotation;

	public static GSE_NativeMathFuncs.Del_InverseTransformDirection InverseTransformDirection;

	public static GSE_NativeMathFuncs.Del_Normal Normal;

	public static GSE_NativeMathFuncs.Del_RandomBool RandomBool;

	public static GSE_NativeMathFuncs.Del_InverseTransformLocation InverseTransformLocation;

	public static GSE_NativeMathFuncs.Del_TransformLocation TransformLocation;

	public static GSE_NativeMathFuncs.Del_TransformRotation TransformRotation;

	public static GSE_NativeMathFuncs.Del_MakeRotFromX MakeRotFromX;

	public static GSE_NativeMathFuncs.Del_FindLookAtRotation FindLookAtRotation;

	public static GSE_NativeMathFuncs.Del_MakeRotFromZ MakeRotFromZ;

	public static GSE_NativeMathFuncs.Del_RInterpTo_Constant RInterpTo_Constant;

	public static GSE_NativeMathFuncs.Del_RandomRotator RandomRotator;

	public static GSE_NativeMathFuncs.Del_NormalizedDeltaRotator NormalizedDeltaRotator;

	public static GSE_NativeMathFuncs.Del_Conv_VectorToRotator Conv_VectorToRotator;

	public static GSE_NativeMathFuncs.Del_CrossProduct CrossProduct;

	public static GSE_NativeMathFuncs.Del_RandomIntInRange RandomIntInRange;

	public static GSE_NativeMathFuncs.Del_FFloor FFloor;

	public static GSE_NativeMathFuncs.Del_MakeRotFromXZ MakeRotFromXZ;

	public static GSE_NativeMathFuncs.Del_TransformDirection TransformDirection;

	public static GSE_NativeMathFuncs.Del_ProjectPointontoPlane ProjectPointontoPlane;

	public static GSE_NativeMathFuncs.Del_TransformToMatrix TransformToMatrix;

	public static GSE_NativeMathFuncs.Del_MakeFromEuler Quat_MakeFromEuler;

	public static GSE_NativeMathFuncs.Del_FClamp_CPP FClamp_CPP;

	public static GSE_NativeMathFuncs.Del_NormalizeAxis_CPP NormalizeAxis_CPP;

	public static GSE_NativeMathFuncs.Del_ClampAxis_CPP ClampAxis_CPP;

	public static GSE_NativeMathFuncs.Del_DotProduct2D_CPP DotProduct2D_CPP;

	public static GSE_NativeMathFuncs.Del_DegAcos_CPP DegAcos_CPP;

	public static GSE_NativeMathFuncs.Del_RandomFloatInRange_CPP RandomFloatInRange_CPP;

	public static float Abs(float Val)
	{
		return Math.Abs(Val);
	}

	public static float Cos(float Val)
	{
		return (float)Math.Cos(Val);
	}

	public static float Sin(float Val)
	{
		return (float)Math.Sin(Val);
	}

	public static float DegreesToRadians(float DegVal)
	{
		return DegVal * ((float)Math.PI / 180f);
	}

	public static float Clamp(float X, float Min, float Max)
	{
		if (!(X < Min))
		{
			if (!(X < Max))
			{
				return Max;
			}
			return X;
		}
		return Min;
	}

	public static double Clamp(double X, double Min, double Max)
	{
		if (!(X < Min))
		{
			if (!(X < Max))
			{
				return Max;
			}
			return X;
		}
		return Min;
	}

	public static float Lerp(float A, float B, float Alpha)
	{
		return (B - A) * Alpha + A;
	}

	public static FVector Lerp(in FVector A, in FVector B, float Alpha)
	{
		return (B - A) * Alpha + A;
	}

	public static FRotator Lerp(in FRotator A, in FRotator B, float Alpha)
	{
		return (B - A) * Alpha + A;
	}

	public static GSLocation Lerp(in GSLocation A, in GSLocation B, float Alpha)
	{
		return (B - A) * Alpha + A;
	}

	public static GSRotation Lerp(in GSRotation A, in GSRotation B, float Alpha)
	{
		return (B - A) * Alpha + A;
	}

	public static float Power(float Base, float Exp)
	{
		return FMath.Pow(Base, Exp);
	}

	public static double Power(double Base, double Exp)
	{
		return FMath.Pow(Base, Exp);
	}

	public static float Square(float V)
	{
		return V * V;
	}

	public static double Square(double V)
	{
		return V * V;
	}

	public static float DistSquared(FVector V1, FVector V2)
	{
		return Square(V2.X - V1.X) + Square(V2.Y - V1.Y) + Square(V2.Z - V1.Z);
	}

	public static float Dist(FVector V1, FVector V2)
	{
		return (float)Math.Sqrt(DistSquared(V1, V2));
	}

	public static float Sqrt(float V)
	{
		return (float)Math.Sqrt(V);
	}

	public static bool IsNearlyEqual(float A, float B, float ErrorTolerance = 1E-08f)
	{
		return Abs(A - B) <= ErrorTolerance;
	}

	public static float FInterpTo(in float Current, in float Target, float DeltaTime, float InterpSpeed)
	{
		if (DeltaTime == 0f || Current == Target)
		{
			return Current;
		}
		if (InterpSpeed <= 1E-08f)
		{
			return Target;
		}
		float num = Target - Current;
		if (Square(num) < 1E-08f)
		{
			return Target;
		}
		float num2 = num * Clamp(DeltaTime * InterpSpeed, 0f, 1f);
		return Current + num2;
	}

	public static float FInterpConstantTo(in float Current, in float Target, float DeltaTime, float InterpSpeed)
	{
		float num = Target - Current;
		if (Square(num) < 1E-08f)
		{
			return Target;
		}
		float num2 = InterpSpeed * DeltaTime;
		return Current + Clamp(num, 0f - num2, num2);
	}

	public static FVector VInterpConstantTo(in FVector Current, in FVector Target, float DeltaTime, float InterpSpeed)
	{
		FVector fVector = Target - Current;
		float num = fVector.Size();
		float num2 = InterpSpeed * DeltaTime;
		if (num > num2)
		{
			if (num2 > 0f)
			{
				FVector fVector2 = fVector / num;
				return Current + fVector2 * num2;
			}
			return Current;
		}
		return Target;
	}

	public static FVector VInterpTo(FVector current, FVector target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		FVector fVector = target - current;
		if (fVector.SizeSquared() < 9.999999747378752E-05)
		{
			return target;
		}
		FVector fVector2 = fVector * FMath.Clamp(deltaTime * interpSpeed, 0f, 1f);
		return current + fVector2;
	}

	public static GSLocation VInterpTo(GSLocation current, GSLocation target, float deltaTime, float interpSpeed)
	{
		if (interpSpeed <= 0f)
		{
			return target;
		}
		GSLocation gSLocation = target - current;
		if (gSLocation.SizeSquared() < 0.0001f)
		{
			return target;
		}
		return current + gSLocation * FMath.Clamp(deltaTime * interpSpeed, 0f, 1f);
	}

	public static GSLocation VInterpConstantTo(in GSLocation Current, in GSLocation Target, float DeltaTime, float InterpSpeed)
	{
		GSLocation Location = Target - Current;
		float num = Location.Size();
		float num2 = InterpSpeed * DeltaTime;
		if (num > num2)
		{
			if (num2 > 0f)
			{
				GSLocation gSLocation = Location / num;
				return Current + gSLocation * num2;
			}
			return Current;
		}
		return Target;
	}

	public static FRotator RInterpTo(in FRotator Current, in FRotator Target, float DeltaTime, float InterpSpeed)
	{
		if (DeltaTime == 0f || Current == Target)
		{
			return Current;
		}
		if (InterpSpeed <= 0f)
		{
			return Target;
		}
		float x = InterpSpeed * DeltaTime;
		FRotator normalized = (Target - Current).GetNormalized();
		if (normalized.IsNearlyZero())
		{
			return Target;
		}
		FRotator fRotator = normalized * Clamp(x, 0f, 1f);
		return (Current + fRotator).GetNormalized();
	}

	public static FRotator RInterpConstantTo(in FRotator Current, in FRotator Target, float DeltaTime, float InterpSpeed)
	{
		if (DeltaTime == 0f || Current == Target)
		{
			return Current;
		}
		if (InterpSpeed <= 0f)
		{
			return Target;
		}
		float num = InterpSpeed * DeltaTime;
		FRotator normalized = (Target - Current).GetNormalized();
		FRotator fRotator = Current;
		fRotator.Pitch += Clamp(normalized.Pitch, 0f - num, num);
		fRotator.Yaw += Clamp(normalized.Yaw, 0f - num, num);
		fRotator.Roll += Clamp(normalized.Roll, 0f - num, num);
		return fRotator.GetNormalized();
	}

	public static GSRotation RInterpTo(in GSRotation Current, in GSRotation Target, float DeltaTime, float InterpSpeed)
	{
		if (DeltaTime == 0f || Current == Target)
		{
			return Current;
		}
		if (InterpSpeed <= 0f)
		{
			return Target;
		}
		float x = InterpSpeed * DeltaTime;
		GSRotation normalized = (Target - Current).GetNormalized();
		if (normalized.IsNearlyZero())
		{
			return Target;
		}
		GSRotation gSRotation = normalized * Clamp(x, 0f, 1f);
		return (Current + gSRotation).GetNormalized();
	}

	public static GSRotation RInterpConstantTo(in GSRotation Current, in GSRotation Target, float DeltaTime, float InterpSpeed)
	{
		if (DeltaTime == 0f || Current == Target)
		{
			return Current;
		}
		if (InterpSpeed <= 0f)
		{
			return Target;
		}
		float num = InterpSpeed * DeltaTime;
		GSRotation normalized = (Target - Current).GetNormalized();
		GSRotation obj = Current;
		obj.Pitch += Clamp(normalized.Pitch, 0f - num, num);
		obj.Yaw += Clamp(normalized.Yaw, 0f - num, num);
		obj.Roll += Clamp(normalized.Roll, 0f - num, num);
		return obj.GetNormalized();
	}

	public static float GetVectorAngle(FVector2D V1, FVector2D V2)
	{
		float x = FVector2D.DotProduct(V1, V2);
		return FMath.RadiansToDegrees(FMath.Atan2(FVector2D.CrossProduct(V1, V2), x));
	}

	public static float FClamp(float V, float a, float b)
	{
		return (float)FClamp_CPP(V, a, b);
	}

	public static float NormalizeAxis(float Angle)
	{
		return (float)NormalizeAxis_CPP(Angle);
	}

	public static float ClampAxis(float Angle)
	{
		return (float)ClampAxis_CPP(Angle);
	}

	public static float DotProduct2D(FVector2D V1, FVector2D V2)
	{
		return (float)DotProduct2D_CPP(V1, V2);
	}

	public static float DegAcos(float A)
	{
		return (float)DegAcos_CPP(A);
	}

	public static float RandomFloatInRange(float Min, float Max)
	{
		return (float)RandomFloatInRange_CPP(Min, Max);
	}

	public static float FSubStepInterpTo(float Current, float Target, float DeltaTime, float InterpSpeed)
	{
		float num = Current;
		if (DeltaTime > 1f / 60f)
		{
			float num2 = (Target - Current) * (1f / DeltaTime);
			float Target2 = Current;
			float num3 = DeltaTime;
			while (num3 > 0.0001f)
			{
				float num4 = FMath.Min(1f / 60f, num3);
				Target2 += num2 * num4;
				num3 -= num4;
				num = FInterpTo(in Current, in Target2, num4, InterpSpeed);
				Current = num;
			}
		}
		else
		{
			num = FInterpTo(in Current, in Target, DeltaTime, InterpSpeed);
		}
		return num;
	}

	public static FVector VSubStepInterpTo(FVector Current, FVector Target, float DeltaTime, float InterpSpeed)
	{
		FVector fVector = Current;
		if (DeltaTime > 1f / 60f)
		{
			FVector fVector2 = (Target - Current) * (1f / DeltaTime);
			FVector target = Current;
			float num = DeltaTime;
			while (num > 0.0001f)
			{
				float num2 = FMath.Min(1f / 60f, num);
				target += fVector2 * num2;
				num -= num2;
				fVector = VInterpTo(Current, target, num2, InterpSpeed);
				Current = fVector;
			}
		}
		else
		{
			fVector = VInterpTo(Current, Target, DeltaTime, InterpSpeed);
		}
		return fVector;
	}

	public static FVector VSubStepInterpTo(FVector Current, FVector Target, float DeltaTime, FVector InterpSpeed)
	{
		FVector fVector = Current;
		if (DeltaTime > 1f / 60f)
		{
			FVector fVector2 = (Target - Current) * (1f / DeltaTime);
			FVector fVector3 = Current;
			float num = DeltaTime;
			while (num > 0.0001f)
			{
				float num2 = FMath.Min(1f / 60f, num);
				fVector3 += fVector2 * num2;
				num -= num2;
				fVector.X = FInterpTo(Current.X, fVector3.X, num2, InterpSpeed.X);
				fVector.Y = FInterpTo(Current.Y, fVector3.Y, num2, InterpSpeed.Y);
				fVector.Z = FInterpTo(Current.Z, fVector3.Z, num2, InterpSpeed.Z);
				Current = fVector;
			}
		}
		else
		{
			fVector.X = FInterpTo(Current.X, Target.X, DeltaTime, InterpSpeed.X);
			fVector.Y = FInterpTo(Current.Y, Target.Y, DeltaTime, InterpSpeed.Y);
			fVector.Z = FInterpTo(Current.Z, Target.Z, DeltaTime, InterpSpeed.Z);
		}
		return fVector;
	}

	public static FRotator RSubStepInterpTo(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed)
	{
		FRotator fRotator = Current;
		if (DeltaTime > 1f / 60f)
		{
			FRotator fRotator2 = (Target - Current).GetNormalized() * (1f / DeltaTime);
			FRotator Target2 = Current;
			float num = DeltaTime;
			while (num > 0.0001f)
			{
				float num2 = FMath.Min(1f / 60f, num);
				Target2 += fRotator2 * num2;
				num -= num2;
				fRotator = RInterpTo(in Current, in Target2, num2, InterpSpeed);
				Current = fRotator;
			}
		}
		else
		{
			fRotator = RInterpTo(in Current, in Target, DeltaTime, InterpSpeed);
		}
		return fRotator;
	}

	static MathLib()
	{
		new GSE_NativeMathFuncs();
	}
}
