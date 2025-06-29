using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugRectangle", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugRectangle
{
	private static bool FRigUnit_DebugRectangle_IsValid;

	private static int FRigUnit_DebugRectangle_StructSize;

	public FRigUnit_DebugRectangle Copy()
	{
		return this;
	}

	public static FRigUnit_DebugRectangle FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugRectangle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugRectangle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugRectangle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugRectangle(nativeBuffer + arrayIndex * FRigUnit_DebugRectangle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugRectangle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugRectangle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugRectangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugRectangle");
		}
	}

	public FRigUnit_DebugRectangle(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugRectangle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugRectangle");
		}
	}

	static FRigUnit_DebugRectangle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugRectangle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugRectangle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugRectangle");
		FRigUnit_DebugRectangle_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugRectangle_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugRectangle", FRigUnit_DebugRectangle_IsValid);
	}
}
