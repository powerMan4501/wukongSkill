using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugRectangleItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugRectangleItemSpace
{
	private static bool FRigUnit_DebugRectangleItemSpace_IsValid;

	private static int FRigUnit_DebugRectangleItemSpace_StructSize;

	public FRigUnit_DebugRectangleItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_DebugRectangleItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugRectangleItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugRectangleItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugRectangleItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugRectangleItemSpace(nativeBuffer + arrayIndex * FRigUnit_DebugRectangleItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugRectangleItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugRectangleItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugRectangleItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugRectangleItemSpace");
		}
	}

	public FRigUnit_DebugRectangleItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugRectangleItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugRectangleItemSpace");
		}
	}

	static FRigUnit_DebugRectangleItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugRectangleItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugRectangleItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugRectangleItemSpace");
		FRigUnit_DebugRectangleItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugRectangleItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugRectangleItemSpace", FRigUnit_DebugRectangleItemSpace_IsValid);
	}
}
