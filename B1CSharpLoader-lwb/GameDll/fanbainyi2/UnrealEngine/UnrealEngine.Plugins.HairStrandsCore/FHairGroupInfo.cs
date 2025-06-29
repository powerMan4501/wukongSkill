using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupInfo", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupInfo
{
	private static bool FHairGroupInfo_IsValid;

	private static int FHairGroupInfo_StructSize;

	public FHairGroupInfo Copy()
	{
		return this;
	}

	public static FHairGroupInfo FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupInfo(nativeBuffer + arrayIndex * FHairGroupInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupInfo");
		}
	}

	public FHairGroupInfo(IntPtr nativeStruct)
	{
		if (!FHairGroupInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupInfo");
		}
	}

	static FHairGroupInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupInfo");
		FHairGroupInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupInfo_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupInfo", FHairGroupInfo_IsValid);
	}
}
