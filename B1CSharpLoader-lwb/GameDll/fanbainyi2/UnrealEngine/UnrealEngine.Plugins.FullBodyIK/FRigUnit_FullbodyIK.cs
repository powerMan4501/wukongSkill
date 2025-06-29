using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FullBodyIK;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FullBodyIK.RigUnit_FullbodyIK", "FullBodyIK", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_FullbodyIK
{
	private static bool FRigUnit_FullbodyIK_IsValid;

	private static int FRigUnit_FullbodyIK_StructSize;

	public FRigUnit_FullbodyIK Copy()
	{
		return this;
	}

	public static FRigUnit_FullbodyIK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_FullbodyIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_FullbodyIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_FullbodyIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_FullbodyIK(nativeBuffer + arrayIndex * FRigUnit_FullbodyIK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_FullbodyIK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_FullbodyIK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_FullbodyIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FullBodyIK.RigUnit_FullbodyIK");
		}
	}

	public FRigUnit_FullbodyIK(IntPtr nativeStruct)
	{
		if (!FRigUnit_FullbodyIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FullBodyIK.RigUnit_FullbodyIK");
		}
	}

	static FRigUnit_FullbodyIK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_FullbodyIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_FullbodyIK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FullBodyIK.RigUnit_FullbodyIK");
		FRigUnit_FullbodyIK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_FullbodyIK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/FullBodyIK.RigUnit_FullbodyIK", FRigUnit_FullbodyIK_IsValid);
	}
}
