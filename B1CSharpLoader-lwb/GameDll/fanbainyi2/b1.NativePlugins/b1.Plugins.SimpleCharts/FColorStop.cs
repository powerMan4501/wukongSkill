using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.ColorStop", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FColorStop
{
	private static bool offset_IsValid;

	private static int offset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ColorStop:offset")]
	public float offset;

	private static bool color_IsValid;

	private static int color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ColorStop:color")]
	public FColor color;

	private static bool FColorStop_IsValid;

	private static int FColorStop_StructSize;

	public FColorStop Copy()
	{
		return this;
	}

	public static FColorStop FromNative(IntPtr nativeBuffer)
	{
		return new FColorStop(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FColorStop value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FColorStop FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FColorStop(nativeBuffer + arrayIndex * FColorStop_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FColorStop value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FColorStop_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FColorStop_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.ColorStop");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, offset_Offset), offset);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, color_Offset), color);
	}

	public FColorStop(IntPtr nativeStruct)
	{
		if (!FColorStop_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.ColorStop");
			offset = 0f;
			color = default(FColor);
		}
		else
		{
			offset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, offset_Offset));
			color = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, color_Offset));
		}
	}

	static FColorStop()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FColorStop)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FColorStop));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.ColorStop");
		FColorStop_StructSize = NativeReflection.GetStructSize(intPtr);
		offset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "offset");
		offset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "offset", Classes.FFloatProperty);
		color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "color");
		color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "color", Classes.FStructProperty);
		FColorStop_IsValid = intPtr != IntPtr.Zero && offset_IsValid && color_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.ColorStop", FColorStop_IsValid);
	}
}
