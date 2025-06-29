using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorAngle", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorAngle
{
	private static bool FRigUnit_MathVectorAngle_IsValid;

	private static int FRigUnit_MathVectorAngle_StructSize;

	public FRigUnit_MathVectorAngle Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorAngle FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorAngle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorAngle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorAngle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorAngle(nativeBuffer + arrayIndex * FRigUnit_MathVectorAngle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorAngle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorAngle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorAngle");
		}
	}

	public FRigUnit_MathVectorAngle(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorAngle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorAngle");
		}
	}

	static FRigUnit_MathVectorAngle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorAngle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorAngle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorAngle");
		FRigUnit_MathVectorAngle_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorAngle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorAngle", FRigUnit_MathVectorAngle_IsValid);
	}
}
