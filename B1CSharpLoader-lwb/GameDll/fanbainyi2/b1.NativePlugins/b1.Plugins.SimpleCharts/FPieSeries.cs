using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.PieSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FPieSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:name")]
	public string name;

	private static bool radius_IsValid;

	private static int radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:radius")]
	public float radius;

	private static bool label_show_IsValid;

	private static FFieldAddress label_show_PropertyAddress;

	private static int label_show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:label_show")]
	public bool label_show;

	private static bool labelLine_show_IsValid;

	private static FFieldAddress labelLine_show_PropertyAddress;

	private static int labelLine_show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:labelLine_show")]
	public bool labelLine_show;

	private static bool RoseType_IsValid;

	private static FFieldAddress RoseType_PropertyAddress;

	private static int RoseType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:RoseType")]
	public bool RoseType;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:data")]
	public Dictionary<string, float> data;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.PieSeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FPieSeries_IsValid;

	private static int FPieSeries_StructSize;

	public FPieSeries Copy()
	{
		FPieSeries result = this;
		if (data != null)
		{
			result.data = new Dictionary<string, float>(data);
		}
		return result;
	}

	public static FPieSeries FromNative(IntPtr nativeBuffer)
	{
		return new FPieSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPieSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPieSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPieSeries(nativeBuffer + arrayIndex * FPieSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPieSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPieSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPieSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.PieSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, radius_Offset), radius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, label_show_Offset), 0, label_show_PropertyAddress.Address, label_show);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, labelLine_show_Offset), 0, labelLine_show_PropertyAddress.Address, labelLine_show);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RoseType_Offset), 0, RoseType_PropertyAddress.Address, RoseType);
		new TMapCopyMarshaler<string, float>(1, data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FPieSeries(IntPtr nativeStruct)
	{
		if (!FPieSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.PieSeries");
			name = FStringMarshaler.DefaultString;
			radius = 0f;
			label_show = false;
			labelLine_show = false;
			RoseType = false;
			data = null;
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, radius_Offset));
			label_show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, label_show_Offset), 0, label_show_PropertyAddress.Address);
			labelLine_show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, labelLine_show_Offset), 0, labelLine_show_PropertyAddress.Address);
			RoseType = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RoseType_Offset), 0, RoseType_PropertyAddress.Address);
			data = new TMapCopyMarshaler<string, float>(1, data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FPieSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPieSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPieSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.PieSeries");
		FPieSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "radius");
		radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref label_show_PropertyAddress, intPtr, "label_show");
		label_show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "label_show");
		label_show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "label_show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref labelLine_show_PropertyAddress, intPtr, "labelLine_show");
		labelLine_show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "labelLine_show");
		labelLine_show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "labelLine_show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RoseType_PropertyAddress, intPtr, "RoseType");
		RoseType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoseType");
		RoseType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoseType", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FPieSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && radius_IsValid && label_show_IsValid && labelLine_show_IsValid && RoseType_IsValid && data_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.PieSeries", FPieSeries_IsValid);
	}
}
