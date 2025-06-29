using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_HighlevelBaseMutable", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_HighlevelBaseMutable
{
	private static bool FRigUnit_HighlevelBaseMutable_IsValid;

	private static int FRigUnit_HighlevelBaseMutable_StructSize;

	public FRigUnit_HighlevelBaseMutable Copy()
	{
		return this;
	}

	public static FRigUnit_HighlevelBaseMutable FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_HighlevelBaseMutable(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_HighlevelBaseMutable value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_HighlevelBaseMutable FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_HighlevelBaseMutable(nativeBuffer + arrayIndex * FRigUnit_HighlevelBaseMutable_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_HighlevelBaseMutable value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_HighlevelBaseMutable_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_HighlevelBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HighlevelBaseMutable");
		}
	}

	public FRigUnit_HighlevelBaseMutable(IntPtr nativeStruct)
	{
		if (!FRigUnit_HighlevelBaseMutable_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_HighlevelBaseMutable");
		}
	}

	static FRigUnit_HighlevelBaseMutable()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_HighlevelBaseMutable)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_HighlevelBaseMutable));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_HighlevelBaseMutable");
		FRigUnit_HighlevelBaseMutable_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_HighlevelBaseMutable_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_HighlevelBaseMutable", FRigUnit_HighlevelBaseMutable_IsValid);
	}
}
