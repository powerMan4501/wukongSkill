using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairCardsGeometrySettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairCardsGeometrySettings
{
	private static bool GenerationType_IsValid;

	private static FFieldAddress GenerationType_PropertyAddress;

	private static int GenerationType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairCardsGeometrySettings:GenerationType")]
	public EHairCardsGenerationType GenerationType;

	private static bool CardsCount_IsValid;

	private static int CardsCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairCardsGeometrySettings:CardsCount")]
	public int CardsCount;

	private static bool ClusterType_IsValid;

	private static FFieldAddress ClusterType_PropertyAddress;

	private static int ClusterType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairCardsGeometrySettings:ClusterType")]
	public EHairCardsClusterType ClusterType;

	private static bool MinSegmentLength_IsValid;

	private static int MinSegmentLength_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairCardsGeometrySettings:MinSegmentLength")]
	public float MinSegmentLength;

	private static bool FHairCardsGeometrySettings_IsValid;

	private static int FHairCardsGeometrySettings_StructSize;

	public FHairCardsGeometrySettings Copy()
	{
		return this;
	}

	public static FHairCardsGeometrySettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairCardsGeometrySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairCardsGeometrySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairCardsGeometrySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairCardsGeometrySettings(nativeBuffer + arrayIndex * FHairCardsGeometrySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairCardsGeometrySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairCardsGeometrySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairCardsGeometrySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCardsGeometrySettings");
			return;
		}
		EnumMarshaler<EHairCardsGenerationType>.ToNative(IntPtr.Add(nativeStruct, GenerationType_Offset), 0, GenerationType_PropertyAddress.Address, GenerationType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CardsCount_Offset), CardsCount);
		EnumMarshaler<EHairCardsClusterType>.ToNative(IntPtr.Add(nativeStruct, ClusterType_Offset), 0, ClusterType_PropertyAddress.Address, ClusterType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinSegmentLength_Offset), MinSegmentLength);
	}

	public FHairCardsGeometrySettings(IntPtr nativeStruct)
	{
		if (!FHairCardsGeometrySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairCardsGeometrySettings");
			GenerationType = EHairCardsGenerationType.CardsCount;
			CardsCount = 0;
			ClusterType = EHairCardsClusterType.Low;
			MinSegmentLength = 0f;
		}
		else
		{
			GenerationType = EnumMarshaler<EHairCardsGenerationType>.FromNative(IntPtr.Add(nativeStruct, GenerationType_Offset), 0, GenerationType_PropertyAddress.Address);
			CardsCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CardsCount_Offset));
			ClusterType = EnumMarshaler<EHairCardsClusterType>.FromNative(IntPtr.Add(nativeStruct, ClusterType_Offset), 0, ClusterType_PropertyAddress.Address);
			MinSegmentLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinSegmentLength_Offset));
		}
	}

	static FHairCardsGeometrySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairCardsGeometrySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairCardsGeometrySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairCardsGeometrySettings");
		FHairCardsGeometrySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref GenerationType_PropertyAddress, intPtr, "GenerationType");
		GenerationType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GenerationType");
		GenerationType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GenerationType", Classes.FEnumProperty);
		CardsCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CardsCount");
		CardsCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CardsCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ClusterType_PropertyAddress, intPtr, "ClusterType");
		ClusterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ClusterType");
		ClusterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ClusterType", Classes.FEnumProperty);
		MinSegmentLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinSegmentLength");
		MinSegmentLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinSegmentLength", Classes.FFloatProperty);
		FHairCardsGeometrySettings_IsValid = intPtr != IntPtr.Zero && GenerationType_IsValid && CardsCount_IsValid && ClusterType_IsValid && MinSegmentLength_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairCardsGeometrySettings", FHairCardsGeometrySettings_IsValid);
	}
}
