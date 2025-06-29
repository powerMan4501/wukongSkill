using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DrawContainerSetColor", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DrawContainerSetColor
{
	private static bool FRigUnit_DrawContainerSetColor_IsValid;

	private static int FRigUnit_DrawContainerSetColor_StructSize;

	public FRigUnit_DrawContainerSetColor Copy()
	{
		return this;
	}

	public static FRigUnit_DrawContainerSetColor FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DrawContainerSetColor(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DrawContainerSetColor value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DrawContainerSetColor FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DrawContainerSetColor(nativeBuffer + arrayIndex * FRigUnit_DrawContainerSetColor_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DrawContainerSetColor value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DrawContainerSetColor_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerSetColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerSetColor");
		}
	}

	public FRigUnit_DrawContainerSetColor(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerSetColor_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerSetColor");
		}
	}

	static FRigUnit_DrawContainerSetColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DrawContainerSetColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DrawContainerSetColor));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DrawContainerSetColor");
		FRigUnit_DrawContainerSetColor_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DrawContainerSetColor_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DrawContainerSetColor", FRigUnit_DrawContainerSetColor_IsValid);
	}
}
