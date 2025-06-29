using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatAtan", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatAtan
{
	private static bool FRigUnit_MathFloatAtan_IsValid;

	private static int FRigUnit_MathFloatAtan_StructSize;

	public FRigUnit_MathFloatAtan Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatAtan FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatAtan(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatAtan value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatAtan FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatAtan(nativeBuffer + arrayIndex * FRigUnit_MathFloatAtan_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatAtan value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatAtan_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAtan_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAtan");
		}
	}

	public FRigUnit_MathFloatAtan(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatAtan_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatAtan");
		}
	}

	static FRigUnit_MathFloatAtan()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatAtan)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatAtan));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatAtan");
		FRigUnit_MathFloatAtan_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatAtan_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatAtan", FRigUnit_MathFloatAtan_IsValid);
	}
}
