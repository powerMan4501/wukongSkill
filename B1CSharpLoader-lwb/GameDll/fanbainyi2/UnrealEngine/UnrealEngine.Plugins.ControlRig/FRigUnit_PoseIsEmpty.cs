using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseIsEmpty", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseIsEmpty
{
	private static bool FRigUnit_PoseIsEmpty_IsValid;

	private static int FRigUnit_PoseIsEmpty_StructSize;

	public FRigUnit_PoseIsEmpty Copy()
	{
		return this;
	}

	public static FRigUnit_PoseIsEmpty FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseIsEmpty(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseIsEmpty value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseIsEmpty FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseIsEmpty(nativeBuffer + arrayIndex * FRigUnit_PoseIsEmpty_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseIsEmpty value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseIsEmpty_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseIsEmpty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseIsEmpty");
		}
	}

	public FRigUnit_PoseIsEmpty(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseIsEmpty_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseIsEmpty");
		}
	}

	static FRigUnit_PoseIsEmpty()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseIsEmpty)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseIsEmpty));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseIsEmpty");
		FRigUnit_PoseIsEmpty_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseIsEmpty_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseIsEmpty", FRigUnit_PoseIsEmpty_IsValid);
	}
}
