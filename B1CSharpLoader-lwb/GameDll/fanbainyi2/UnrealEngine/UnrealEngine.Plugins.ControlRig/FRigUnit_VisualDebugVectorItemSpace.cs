using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_VisualDebugVectorItemSpace
{
	private static bool FRigUnit_VisualDebugVectorItemSpace_IsValid;

	private static int FRigUnit_VisualDebugVectorItemSpace_StructSize;

	public FRigUnit_VisualDebugVectorItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_VisualDebugVectorItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_VisualDebugVectorItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_VisualDebugVectorItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_VisualDebugVectorItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_VisualDebugVectorItemSpace(nativeBuffer + arrayIndex * FRigUnit_VisualDebugVectorItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_VisualDebugVectorItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_VisualDebugVectorItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugVectorItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace");
		}
	}

	public FRigUnit_VisualDebugVectorItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_VisualDebugVectorItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace");
		}
	}

	static FRigUnit_VisualDebugVectorItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_VisualDebugVectorItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_VisualDebugVectorItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace");
		FRigUnit_VisualDebugVectorItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_VisualDebugVectorItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_VisualDebugVectorItemSpace", FRigUnit_VisualDebugVectorItemSpace_IsValid);
	}
}
