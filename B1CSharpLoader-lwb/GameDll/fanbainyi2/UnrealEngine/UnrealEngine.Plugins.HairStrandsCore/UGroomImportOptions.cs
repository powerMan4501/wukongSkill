using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)810549412uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomImportOptions", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomImportOptions : UObject
{
	private static bool ConversionSettings_IsValid;

	private static int ConversionSettings_Offset;

	private static bool InterpolationSettings_IsValid;

	private static FFieldAddress InterpolationSettings_PropertyAddress;

	private static int InterpolationSettings_Offset;

	private TArrayReadWriteMarshaler<FHairGroupsInterpolation> InterpolationSettings_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503668346863621uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomImportOptions:ConversionSettings")]
	public FGroomConversionSettings ConversionSettings
	{
		get
		{
			CheckDestroyed();
			if (!ConversionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomImportOptions:ConversionSettings");
				return default(FGroomConversionSettings);
			}
			return FGroomConversionSettings.FromNative(IntPtr.Add(base.Address, ConversionSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConversionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomImportOptions:ConversionSettings");
			}
			else
			{
				FGroomConversionSettings.ToNative(IntPtr.Add(base.Address, ConversionSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627502085uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomImportOptions:InterpolationSettings")]
	public TArrayReadWrite<FHairGroupsInterpolation> InterpolationSettings
	{
		get
		{
			CheckDestroyed();
			if (!InterpolationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomImportOptions:InterpolationSettings");
				return null;
			}
			if (InterpolationSettings_MarshalerCached == null)
			{
				InterpolationSettings_MarshalerCached = new TArrayReadWriteMarshaler<FHairGroupsInterpolation>(1, InterpolationSettings_PropertyAddress, CachedMarshalingDelegates<FHairGroupsInterpolation, FHairGroupsInterpolation>.FromNative, CachedMarshalingDelegates<FHairGroupsInterpolation, FHairGroupsInterpolation>.ToNative);
			}
			return InterpolationSettings_MarshalerCached.FromNative(IntPtr.Add(base.Address, InterpolationSettings_Offset));
		}
	}

	static UGroomImportOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomImportOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomImportOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomImportOptions");
		ConversionSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ConversionSettings");
		ConversionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ConversionSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpolationSettings_PropertyAddress, unrealStruct, "InterpolationSettings");
		InterpolationSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InterpolationSettings");
		InterpolationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InterpolationSettings", Classes.FArrayProperty);
	}
}
