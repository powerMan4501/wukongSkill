using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MultiFABRIK", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MultiFABRIK
{
	private static bool FRigUnit_MultiFABRIK_IsValid;

	private static int FRigUnit_MultiFABRIK_StructSize;

	public FRigUnit_MultiFABRIK Copy()
	{
		return this;
	}

	public static FRigUnit_MultiFABRIK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MultiFABRIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MultiFABRIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MultiFABRIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MultiFABRIK(nativeBuffer + arrayIndex * FRigUnit_MultiFABRIK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MultiFABRIK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MultiFABRIK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MultiFABRIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MultiFABRIK");
		}
	}

	public FRigUnit_MultiFABRIK(IntPtr nativeStruct)
	{
		if (!FRigUnit_MultiFABRIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MultiFABRIK");
		}
	}

	static FRigUnit_MultiFABRIK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MultiFABRIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MultiFABRIK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MultiFABRIK");
		FRigUnit_MultiFABRIK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MultiFABRIK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MultiFABRIK", FRigUnit_MultiFABRIK_IsValid);
	}
}
