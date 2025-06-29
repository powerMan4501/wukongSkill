using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorRound", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorRound
{
	private static bool FRigUnit_MathVectorRound_IsValid;

	private static int FRigUnit_MathVectorRound_StructSize;

	public FRigUnit_MathVectorRound Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorRound FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorRound(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorRound value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorRound FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorRound(nativeBuffer + arrayIndex * FRigUnit_MathVectorRound_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorRound value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorRound_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorRound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorRound");
		}
	}

	public FRigUnit_MathVectorRound(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorRound_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorRound");
		}
	}

	static FRigUnit_MathVectorRound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorRound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorRound));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorRound");
		FRigUnit_MathVectorRound_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorRound_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorRound", FRigUnit_MathVectorRound_IsValid);
	}
}
