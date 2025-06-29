using System;
using System.Runtime.CompilerServices;
using UnrealEngine.ClothingSystemRuntimeInterface;
using UnrealEngine.Runtime;

namespace UnrealEngine.ClothingSystemRuntimeNv;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv", "ClothingSystemRuntimeNv", UnrealModuleType.Engine)]
public class UClothingSimulationInteractorNv : UClothingSimulationInteractor
{
	private static bool SetAnimDriveDamperStiffness_IsValid;

	private static IntPtr SetAnimDriveDamperStiffness_FunctionAddress;

	private static int SetAnimDriveDamperStiffness_ParamsSize;

	private static bool SetAnimDriveDamperStiffness_InStiffness_IsValid;

	private static FFieldAddress SetAnimDriveDamperStiffness_InStiffness_PropertyAddress;

	private static int SetAnimDriveDamperStiffness_InStiffness_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv:SetAnimDriveDamperStiffness")]
	public unsafe void SetAnimDriveDamperStiffness(float InStiffness)
	{
		CheckDestroyed();
		if (!SetAnimDriveDamperStiffness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv:SetAnimDriveDamperStiffness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnimDriveDamperStiffness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnimDriveDamperStiffness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetAnimDriveDamperStiffness_InStiffness_Offset), 0, SetAnimDriveDamperStiffness_InStiffness_PropertyAddress.Address, InStiffness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnimDriveDamperStiffness_FunctionAddress, intPtr, SetAnimDriveDamperStiffness_ParamsSize);
	}

	static UClothingSimulationInteractorNv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UClothingSimulationInteractorNv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UClothingSimulationInteractorNv));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv");
		SetAnimDriveDamperStiffness_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAnimDriveDamperStiffness");
		SetAnimDriveDamperStiffness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnimDriveDamperStiffness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnimDriveDamperStiffness_InStiffness_PropertyAddress, SetAnimDriveDamperStiffness_FunctionAddress, "InStiffness");
		SetAnimDriveDamperStiffness_InStiffness_Offset = NativeReflectionCached.GetPropertyOffset(SetAnimDriveDamperStiffness_FunctionAddress, "InStiffness");
		SetAnimDriveDamperStiffness_InStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnimDriveDamperStiffness_FunctionAddress, "InStiffness", Classes.FFloatProperty);
		SetAnimDriveDamperStiffness_IsValid = SetAnimDriveDamperStiffness_FunctionAddress != IntPtr.Zero && SetAnimDriveDamperStiffness_InStiffness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ClothingSystemRuntimeNv.ClothingSimulationInteractorNv:SetAnimDriveDamperStiffness", SetAnimDriveDamperStiffness_IsValid);
	}
}
