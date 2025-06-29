using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SphereTraceByObjectTypes", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SphereTraceByObjectTypes
{
	private static bool FRigUnit_SphereTraceByObjectTypes_IsValid;

	private static int FRigUnit_SphereTraceByObjectTypes_StructSize;

	public FRigUnit_SphereTraceByObjectTypes Copy()
	{
		return this;
	}

	public static FRigUnit_SphereTraceByObjectTypes FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SphereTraceByObjectTypes(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SphereTraceByObjectTypes value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SphereTraceByObjectTypes FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SphereTraceByObjectTypes(nativeBuffer + arrayIndex * FRigUnit_SphereTraceByObjectTypes_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SphereTraceByObjectTypes value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SphereTraceByObjectTypes_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphereTraceByObjectTypes_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphereTraceByObjectTypes");
		}
	}

	public FRigUnit_SphereTraceByObjectTypes(IntPtr nativeStruct)
	{
		if (!FRigUnit_SphereTraceByObjectTypes_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SphereTraceByObjectTypes");
		}
	}

	static FRigUnit_SphereTraceByObjectTypes()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SphereTraceByObjectTypes)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SphereTraceByObjectTypes));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SphereTraceByObjectTypes");
		FRigUnit_SphereTraceByObjectTypes_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SphereTraceByObjectTypes_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SphereTraceByObjectTypes", FRigUnit_SphereTraceByObjectTypes_IsValid);
	}
}
