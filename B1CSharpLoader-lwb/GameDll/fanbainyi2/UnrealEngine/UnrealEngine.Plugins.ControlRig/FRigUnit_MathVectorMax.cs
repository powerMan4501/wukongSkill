using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorMax", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorMax
{
	private static bool FRigUnit_MathVectorMax_IsValid;

	private static int FRigUnit_MathVectorMax_StructSize;

	public FRigUnit_MathVectorMax Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorMax FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorMax(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorMax value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorMax FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorMax(nativeBuffer + arrayIndex * FRigUnit_MathVectorMax_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorMax value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorMax_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMax_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMax");
		}
	}

	public FRigUnit_MathVectorMax(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMax_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMax");
		}
	}

	static FRigUnit_MathVectorMax()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorMax)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorMax));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorMax");
		FRigUnit_MathVectorMax_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorMax_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorMax", FRigUnit_MathVectorMax_IsValid);
	}
}
