using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsPhysics", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsPhysics
{
	private static bool FHairGroupsPhysics_IsValid;

	private static int FHairGroupsPhysics_StructSize;

	public FHairGroupsPhysics Copy()
	{
		return this;
	}

	public static FHairGroupsPhysics FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsPhysics(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsPhysics value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsPhysics FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsPhysics(nativeBuffer + arrayIndex * FHairGroupsPhysics_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsPhysics value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsPhysics_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsPhysics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsPhysics");
		}
	}

	public FHairGroupsPhysics(IntPtr nativeStruct)
	{
		if (!FHairGroupsPhysics_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsPhysics");
		}
	}

	static FHairGroupsPhysics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsPhysics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsPhysics));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsPhysics");
		FHairGroupsPhysics_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsPhysics_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsPhysics", FHairGroupsPhysics_IsValid);
	}
}
