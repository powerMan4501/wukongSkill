using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnitMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnitMutable
{
	private static bool FRigUnitMutable_IsValid;

	private static int FRigUnitMutable_StructSize;

	public FRigUnitMutable Copy()
	{
		return this;
	}

	public static FRigUnitMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnitMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnitMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnitMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnitMutable(nativeBuffer + arrayIndex * FRigUnitMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnitMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnitMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnitMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnitMutable");
		}
	}

	public FRigUnitMutable(IntPtr nativeStruct)
	{
		if (!FRigUnitMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnitMutable");
		}
	}

	static FRigUnitMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnitMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnitMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnitMutable");
		FRigUnitMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnitMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnitMutable", FRigUnitMutable_IsValid);
	}
}
