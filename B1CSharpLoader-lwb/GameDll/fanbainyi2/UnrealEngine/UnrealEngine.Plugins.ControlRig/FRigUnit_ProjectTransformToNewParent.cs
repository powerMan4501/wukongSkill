using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ProjectTransformToNewParent", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ProjectTransformToNewParent
{
	private static bool FRigUnit_ProjectTransformToNewParent_IsValid;

	private static int FRigUnit_ProjectTransformToNewParent_StructSize;

	public FRigUnit_ProjectTransformToNewParent Copy()
	{
		return this;
	}

	public static FRigUnit_ProjectTransformToNewParent FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ProjectTransformToNewParent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ProjectTransformToNewParent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ProjectTransformToNewParent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ProjectTransformToNewParent(nativeBuffer + arrayIndex * FRigUnit_ProjectTransformToNewParent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ProjectTransformToNewParent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ProjectTransformToNewParent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ProjectTransformToNewParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ProjectTransformToNewParent");
		}
	}

	public FRigUnit_ProjectTransformToNewParent(IntPtr nativeStruct)
	{
		if (!FRigUnit_ProjectTransformToNewParent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ProjectTransformToNewParent");
		}
	}

	static FRigUnit_ProjectTransformToNewParent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ProjectTransformToNewParent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ProjectTransformToNewParent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ProjectTransformToNewParent");
		FRigUnit_ProjectTransformToNewParent_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ProjectTransformToNewParent_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ProjectTransformToNewParent", FRigUnit_ProjectTransformToNewParent_IsValid);
	}
}
