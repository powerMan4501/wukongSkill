using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.Radar", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FRadar
{
	private static bool circle_IsValid;

	private static FFieldAddress circle_PropertyAddress;

	private static int circle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.Radar:circle")]
	public bool circle;

	private static bool radius_IsValid;

	private static int radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.Radar:radius")]
	public float radius;

	private static bool color_IsValid;

	private static int color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.Radar:color")]
	public FColor color;

	private static bool backgroundColor_IsValid;

	private static int backgroundColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.Radar:backgroundColor")]
	public FColor backgroundColor;

	private static bool indicator_IsValid;

	private static FFieldAddress indicator_PropertyAddress;

	private static int indicator_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.Radar:indicator")]
	public List<FIndicator> indicator;

	private static bool FRadar_IsValid;

	private static int FRadar_StructSize;

	public FRadar Copy()
	{
		FRadar result = this;
		if (indicator != null)
		{
			result.indicator = new List<FIndicator>(indicator);
		}
		return result;
	}

	public static FRadar FromNative(IntPtr nativeBuffer)
	{
		return new FRadar(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRadar value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRadar FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRadar(nativeBuffer + arrayIndex * FRadar_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRadar value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRadar_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRadar_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.Radar");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, circle_Offset), 0, circle_PropertyAddress.Address, circle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, radius_Offset), radius);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, color_Offset), color);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, backgroundColor_Offset), backgroundColor);
		new TArrayCopyMarshaler<FIndicator>(1, indicator_PropertyAddress, CachedMarshalingDelegates<FIndicator, FIndicator>.FromNative, CachedMarshalingDelegates<FIndicator, FIndicator>.ToNative).ToNative(IntPtr.Add(nativeStruct, indicator_Offset), indicator);
	}

	public FRadar(IntPtr nativeStruct)
	{
		if (!FRadar_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.Radar");
			circle = false;
			radius = 0f;
			color = default(FColor);
			backgroundColor = default(FColor);
			indicator = null;
		}
		else
		{
			circle = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, circle_Offset), 0, circle_PropertyAddress.Address);
			radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, radius_Offset));
			color = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, color_Offset));
			backgroundColor = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, backgroundColor_Offset));
			indicator = new TArrayCopyMarshaler<FIndicator>(1, indicator_PropertyAddress, CachedMarshalingDelegates<FIndicator, FIndicator>.FromNative, CachedMarshalingDelegates<FIndicator, FIndicator>.ToNative).FromNative(IntPtr.Add(nativeStruct, indicator_Offset));
		}
	}

	static FRadar()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRadar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRadar));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.Radar");
		FRadar_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref circle_PropertyAddress, intPtr, "circle");
		circle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "circle");
		circle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "circle", Classes.FBoolProperty);
		radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "radius");
		radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "radius", Classes.FFloatProperty);
		color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "color");
		color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "color", Classes.FStructProperty);
		backgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "backgroundColor");
		backgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "backgroundColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref indicator_PropertyAddress, intPtr, "indicator");
		indicator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "indicator");
		indicator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "indicator", Classes.FArrayProperty);
		FRadar_IsValid = intPtr != IntPtr.Zero && circle_IsValid && radius_IsValid && color_IsValid && backgroundColor_IsValid && indicator_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.Radar", FRadar_IsValid);
	}
}
