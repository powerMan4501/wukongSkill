using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorAbs", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorAbs
{
	private static bool FRigUnit_MathVectorAbs_IsValid;

	private static int FRigUnit_MathVectorAbs_StructSize;

	public FRigUnit_MathVectorAbs Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorAbs FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorAbs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorAbs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorAbs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorAbs(nativeBuffer + arrayIndex * FRigUnit_MathVectorAbs_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorAbs value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorAbs_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorAbs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorAbs");
		}
	}

	public FRigUnit_MathVectorAbs(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorAbs_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorAbs");
		}
	}

	static FRigUnit_MathVectorAbs()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorAbs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorAbs));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorAbs");
		FRigUnit_MathVectorAbs_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorAbs_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorAbs", FRigUnit_MathVectorAbs_IsValid);
	}
}
