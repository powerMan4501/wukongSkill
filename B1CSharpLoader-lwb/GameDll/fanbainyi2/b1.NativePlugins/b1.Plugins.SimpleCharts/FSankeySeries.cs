using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.SankeySeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FSankeySeries
{
	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.SankeySeries:data")]
	public List<string> data;

	private static bool links_IsValid;

	private static FFieldAddress links_PropertyAddress;

	private static int links_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.SankeySeries:links")]
	public List<Flinks> links;

	private static bool left_IsValid;

	private static int left_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.SankeySeries:left")]
	public float left;

	private static bool DataLabel_IsValid;

	private static int DataLabel_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.SankeySeries:DataLabel")]
	public FSeriesLabel DataLabel;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.SankeySeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.SankeySeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FSankeySeries_IsValid;

	private static int FSankeySeries_StructSize;

	public FSankeySeries Copy()
	{
		FSankeySeries result = this;
		if (data != null)
		{
			result.data = new List<string>(data);
		}
		if (links != null)
		{
			result.links = new List<Flinks>(links);
		}
		return result;
	}

	public static FSankeySeries FromNative(IntPtr nativeBuffer)
	{
		return new FSankeySeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSankeySeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSankeySeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSankeySeries(nativeBuffer + arrayIndex * FSankeySeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSankeySeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSankeySeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSankeySeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.SankeySeries");
			return;
		}
		new TArrayCopyMarshaler<string>(1, data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		new TArrayCopyMarshaler<Flinks>(1, links_PropertyAddress, CachedMarshalingDelegates<Flinks, Flinks>.FromNative, CachedMarshalingDelegates<Flinks, Flinks>.ToNative).ToNative(IntPtr.Add(nativeStruct, links_Offset), links);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, left_Offset), left);
		FSeriesLabel.ToNative(IntPtr.Add(nativeStruct, DataLabel_Offset), DataLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FSankeySeries(IntPtr nativeStruct)
	{
		if (!FSankeySeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.SankeySeries");
			data = null;
			links = null;
			left = 0f;
			DataLabel = default(FSeriesLabel);
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			data = new TArrayCopyMarshaler<string>(1, data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			links = new TArrayCopyMarshaler<Flinks>(1, links_PropertyAddress, CachedMarshalingDelegates<Flinks, Flinks>.FromNative, CachedMarshalingDelegates<Flinks, Flinks>.ToNative).FromNative(IntPtr.Add(nativeStruct, links_Offset));
			left = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, left_Offset));
			DataLabel = FSeriesLabel.FromNative(IntPtr.Add(nativeStruct, DataLabel_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FSankeySeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSankeySeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSankeySeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.SankeySeries");
		FSankeySeries_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref links_PropertyAddress, intPtr, "links");
		links_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "links");
		links_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "links", Classes.FArrayProperty);
		left_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "left");
		left_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "left", Classes.FFloatProperty);
		DataLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataLabel");
		DataLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataLabel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FSankeySeries_IsValid = intPtr != IntPtr.Zero && data_IsValid && links_IsValid && left_IsValid && DataLabel_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.SankeySeries", FSankeySeries_IsValid);
	}
}
