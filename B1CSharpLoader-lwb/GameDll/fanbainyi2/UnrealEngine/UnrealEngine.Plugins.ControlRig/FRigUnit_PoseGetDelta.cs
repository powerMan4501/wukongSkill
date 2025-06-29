using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseGetDelta", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseGetDelta
{
	private static bool FRigUnit_PoseGetDelta_IsValid;

	private static int FRigUnit_PoseGetDelta_StructSize;

	public FRigUnit_PoseGetDelta Copy()
	{
		return this;
	}

	public static FRigUnit_PoseGetDelta FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseGetDelta(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseGetDelta value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseGetDelta FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseGetDelta(nativeBuffer + arrayIndex * FRigUnit_PoseGetDelta_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseGetDelta value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseGetDelta_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetDelta_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetDelta");
		}
	}

	public FRigUnit_PoseGetDelta(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetDelta_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetDelta");
		}
	}

	static FRigUnit_PoseGetDelta()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseGetDelta)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseGetDelta));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseGetDelta");
		FRigUnit_PoseGetDelta_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseGetDelta_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseGetDelta", FRigUnit_PoseGetDelta_IsValid);
	}
}
