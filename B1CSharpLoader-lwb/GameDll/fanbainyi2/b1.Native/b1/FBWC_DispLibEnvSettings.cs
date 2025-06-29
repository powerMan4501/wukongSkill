using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/b1.BWC_DispLibEnvSettings", "b1", UnrealModuleType.Game)]
public struct FBWC_DispLibEnvSettings
{
	private static bool Override_SunLightIntensity_IsValid;

	private static FFieldAddress Override_SunLightIntensity_PropertyAddress;

	private static int Override_SunLightIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SunLightIntensity")]
	public bool Override_SunLightIntensity;

	private static bool Override_SunLightColor_IsValid;

	private static FFieldAddress Override_SunLightColor_PropertyAddress;

	private static int Override_SunLightColor_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SunLightColor")]
	public bool Override_SunLightColor;

	private static bool Override_SunAngle_IsValid;

	private static FFieldAddress Override_SunAngle_PropertyAddress;

	private static int Override_SunAngle_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SunAngle")]
	public bool Override_SunAngle;

	private static bool Override_SunInclination_IsValid;

	private static FFieldAddress Override_SunInclination_PropertyAddress;

	private static int Override_SunInclination_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SunInclination")]
	public bool Override_SunInclination;

	private static bool Override_SunExtentDawnAndDusk_IsValid;

	private static FFieldAddress Override_SunExtentDawnAndDusk_PropertyAddress;

	private static int Override_SunExtentDawnAndDusk_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SunExtentDawnAndDusk")]
	public bool Override_SunExtentDawnAndDusk;

	private static bool Override_SunVolumetricScattering_IsValid;

	private static FFieldAddress Override_SunVolumetricScattering_PropertyAddress;

	private static int Override_SunVolumetricScattering_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SunVolumetricScattering")]
	public bool Override_SunVolumetricScattering;

	private static bool Override_SunColorCurve_IsValid;

	private static FFieldAddress Override_SunColorCurve_PropertyAddress;

	private static int Override_SunColorCurve_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SunColorCurve")]
	public bool Override_SunColorCurve;

	private static bool Override_MoonLightIntensity_IsValid;

	private static FFieldAddress Override_MoonLightIntensity_PropertyAddress;

	private static int Override_MoonLightIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_MoonLightIntensity")]
	public bool Override_MoonLightIntensity;

	private static bool Override_MoonLightColor_IsValid;

	private static FFieldAddress Override_MoonLightColor_PropertyAddress;

	private static int Override_MoonLightColor_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_MoonLightColor")]
	public bool Override_MoonLightColor;

	private static bool Override_MoonInclination_IsValid;

	private static FFieldAddress Override_MoonInclination_PropertyAddress;

	private static int Override_MoonInclination_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_MoonInclination")]
	public bool Override_MoonInclination;

	private static bool Override_MoonOrbitOffset_IsValid;

	private static FFieldAddress Override_MoonOrbitOffset_PropertyAddress;

	private static int Override_MoonOrbitOffset_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_MoonOrbitOffset")]
	public bool Override_MoonOrbitOffset;

	private static bool Override_MoonAngle_IsValid;

	private static FFieldAddress Override_MoonAngle_PropertyAddress;

	private static int Override_MoonAngle_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_MoonAngle")]
	public bool Override_MoonAngle;

	private static bool Override_MoonVolumetricScattering_IsValid;

	private static FFieldAddress Override_MoonVolumetricScattering_PropertyAddress;

	private static int Override_MoonVolumetricScattering_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_MoonVolumetricScattering")]
	public bool Override_MoonVolumetricScattering;

	private static bool Override_MoonColorCurve_IsValid;

	private static FFieldAddress Override_MoonColorCurve_PropertyAddress;

	private static int Override_MoonColorCurve_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_MoonColorCurve")]
	public bool Override_MoonColorCurve;

	private static bool Override_SkyLightIntensity_IsValid;

	private static FFieldAddress Override_SkyLightIntensity_PropertyAddress;

	private static int Override_SkyLightIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SkyLightIntensity")]
	public bool Override_SkyLightIntensity;

	private static bool Override_SkyLightCubeArray_IsValid;

	private static FFieldAddress Override_SkyLightCubeArray_PropertyAddress;

	private static int Override_SkyLightCubeArray_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SkyLightCubeArray")]
	public bool Override_SkyLightCubeArray;

	private static bool Override_SkyLightColor_IsValid;

	private static FFieldAddress Override_SkyLightColor_PropertyAddress;

	private static int Override_SkyLightColor_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SkyLightColor")]
	public bool Override_SkyLightColor;

	private static bool Override_SkyLightVolumetricScattering_IsValid;

	private static FFieldAddress Override_SkyLightVolumetricScattering_PropertyAddress;

	private static int Override_SkyLightVolumetricScattering_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SkyLightVolumetricScattering")]
	public bool Override_SkyLightVolumetricScattering;

	private static bool Override_SkyLightCubeMap_IsValid;

	private static FFieldAddress Override_SkyLightCubeMap_PropertyAddress;

	private static int Override_SkyLightCubeMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_SkyLightCubeMap")]
	public bool Override_SkyLightCubeMap;

	private static bool Override_FogDensity_IsValid;

	private static FFieldAddress Override_FogDensity_PropertyAddress;

	private static int Override_FogDensity_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogDensity")]
	public bool Override_FogDensity;

	private static bool Override_FogDensityCurve_IsValid;

	private static FFieldAddress Override_FogDensityCurve_PropertyAddress;

	private static int Override_FogDensityCurve_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogDensityCurve")]
	public bool Override_FogDensityCurve;

	private static bool Override_FogHeightFalloff_IsValid;

	private static FFieldAddress Override_FogHeightFalloff_PropertyAddress;

	private static int Override_FogHeightFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogHeightFalloff")]
	public bool Override_FogHeightFalloff;

	private static bool Override_FogScatteringDistribution_IsValid;

	private static FFieldAddress Override_FogScatteringDistribution_PropertyAddress;

	private static int Override_FogScatteringDistribution_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogScatteringDistribution")]
	public bool Override_FogScatteringDistribution;

	private static bool Override_FogExtinctionScale_IsValid;

	private static FFieldAddress Override_FogExtinctionScale_PropertyAddress;

	private static int Override_FogExtinctionScale_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogExtinctionScale")]
	public bool Override_FogExtinctionScale;

	private static bool Override_FogStartDistance_IsValid;

	private static FFieldAddress Override_FogStartDistance_PropertyAddress;

	private static int Override_FogStartDistance_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogStartDistance")]
	public bool Override_FogStartDistance;

	private static bool Override_FogViewDistance_IsValid;

	private static FFieldAddress Override_FogViewDistance_PropertyAddress;

	private static int Override_FogViewDistance_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogViewDistance")]
	public bool Override_FogViewDistance;

	private static bool Override_FogAlbedoCurve_IsValid;

	private static FFieldAddress Override_FogAlbedoCurve_PropertyAddress;

	private static int Override_FogAlbedoCurve_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogAlbedoCurve")]
	public bool Override_FogAlbedoCurve;

	private static bool Override_FogEmissiveCurve_IsValid;

	private static FFieldAddress Override_FogEmissiveCurve_PropertyAddress;

	private static int Override_FogEmissiveCurve_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogEmissiveCurve")]
	public bool Override_FogEmissiveCurve;

	private static bool Override_LocalFogWeatherTexMask_IsValid;

	private static FFieldAddress Override_LocalFogWeatherTexMask_PropertyAddress;

	private static int Override_LocalFogWeatherTexMask_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogWeatherTexMask")]
	public bool Override_LocalFogWeatherTexMask;

	private static bool Override_FogAlbedo_IsValid;

	private static FFieldAddress Override_FogAlbedo_PropertyAddress;

	private static int Override_FogAlbedo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogAlbedo")]
	public bool Override_FogAlbedo;

	private static bool Override_FogEmissive_IsValid;

	private static FFieldAddress Override_FogEmissive_PropertyAddress;

	private static int Override_FogEmissive_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogEmissive")]
	public bool Override_FogEmissive;

	private static bool Override_FogScatteringColor_IsValid;

	private static FFieldAddress Override_FogScatteringColor_PropertyAddress;

	private static int Override_FogScatteringColor_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_FogScatteringColor")]
	public bool Override_FogScatteringColor;

	private static bool Override_LocalFogDensityMinMax_IsValid;

	private static FFieldAddress Override_LocalFogDensityMinMax_PropertyAddress;

	private static int Override_LocalFogDensityMinMax_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogDensityMinMax")]
	public bool Override_LocalFogDensityMinMax;

	private static bool Override_LocalFogAlbedo_IsValid;

	private static FFieldAddress Override_LocalFogAlbedo_PropertyAddress;

	private static int Override_LocalFogAlbedo_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogAlbedo")]
	public bool Override_LocalFogAlbedo;

	private static bool Override_LocalFogEmissive_IsValid;

	private static FFieldAddress Override_LocalFogEmissive_PropertyAddress;

	private static int Override_LocalFogEmissive_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogEmissive")]
	public bool Override_LocalFogEmissive;

	private static bool Override_LocalFogDensityTex_IsValid;

	private static FFieldAddress Override_LocalFogDensityTex_PropertyAddress;

	private static int Override_LocalFogDensityTex_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogDensityTex")]
	public bool Override_LocalFogDensityTex;

	private static bool Override_LocalFogHeightFalloff_IsValid;

	private static FFieldAddress Override_LocalFogHeightFalloff_PropertyAddress;

	private static int Override_LocalFogHeightFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogHeightFalloff")]
	public bool Override_LocalFogHeightFalloff;

	private static bool Override_LocalFogWeatherTexTilingAndFlowDir_IsValid;

	private static FFieldAddress Override_LocalFogWeatherTexTilingAndFlowDir_PropertyAddress;

	private static int Override_LocalFogWeatherTexTilingAndFlowDir_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogWeatherTexTilingAndFlowDir")]
	public bool Override_LocalFogWeatherTexTilingAndFlowDir;

	private static bool Override_LocalFogDensityTilingScale_IsValid;

	private static FFieldAddress Override_LocalFogDensityTilingScale_PropertyAddress;

	private static int Override_LocalFogDensityTilingScale_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogDensityTilingScale")]
	public bool Override_LocalFogDensityTilingScale;

	private static bool Override_LocalFogStartDistance_IsValid;

	private static FFieldAddress Override_LocalFogStartDistance_PropertyAddress;

	private static int Override_LocalFogStartDistance_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_LocalFogStartDistance")]
	public bool Override_LocalFogStartDistance;

	private static bool Override_WindStrengthScale_IsValid;

	private static FFieldAddress Override_WindStrengthScale_PropertyAddress;

	private static int Override_WindStrengthScale_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_WindStrengthScale")]
	public bool Override_WindStrengthScale;

	private static bool Override_WindStrengthCurve_IsValid;

	private static FFieldAddress Override_WindStrengthCurve_PropertyAddress;

	private static int Override_WindStrengthCurve_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:bOverride_WindStrengthCurve")]
	public bool Override_WindStrengthCurve;

	private static bool Weather_IsValid;

	private static FFieldAddress Weather_PropertyAddress;

	private static int Weather_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:Weather")]
	public EBGW_DispLibEnvWeather Weather;

	private static bool WeatherProbability_IsValid;

	private static int WeatherProbability_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:WeatherProbability")]
	public float WeatherProbability;

	private static bool SunLightIntensity_IsValid;

	private static int SunLightIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunLightIntensity")]
	public float SunLightIntensity;

	private static bool SunLightColor_IsValid;

	private static int SunLightColor_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunLightColor")]
	public FLinearColor SunLightColor;

	private static bool SunAngle_IsValid;

	private static int SunAngle_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunAngle")]
	public float SunAngle;

	private static bool SunInclination_IsValid;

	private static int SunInclination_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunInclination")]
	public float SunInclination;

	private static bool SunExtentDawnAndDusk_IsValid;

	private static int SunExtentDawnAndDusk_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunExtentDawnAndDusk")]
	public float SunExtentDawnAndDusk;

	private static bool SunVolumetricScattering_IsValid;

	private static int SunVolumetricScattering_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunVolumetricScattering")]
	public float SunVolumetricScattering;

	private static bool SunColorCurveValue_IsValid;

	private static int SunColorCurveValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunColorCurveValue")]
	public FLinearColor SunColorCurveValue;

	private static bool SunColorCurve_IsValid;

	private static int SunColorCurve_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SunColorCurve")]
	public UCurveLinearColor SunColorCurve;

	private static bool MoonLightIntensity_IsValid;

	private static int MoonLightIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonLightIntensity")]
	public float MoonLightIntensity;

	private static bool MoonLightColor_IsValid;

	private static int MoonLightColor_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonLightColor")]
	public FLinearColor MoonLightColor;

	private static bool MoonInclination_IsValid;

	private static int MoonInclination_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonInclination")]
	public float MoonInclination;

	private static bool MoonOrbitOffset_IsValid;

	private static int MoonOrbitOffset_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonOrbitOffset")]
	public float MoonOrbitOffset;

	private static bool MoonAngle_IsValid;

	private static int MoonAngle_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonAngle")]
	public float MoonAngle;

	private static bool MoonVolumetricScattering_IsValid;

	private static int MoonVolumetricScattering_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonVolumetricScattering")]
	public float MoonVolumetricScattering;

	private static bool MoonColorCurveValue_IsValid;

	private static int MoonColorCurveValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonColorCurveValue")]
	public FLinearColor MoonColorCurveValue;

	private static bool MoonColorCurve_IsValid;

	private static int MoonColorCurve_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:MoonColorCurve")]
	public UCurveLinearColor MoonColorCurve;

	private static bool SkyLightIntensity_IsValid;

	private static int SkyLightIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SkyLightIntensity")]
	public float SkyLightIntensity;

	private static bool SkyLightColor_IsValid;

	private static int SkyLightColor_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SkyLightColor")]
	public FLinearColor SkyLightColor;

	private static bool SkyLightVolumetricScattering_IsValid;

	private static int SkyLightVolumetricScattering_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SkyLightVolumetricScattering")]
	public float SkyLightVolumetricScattering;

	private static bool SkyLightCubeMap_IsValid;

	private static int SkyLightCubeMap_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SkyLightCubeMap")]
	public UTextureCube SkyLightCubeMap;

	private static bool SkyLightCubeArrayValue_IsValid;

	private static int SkyLightCubeArrayValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:SkyLightCubeArrayValue")]
	public int SkyLightCubeArrayValue;

	private static bool FogDensity_IsValid;

	private static int FogDensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogDensity")]
	public float FogDensity;

	private static bool FogDensityCurveValue_IsValid;

	private static int FogDensityCurveValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogDensityCurveValue")]
	public float FogDensityCurveValue;

	private static bool FogHeightFalloff_IsValid;

	private static int FogHeightFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogHeightFalloff")]
	public float FogHeightFalloff;

	private static bool FogScatteringDistribution_IsValid;

	private static int FogScatteringDistribution_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogScatteringDistribution")]
	public float FogScatteringDistribution;

	private static bool FogExtinctionScale_IsValid;

	private static int FogExtinctionScale_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogExtinctionScale")]
	public float FogExtinctionScale;

	private static bool FogStartDistance_IsValid;

	private static int FogStartDistance_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogStartDistance")]
	public float FogStartDistance;

	private static bool FogViewDistance_IsValid;

	private static int FogViewDistance_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogViewDistance")]
	public float FogViewDistance;

	private static bool FogAlbedoCurveValue_IsValid;

	private static int FogAlbedoCurveValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogAlbedoCurveValue")]
	public FLinearColor FogAlbedoCurveValue;

	private static bool FogEmissiveCurveValue_IsValid;

	private static int FogEmissiveCurveValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogEmissiveCurveValue")]
	public FLinearColor FogEmissiveCurveValue;

	private static bool FogScatteringColor_IsValid;

	private static int FogScatteringColor_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogScatteringColor")]
	public FLinearColor FogScatteringColor;

	private static bool FogAlbedo_IsValid;

	private static int FogAlbedo_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogAlbedo")]
	public FLinearColor FogAlbedo;

	private static bool FogEmissive_IsValid;

	private static int FogEmissive_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogEmissive")]
	public FLinearColor FogEmissive;

	private static bool FogDensityCurve_IsValid;

	private static int FogDensityCurve_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogDensityCurve")]
	public UCurveFloat FogDensityCurve;

	private static bool FogAlbedoCurve_IsValid;

	private static int FogAlbedoCurve_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogAlbedoCurve")]
	public UCurveLinearColor FogAlbedoCurve;

	private static bool FogEmissiveCurve_IsValid;

	private static int FogEmissiveCurve_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:FogEmissiveCurve")]
	public UCurveLinearColor FogEmissiveCurve;

	private static bool LocalFogWeatherTexMask_IsValid;

	private static int LocalFogWeatherTexMask_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogWeatherTexMask")]
	public int LocalFogWeatherTexMask;

	private static bool LocalFogDensityMinMax_IsValid;

	private static int LocalFogDensityMinMax_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogDensityMinMax")]
	public FVector2D LocalFogDensityMinMax;

	private static bool LocalFogHeightFalloff_IsValid;

	private static int LocalFogHeightFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogHeightFalloff")]
	public float LocalFogHeightFalloff;

	private static bool LocalFogAlbedo_IsValid;

	private static int LocalFogAlbedo_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogAlbedo")]
	public FLinearColor LocalFogAlbedo;

	private static bool LocalFogEmissive_IsValid;

	private static int LocalFogEmissive_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogEmissive")]
	public FLinearColor LocalFogEmissive;

	private static bool LocalFogWeatherTexTilingAndFlowDir_IsValid;

	private static int LocalFogWeatherTexTilingAndFlowDir_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogWeatherTexTilingAndFlowDir")]
	public FVector4 LocalFogWeatherTexTilingAndFlowDir;

	private static bool LocalFogDensityTex_IsValid;

	private static int LocalFogDensityTex_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogDensityTex")]
	public UVolumeTexture LocalFogDensityTex;

	private static bool LocalFogDensityTilingScale_IsValid;

	private static int LocalFogDensityTilingScale_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogDensityTilingScale")]
	public FVector LocalFogDensityTilingScale;

	private static bool LocalFogStartDistance_IsValid;

	private static int LocalFogStartDistance_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:LocalFogStartDistance")]
	public float LocalFogStartDistance;

	private static bool WindStrengthScale_IsValid;

	private static int WindStrengthScale_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:WindStrengthScale")]
	public float WindStrengthScale;

	private static bool WindStrengthCurveValue_IsValid;

	private static int WindStrengthCurveValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:WindStrengthCurveValue")]
	public float WindStrengthCurveValue;

	private static bool WindStrengthCurve_IsValid;

	private static int WindStrengthCurve_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:WindStrengthCurve")]
	public UCurveFloat WindStrengthCurve;

	private static bool WeatherFX_IsValid;

	private static int WeatherFX_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:WeatherFX")]
	public UNiagaraSystem WeatherFX;

	private static bool WeatherFXActor_IsValid;

	private static int WeatherFXActor_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvSettings:WeatherFXActor")]
	public AActor WeatherFXActor;

	private static bool FBWC_DispLibEnvSettings_IsValid;

	private static int FBWC_DispLibEnvSettings_StructSize;

	public FBWC_DispLibEnvSettings Copy()
	{
		return this;
	}

	public static FBWC_DispLibEnvSettings FromNative(IntPtr nativeBuffer)
	{
		return new FBWC_DispLibEnvSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBWC_DispLibEnvSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBWC_DispLibEnvSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBWC_DispLibEnvSettings(nativeBuffer + arrayIndex * FBWC_DispLibEnvSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBWC_DispLibEnvSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBWC_DispLibEnvSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBWC_DispLibEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BWC_DispLibEnvSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SunLightIntensity_Offset), 0, Override_SunLightIntensity_PropertyAddress.Address, Override_SunLightIntensity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SunLightColor_Offset), 0, Override_SunLightColor_PropertyAddress.Address, Override_SunLightColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SunAngle_Offset), 0, Override_SunAngle_PropertyAddress.Address, Override_SunAngle);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SunInclination_Offset), 0, Override_SunInclination_PropertyAddress.Address, Override_SunInclination);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SunExtentDawnAndDusk_Offset), 0, Override_SunExtentDawnAndDusk_PropertyAddress.Address, Override_SunExtentDawnAndDusk);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SunVolumetricScattering_Offset), 0, Override_SunVolumetricScattering_PropertyAddress.Address, Override_SunVolumetricScattering);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SunColorCurve_Offset), 0, Override_SunColorCurve_PropertyAddress.Address, Override_SunColorCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_MoonLightIntensity_Offset), 0, Override_MoonLightIntensity_PropertyAddress.Address, Override_MoonLightIntensity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_MoonLightColor_Offset), 0, Override_MoonLightColor_PropertyAddress.Address, Override_MoonLightColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_MoonInclination_Offset), 0, Override_MoonInclination_PropertyAddress.Address, Override_MoonInclination);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_MoonOrbitOffset_Offset), 0, Override_MoonOrbitOffset_PropertyAddress.Address, Override_MoonOrbitOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_MoonAngle_Offset), 0, Override_MoonAngle_PropertyAddress.Address, Override_MoonAngle);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_MoonVolumetricScattering_Offset), 0, Override_MoonVolumetricScattering_PropertyAddress.Address, Override_MoonVolumetricScattering);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_MoonColorCurve_Offset), 0, Override_MoonColorCurve_PropertyAddress.Address, Override_MoonColorCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SkyLightIntensity_Offset), 0, Override_SkyLightIntensity_PropertyAddress.Address, Override_SkyLightIntensity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SkyLightCubeArray_Offset), 0, Override_SkyLightCubeArray_PropertyAddress.Address, Override_SkyLightCubeArray);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SkyLightColor_Offset), 0, Override_SkyLightColor_PropertyAddress.Address, Override_SkyLightColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SkyLightVolumetricScattering_Offset), 0, Override_SkyLightVolumetricScattering_PropertyAddress.Address, Override_SkyLightVolumetricScattering);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_SkyLightCubeMap_Offset), 0, Override_SkyLightCubeMap_PropertyAddress.Address, Override_SkyLightCubeMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogDensity_Offset), 0, Override_FogDensity_PropertyAddress.Address, Override_FogDensity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogDensityCurve_Offset), 0, Override_FogDensityCurve_PropertyAddress.Address, Override_FogDensityCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogHeightFalloff_Offset), 0, Override_FogHeightFalloff_PropertyAddress.Address, Override_FogHeightFalloff);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogScatteringDistribution_Offset), 0, Override_FogScatteringDistribution_PropertyAddress.Address, Override_FogScatteringDistribution);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogExtinctionScale_Offset), 0, Override_FogExtinctionScale_PropertyAddress.Address, Override_FogExtinctionScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogStartDistance_Offset), 0, Override_FogStartDistance_PropertyAddress.Address, Override_FogStartDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogViewDistance_Offset), 0, Override_FogViewDistance_PropertyAddress.Address, Override_FogViewDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogAlbedoCurve_Offset), 0, Override_FogAlbedoCurve_PropertyAddress.Address, Override_FogAlbedoCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogEmissiveCurve_Offset), 0, Override_FogEmissiveCurve_PropertyAddress.Address, Override_FogEmissiveCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogWeatherTexMask_Offset), 0, Override_LocalFogWeatherTexMask_PropertyAddress.Address, Override_LocalFogWeatherTexMask);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogAlbedo_Offset), 0, Override_FogAlbedo_PropertyAddress.Address, Override_FogAlbedo);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogEmissive_Offset), 0, Override_FogEmissive_PropertyAddress.Address, Override_FogEmissive);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_FogScatteringColor_Offset), 0, Override_FogScatteringColor_PropertyAddress.Address, Override_FogScatteringColor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogDensityMinMax_Offset), 0, Override_LocalFogDensityMinMax_PropertyAddress.Address, Override_LocalFogDensityMinMax);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogAlbedo_Offset), 0, Override_LocalFogAlbedo_PropertyAddress.Address, Override_LocalFogAlbedo);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogEmissive_Offset), 0, Override_LocalFogEmissive_PropertyAddress.Address, Override_LocalFogEmissive);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogDensityTex_Offset), 0, Override_LocalFogDensityTex_PropertyAddress.Address, Override_LocalFogDensityTex);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogHeightFalloff_Offset), 0, Override_LocalFogHeightFalloff_PropertyAddress.Address, Override_LocalFogHeightFalloff);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogWeatherTexTilingAndFlowDir_Offset), 0, Override_LocalFogWeatherTexTilingAndFlowDir_PropertyAddress.Address, Override_LocalFogWeatherTexTilingAndFlowDir);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogDensityTilingScale_Offset), 0, Override_LocalFogDensityTilingScale_PropertyAddress.Address, Override_LocalFogDensityTilingScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_LocalFogStartDistance_Offset), 0, Override_LocalFogStartDistance_PropertyAddress.Address, Override_LocalFogStartDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_WindStrengthScale_Offset), 0, Override_WindStrengthScale_PropertyAddress.Address, Override_WindStrengthScale);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_WindStrengthCurve_Offset), 0, Override_WindStrengthCurve_PropertyAddress.Address, Override_WindStrengthCurve);
		EnumMarshaler<EBGW_DispLibEnvWeather>.ToNative(IntPtr.Add(nativeStruct, Weather_Offset), 0, Weather_PropertyAddress.Address, Weather);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WeatherProbability_Offset), WeatherProbability);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SunLightIntensity_Offset), SunLightIntensity);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, SunLightColor_Offset), SunLightColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SunAngle_Offset), SunAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SunInclination_Offset), SunInclination);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SunExtentDawnAndDusk_Offset), SunExtentDawnAndDusk);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SunVolumetricScattering_Offset), SunVolumetricScattering);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, SunColorCurveValue_Offset), SunColorCurveValue);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, SunColorCurve_Offset), SunColorCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MoonLightIntensity_Offset), MoonLightIntensity);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, MoonLightColor_Offset), MoonLightColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MoonInclination_Offset), MoonInclination);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MoonOrbitOffset_Offset), MoonOrbitOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MoonAngle_Offset), MoonAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MoonVolumetricScattering_Offset), MoonVolumetricScattering);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, MoonColorCurveValue_Offset), MoonColorCurveValue);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, MoonColorCurve_Offset), MoonColorCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SkyLightIntensity_Offset), SkyLightIntensity);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, SkyLightColor_Offset), SkyLightColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SkyLightVolumetricScattering_Offset), SkyLightVolumetricScattering);
		UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(nativeStruct, SkyLightCubeMap_Offset), SkyLightCubeMap);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SkyLightCubeArrayValue_Offset), SkyLightCubeArrayValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogDensity_Offset), FogDensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogDensityCurveValue_Offset), FogDensityCurveValue);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogHeightFalloff_Offset), FogHeightFalloff);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogScatteringDistribution_Offset), FogScatteringDistribution);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogExtinctionScale_Offset), FogExtinctionScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogStartDistance_Offset), FogStartDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FogViewDistance_Offset), FogViewDistance);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, FogAlbedoCurveValue_Offset), FogAlbedoCurveValue);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, FogEmissiveCurveValue_Offset), FogEmissiveCurveValue);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, FogScatteringColor_Offset), FogScatteringColor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, FogAlbedo_Offset), FogAlbedo);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, FogEmissive_Offset), FogEmissive);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, FogDensityCurve_Offset), FogDensityCurve);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, FogAlbedoCurve_Offset), FogAlbedoCurve);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(nativeStruct, FogEmissiveCurve_Offset), FogEmissiveCurve);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LocalFogWeatherTexMask_Offset), LocalFogWeatherTexMask);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, LocalFogDensityMinMax_Offset), LocalFogDensityMinMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LocalFogHeightFalloff_Offset), LocalFogHeightFalloff);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, LocalFogAlbedo_Offset), LocalFogAlbedo);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, LocalFogEmissive_Offset), LocalFogEmissive);
		BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(nativeStruct, LocalFogWeatherTexTilingAndFlowDir_Offset), LocalFogWeatherTexTilingAndFlowDir);
		UObjectMarshaler<UVolumeTexture>.ToNative(IntPtr.Add(nativeStruct, LocalFogDensityTex_Offset), LocalFogDensityTex);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, LocalFogDensityTilingScale_Offset), LocalFogDensityTilingScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LocalFogStartDistance_Offset), LocalFogStartDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindStrengthScale_Offset), WindStrengthScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindStrengthCurveValue_Offset), WindStrengthCurveValue);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, WindStrengthCurve_Offset), WindStrengthCurve);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, WeatherFX_Offset), WeatherFX);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, WeatherFXActor_Offset), WeatherFXActor);
	}

	public FBWC_DispLibEnvSettings(IntPtr nativeStruct)
	{
		if (!FBWC_DispLibEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.BWC_DispLibEnvSettings");
			Override_SunLightIntensity = false;
			Override_SunLightColor = false;
			Override_SunAngle = false;
			Override_SunInclination = false;
			Override_SunExtentDawnAndDusk = false;
			Override_SunVolumetricScattering = false;
			Override_SunColorCurve = false;
			Override_MoonLightIntensity = false;
			Override_MoonLightColor = false;
			Override_MoonInclination = false;
			Override_MoonOrbitOffset = false;
			Override_MoonAngle = false;
			Override_MoonVolumetricScattering = false;
			Override_MoonColorCurve = false;
			Override_SkyLightIntensity = false;
			Override_SkyLightCubeArray = false;
			Override_SkyLightColor = false;
			Override_SkyLightVolumetricScattering = false;
			Override_SkyLightCubeMap = false;
			Override_FogDensity = false;
			Override_FogDensityCurve = false;
			Override_FogHeightFalloff = false;
			Override_FogScatteringDistribution = false;
			Override_FogExtinctionScale = false;
			Override_FogStartDistance = false;
			Override_FogViewDistance = false;
			Override_FogAlbedoCurve = false;
			Override_FogEmissiveCurve = false;
			Override_LocalFogWeatherTexMask = false;
			Override_FogAlbedo = false;
			Override_FogEmissive = false;
			Override_FogScatteringColor = false;
			Override_LocalFogDensityMinMax = false;
			Override_LocalFogAlbedo = false;
			Override_LocalFogEmissive = false;
			Override_LocalFogDensityTex = false;
			Override_LocalFogHeightFalloff = false;
			Override_LocalFogWeatherTexTilingAndFlowDir = false;
			Override_LocalFogDensityTilingScale = false;
			Override_LocalFogStartDistance = false;
			Override_WindStrengthScale = false;
			Override_WindStrengthCurve = false;
			Weather = EBGW_DispLibEnvWeather.Sunny;
			WeatherProbability = 0f;
			SunLightIntensity = 0f;
			SunLightColor = default(FLinearColor);
			SunAngle = 0f;
			SunInclination = 0f;
			SunExtentDawnAndDusk = 0f;
			SunVolumetricScattering = 0f;
			SunColorCurveValue = default(FLinearColor);
			SunColorCurve = null;
			MoonLightIntensity = 0f;
			MoonLightColor = default(FLinearColor);
			MoonInclination = 0f;
			MoonOrbitOffset = 0f;
			MoonAngle = 0f;
			MoonVolumetricScattering = 0f;
			MoonColorCurveValue = default(FLinearColor);
			MoonColorCurve = null;
			SkyLightIntensity = 0f;
			SkyLightColor = default(FLinearColor);
			SkyLightVolumetricScattering = 0f;
			SkyLightCubeMap = null;
			SkyLightCubeArrayValue = 0;
			FogDensity = 0f;
			FogDensityCurveValue = 0f;
			FogHeightFalloff = 0f;
			FogScatteringDistribution = 0f;
			FogExtinctionScale = 0f;
			FogStartDistance = 0f;
			FogViewDistance = 0f;
			FogAlbedoCurveValue = default(FLinearColor);
			FogEmissiveCurveValue = default(FLinearColor);
			FogScatteringColor = default(FLinearColor);
			FogAlbedo = default(FLinearColor);
			FogEmissive = default(FLinearColor);
			FogDensityCurve = null;
			FogAlbedoCurve = null;
			FogEmissiveCurve = null;
			LocalFogWeatherTexMask = 0;
			LocalFogDensityMinMax = default(FVector2D);
			LocalFogHeightFalloff = 0f;
			LocalFogAlbedo = default(FLinearColor);
			LocalFogEmissive = default(FLinearColor);
			LocalFogWeatherTexTilingAndFlowDir = default(FVector4);
			LocalFogDensityTex = null;
			LocalFogDensityTilingScale = default(FVector);
			LocalFogStartDistance = 0f;
			WindStrengthScale = 0f;
			WindStrengthCurveValue = 0f;
			WindStrengthCurve = null;
			WeatherFX = null;
			WeatherFXActor = null;
		}
		else
		{
			Override_SunLightIntensity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SunLightIntensity_Offset), 0, Override_SunLightIntensity_PropertyAddress.Address);
			Override_SunLightColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SunLightColor_Offset), 0, Override_SunLightColor_PropertyAddress.Address);
			Override_SunAngle = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SunAngle_Offset), 0, Override_SunAngle_PropertyAddress.Address);
			Override_SunInclination = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SunInclination_Offset), 0, Override_SunInclination_PropertyAddress.Address);
			Override_SunExtentDawnAndDusk = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SunExtentDawnAndDusk_Offset), 0, Override_SunExtentDawnAndDusk_PropertyAddress.Address);
			Override_SunVolumetricScattering = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SunVolumetricScattering_Offset), 0, Override_SunVolumetricScattering_PropertyAddress.Address);
			Override_SunColorCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SunColorCurve_Offset), 0, Override_SunColorCurve_PropertyAddress.Address);
			Override_MoonLightIntensity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_MoonLightIntensity_Offset), 0, Override_MoonLightIntensity_PropertyAddress.Address);
			Override_MoonLightColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_MoonLightColor_Offset), 0, Override_MoonLightColor_PropertyAddress.Address);
			Override_MoonInclination = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_MoonInclination_Offset), 0, Override_MoonInclination_PropertyAddress.Address);
			Override_MoonOrbitOffset = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_MoonOrbitOffset_Offset), 0, Override_MoonOrbitOffset_PropertyAddress.Address);
			Override_MoonAngle = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_MoonAngle_Offset), 0, Override_MoonAngle_PropertyAddress.Address);
			Override_MoonVolumetricScattering = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_MoonVolumetricScattering_Offset), 0, Override_MoonVolumetricScattering_PropertyAddress.Address);
			Override_MoonColorCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_MoonColorCurve_Offset), 0, Override_MoonColorCurve_PropertyAddress.Address);
			Override_SkyLightIntensity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SkyLightIntensity_Offset), 0, Override_SkyLightIntensity_PropertyAddress.Address);
			Override_SkyLightCubeArray = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SkyLightCubeArray_Offset), 0, Override_SkyLightCubeArray_PropertyAddress.Address);
			Override_SkyLightColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SkyLightColor_Offset), 0, Override_SkyLightColor_PropertyAddress.Address);
			Override_SkyLightVolumetricScattering = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SkyLightVolumetricScattering_Offset), 0, Override_SkyLightVolumetricScattering_PropertyAddress.Address);
			Override_SkyLightCubeMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_SkyLightCubeMap_Offset), 0, Override_SkyLightCubeMap_PropertyAddress.Address);
			Override_FogDensity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogDensity_Offset), 0, Override_FogDensity_PropertyAddress.Address);
			Override_FogDensityCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogDensityCurve_Offset), 0, Override_FogDensityCurve_PropertyAddress.Address);
			Override_FogHeightFalloff = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogHeightFalloff_Offset), 0, Override_FogHeightFalloff_PropertyAddress.Address);
			Override_FogScatteringDistribution = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogScatteringDistribution_Offset), 0, Override_FogScatteringDistribution_PropertyAddress.Address);
			Override_FogExtinctionScale = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogExtinctionScale_Offset), 0, Override_FogExtinctionScale_PropertyAddress.Address);
			Override_FogStartDistance = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogStartDistance_Offset), 0, Override_FogStartDistance_PropertyAddress.Address);
			Override_FogViewDistance = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogViewDistance_Offset), 0, Override_FogViewDistance_PropertyAddress.Address);
			Override_FogAlbedoCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogAlbedoCurve_Offset), 0, Override_FogAlbedoCurve_PropertyAddress.Address);
			Override_FogEmissiveCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogEmissiveCurve_Offset), 0, Override_FogEmissiveCurve_PropertyAddress.Address);
			Override_LocalFogWeatherTexMask = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogWeatherTexMask_Offset), 0, Override_LocalFogWeatherTexMask_PropertyAddress.Address);
			Override_FogAlbedo = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogAlbedo_Offset), 0, Override_FogAlbedo_PropertyAddress.Address);
			Override_FogEmissive = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogEmissive_Offset), 0, Override_FogEmissive_PropertyAddress.Address);
			Override_FogScatteringColor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_FogScatteringColor_Offset), 0, Override_FogScatteringColor_PropertyAddress.Address);
			Override_LocalFogDensityMinMax = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogDensityMinMax_Offset), 0, Override_LocalFogDensityMinMax_PropertyAddress.Address);
			Override_LocalFogAlbedo = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogAlbedo_Offset), 0, Override_LocalFogAlbedo_PropertyAddress.Address);
			Override_LocalFogEmissive = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogEmissive_Offset), 0, Override_LocalFogEmissive_PropertyAddress.Address);
			Override_LocalFogDensityTex = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogDensityTex_Offset), 0, Override_LocalFogDensityTex_PropertyAddress.Address);
			Override_LocalFogHeightFalloff = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogHeightFalloff_Offset), 0, Override_LocalFogHeightFalloff_PropertyAddress.Address);
			Override_LocalFogWeatherTexTilingAndFlowDir = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogWeatherTexTilingAndFlowDir_Offset), 0, Override_LocalFogWeatherTexTilingAndFlowDir_PropertyAddress.Address);
			Override_LocalFogDensityTilingScale = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogDensityTilingScale_Offset), 0, Override_LocalFogDensityTilingScale_PropertyAddress.Address);
			Override_LocalFogStartDistance = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_LocalFogStartDistance_Offset), 0, Override_LocalFogStartDistance_PropertyAddress.Address);
			Override_WindStrengthScale = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_WindStrengthScale_Offset), 0, Override_WindStrengthScale_PropertyAddress.Address);
			Override_WindStrengthCurve = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_WindStrengthCurve_Offset), 0, Override_WindStrengthCurve_PropertyAddress.Address);
			Weather = EnumMarshaler<EBGW_DispLibEnvWeather>.FromNative(IntPtr.Add(nativeStruct, Weather_Offset), 0, Weather_PropertyAddress.Address);
			WeatherProbability = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WeatherProbability_Offset));
			SunLightIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SunLightIntensity_Offset));
			SunLightColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, SunLightColor_Offset));
			SunAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SunAngle_Offset));
			SunInclination = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SunInclination_Offset));
			SunExtentDawnAndDusk = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SunExtentDawnAndDusk_Offset));
			SunVolumetricScattering = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SunVolumetricScattering_Offset));
			SunColorCurveValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, SunColorCurveValue_Offset));
			SunColorCurve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, SunColorCurve_Offset));
			MoonLightIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MoonLightIntensity_Offset));
			MoonLightColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, MoonLightColor_Offset));
			MoonInclination = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MoonInclination_Offset));
			MoonOrbitOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MoonOrbitOffset_Offset));
			MoonAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MoonAngle_Offset));
			MoonVolumetricScattering = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MoonVolumetricScattering_Offset));
			MoonColorCurveValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, MoonColorCurveValue_Offset));
			MoonColorCurve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, MoonColorCurve_Offset));
			SkyLightIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SkyLightIntensity_Offset));
			SkyLightColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, SkyLightColor_Offset));
			SkyLightVolumetricScattering = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SkyLightVolumetricScattering_Offset));
			SkyLightCubeMap = UObjectMarshaler<UTextureCube>.FromNative(IntPtr.Add(nativeStruct, SkyLightCubeMap_Offset));
			SkyLightCubeArrayValue = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SkyLightCubeArrayValue_Offset));
			FogDensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogDensity_Offset));
			FogDensityCurveValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogDensityCurveValue_Offset));
			FogHeightFalloff = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogHeightFalloff_Offset));
			FogScatteringDistribution = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogScatteringDistribution_Offset));
			FogExtinctionScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogExtinctionScale_Offset));
			FogStartDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogStartDistance_Offset));
			FogViewDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FogViewDistance_Offset));
			FogAlbedoCurveValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, FogAlbedoCurveValue_Offset));
			FogEmissiveCurveValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, FogEmissiveCurveValue_Offset));
			FogScatteringColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, FogScatteringColor_Offset));
			FogAlbedo = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, FogAlbedo_Offset));
			FogEmissive = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, FogEmissive_Offset));
			FogDensityCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, FogDensityCurve_Offset));
			FogAlbedoCurve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, FogAlbedoCurve_Offset));
			FogEmissiveCurve = UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(nativeStruct, FogEmissiveCurve_Offset));
			LocalFogWeatherTexMask = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LocalFogWeatherTexMask_Offset));
			LocalFogDensityMinMax = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, LocalFogDensityMinMax_Offset));
			LocalFogHeightFalloff = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LocalFogHeightFalloff_Offset));
			LocalFogAlbedo = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, LocalFogAlbedo_Offset));
			LocalFogEmissive = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, LocalFogEmissive_Offset));
			LocalFogWeatherTexTilingAndFlowDir = BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(nativeStruct, LocalFogWeatherTexTilingAndFlowDir_Offset));
			LocalFogDensityTex = UObjectMarshaler<UVolumeTexture>.FromNative(IntPtr.Add(nativeStruct, LocalFogDensityTex_Offset));
			LocalFogDensityTilingScale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, LocalFogDensityTilingScale_Offset));
			LocalFogStartDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LocalFogStartDistance_Offset));
			WindStrengthScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindStrengthScale_Offset));
			WindStrengthCurveValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindStrengthCurveValue_Offset));
			WindStrengthCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, WindStrengthCurve_Offset));
			WeatherFX = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, WeatherFX_Offset));
			WeatherFXActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, WeatherFXActor_Offset));
		}
	}

	static FBWC_DispLibEnvSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBWC_DispLibEnvSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBWC_DispLibEnvSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.BWC_DispLibEnvSettings");
		FBWC_DispLibEnvSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Override_SunLightIntensity_PropertyAddress, intPtr, "bOverride_SunLightIntensity");
		Override_SunLightIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SunLightIntensity");
		Override_SunLightIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SunLightIntensity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SunLightColor_PropertyAddress, intPtr, "bOverride_SunLightColor");
		Override_SunLightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SunLightColor");
		Override_SunLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SunLightColor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SunAngle_PropertyAddress, intPtr, "bOverride_SunAngle");
		Override_SunAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SunAngle");
		Override_SunAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SunAngle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SunInclination_PropertyAddress, intPtr, "bOverride_SunInclination");
		Override_SunInclination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SunInclination");
		Override_SunInclination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SunInclination", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SunExtentDawnAndDusk_PropertyAddress, intPtr, "bOverride_SunExtentDawnAndDusk");
		Override_SunExtentDawnAndDusk_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SunExtentDawnAndDusk");
		Override_SunExtentDawnAndDusk_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SunExtentDawnAndDusk", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SunVolumetricScattering_PropertyAddress, intPtr, "bOverride_SunVolumetricScattering");
		Override_SunVolumetricScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SunVolumetricScattering");
		Override_SunVolumetricScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SunVolumetricScattering", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SunColorCurve_PropertyAddress, intPtr, "bOverride_SunColorCurve");
		Override_SunColorCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SunColorCurve");
		Override_SunColorCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SunColorCurve", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_MoonLightIntensity_PropertyAddress, intPtr, "bOverride_MoonLightIntensity");
		Override_MoonLightIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_MoonLightIntensity");
		Override_MoonLightIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_MoonLightIntensity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_MoonLightColor_PropertyAddress, intPtr, "bOverride_MoonLightColor");
		Override_MoonLightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_MoonLightColor");
		Override_MoonLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_MoonLightColor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_MoonInclination_PropertyAddress, intPtr, "bOverride_MoonInclination");
		Override_MoonInclination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_MoonInclination");
		Override_MoonInclination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_MoonInclination", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_MoonOrbitOffset_PropertyAddress, intPtr, "bOverride_MoonOrbitOffset");
		Override_MoonOrbitOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_MoonOrbitOffset");
		Override_MoonOrbitOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_MoonOrbitOffset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_MoonAngle_PropertyAddress, intPtr, "bOverride_MoonAngle");
		Override_MoonAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_MoonAngle");
		Override_MoonAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_MoonAngle", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_MoonVolumetricScattering_PropertyAddress, intPtr, "bOverride_MoonVolumetricScattering");
		Override_MoonVolumetricScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_MoonVolumetricScattering");
		Override_MoonVolumetricScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_MoonVolumetricScattering", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_MoonColorCurve_PropertyAddress, intPtr, "bOverride_MoonColorCurve");
		Override_MoonColorCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_MoonColorCurve");
		Override_MoonColorCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_MoonColorCurve", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SkyLightIntensity_PropertyAddress, intPtr, "bOverride_SkyLightIntensity");
		Override_SkyLightIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SkyLightIntensity");
		Override_SkyLightIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SkyLightIntensity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SkyLightCubeArray_PropertyAddress, intPtr, "bOverride_SkyLightCubeArray");
		Override_SkyLightCubeArray_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SkyLightCubeArray");
		Override_SkyLightCubeArray_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SkyLightCubeArray", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SkyLightColor_PropertyAddress, intPtr, "bOverride_SkyLightColor");
		Override_SkyLightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SkyLightColor");
		Override_SkyLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SkyLightColor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SkyLightVolumetricScattering_PropertyAddress, intPtr, "bOverride_SkyLightVolumetricScattering");
		Override_SkyLightVolumetricScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SkyLightVolumetricScattering");
		Override_SkyLightVolumetricScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SkyLightVolumetricScattering", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SkyLightCubeMap_PropertyAddress, intPtr, "bOverride_SkyLightCubeMap");
		Override_SkyLightCubeMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_SkyLightCubeMap");
		Override_SkyLightCubeMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_SkyLightCubeMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogDensity_PropertyAddress, intPtr, "bOverride_FogDensity");
		Override_FogDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogDensity");
		Override_FogDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogDensity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogDensityCurve_PropertyAddress, intPtr, "bOverride_FogDensityCurve");
		Override_FogDensityCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogDensityCurve");
		Override_FogDensityCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogDensityCurve", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogHeightFalloff_PropertyAddress, intPtr, "bOverride_FogHeightFalloff");
		Override_FogHeightFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogHeightFalloff");
		Override_FogHeightFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogHeightFalloff", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogScatteringDistribution_PropertyAddress, intPtr, "bOverride_FogScatteringDistribution");
		Override_FogScatteringDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogScatteringDistribution");
		Override_FogScatteringDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogScatteringDistribution", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogExtinctionScale_PropertyAddress, intPtr, "bOverride_FogExtinctionScale");
		Override_FogExtinctionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogExtinctionScale");
		Override_FogExtinctionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogExtinctionScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogStartDistance_PropertyAddress, intPtr, "bOverride_FogStartDistance");
		Override_FogStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogStartDistance");
		Override_FogStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogStartDistance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogViewDistance_PropertyAddress, intPtr, "bOverride_FogViewDistance");
		Override_FogViewDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogViewDistance");
		Override_FogViewDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogViewDistance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogAlbedoCurve_PropertyAddress, intPtr, "bOverride_FogAlbedoCurve");
		Override_FogAlbedoCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogAlbedoCurve");
		Override_FogAlbedoCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogAlbedoCurve", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogEmissiveCurve_PropertyAddress, intPtr, "bOverride_FogEmissiveCurve");
		Override_FogEmissiveCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogEmissiveCurve");
		Override_FogEmissiveCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogEmissiveCurve", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogWeatherTexMask_PropertyAddress, intPtr, "bOverride_LocalFogWeatherTexMask");
		Override_LocalFogWeatherTexMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogWeatherTexMask");
		Override_LocalFogWeatherTexMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogWeatherTexMask", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogAlbedo_PropertyAddress, intPtr, "bOverride_FogAlbedo");
		Override_FogAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogAlbedo");
		Override_FogAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogAlbedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogEmissive_PropertyAddress, intPtr, "bOverride_FogEmissive");
		Override_FogEmissive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogEmissive");
		Override_FogEmissive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogEmissive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_FogScatteringColor_PropertyAddress, intPtr, "bOverride_FogScatteringColor");
		Override_FogScatteringColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_FogScatteringColor");
		Override_FogScatteringColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_FogScatteringColor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogDensityMinMax_PropertyAddress, intPtr, "bOverride_LocalFogDensityMinMax");
		Override_LocalFogDensityMinMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogDensityMinMax");
		Override_LocalFogDensityMinMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogDensityMinMax", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogAlbedo_PropertyAddress, intPtr, "bOverride_LocalFogAlbedo");
		Override_LocalFogAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogAlbedo");
		Override_LocalFogAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogAlbedo", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogEmissive_PropertyAddress, intPtr, "bOverride_LocalFogEmissive");
		Override_LocalFogEmissive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogEmissive");
		Override_LocalFogEmissive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogEmissive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogDensityTex_PropertyAddress, intPtr, "bOverride_LocalFogDensityTex");
		Override_LocalFogDensityTex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogDensityTex");
		Override_LocalFogDensityTex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogDensityTex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogHeightFalloff_PropertyAddress, intPtr, "bOverride_LocalFogHeightFalloff");
		Override_LocalFogHeightFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogHeightFalloff");
		Override_LocalFogHeightFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogHeightFalloff", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogWeatherTexTilingAndFlowDir_PropertyAddress, intPtr, "bOverride_LocalFogWeatherTexTilingAndFlowDir");
		Override_LocalFogWeatherTexTilingAndFlowDir_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogWeatherTexTilingAndFlowDir");
		Override_LocalFogWeatherTexTilingAndFlowDir_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogWeatherTexTilingAndFlowDir", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogDensityTilingScale_PropertyAddress, intPtr, "bOverride_LocalFogDensityTilingScale");
		Override_LocalFogDensityTilingScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogDensityTilingScale");
		Override_LocalFogDensityTilingScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogDensityTilingScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_LocalFogStartDistance_PropertyAddress, intPtr, "bOverride_LocalFogStartDistance");
		Override_LocalFogStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_LocalFogStartDistance");
		Override_LocalFogStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_LocalFogStartDistance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_WindStrengthScale_PropertyAddress, intPtr, "bOverride_WindStrengthScale");
		Override_WindStrengthScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_WindStrengthScale");
		Override_WindStrengthScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_WindStrengthScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_WindStrengthCurve_PropertyAddress, intPtr, "bOverride_WindStrengthCurve");
		Override_WindStrengthCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_WindStrengthCurve");
		Override_WindStrengthCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_WindStrengthCurve", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Weather_PropertyAddress, intPtr, "Weather");
		Weather_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weather");
		Weather_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weather", Classes.FEnumProperty);
		WeatherProbability_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeatherProbability");
		WeatherProbability_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeatherProbability", Classes.FFloatProperty);
		SunLightIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunLightIntensity");
		SunLightIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunLightIntensity", Classes.FFloatProperty);
		SunLightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunLightColor");
		SunLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunLightColor", Classes.FStructProperty);
		SunAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunAngle");
		SunAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunAngle", Classes.FFloatProperty);
		SunInclination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunInclination");
		SunInclination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunInclination", Classes.FFloatProperty);
		SunExtentDawnAndDusk_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunExtentDawnAndDusk");
		SunExtentDawnAndDusk_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunExtentDawnAndDusk", Classes.FFloatProperty);
		SunVolumetricScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunVolumetricScattering");
		SunVolumetricScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunVolumetricScattering", Classes.FFloatProperty);
		SunColorCurveValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunColorCurveValue");
		SunColorCurveValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunColorCurveValue", Classes.FStructProperty);
		SunColorCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunColorCurve");
		SunColorCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunColorCurve", Classes.FObjectProperty);
		MoonLightIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonLightIntensity");
		MoonLightIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonLightIntensity", Classes.FFloatProperty);
		MoonLightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonLightColor");
		MoonLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonLightColor", Classes.FStructProperty);
		MoonInclination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonInclination");
		MoonInclination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonInclination", Classes.FFloatProperty);
		MoonOrbitOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonOrbitOffset");
		MoonOrbitOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonOrbitOffset", Classes.FFloatProperty);
		MoonAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonAngle");
		MoonAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonAngle", Classes.FFloatProperty);
		MoonVolumetricScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonVolumetricScattering");
		MoonVolumetricScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonVolumetricScattering", Classes.FFloatProperty);
		MoonColorCurveValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonColorCurveValue");
		MoonColorCurveValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonColorCurveValue", Classes.FStructProperty);
		MoonColorCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonColorCurve");
		MoonColorCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonColorCurve", Classes.FObjectProperty);
		SkyLightIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightIntensity");
		SkyLightIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightIntensity", Classes.FFloatProperty);
		SkyLightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightColor");
		SkyLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightColor", Classes.FStructProperty);
		SkyLightVolumetricScattering_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightVolumetricScattering");
		SkyLightVolumetricScattering_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightVolumetricScattering", Classes.FFloatProperty);
		SkyLightCubeMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightCubeMap");
		SkyLightCubeMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightCubeMap", Classes.FObjectProperty);
		SkyLightCubeArrayValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLightCubeArrayValue");
		SkyLightCubeArrayValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLightCubeArrayValue", Classes.FIntProperty);
		FogDensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogDensity");
		FogDensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogDensity", Classes.FFloatProperty);
		FogDensityCurveValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogDensityCurveValue");
		FogDensityCurveValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogDensityCurveValue", Classes.FFloatProperty);
		FogHeightFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogHeightFalloff");
		FogHeightFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogHeightFalloff", Classes.FFloatProperty);
		FogScatteringDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogScatteringDistribution");
		FogScatteringDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogScatteringDistribution", Classes.FFloatProperty);
		FogExtinctionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogExtinctionScale");
		FogExtinctionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogExtinctionScale", Classes.FFloatProperty);
		FogStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogStartDistance");
		FogStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogStartDistance", Classes.FFloatProperty);
		FogViewDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogViewDistance");
		FogViewDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogViewDistance", Classes.FFloatProperty);
		FogAlbedoCurveValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogAlbedoCurveValue");
		FogAlbedoCurveValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogAlbedoCurveValue", Classes.FStructProperty);
		FogEmissiveCurveValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogEmissiveCurveValue");
		FogEmissiveCurveValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogEmissiveCurveValue", Classes.FStructProperty);
		FogScatteringColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogScatteringColor");
		FogScatteringColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogScatteringColor", Classes.FStructProperty);
		FogAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogAlbedo");
		FogAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogAlbedo", Classes.FStructProperty);
		FogEmissive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogEmissive");
		FogEmissive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogEmissive", Classes.FStructProperty);
		FogDensityCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogDensityCurve");
		FogDensityCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogDensityCurve", Classes.FObjectProperty);
		FogAlbedoCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogAlbedoCurve");
		FogAlbedoCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogAlbedoCurve", Classes.FObjectProperty);
		FogEmissiveCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FogEmissiveCurve");
		FogEmissiveCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FogEmissiveCurve", Classes.FObjectProperty);
		LocalFogWeatherTexMask_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogWeatherTexMask");
		LocalFogWeatherTexMask_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogWeatherTexMask", Classes.FIntProperty);
		LocalFogDensityMinMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogDensityMinMax");
		LocalFogDensityMinMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogDensityMinMax", Classes.FStructProperty);
		LocalFogHeightFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogHeightFalloff");
		LocalFogHeightFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogHeightFalloff", Classes.FFloatProperty);
		LocalFogAlbedo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogAlbedo");
		LocalFogAlbedo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogAlbedo", Classes.FStructProperty);
		LocalFogEmissive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogEmissive");
		LocalFogEmissive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogEmissive", Classes.FStructProperty);
		LocalFogWeatherTexTilingAndFlowDir_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogWeatherTexTilingAndFlowDir");
		LocalFogWeatherTexTilingAndFlowDir_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogWeatherTexTilingAndFlowDir", Classes.FStructProperty);
		LocalFogDensityTex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogDensityTex");
		LocalFogDensityTex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogDensityTex", Classes.FObjectProperty);
		LocalFogDensityTilingScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogDensityTilingScale");
		LocalFogDensityTilingScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogDensityTilingScale", Classes.FStructProperty);
		LocalFogStartDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalFogStartDistance");
		LocalFogStartDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalFogStartDistance", Classes.FFloatProperty);
		WindStrengthScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindStrengthScale");
		WindStrengthScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindStrengthScale", Classes.FFloatProperty);
		WindStrengthCurveValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindStrengthCurveValue");
		WindStrengthCurveValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindStrengthCurveValue", Classes.FFloatProperty);
		WindStrengthCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindStrengthCurve");
		WindStrengthCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindStrengthCurve", Classes.FObjectProperty);
		WeatherFX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeatherFX");
		WeatherFX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeatherFX", Classes.FObjectProperty);
		WeatherFXActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeatherFXActor");
		WeatherFXActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeatherFXActor", Classes.FObjectProperty);
		FBWC_DispLibEnvSettings_IsValid = intPtr != IntPtr.Zero && Override_SunLightIntensity_IsValid && Override_SunLightColor_IsValid && Override_SunAngle_IsValid && Override_SunInclination_IsValid && Override_SunExtentDawnAndDusk_IsValid && Override_SunVolumetricScattering_IsValid && Override_SunColorCurve_IsValid && Override_MoonLightIntensity_IsValid && Override_MoonLightColor_IsValid && Override_MoonInclination_IsValid && Override_MoonOrbitOffset_IsValid && Override_MoonAngle_IsValid && Override_MoonVolumetricScattering_IsValid && Override_MoonColorCurve_IsValid && Override_SkyLightIntensity_IsValid && Override_SkyLightCubeArray_IsValid && Override_SkyLightColor_IsValid && Override_SkyLightVolumetricScattering_IsValid && Override_SkyLightCubeMap_IsValid && Override_FogDensity_IsValid && Override_FogDensityCurve_IsValid && Override_FogHeightFalloff_IsValid && Override_FogScatteringDistribution_IsValid && Override_FogExtinctionScale_IsValid && Override_FogStartDistance_IsValid && Override_FogViewDistance_IsValid && Override_FogAlbedoCurve_IsValid && Override_FogEmissiveCurve_IsValid && Override_LocalFogWeatherTexMask_IsValid && Override_FogAlbedo_IsValid && Override_FogEmissive_IsValid && Override_FogScatteringColor_IsValid && Override_LocalFogDensityMinMax_IsValid && Override_LocalFogAlbedo_IsValid && Override_LocalFogEmissive_IsValid && Override_LocalFogDensityTex_IsValid && Override_LocalFogHeightFalloff_IsValid && Override_LocalFogWeatherTexTilingAndFlowDir_IsValid && Override_LocalFogDensityTilingScale_IsValid && Override_LocalFogStartDistance_IsValid && Override_WindStrengthScale_IsValid && Override_WindStrengthCurve_IsValid && Weather_IsValid && WeatherProbability_IsValid && SunLightIntensity_IsValid && SunLightColor_IsValid && SunAngle_IsValid && SunInclination_IsValid && SunExtentDawnAndDusk_IsValid && SunVolumetricScattering_IsValid && SunColorCurveValue_IsValid && SunColorCurve_IsValid && MoonLightIntensity_IsValid && MoonLightColor_IsValid && MoonInclination_IsValid && MoonOrbitOffset_IsValid && MoonAngle_IsValid && MoonVolumetricScattering_IsValid && MoonColorCurveValue_IsValid && MoonColorCurve_IsValid && SkyLightIntensity_IsValid && SkyLightColor_IsValid && SkyLightVolumetricScattering_IsValid && SkyLightCubeMap_IsValid && SkyLightCubeArrayValue_IsValid && FogDensity_IsValid && FogDensityCurveValue_IsValid && FogHeightFalloff_IsValid && FogScatteringDistribution_IsValid && FogExtinctionScale_IsValid && FogStartDistance_IsValid && FogViewDistance_IsValid && FogAlbedoCurveValue_IsValid && FogEmissiveCurveValue_IsValid && FogScatteringColor_IsValid && FogAlbedo_IsValid && FogEmissive_IsValid && FogDensityCurve_IsValid && FogAlbedoCurve_IsValid && FogEmissiveCurve_IsValid && LocalFogWeatherTexMask_IsValid && LocalFogDensityMinMax_IsValid && LocalFogHeightFalloff_IsValid && LocalFogAlbedo_IsValid && LocalFogEmissive_IsValid && LocalFogWeatherTexTilingAndFlowDir_IsValid && LocalFogDensityTex_IsValid && LocalFogDensityTilingScale_IsValid && LocalFogStartDistance_IsValid && WindStrengthScale_IsValid && WindStrengthCurveValue_IsValid && WindStrengthCurve_IsValid && WeatherFX_IsValid && WeatherFXActor_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.BWC_DispLibEnvSettings", FBWC_DispLibEnvSettings_IsValid);
	}
}
