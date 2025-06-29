using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairExternalForces", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairExternalForces
{
	private static bool FHairExternalForces_IsValid;

	private static int FHairExternalForces_StructSize;

	public FHairExternalForces Copy()
	{
		return this;
	}

	public static FHairExternalForces FromNative(IntPtr nativeBuffer)
	{
		return new FHairExternalForces(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairExternalForces value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairExternalForces FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairExternalForces(nativeBuffer + arrayIndex * FHairExternalForces_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairExternalForces value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairExternalForces_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairExternalForces_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairExternalForces");
		}
	}

	public FHairExternalForces(IntPtr nativeStruct)
	{
		if (!FHairExternalForces_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairExternalForces");
		}
	}

	static FHairExternalForces()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairExternalForces)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairExternalForces));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairExternalForces");
		FHairExternalForces_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairExternalForces_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairExternalForces", FHairExternalForces_IsValid);
	}
}
