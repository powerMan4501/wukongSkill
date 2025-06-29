using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_Add_FloatFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_Add_FloatFloat
{
	private static bool FRigUnit_Add_FloatFloat_IsValid;

	private static int FRigUnit_Add_FloatFloat_StructSize;

	public FRigUnit_Add_FloatFloat Copy()
	{
		return this;
	}

	public static FRigUnit_Add_FloatFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_Add_FloatFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_Add_FloatFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_Add_FloatFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_Add_FloatFloat(nativeBuffer + arrayIndex * FRigUnit_Add_FloatFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_Add_FloatFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_Add_FloatFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_Add_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Add_FloatFloat");
		}
	}

	public FRigUnit_Add_FloatFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_Add_FloatFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_Add_FloatFloat");
		}
	}

	static FRigUnit_Add_FloatFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_Add_FloatFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_Add_FloatFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_Add_FloatFloat");
		FRigUnit_Add_FloatFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_Add_FloatFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_Add_FloatFloat", FRigUnit_Add_FloatFloat_IsValid);
	}
}
