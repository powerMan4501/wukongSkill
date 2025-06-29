using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SpringInterpVectorV2", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SpringInterpVectorV2
{
	private static bool FRigUnit_SpringInterpVectorV2_IsValid;

	private static int FRigUnit_SpringInterpVectorV2_StructSize;

	public FRigUnit_SpringInterpVectorV2 Copy()
	{
		return this;
	}

	public static FRigUnit_SpringInterpVectorV2 FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SpringInterpVectorV2(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SpringInterpVectorV2 value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SpringInterpVectorV2 FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SpringInterpVectorV2(nativeBuffer + arrayIndex * FRigUnit_SpringInterpVectorV2_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SpringInterpVectorV2 value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SpringInterpVectorV2_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpVectorV2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpVectorV2");
		}
	}

	public FRigUnit_SpringInterpVectorV2(IntPtr nativeStruct)
	{
		if (!FRigUnit_SpringInterpVectorV2_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SpringInterpVectorV2");
		}
	}

	static FRigUnit_SpringInterpVectorV2()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SpringInterpVectorV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SpringInterpVectorV2));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SpringInterpVectorV2");
		FRigUnit_SpringInterpVectorV2_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SpringInterpVectorV2_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SpringInterpVectorV2", FRigUnit_SpringInterpVectorV2_IsValid);
	}
}
