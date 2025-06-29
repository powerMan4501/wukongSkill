using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigControlModifiedContext", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigControlModifiedContext
{
	private static bool FRigControlModifiedContext_IsValid;

	private static int FRigControlModifiedContext_StructSize;

	public FRigControlModifiedContext Copy()
	{
		return this;
	}

	public static FRigControlModifiedContext FromNative(IntPtr nativeBuffer)
	{
		return new FRigControlModifiedContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigControlModifiedContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigControlModifiedContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigControlModifiedContext(nativeBuffer + arrayIndex * FRigControlModifiedContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigControlModifiedContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigControlModifiedContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigControlModifiedContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlModifiedContext");
		}
	}

	public FRigControlModifiedContext(IntPtr nativeStruct)
	{
		if (!FRigControlModifiedContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigControlModifiedContext");
		}
	}

	static FRigControlModifiedContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigControlModifiedContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigControlModifiedContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigControlModifiedContext");
		FRigControlModifiedContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigControlModifiedContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigControlModifiedContext", FRigControlModifiedContext_IsValid);
	}
}
