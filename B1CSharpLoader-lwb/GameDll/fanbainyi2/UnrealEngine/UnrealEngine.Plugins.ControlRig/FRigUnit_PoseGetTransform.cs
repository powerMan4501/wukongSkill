using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_PoseGetTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PoseGetTransform
{
	private static bool FRigUnit_PoseGetTransform_IsValid;

	private static int FRigUnit_PoseGetTransform_StructSize;

	public FRigUnit_PoseGetTransform Copy()
	{
		return this;
	}

	public static FRigUnit_PoseGetTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PoseGetTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PoseGetTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PoseGetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PoseGetTransform(nativeBuffer + arrayIndex * FRigUnit_PoseGetTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PoseGetTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PoseGetTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetTransform");
		}
	}

	public FRigUnit_PoseGetTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_PoseGetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_PoseGetTransform");
		}
	}

	static FRigUnit_PoseGetTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PoseGetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PoseGetTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_PoseGetTransform");
		FRigUnit_PoseGetTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PoseGetTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_PoseGetTransform", FRigUnit_PoseGetTransform_IsValid);
	}
}
