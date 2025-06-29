using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsCardsSourceDescription", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsCardsSourceDescription
{
	private static bool FHairGroupsCardsSourceDescription_IsValid;

	private static int FHairGroupsCardsSourceDescription_StructSize;

	public FHairGroupsCardsSourceDescription Copy()
	{
		return this;
	}

	public static FHairGroupsCardsSourceDescription FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsCardsSourceDescription(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsCardsSourceDescription value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsCardsSourceDescription FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsCardsSourceDescription(nativeBuffer + arrayIndex * FHairGroupsCardsSourceDescription_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsCardsSourceDescription value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsCardsSourceDescription_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsCardsSourceDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsCardsSourceDescription");
		}
	}

	public FHairGroupsCardsSourceDescription(IntPtr nativeStruct)
	{
		if (!FHairGroupsCardsSourceDescription_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsCardsSourceDescription");
		}
	}

	static FHairGroupsCardsSourceDescription()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsCardsSourceDescription)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsCardsSourceDescription));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsCardsSourceDescription");
		FHairGroupsCardsSourceDescription_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsCardsSourceDescription_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsCardsSourceDescription", FHairGroupsCardsSourceDescription_IsValid);
	}
}
