using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathColorAdd", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathColorAdd
{
	private static bool FRigUnit_MathColorAdd_IsValid;

	private static int FRigUnit_MathColorAdd_StructSize;

	public FRigUnit_MathColorAdd Copy()
	{
		return this;
	}

	public static FRigUnit_MathColorAdd FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathColorAdd(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathColorAdd value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathColorAdd FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathColorAdd(nativeBuffer + arrayIndex * FRigUnit_MathColorAdd_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathColorAdd value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathColorAdd_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorAdd");
		}
	}

	public FRigUnit_MathColorAdd(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorAdd_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorAdd");
		}
	}

	static FRigUnit_MathColorAdd()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathColorAdd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathColorAdd));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathColorAdd");
		FRigUnit_MathColorAdd_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathColorAdd_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathColorAdd", FRigUnit_MathColorAdd_IsValid);
	}
}
