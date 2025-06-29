using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TransformConstraint", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TransformConstraint
{
	private static bool FRigUnit_TransformConstraint_IsValid;

	private static int FRigUnit_TransformConstraint_StructSize;

	public FRigUnit_TransformConstraint Copy()
	{
		return this;
	}

	public static FRigUnit_TransformConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TransformConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TransformConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TransformConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TransformConstraint(nativeBuffer + arrayIndex * FRigUnit_TransformConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TransformConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TransformConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TransformConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TransformConstraint");
		}
	}

	public FRigUnit_TransformConstraint(IntPtr nativeStruct)
	{
		if (!FRigUnit_TransformConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TransformConstraint");
		}
	}

	static FRigUnit_TransformConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TransformConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TransformConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TransformConstraint");
		FRigUnit_TransformConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TransformConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TransformConstraint", FRigUnit_TransformConstraint_IsValid);
	}
}
