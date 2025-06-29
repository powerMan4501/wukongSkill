using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_RandomFloat", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_RandomFloat
{
	private static bool FRigUnit_RandomFloat_IsValid;

	private static int FRigUnit_RandomFloat_StructSize;

	public FRigUnit_RandomFloat Copy()
	{
		return this;
	}

	public static FRigUnit_RandomFloat FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_RandomFloat(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_RandomFloat value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_RandomFloat FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_RandomFloat(nativeBuffer + arrayIndex * FRigUnit_RandomFloat_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_RandomFloat value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_RandomFloat_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_RandomFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RandomFloat");
		}
	}

	public FRigUnit_RandomFloat(IntPtr nativeStruct)
	{
		if (!FRigUnit_RandomFloat_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_RandomFloat");
		}
	}

	static FRigUnit_RandomFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_RandomFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_RandomFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_RandomFloat");
		FRigUnit_RandomFloat_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_RandomFloat_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_RandomFloat", FRigUnit_RandomFloat_IsValid);
	}
}
