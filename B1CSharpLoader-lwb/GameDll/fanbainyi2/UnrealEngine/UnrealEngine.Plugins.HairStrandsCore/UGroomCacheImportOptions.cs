using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomCacheImportOptions", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomCacheImportOptions : UObject
{
	private static bool ImportSettings_IsValid;

	private static int ImportSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomCacheImportOptions:ImportSettings")]
	public FGroomCacheImportSettings ImportSettings
	{
		get
		{
			CheckDestroyed();
			if (!ImportSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCacheImportOptions:ImportSettings");
				return default(FGroomCacheImportSettings);
			}
			return FGroomCacheImportSettings.FromNative(IntPtr.Add(base.Address, ImportSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImportSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomCacheImportOptions:ImportSettings");
			}
			else
			{
				FGroomCacheImportSettings.ToNative(IntPtr.Add(base.Address, ImportSettings_Offset), value);
			}
		}
	}

	static UGroomCacheImportOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomCacheImportOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomCacheImportOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomCacheImportOptions");
		ImportSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImportSettings");
		ImportSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImportSettings", Classes.FStructProperty);
	}
}
