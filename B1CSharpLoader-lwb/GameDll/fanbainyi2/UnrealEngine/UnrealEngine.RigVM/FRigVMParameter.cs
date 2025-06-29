using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.RigVM;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/RigVM.RigVMParameter", "RigVM", UnrealModuleType.Engine)]
public struct FRigVMParameter
{
	private static bool FRigVMParameter_IsValid;

	private static int FRigVMParameter_StructSize;

	public FRigVMParameter Copy()
	{
		return this;
	}

	public static FRigVMParameter FromNative(IntPtr nativeBuffer)
	{
		return new FRigVMParameter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigVMParameter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigVMParameter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigVMParameter(nativeBuffer + arrayIndex * FRigVMParameter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigVMParameter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigVMParameter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigVMParameter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMParameter");
		}
	}

	public FRigVMParameter(IntPtr nativeStruct)
	{
		if (!FRigVMParameter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/RigVM.RigVMParameter");
		}
	}

	static FRigVMParameter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigVMParameter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigVMParameter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/RigVM.RigVMParameter");
		FRigVMParameter_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigVMParameter_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/RigVM.RigVMParameter", FRigVMParameter_IsValid);
	}
}
