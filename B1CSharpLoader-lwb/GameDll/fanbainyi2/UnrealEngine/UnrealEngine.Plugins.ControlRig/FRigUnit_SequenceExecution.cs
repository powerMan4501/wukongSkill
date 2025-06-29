using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SequenceExecution", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SequenceExecution
{
	private static bool FRigUnit_SequenceExecution_IsValid;

	private static int FRigUnit_SequenceExecution_StructSize;

	public FRigUnit_SequenceExecution Copy()
	{
		return this;
	}

	public static FRigUnit_SequenceExecution FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SequenceExecution(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SequenceExecution value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SequenceExecution FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SequenceExecution(nativeBuffer + arrayIndex * FRigUnit_SequenceExecution_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SequenceExecution value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SequenceExecution_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SequenceExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SequenceExecution");
		}
	}

	public FRigUnit_SequenceExecution(IntPtr nativeStruct)
	{
		if (!FRigUnit_SequenceExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SequenceExecution");
		}
	}

	static FRigUnit_SequenceExecution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SequenceExecution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SequenceExecution));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SequenceExecution");
		FRigUnit_SequenceExecution_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SequenceExecution_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SequenceExecution", FRigUnit_SequenceExecution_IsValid);
	}
}
