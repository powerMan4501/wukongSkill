using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorRemap", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorRemap
{
	private static bool FRigUnit_MathVectorRemap_IsValid;

	private static int FRigUnit_MathVectorRemap_StructSize;

	public FRigUnit_MathVectorRemap Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorRemap FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorRemap(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorRemap value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorRemap FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorRemap(nativeBuffer + arrayIndex * FRigUnit_MathVectorRemap_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorRemap value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorRemap_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorRemap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorRemap");
		}
	}

	public FRigUnit_MathVectorRemap(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorRemap_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorRemap");
		}
	}

	static FRigUnit_MathVectorRemap()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorRemap)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorRemap));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorRemap");
		FRigUnit_MathVectorRemap_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorRemap_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorRemap", FRigUnit_MathVectorRemap_IsValid);
	}
}
