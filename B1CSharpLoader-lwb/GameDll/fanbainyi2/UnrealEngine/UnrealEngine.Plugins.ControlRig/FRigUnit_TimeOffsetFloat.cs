using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_TimeOffsetFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_TimeOffsetFloat
{
	private static bool FRigUnit_TimeOffsetFloat_IsValid;

	private static int FRigUnit_TimeOffsetFloat_StructSize;

	public FRigUnit_TimeOffsetFloat Copy()
	{
		return this;
	}

	public static FRigUnit_TimeOffsetFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_TimeOffsetFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_TimeOffsetFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_TimeOffsetFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_TimeOffsetFloat(nativeBuffer + arrayIndex * FRigUnit_TimeOffsetFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_TimeOffsetFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_TimeOffsetFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_TimeOffsetFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TimeOffsetFloat");
		}
	}

	public FRigUnit_TimeOffsetFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_TimeOffsetFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_TimeOffsetFloat");
		}
	}

	static FRigUnit_TimeOffsetFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_TimeOffsetFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_TimeOffsetFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_TimeOffsetFloat");
		FRigUnit_TimeOffsetFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_TimeOffsetFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_TimeOffsetFloat", FRigUnit_TimeOffsetFloat_IsValid);
	}
}
