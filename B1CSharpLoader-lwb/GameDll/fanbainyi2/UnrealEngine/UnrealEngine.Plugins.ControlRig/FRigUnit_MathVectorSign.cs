using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorSign", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorSign
{
	private static bool FRigUnit_MathVectorSign_IsValid;

	private static int FRigUnit_MathVectorSign_StructSize;

	public FRigUnit_MathVectorSign Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorSign FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorSign(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorSign value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorSign FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorSign(nativeBuffer + arrayIndex * FRigUnit_MathVectorSign_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorSign value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorSign_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSign_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSign");
		}
	}

	public FRigUnit_MathVectorSign(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSign_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSign");
		}
	}

	static FRigUnit_MathVectorSign()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorSign)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorSign));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorSign");
		FRigUnit_MathVectorSign_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorSign_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorSign", FRigUnit_MathVectorSign_IsValid);
	}
}
