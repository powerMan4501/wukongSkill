using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DrawContainerSetTransform", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DrawContainerSetTransform
{
	private static bool FRigUnit_DrawContainerSetTransform_IsValid;

	private static int FRigUnit_DrawContainerSetTransform_StructSize;

	public FRigUnit_DrawContainerSetTransform Copy()
	{
		return this;
	}

	public static FRigUnit_DrawContainerSetTransform FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DrawContainerSetTransform(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DrawContainerSetTransform value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DrawContainerSetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DrawContainerSetTransform(nativeBuffer + arrayIndex * FRigUnit_DrawContainerSetTransform_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DrawContainerSetTransform value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DrawContainerSetTransform_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerSetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerSetTransform");
		}
	}

	public FRigUnit_DrawContainerSetTransform(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerSetTransform_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerSetTransform");
		}
	}

	static FRigUnit_DrawContainerSetTransform()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DrawContainerSetTransform)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DrawContainerSetTransform));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DrawContainerSetTransform");
		FRigUnit_DrawContainerSetTransform_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DrawContainerSetTransform_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DrawContainerSetTransform", FRigUnit_DrawContainerSetTransform_IsValid);
	}
}
