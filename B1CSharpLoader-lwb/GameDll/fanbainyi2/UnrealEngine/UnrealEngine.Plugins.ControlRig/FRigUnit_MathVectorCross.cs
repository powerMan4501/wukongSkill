using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorCross", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorCross
{
	private static bool FRigUnit_MathVectorCross_IsValid;

	private static int FRigUnit_MathVectorCross_StructSize;

	public FRigUnit_MathVectorCross Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorCross FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorCross(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorCross value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorCross FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorCross(nativeBuffer + arrayIndex * FRigUnit_MathVectorCross_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorCross value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorCross_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorCross_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorCross");
		}
	}

	public FRigUnit_MathVectorCross(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorCross_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorCross");
		}
	}

	static FRigUnit_MathVectorCross()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorCross)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorCross));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorCross");
		FRigUnit_MathVectorCross_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorCross_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorCross", FRigUnit_MathVectorCross_IsValid);
	}
}
