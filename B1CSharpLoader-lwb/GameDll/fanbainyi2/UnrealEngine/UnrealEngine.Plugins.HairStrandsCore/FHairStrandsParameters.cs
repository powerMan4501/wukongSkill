using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairStrandsParameters", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairStrandsParameters
{
	private static bool FHairStrandsParameters_IsValid;

	private static int FHairStrandsParameters_StructSize;

	public FHairStrandsParameters Copy()
	{
		return this;
	}

	public static FHairStrandsParameters FromNative(IntPtr nativeBuffer)
	{
		return new FHairStrandsParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairStrandsParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairStrandsParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairStrandsParameters(nativeBuffer + arrayIndex * FHairStrandsParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairStrandsParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairStrandsParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairStrandsParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairStrandsParameters");
		}
	}

	public FHairStrandsParameters(IntPtr nativeStruct)
	{
		if (!FHairStrandsParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairStrandsParameters");
		}
	}

	static FHairStrandsParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairStrandsParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairStrandsParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairStrandsParameters");
		FHairStrandsParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairStrandsParameters_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairStrandsParameters", FHairStrandsParameters_IsValid);
	}
}
