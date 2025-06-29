using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AnimEasing", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AnimEasing
{
	private static bool FRigUnit_AnimEasing_IsValid;

	private static int FRigUnit_AnimEasing_StructSize;

	public FRigUnit_AnimEasing Copy()
	{
		return this;
	}

	public static FRigUnit_AnimEasing FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AnimEasing(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AnimEasing value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AnimEasing FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AnimEasing(nativeBuffer + arrayIndex * FRigUnit_AnimEasing_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AnimEasing value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AnimEasing_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimEasing_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimEasing");
		}
	}

	public FRigUnit_AnimEasing(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimEasing_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimEasing");
		}
	}

	static FRigUnit_AnimEasing()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AnimEasing)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AnimEasing));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AnimEasing");
		FRigUnit_AnimEasing_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AnimEasing_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AnimEasing", FRigUnit_AnimEasing_IsValid);
	}
}
