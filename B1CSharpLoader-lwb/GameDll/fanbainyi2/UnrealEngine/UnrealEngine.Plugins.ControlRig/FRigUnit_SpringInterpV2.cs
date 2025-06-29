using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SpringInterpV2", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SpringInterpV2
{
	private static bool FRigUnit_SpringInterpV2_IsValid;

	private static int FRigUnit_SpringInterpV2_StructSize;

	public FRigUnit_SpringInterpV2 Copy()
	{
		return this;
	}

	public static FRigUnit_SpringInterpV2 FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SpringInterpV2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SpringInterpV2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SpringInterpV2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SpringInterpV2(nativeBuffer + arrayIndex * FRigUnit_SpringInterpV2_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SpringInterpV2 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SpringInterpV2_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpV2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpV2");
		}
	}

	public FRigUnit_SpringInterpV2(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpV2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpV2");
		}
	}

	static FRigUnit_SpringInterpV2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SpringInterpV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SpringInterpV2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SpringInterpV2");
		FRigUnit_SpringInterpV2_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SpringInterpV2_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SpringInterpV2", FRigUnit_SpringInterpV2_IsValid);
	}
}
