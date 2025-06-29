using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatLerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatLerp
{
	private static bool FRigUnit_MathFloatLerp_IsValid;

	private static int FRigUnit_MathFloatLerp_StructSize;

	public FRigUnit_MathFloatLerp Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatLerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatLerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatLerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatLerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatLerp(nativeBuffer + arrayIndex * FRigUnit_MathFloatLerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatLerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatLerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLerp");
		}
	}

	public FRigUnit_MathFloatLerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatLerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatLerp");
		}
	}

	static FRigUnit_MathFloatLerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatLerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatLerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatLerp");
		FRigUnit_MathFloatLerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatLerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatLerp", FRigUnit_MathFloatLerp_IsValid);
	}
}
