using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorRad", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorRad
{
	private static bool FRigUnit_MathVectorRad_IsValid;

	private static int FRigUnit_MathVectorRad_StructSize;

	public FRigUnit_MathVectorRad Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorRad FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorRad(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorRad value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorRad FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorRad(nativeBuffer + arrayIndex * FRigUnit_MathVectorRad_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorRad value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorRad_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorRad_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorRad");
		}
	}

	public FRigUnit_MathVectorRad(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorRad_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorRad");
		}
	}

	static FRigUnit_MathVectorRad()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorRad)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorRad));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorRad");
		FRigUnit_MathVectorRad_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorRad_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorRad", FRigUnit_MathVectorRad_IsValid);
	}
}
