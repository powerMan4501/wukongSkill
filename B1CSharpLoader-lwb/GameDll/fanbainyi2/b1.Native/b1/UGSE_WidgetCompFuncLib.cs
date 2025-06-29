using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_WidgetCompFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_WidgetCompFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UnregisterWidgetComponent_IsValid;

	private static IntPtr UnregisterWidgetComponent_FunctionAddress;

	private static int UnregisterWidgetComponent_ParamsSize;

	private static bool UnregisterWidgetComponent_Comp_IsValid;

	private static FFieldAddress UnregisterWidgetComponent_Comp_PropertyAddress;

	private static int UnregisterWidgetComponent_Comp_Offset;

	private static bool RegisterWidgetComponent_IsValid;

	private static IntPtr RegisterWidgetComponent_FunctionAddress;

	private static int RegisterWidgetComponent_ParamsSize;

	private static bool RegisterWidgetComponent_Comp_IsValid;

	private static FFieldAddress RegisterWidgetComponent_Comp_PropertyAddress;

	private static int RegisterWidgetComponent_Comp_Offset;

	private static bool DestoryWidgetComponent_IsValid;

	private static IntPtr DestoryWidgetComponent_FunctionAddress;

	private static int DestoryWidgetComponent_ParamsSize;

	private static bool DestoryWidgetComponent_Comp_IsValid;

	private static FFieldAddress DestoryWidgetComponent_Comp_PropertyAddress;

	private static int DestoryWidgetComponent_Comp_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WidgetCompFuncLib:UnregisterWidgetComponent")]
	public unsafe static void UnregisterWidgetComponent(UWidgetComponent Comp)
	{
		if (!UnregisterWidgetComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WidgetCompFuncLib:UnregisterWidgetComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnregisterWidgetComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnregisterWidgetComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetComponent>.ToNative(IntPtr.Add(intPtr, UnregisterWidgetComponent_Comp_Offset), 0, UnregisterWidgetComponent_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnregisterWidgetComponent_FunctionAddress, intPtr, UnregisterWidgetComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WidgetCompFuncLib:RegisterWidgetComponent")]
	public unsafe static void RegisterWidgetComponent(UWidgetComponent Comp)
	{
		if (!RegisterWidgetComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WidgetCompFuncLib:RegisterWidgetComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterWidgetComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterWidgetComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetComponent>.ToNative(IntPtr.Add(intPtr, RegisterWidgetComponent_Comp_Offset), 0, RegisterWidgetComponent_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterWidgetComponent_FunctionAddress, intPtr, RegisterWidgetComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_WidgetCompFuncLib:DestoryWidgetComponent")]
	public unsafe static void DestoryWidgetComponent(UWidgetComponent Comp)
	{
		if (!DestoryWidgetComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_WidgetCompFuncLib:DestoryWidgetComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DestoryWidgetComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DestoryWidgetComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidgetComponent>.ToNative(IntPtr.Add(intPtr, DestoryWidgetComponent_Comp_Offset), 0, DestoryWidgetComponent_Comp_PropertyAddress.Address, Comp);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DestoryWidgetComponent_FunctionAddress, intPtr, DestoryWidgetComponent_ParamsSize);
	}

	static UGSE_WidgetCompFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_WidgetCompFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_WidgetCompFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_WidgetCompFuncLib");
		UnregisterWidgetComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnregisterWidgetComponent");
		UnregisterWidgetComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(UnregisterWidgetComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnregisterWidgetComponent_Comp_PropertyAddress, UnregisterWidgetComponent_FunctionAddress, "Comp");
		UnregisterWidgetComponent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(UnregisterWidgetComponent_FunctionAddress, "Comp");
		UnregisterWidgetComponent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(UnregisterWidgetComponent_FunctionAddress, "Comp", Classes.FObjectProperty);
		UnregisterWidgetComponent_IsValid = UnregisterWidgetComponent_FunctionAddress != IntPtr.Zero && UnregisterWidgetComponent_Comp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WidgetCompFuncLib:UnregisterWidgetComponent", UnregisterWidgetComponent_IsValid);
		RegisterWidgetComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterWidgetComponent");
		RegisterWidgetComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterWidgetComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterWidgetComponent_Comp_PropertyAddress, RegisterWidgetComponent_FunctionAddress, "Comp");
		RegisterWidgetComponent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(RegisterWidgetComponent_FunctionAddress, "Comp");
		RegisterWidgetComponent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterWidgetComponent_FunctionAddress, "Comp", Classes.FObjectProperty);
		RegisterWidgetComponent_IsValid = RegisterWidgetComponent_FunctionAddress != IntPtr.Zero && RegisterWidgetComponent_Comp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WidgetCompFuncLib:RegisterWidgetComponent", RegisterWidgetComponent_IsValid);
		DestoryWidgetComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DestoryWidgetComponent");
		DestoryWidgetComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(DestoryWidgetComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DestoryWidgetComponent_Comp_PropertyAddress, DestoryWidgetComponent_FunctionAddress, "Comp");
		DestoryWidgetComponent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(DestoryWidgetComponent_FunctionAddress, "Comp");
		DestoryWidgetComponent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(DestoryWidgetComponent_FunctionAddress, "Comp", Classes.FObjectProperty);
		DestoryWidgetComponent_IsValid = DestoryWidgetComponent_FunctionAddress != IntPtr.Zero && DestoryWidgetComponent_Comp_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_WidgetCompFuncLib:DestoryWidgetComponent", DestoryWidgetComponent_IsValid);
	}
}
