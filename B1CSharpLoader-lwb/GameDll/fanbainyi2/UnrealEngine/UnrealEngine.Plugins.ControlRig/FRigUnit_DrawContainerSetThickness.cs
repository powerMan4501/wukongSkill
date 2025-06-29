using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_DrawContainerSetThickness", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_DrawContainerSetThickness
{
	private static bool FRigUnit_DrawContainerSetThickness_IsValid;

	private static int FRigUnit_DrawContainerSetThickness_StructSize;

	public FRigUnit_DrawContainerSetThickness Copy()
	{
		return this;
	}

	public static FRigUnit_DrawContainerSetThickness FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_DrawContainerSetThickness(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_DrawContainerSetThickness value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_DrawContainerSetThickness FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_DrawContainerSetThickness(nativeBuffer + arrayIndex * FRigUnit_DrawContainerSetThickness_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_DrawContainerSetThickness value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_DrawContainerSetThickness_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerSetThickness_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerSetThickness");
		}
	}

	public FRigUnit_DrawContainerSetThickness(IntPtr nativeStruct)
	{
		if (!FRigUnit_DrawContainerSetThickness_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_DrawContainerSetThickness");
		}
	}

	static FRigUnit_DrawContainerSetThickness()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_DrawContainerSetThickness)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_DrawContainerSetThickness));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_DrawContainerSetThickness");
		FRigUnit_DrawContainerSetThickness_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_DrawContainerSetThickness_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_DrawContainerSetThickness", FRigUnit_DrawContainerSetThickness_IsValid);
	}
}
