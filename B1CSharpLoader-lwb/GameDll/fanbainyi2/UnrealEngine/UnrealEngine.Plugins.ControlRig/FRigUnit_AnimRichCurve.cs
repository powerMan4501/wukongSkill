using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AnimRichCurve", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AnimRichCurve
{
	private static bool FRigUnit_AnimRichCurve_IsValid;

	private static int FRigUnit_AnimRichCurve_StructSize;

	public FRigUnit_AnimRichCurve Copy()
	{
		return this;
	}

	public static FRigUnit_AnimRichCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AnimRichCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AnimRichCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AnimRichCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AnimRichCurve(nativeBuffer + arrayIndex * FRigUnit_AnimRichCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AnimRichCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AnimRichCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimRichCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimRichCurve");
		}
	}

	public FRigUnit_AnimRichCurve(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimRichCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimRichCurve");
		}
	}

	static FRigUnit_AnimRichCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AnimRichCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AnimRichCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AnimRichCurve");
		FRigUnit_AnimRichCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AnimRichCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AnimRichCurve", FRigUnit_AnimRichCurve_IsValid);
	}
}
