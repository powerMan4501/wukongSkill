using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsMeshesSourceDescription", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsMeshesSourceDescription
{
	private static bool FHairGroupsMeshesSourceDescription_IsValid;

	private static int FHairGroupsMeshesSourceDescription_StructSize;

	public FHairGroupsMeshesSourceDescription Copy()
	{
		return this;
	}

	public static FHairGroupsMeshesSourceDescription FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsMeshesSourceDescription(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsMeshesSourceDescription value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsMeshesSourceDescription FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsMeshesSourceDescription(nativeBuffer + arrayIndex * FHairGroupsMeshesSourceDescription_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsMeshesSourceDescription value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsMeshesSourceDescription_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsMeshesSourceDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsMeshesSourceDescription");
		}
	}

	public FHairGroupsMeshesSourceDescription(IntPtr nativeStruct)
	{
		if (!FHairGroupsMeshesSourceDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsMeshesSourceDescription");
		}
	}

	static FHairGroupsMeshesSourceDescription()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsMeshesSourceDescription)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsMeshesSourceDescription));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsMeshesSourceDescription");
		FHairGroupsMeshesSourceDescription_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsMeshesSourceDescription_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsMeshesSourceDescription", FHairGroupsMeshesSourceDescription_IsValid);
	}
}
