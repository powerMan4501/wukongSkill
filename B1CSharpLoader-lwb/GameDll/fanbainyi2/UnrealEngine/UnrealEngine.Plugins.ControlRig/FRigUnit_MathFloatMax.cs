using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatMax", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatMax
{
	private static bool FRigUnit_MathFloatMax_IsValid;

	private static int FRigUnit_MathFloatMax_StructSize;

	public FRigUnit_MathFloatMax Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatMax FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatMax(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatMax value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatMax FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatMax(nativeBuffer + arrayIndex * FRigUnit_MathFloatMax_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatMax value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatMax_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMax_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMax");
		}
	}

	public FRigUnit_MathFloatMax(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatMax_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatMax");
		}
	}

	static FRigUnit_MathFloatMax()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatMax)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatMax));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatMax");
		FRigUnit_MathFloatMax_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatMax_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatMax", FRigUnit_MathFloatMax_IsValid);
	}
}
