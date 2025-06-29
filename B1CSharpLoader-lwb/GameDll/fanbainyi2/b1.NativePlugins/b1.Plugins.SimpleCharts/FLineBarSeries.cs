using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.LineBarSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FLineBarSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.LineBarSeries:name")]
	public string name;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.LineBarSeries:data")]
	public List<float> data;

	private static bool type_IsValid;

	private static FFieldAddress type_PropertyAddress;

	private static int type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.LineBarSeries:type")]
	public EChartType type;

	private static bool DataLabel_IsValid;

	private static int DataLabel_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.LineBarSeries:DataLabel")]
	public FSeriesLabel DataLabel;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.LineBarSeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.LineBarSeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FLineBarSeries_IsValid;

	private static int FLineBarSeries_StructSize;

	public FLineBarSeries Copy()
	{
		FLineBarSeries result = this;
		if (data != null)
		{
			result.data = new List<float>(data);
		}
		return result;
	}

	public static FLineBarSeries FromNative(IntPtr nativeBuffer)
	{
		return new FLineBarSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLineBarSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLineBarSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLineBarSeries(nativeBuffer + arrayIndex * FLineBarSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLineBarSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLineBarSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLineBarSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.LineBarSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		new TArrayCopyMarshaler<float>(1, data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		EnumMarshaler<EChartType>.ToNative(IntPtr.Add(nativeStruct, type_Offset), 0, type_PropertyAddress.Address, type);
		FSeriesLabel.ToNative(IntPtr.Add(nativeStruct, DataLabel_Offset), DataLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FLineBarSeries(IntPtr nativeStruct)
	{
		if (!FLineBarSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.LineBarSeries");
			name = FStringMarshaler.DefaultString;
			data = null;
			type = EChartType.Bar;
			DataLabel = default(FSeriesLabel);
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			data = new TArrayCopyMarshaler<float>(1, data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			type = EnumMarshaler<EChartType>.FromNative(IntPtr.Add(nativeStruct, type_Offset), 0, type_PropertyAddress.Address);
			DataLabel = FSeriesLabel.FromNative(IntPtr.Add(nativeStruct, DataLabel_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FLineBarSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLineBarSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLineBarSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.LineBarSeries");
		FLineBarSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref type_PropertyAddress, intPtr, "type");
		type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "type");
		type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "type", Classes.FEnumProperty);
		DataLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataLabel");
		DataLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataLabel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FLineBarSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && data_IsValid && type_IsValid && DataLabel_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.LineBarSeries", FLineBarSeries_IsValid);
	}
}
