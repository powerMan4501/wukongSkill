using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 102408)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.RandomStream", "CoreUObject", UnrealModuleType.Engine)]
public struct FRandomStream
{
	private static bool InitialSeed_IsValid;

	private static int InitialSeed_Offset;

	[UProperty(Flags = (PropFlags)6755469251052037uL)]
	[UMetaPath("/Script/CoreUObject.RandomStream:InitialSeed")]
	public int InitialSeed;

	private static bool Seed_IsValid;

	private static int Seed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274816uL)]
	[UMetaPath("/Script/CoreUObject.RandomStream:Seed")]
	public int Seed;

	private static bool FRandomStream_IsValid;

	private static int FRandomStream_StructSize;

	public FRandomStream Copy()
	{
		return this;
	}

	static FRandomStream()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRandomStream)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRandomStream));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.RandomStream");
		FRandomStream_StructSize = NativeReflection.GetStructSize(intPtr);
		InitialSeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialSeed");
		InitialSeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialSeed", Classes.FIntProperty);
		Seed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Seed");
		Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Seed", Classes.FIntProperty);
		FRandomStream_IsValid = intPtr != IntPtr.Zero && InitialSeed_IsValid && Seed_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.RandomStream", FRandomStream_IsValid);
		NativeReflection.ValidateBlittableStructSize(intPtr, typeof(FRandomStream));
	}

	public FRandomStream(int seed)
	{
		InitialSeed = seed;
		Seed = seed;
	}

	public void Initialize(int seed)
	{
		InitialSeed = seed;
		Seed = seed;
	}

	public void Reset()
	{
		Seed = InitialSeed;
	}

	public int GetInitialSeed()
	{
		return InitialSeed;
	}

	public void GenerateNewSeed()
	{
		Initialize(FMath.Rand());
	}

	public unsafe float GetFraction()
	{
		MutateSeed();
		float num = 1f;
		float value = default(float);
		*(int*)(&value) = (int)(*(int*)(&num) & 0xFF800000u) | (Seed & 0x7FFFFF);
		return FMath.Fractional(value);
	}

	public uint GetUnsignedInt()
	{
		MutateSeed();
		return (uint)Seed;
	}

	public FVector GetUnitVector()
	{
		FVector fVector = default(FVector);
		double num;
		do
		{
			fVector.mX = GetFraction() * 2f - 1f;
			fVector.mY = GetFraction() * 2f - 1f;
			fVector.mZ = GetFraction() * 2f - 1f;
			num = fVector.SizeSquared();
		}
		while (num > 1.0 || num < 9.999999747378752E-05);
		return fVector.GetUnsafeNormal();
	}

	public int GetCurrentSeed()
	{
		return Seed;
	}

	public float FRand()
	{
		return GetFraction();
	}

	public int RandHelper(int a)
	{
		if (a <= 0)
		{
			return 0;
		}
		return FMath.TruncToInt(GetFraction() * ((float)a - 1E-05f));
	}

	public int RandRange(int min, int max)
	{
		int a = max - min + 1;
		return min + RandHelper(a);
	}

	public float FRandRange(float min, float max)
	{
		return min + (max - min) * FRand();
	}

	public FVector VRand()
	{
		return GetUnitVector();
	}

	public FVector VRandCone(FVector dir, float coneHalfAngleRad)
	{
		if (coneHalfAngleRad > 0f)
		{
			float num = FRand();
			float num2 = FRand();
			float num3 = (float)Math.PI * 2f * num;
			float x = FMath.Acos(2f * num2 - 1f);
			x = FMath.Fmod(x, coneHalfAngleRad);
			FMatrix fMatrix = FMatrix.CreateRotation(dir.Rotation());
			FVector unitAxis = fMatrix.GetUnitAxis(EAxis.X);
			FVector unitAxis2 = fMatrix.GetUnitAxis(EAxis.Y);
			return dir.RotateAngleAxis(x * 180f / (float)Math.PI, unitAxis2).RotateAngleAxis(num3 * 180f / (float)Math.PI, unitAxis).GetSafeNormal();
		}
		return dir.GetSafeNormal();
	}

	public FVector VRandCone(FVector dir, float horizontalConeHalfAngleRad, float verticalConeHalfAngleRad)
	{
		if (verticalConeHalfAngleRad > 0f && horizontalConeHalfAngleRad > 0f)
		{
			float num = FRand();
			float num2 = FRand();
			float num3 = (float)Math.PI * 2f * num;
			float x = FMath.Acos(2f * num2 - 1f);
			float num4 = FMath.Square(FMath.Cos(num3) / verticalConeHalfAngleRad) + FMath.Square(FMath.Sin(num3) / horizontalConeHalfAngleRad);
			num4 = FMath.Sqrt(1f / num4);
			x = FMath.Fmod(x, num4);
			FMatrix fMatrix = FMatrix.CreateRotation(dir.Rotation());
			FVector unitAxis = fMatrix.GetUnitAxis(EAxis.X);
			FVector unitAxis2 = fMatrix.GetUnitAxis(EAxis.Y);
			return dir.RotateAngleAxis(x * 180f / (float)Math.PI, unitAxis2).RotateAngleAxis(num3 * 180f / (float)Math.PI, unitAxis).GetSafeNormal();
		}
		return dir.GetSafeNormal();
	}

	public void MutateSeed()
	{
		Seed = Seed * 196314165 + 907633515;
	}
}
