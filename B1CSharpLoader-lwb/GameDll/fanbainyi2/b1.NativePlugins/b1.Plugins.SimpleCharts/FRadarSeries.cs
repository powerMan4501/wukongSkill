using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.RadarSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FRadarSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.RadarSeries:name")]
	public string name;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.RadarSeries:data")]
	public List<FData> data;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.RadarSeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.RadarSeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FRadarSeries_IsValid;

	private static int FRadarSeries_StructSize;

	public FRadarSeries Copy()
	{
		FRadarSeries result = this;
		if (data != null)
		{
			result.data = new List<FData>(data);
		}
		return result;
	}

	public static FRadarSeries FromNative(IntPtr nativeBuffer)
	{
		return new FRadarSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRadarSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRadarSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRadarSeries(nativeBuffer + arrayIndex * FRadarSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRadarSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRadarSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRadarSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.RadarSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		new TArrayCopyMarshaler<FData>(1, data_PropertyAddress, CachedMarshalingDelegates<FData, FData>.FromNative, CachedMarshalingDelegates<FData, FData>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FRadarSeries(IntPtr nativeStruct)
	{
		if (!FRadarSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.RadarSeries");
			name = FStringMarshaler.DefaultString;
			data = null;
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			data = new TArrayCopyMarshaler<FData>(1, data_PropertyAddress, CachedMarshalingDelegates<FData, FData>.FromNative, CachedMarshalingDelegates<FData, FData>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FRadarSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRadarSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRadarSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.RadarSeries");
		FRadarSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FRadarSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && data_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.RadarSeries", FRadarSeries_IsValid);
	}
}
