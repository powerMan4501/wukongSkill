using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorFromFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorFromFloat
{
	private static bool FRigUnit_MathVectorFromFloat_IsValid;

	private static int FRigUnit_MathVectorFromFloat_StructSize;

	public FRigUnit_MathVectorFromFloat Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorFromFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorFromFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorFromFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorFromFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorFromFloat(nativeBuffer + arrayIndex * FRigUnit_MathVectorFromFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorFromFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorFromFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorFromFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorFromFloat");
		}
	}

	public FRigUnit_MathVectorFromFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorFromFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorFromFloat");
		}
	}

	static FRigUnit_MathVectorFromFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorFromFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorFromFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorFromFloat");
		FRigUnit_MathVectorFromFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorFromFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorFromFloat", FRigUnit_MathVectorFromFloat_IsValid);
	}
}
