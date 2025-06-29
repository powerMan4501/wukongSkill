using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_NameConcat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_NameConcat
{
	private static bool FRigUnit_NameConcat_IsValid;

	private static int FRigUnit_NameConcat_StructSize;

	public FRigUnit_NameConcat Copy()
	{
		return this;
	}

	public static FRigUnit_NameConcat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_NameConcat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_NameConcat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_NameConcat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_NameConcat(nativeBuffer + arrayIndex * FRigUnit_NameConcat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_NameConcat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_NameConcat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameConcat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameConcat");
		}
	}

	public FRigUnit_NameConcat(IntPtr nativeStruct)
	{
		if (!FRigUnit_NameConcat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_NameConcat");
		}
	}

	static FRigUnit_NameConcat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_NameConcat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_NameConcat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_NameConcat");
		FRigUnit_NameConcat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_NameConcat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_NameConcat", FRigUnit_NameConcat_IsValid);
	}
}
