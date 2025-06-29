using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorClampSpatially", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorClampSpatially
{
	private static bool FRigUnit_MathVectorClampSpatially_IsValid;

	private static int FRigUnit_MathVectorClampSpatially_StructSize;

	public FRigUnit_MathVectorClampSpatially Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorClampSpatially FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorClampSpatially(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorClampSpatially value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorClampSpatially FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorClampSpatially(nativeBuffer + arrayIndex * FRigUnit_MathVectorClampSpatially_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorClampSpatially value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorClampSpatially_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorClampSpatially_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorClampSpatially");
		}
	}

	public FRigUnit_MathVectorClampSpatially(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorClampSpatially_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorClampSpatially");
		}
	}

	static FRigUnit_MathVectorClampSpatially()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorClampSpatially)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorClampSpatially));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorClampSpatially");
		FRigUnit_MathVectorClampSpatially_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorClampSpatially_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorClampSpatially", FRigUnit_MathVectorClampSpatially_IsValid);
	}
}
