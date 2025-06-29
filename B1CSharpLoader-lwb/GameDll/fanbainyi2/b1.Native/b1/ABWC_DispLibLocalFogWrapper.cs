using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BWC_DispLibLocalFogWrapper", "b1", UnrealModuleType.Game)]
public class ABWC_DispLibLocalFogWrapper : AActor
{
	private static bool SetLocalFogParameter_IsValid;

	private IntPtr SetLocalFogParameter_InstanceFunctionAddress;

	private static IntPtr SetLocalFogParameter_FunctionAddress;

	private static int SetLocalFogParameter_ParamsSize;

	private static bool SetLocalFogParameter_InSettings_IsValid;

	private static FFieldAddress SetLocalFogParameter_InSettings_PropertyAddress;

	private static int SetLocalFogParameter_InSettings_Offset;

	private static bool SetLocalFogParameter_WindDir_IsValid;

	private static FFieldAddress SetLocalFogParameter_WindDir_PropertyAddress;

	private static int SetLocalFogParameter_WindDir_Offset;

	[UFunction(Flags = 146934784u)]
	[UMetaPath("/Script/b1.BWC_DispLibLocalFogWrapper:SetLocalFogParameter")]
	public unsafe void SetLocalFogParameter(FBWC_DispLibEnvSettings InSettings, FVector2D WindDir)
	{
		CheckDestroyed();
		if (!SetLocalFogParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibLocalFogWrapper:SetLocalFogParameter");
			return;
		}
		if (SetLocalFogParameter_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetLocalFogParameter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetLocalFogParameter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalFogParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalFogParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLocalFogParameter_InSettings_PropertyAddress.Address, intPtr);
		FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(intPtr, SetLocalFogParameter_InSettings_Offset), 0, SetLocalFogParameter_InSettings_PropertyAddress.Address, InSettings);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetLocalFogParameter_WindDir_Offset), 0, SetLocalFogParameter_WindDir_PropertyAddress.Address, WindDir);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocalFogParameter_InstanceFunctionAddress, intPtr, SetLocalFogParameter_ParamsSize);
	}

	protected unsafe virtual void SetLocalFogParameter_Implementation(FBWC_DispLibEnvSettings InSettings, FVector2D WindDir)
	{
		CheckDestroyed();
		if (!SetLocalFogParameter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibLocalFogWrapper:SetLocalFogParameter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalFogParameter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalFogParameter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLocalFogParameter_InSettings_PropertyAddress.Address, intPtr);
		FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(intPtr, SetLocalFogParameter_InSettings_Offset), 0, SetLocalFogParameter_InSettings_PropertyAddress.Address, InSettings);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetLocalFogParameter_WindDir_Offset), 0, SetLocalFogParameter_WindDir_PropertyAddress.Address, WindDir);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLocalFogParameter_FunctionAddress, intPtr, SetLocalFogParameter_ParamsSize);
	}

	static ABWC_DispLibLocalFogWrapper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABWC_DispLibLocalFogWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABWC_DispLibLocalFogWrapper));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BWC_DispLibLocalFogWrapper");
		SetLocalFogParameter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLocalFogParameter");
		SetLocalFogParameter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalFogParameter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalFogParameter_InSettings_PropertyAddress, SetLocalFogParameter_FunctionAddress, "InSettings");
		SetLocalFogParameter_InSettings_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalFogParameter_FunctionAddress, "InSettings");
		SetLocalFogParameter_InSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalFogParameter_FunctionAddress, "InSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalFogParameter_WindDir_PropertyAddress, SetLocalFogParameter_FunctionAddress, "WindDir");
		SetLocalFogParameter_WindDir_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalFogParameter_FunctionAddress, "WindDir");
		SetLocalFogParameter_WindDir_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalFogParameter_FunctionAddress, "WindDir", Classes.FStructProperty);
		SetLocalFogParameter_IsValid = SetLocalFogParameter_FunctionAddress != IntPtr.Zero && SetLocalFogParameter_InSettings_IsValid && SetLocalFogParameter_WindDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibLocalFogWrapper:SetLocalFogParameter", SetLocalFogParameter_IsValid);
	}
}
