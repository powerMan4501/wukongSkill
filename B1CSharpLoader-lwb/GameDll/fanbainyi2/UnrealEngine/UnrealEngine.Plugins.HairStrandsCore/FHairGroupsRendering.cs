using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsRendering", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsRendering
{
	private static bool FHairGroupsRendering_IsValid;

	private static int FHairGroupsRendering_StructSize;

	public FHairGroupsRendering Copy()
	{
		return this;
	}

	public static FHairGroupsRendering FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsRendering(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsRendering value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsRendering FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsRendering(nativeBuffer + arrayIndex * FHairGroupsRendering_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsRendering value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsRendering_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsRendering_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsRendering");
		}
	}

	public FHairGroupsRendering(IntPtr nativeStruct)
	{
		if (!FHairGroupsRendering_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsRendering");
		}
	}

	static FHairGroupsRendering()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsRendering)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsRendering));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsRendering");
		FHairGroupsRendering_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsRendering_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsRendering", FHairGroupsRendering_IsValid);
	}
}
