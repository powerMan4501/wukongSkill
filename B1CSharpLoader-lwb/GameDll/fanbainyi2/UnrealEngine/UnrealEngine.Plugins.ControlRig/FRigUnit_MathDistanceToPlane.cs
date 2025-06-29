using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathDistanceToPlane", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathDistanceToPlane
{
	private static bool FRigUnit_MathDistanceToPlane_IsValid;

	private static int FRigUnit_MathDistanceToPlane_StructSize;

	public FRigUnit_MathDistanceToPlane Copy()
	{
		return this;
	}

	public static FRigUnit_MathDistanceToPlane FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathDistanceToPlane(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathDistanceToPlane value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathDistanceToPlane FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathDistanceToPlane(nativeBuffer + arrayIndex * FRigUnit_MathDistanceToPlane_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathDistanceToPlane value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathDistanceToPlane_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathDistanceToPlane_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathDistanceToPlane");
		}
	}

	public FRigUnit_MathDistanceToPlane(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathDistanceToPlane_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathDistanceToPlane");
		}
	}

	static FRigUnit_MathDistanceToPlane()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathDistanceToPlane)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathDistanceToPlane));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathDistanceToPlane");
		FRigUnit_MathDistanceToPlane_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathDistanceToPlane_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathDistanceToPlane", FRigUnit_MathDistanceToPlane_IsValid);
	}
}
