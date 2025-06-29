using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathColorSub", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathColorSub
{
	private static bool FRigUnit_MathColorSub_IsValid;

	private static int FRigUnit_MathColorSub_StructSize;

	public FRigUnit_MathColorSub Copy()
	{
		return this;
	}

	public static FRigUnit_MathColorSub FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathColorSub(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathColorSub value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathColorSub FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathColorSub(nativeBuffer + arrayIndex * FRigUnit_MathColorSub_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathColorSub value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathColorSub_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorSub");
		}
	}

	public FRigUnit_MathColorSub(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathColorSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathColorSub");
		}
	}

	static FRigUnit_MathColorSub()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathColorSub)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathColorSub));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathColorSub");
		FRigUnit_MathColorSub_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathColorSub_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathColorSub", FRigUnit_MathColorSub_IsValid);
	}
}
