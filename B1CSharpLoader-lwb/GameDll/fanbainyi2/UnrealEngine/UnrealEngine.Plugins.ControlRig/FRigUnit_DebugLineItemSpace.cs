using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugLineItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugLineItemSpace
{
	private static bool FRigUnit_DebugLineItemSpace_IsValid;

	private static int FRigUnit_DebugLineItemSpace_StructSize;

	public FRigUnit_DebugLineItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_DebugLineItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugLineItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugLineItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugLineItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugLineItemSpace(nativeBuffer + arrayIndex * FRigUnit_DebugLineItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugLineItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugLineItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLineItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLineItemSpace");
		}
	}

	public FRigUnit_DebugLineItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLineItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLineItemSpace");
		}
	}

	static FRigUnit_DebugLineItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugLineItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugLineItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugLineItemSpace");
		FRigUnit_DebugLineItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugLineItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugLineItemSpace", FRigUnit_DebugLineItemSpace_IsValid);
	}
}
