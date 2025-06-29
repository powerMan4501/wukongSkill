using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorClamp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorClamp
{
	private static bool FRigUnit_MathVectorClamp_IsValid;

	private static int FRigUnit_MathVectorClamp_StructSize;

	public FRigUnit_MathVectorClamp Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorClamp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorClamp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorClamp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorClamp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorClamp(nativeBuffer + arrayIndex * FRigUnit_MathVectorClamp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorClamp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorClamp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorClamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorClamp");
		}
	}

	public FRigUnit_MathVectorClamp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorClamp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorClamp");
		}
	}

	static FRigUnit_MathVectorClamp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorClamp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorClamp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorClamp");
		FRigUnit_MathVectorClamp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorClamp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorClamp", FRigUnit_MathVectorClamp_IsValid);
	}
}
