using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorSub", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorSub
{
	private static bool FRigUnit_MathVectorSub_IsValid;

	private static int FRigUnit_MathVectorSub_StructSize;

	public FRigUnit_MathVectorSub Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorSub FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorSub(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorSub value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorSub FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorSub(nativeBuffer + arrayIndex * FRigUnit_MathVectorSub_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorSub value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorSub_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSub");
		}
	}

	public FRigUnit_MathVectorSub(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorSub_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorSub");
		}
	}

	static FRigUnit_MathVectorSub()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorSub)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorSub));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorSub");
		FRigUnit_MathVectorSub_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorSub_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorSub", FRigUnit_MathVectorSub_IsValid);
	}
}
