using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MapRange_Float", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MapRange_Float
{
	private static bool FRigUnit_MapRange_Float_IsValid;

	private static int FRigUnit_MapRange_Float_StructSize;

	public FRigUnit_MapRange_Float Copy()
	{
		return this;
	}

	public static FRigUnit_MapRange_Float FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MapRange_Float(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MapRange_Float value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MapRange_Float FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MapRange_Float(nativeBuffer + arrayIndex * FRigUnit_MapRange_Float_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MapRange_Float value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MapRange_Float_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MapRange_Float_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MapRange_Float");
		}
	}

	public FRigUnit_MapRange_Float(IntPtr nativeStruct)
	{
		if (!FRigUnit_MapRange_Float_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MapRange_Float");
		}
	}

	static FRigUnit_MapRange_Float()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MapRange_Float)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MapRange_Float));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MapRange_Float");
		FRigUnit_MapRange_Float_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MapRange_Float_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MapRange_Float", FRigUnit_MapRange_Float_IsValid);
	}
}
