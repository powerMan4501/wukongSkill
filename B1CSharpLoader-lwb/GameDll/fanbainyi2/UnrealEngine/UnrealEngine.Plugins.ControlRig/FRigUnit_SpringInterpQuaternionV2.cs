using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SpringInterpQuaternionV2", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SpringInterpQuaternionV2
{
	private static bool FRigUnit_SpringInterpQuaternionV2_IsValid;

	private static int FRigUnit_SpringInterpQuaternionV2_StructSize;

	public FRigUnit_SpringInterpQuaternionV2 Copy()
	{
		return this;
	}

	public static FRigUnit_SpringInterpQuaternionV2 FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SpringInterpQuaternionV2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SpringInterpQuaternionV2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SpringInterpQuaternionV2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SpringInterpQuaternionV2(nativeBuffer + arrayIndex * FRigUnit_SpringInterpQuaternionV2_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SpringInterpQuaternionV2 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SpringInterpQuaternionV2_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpQuaternionV2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpQuaternionV2");
		}
	}

	public FRigUnit_SpringInterpQuaternionV2(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpQuaternionV2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpQuaternionV2");
		}
	}

	static FRigUnit_SpringInterpQuaternionV2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SpringInterpQuaternionV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SpringInterpQuaternionV2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SpringInterpQuaternionV2");
		FRigUnit_SpringInterpQuaternionV2_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SpringInterpQuaternionV2_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SpringInterpQuaternionV2", FRigUnit_SpringInterpQuaternionV2_IsValid);
	}
}
