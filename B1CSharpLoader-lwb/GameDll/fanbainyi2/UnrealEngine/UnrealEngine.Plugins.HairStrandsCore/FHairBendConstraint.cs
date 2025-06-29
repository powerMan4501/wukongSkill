using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairBendConstraint", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairBendConstraint
{
	private static bool FHairBendConstraint_IsValid;

	private static int FHairBendConstraint_StructSize;

	public FHairBendConstraint Copy()
	{
		return this;
	}

	public static FHairBendConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FHairBendConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairBendConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairBendConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairBendConstraint(nativeBuffer + arrayIndex * FHairBendConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairBendConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairBendConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairBendConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairBendConstraint");
		}
	}

	public FHairBendConstraint(IntPtr nativeStruct)
	{
		if (!FHairBendConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairBendConstraint");
		}
	}

	static FHairBendConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairBendConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairBendConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairBendConstraint");
		FHairBendConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairBendConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairBendConstraint", FHairBendConstraint_IsValid);
	}
}
