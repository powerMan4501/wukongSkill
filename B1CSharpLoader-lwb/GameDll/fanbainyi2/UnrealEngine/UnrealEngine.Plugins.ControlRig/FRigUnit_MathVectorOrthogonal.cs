using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorOrthogonal", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorOrthogonal
{
	private static bool FRigUnit_MathVectorOrthogonal_IsValid;

	private static int FRigUnit_MathVectorOrthogonal_StructSize;

	public FRigUnit_MathVectorOrthogonal Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorOrthogonal FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorOrthogonal(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorOrthogonal value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorOrthogonal FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorOrthogonal(nativeBuffer + arrayIndex * FRigUnit_MathVectorOrthogonal_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorOrthogonal value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorOrthogonal_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorOrthogonal_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorOrthogonal");
		}
	}

	public FRigUnit_MathVectorOrthogonal(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorOrthogonal_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorOrthogonal");
		}
	}

	static FRigUnit_MathVectorOrthogonal()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorOrthogonal)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorOrthogonal));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorOrthogonal");
		FRigUnit_MathVectorOrthogonal_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorOrthogonal_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorOrthogonal", FRigUnit_MathVectorOrthogonal_IsValid);
	}
}
