using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_NameReplace", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_NameReplace
{
	private static bool FRigUnit_NameReplace_IsValid;

	private static int FRigUnit_NameReplace_StructSize;

	public FRigUnit_NameReplace Copy()
	{
		return this;
	}

	public static FRigUnit_NameReplace FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_NameReplace(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_NameReplace value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_NameReplace FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_NameReplace(nativeBuffer + arrayIndex * FRigUnit_NameReplace_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_NameReplace value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_NameReplace_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameReplace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameReplace");
		}
	}

	public FRigUnit_NameReplace(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameReplace_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameReplace");
		}
	}

	static FRigUnit_NameReplace()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_NameReplace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_NameReplace));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_NameReplace");
		FRigUnit_NameReplace_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_NameReplace_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_NameReplace", FRigUnit_NameReplace_IsValid);
	}
}
