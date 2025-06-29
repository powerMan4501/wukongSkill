using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[UMetaPath("/Script/RigVM.RigVMStruct", "RigVM", UnrealModuleType.Engine)]
public struct FRigVMStruct
{
	private static bool FRigVMStruct_IsValid;

	private static int FRigVMStruct_StructSize;

	public FRigVMStruct Copy()
	{
		return this;
	}

	public static FRigVMStruct FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMStruct(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMStruct value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMStruct FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMStruct(nativeBuffer + arrayIndex * FRigVMStruct_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMStruct value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMStruct_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMStruct");
		}
	}

	public FRigVMStruct(IntPtr nativeStruct)
	{
		if (!FRigVMStruct_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMStruct");
		}
	}

	static FRigVMStruct()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMStruct));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVM.RigVMStruct");
		FRigVMStruct_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigVMStruct_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/RigVM.RigVMStruct", FRigVMStruct_IsValid);
	}
}
