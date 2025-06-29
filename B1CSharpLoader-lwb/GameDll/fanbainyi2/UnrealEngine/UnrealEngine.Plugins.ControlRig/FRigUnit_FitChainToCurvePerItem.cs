using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_FitChainToCurvePerItem", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FitChainToCurvePerItem
{
	private static bool FRigUnit_FitChainToCurvePerItem_IsValid;

	private static int FRigUnit_FitChainToCurvePerItem_StructSize;

	public FRigUnit_FitChainToCurvePerItem Copy()
	{
		return this;
	}

	public static FRigUnit_FitChainToCurvePerItem FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FitChainToCurvePerItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FitChainToCurvePerItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FitChainToCurvePerItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FitChainToCurvePerItem(nativeBuffer + arrayIndex * FRigUnit_FitChainToCurvePerItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FitChainToCurvePerItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FitChainToCurvePerItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToCurvePerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FitChainToCurvePerItem");
		}
	}

	public FRigUnit_FitChainToCurvePerItem(IntPtr nativeStruct)
	{
		if (!FRigUnit_FitChainToCurvePerItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_FitChainToCurvePerItem");
		}
	}

	static FRigUnit_FitChainToCurvePerItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FitChainToCurvePerItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FitChainToCurvePerItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_FitChainToCurvePerItem");
		FRigUnit_FitChainToCurvePerItem_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FitChainToCurvePerItem_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_FitChainToCurvePerItem", FRigUnit_FitChainToCurvePerItem_IsValid);
	}
}
