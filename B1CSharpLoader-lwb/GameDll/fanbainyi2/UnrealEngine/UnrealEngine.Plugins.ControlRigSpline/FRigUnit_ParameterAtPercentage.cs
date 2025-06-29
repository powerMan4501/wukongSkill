using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRigSpline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRigSpline.RigUnit_ParameterAtPercentage", "ControlRigSpline", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ParameterAtPercentage
{
	private static bool FRigUnit_ParameterAtPercentage_IsValid;

	private static int FRigUnit_ParameterAtPercentage_StructSize;

	public FRigUnit_ParameterAtPercentage Copy()
	{
		return this;
	}

	public static FRigUnit_ParameterAtPercentage FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ParameterAtPercentage(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ParameterAtPercentage value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ParameterAtPercentage FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ParameterAtPercentage(nativeBuffer + arrayIndex * FRigUnit_ParameterAtPercentage_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ParameterAtPercentage value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ParameterAtPercentage_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParameterAtPercentage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ParameterAtPercentage");
		}
	}

	public FRigUnit_ParameterAtPercentage(IntPtr nativeStruct)
	{
		if (!FRigUnit_ParameterAtPercentage_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRigSpline.RigUnit_ParameterAtPercentage");
		}
	}

	static FRigUnit_ParameterAtPercentage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ParameterAtPercentage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ParameterAtPercentage));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRigSpline.RigUnit_ParameterAtPercentage");
		FRigUnit_ParameterAtPercentage_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ParameterAtPercentage_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRigSpline.RigUnit_ParameterAtPercentage", FRigUnit_ParameterAtPercentage_IsValid);
	}
}
