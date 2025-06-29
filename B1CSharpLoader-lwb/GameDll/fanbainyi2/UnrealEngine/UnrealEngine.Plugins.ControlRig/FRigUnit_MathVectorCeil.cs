using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorCeil", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorCeil
{
	private static bool FRigUnit_MathVectorCeil_IsValid;

	private static int FRigUnit_MathVectorCeil_StructSize;

	public FRigUnit_MathVectorCeil Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorCeil FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorCeil(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorCeil value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorCeil FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorCeil(nativeBuffer + arrayIndex * FRigUnit_MathVectorCeil_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorCeil value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorCeil_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorCeil_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorCeil");
		}
	}

	public FRigUnit_MathVectorCeil(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorCeil_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorCeil");
		}
	}

	static FRigUnit_MathVectorCeil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorCeil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorCeil));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorCeil");
		FRigUnit_MathVectorCeil_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorCeil_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorCeil", FRigUnit_MathVectorCeil_IsValid);
	}
}
