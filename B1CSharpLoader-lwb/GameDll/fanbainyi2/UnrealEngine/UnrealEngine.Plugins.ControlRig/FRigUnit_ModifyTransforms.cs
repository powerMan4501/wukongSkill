using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ModifyTransforms", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ModifyTransforms
{
	private static bool FRigUnit_ModifyTransforms_IsValid;

	private static int FRigUnit_ModifyTransforms_StructSize;

	public FRigUnit_ModifyTransforms Copy()
	{
		return this;
	}

	public static FRigUnit_ModifyTransforms FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ModifyTransforms(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ModifyTransforms value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ModifyTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ModifyTransforms(nativeBuffer + arrayIndex * FRigUnit_ModifyTransforms_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ModifyTransforms value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ModifyTransforms_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ModifyTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ModifyTransforms");
		}
	}

	public FRigUnit_ModifyTransforms(IntPtr nativeStruct)
	{
		if (!FRigUnit_ModifyTransforms_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ModifyTransforms");
		}
	}

	static FRigUnit_ModifyTransforms()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ModifyTransforms)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ModifyTransforms));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ModifyTransforms");
		FRigUnit_ModifyTransforms_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ModifyTransforms_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ModifyTransforms", FRigUnit_ModifyTransforms_IsValid);
	}
}
