using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ToSwingAndTwist", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ToSwingAndTwist
{
	private static bool FRigUnit_ToSwingAndTwist_IsValid;

	private static int FRigUnit_ToSwingAndTwist_StructSize;

	public FRigUnit_ToSwingAndTwist Copy()
	{
		return this;
	}

	public static FRigUnit_ToSwingAndTwist FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ToSwingAndTwist(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ToSwingAndTwist value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ToSwingAndTwist FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ToSwingAndTwist(nativeBuffer + arrayIndex * FRigUnit_ToSwingAndTwist_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ToSwingAndTwist value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ToSwingAndTwist_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToSwingAndTwist_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToSwingAndTwist");
		}
	}

	public FRigUnit_ToSwingAndTwist(IntPtr nativeStruct)
	{
		if (!FRigUnit_ToSwingAndTwist_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ToSwingAndTwist");
		}
	}

	static FRigUnit_ToSwingAndTwist()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ToSwingAndTwist)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ToSwingAndTwist));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ToSwingAndTwist");
		FRigUnit_ToSwingAndTwist_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ToSwingAndTwist_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ToSwingAndTwist", FRigUnit_ToSwingAndTwist_IsValid);
	}
}
