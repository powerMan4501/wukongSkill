using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorLength", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorLength
{
	private static bool FRigUnit_MathVectorLength_IsValid;

	private static int FRigUnit_MathVectorLength_StructSize;

	public FRigUnit_MathVectorLength Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorLength FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorLength(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorLength value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorLength FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorLength(nativeBuffer + arrayIndex * FRigUnit_MathVectorLength_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorLength value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorLength_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorLength");
		}
	}

	public FRigUnit_MathVectorLength(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorLength");
		}
	}

	static FRigUnit_MathVectorLength()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorLength)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorLength));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorLength");
		FRigUnit_MathVectorLength_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorLength_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorLength", FRigUnit_MathVectorLength_IsValid);
	}
}
