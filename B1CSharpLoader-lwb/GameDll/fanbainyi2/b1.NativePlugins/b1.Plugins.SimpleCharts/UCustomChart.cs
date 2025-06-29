using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.SimpleCharts;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/SimpleCharts.CustomChart", "SimpleCharts", UnrealModuleType.GamePlugin)]
public class UCustomChart : UWidget
{
	private static bool useDirtyRect_IsValid;

	private static FFieldAddress useDirtyRect_PropertyAddress;

	private static int useDirtyRect_Offset;

	private static bool Theme_IsValid;

	private static FFieldAddress Theme_PropertyAddress;

	private static int Theme_Offset;

	private static bool Option_IsValid;

	private static int Option_Offset;

	private static bool SetTheme_IsValid;

	private static IntPtr SetTheme_FunctionAddress;

	private static int SetTheme_ParamsSize;

	private static bool SetTheme_ChartTheme_IsValid;

	private static FFieldAddress SetTheme_ChartTheme_PropertyAddress;

	private static int SetTheme_ChartTheme_Offset;

	private static bool SetOption_IsValid;

	private static IntPtr SetOption_FunctionAddress;

	private static int SetOption_ParamsSize;

	private static bool SetOption_InOption_IsValid;

	private static FFieldAddress SetOption_InOption_PropertyAddress;

	private static int SetOption_InOption_Offset;

	private static bool SetOption_OtherCode_IsValid;

	private static FFieldAddress SetOption_OtherCode_PropertyAddress;

	private static int SetOption_OtherCode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.CustomChart:useDirtyRect")]
	public bool useDirtyRect
	{
		get
		{
			CheckDestroyed();
			if (!useDirtyRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.CustomChart:useDirtyRect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, useDirtyRect_Offset), 0, useDirtyRect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!useDirtyRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.CustomChart:useDirtyRect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, useDirtyRect_Offset), 0, useDirtyRect_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.CustomChart:Theme")]
	public EChartTheme Theme
	{
		get
		{
			CheckDestroyed();
			if (!Theme_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.CustomChart:Theme");
				return EChartTheme.Azul;
			}
			return EnumMarshaler<EChartTheme>.FromNative(IntPtr.Add(base.Address, Theme_Offset), 0, Theme_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Theme_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.CustomChart:Theme");
			}
			else
			{
				EnumMarshaler<EChartTheme>.ToNative(IntPtr.Add(base.Address, Theme_Offset), 0, Theme_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.CustomChart:Option")]
	public string Option
	{
		get
		{
			CheckDestroyed();
			if (!Option_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.CustomChart:Option");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Option_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Option_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.CustomChart:Option");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Option_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.CustomChart:SetTheme")]
	public unsafe void SetTheme(EChartTheme ChartTheme)
	{
		CheckDestroyed();
		if (!SetTheme_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.CustomChart:SetTheme");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTheme_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTheme_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EChartTheme>.ToNative(IntPtr.Add(intPtr, SetTheme_ChartTheme_Offset), 0, SetTheme_ChartTheme_PropertyAddress.Address, ChartTheme);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTheme_FunctionAddress, intPtr, SetTheme_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.CustomChart:SetOption")]
	public unsafe void SetOption(string InOption, string OtherCode)
	{
		CheckDestroyed();
		if (!SetOption_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.CustomChart:SetOption");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOption_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOption_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetOption_InOption_Offset), 0, SetOption_InOption_PropertyAddress.Address, InOption);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetOption_OtherCode_Offset), 0, SetOption_OtherCode_PropertyAddress.Address, OtherCode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOption_FunctionAddress, intPtr, SetOption_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetOption_InOption_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetOption_OtherCode_PropertyAddress.Address, intPtr);
	}

	static UCustomChart()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCustomChart)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCustomChart));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SimpleCharts.CustomChart");
		NativeReflectionCached.GetPropertyRef(ref useDirtyRect_PropertyAddress, intPtr, "useDirtyRect");
		useDirtyRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "useDirtyRect");
		useDirtyRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "useDirtyRect", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Theme_PropertyAddress, intPtr, "Theme");
		Theme_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Theme");
		Theme_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Theme", Classes.FEnumProperty);
		Option_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Option");
		Option_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Option", Classes.FStrProperty);
		SetTheme_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTheme");
		SetTheme_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTheme_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTheme_ChartTheme_PropertyAddress, SetTheme_FunctionAddress, "ChartTheme");
		SetTheme_ChartTheme_Offset = NativeReflectionCached.GetPropertyOffset(SetTheme_FunctionAddress, "ChartTheme");
		SetTheme_ChartTheme_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTheme_FunctionAddress, "ChartTheme", Classes.FEnumProperty);
		SetTheme_IsValid = SetTheme_FunctionAddress != IntPtr.Zero && SetTheme_ChartTheme_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.CustomChart:SetTheme", SetTheme_IsValid);
		SetOption_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOption");
		SetOption_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOption_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOption_InOption_PropertyAddress, SetOption_FunctionAddress, "InOption");
		SetOption_InOption_Offset = NativeReflectionCached.GetPropertyOffset(SetOption_FunctionAddress, "InOption");
		SetOption_InOption_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOption_FunctionAddress, "InOption", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOption_OtherCode_PropertyAddress, SetOption_FunctionAddress, "OtherCode");
		SetOption_OtherCode_Offset = NativeReflectionCached.GetPropertyOffset(SetOption_FunctionAddress, "OtherCode");
		SetOption_OtherCode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOption_FunctionAddress, "OtherCode", Classes.FStrProperty);
		SetOption_IsValid = SetOption_FunctionAddress != IntPtr.Zero && SetOption_InOption_IsValid && SetOption_OtherCode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.CustomChart:SetOption", SetOption_IsValid);
	}
}
