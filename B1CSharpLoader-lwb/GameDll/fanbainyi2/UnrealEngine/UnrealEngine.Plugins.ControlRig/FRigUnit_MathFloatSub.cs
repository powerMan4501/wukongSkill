using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatSub", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatSub
{
	private static bool FRigUnit_MathFloatSub_IsValid;

	private static int FRigUnit_MathFloatSub_StructSize;

	public FRigUnit_MathFloatSub Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatSub FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatSub(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatSub value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatSub FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatSub(nativeBuffer + arrayIndex * FRigUnit_MathFloatSub_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatSub value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatSub_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSub");
		}
	}

	public FRigUnit_MathFloatSub(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatSub");
		}
	}

	static FRigUnit_MathFloatSub()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatSub)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatSub));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatSub");
		FRigUnit_MathFloatSub_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatSub_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatSub", FRigUnit_MathFloatSub_IsValid);
	}
}
