using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ConvertVectorRotation", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ConvertVectorRotation
{
	private static bool FRigUnit_ConvertVectorRotation_IsValid;

	private static int FRigUnit_ConvertVectorRotation_StructSize;

	public FRigUnit_ConvertVectorRotation Copy()
	{
		return this;
	}

	public static FRigUnit_ConvertVectorRotation FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ConvertVectorRotation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ConvertVectorRotation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ConvertVectorRotation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ConvertVectorRotation(nativeBuffer + arrayIndex * FRigUnit_ConvertVectorRotation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ConvertVectorRotation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ConvertVectorRotation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertVectorRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertVectorRotation");
		}
	}

	public FRigUnit_ConvertVectorRotation(IntPtr nativeStruct)
	{
		if (!FRigUnit_ConvertVectorRotation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ConvertVectorRotation");
		}
	}

	static FRigUnit_ConvertVectorRotation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ConvertVectorRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ConvertVectorRotation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ConvertVectorRotation");
		FRigUnit_ConvertVectorRotation_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ConvertVectorRotation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ConvertVectorRotation", FRigUnit_ConvertVectorRotation_IsValid);
	}
}
