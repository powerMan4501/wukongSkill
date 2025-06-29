using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_SecondsToFrames", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_SecondsToFrames
{
	private static bool FRigUnit_SecondsToFrames_IsValid;

	private static int FRigUnit_SecondsToFrames_StructSize;

	public FRigUnit_SecondsToFrames Copy()
	{
		return this;
	}

	public static FRigUnit_SecondsToFrames FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_SecondsToFrames(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_SecondsToFrames value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_SecondsToFrames FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_SecondsToFrames(nativeBuffer + arrayIndex * FRigUnit_SecondsToFrames_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_SecondsToFrames value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_SecondsToFrames_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_SecondsToFrames_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SecondsToFrames");
		}
	}

	public FRigUnit_SecondsToFrames(IntPtr nativeStruct)
	{
		if (!FRigUnit_SecondsToFrames_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_SecondsToFrames");
		}
	}

	static FRigUnit_SecondsToFrames()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_SecondsToFrames)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_SecondsToFrames));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_SecondsToFrames");
		FRigUnit_SecondsToFrames_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_SecondsToFrames_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_SecondsToFrames", FRigUnit_SecondsToFrames_IsValid);
	}
}
