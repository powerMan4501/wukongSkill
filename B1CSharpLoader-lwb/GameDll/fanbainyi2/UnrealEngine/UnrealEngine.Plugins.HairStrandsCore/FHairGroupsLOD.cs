using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupsLOD", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupsLOD
{
	private static bool FHairGroupsLOD_IsValid;

	private static int FHairGroupsLOD_StructSize;

	public FHairGroupsLOD Copy()
	{
		return this;
	}

	public static FHairGroupsLOD FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupsLOD(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupsLOD value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupsLOD FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupsLOD(nativeBuffer + arrayIndex * FHairGroupsLOD_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupsLOD value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupsLOD_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupsLOD_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsLOD");
		}
	}

	public FHairGroupsLOD(IntPtr nativeStruct)
	{
		if (!FHairGroupsLOD_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupsLOD");
		}
	}

	static FHairGroupsLOD()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupsLOD)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupsLOD));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupsLOD");
		FHairGroupsLOD_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupsLOD_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupsLOD", FHairGroupsLOD_IsValid);
	}
}
