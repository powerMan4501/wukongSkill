using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorMod", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorMod
{
	private static bool FRigUnit_MathVectorMod_IsValid;

	private static int FRigUnit_MathVectorMod_StructSize;

	public FRigUnit_MathVectorMod Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorMod FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorMod(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorMod value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorMod FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorMod(nativeBuffer + arrayIndex * FRigUnit_MathVectorMod_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorMod value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorMod_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMod");
		}
	}

	public FRigUnit_MathVectorMod(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMod_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMod");
		}
	}

	static FRigUnit_MathVectorMod()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorMod)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorMod));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorMod");
		FRigUnit_MathVectorMod_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorMod_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorMod", FRigUnit_MathVectorMod_IsValid);
	}
}
