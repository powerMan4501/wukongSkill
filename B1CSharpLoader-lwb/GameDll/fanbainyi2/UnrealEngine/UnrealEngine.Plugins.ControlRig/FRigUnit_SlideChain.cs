using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SlideChain", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SlideChain
{
	private static bool FRigUnit_SlideChain_IsValid;

	private static int FRigUnit_SlideChain_StructSize;

	public FRigUnit_SlideChain Copy()
	{
		return this;
	}

	public static FRigUnit_SlideChain FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SlideChain(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SlideChain value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SlideChain FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SlideChain(nativeBuffer + arrayIndex * FRigUnit_SlideChain_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SlideChain value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SlideChain_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SlideChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SlideChain");
		}
	}

	public FRigUnit_SlideChain(IntPtr nativeStruct)
	{
		if (!FRigUnit_SlideChain_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SlideChain");
		}
	}

	static FRigUnit_SlideChain()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SlideChain)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SlideChain));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SlideChain");
		FRigUnit_SlideChain_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SlideChain_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SlideChain", FRigUnit_SlideChain_IsValid);
	}
}
