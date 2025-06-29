using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.RigVMFunctionReferenceArray", "RigVMDeveloper", UnrealModuleType.Engine)]
public struct FRigVMFunctionReferenceArray
{
	private static bool FRigVMFunctionReferenceArray_IsValid;

	private static int FRigVMFunctionReferenceArray_StructSize;

	public FRigVMFunctionReferenceArray Copy()
	{
		return this;
	}

	public static FRigVMFunctionReferenceArray FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMFunctionReferenceArray(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMFunctionReferenceArray value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMFunctionReferenceArray FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMFunctionReferenceArray(nativeBuffer + arrayIndex * FRigVMFunctionReferenceArray_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMFunctionReferenceArray value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMFunctionReferenceArray_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMFunctionReferenceArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMFunctionReferenceArray");
		}
	}

	public FRigVMFunctionReferenceArray(IntPtr nativeStruct)
	{
		if (!FRigVMFunctionReferenceArray_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVMDeveloper.RigVMFunctionReferenceArray");
		}
	}

	static FRigVMFunctionReferenceArray()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMFunctionReferenceArray)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMFunctionReferenceArray));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVMDeveloper.RigVMFunctionReferenceArray");
		FRigVMFunctionReferenceArray_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigVMFunctionReferenceArray_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/RigVMDeveloper.RigVMFunctionReferenceArray", FRigVMFunctionReferenceArray_IsValid);
	}
}
