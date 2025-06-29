using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGroupInfoWithVisibility", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGroupInfoWithVisibility
{
	private static bool FHairGroupInfoWithVisibility_IsValid;

	private static int FHairGroupInfoWithVisibility_StructSize;

	public FHairGroupInfoWithVisibility Copy()
	{
		return this;
	}

	public static FHairGroupInfoWithVisibility FromNative(IntPtr nativeBuffer)
	{
		return new FHairGroupInfoWithVisibility(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGroupInfoWithVisibility value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGroupInfoWithVisibility FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGroupInfoWithVisibility(nativeBuffer + arrayIndex * FHairGroupInfoWithVisibility_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGroupInfoWithVisibility value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGroupInfoWithVisibility_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGroupInfoWithVisibility_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupInfoWithVisibility");
		}
	}

	public FHairGroupInfoWithVisibility(IntPtr nativeStruct)
	{
		if (!FHairGroupInfoWithVisibility_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGroupInfoWithVisibility");
		}
	}

	static FHairGroupInfoWithVisibility()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGroupInfoWithVisibility)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGroupInfoWithVisibility));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGroupInfoWithVisibility");
		FHairGroupInfoWithVisibility_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairGroupInfoWithVisibility_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGroupInfoWithVisibility", FHairGroupInfoWithVisibility_IsValid);
	}
}
