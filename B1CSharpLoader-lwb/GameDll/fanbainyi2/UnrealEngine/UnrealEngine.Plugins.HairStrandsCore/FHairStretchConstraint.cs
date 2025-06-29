using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairStretchConstraint", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairStretchConstraint
{
	private static bool FHairStretchConstraint_IsValid;

	private static int FHairStretchConstraint_StructSize;

	public FHairStretchConstraint Copy()
	{
		return this;
	}

	public static FHairStretchConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FHairStretchConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairStretchConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairStretchConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairStretchConstraint(nativeBuffer + arrayIndex * FHairStretchConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairStretchConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairStretchConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairStretchConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairStretchConstraint");
		}
	}

	public FHairStretchConstraint(IntPtr nativeStruct)
	{
		if (!FHairStretchConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairStretchConstraint");
		}
	}

	static FHairStretchConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairStretchConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairStretchConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairStretchConstraint");
		FHairStretchConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairStretchConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairStretchConstraint", FHairStretchConstraint_IsValid);
	}
}
