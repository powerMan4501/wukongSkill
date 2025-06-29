using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AnimEasingType", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AnimEasingType
{
	private static bool FRigUnit_AnimEasingType_IsValid;

	private static int FRigUnit_AnimEasingType_StructSize;

	public FRigUnit_AnimEasingType Copy()
	{
		return this;
	}

	public static FRigUnit_AnimEasingType FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AnimEasingType(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AnimEasingType value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AnimEasingType FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AnimEasingType(nativeBuffer + arrayIndex * FRigUnit_AnimEasingType_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AnimEasingType value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AnimEasingType_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimEasingType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimEasingType");
		}
	}

	public FRigUnit_AnimEasingType(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimEasingType_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimEasingType");
		}
	}

	static FRigUnit_AnimEasingType()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AnimEasingType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AnimEasingType));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AnimEasingType");
		FRigUnit_AnimEasingType_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AnimEasingType_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AnimEasingType", FRigUnit_AnimEasingType_IsValid);
	}
}
