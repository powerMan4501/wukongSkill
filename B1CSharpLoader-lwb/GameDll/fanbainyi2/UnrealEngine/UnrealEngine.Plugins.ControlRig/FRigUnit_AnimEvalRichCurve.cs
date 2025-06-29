using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_AnimEvalRichCurve", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_AnimEvalRichCurve
{
	private static bool FRigUnit_AnimEvalRichCurve_IsValid;

	private static int FRigUnit_AnimEvalRichCurve_StructSize;

	public FRigUnit_AnimEvalRichCurve Copy()
	{
		return this;
	}

	public static FRigUnit_AnimEvalRichCurve FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_AnimEvalRichCurve(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_AnimEvalRichCurve value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_AnimEvalRichCurve FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_AnimEvalRichCurve(nativeBuffer + arrayIndex * FRigUnit_AnimEvalRichCurve_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_AnimEvalRichCurve value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_AnimEvalRichCurve_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimEvalRichCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimEvalRichCurve");
		}
	}

	public FRigUnit_AnimEvalRichCurve(IntPtr nativeStruct)
	{
		if (!FRigUnit_AnimEvalRichCurve_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_AnimEvalRichCurve");
		}
	}

	static FRigUnit_AnimEvalRichCurve()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_AnimEvalRichCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_AnimEvalRichCurve));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_AnimEvalRichCurve");
		FRigUnit_AnimEvalRichCurve_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_AnimEvalRichCurve_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_AnimEvalRichCurve", FRigUnit_AnimEvalRichCurve_IsValid);
	}
}
