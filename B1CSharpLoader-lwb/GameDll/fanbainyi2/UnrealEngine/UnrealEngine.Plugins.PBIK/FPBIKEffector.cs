using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PBIK;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PBIK.PBIKEffector", "PBIK", UnrealModuleType.EnginePlugin)]
public struct FPBIKEffector
{
	private static bool FPBIKEffector_IsValid;

	private static int FPBIKEffector_StructSize;

	public FPBIKEffector Copy()
	{
		return this;
	}

	public static FPBIKEffector FromNative(IntPtr nativeBuffer)
	{
		return new FPBIKEffector(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPBIKEffector value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPBIKEffector FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPBIKEffector(nativeBuffer + arrayIndex * FPBIKEffector_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPBIKEffector value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPBIKEffector_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPBIKEffector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PBIK.PBIKEffector");
		}
	}

	public FPBIKEffector(IntPtr nativeStruct)
	{
		if (!FPBIKEffector_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PBIK.PBIKEffector");
		}
	}

	static FPBIKEffector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPBIKEffector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPBIKEffector));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PBIK.PBIKEffector");
		FPBIKEffector_StructSize = NativeReflection.GetStructSize(intPtr);
		FPBIKEffector_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/PBIK.PBIKEffector", FPBIKEffector_IsValid);
	}
}
