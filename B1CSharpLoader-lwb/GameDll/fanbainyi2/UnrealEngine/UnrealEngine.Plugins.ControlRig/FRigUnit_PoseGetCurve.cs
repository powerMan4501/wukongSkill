using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseGetCurve", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseGetCurve
{
	private static bool FRigUnit_PoseGetCurve_IsValid;

	private static int FRigUnit_PoseGetCurve_StructSize;

	public FRigUnit_PoseGetCurve Copy()
	{
		return this;
	}

	public static FRigUnit_PoseGetCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseGetCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseGetCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseGetCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseGetCurve(nativeBuffer + arrayIndex * FRigUnit_PoseGetCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseGetCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseGetCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetCurve");
		}
	}

	public FRigUnit_PoseGetCurve(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetCurve");
		}
	}

	static FRigUnit_PoseGetCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseGetCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseGetCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseGetCurve");
		FRigUnit_PoseGetCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseGetCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseGetCurve", FRigUnit_PoseGetCurve_IsValid);
	}
}
