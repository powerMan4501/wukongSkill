using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PBIK;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PBIK.RigUnit_PBIK", "PBIK", UnrealModuleType.EnginePlugin)]
public struct FRigUnit_PBIK
{
	private static bool FRigUnit_PBIK_IsValid;

	private static int FRigUnit_PBIK_StructSize;

	public FRigUnit_PBIK Copy()
	{
		return this;
	}

	public static FRigUnit_PBIK FromNative(IntPtr nativeBuffer)
	{
		return new FRigUnit_PBIK(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRigUnit_PBIK value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRigUnit_PBIK FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRigUnit_PBIK(nativeBuffer + arrayIndex * FRigUnit_PBIK_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRigUnit_PBIK value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRigUnit_PBIK_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRigUnit_PBIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PBIK.RigUnit_PBIK");
		}
	}

	public FRigUnit_PBIK(IntPtr nativeStruct)
	{
		if (!FRigUnit_PBIK_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PBIK.RigUnit_PBIK");
		}
	}

	static FRigUnit_PBIK()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRigUnit_PBIK)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRigUnit_PBIK));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PBIK.RigUnit_PBIK");
		FRigUnit_PBIK_StructSize = NativeReflection.GetStructSize(intPtr);
		FRigUnit_PBIK_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PBIK.RigUnit_PBIK", FRigUnit_PBIK_IsValid);
	}
}
