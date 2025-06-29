using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorBase
{
	private static bool FRigUnit_MathVectorBase_IsValid;

	private static int FRigUnit_MathVectorBase_StructSize;

	public FRigUnit_MathVectorBase Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorBase(nativeBuffer + arrayIndex * FRigUnit_MathVectorBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorBase");
		}
	}

	public FRigUnit_MathVectorBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorBase");
		}
	}

	static FRigUnit_MathVectorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorBase");
		FRigUnit_MathVectorBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorBase", FRigUnit_MathVectorBase_IsValid);
	}
}
