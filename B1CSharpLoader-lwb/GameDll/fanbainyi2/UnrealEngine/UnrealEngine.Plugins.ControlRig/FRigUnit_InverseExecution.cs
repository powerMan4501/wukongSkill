using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_InverseExecution", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_InverseExecution
{
	private static bool FRigUnit_InverseExecution_IsValid;

	private static int FRigUnit_InverseExecution_StructSize;

	public FRigUnit_InverseExecution Copy()
	{
		return this;
	}

	public static FRigUnit_InverseExecution FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_InverseExecution(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_InverseExecution value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_InverseExecution FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_InverseExecution(nativeBuffer + arrayIndex * FRigUnit_InverseExecution_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_InverseExecution value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_InverseExecution_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_InverseExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_InverseExecution");
		}
	}

	public FRigUnit_InverseExecution(IntPtr nativeStruct)
	{
		if (!FRigUnit_InverseExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_InverseExecution");
		}
	}

	static FRigUnit_InverseExecution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_InverseExecution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_InverseExecution));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_InverseExecution");
		FRigUnit_InverseExecution_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_InverseExecution_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_InverseExecution", FRigUnit_InverseExecution_IsValid);
	}
}
