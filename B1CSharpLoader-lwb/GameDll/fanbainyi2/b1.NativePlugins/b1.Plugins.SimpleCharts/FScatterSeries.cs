using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.ScatterSeries", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FScatterSeries
{
	private static bool name_IsValid;

	private static int name_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.ScatterSeries:name")]
	public string name;

	private static bool data_IsValid;

	private static FFieldAddress data_PropertyAddress;

	private static int data_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.ScatterSeries:data")]
	public List<FVector2D> data;

	private static bool symbolSize_IsValid;

	private static int symbolSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ScatterSeries:symbolSize")]
	public float symbolSize;

	private static bool DataLabel_IsValid;

	private static int DataLabel_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.ScatterSeries:DataLabel")]
	public FSeriesLabel DataLabel;

	private static bool UseGradientColor_IsValid;

	private static FFieldAddress UseGradientColor_PropertyAddress;

	private static int UseGradientColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ScatterSeries:UseGradientColor")]
	public bool UseGradientColor;

	private static bool LinearGradient_IsValid;

	private static int LinearGradient_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.ScatterSeries:LinearGradient")]
	public FLinearGradient LinearGradient;

	private static bool FScatterSeries_IsValid;

	private static int FScatterSeries_StructSize;

	public FScatterSeries Copy()
	{
		FScatterSeries result = this;
		if (data != null)
		{
			result.data = new List<FVector2D>(data);
		}
		return result;
	}

	public static FScatterSeries FromNative(IntPtr nativeBuffer)
	{
		return new FScatterSeries(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FScatterSeries value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FScatterSeries FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FScatterSeries(nativeBuffer + arrayIndex * FScatterSeries_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FScatterSeries value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FScatterSeries_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FScatterSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.ScatterSeries");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, name_Offset), name);
		new TArrayCopyMarshaler<FVector2D>(1, data_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).ToNative(IntPtr.Add(nativeStruct, data_Offset), data);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, symbolSize_Offset), symbolSize);
		FSeriesLabel.ToNative(IntPtr.Add(nativeStruct, DataLabel_Offset), DataLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address, UseGradientColor);
		FLinearGradient.ToNative(IntPtr.Add(nativeStruct, LinearGradient_Offset), LinearGradient);
	}

	public FScatterSeries(IntPtr nativeStruct)
	{
		if (!FScatterSeries_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.ScatterSeries");
			name = FStringMarshaler.DefaultString;
			data = null;
			symbolSize = 0f;
			DataLabel = default(FSeriesLabel);
			UseGradientColor = false;
			LinearGradient = default(FLinearGradient);
		}
		else
		{
			name = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, name_Offset));
			data = new TArrayCopyMarshaler<FVector2D>(1, data_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative).FromNative(IntPtr.Add(nativeStruct, data_Offset));
			symbolSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, symbolSize_Offset));
			DataLabel = FSeriesLabel.FromNative(IntPtr.Add(nativeStruct, DataLabel_Offset));
			UseGradientColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseGradientColor_Offset), 0, UseGradientColor_PropertyAddress.Address);
			LinearGradient = FLinearGradient.FromNative(IntPtr.Add(nativeStruct, LinearGradient_Offset));
		}
	}

	static FScatterSeries()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FScatterSeries)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FScatterSeries));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.ScatterSeries");
		FScatterSeries_StructSize = NativeReflection.GetStructSize(intPtr);
		name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "name");
		name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref data_PropertyAddress, intPtr, "data");
		data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "data");
		data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "data", Classes.FArrayProperty);
		symbolSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "symbolSize");
		symbolSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "symbolSize", Classes.FFloatProperty);
		DataLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DataLabel");
		DataLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DataLabel", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseGradientColor_PropertyAddress, intPtr, "UseGradientColor");
		UseGradientColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseGradientColor");
		UseGradientColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseGradientColor", Classes.FBoolProperty);
		LinearGradient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinearGradient");
		LinearGradient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinearGradient", Classes.FStructProperty);
		FScatterSeries_IsValid = intPtr != IntPtr.Zero && name_IsValid && data_IsValid && symbolSize_IsValid && DataLabel_IsValid && UseGradientColor_IsValid && LinearGradient_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.ScatterSeries", FScatterSeries_IsValid);
	}
}
