using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Water.NiagaraWaterFunctionLibrary", "Water", UnrealModuleType.EnginePlugin)]
public class UNiagaraWaterFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetWaterBodyComponent_IsValid;

	private static IntPtr SetWaterBodyComponent_FunctionAddress;

	private static int SetWaterBodyComponent_ParamsSize;

	private static bool SetWaterBodyComponent_NiagaraSystem_IsValid;

	private static FFieldAddress SetWaterBodyComponent_NiagaraSystem_PropertyAddress;

	private static int SetWaterBodyComponent_NiagaraSystem_Offset;

	private static bool SetWaterBodyComponent_OverrideName_IsValid;

	private static FFieldAddress SetWaterBodyComponent_OverrideName_PropertyAddress;

	private static int SetWaterBodyComponent_OverrideName_Offset;

	private static bool SetWaterBodyComponent_WaterBodyComponent_IsValid;

	private static FFieldAddress SetWaterBodyComponent_WaterBodyComponent_PropertyAddress;

	private static int SetWaterBodyComponent_WaterBodyComponent_Offset;

	[UFunction(Flags = 67380225u)]
	[UMetaPath("/Script/Water.NiagaraWaterFunctionLibrary:SetWaterBodyComponent")]
	public unsafe static void SetWaterBodyComponent(UNiagaraComponent NiagaraSystem, string OverrideName, UWaterBodyComponent WaterBodyComponent)
	{
		if (!SetWaterBodyComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.NiagaraWaterFunctionLibrary:SetWaterBodyComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWaterBodyComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWaterBodyComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, SetWaterBodyComponent_NiagaraSystem_Offset), 0, SetWaterBodyComponent_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetWaterBodyComponent_OverrideName_Offset), 0, SetWaterBodyComponent_OverrideName_PropertyAddress.Address, OverrideName);
		UObjectMarshaler<UWaterBodyComponent>.ToNative(IntPtr.Add(intPtr, SetWaterBodyComponent_WaterBodyComponent_Offset), 0, SetWaterBodyComponent_WaterBodyComponent_PropertyAddress.Address, WaterBodyComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWaterBodyComponent_FunctionAddress, intPtr, SetWaterBodyComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetWaterBodyComponent_OverrideName_PropertyAddress.Address, intPtr);
	}

	static UNiagaraWaterFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraWaterFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraWaterFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Water.NiagaraWaterFunctionLibrary");
		SetWaterBodyComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWaterBodyComponent");
		SetWaterBodyComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWaterBodyComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWaterBodyComponent_NiagaraSystem_PropertyAddress, SetWaterBodyComponent_FunctionAddress, "NiagaraSystem");
		SetWaterBodyComponent_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(SetWaterBodyComponent_FunctionAddress, "NiagaraSystem");
		SetWaterBodyComponent_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaterBodyComponent_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaterBodyComponent_OverrideName_PropertyAddress, SetWaterBodyComponent_FunctionAddress, "OverrideName");
		SetWaterBodyComponent_OverrideName_Offset = NativeReflectionCached.GetPropertyOffset(SetWaterBodyComponent_FunctionAddress, "OverrideName");
		SetWaterBodyComponent_OverrideName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaterBodyComponent_FunctionAddress, "OverrideName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWaterBodyComponent_WaterBodyComponent_PropertyAddress, SetWaterBodyComponent_FunctionAddress, "WaterBodyComponent");
		SetWaterBodyComponent_WaterBodyComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetWaterBodyComponent_FunctionAddress, "WaterBodyComponent");
		SetWaterBodyComponent_WaterBodyComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaterBodyComponent_FunctionAddress, "WaterBodyComponent", Classes.FObjectProperty);
		SetWaterBodyComponent_IsValid = SetWaterBodyComponent_FunctionAddress != IntPtr.Zero && SetWaterBodyComponent_NiagaraSystem_IsValid && SetWaterBodyComponent_OverrideName_IsValid && SetWaterBodyComponent_WaterBodyComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.NiagaraWaterFunctionLibrary:SetWaterBodyComponent", SetWaterBodyComponent_IsValid);
	}
}
