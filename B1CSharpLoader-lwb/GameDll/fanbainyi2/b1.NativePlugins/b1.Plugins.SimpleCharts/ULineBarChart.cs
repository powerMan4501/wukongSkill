using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/SimpleCharts.LineBarChart", "SimpleCharts", UnrealModuleType.GamePlugin)]
public class ULineBarChart : UChartBase
{
	private static bool Series_IsValid;

	private static FFieldAddress Series_PropertyAddress;

	private static int Series_Offset;

	private TArrayReadWriteMarshaler<FLineBarSeries> Series_MarshalerCached;

	private static bool SetSeries_IsValid;

	private static IntPtr SetSeries_FunctionAddress;

	private static int SetSeries_ParamsSize;

	private static bool SetSeries_SeriesData_IsValid;

	private static FFieldAddress SetSeries_SeriesData_PropertyAddress;

	private static int SetSeries_SeriesData_Offset;

	private static bool SetLegend_IsValid;

	private static IntPtr SetLegend_FunctionAddress;

	private static int SetLegend_ParamsSize;

	private static bool SetLegend_show_IsValid;

	private static FFieldAddress SetLegend_show_PropertyAddress;

	private static int SetLegend_show_Offset;

	private static bool SetLegend_position_IsValid;

	private static FFieldAddress SetLegend_position_PropertyAddress;

	private static int SetLegend_position_Offset;

	private static bool SetLegend_orient_IsValid;

	private static FFieldAddress SetLegend_orient_PropertyAddress;

	private static int SetLegend_orient_Offset;

	private static bool SetLegend_color_IsValid;

	private static FFieldAddress SetLegend_color_PropertyAddress;

	private static int SetLegend_color_Offset;

	private static bool SetLegend_fontSize_IsValid;

	private static FFieldAddress SetLegend_fontSize_PropertyAddress;

	private static int SetLegend_fontSize_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.LineBarChart:Series")]
	public TArrayReadWrite<FLineBarSeries> Series
	{
		get
		{
			CheckDestroyed();
			if (!Series_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.LineBarChart:Series");
				return null;
			}
			if (Series_MarshalerCached == null)
			{
				Series_MarshalerCached = new TArrayReadWriteMarshaler<FLineBarSeries>(1, Series_PropertyAddress, CachedMarshalingDelegates<FLineBarSeries, FLineBarSeries>.FromNative, CachedMarshalingDelegates<FLineBarSeries, FLineBarSeries>.ToNative);
			}
			return Series_MarshalerCached.FromNative(IntPtr.Add(base.Address, Series_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.LineBarChart:SetSeries")]
	public unsafe void SetSeries(List<FLineBarSeries> SeriesData)
	{
		CheckDestroyed();
		if (!SetSeries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.LineBarChart:SetSeries");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSeries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSeries_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FLineBarSeries>(1, SetSeries_SeriesData_PropertyAddress, CachedMarshalingDelegates<FLineBarSeries, FLineBarSeries>.FromNative, CachedMarshalingDelegates<FLineBarSeries, FLineBarSeries>.ToNative).ToNative(IntPtr.Add(intPtr, SetSeries_SeriesData_Offset), SeriesData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSeries_FunctionAddress, intPtr, SetSeries_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSeries_SeriesData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/SimpleCharts.LineBarChart:SetLegend")]
	public unsafe void SetLegend(bool show, EPosition position, EOrient orient, FLinearColor color, int fontSize)
	{
		CheckDestroyed();
		if (!SetLegend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.LineBarChart:SetLegend");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLegend_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLegend_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLegend_show_Offset), 0, SetLegend_show_PropertyAddress.Address, show);
		EnumMarshaler<EPosition>.ToNative(IntPtr.Add(intPtr, SetLegend_position_Offset), 0, SetLegend_position_PropertyAddress.Address, position);
		EnumMarshaler<EOrient>.ToNative(IntPtr.Add(intPtr, SetLegend_orient_Offset), 0, SetLegend_orient_PropertyAddress.Address, orient);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetLegend_color_Offset), 0, SetLegend_color_PropertyAddress.Address, color);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetLegend_fontSize_Offset), 0, SetLegend_fontSize_PropertyAddress.Address, fontSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLegend_FunctionAddress, intPtr, SetLegend_ParamsSize);
	}

	static ULineBarChart()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULineBarChart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULineBarChart));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SimpleCharts.LineBarChart");
		NativeReflectionCached.GetPropertyRef(ref Series_PropertyAddress, intPtr, "Series");
		Series_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Series");
		Series_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Series", Classes.FArrayProperty);
		SetSeries_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSeries");
		SetSeries_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSeries_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSeries_SeriesData_PropertyAddress, SetSeries_FunctionAddress, "SeriesData");
		SetSeries_SeriesData_Offset = NativeReflectionCached.GetPropertyOffset(SetSeries_FunctionAddress, "SeriesData");
		SetSeries_SeriesData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSeries_FunctionAddress, "SeriesData", Classes.FArrayProperty);
		SetSeries_IsValid = SetSeries_FunctionAddress != IntPtr.Zero && SetSeries_SeriesData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.LineBarChart:SetSeries", SetSeries_IsValid);
		SetLegend_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLegend");
		SetLegend_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLegend_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLegend_show_PropertyAddress, SetLegend_FunctionAddress, "show");
		SetLegend_show_Offset = NativeReflectionCached.GetPropertyOffset(SetLegend_FunctionAddress, "show");
		SetLegend_show_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLegend_FunctionAddress, "show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLegend_position_PropertyAddress, SetLegend_FunctionAddress, "position");
		SetLegend_position_Offset = NativeReflectionCached.GetPropertyOffset(SetLegend_FunctionAddress, "position");
		SetLegend_position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLegend_FunctionAddress, "position", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLegend_orient_PropertyAddress, SetLegend_FunctionAddress, "orient");
		SetLegend_orient_Offset = NativeReflectionCached.GetPropertyOffset(SetLegend_FunctionAddress, "orient");
		SetLegend_orient_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLegend_FunctionAddress, "orient", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLegend_color_PropertyAddress, SetLegend_FunctionAddress, "color");
		SetLegend_color_Offset = NativeReflectionCached.GetPropertyOffset(SetLegend_FunctionAddress, "color");
		SetLegend_color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLegend_FunctionAddress, "color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLegend_fontSize_PropertyAddress, SetLegend_FunctionAddress, "fontSize");
		SetLegend_fontSize_Offset = NativeReflectionCached.GetPropertyOffset(SetLegend_FunctionAddress, "fontSize");
		SetLegend_fontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLegend_FunctionAddress, "fontSize", Classes.FIntProperty);
		SetLegend_IsValid = SetLegend_FunctionAddress != IntPtr.Zero && SetLegend_show_IsValid && SetLegend_position_IsValid && SetLegend_orient_IsValid && SetLegend_color_IsValid && SetLegend_fontSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.LineBarChart:SetLegend", SetLegend_IsValid);
	}
}
