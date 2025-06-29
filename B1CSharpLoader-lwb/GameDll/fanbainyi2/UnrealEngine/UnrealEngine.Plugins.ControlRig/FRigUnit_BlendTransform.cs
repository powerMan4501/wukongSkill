using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_BlendTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_BlendTransform
{
	private static bool FRigUnit_BlendTransform_IsValid;

	private static int FRigUnit_BlendTransform_StructSize;

	public FRigUnit_BlendTransform Copy()
	{
		return this;
	}

	public static FRigUnit_BlendTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_BlendTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_BlendTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_BlendTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_BlendTransform(nativeBuffer + arrayIndex * FRigUnit_BlendTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_BlendTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_BlendTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_BlendTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BlendTransform");
		}
	}

	public FRigUnit_BlendTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_BlendTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_BlendTransform");
		}
	}

	static FRigUnit_BlendTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_BlendTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_BlendTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_BlendTransform");
		FRigUnit_BlendTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_BlendTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_BlendTransform", FRigUnit_BlendTransform_IsValid);
	}
}
