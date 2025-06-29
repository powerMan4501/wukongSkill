using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertVectorToRotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertVectorToRotation
{
	private static bool FRigUnit_ConvertVectorToRotation_IsValid;

	private static int FRigUnit_ConvertVectorToRotation_StructSize;

	public FRigUnit_ConvertVectorToRotation Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertVectorToRotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertVectorToRotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertVectorToRotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertVectorToRotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertVectorToRotation(nativeBuffer + arrayIndex * FRigUnit_ConvertVectorToRotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertVectorToRotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertVectorToRotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertVectorToRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertVectorToRotation");
		}
	}

	public FRigUnit_ConvertVectorToRotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertVectorToRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertVectorToRotation");
		}
	}

	static FRigUnit_ConvertVectorToRotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertVectorToRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertVectorToRotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertVectorToRotation");
		FRigUnit_ConvertVectorToRotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertVectorToRotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertVectorToRotation", FRigUnit_ConvertVectorToRotation_IsValid);
	}
}
