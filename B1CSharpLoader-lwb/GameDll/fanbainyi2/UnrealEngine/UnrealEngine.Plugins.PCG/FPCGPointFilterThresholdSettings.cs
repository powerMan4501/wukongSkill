using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPointFilterThresholdSettings", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGPointFilterThresholdSettings
{
	private static bool Inclusive_IsValid;

	private static FFieldAddress Inclusive_PropertyAddress;

	private static int Inclusive_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterThresholdSettings:bInclusive")]
	public bool Inclusive;

	private static bool UseConstantThreshold_IsValid;

	private static FFieldAddress UseConstantThreshold_PropertyAddress;

	private static int UseConstantThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterThresholdSettings:bUseConstantThreshold")]
	public bool UseConstantThreshold;

	private static bool ThresholdAttribute_IsValid;

	private static int ThresholdAttribute_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterThresholdSettings:ThresholdAttribute")]
	public FPCGAttributePropertyInputSelector ThresholdAttribute;

	private static bool UseSpatialQuery_IsValid;

	private static FFieldAddress UseSpatialQuery_PropertyAddress;

	private static int UseSpatialQuery_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterThresholdSettings:bUseSpatialQuery")]
	public bool UseSpatialQuery;

	private static bool AttributeTypes_IsValid;

	private static int AttributeTypes_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterThresholdSettings:AttributeTypes")]
	public FPCGMetadataTypesConstantStruct AttributeTypes;

	private static bool FPCGPointFilterThresholdSettings_IsValid;

	private static int FPCGPointFilterThresholdSettings_StructSize;

	public FPCGPointFilterThresholdSettings Copy()
	{
		return this;
	}

	public static FPCGPointFilterThresholdSettings FromNative(IntPtr nativeBuffer)
	{
		return new FPCGPointFilterThresholdSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGPointFilterThresholdSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGPointFilterThresholdSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGPointFilterThresholdSettings(nativeBuffer + arrayIndex * FPCGPointFilterThresholdSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGPointFilterThresholdSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGPointFilterThresholdSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGPointFilterThresholdSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPointFilterThresholdSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Inclusive_Offset), 0, Inclusive_PropertyAddress.Address, Inclusive);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseConstantThreshold_Offset), 0, UseConstantThreshold_PropertyAddress.Address, UseConstantThreshold);
		FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(nativeStruct, ThresholdAttribute_Offset), ThresholdAttribute);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseSpatialQuery_Offset), 0, UseSpatialQuery_PropertyAddress.Address, UseSpatialQuery);
		FPCGMetadataTypesConstantStruct.ToNative(IntPtr.Add(nativeStruct, AttributeTypes_Offset), AttributeTypes);
	}

	public FPCGPointFilterThresholdSettings(IntPtr nativeStruct)
	{
		if (!FPCGPointFilterThresholdSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGPointFilterThresholdSettings");
			Inclusive = false;
			UseConstantThreshold = false;
			ThresholdAttribute = default(FPCGAttributePropertyInputSelector);
			UseSpatialQuery = false;
			AttributeTypes = default(FPCGMetadataTypesConstantStruct);
		}
		else
		{
			Inclusive = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Inclusive_Offset), 0, Inclusive_PropertyAddress.Address);
			UseConstantThreshold = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseConstantThreshold_Offset), 0, UseConstantThreshold_PropertyAddress.Address);
			ThresholdAttribute = FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(nativeStruct, ThresholdAttribute_Offset));
			UseSpatialQuery = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseSpatialQuery_Offset), 0, UseSpatialQuery_PropertyAddress.Address);
			AttributeTypes = FPCGMetadataTypesConstantStruct.FromNative(IntPtr.Add(nativeStruct, AttributeTypes_Offset));
		}
	}

	static FPCGPointFilterThresholdSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGPointFilterThresholdSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGPointFilterThresholdSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGPointFilterThresholdSettings");
		FPCGPointFilterThresholdSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Inclusive_PropertyAddress, intPtr, "bInclusive");
		Inclusive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInclusive");
		Inclusive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInclusive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseConstantThreshold_PropertyAddress, intPtr, "bUseConstantThreshold");
		UseConstantThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseConstantThreshold");
		UseConstantThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseConstantThreshold", Classes.FBoolProperty);
		ThresholdAttribute_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThresholdAttribute");
		ThresholdAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThresholdAttribute", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSpatialQuery_PropertyAddress, intPtr, "bUseSpatialQuery");
		UseSpatialQuery_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseSpatialQuery");
		UseSpatialQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseSpatialQuery", Classes.FBoolProperty);
		AttributeTypes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttributeTypes");
		AttributeTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttributeTypes", Classes.FStructProperty);
		FPCGPointFilterThresholdSettings_IsValid = intPtr != IntPtr.Zero && Inclusive_IsValid && UseConstantThreshold_IsValid && ThresholdAttribute_IsValid && UseSpatialQuery_IsValid && AttributeTypes_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGPointFilterThresholdSettings", FPCGPointFilterThresholdSettings_IsValid);
	}
}
