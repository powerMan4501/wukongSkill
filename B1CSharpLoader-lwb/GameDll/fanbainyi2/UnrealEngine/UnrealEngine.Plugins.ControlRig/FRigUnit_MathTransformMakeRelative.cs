using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformMakeRelative", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformMakeRelative
{
	private static bool FRigUnit_MathTransformMakeRelative_IsValid;

	private static int FRigUnit_MathTransformMakeRelative_StructSize;

	public FRigUnit_MathTransformMakeRelative Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformMakeRelative FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformMakeRelative(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformMakeRelative value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformMakeRelative FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformMakeRelative(nativeBuffer + arrayIndex * FRigUnit_MathTransformMakeRelative_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformMakeRelative value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformMakeRelative_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMakeRelative_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMakeRelative");
		}
	}

	public FRigUnit_MathTransformMakeRelative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMakeRelative_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMakeRelative");
		}
	}

	static FRigUnit_MathTransformMakeRelative()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformMakeRelative)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformMakeRelative));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformMakeRelative");
		FRigUnit_MathTransformMakeRelative_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformMakeRelative_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformMakeRelative", FRigUnit_MathTransformMakeRelative_IsValid);
	}
}
