using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.LinearGradient", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FLinearGradient
{
	private static bool ColorPosition_IsValid;

	private static int ColorPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.LinearGradient:ColorPosition")]
	public FVector4 ColorPosition;

	private static bool colorStops_IsValid;

	private static FFieldAddress colorStops_PropertyAddress;

	private static int colorStops_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.LinearGradient:colorStops")]
	public List<FColorStop> colorStops;

	private static bool FLinearGradient_IsValid;

	private static int FLinearGradient_StructSize;

	public FLinearGradient Copy()
	{
		FLinearGradient result = this;
		if (colorStops != null)
		{
			result.colorStops = new List<FColorStop>(colorStops);
		}
		return result;
	}

	public static FLinearGradient FromNative(IntPtr nativeBuffer)
	{
		return new FLinearGradient(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLinearGradient value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLinearGradient FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLinearGradient(nativeBuffer + arrayIndex * FLinearGradient_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLinearGradient value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLinearGradient_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLinearGradient_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.LinearGradient");
			return;
		}
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, ColorPosition_Offset), ColorPosition);
		new TArrayCopyMarshaler<FColorStop>(1, colorStops_PropertyAddress, CachedMarshalingDelegates<FColorStop, FColorStop>.FromNative, CachedMarshalingDelegates<FColorStop, FColorStop>.ToNative).ToNative(IntPtr.Add(nativeStruct, colorStops_Offset), colorStops);
	}

	public FLinearGradient(IntPtr nativeStruct)
	{
		if (!FLinearGradient_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.LinearGradient");
			ColorPosition = default(FVector4);
			colorStops = null;
		}
		else
		{
			ColorPosition = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, ColorPosition_Offset));
			colorStops = new TArrayCopyMarshaler<FColorStop>(1, colorStops_PropertyAddress, CachedMarshalingDelegates<FColorStop, FColorStop>.FromNative, CachedMarshalingDelegates<FColorStop, FColorStop>.ToNative).FromNative(IntPtr.Add(nativeStruct, colorStops_Offset));
		}
	}

	static FLinearGradient()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLinearGradient)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLinearGradient));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.LinearGradient");
		FLinearGradient_StructSize = NativeReflection.GetStructSize(intPtr);
		ColorPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ColorPosition");
		ColorPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ColorPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref colorStops_PropertyAddress, intPtr, "colorStops");
		colorStops_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "colorStops");
		colorStops_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "colorStops", Classes.FArrayProperty);
		FLinearGradient_IsValid = intPtr != IntPtr.Zero && ColorPosition_IsValid && colorStops_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.LinearGradient", FLinearGradient_IsValid);
	}
}
