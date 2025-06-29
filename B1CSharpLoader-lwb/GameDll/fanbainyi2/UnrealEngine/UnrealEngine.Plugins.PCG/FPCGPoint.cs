using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPoint", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGPoint
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/PCG.PCGPoint:Transform")]
	public FTransform Transform;

	private static bool Density_IsValid;

	private static int Density_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPoint:Density")]
	public float Density;

	private static bool BoundsMin_IsValid;

	private static int BoundsMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPoint:BoundsMin")]
	public FVector BoundsMin;

	private static bool BoundsMax_IsValid;

	private static int BoundsMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPoint:BoundsMax")]
	public FVector BoundsMax;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPoint:Color")]
	public FVector4 Color;

	private static bool Steepness_IsValid;

	private static int Steepness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPoint:Steepness")]
	public float Steepness;

	private static bool Seed_IsValid;

	private static int Seed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPoint:Seed")]
	public int Seed;

	private static bool MetadataEntry_IsValid;

	private static int MetadataEntry_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/PCG.PCGPoint:MetadataEntry")]
	public long MetadataEntry;

	private static bool FPCGPoint_IsValid;

	private static int FPCGPoint_StructSize;

	public FPCGPoint Copy()
	{
		return this;
	}

	public static FPCGPoint FromNative(IntPtr nativeBuffer)
	{
		return new FPCGPoint(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGPoint value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGPoint FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGPoint(nativeBuffer + arrayIndex * FPCGPoint_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGPoint value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGPoint_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPoint");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Transform_Offset), Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Density_Offset), Density);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, BoundsMin_Offset), BoundsMin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, BoundsMax_Offset), BoundsMax);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Steepness_Offset), Steepness);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Seed_Offset), Seed);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, MetadataEntry_Offset), MetadataEntry);
	}

	public FPCGPoint(IntPtr nativeStruct)
	{
		if (!FPCGPoint_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPoint");
			Transform = default(FTransform);
			Density = 0f;
			BoundsMin = default(FVector);
			BoundsMax = default(FVector);
			Color = default(FVector4);
			Steepness = 0f;
			Seed = 0;
			MetadataEntry = 0L;
		}
		else
		{
			Transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Transform_Offset));
			Density = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Density_Offset));
			BoundsMin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, BoundsMin_Offset));
			BoundsMax = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, BoundsMax_Offset));
			Color = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			Steepness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Steepness_Offset));
			Seed = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Seed_Offset));
			MetadataEntry = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, MetadataEntry_Offset));
		}
	}

	static FPCGPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGPoint");
		FPCGPoint_StructSize = NativeReflection.GetStructSize(intPtr);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		Density_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Density");
		Density_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Density", Classes.FFloatProperty);
		BoundsMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoundsMin");
		BoundsMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoundsMin", Classes.FStructProperty);
		BoundsMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoundsMax");
		BoundsMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoundsMax", Classes.FStructProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		Steepness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Steepness");
		Steepness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Steepness", Classes.FFloatProperty);
		Seed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Seed");
		Seed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Seed", Classes.FIntProperty);
		MetadataEntry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetadataEntry");
		MetadataEntry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetadataEntry", Classes.FInt64Property);
		FPCGPoint_IsValid = intPtr != IntPtr.Zero && Transform_IsValid && Density_IsValid && BoundsMin_IsValid && BoundsMax_IsValid && Color_IsValid && Steepness_IsValid && Seed_IsValid && MetadataEntry_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGPoint", FPCGPoint_IsValid);
	}
}
