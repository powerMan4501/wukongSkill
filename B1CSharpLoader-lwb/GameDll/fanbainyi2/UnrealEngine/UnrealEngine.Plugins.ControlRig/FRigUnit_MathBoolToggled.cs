using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathBoolToggled", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathBoolToggled
{
	private static bool FRigUnit_MathBoolToggled_IsValid;

	private static int FRigUnit_MathBoolToggled_StructSize;

	public FRigUnit_MathBoolToggled Copy()
	{
		return this;
	}

	public static FRigUnit_MathBoolToggled FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathBoolToggled(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathBoolToggled value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathBoolToggled FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathBoolToggled(nativeBuffer + arrayIndex * FRigUnit_MathBoolToggled_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathBoolToggled value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathBoolToggled_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolToggled_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolToggled");
		}
	}

	public FRigUnit_MathBoolToggled(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathBoolToggled_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathBoolToggled");
		}
	}

	static FRigUnit_MathBoolToggled()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathBoolToggled)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathBoolToggled));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathBoolToggled");
		FRigUnit_MathBoolToggled_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathBoolToggled_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathBoolToggled", FRigUnit_MathBoolToggled_IsValid);
	}
}
