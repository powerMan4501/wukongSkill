using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorNotEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorNotEquals
{
	private static bool FRigUnit_MathVectorNotEquals_IsValid;

	private static int FRigUnit_MathVectorNotEquals_StructSize;

	public FRigUnit_MathVectorNotEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorNotEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorNotEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorNotEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorNotEquals(nativeBuffer + arrayIndex * FRigUnit_MathVectorNotEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorNotEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorNotEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorNotEquals");
		}
	}

	public FRigUnit_MathVectorNotEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorNotEquals");
		}
	}

	static FRigUnit_MathVectorNotEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorNotEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorNotEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorNotEquals");
		FRigUnit_MathVectorNotEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorNotEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorNotEquals", FRigUnit_MathVectorNotEquals_IsValid);
	}
}
