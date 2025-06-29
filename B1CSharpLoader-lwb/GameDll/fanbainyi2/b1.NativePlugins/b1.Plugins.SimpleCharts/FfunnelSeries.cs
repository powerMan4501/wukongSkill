using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.funnelSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FfunnelSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:name")]
	public string name;

	private static bool left_IsValid;

	private static int left_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:left")]
	public float left;

	private static bool width_IsValid;

	private static int width_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:width")]
	public float width;

	private static bool min_IsValid;

	private static int min_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:min")]
	public float min;

	private static bool max_IsValid;

	private static int max_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:max")]
	public float max;

	private static bool minSize_IsValid;

	private static int minSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:minSize")]
	public float minSize;

	private static bool maxSize_IsValid;

	private static int maxSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:maxSize")]
	public float maxSize;

	private static bool gap_IsValid;

	private static int gap_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:gap")]
	public float gap;

	private static bool label_show_IsValid;

	private static FFieldAddress label_show_PropertyAddress;

	private static int label_show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:label_show")]
	public bool label_show;

	private static bool label_Position_IsValid;

	private static FFieldAddress label_Position_PropertyAddress;

	private static int label_Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:label_Position")]
	public EPosition label_Position;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.funnelSeries:data")]
	public List<FfunnelData> data;

	private static bool FfunnelSeries_IsValid;

	private static int FfunnelSeries_StructSize;

	public FfunnelSeries Copy()
	{
		FfunnelSeries result = this;
		if (data != null)
		{
			result.data = new List<FfunnelData>(data);
		}
		return result;
	}

	public static FfunnelSeries FromNative(IntPtr nativeBuffer)
	{
		return new FfunnelSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FfunnelSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FfunnelSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FfunnelSeries(nativeBuffer + arrayIndex * FfunnelSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FfunnelSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FfunnelSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FfunnelSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.funnelSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, left_Offset), left);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, width_Offset), width);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, min_Offset), min);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, max_Offset), max);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, minSize_Offset), minSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, maxSize_Offset), maxSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, gap_Offset), gap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, label_show_Offset), 0, label_show_PropertyAddress.Address, label_show);
		EnumMarshaler<EPosition>.ToNative(IntPtr.Add(nativeStruct, label_Position_Offset), 0, label_Position_PropertyAddress.Address, label_Position);
		new TArrayCopyMarshaler<FfunnelData>(1, data_PropertyAddress, CachedMarshalingDelegates<FfunnelData, FfunnelData>.FromNative, CachedMarshalingDelegates<FfunnelData, FfunnelData>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
	}

	public FfunnelSeries(IntPtr nativeStruct)
	{
		if (!FfunnelSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.funnelSeries");
			name = FStringMarshaler.DefaultString;
			left = 0f;
			width = 0f;
			min = 0f;
			max = 0f;
			minSize = 0f;
			maxSize = 0f;
			gap = 0f;
			label_show = false;
			label_Position = EPosition.Center;
			data = null;
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			left = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, left_Offset));
			width = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, width_Offset));
			min = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, min_Offset));
			max = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, max_Offset));
			minSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, minSize_Offset));
			maxSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, maxSize_Offset));
			gap = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, gap_Offset));
			label_show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, label_show_Offset), 0, label_show_PropertyAddress.Address);
			label_Position = EnumMarshaler<EPosition>.FromNative(IntPtr.Add(nativeStruct, label_Position_Offset), 0, label_Position_PropertyAddress.Address);
			data = new TArrayCopyMarshaler<FfunnelData>(1, data_PropertyAddress, CachedMarshalingDelegates<FfunnelData, FfunnelData>.FromNative, CachedMarshalingDelegates<FfunnelData, FfunnelData>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
		}
	}

	static FfunnelSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FfunnelSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FfunnelSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.funnelSeries");
		FfunnelSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		left_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "left");
		left_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "left", Classes.FFloatProperty);
		width_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "width");
		width_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "width", Classes.FFloatProperty);
		min_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "min");
		min_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "min", Classes.FFloatProperty);
		max_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "max");
		max_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "max", Classes.FFloatProperty);
		minSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "minSize");
		minSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "minSize", Classes.FFloatProperty);
		maxSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "maxSize");
		maxSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "maxSize", Classes.FFloatProperty);
		gap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "gap");
		gap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "gap", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref label_show_PropertyAddress, intPtr, "label_show");
		label_show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "label_show");
		label_show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "label_show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref label_Position_PropertyAddress, intPtr, "label_Position");
		label_Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "label_Position");
		label_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "label_Position", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		FfunnelSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && left_IsValid && width_IsValid && min_IsValid && max_IsValid && minSize_IsValid && maxSize_IsValid && gap_IsValid && label_show_IsValid && label_Position_IsValid && data_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.funnelSeries", FfunnelSeries_IsValid);
	}
}
