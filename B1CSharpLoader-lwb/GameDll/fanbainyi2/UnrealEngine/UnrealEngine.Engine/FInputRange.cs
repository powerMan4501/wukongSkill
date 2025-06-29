using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.InputRange", "Engine", UnrealModuleType.Engine)]
public struct FInputRange
{
	private static bool Min_IsValid;

	private static int Min_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputRange:Min")]
	public float Min;

	private static bool Max_IsValid;

	private static int Max_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.InputRange:Max")]
	public float Max;

	private static bool FInputRange_IsValid;

	private static int FInputRange_StructSize;

	public FInputRange Copy()
	{
		return this;
	}

	public static FInputRange FromNative(IntPtr nativeBuffer)
	{
		return new FInputRange(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputRange value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputRange FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputRange(nativeBuffer + arrayIndex * FInputRange_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputRange value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputRange_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputRange");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Min_Offset), Min);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Max_Offset), Max);
	}

	public FInputRange(IntPtr nativeStruct)
	{
		if (!FInputRange_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.InputRange");
			Min = 0f;
			Max = 0f;
		}
		else
		{
			Min = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Min_Offset));
			Max = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Max_Offset));
		}
	}

	static FInputRange()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputRange));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.InputRange");
		FInputRange_StructSize = NativeReflection.GetStructSize(intPtr);
		Min_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Min");
		Min_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Min", Classes.FFloatProperty);
		Max_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Max");
		Max_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Max", Classes.FFloatProperty);
		FInputRange_IsValid = intPtr != IntPtr.Zero && Min_IsValid && Max_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.InputRange", FInputRange_IsValid);
	}
}
