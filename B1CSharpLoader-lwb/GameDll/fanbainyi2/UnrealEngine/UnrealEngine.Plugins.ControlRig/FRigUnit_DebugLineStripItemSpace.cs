using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugLineStripItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugLineStripItemSpace
{
	private static bool FRigUnit_DebugLineStripItemSpace_IsValid;

	private static int FRigUnit_DebugLineStripItemSpace_StructSize;

	public FRigUnit_DebugLineStripItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_DebugLineStripItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugLineStripItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugLineStripItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugLineStripItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugLineStripItemSpace(nativeBuffer + arrayIndex * FRigUnit_DebugLineStripItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugLineStripItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugLineStripItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLineStripItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLineStripItemSpace");
		}
	}

	public FRigUnit_DebugLineStripItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugLineStripItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugLineStripItemSpace");
		}
	}

	static FRigUnit_DebugLineStripItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugLineStripItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugLineStripItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugLineStripItemSpace");
		FRigUnit_DebugLineStripItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugLineStripItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugLineStripItemSpace", FRigUnit_DebugLineStripItemSpace_IsValid);
	}
}
