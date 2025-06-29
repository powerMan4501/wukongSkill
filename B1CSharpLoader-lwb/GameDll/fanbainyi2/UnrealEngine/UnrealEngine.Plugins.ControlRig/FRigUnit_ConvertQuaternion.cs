using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertQuaternion", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertQuaternion
{
	private static bool FRigUnit_ConvertQuaternion_IsValid;

	private static int FRigUnit_ConvertQuaternion_StructSize;

	public FRigUnit_ConvertQuaternion Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertQuaternion FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertQuaternion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertQuaternion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertQuaternion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertQuaternion(nativeBuffer + arrayIndex * FRigUnit_ConvertQuaternion_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertQuaternion value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertQuaternion_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertQuaternion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertQuaternion");
		}
	}

	public FRigUnit_ConvertQuaternion(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertQuaternion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertQuaternion");
		}
	}

	static FRigUnit_ConvertQuaternion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertQuaternion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertQuaternion));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertQuaternion");
		FRigUnit_ConvertQuaternion_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertQuaternion_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertQuaternion", FRigUnit_ConvertQuaternion_IsValid);
	}
}
