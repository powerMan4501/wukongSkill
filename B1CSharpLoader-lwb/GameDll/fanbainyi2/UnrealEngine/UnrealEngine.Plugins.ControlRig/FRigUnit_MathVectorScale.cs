using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ControlRig.RigUnit_MathVectorScale", "ControlRig", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_MathVectorScale
{
	private static bool FRigUnit_MathVectorScale_IsValid;

	private static int FRigUnit_MathVectorScale_StructSize;

	public FRigUnit_MathVectorScale Copy()
	{
		return this;
	}

	public static FRigUnit_MathVectorScale FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_MathVectorScale(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_MathVectorScale value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_MathVectorScale FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_MathVectorScale(nativeBuffer + arrayIndex * FRigUnit_MathVectorScale_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_MathVectorScale value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_MathVectorScale_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorScale");
		}
	}

	public FRigUnit_MathVectorScale(IntPtr nativeStruct)
	{
		if (!FRigUnit_MathVectorScale_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ControlRig.RigUnit_MathVectorScale");
		}
	}

	static FRigUnit_MathVectorScale()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_MathVectorScale)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_MathVectorScale));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ControlRig.RigUnit_MathVectorScale");
		FRigUnit_MathVectorScale_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_MathVectorScale_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/ControlRig.RigUnit_MathVectorScale", FRigUnit_MathVectorScale_IsValid);
	}
}
