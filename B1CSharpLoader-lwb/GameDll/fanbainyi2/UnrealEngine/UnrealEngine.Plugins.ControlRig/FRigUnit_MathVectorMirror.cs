using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorMirror", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorMirror
{
	private static bool FRigUnit_MathVectorMirror_IsValid;

	private static int FRigUnit_MathVectorMirror_StructSize;

	public FRigUnit_MathVectorMirror Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorMirror FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorMirror(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorMirror value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorMirror FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorMirror(nativeBuffer + arrayIndex * FRigUnit_MathVectorMirror_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorMirror value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorMirror_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMirror_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMirror");
		}
	}

	public FRigUnit_MathVectorMirror(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorMirror_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorMirror");
		}
	}

	static FRigUnit_MathVectorMirror()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorMirror)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorMirror));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorMirror");
		FRigUnit_MathVectorMirror_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorMirror_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorMirror", FRigUnit_MathVectorMirror_IsValid);
	}
}
