using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairMaterialConstraints", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairMaterialConstraints
{
	private static bool FHairMaterialConstraints_IsValid;

	private static int FHairMaterialConstraints_StructSize;

	public FHairMaterialConstraints Copy()
	{
		return this;
	}

	public static FHairMaterialConstraints FromNative(IntPtr nativeBuffer)
	{
		return new FHairMaterialConstraints(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairMaterialConstraints value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairMaterialConstraints FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairMaterialConstraints(nativeBuffer + arrayIndex * FHairMaterialConstraints_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairMaterialConstraints value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairMaterialConstraints_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairMaterialConstraints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairMaterialConstraints");
		}
	}

	public FHairMaterialConstraints(IntPtr nativeStruct)
	{
		if (!FHairMaterialConstraints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairMaterialConstraints");
		}
	}

	static FHairMaterialConstraints()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairMaterialConstraints)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairMaterialConstraints));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairMaterialConstraints");
		FHairMaterialConstraints_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairMaterialConstraints_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairMaterialConstraints", FHairMaterialConstraints_IsValid);
	}
}
