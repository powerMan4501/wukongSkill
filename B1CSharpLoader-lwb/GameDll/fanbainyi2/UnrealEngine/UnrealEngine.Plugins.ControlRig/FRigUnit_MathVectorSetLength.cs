using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorSetLength", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorSetLength
{
	private static bool FRigUnit_MathVectorSetLength_IsValid;

	private static int FRigUnit_MathVectorSetLength_StructSize;

	public FRigUnit_MathVectorSetLength Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorSetLength FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorSetLength(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorSetLength value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorSetLength FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorSetLength(nativeBuffer + arrayIndex * FRigUnit_MathVectorSetLength_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorSetLength value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorSetLength_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSetLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSetLength");
		}
	}

	public FRigUnit_MathVectorSetLength(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSetLength_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSetLength");
		}
	}

	static FRigUnit_MathVectorSetLength()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorSetLength)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorSetLength));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorSetLength");
		FRigUnit_MathVectorSetLength_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorSetLength_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorSetLength", FRigUnit_MathVectorSetLength_IsValid);
	}
}
