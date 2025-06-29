using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathFloatTan", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathFloatTan
{
	private static bool FRigUnit_MathFloatTan_IsValid;

	private static int FRigUnit_MathFloatTan_StructSize;

	public FRigUnit_MathFloatTan Copy()
	{
		return this;
	}

	public static FRigUnit_MathFloatTan FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathFloatTan(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathFloatTan value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathFloatTan FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathFloatTan(nativeBuffer + arrayIndex * FRigUnit_MathFloatTan_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathFloatTan value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathFloatTan_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatTan_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatTan");
		}
	}

	public FRigUnit_MathFloatTan(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathFloatTan_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathFloatTan");
		}
	}

	static FRigUnit_MathFloatTan()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathFloatTan)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathFloatTan));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathFloatTan");
		FRigUnit_MathFloatTan_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathFloatTan_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathFloatTan", FRigUnit_MathFloatTan_IsValid);
	}
}
