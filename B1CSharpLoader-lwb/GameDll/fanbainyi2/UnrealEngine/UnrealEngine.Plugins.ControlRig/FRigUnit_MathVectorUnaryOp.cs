using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorUnaryOp", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorUnaryOp
{
	private static bool FRigUnit_MathVectorUnaryOp_IsValid;

	private static int FRigUnit_MathVectorUnaryOp_StructSize;

	public FRigUnit_MathVectorUnaryOp Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorUnaryOp FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorUnaryOp(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorUnaryOp value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorUnaryOp FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorUnaryOp(nativeBuffer + arrayIndex * FRigUnit_MathVectorUnaryOp_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorUnaryOp value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorUnaryOp_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorUnaryOp");
		}
	}

	public FRigUnit_MathVectorUnaryOp(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorUnaryOp_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorUnaryOp");
		}
	}

	static FRigUnit_MathVectorUnaryOp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorUnaryOp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorUnaryOp));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorUnaryOp");
		FRigUnit_MathVectorUnaryOp_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorUnaryOp_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorUnaryOp", FRigUnit_MathVectorUnaryOp_IsValid);
	}
}
