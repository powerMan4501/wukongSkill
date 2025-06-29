using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatNotEquals", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatNotEquals
{
	private static bool FRigUnit_MathFloatNotEquals_IsValid;

	private static int FRigUnit_MathFloatNotEquals_StructSize;

	public FRigUnit_MathFloatNotEquals Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatNotEquals FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatNotEquals(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatNotEquals value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatNotEquals FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatNotEquals(nativeBuffer + arrayIndex * FRigUnit_MathFloatNotEquals_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatNotEquals value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatNotEquals_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatNotEquals");
		}
	}

	public FRigUnit_MathFloatNotEquals(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatNotEquals_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatNotEquals");
		}
	}

	static FRigUnit_MathFloatNotEquals()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatNotEquals)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatNotEquals));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatNotEquals");
		FRigUnit_MathFloatNotEquals_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatNotEquals_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatNotEquals", FRigUnit_MathFloatNotEquals_IsValid);
	}
}
