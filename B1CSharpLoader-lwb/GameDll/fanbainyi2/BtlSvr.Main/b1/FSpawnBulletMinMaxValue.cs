using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SpawnBulletMinMaxValue")]
public struct FSpawnBulletMinMaxValue
{
	[UProperty]
	[EditAnywhere]
	[Category("GSSpawnBullets|LeftValue")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpawnBulletMinMaxValue:LeftValue")]
	public float LeftValue;

	[EditAnywhere]
	[UProperty]
	[Category("GSSpawnBullets|RightValue")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SpawnBulletMinMaxValue:RightValue")]
	public float RightValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSSpawnBullets|RightValue")]
	[USharpPath("/Script/b1-Managed.SpawnBulletMinMaxValue:IsEquidistance")]
	public bool IsEquidistance;

	private static int SpawnBulletMinMaxValue_StructSize;

	private static int SpawnBulletMinMaxValue_IsValid;

	private static bool LeftValue_IsValid;

	private static int LeftValue_Offset;

	private static bool RightValue_IsValid;

	private static int RightValue_Offset;

	private static bool IsEquidistance_IsValid;

	private static int IsEquidistance_Offset;

	private static FFieldAddress IsEquidistance_PropertyAddress;

	public FSpawnBulletMinMaxValue Copy()
	{
		return this;
	}

	public static FSpawnBulletMinMaxValue FromNative(IntPtr nativeBuffer)
	{
		return new FSpawnBulletMinMaxValue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSpawnBulletMinMaxValue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSpawnBulletMinMaxValue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSpawnBulletMinMaxValue(IntPtr.Add(nativeBuffer, arrayIndex * SpawnBulletMinMaxValue_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSpawnBulletMinMaxValue value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SpawnBulletMinMaxValue_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SpawnBulletMinMaxValue_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnBulletMinMaxValue");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LeftValue_Offset), LeftValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RightValue_Offset), RightValue);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsEquidistance_Offset), 0, IsEquidistance_PropertyAddress.Address, IsEquidistance);
	}

	public FSpawnBulletMinMaxValue(IntPtr nativeStruct)
	{
		if (SpawnBulletMinMaxValue_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SpawnBulletMinMaxValue");
			LeftValue = 0f;
			RightValue = 0f;
			IsEquidistance = false;
		}
		else
		{
			LeftValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LeftValue_Offset));
			RightValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RightValue_Offset));
			IsEquidistance = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsEquidistance_Offset), 0, IsEquidistance_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SpawnBulletMinMaxValue");
		SpawnBulletMinMaxValue_StructSize = NativeReflection.GetStructSize(intPtr);
		LeftValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftValue");
		LeftValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftValue", Classes.FFloatProperty);
		RightValue_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightValue");
		RightValue_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightValue", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsEquidistance_PropertyAddress, intPtr, "IsEquidistance");
		IsEquidistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsEquidistance");
		IsEquidistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsEquidistance", Classes.FBoolProperty);
		SpawnBulletMinMaxValue_IsValid = ((intPtr != IntPtr.Zero && LeftValue_IsValid && RightValue_IsValid && IsEquidistance_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SpawnBulletMinMaxValue", (byte)SpawnBulletMinMaxValue_IsValid != 0);
	}

	static FSpawnBulletMinMaxValue()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSpawnBulletMinMaxValue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSpawnBulletMinMaxValue));
	}
}
