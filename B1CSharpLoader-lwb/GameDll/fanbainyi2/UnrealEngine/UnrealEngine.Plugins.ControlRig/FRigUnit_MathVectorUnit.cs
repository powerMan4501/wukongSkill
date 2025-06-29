using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorUnit", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorUnit
{
	private static bool FRigUnit_MathVectorUnit_IsValid;

	private static int FRigUnit_MathVectorUnit_StructSize;

	public FRigUnit_MathVectorUnit Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorUnit FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorUnit(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorUnit value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorUnit FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorUnit(nativeBuffer + arrayIndex * FRigUnit_MathVectorUnit_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorUnit value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorUnit_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorUnit");
		}
	}

	public FRigUnit_MathVectorUnit(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorUnit_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorUnit");
		}
	}

	static FRigUnit_MathVectorUnit()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorUnit)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorUnit));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorUnit");
		FRigUnit_MathVectorUnit_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorUnit_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorUnit", FRigUnit_MathVectorUnit_IsValid);
	}
}
