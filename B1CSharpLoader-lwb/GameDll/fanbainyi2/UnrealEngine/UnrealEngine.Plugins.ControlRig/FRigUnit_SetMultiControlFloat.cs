using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SetMultiControlFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SetMultiControlFloat
{
	private static bool FRigUnit_SetMultiControlFloat_IsValid;

	private static int FRigUnit_SetMultiControlFloat_StructSize;

	public FRigUnit_SetMultiControlFloat Copy()
	{
		return this;
	}

	public static FRigUnit_SetMultiControlFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SetMultiControlFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SetMultiControlFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SetMultiControlFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SetMultiControlFloat(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SetMultiControlFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SetMultiControlFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlFloat");
		}
	}

	public FRigUnit_SetMultiControlFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_SetMultiControlFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SetMultiControlFloat");
		}
	}

	static FRigUnit_SetMultiControlFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SetMultiControlFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SetMultiControlFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SetMultiControlFloat");
		FRigUnit_SetMultiControlFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SetMultiControlFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SetMultiControlFloat", FRigUnit_SetMultiControlFloat_IsValid);
	}
}
