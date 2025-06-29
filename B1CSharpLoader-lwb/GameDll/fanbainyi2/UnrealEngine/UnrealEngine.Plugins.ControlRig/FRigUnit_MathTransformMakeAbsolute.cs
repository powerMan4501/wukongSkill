using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathTransformMakeAbsolute", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathTransformMakeAbsolute
{
	private static bool FRigUnit_MathTransformMakeAbsolute_IsValid;

	private static int FRigUnit_MathTransformMakeAbsolute_StructSize;

	public FRigUnit_MathTransformMakeAbsolute Copy()
	{
		return this;
	}

	public static FRigUnit_MathTransformMakeAbsolute FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathTransformMakeAbsolute(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathTransformMakeAbsolute value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathTransformMakeAbsolute FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathTransformMakeAbsolute(nativeBuffer + arrayIndex * FRigUnit_MathTransformMakeAbsolute_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathTransformMakeAbsolute value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathTransformMakeAbsolute_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMakeAbsolute_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMakeAbsolute");
		}
	}

	public FRigUnit_MathTransformMakeAbsolute(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathTransformMakeAbsolute_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathTransformMakeAbsolute");
		}
	}

	static FRigUnit_MathTransformMakeAbsolute()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathTransformMakeAbsolute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathTransformMakeAbsolute));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathTransformMakeAbsolute");
		FRigUnit_MathTransformMakeAbsolute_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathTransformMakeAbsolute_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathTransformMakeAbsolute", FRigUnit_MathTransformMakeAbsolute_IsValid);
	}
}
