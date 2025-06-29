using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.GaugeSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FGaugeSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.GaugeSeries:name")]
	public string name;

	private static bool min_IsValid;

	private static int min_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.GaugeSeries:min")]
	public float min;

	private static bool max_IsValid;

	private static int max_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.GaugeSeries:max")]
	public float max;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.GaugeSeries:data")]
	public List<FGaugeData> data;

	private static bool FGaugeSeries_IsValid;

	private static int FGaugeSeries_StructSize;

	public FGaugeSeries Copy()
	{
		FGaugeSeries result = this;
		if (data != null)
		{
			result.data = new List<FGaugeData>(data);
		}
		return result;
	}

	public static FGaugeSeries FromNative(IntPtr nativeBuffer)
	{
		return new FGaugeSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGaugeSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGaugeSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGaugeSeries(nativeBuffer + arrayIndex * FGaugeSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGaugeSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGaugeSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGaugeSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.GaugeSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, min_Offset), min);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, max_Offset), max);
		new TArrayCopyMarshaler<FGaugeData>(1, data_PropertyAddress, CachedMarshalingDelegates<FGaugeData, FGaugeData>.FromNative, CachedMarshalingDelegates<FGaugeData, FGaugeData>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
	}

	public FGaugeSeries(IntPtr nativeStruct)
	{
		if (!FGaugeSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.GaugeSeries");
			name = FStringMarshaler.DefaultString;
			min = 0f;
			max = 0f;
			data = null;
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			min = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, min_Offset));
			max = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, max_Offset));
			data = new TArrayCopyMarshaler<FGaugeData>(1, data_PropertyAddress, CachedMarshalingDelegates<FGaugeData, FGaugeData>.FromNative, CachedMarshalingDelegates<FGaugeData, FGaugeData>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
		}
	}

	static FGaugeSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGaugeSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGaugeSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.GaugeSeries");
		FGaugeSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		min_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "min");
		min_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "min", Classes.FFloatProperty);
		max_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "max");
		max_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "max", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		FGaugeSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && min_IsValid && max_IsValid && data_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.GaugeSeries", FGaugeSeries_IsValid);
	}
}
