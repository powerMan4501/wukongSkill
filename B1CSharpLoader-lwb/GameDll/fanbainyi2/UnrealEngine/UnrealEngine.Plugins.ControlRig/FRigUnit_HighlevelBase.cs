using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HighlevelBase", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HighlevelBase
{
	private static bool FRigUnit_HighlevelBase_IsValid;

	private static int FRigUnit_HighlevelBase_StructSize;

	public FRigUnit_HighlevelBase Copy()
	{
		return this;
	}

	public static FRigUnit_HighlevelBase FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HighlevelBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HighlevelBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HighlevelBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HighlevelBase(nativeBuffer + arrayIndex * FRigUnit_HighlevelBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HighlevelBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HighlevelBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HighlevelBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HighlevelBase");
		}
	}

	public FRigUnit_HighlevelBase(IntPtr nativeStruct)
	{
		if (!FRigUnit_HighlevelBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HighlevelBase");
		}
	}

	static FRigUnit_HighlevelBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HighlevelBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HighlevelBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HighlevelBase");
		FRigUnit_HighlevelBase_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HighlevelBase_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HighlevelBase", FRigUnit_HighlevelBase_IsValid);
	}
}
