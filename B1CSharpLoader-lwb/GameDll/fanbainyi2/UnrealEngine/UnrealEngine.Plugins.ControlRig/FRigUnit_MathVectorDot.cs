using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorDot", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorDot
{
	private static bool FRigUnit_MathVectorDot_IsValid;

	private static int FRigUnit_MathVectorDot_StructSize;

	public FRigUnit_MathVectorDot Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorDot FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorDot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorDot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorDot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorDot(nativeBuffer + arrayIndex * FRigUnit_MathVectorDot_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorDot value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorDot_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDot");
		}
	}

	public FRigUnit_MathVectorDot(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDot");
		}
	}

	static FRigUnit_MathVectorDot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorDot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorDot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorDot");
		FRigUnit_MathVectorDot_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorDot_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorDot", FRigUnit_MathVectorDot_IsValid);
	}
}
