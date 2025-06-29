using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorAdd", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorAdd
{
	private static bool FRigUnit_MathVectorAdd_IsValid;

	private static int FRigUnit_MathVectorAdd_StructSize;

	public FRigUnit_MathVectorAdd Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorAdd FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorAdd(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorAdd value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorAdd FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorAdd(nativeBuffer + arrayIndex * FRigUnit_MathVectorAdd_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorAdd value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorAdd_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorAdd");
		}
	}

	public FRigUnit_MathVectorAdd(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorAdd");
		}
	}

	static FRigUnit_MathVectorAdd()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorAdd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorAdd));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorAdd");
		FRigUnit_MathVectorAdd_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorAdd_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorAdd", FRigUnit_MathVectorAdd_IsValid);
	}
}
