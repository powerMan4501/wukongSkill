using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatAbs", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatAbs
{
	private static bool FRigUnit_MathFloatAbs_IsValid;

	private static int FRigUnit_MathFloatAbs_StructSize;

	public FRigUnit_MathFloatAbs Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatAbs FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatAbs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatAbs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatAbs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatAbs(nativeBuffer + arrayIndex * FRigUnit_MathFloatAbs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatAbs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatAbs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAbs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAbs");
		}
	}

	public FRigUnit_MathFloatAbs(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAbs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAbs");
		}
	}

	static FRigUnit_MathFloatAbs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatAbs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatAbs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatAbs");
		FRigUnit_MathFloatAbs_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatAbs_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatAbs", FRigUnit_MathFloatAbs_IsValid);
	}
}
