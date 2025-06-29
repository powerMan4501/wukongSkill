using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MultiplyQuaternion", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MultiplyQuaternion
{
	private static bool FRigUnit_MultiplyQuaternion_IsValid;

	private static int FRigUnit_MultiplyQuaternion_StructSize;

	public FRigUnit_MultiplyQuaternion Copy()
	{
		return this;
	}

	public static FRigUnit_MultiplyQuaternion FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MultiplyQuaternion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MultiplyQuaternion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MultiplyQuaternion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MultiplyQuaternion(nativeBuffer + arrayIndex * FRigUnit_MultiplyQuaternion_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MultiplyQuaternion value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MultiplyQuaternion_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MultiplyQuaternion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MultiplyQuaternion");
		}
	}

	public FRigUnit_MultiplyQuaternion(IntPtr nativeStruct)
	{
		if (!FRigUnit_MultiplyQuaternion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MultiplyQuaternion");
		}
	}

	static FRigUnit_MultiplyQuaternion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MultiplyQuaternion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MultiplyQuaternion));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MultiplyQuaternion");
		FRigUnit_MultiplyQuaternion_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MultiplyQuaternion_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MultiplyQuaternion", FRigUnit_MultiplyQuaternion_IsValid);
	}
}
