using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SlideChainItemArray", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SlideChainItemArray
{
	private static bool FRigUnit_SlideChainItemArray_IsValid;

	private static int FRigUnit_SlideChainItemArray_StructSize;

	public FRigUnit_SlideChainItemArray Copy()
	{
		return this;
	}

	public static FRigUnit_SlideChainItemArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SlideChainItemArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SlideChainItemArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SlideChainItemArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SlideChainItemArray(nativeBuffer + arrayIndex * FRigUnit_SlideChainItemArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SlideChainItemArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SlideChainItemArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SlideChainItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SlideChainItemArray");
		}
	}

	public FRigUnit_SlideChainItemArray(IntPtr nativeStruct)
	{
		if (!FRigUnit_SlideChainItemArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SlideChainItemArray");
		}
	}

	static FRigUnit_SlideChainItemArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SlideChainItemArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SlideChainItemArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SlideChainItemArray");
		FRigUnit_SlideChainItemArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SlideChainItemArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SlideChainItemArray", FRigUnit_SlideChainItemArray_IsValid);
	}
}
