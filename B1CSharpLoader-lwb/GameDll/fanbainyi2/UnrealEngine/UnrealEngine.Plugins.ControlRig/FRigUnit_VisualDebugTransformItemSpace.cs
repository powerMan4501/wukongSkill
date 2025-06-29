using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_VisualDebugTransformItemSpace
{
	private static bool FRigUnit_VisualDebugTransformItemSpace_IsValid;

	private static int FRigUnit_VisualDebugTransformItemSpace_StructSize;

	public FRigUnit_VisualDebugTransformItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_VisualDebugTransformItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_VisualDebugTransformItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_VisualDebugTransformItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_VisualDebugTransformItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_VisualDebugTransformItemSpace(nativeBuffer + arrayIndex * FRigUnit_VisualDebugTransformItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_VisualDebugTransformItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_VisualDebugTransformItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugTransformItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace");
		}
	}

	public FRigUnit_VisualDebugTransformItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugTransformItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace");
		}
	}

	static FRigUnit_VisualDebugTransformItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_VisualDebugTransformItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_VisualDebugTransformItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace");
		FRigUnit_VisualDebugTransformItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_VisualDebugTransformItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_VisualDebugTransformItemSpace", FRigUnit_VisualDebugTransformItemSpace_IsValid);
	}
}
