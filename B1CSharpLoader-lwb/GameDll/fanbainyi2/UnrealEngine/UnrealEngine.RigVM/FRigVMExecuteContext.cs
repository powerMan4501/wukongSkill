using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[UMetaPath("/Script/RigVM.RigVMExecuteContext", "RigVM", UnrealModuleType.Engine)]
public struct FRigVMExecuteContext
{
	private static bool FRigVMExecuteContext_IsValid;

	private static int FRigVMExecuteContext_StructSize;

	public FRigVMExecuteContext Copy()
	{
		return this;
	}

	public static FRigVMExecuteContext FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMExecuteContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMExecuteContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMExecuteContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMExecuteContext(nativeBuffer + arrayIndex * FRigVMExecuteContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMExecuteContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMExecuteContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMExecuteContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMExecuteContext");
		}
	}

	public FRigVMExecuteContext(IntPtr nativeStruct)
	{
		if (!FRigVMExecuteContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMExecuteContext");
		}
	}

	static FRigVMExecuteContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMExecuteContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMExecuteContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVM.RigVMExecuteContext");
		FRigVMExecuteContext_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigVMExecuteContext_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/RigVM.RigVMExecuteContext", FRigVMExecuteContext_IsValid);
	}
}
