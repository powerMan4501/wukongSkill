using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntersectPlane", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntersectPlane
{
	private static bool FRigUnit_MathIntersectPlane_IsValid;

	private static int FRigUnit_MathIntersectPlane_StructSize;

	public FRigUnit_MathIntersectPlane Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntersectPlane FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntersectPlane(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntersectPlane value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntersectPlane FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntersectPlane(nativeBuffer + arrayIndex * FRigUnit_MathIntersectPlane_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntersectPlane value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntersectPlane_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntersectPlane_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntersectPlane");
		}
	}

	public FRigUnit_MathIntersectPlane(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntersectPlane_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntersectPlane");
		}
	}

	static FRigUnit_MathIntersectPlane()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntersectPlane)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntersectPlane));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntersectPlane");
		FRigUnit_MathIntersectPlane_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntersectPlane_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntersectPlane", FRigUnit_MathIntersectPlane_IsValid);
	}
}
