using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigExecuteContext", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FControlRigExecuteContext
{
	private static bool FControlRigExecuteContext_IsValid;

	private static int FControlRigExecuteContext_StructSize;

	public FControlRigExecuteContext Copy()
	{
		return this;
	}

	public static FControlRigExecuteContext FromNative(IntPtr nativeBuffer)
	{
		return new FControlRigExecuteContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FControlRigExecuteContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FControlRigExecuteContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FControlRigExecuteContext(nativeBuffer + arrayIndex * FControlRigExecuteContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FControlRigExecuteContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FControlRigExecuteContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FControlRigExecuteContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigExecuteContext");
		}
	}

	public FControlRigExecuteContext(IntPtr nativeStruct)
	{
		if (!FControlRigExecuteContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.ControlRigExecuteContext");
		}
	}

	static FControlRigExecuteContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FControlRigExecuteContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FControlRigExecuteContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.ControlRigExecuteContext");
		FControlRigExecuteContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FControlRigExecuteContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.ControlRigExecuteContext", FControlRigExecuteContext_IsValid);
	}
}
