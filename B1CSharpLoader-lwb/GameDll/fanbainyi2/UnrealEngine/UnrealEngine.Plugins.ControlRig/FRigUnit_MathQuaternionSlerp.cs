using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathQuaternionSlerp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathQuaternionSlerp
{
	private static bool FRigUnit_MathQuaternionSlerp_IsValid;

	private static int FRigUnit_MathQuaternionSlerp_StructSize;

	public FRigUnit_MathQuaternionSlerp Copy()
	{
		return this;
	}

	public static FRigUnit_MathQuaternionSlerp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathQuaternionSlerp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathQuaternionSlerp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathQuaternionSlerp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathQuaternionSlerp(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionSlerp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathQuaternionSlerp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathQuaternionSlerp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionSlerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionSlerp");
		}
	}

	public FRigUnit_MathQuaternionSlerp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathQuaternionSlerp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathQuaternionSlerp");
		}
	}

	static FRigUnit_MathQuaternionSlerp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathQuaternionSlerp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathQuaternionSlerp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathQuaternionSlerp");
		FRigUnit_MathQuaternionSlerp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathQuaternionSlerp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathQuaternionSlerp", FRigUnit_MathQuaternionSlerp_IsValid);
	}
}
