using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorSelectBool", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorSelectBool
{
	private static bool FRigUnit_MathVectorSelectBool_IsValid;

	private static int FRigUnit_MathVectorSelectBool_StructSize;

	public FRigUnit_MathVectorSelectBool Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorSelectBool FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorSelectBool(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorSelectBool value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorSelectBool FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorSelectBool(nativeBuffer + arrayIndex * FRigUnit_MathVectorSelectBool_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorSelectBool value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorSelectBool_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSelectBool");
		}
	}

	public FRigUnit_MathVectorSelectBool(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSelectBool_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSelectBool");
		}
	}

	static FRigUnit_MathVectorSelectBool()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorSelectBool)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorSelectBool));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorSelectBool");
		FRigUnit_MathVectorSelectBool_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorSelectBool_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorSelectBool", FRigUnit_MathVectorSelectBool_IsValid);
	}
}
