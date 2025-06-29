using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorParallel", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorParallel
{
	private static bool FRigUnit_MathVectorParallel_IsValid;

	private static int FRigUnit_MathVectorParallel_StructSize;

	public FRigUnit_MathVectorParallel Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorParallel FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorParallel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorParallel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorParallel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorParallel(nativeBuffer + arrayIndex * FRigUnit_MathVectorParallel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorParallel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorParallel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorParallel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorParallel");
		}
	}

	public FRigUnit_MathVectorParallel(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorParallel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorParallel");
		}
	}

	static FRigUnit_MathVectorParallel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorParallel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorParallel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorParallel");
		FRigUnit_MathVectorParallel_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorParallel_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorParallel", FRigUnit_MathVectorParallel_IsValid);
	}
}
