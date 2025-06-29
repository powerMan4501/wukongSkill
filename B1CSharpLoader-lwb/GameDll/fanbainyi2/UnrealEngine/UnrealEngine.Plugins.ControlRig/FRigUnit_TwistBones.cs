using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TwistBones", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TwistBones
{
	private static bool FRigUnit_TwistBones_IsValid;

	private static int FRigUnit_TwistBones_StructSize;

	public FRigUnit_TwistBones Copy()
	{
		return this;
	}

	public static FRigUnit_TwistBones FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TwistBones(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TwistBones value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TwistBones FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TwistBones(nativeBuffer + arrayIndex * FRigUnit_TwistBones_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TwistBones value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TwistBones_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwistBones_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwistBones");
		}
	}

	public FRigUnit_TwistBones(IntPtr nativeStruct)
	{
		if (!FRigUnit_TwistBones_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TwistBones");
		}
	}

	static FRigUnit_TwistBones()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TwistBones)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TwistBones));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TwistBones");
		FRigUnit_TwistBones_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TwistBones_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TwistBones", FRigUnit_TwistBones_IsValid);
	}
}
