using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigEventContext", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigEventContext
{
	private static bool FRigEventContext_IsValid;

	private static int FRigEventContext_StructSize;

	public FRigEventContext Copy()
	{
		return this;
	}

	public static FRigEventContext FromNative(IntPtr nativeBuffer)
	{
		return new FRigEventContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigEventContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigEventContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigEventContext(nativeBuffer + arrayIndex * FRigEventContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigEventContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigEventContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigEventContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigEventContext");
		}
	}

	public FRigEventContext(IntPtr nativeStruct)
	{
		if (!FRigEventContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigEventContext");
		}
	}

	static FRigEventContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigEventContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigEventContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigEventContext");
		FRigEventContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigEventContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigEventContext", FRigEventContext_IsValid);
	}
}
