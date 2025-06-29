using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugArcItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugArcItemSpace
{
	private static bool FRigUnit_DebugArcItemSpace_IsValid;

	private static int FRigUnit_DebugArcItemSpace_StructSize;

	public FRigUnit_DebugArcItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_DebugArcItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugArcItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugArcItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugArcItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugArcItemSpace(nativeBuffer + arrayIndex * FRigUnit_DebugArcItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugArcItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugArcItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugArcItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugArcItemSpace");
		}
	}

	public FRigUnit_DebugArcItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugArcItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugArcItemSpace");
		}
	}

	static FRigUnit_DebugArcItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugArcItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugArcItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugArcItemSpace");
		FRigUnit_DebugArcItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugArcItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugArcItemSpace", FRigUnit_DebugArcItemSpace_IsValid);
	}
}
