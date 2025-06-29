using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsInterpolation", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsInterpolation
{
	private static bool FHairGroupsInterpolation_IsValid;

	private static int FHairGroupsInterpolation_StructSize;

	public FHairGroupsInterpolation Copy()
	{
		return this;
	}

	public static FHairGroupsInterpolation FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsInterpolation(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsInterpolation value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsInterpolation FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsInterpolation(nativeBuffer + arrayIndex * FHairGroupsInterpolation_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsInterpolation value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsInterpolation_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsInterpolation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsInterpolation");
		}
	}

	public FHairGroupsInterpolation(IntPtr nativeStruct)
	{
		if (!FHairGroupsInterpolation_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsInterpolation");
		}
	}

	static FHairGroupsInterpolation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsInterpolation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsInterpolation));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsInterpolation");
		FHairGroupsInterpolation_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsInterpolation_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsInterpolation", FHairGroupsInterpolation_IsValid);
	}
}
