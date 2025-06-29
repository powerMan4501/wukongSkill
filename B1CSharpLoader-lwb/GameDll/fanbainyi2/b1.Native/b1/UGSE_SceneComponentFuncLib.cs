using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SceneComponentFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SceneComponentFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetWorldLocationAndRotationSimple_IsValid;

	private static IntPtr SetWorldLocationAndRotationSimple_FunctionAddress;

	private static int SetWorldLocationAndRotationSimple_ParamsSize;

	private static bool SetWorldLocationAndRotationSimple_InSceneComponent_IsValid;

	private static FFieldAddress SetWorldLocationAndRotationSimple_InSceneComponent_PropertyAddress;

	private static int SetWorldLocationAndRotationSimple_InSceneComponent_Offset;

	private static bool SetWorldLocationAndRotationSimple_Pos_IsValid;

	private static FFieldAddress SetWorldLocationAndRotationSimple_Pos_PropertyAddress;

	private static int SetWorldLocationAndRotationSimple_Pos_Offset;

	private static bool SetWorldLocationAndRotationSimple_Rot_IsValid;

	private static FFieldAddress SetWorldLocationAndRotationSimple_Rot_PropertyAddress;

	private static int SetWorldLocationAndRotationSimple_Rot_Offset;

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SceneComponentFuncLib:SetWorldLocationAndRotationSimple")]
	public unsafe static void SetWorldLocationAndRotationSimple(USceneComponent InSceneComponent, FVector Pos, FRotator Rot)
	{
		if (!SetWorldLocationAndRotationSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SceneComponentFuncLib:SetWorldLocationAndRotationSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldLocationAndRotationSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldLocationAndRotationSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetWorldLocationAndRotationSimple_InSceneComponent_Offset), 0, SetWorldLocationAndRotationSimple_InSceneComponent_PropertyAddress.Address, InSceneComponent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetWorldLocationAndRotationSimple_Pos_Offset), 0, SetWorldLocationAndRotationSimple_Pos_PropertyAddress.Address, Pos);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetWorldLocationAndRotationSimple_Rot_Offset), 0, SetWorldLocationAndRotationSimple_Rot_PropertyAddress.Address, Rot);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetWorldLocationAndRotationSimple_FunctionAddress, intPtr, SetWorldLocationAndRotationSimple_ParamsSize);
	}

	static UGSE_SceneComponentFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SceneComponentFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SceneComponentFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SceneComponentFuncLib");
		SetWorldLocationAndRotationSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetWorldLocationAndRotationSimple");
		SetWorldLocationAndRotationSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldLocationAndRotationSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotationSimple_InSceneComponent_PropertyAddress, SetWorldLocationAndRotationSimple_FunctionAddress, "InSceneComponent");
		SetWorldLocationAndRotationSimple_InSceneComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotationSimple_FunctionAddress, "InSceneComponent");
		SetWorldLocationAndRotationSimple_InSceneComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotationSimple_FunctionAddress, "InSceneComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotationSimple_Pos_PropertyAddress, SetWorldLocationAndRotationSimple_FunctionAddress, "Pos");
		SetWorldLocationAndRotationSimple_Pos_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotationSimple_FunctionAddress, "Pos");
		SetWorldLocationAndRotationSimple_Pos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotationSimple_FunctionAddress, "Pos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetWorldLocationAndRotationSimple_Rot_PropertyAddress, SetWorldLocationAndRotationSimple_FunctionAddress, "Rot");
		SetWorldLocationAndRotationSimple_Rot_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldLocationAndRotationSimple_FunctionAddress, "Rot");
		SetWorldLocationAndRotationSimple_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldLocationAndRotationSimple_FunctionAddress, "Rot", Classes.FStructProperty);
		SetWorldLocationAndRotationSimple_IsValid = SetWorldLocationAndRotationSimple_FunctionAddress != IntPtr.Zero && SetWorldLocationAndRotationSimple_InSceneComponent_IsValid && SetWorldLocationAndRotationSimple_Pos_IsValid && SetWorldLocationAndRotationSimple_Rot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SceneComponentFuncLib:SetWorldLocationAndRotationSimple", SetWorldLocationAndRotationSimple_IsValid);
	}
}
