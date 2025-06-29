using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairSolverSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairSolverSettings
{
	private static bool FHairSolverSettings_IsValid;

	private static int FHairSolverSettings_StructSize;

	public FHairSolverSettings Copy()
	{
		return this;
	}

	public static FHairSolverSettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairSolverSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairSolverSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairSolverSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairSolverSettings(nativeBuffer + arrayIndex * FHairSolverSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairSolverSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairSolverSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairSolverSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSolverSettings");
		}
	}

	public FHairSolverSettings(IntPtr nativeStruct)
	{
		if (!FHairSolverSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSolverSettings");
		}
	}

	static FHairSolverSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairSolverSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairSolverSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairSolverSettings");
		FHairSolverSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairSolverSettings_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairSolverSettings", FHairSolverSettings_IsValid);
	}
}
