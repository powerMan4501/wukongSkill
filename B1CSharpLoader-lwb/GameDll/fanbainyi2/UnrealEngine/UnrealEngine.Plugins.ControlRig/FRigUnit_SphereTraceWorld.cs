using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SphereTraceWorld", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SphereTraceWorld
{
	private static bool FRigUnit_SphereTraceWorld_IsValid;

	private static int FRigUnit_SphereTraceWorld_StructSize;

	public FRigUnit_SphereTraceWorld Copy()
	{
		return this;
	}

	public static FRigUnit_SphereTraceWorld FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SphereTraceWorld(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SphereTraceWorld value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SphereTraceWorld FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SphereTraceWorld(nativeBuffer + arrayIndex * FRigUnit_SphereTraceWorld_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SphereTraceWorld value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SphereTraceWorld_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphereTraceWorld_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphereTraceWorld");
		}
	}

	public FRigUnit_SphereTraceWorld(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphereTraceWorld_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphereTraceWorld");
		}
	}

	static FRigUnit_SphereTraceWorld()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SphereTraceWorld)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SphereTraceWorld));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SphereTraceWorld");
		FRigUnit_SphereTraceWorld_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SphereTraceWorld_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SphereTraceWorld", FRigUnit_SphereTraceWorld_IsValid);
	}
}
