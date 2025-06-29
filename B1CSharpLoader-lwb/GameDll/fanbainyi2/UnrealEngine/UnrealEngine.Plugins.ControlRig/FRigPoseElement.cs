using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigPoseElement", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigPoseElement
{
	private static bool FRigPoseElement_IsValid;

	private static int FRigPoseElement_StructSize;

	public FRigPoseElement Copy()
	{
		return this;
	}

	public static FRigPoseElement FromNative(IntPtr nativeBuffer)
	{
		return new FRigPoseElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigPoseElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigPoseElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigPoseElement(nativeBuffer + arrayIndex * FRigPoseElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigPoseElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigPoseElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigPoseElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigPoseElement");
		}
	}

	public FRigPoseElement(IntPtr nativeStruct)
	{
		if (!FRigPoseElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigPoseElement");
		}
	}

	static FRigPoseElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigPoseElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigPoseElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigPoseElement");
		FRigPoseElement_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigPoseElement_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigPoseElement", FRigPoseElement_IsValid);
	}
}
