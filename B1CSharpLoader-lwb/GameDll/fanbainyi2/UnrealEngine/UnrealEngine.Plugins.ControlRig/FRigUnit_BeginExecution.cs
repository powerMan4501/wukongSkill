using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BeginExecution", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BeginExecution
{
	private static bool FRigUnit_BeginExecution_IsValid;

	private static int FRigUnit_BeginExecution_StructSize;

	public FRigUnit_BeginExecution Copy()
	{
		return this;
	}

	public static FRigUnit_BeginExecution FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BeginExecution(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BeginExecution value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BeginExecution FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BeginExecution(nativeBuffer + arrayIndex * FRigUnit_BeginExecution_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BeginExecution value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BeginExecution_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BeginExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BeginExecution");
		}
	}

	public FRigUnit_BeginExecution(IntPtr nativeStruct)
	{
		if (!FRigUnit_BeginExecution_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BeginExecution");
		}
	}

	static FRigUnit_BeginExecution()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BeginExecution)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BeginExecution));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BeginExecution");
		FRigUnit_BeginExecution_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BeginExecution_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BeginExecution", FRigUnit_BeginExecution_IsValid);
	}
}
