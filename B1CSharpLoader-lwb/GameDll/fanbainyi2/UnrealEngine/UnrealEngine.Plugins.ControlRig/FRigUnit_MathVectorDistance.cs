using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorDistance", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorDistance
{
	private static bool FRigUnit_MathVectorDistance_IsValid;

	private static int FRigUnit_MathVectorDistance_StructSize;

	public FRigUnit_MathVectorDistance Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorDistance FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorDistance(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorDistance value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorDistance FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorDistance(nativeBuffer + arrayIndex * FRigUnit_MathVectorDistance_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorDistance value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorDistance_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDistance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDistance");
		}
	}

	public FRigUnit_MathVectorDistance(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorDistance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorDistance");
		}
	}

	static FRigUnit_MathVectorDistance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorDistance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorDistance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorDistance");
		FRigUnit_MathVectorDistance_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorDistance_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorDistance", FRigUnit_MathVectorDistance_IsValid);
	}
}
