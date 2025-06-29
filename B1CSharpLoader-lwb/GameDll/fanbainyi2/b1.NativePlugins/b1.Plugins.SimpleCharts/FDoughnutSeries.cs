using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.DoughnutSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FDoughnutSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:name")]
	public string name;

	private static bool inside_radius_IsValid;

	private static int inside_radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:inside_radius")]
	public float inside_radius;

	private static bool outside_radius_IsValid;

	private static int outside_radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:outside_radius")]
	public float outside_radius;

	private static bool label_show_IsValid;

	private static FFieldAddress label_show_PropertyAddress;

	private static int label_show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:label_show")]
	public bool label_show;

	private static bool labelLine_show_IsValid;

	private static FFieldAddress labelLine_show_PropertyAddress;

	private static int labelLine_show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:labelLine_show")]
	public bool labelLine_show;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:data")]
	public Dictionary<string, float> data;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutSeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FDoughnutSeries_IsValid;

	private static int FDoughnutSeries_StructSize;

	public FDoughnutSeries Copy()
	{
		FDoughnutSeries result = this;
		if (data != null)
		{
			result.data = new Dictionary<string, float>(data);
		}
		return result;
	}

	public static FDoughnutSeries FromNative(IntPtr nativeBuffer)
	{
		return new FDoughnutSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDoughnutSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDoughnutSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDoughnutSeries(nativeBuffer + arrayIndex * FDoughnutSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDoughnutSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDoughnutSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDoughnutSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.DoughnutSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, inside_radius_Offset), inside_radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, outside_radius_Offset), outside_radius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, label_show_Offset), 0, label_show_PropertyAddress.Address, label_show);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, labelLine_show_Offset), 0, labelLine_show_PropertyAddress.Address, labelLine_show);
		new TMapCopyMarshaler<string, float>(1, data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FDoughnutSeries(IntPtr nativeStruct)
	{
		if (!FDoughnutSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.DoughnutSeries");
			name = FStringMarshaler.DefaultString;
			inside_radius = 0f;
			outside_radius = 0f;
			label_show = false;
			labelLine_show = false;
			data = null;
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			inside_radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, inside_radius_Offset));
			outside_radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, outside_radius_Offset));
			label_show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, label_show_Offset), 0, label_show_PropertyAddress.Address);
			labelLine_show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, labelLine_show_Offset), 0, labelLine_show_PropertyAddress.Address);
			data = new TMapCopyMarshaler<string, float>(1, data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FDoughnutSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDoughnutSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDoughnutSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.DoughnutSeries");
		FDoughnutSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		inside_radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "inside_radius");
		inside_radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "inside_radius", Classes.FFloatProperty);
		outside_radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "outside_radius");
		outside_radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "outside_radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref label_show_PropertyAddress, intPtr, "label_show");
		label_show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "label_show");
		label_show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "label_show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref labelLine_show_PropertyAddress, intPtr, "labelLine_show");
		labelLine_show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "labelLine_show");
		labelLine_show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "labelLine_show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FDoughnutSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && inside_radius_IsValid && outside_radius_IsValid && label_show_IsValid && labelLine_show_IsValid && data_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.DoughnutSeries", FDoughnutSeries_IsValid);
	}
}
