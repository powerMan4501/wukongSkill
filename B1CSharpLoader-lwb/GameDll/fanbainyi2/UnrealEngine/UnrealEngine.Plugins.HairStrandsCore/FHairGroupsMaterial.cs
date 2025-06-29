using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsMaterial", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsMaterial
{
	private static bool FHairGroupsMaterial_IsValid;

	private static int FHairGroupsMaterial_StructSize;

	public FHairGroupsMaterial Copy()
	{
		return this;
	}

	public static FHairGroupsMaterial FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsMaterial(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsMaterial value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsMaterial FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsMaterial(nativeBuffer + arrayIndex * FHairGroupsMaterial_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsMaterial value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsMaterial_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsMaterial_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsMaterial");
		}
	}

	public FHairGroupsMaterial(IntPtr nativeStruct)
	{
		if (!FHairGroupsMaterial_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsMaterial");
		}
	}

	static FHairGroupsMaterial()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsMaterial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsMaterial));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsMaterial");
		FHairGroupsMaterial_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsMaterial_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsMaterial", FHairGroupsMaterial_IsValid);
	}
}
