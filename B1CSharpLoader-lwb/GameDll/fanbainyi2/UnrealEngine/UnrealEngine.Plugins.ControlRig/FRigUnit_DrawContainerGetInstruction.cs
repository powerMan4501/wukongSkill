using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DrawContainerGetInstruction", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DrawContainerGetInstruction
{
	private static bool FRigUnit_DrawContainerGetInstruction_IsValid;

	private static int FRigUnit_DrawContainerGetInstruction_StructSize;

	public FRigUnit_DrawContainerGetInstruction Copy()
	{
		return this;
	}

	public static FRigUnit_DrawContainerGetInstruction FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DrawContainerGetInstruction(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DrawContainerGetInstruction value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DrawContainerGetInstruction FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DrawContainerGetInstruction(nativeBuffer + arrayIndex * FRigUnit_DrawContainerGetInstruction_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DrawContainerGetInstruction value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DrawContainerGetInstruction_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerGetInstruction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerGetInstruction");
		}
	}

	public FRigUnit_DrawContainerGetInstruction(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerGetInstruction_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerGetInstruction");
		}
	}

	static FRigUnit_DrawContainerGetInstruction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DrawContainerGetInstruction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DrawContainerGetInstruction));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DrawContainerGetInstruction");
		FRigUnit_DrawContainerGetInstruction_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DrawContainerGetInstruction_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DrawContainerGetInstruction", FRigUnit_DrawContainerGetInstruction_IsValid);
	}
}
