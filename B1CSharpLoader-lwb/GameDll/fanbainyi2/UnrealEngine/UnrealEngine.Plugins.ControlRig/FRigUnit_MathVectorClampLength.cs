using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorClampLength", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorClampLength
{
	private static bool FRigUnit_MathVectorClampLength_IsValid;

	private static int FRigUnit_MathVectorClampLength_StructSize;

	public FRigUnit_MathVectorClampLength Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorClampLength FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorClampLength(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorClampLength value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorClampLength FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorClampLength(nativeBuffer + arrayIndex * FRigUnit_MathVectorClampLength_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorClampLength value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorClampLength_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorClampLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorClampLength");
		}
	}

	public FRigUnit_MathVectorClampLength(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorClampLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorClampLength");
		}
	}

	static FRigUnit_MathVectorClampLength()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorClampLength)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorClampLength));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorClampLength");
		FRigUnit_MathVectorClampLength_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorClampLength_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorClampLength", FRigUnit_MathVectorClampLength_IsValid);
	}
}
