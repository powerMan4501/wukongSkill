using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorLerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorLerp
{
	private static bool FRigUnit_MathVectorLerp_IsValid;

	private static int FRigUnit_MathVectorLerp_StructSize;

	public FRigUnit_MathVectorLerp Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorLerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorLerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorLerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorLerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorLerp(nativeBuffer + arrayIndex * FRigUnit_MathVectorLerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorLerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorLerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorLerp");
		}
	}

	public FRigUnit_MathVectorLerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorLerp");
		}
	}

	static FRigUnit_MathVectorLerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorLerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorLerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorLerp");
		FRigUnit_MathVectorLerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorLerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorLerp", FRigUnit_MathVectorLerp_IsValid);
	}
}
