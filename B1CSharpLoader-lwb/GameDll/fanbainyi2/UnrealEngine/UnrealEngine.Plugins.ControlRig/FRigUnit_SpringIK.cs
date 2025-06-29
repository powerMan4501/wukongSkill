using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SpringIK", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SpringIK
{
	private static bool FRigUnit_SpringIK_IsValid;

	private static int FRigUnit_SpringIK_StructSize;

	public FRigUnit_SpringIK Copy()
	{
		return this;
	}

	public static FRigUnit_SpringIK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SpringIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SpringIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SpringIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SpringIK(nativeBuffer + arrayIndex * FRigUnit_SpringIK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SpringIK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SpringIK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringIK");
		}
	}

	public FRigUnit_SpringIK(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringIK");
		}
	}

	static FRigUnit_SpringIK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SpringIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SpringIK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SpringIK");
		FRigUnit_SpringIK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SpringIK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SpringIK", FRigUnit_SpringIK_IsValid);
	}
}
