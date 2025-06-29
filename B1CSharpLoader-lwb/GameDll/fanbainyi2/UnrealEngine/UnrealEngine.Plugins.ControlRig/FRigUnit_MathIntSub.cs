using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathIntSub", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathIntSub
{
	private static bool FRigUnit_MathIntSub_IsValid;

	private static int FRigUnit_MathIntSub_StructSize;

	public FRigUnit_MathIntSub Copy()
	{
		return this;
	}

	public static FRigUnit_MathIntSub FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathIntSub(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathIntSub value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathIntSub FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathIntSub(nativeBuffer + arrayIndex * FRigUnit_MathIntSub_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathIntSub value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathIntSub_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntSub");
		}
	}

	public FRigUnit_MathIntSub(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathIntSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathIntSub");
		}
	}

	static FRigUnit_MathIntSub()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathIntSub)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathIntSub));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathIntSub");
		FRigUnit_MathIntSub_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathIntSub_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathIntSub", FRigUnit_MathIntSub_IsValid);
	}
}
