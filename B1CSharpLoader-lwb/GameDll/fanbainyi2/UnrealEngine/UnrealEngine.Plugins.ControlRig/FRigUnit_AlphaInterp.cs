using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AlphaInterp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AlphaInterp
{
	private static bool FRigUnit_AlphaInterp_IsValid;

	private static int FRigUnit_AlphaInterp_StructSize;

	public FRigUnit_AlphaInterp Copy()
	{
		return this;
	}

	public static FRigUnit_AlphaInterp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AlphaInterp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AlphaInterp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AlphaInterp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AlphaInterp(nativeBuffer + arrayIndex * FRigUnit_AlphaInterp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AlphaInterp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AlphaInterp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AlphaInterp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AlphaInterp");
		}
	}

	public FRigUnit_AlphaInterp(IntPtr nativeStruct)
	{
		if (!FRigUnit_AlphaInterp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AlphaInterp");
		}
	}

	static FRigUnit_AlphaInterp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AlphaInterp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AlphaInterp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AlphaInterp");
		FRigUnit_AlphaInterp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AlphaInterp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AlphaInterp", FRigUnit_AlphaInterp_IsValid);
	}
}
