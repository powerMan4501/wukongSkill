using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SpawnBulletSpeed")]
public struct FSpawnBulletSpeed
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSSpawnBullets")]
	[USharpPath("/Script/b1-Managed.SpawnBulletSpeed:Spd")]
	public FSpawnBulletMinMaxValue Spd;

	[UProperty]
	[EditAnywhere]
	[Category("GSSpawnBullets")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpawnBulletSpeed:AccelerationTime")]
	public float AccelerationTime;

	[BlueprintReadWrite]
	[Category("GSSpawnBullets")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SpawnBulletSpeed:SpdCurve")]
	public UCurveFloat SpdCurve;

	private static int SpawnBulletSpeed_StructSize;

	private static int SpawnBulletSpeed_IsValid;

	private static bool Spd_IsValid;

	private static int Spd_Offset;

	private static bool AccelerationTime_IsValid;

	private static int AccelerationTime_Offset;

	private static bool SpdCurve_IsValid;

	private static int SpdCurve_Offset;

	public FSpawnBulletSpeed Copy()
	{
		return this;
	}

	public static FSpawnBulletSpeed FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnBulletSpeed(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnBulletSpeed value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnBulletSpeed FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnBulletSpeed(IntPtr.Add(nativeBuffer, arrayIndex * SpawnBulletSpeed_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnBulletSpeed value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnBulletSpeed_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnBulletSpeed_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnBulletSpeed");
			return;
		}
		FSpawnBulletMinMaxValue.ToNative(IntPtr.Add(nativeStruct, Spd_Offset), Spd);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AccelerationTime_Offset), AccelerationTime);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, SpdCurve_Offset), SpdCurve);
	}

	public FSpawnBulletSpeed(IntPtr nativeStruct)
	{
		if (SpawnBulletSpeed_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnBulletSpeed");
			Spd = default(FSpawnBulletMinMaxValue);
			AccelerationTime = 0f;
			SpdCurve = null;
		}
		else
		{
			Spd = FSpawnBulletMinMaxValue.FromNative(IntPtr.Add(nativeStruct, Spd_Offset));
			AccelerationTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AccelerationTime_Offset));
			SpdCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, SpdCurve_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnBulletSpeed");
		SpawnBulletSpeed_StructSize = NativeReflection.GetStructSize(intPtr);
		Spd_Offset = NativeReflection.GetPropertyOffset(intPtr, "Spd");
		Spd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Spd", Classes.FStructProperty);
		AccelerationTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "AccelerationTime");
		AccelerationTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AccelerationTime", Classes.FFloatProperty);
		SpdCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpdCurve");
		SpdCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpdCurve", Classes.FObjectProperty);
		SpawnBulletSpeed_IsValid = ((intPtr != IntPtr.Zero && Spd_IsValid && AccelerationTime_IsValid && SpdCurve_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnBulletSpeed", (byte)SpawnBulletSpeed_IsValid != 0);
	}

	static FSpawnBulletSpeed()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnBulletSpeed)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnBulletSpeed));
	}
}
