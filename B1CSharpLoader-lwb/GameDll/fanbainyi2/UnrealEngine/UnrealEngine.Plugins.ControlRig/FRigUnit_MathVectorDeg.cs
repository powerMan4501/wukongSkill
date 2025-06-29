using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorDeg", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorDeg
{
	private static bool FRigUnit_MathVectorDeg_IsValid;

	private static int FRigUnit_MathVectorDeg_StructSize;

	public FRigUnit_MathVectorDeg Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorDeg FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorDeg(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorDeg value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorDeg FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorDeg(nativeBuffer + arrayIndex * FRigUnit_MathVectorDeg_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorDeg value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorDeg_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDeg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDeg");
		}
	}

	public FRigUnit_MathVectorDeg(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDeg_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDeg");
		}
	}

	static FRigUnit_MathVectorDeg()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorDeg)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorDeg));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorDeg");
		FRigUnit_MathVectorDeg_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorDeg_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorDeg", FRigUnit_MathVectorDeg_IsValid);
	}
}
