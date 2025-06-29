using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorEquals
{
	private static bool FRigUnit_MathVectorEquals_IsValid;

	private static int FRigUnit_MathVectorEquals_StructSize;

	public FRigUnit_MathVectorEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorEquals(nativeBuffer + arrayIndex * FRigUnit_MathVectorEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorEquals");
		}
	}

	public FRigUnit_MathVectorEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorEquals");
		}
	}

	static FRigUnit_MathVectorEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorEquals");
		FRigUnit_MathVectorEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorEquals", FRigUnit_MathVectorEquals_IsValid);
	}
}
