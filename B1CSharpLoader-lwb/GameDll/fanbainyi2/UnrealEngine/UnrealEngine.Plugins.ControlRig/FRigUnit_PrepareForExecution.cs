using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PrepareForExecution", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PrepareForExecution
{
	private static bool FRigUnit_PrepareForExecution_IsValid;

	private static int FRigUnit_PrepareForExecution_StructSize;

	public FRigUnit_PrepareForExecution Copy()
	{
		return this;
	}

	public static FRigUnit_PrepareForExecution FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PrepareForExecution(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PrepareForExecution value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PrepareForExecution FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PrepareForExecution(nativeBuffer + arrayIndex * FRigUnit_PrepareForExecution_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PrepareForExecution value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PrepareForExecution_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PrepareForExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PrepareForExecution");
		}
	}

	public FRigUnit_PrepareForExecution(IntPtr nativeStruct)
	{
		if (!FRigUnit_PrepareForExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PrepareForExecution");
		}
	}

	static FRigUnit_PrepareForExecution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PrepareForExecution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PrepareForExecution));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PrepareForExecution");
		FRigUnit_PrepareForExecution_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PrepareForExecution_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PrepareForExecution", FRigUnit_PrepareForExecution_IsValid);
	}
}
