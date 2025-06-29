using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolNand", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolNand
{
	private static bool FRigUnit_MathBoolNand_IsValid;

	private static int FRigUnit_MathBoolNand_StructSize;

	public FRigUnit_MathBoolNand Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolNand FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolNand(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolNand value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolNand FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolNand(nativeBuffer + arrayIndex * FRigUnit_MathBoolNand_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolNand value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolNand_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolNand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolNand");
		}
	}

	public FRigUnit_MathBoolNand(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolNand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolNand");
		}
	}

	static FRigUnit_MathBoolNand()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolNand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolNand));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolNand");
		FRigUnit_MathBoolNand_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolNand_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolNand", FRigUnit_MathBoolNand_IsValid);
	}
}
