using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SphereTraceByTraceChannel", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SphereTraceByTraceChannel
{
	private static bool FRigUnit_SphereTraceByTraceChannel_IsValid;

	private static int FRigUnit_SphereTraceByTraceChannel_StructSize;

	public FRigUnit_SphereTraceByTraceChannel Copy()
	{
		return this;
	}

	public static FRigUnit_SphereTraceByTraceChannel FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SphereTraceByTraceChannel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SphereTraceByTraceChannel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SphereTraceByTraceChannel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SphereTraceByTraceChannel(nativeBuffer + arrayIndex * FRigUnit_SphereTraceByTraceChannel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SphereTraceByTraceChannel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SphereTraceByTraceChannel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphereTraceByTraceChannel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphereTraceByTraceChannel");
		}
	}

	public FRigUnit_SphereTraceByTraceChannel(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphereTraceByTraceChannel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphereTraceByTraceChannel");
		}
	}

	static FRigUnit_SphereTraceByTraceChannel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SphereTraceByTraceChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SphereTraceByTraceChannel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SphereTraceByTraceChannel");
		FRigUnit_SphereTraceByTraceChannel_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SphereTraceByTraceChannel_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SphereTraceByTraceChannel", FRigUnit_SphereTraceByTraceChannel_IsValid);
	}
}
