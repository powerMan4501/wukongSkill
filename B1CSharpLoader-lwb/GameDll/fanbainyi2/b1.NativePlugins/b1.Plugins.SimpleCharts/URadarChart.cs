using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/SimpleCharts.RadarChart", "SimpleCharts", UnrealModuleType.GamePlugin)]
public class URadarChart : UChartBase
{
	private static bool Series_IsValid;

	private static int Series_Offset;

	private static bool Radar_IsValid;

	private static int Radar_Offset;

	private static bool SetSeries_IsValid;

	private static IntPtr SetSeries_FunctionAddress;

	private static int SetSeries_ParamsSize;

	private static bool SetSeries_SeriesData_IsValid;

	private static FFieldAddress SetSeries_SeriesData_PropertyAddress;

	private static int SetSeries_SeriesData_Offset;

	private static bool SetRadar_IsValid;

	private static IntPtr SetRadar_FunctionAddress;

	private static int SetRadar_ParamsSize;

	private static bool SetRadar_RadarData_IsValid;

	private static FFieldAddress SetRadar_RadarData_PropertyAddress;

	private static int SetRadar_RadarData_Offset;

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
	[UMetaPath("/Script/SimpleCharts.RadarChart:Series")]
	public FRadarSeries Series
	{
		get
		{
			CheckDestroyed();
			if (!Series_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.RadarChart:Series");
				return default(FRadarSeries);
			}
			return FRadarSeries.FromNative(IntPtr.Add(base.Address, Series_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Series_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.RadarChart:Series");
			}
			else
			{
				FRadarSeries.ToNative(IntPtr.Add(base.Address, Series_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.RadarChart:Radar")]
	public FRadar Radar
	{
		get
		{
			CheckDestroyed();
			if (!Radar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.RadarChart:Radar");
				return default(FRadar);
			}
			return FRadar.FromNative(IntPtr.Add(base.Address, Radar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.RadarChart:Radar");
			}
			else
			{
				FRadar.ToNative(IntPtr.Add(base.Address, Radar_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.RadarChart:SetSeries")]
	public unsafe void SetSeries(FRadarSeries SeriesData)
	{
		CheckDestroyed();
		if (!SetSeries_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.RadarChart:SetSeries");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSeries_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSeries_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSeries_SeriesData_PropertyAddress.Address, intPtr);
		FRadarSeries.ToNative(IntPtr.Add(intPtr, SetSeries_SeriesData_Offset), 0, SetSeries_SeriesData_PropertyAddress.Address, SeriesData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSeries_FunctionAddress, intPtr, SetSeries_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSeries_SeriesData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.RadarChart:SetRadar")]
	public unsafe void SetRadar(FRadar RadarData)
	{
		CheckDestroyed();
		if (!SetRadar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.RadarChart:SetRadar");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRadar_RadarData_PropertyAddress.Address, intPtr);
		FRadar.ToNative(IntPtr.Add(intPtr, SetRadar_RadarData_Offset), 0, SetRadar_RadarData_PropertyAddress.Address, RadarData);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadar_FunctionAddress, intPtr, SetRadar_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetRadar_RadarData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/SimpleCharts.RadarChart:SetLegend")]
	public unsafe void SetLegend(bool show, EPosition position, EOrient orient, FLinearColor color, int fontSize)
	{
		CheckDestroyed();
		if (!SetLegend_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.RadarChart:SetLegend");
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

	static URadarChart()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(URadarChart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(URadarChart));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SimpleCharts.RadarChart");
		Series_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Series");
		Series_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Series", Classes.FStructProperty);
		Radar_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radar");
		Radar_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radar", Classes.FStructProperty);
		SetSeries_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSeries");
		SetSeries_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSeries_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSeries_SeriesData_PropertyAddress, SetSeries_FunctionAddress, "SeriesData");
		SetSeries_SeriesData_Offset = NativeReflectionCached.GetPropertyOffset(SetSeries_FunctionAddress, "SeriesData");
		SetSeries_SeriesData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSeries_FunctionAddress, "SeriesData", Classes.FStructProperty);
		SetSeries_IsValid = SetSeries_FunctionAddress != IntPtr.Zero && SetSeries_SeriesData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.RadarChart:SetSeries", SetSeries_IsValid);
		SetRadar_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadar");
		SetRadar_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadar_RadarData_PropertyAddress, SetRadar_FunctionAddress, "RadarData");
		SetRadar_RadarData_Offset = NativeReflectionCached.GetPropertyOffset(SetRadar_FunctionAddress, "RadarData");
		SetRadar_RadarData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadar_FunctionAddress, "RadarData", Classes.FStructProperty);
		SetRadar_IsValid = SetRadar_FunctionAddress != IntPtr.Zero && SetRadar_RadarData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.RadarChart:SetRadar", SetRadar_IsValid);
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
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.RadarChart:SetLegend", SetLegend_IsValid);
	}
}
