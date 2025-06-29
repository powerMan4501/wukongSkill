using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Clamp_Float", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Clamp_Float
{
	private static bool FRigUnit_Clamp_Float_IsValid;

	private static int FRigUnit_Clamp_Float_StructSize;

	public FRigUnit_Clamp_Float Copy()
	{
		return this;
	}

	public static FRigUnit_Clamp_Float FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Clamp_Float(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Clamp_Float value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Clamp_Float FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Clamp_Float(nativeBuffer + arrayIndex * FRigUnit_Clamp_Float_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Clamp_Float value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Clamp_Float_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Clamp_Float_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Clamp_Float");
		}
	}

	public FRigUnit_Clamp_Float(IntPtr nativeStruct)
	{
		if (!FRigUnit_Clamp_Float_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Clamp_Float");
		}
	}

	static FRigUnit_Clamp_Float()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Clamp_Float)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Clamp_Float));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Clamp_Float");
		FRigUnit_Clamp_Float_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Clamp_Float_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Clamp_Float", FRigUnit_Clamp_Float_IsValid);
	}
}
