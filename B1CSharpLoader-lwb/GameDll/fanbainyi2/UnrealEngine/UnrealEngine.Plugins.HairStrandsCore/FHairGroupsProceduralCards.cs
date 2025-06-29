using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsProceduralCards", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsProceduralCards
{
	private static bool FHairGroupsProceduralCards_IsValid;

	private static int FHairGroupsProceduralCards_StructSize;

	public FHairGroupsProceduralCards Copy()
	{
		return this;
	}

	public static FHairGroupsProceduralCards FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsProceduralCards(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsProceduralCards value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsProceduralCards FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsProceduralCards(nativeBuffer + arrayIndex * FHairGroupsProceduralCards_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsProceduralCards value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsProceduralCards_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsProceduralCards_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsProceduralCards");
		}
	}

	public FHairGroupsProceduralCards(IntPtr nativeStruct)
	{
		if (!FHairGroupsProceduralCards_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsProceduralCards");
		}
	}

	static FHairGroupsProceduralCards()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsProceduralCards)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsProceduralCards));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsProceduralCards");
		FHairGroupsProceduralCards_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsProceduralCards_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsProceduralCards", FHairGroupsProceduralCards_IsValid);
	}
}
