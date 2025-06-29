using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.BarSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FBarSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:name")]
	public string name;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:data")]
	public List<float> data;

	private static bool stack_IsValid;

	private static int stack_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:stack")]
	public string stack;

	private static bool showBackground_IsValid;

	private static FFieldAddress showBackground_PropertyAddress;

	private static int showBackground_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:showBackground")]
	public bool showBackground;

	private static bool backgroundColor_IsValid;

	private static int backgroundColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:backgroundColor")]
	public FLinearColor backgroundColor;

	private static bool DataLabel_IsValid;

	private static int DataLabel_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:DataLabel")]
	public FSeriesLabel DataLabel;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.BarSeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FBarSeries_IsValid;

	private static int FBarSeries_StructSize;

	public FBarSeries Copy()
	{
		FBarSeries result = this;
		if (data != null)
		{
			result.data = new List<float>(data);
		}
		return result;
	}

	public static FBarSeries FromNative(IntPtr nativeBuffer)
	{
		return new FBarSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBarSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBarSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBarSeries(nativeBuffer + arrayIndex * FBarSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBarSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBarSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBarSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.BarSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		new TArrayCopyMarshaler<float>(1, data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, stack_Offset), stack);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, showBackground_Offset), 0, showBackground_PropertyAddress.Address, showBackground);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, backgroundColor_Offset), backgroundColor);
		FSeriesLabel.ToNative(IntPtr.Add(nativeStruct, DataLabel_Offset), DataLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FBarSeries(IntPtr nativeStruct)
	{
		if (!FBarSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.BarSeries");
			name = FStringMarshaler.DefaultString;
			data = null;
			stack = FStringMarshaler.DefaultString;
			showBackground = false;
			backgroundColor = default(FLinearColor);
			DataLabel = default(FSeriesLabel);
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			data = new TArrayCopyMarshaler<float>(1, data_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			stack = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, stack_Offset));
			showBackground = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, showBackground_Offset), 0, showBackground_PropertyAddress.Address);
			backgroundColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, backgroundColor_Offset));
			DataLabel = FSeriesLabel.FromNative(IntPtr.Add(nativeStruct, DataLabel_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FBarSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBarSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBarSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.BarSeries");
		FBarSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		stack_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "stack");
		stack_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "stack", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref showBackground_PropertyAddress, intPtr, "showBackground");
		showBackground_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "showBackground");
		showBackground_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "showBackground", Classes.FBoolProperty);
		backgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "backgroundColor");
		backgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "backgroundColor", Classes.FStructProperty);
		DataLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataLabel");
		DataLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataLabel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FBarSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && data_IsValid && stack_IsValid && showBackground_IsValid && backgroundColor_IsValid && DataLabel_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.BarSeries", FBarSeries_IsValid);
	}
}
