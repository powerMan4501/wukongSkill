using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertRotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertRotation
{
	private static bool FRigUnit_ConvertRotation_IsValid;

	private static int FRigUnit_ConvertRotation_StructSize;

	public FRigUnit_ConvertRotation Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertRotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertRotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertRotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertRotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertRotation(nativeBuffer + arrayIndex * FRigUnit_ConvertRotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertRotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertRotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertRotation");
		}
	}

	public FRigUnit_ConvertRotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertRotation");
		}
	}

	static FRigUnit_ConvertRotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertRotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertRotation");
		FRigUnit_ConvertRotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertRotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertRotation", FRigUnit_ConvertRotation_IsValid);
	}
}
