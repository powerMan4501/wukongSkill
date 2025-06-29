using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionScale", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionScale
{
	private static bool FRigUnit_MathQuaternionScale_IsValid;

	private static int FRigUnit_MathQuaternionScale_StructSize;

	public FRigUnit_MathQuaternionScale Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionScale FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionScale(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionScale value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionScale FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionScale(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionScale_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionScale value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionScale_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionScale");
		}
	}

	public FRigUnit_MathQuaternionScale(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionScale");
		}
	}

	static FRigUnit_MathQuaternionScale()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionScale)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionScale));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionScale");
		FRigUnit_MathQuaternionScale_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionScale_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionScale", FRigUnit_MathQuaternionScale_IsValid);
	}
}
