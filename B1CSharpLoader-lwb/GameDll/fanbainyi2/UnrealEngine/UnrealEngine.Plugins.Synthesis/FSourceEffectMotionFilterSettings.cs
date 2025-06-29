using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectMotionFilterSettings
{
	private static bool MotionFilterTopology_IsValid;

	private static FFieldAddress MotionFilterTopology_PropertyAddress;

	private static int MotionFilterTopology_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterSettings:MotionFilterTopology")]
	public ESourceEffectMotionFilterTopology MotionFilterTopology;

	private static bool MotionFilterMix_IsValid;

	private static int MotionFilterMix_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterSettings:MotionFilterMix")]
	public float MotionFilterMix;

	private static bool FilterASettings_IsValid;

	private static int FilterASettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterSettings:FilterASettings")]
	public FSourceEffectIndividualFilterSettings FilterASettings;

	private static bool FilterBSettings_IsValid;

	private static int FilterBSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterSettings:FilterBSettings")]
	public FSourceEffectIndividualFilterSettings FilterBSettings;

	private static bool ModulationMappings_IsValid;

	private static FFieldAddress ModulationMappings_PropertyAddress;

	private static int ModulationMappings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterSettings:ModulationMappings")]
	public Dictionary<ESourceEffectMotionFilterModDestination, FSourceEffectMotionFilterModulationSettings> ModulationMappings;

	private static bool DryVolumeDb_IsValid;

	private static int DryVolumeDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectMotionFilterSettings:DryVolumeDb")]
	public float DryVolumeDb;

	private static bool FSourceEffectMotionFilterSettings_IsValid;

	private static int FSourceEffectMotionFilterSettings_StructSize;

	public FSourceEffectMotionFilterSettings Copy()
	{
		FSourceEffectMotionFilterSettings result = this;
		if (ModulationMappings != null)
		{
			result.ModulationMappings = new Dictionary<ESourceEffectMotionFilterModDestination, FSourceEffectMotionFilterModulationSettings>(ModulationMappings);
		}
		return result;
	}

	public static FSourceEffectMotionFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectMotionFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectMotionFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectMotionFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectMotionFilterSettings(nativeBuffer + arrayIndex * FSourceEffectMotionFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectMotionFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectMotionFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectMotionFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectMotionFilterSettings");
			return;
		}
		EnumMarshaler<ESourceEffectMotionFilterTopology>.ToNative(IntPtr.Add(nativeStruct, MotionFilterTopology_Offset), 0, MotionFilterTopology_PropertyAddress.Address, MotionFilterTopology);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MotionFilterMix_Offset), MotionFilterMix);
		FSourceEffectIndividualFilterSettings.ToNative(IntPtr.Add(nativeStruct, FilterASettings_Offset), FilterASettings);
		FSourceEffectIndividualFilterSettings.ToNative(IntPtr.Add(nativeStruct, FilterBSettings_Offset), FilterBSettings);
		new TMapCopyMarshaler<ESourceEffectMotionFilterModDestination, FSourceEffectMotionFilterModulationSettings>(1, ModulationMappings_PropertyAddress, CachedMarshalingDelegates<ESourceEffectMotionFilterModDestination, EnumMarshaler<ESourceEffectMotionFilterModDestination>>.FromNative, CachedMarshalingDelegates<ESourceEffectMotionFilterModDestination, EnumMarshaler<ESourceEffectMotionFilterModDestination>>.ToNative, CachedMarshalingDelegates<FSourceEffectMotionFilterModulationSettings, FSourceEffectMotionFilterModulationSettings>.FromNative, CachedMarshalingDelegates<FSourceEffectMotionFilterModulationSettings, FSourceEffectMotionFilterModulationSettings>.ToNative).ToNative(IntPtr.Add(nativeStruct, ModulationMappings_Offset), ModulationMappings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DryVolumeDb_Offset), DryVolumeDb);
	}

	public FSourceEffectMotionFilterSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectMotionFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectMotionFilterSettings");
			MotionFilterTopology = ESourceEffectMotionFilterTopology.SerialMode;
			MotionFilterMix = 0f;
			FilterASettings = default(FSourceEffectIndividualFilterSettings);
			FilterBSettings = default(FSourceEffectIndividualFilterSettings);
			ModulationMappings = null;
			DryVolumeDb = 0f;
		}
		else
		{
			MotionFilterTopology = EnumMarshaler<ESourceEffectMotionFilterTopology>.FromNative(IntPtr.Add(nativeStruct, MotionFilterTopology_Offset), 0, MotionFilterTopology_PropertyAddress.Address);
			MotionFilterMix = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MotionFilterMix_Offset));
			FilterASettings = FSourceEffectIndividualFilterSettings.FromNative(IntPtr.Add(nativeStruct, FilterASettings_Offset));
			FilterBSettings = FSourceEffectIndividualFilterSettings.FromNative(IntPtr.Add(nativeStruct, FilterBSettings_Offset));
			ModulationMappings = new TMapCopyMarshaler<ESourceEffectMotionFilterModDestination, FSourceEffectMotionFilterModulationSettings>(1, ModulationMappings_PropertyAddress, CachedMarshalingDelegates<ESourceEffectMotionFilterModDestination, EnumMarshaler<ESourceEffectMotionFilterModDestination>>.FromNative, CachedMarshalingDelegates<ESourceEffectMotionFilterModDestination, EnumMarshaler<ESourceEffectMotionFilterModDestination>>.ToNative, CachedMarshalingDelegates<FSourceEffectMotionFilterModulationSettings, FSourceEffectMotionFilterModulationSettings>.FromNative, CachedMarshalingDelegates<FSourceEffectMotionFilterModulationSettings, FSourceEffectMotionFilterModulationSettings>.ToNative).FromNative(IntPtr.Add(nativeStruct, ModulationMappings_Offset));
			DryVolumeDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DryVolumeDb_Offset));
		}
	}

	static FSourceEffectMotionFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectMotionFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectMotionFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectMotionFilterSettings");
		FSourceEffectMotionFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MotionFilterTopology_PropertyAddress, intPtr, "MotionFilterTopology");
		MotionFilterTopology_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MotionFilterTopology");
		MotionFilterTopology_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MotionFilterTopology", Classes.FEnumProperty);
		MotionFilterMix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MotionFilterMix");
		MotionFilterMix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MotionFilterMix", Classes.FFloatProperty);
		FilterASettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterASettings");
		FilterASettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterASettings", Classes.FStructProperty);
		FilterBSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterBSettings");
		FilterBSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterBSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ModulationMappings_PropertyAddress, intPtr, "ModulationMappings");
		ModulationMappings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationMappings");
		ModulationMappings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationMappings", Classes.FMapProperty);
		DryVolumeDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryVolumeDb");
		DryVolumeDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryVolumeDb", Classes.FFloatProperty);
		FSourceEffectMotionFilterSettings_IsValid = intPtr != IntPtr.Zero && MotionFilterTopology_IsValid && MotionFilterMix_IsValid && FilterASettings_IsValid && FilterBSettings_IsValid && ModulationMappings_IsValid && DryVolumeDb_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectMotionFilterSettings", FSourceEffectMotionFilterSettings_IsValid);
	}
}
