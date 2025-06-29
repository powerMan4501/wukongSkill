using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformLerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformLerp
{
	private static bool FRigUnit_MathTransformLerp_IsValid;

	private static int FRigUnit_MathTransformLerp_StructSize;

	public FRigUnit_MathTransformLerp Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformLerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformLerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformLerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformLerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformLerp(nativeBuffer + arrayIndex * FRigUnit_MathTransformLerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformLerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformLerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformLerp");
		}
	}

	public FRigUnit_MathTransformLerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformLerp");
		}
	}

	static FRigUnit_MathTransformLerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformLerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformLerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformLerp");
		FRigUnit_MathTransformLerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformLerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformLerp", FRigUnit_MathTransformLerp_IsValid);
	}
}
