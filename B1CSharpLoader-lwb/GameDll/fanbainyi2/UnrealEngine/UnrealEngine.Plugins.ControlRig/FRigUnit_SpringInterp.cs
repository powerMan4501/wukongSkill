using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SpringInterp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SpringInterp
{
	private static bool FRigUnit_SpringInterp_IsValid;

	private static int FRigUnit_SpringInterp_StructSize;

	public FRigUnit_SpringInterp Copy()
	{
		return this;
	}

	public static FRigUnit_SpringInterp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SpringInterp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SpringInterp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SpringInterp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SpringInterp(nativeBuffer + arrayIndex * FRigUnit_SpringInterp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SpringInterp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SpringInterp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterp");
		}
	}

	public FRigUnit_SpringInterp(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterp");
		}
	}

	static FRigUnit_SpringInterp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SpringInterp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SpringInterp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SpringInterp");
		FRigUnit_SpringInterp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SpringInterp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SpringInterp", FRigUnit_SpringInterp_IsValid);
	}
}
