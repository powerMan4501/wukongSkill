using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/SimpleCharts.DoughnutChart", "SimpleCharts", UnrealModuleType.GamePlugin)]
public class UDoughnutChart : UChartBase
{
	private static bool Series_IsValid;

	private static int Series_Offset;

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

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.DoughnutChart:Series")]
	public FDoughnutSeries Series
	{
		get
		{
			CheckDestroyed();
			if (!Series_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.DoughnutChart:Series");
				return default(FDoughnutSeries);
			}
			return FDoughnutSeries.FromNative(IntPtr.Add(base.Address, Series_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Series_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.DoughnutChart:Series");
			}
			else
			{
				FDoughnutSeries.ToNative(IntPtr.Add(base.Address, Series_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.DoughnutChart:SetSeries")]
	public unsafe void SetSeries(FDoughnutSeries SeriesData)
	{
		CheckDestroyed();
		if (!SetSeries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.DoughnutChart:SetSeries");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSeries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSeries_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSeries_SeriesData_PropertyAddress.Address, intPtr);
		FDoughnutSeries.ToNative(IntPtr.Add(intPtr, SetSeries_SeriesData_Offset), 0, SetSeries_SeriesData_PropertyAddress.Address, SeriesData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSeries_FunctionAddress, intPtr, SetSeries_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSeries_SeriesData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/SimpleCharts.DoughnutChart:SetLegend")]
	public unsafe void SetLegend(bool show, EPosition position, EOrient orient, FLinearColor color, int fontSize)
	{
		CheckDestroyed();
		if (!SetLegend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.DoughnutChart:SetLegend");
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

	static UDoughnutChart()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDoughnutChart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDoughnutChart));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SimpleCharts.DoughnutChart");
		Series_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Series");
		Series_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Series", Classes.FStructProperty);
		SetSeries_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSeries");
		SetSeries_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSeries_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSeries_SeriesData_PropertyAddress, SetSeries_FunctionAddress, "SeriesData");
		SetSeries_SeriesData_Offset = NativeReflectionCached.GetPropertyOffset(SetSeries_FunctionAddress, "SeriesData");
		SetSeries_SeriesData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSeries_FunctionAddress, "SeriesData", Classes.FStructProperty);
		SetSeries_IsValid = SetSeries_FunctionAddress != IntPtr.Zero && SetSeries_SeriesData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.DoughnutChart:SetSeries", SetSeries_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.DoughnutChart:SetLegend", SetLegend_IsValid);
	}
}
