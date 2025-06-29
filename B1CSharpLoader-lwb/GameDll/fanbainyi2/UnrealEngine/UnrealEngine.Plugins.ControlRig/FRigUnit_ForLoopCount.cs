using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_ForLoopCount", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_ForLoopCount
{
	private static bool FRigUnit_ForLoopCount_IsValid;

	private static int FRigUnit_ForLoopCount_StructSize;

	public FRigUnit_ForLoopCount Copy()
	{
		return this;
	}

	public static FRigUnit_ForLoopCount FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_ForLoopCount(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_ForLoopCount value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_ForLoopCount FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_ForLoopCount(nativeBuffer + arrayIndex * FRigUnit_ForLoopCount_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_ForLoopCount value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_ForLoopCount_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_ForLoopCount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ForLoopCount");
		}
	}

	public FRigUnit_ForLoopCount(IntPtr nativeStruct)
	{
		if (!FRigUnit_ForLoopCount_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_ForLoopCount");
		}
	}

	static FRigUnit_ForLoopCount()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_ForLoopCount)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_ForLoopCount));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_ForLoopCount");
		FRigUnit_ForLoopCount_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_ForLoopCount_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_ForLoopCount", FRigUnit_ForLoopCount_IsValid);
	}
}
