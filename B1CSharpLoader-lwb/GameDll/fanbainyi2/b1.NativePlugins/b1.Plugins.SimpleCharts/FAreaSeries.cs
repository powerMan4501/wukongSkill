using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.AreaSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FAreaSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.AreaSeries:name")]
	public string name;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.AreaSeries:data")]
	public List<float> data;

	private static bool smooth_IsValid;

	private static FFieldAddress smooth_PropertyAddress;

	private static int smooth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.AreaSeries:smooth")]
	public bool smooth;

	private static bool DataLabel_IsValid;

	private static int DataLabel_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.AreaSeries:DataLabel")]
	public FSeriesLabel DataLabel;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.AreaSeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.AreaSeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FAreaSeries_IsValid;

	private static int FAreaSeries_StructSize;

	public FAreaSeries Copy()
	{
		FAreaSeries result = this;
		if (data != null)
		{
			result.data = new List<float>(data);
		}
		return result;
	}

	public static FAreaSeries FromNative(IntPtr nativeBuffer)
	{
		return new FAreaSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAreaSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAreaSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAreaSeries(nativeBuffer + arrayIndex * FAreaSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAreaSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAreaSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAreaSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.AreaSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		new TArrayCopyMarshaler<float>(1, data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, smooth_Offset), 0, smooth_PropertyAddress.Address, smooth);
		FSeriesLabel.ToNative(IntPtr.Add(nativeStruct, DataLabel_Offset), DataLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FAreaSeries(IntPtr nativeStruct)
	{
		if (!FAreaSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.AreaSeries");
			name = FStringMarshaler.DefaultString;
			data = null;
			smooth = false;
			DataLabel = default(FSeriesLabel);
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			data = new TArrayCopyMarshaler<float>(1, data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			smooth = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, smooth_Offset), 0, smooth_PropertyAddress.Address);
			DataLabel = FSeriesLabel.FromNative(IntPtr.Add(nativeStruct, DataLabel_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FAreaSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAreaSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAreaSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.AreaSeries");
		FAreaSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref smooth_PropertyAddress, intPtr, "smooth");
		smooth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "smooth");
		smooth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "smooth", Classes.FBoolProperty);
		DataLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataLabel");
		DataLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataLabel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FAreaSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && data_IsValid && smooth_IsValid && DataLabel_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.AreaSeries", FAreaSeries_IsValid);
	}
}
