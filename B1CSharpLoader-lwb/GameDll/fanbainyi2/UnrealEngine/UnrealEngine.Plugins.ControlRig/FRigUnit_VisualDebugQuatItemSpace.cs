using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_VisualDebugQuatItemSpace
{
	private static bool FRigUnit_VisualDebugQuatItemSpace_IsValid;

	private static int FRigUnit_VisualDebugQuatItemSpace_StructSize;

	public FRigUnit_VisualDebugQuatItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_VisualDebugQuatItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_VisualDebugQuatItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_VisualDebugQuatItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_VisualDebugQuatItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_VisualDebugQuatItemSpace(nativeBuffer + arrayIndex * FRigUnit_VisualDebugQuatItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_VisualDebugQuatItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_VisualDebugQuatItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugQuatItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace");
		}
	}

	public FRigUnit_VisualDebugQuatItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugQuatItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace");
		}
	}

	static FRigUnit_VisualDebugQuatItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_VisualDebugQuatItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_VisualDebugQuatItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace");
		FRigUnit_VisualDebugQuatItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_VisualDebugQuatItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_VisualDebugQuatItemSpace", FRigUnit_VisualDebugQuatItemSpace_IsValid);
	}
}
