using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorDiv", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorDiv
{
	private static bool FRigUnit_MathVectorDiv_IsValid;

	private static int FRigUnit_MathVectorDiv_StructSize;

	public FRigUnit_MathVectorDiv Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorDiv FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorDiv(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorDiv value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorDiv FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorDiv(nativeBuffer + arrayIndex * FRigUnit_MathVectorDiv_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorDiv value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorDiv_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDiv_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDiv");
		}
	}

	public FRigUnit_MathVectorDiv(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDiv_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDiv");
		}
	}

	static FRigUnit_MathVectorDiv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorDiv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorDiv));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorDiv");
		FRigUnit_MathVectorDiv_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorDiv_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorDiv", FRigUnit_MathVectorDiv_IsValid);
	}
}
