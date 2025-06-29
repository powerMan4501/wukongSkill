using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformFromSRT", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformFromSRT
{
	private static bool FRigUnit_MathTransformFromSRT_IsValid;

	private static int FRigUnit_MathTransformFromSRT_StructSize;

	public FRigUnit_MathTransformFromSRT Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformFromSRT FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformFromSRT(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformFromSRT value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformFromSRT FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformFromSRT(nativeBuffer + arrayIndex * FRigUnit_MathTransformFromSRT_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformFromSRT value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformFromSRT_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformFromSRT_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformFromSRT");
		}
	}

	public FRigUnit_MathTransformFromSRT(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformFromSRT_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformFromSRT");
		}
	}

	static FRigUnit_MathTransformFromSRT()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformFromSRT)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformFromSRT));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformFromSRT");
		FRigUnit_MathTransformFromSRT_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformFromSRT_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformFromSRT", FRigUnit_MathTransformFromSRT_IsValid);
	}
}
