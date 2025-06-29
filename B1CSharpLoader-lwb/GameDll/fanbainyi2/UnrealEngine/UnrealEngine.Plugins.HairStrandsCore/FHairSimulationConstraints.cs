using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairSimulationConstraints
{
	private static bool BendDamping_IsValid;

	private static int BendDamping_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:BendDamping")]
	public float BendDamping;

	private static bool BendStiffness_IsValid;

	private static int BendStiffness_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:BendStiffness")]
	public float BendStiffness;

	private static bool StretchDamping_IsValid;

	private static int StretchDamping_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:StretchDamping")]
	public float StretchDamping;

	private static bool StretchStiffness_IsValid;

	private static int StretchStiffness_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:StretchStiffness")]
	public float StretchStiffness;

	private static bool StaticFriction_IsValid;

	private static int StaticFriction_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:StaticFriction")]
	public float StaticFriction;

	private static bool KineticFriction_IsValid;

	private static int KineticFriction_Offset;

	[UProperty(Flags = (PropFlags)6759875870720517uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:KineticFriction")]
	public float KineticFriction;

	private static bool StrandsViscosity_IsValid;

	private static int StrandsViscosity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:StrandsViscosity")]
	public float StrandsViscosity;

	private static bool CollisionRadius_IsValid;

	private static int CollisionRadius_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/HairStrandsCore.HairSimulationConstraints:CollisionRadius")]
	public float CollisionRadius;

	private static bool FHairSimulationConstraints_IsValid;

	private static int FHairSimulationConstraints_StructSize;

	public FHairSimulationConstraints Copy()
	{
		return this;
	}

	public static FHairSimulationConstraints FromNative(IntPtr nativeBuffer)
	{
		return new FHairSimulationConstraints(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairSimulationConstraints value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairSimulationConstraints FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairSimulationConstraints(nativeBuffer + arrayIndex * FHairSimulationConstraints_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairSimulationConstraints value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairSimulationConstraints_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairSimulationConstraints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationConstraints");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BendDamping_Offset), BendDamping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BendStiffness_Offset), BendStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StretchDamping_Offset), StretchDamping);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StretchStiffness_Offset), StretchStiffness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StaticFriction_Offset), StaticFriction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, KineticFriction_Offset), KineticFriction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StrandsViscosity_Offset), StrandsViscosity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CollisionRadius_Offset), CollisionRadius);
	}

	public FHairSimulationConstraints(IntPtr nativeStruct)
	{
		if (!FHairSimulationConstraints_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairSimulationConstraints");
			BendDamping = 0f;
			BendStiffness = 0f;
			StretchDamping = 0f;
			StretchStiffness = 0f;
			StaticFriction = 0f;
			KineticFriction = 0f;
			StrandsViscosity = 0f;
			CollisionRadius = 0f;
		}
		else
		{
			BendDamping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BendDamping_Offset));
			BendStiffness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BendStiffness_Offset));
			StretchDamping = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StretchDamping_Offset));
			StretchStiffness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StretchStiffness_Offset));
			StaticFriction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StaticFriction_Offset));
			KineticFriction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, KineticFriction_Offset));
			StrandsViscosity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StrandsViscosity_Offset));
			CollisionRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CollisionRadius_Offset));
		}
	}

	static FHairSimulationConstraints()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairSimulationConstraints)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairSimulationConstraints));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairSimulationConstraints");
		FHairSimulationConstraints_StructSize = NativeReflection.GetStructSize(intPtr);
		BendDamping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BendDamping");
		BendDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BendDamping", Classes.FFloatProperty);
		BendStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BendStiffness");
		BendStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BendStiffness", Classes.FFloatProperty);
		StretchDamping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StretchDamping");
		StretchDamping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StretchDamping", Classes.FFloatProperty);
		StretchStiffness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StretchStiffness");
		StretchStiffness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StretchStiffness", Classes.FFloatProperty);
		StaticFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticFriction");
		StaticFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticFriction", Classes.FFloatProperty);
		KineticFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KineticFriction");
		KineticFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KineticFriction", Classes.FFloatProperty);
		StrandsViscosity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StrandsViscosity");
		StrandsViscosity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StrandsViscosity", Classes.FFloatProperty);
		CollisionRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionRadius");
		CollisionRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionRadius", Classes.FFloatProperty);
		FHairSimulationConstraints_IsValid = intPtr != IntPtr.Zero && BendDamping_IsValid && BendStiffness_IsValid && StretchDamping_IsValid && StretchStiffness_IsValid && StaticFriction_IsValid && KineticFriction_IsValid && StrandsViscosity_IsValid && CollisionRadius_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairSimulationConstraints", FHairSimulationConstraints_IsValid);
	}
}
