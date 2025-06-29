using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_InverseQuaterion", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_InverseQuaterion
{
	private static bool FRigUnit_InverseQuaterion_IsValid;

	private static int FRigUnit_InverseQuaterion_StructSize;

	public FRigUnit_InverseQuaterion Copy()
	{
		return this;
	}

	public static FRigUnit_InverseQuaterion FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_InverseQuaterion(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_InverseQuaterion value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_InverseQuaterion FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_InverseQuaterion(nativeBuffer + arrayIndex * FRigUnit_InverseQuaterion_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_InverseQuaterion value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_InverseQuaterion_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_InverseQuaterion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_InverseQuaterion");
		}
	}

	public FRigUnit_InverseQuaterion(IntPtr nativeStruct)
	{
		if (!FRigUnit_InverseQuaterion_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_InverseQuaterion");
		}
	}

	static FRigUnit_InverseQuaterion()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_InverseQuaterion)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_InverseQuaterion));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_InverseQuaterion");
		FRigUnit_InverseQuaterion_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_InverseQuaterion_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_InverseQuaterion", FRigUnit_InverseQuaterion_IsValid);
	}
}
