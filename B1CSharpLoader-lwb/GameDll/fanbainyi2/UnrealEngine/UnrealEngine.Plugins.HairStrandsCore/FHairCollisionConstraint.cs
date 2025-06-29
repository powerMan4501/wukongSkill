using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairCollisionConstraint", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairCollisionConstraint
{
	private static bool FHairCollisionConstraint_IsValid;

	private static int FHairCollisionConstraint_StructSize;

	public FHairCollisionConstraint Copy()
	{
		return this;
	}

	public static FHairCollisionConstraint FromNative(IntPtr nativeBuffer)
	{
		return new FHairCollisionConstraint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairCollisionConstraint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairCollisionConstraint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairCollisionConstraint(nativeBuffer + arrayIndex * FHairCollisionConstraint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairCollisionConstraint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairCollisionConstraint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairCollisionConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCollisionConstraint");
		}
	}

	public FHairCollisionConstraint(IntPtr nativeStruct)
	{
		if (!FHairCollisionConstraint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCollisionConstraint");
		}
	}

	static FHairCollisionConstraint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairCollisionConstraint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairCollisionConstraint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairCollisionConstraint");
		FHairCollisionConstraint_StructSize = NativeReflection.GetStructSize(intPtr);
		FHairCollisionConstraint_IsValid = intPtr != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairCollisionConstraint", FHairCollisionConstraint_IsValid);
	}
}
