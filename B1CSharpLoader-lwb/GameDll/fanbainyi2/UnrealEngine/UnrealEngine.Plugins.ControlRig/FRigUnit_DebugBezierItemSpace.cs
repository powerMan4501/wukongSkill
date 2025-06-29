using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DebugBezierItemSpace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DebugBezierItemSpace
{
	private static bool FRigUnit_DebugBezierItemSpace_IsValid;

	private static int FRigUnit_DebugBezierItemSpace_StructSize;

	public FRigUnit_DebugBezierItemSpace Copy()
	{
		return this;
	}

	public static FRigUnit_DebugBezierItemSpace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DebugBezierItemSpace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DebugBezierItemSpace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DebugBezierItemSpace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DebugBezierItemSpace(nativeBuffer + arrayIndex * FRigUnit_DebugBezierItemSpace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DebugBezierItemSpace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DebugBezierItemSpace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBezierItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBezierItemSpace");
		}
	}

	public FRigUnit_DebugBezierItemSpace(IntPtr nativeStruct)
	{
		if (!FRigUnit_DebugBezierItemSpace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DebugBezierItemSpace");
		}
	}

	static FRigUnit_DebugBezierItemSpace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DebugBezierItemSpace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DebugBezierItemSpace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DebugBezierItemSpace");
		FRigUnit_DebugBezierItemSpace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DebugBezierItemSpace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DebugBezierItemSpace", FRigUnit_DebugBezierItemSpace_IsValid);
	}
}
