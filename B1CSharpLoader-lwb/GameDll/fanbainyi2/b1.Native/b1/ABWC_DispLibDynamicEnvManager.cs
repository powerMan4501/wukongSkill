using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager", "b1", UnrealModuleType.Game)]
public class ABWC_DispLibDynamicEnvManager : AActor
{
	private static bool MoonPositionCurve_IsValid;

	private static int MoonPositionCurve_Offset;

	private static bool EnvSystemConf_IsValid;

	private static int EnvSystemConf_Offset;

	private static bool Weather_IsValid;

	private static FFieldAddress Weather_PropertyAddress;

	private static int Weather_Offset;

	private static bool TimeOfDay_IsValid;

	private static int TimeOfDay_Offset;

	private static bool AutoTimeOfDay_IsValid;

	private static FFieldAddress AutoTimeOfDay_PropertyAddress;

	private static int AutoTimeOfDay_Offset;

	private static bool AutoRandormWeather_IsValid;

	private static FFieldAddress AutoRandormWeather_PropertyAddress;

	private static int AutoRandormWeather_Offset;

	private static bool EnableDayNightCircle_IsValid;

	private static FFieldAddress EnableDayNightCircle_PropertyAddress;

	private static int EnableDayNightCircle_Offset;

	private static bool WindDir_IsValid;

	private static int WindDir_Offset;

	private static bool FinalEnvSettings_IsValid;

	private static int FinalEnvSettings_Offset;

	private static bool SceneRoot_IsValid;

	private static int SceneRoot_Offset;

	private static bool SunLight_IsValid;

	private static int SunLight_Offset;

	private static bool MoonLight_IsValid;

	private static int MoonLight_Offset;

	private static bool SkyLight_IsValid;

	private static int SkyLight_Offset;

	private static bool HeightFog_IsValid;

	private static int HeightFog_Offset;

	private static bool SkyAtmosphere_IsValid;

	private static int SkyAtmosphere_Offset;

	private static bool SunRoot_IsValid;

	private static int SunRoot_Offset;

	private static bool MoonRoot_IsValid;

	private static int MoonRoot_Offset;

	private static bool WeathFXRoot_IsValid;

	private static int WeathFXRoot_Offset;

	private static bool WeatherFXActor_IsValid;

	private static int WeatherFXActor_Offset;

	private static bool UpdateSunAndMoonAngle_IsValid;

	private static IntPtr UpdateSunAndMoonAngle_FunctionAddress;

	private static int UpdateSunAndMoonAngle_ParamsSize;

	private static bool UpdateSunAndMoonAngle_Settings_IsValid;

	private static FFieldAddress UpdateSunAndMoonAngle_Settings_PropertyAddress;

	private static int UpdateSunAndMoonAngle_Settings_Offset;

	private static bool UpdateEnvSystemConfig_IsValid;

	private static IntPtr UpdateEnvSystemConfig_FunctionAddress;

	private static int UpdateEnvSystemConfig_ParamsSize;

	private static bool UpdateEnvSystemConfig_SystemConf_IsValid;

	private static FFieldAddress UpdateEnvSystemConfig_SystemConf_PropertyAddress;

	private static int UpdateEnvSystemConfig_SystemConf_Offset;

	private static bool SwithToNarrative_IsValid;

	private static IntPtr SwithToNarrative_FunctionAddress;

	private static int SwithToNarrative_ParamsSize;

	private static bool SwithToNarrative_Enable_IsValid;

	private static FFieldAddress SwithToNarrative_Enable_PropertyAddress;

	private static int SwithToNarrative_Enable_Offset;

	private static bool SwithToNarrative_ChangeDuration_IsValid;

	private static FFieldAddress SwithToNarrative_ChangeDuration_PropertyAddress;

	private static int SwithToNarrative_ChangeDuration_Offset;

	private static bool SetWeather_IsValid;

	private static IntPtr SetWeather_FunctionAddress;

	private static int SetWeather_ParamsSize;

	private static bool SetWeather_InWeather_IsValid;

	private static FFieldAddress SetWeather_InWeather_PropertyAddress;

	private static int SetWeather_InWeather_Offset;

	private static bool SetEnvSettings_IsValid;

	private static IntPtr SetEnvSettings_FunctionAddress;

	private static int SetEnvSettings_ParamsSize;

	private static bool SetEnvSettings_IsNight_IsValid;

	private static FFieldAddress SetEnvSettings_IsNight_PropertyAddress;

	private static int SetEnvSettings_IsNight_Offset;

	private static bool SetEnvSettings_CameraLocation_IsValid;

	private static FFieldAddress SetEnvSettings_CameraLocation_PropertyAddress;

	private static int SetEnvSettings_CameraLocation_Offset;

	private static bool RandomWeather_IsValid;

	private static IntPtr RandomWeather_FunctionAddress;

	private static int RandomWeather_ParamsSize;

	private static bool RandomWeather_ViewLocation_IsValid;

	private static FFieldAddress RandomWeather_ViewLocation_PropertyAddress;

	private static int RandomWeather_ViewLocation_Offset;

	private static bool RandomWeather_ReturnValue_IsValid;

	private static FFieldAddress RandomWeather_ReturnValue_PropertyAddress;

	private static int RandomWeather_ReturnValue_Offset;

	private static bool OverrideEnvSettings_IsValid;

	private static IntPtr OverrideEnvSettings_FunctionAddress;

	private static int OverrideEnvSettings_ParamsSize;

	private static bool OverrideEnvSettings_Src_IsValid;

	private static FFieldAddress OverrideEnvSettings_Src_PropertyAddress;

	private static int OverrideEnvSettings_Src_Offset;

	private static bool OverrideEnvSettings_Dest_IsValid;

	private static FFieldAddress OverrideEnvSettings_Dest_PropertyAddress;

	private static int OverrideEnvSettings_Dest_Offset;

	private static bool OverrideEnvSettings_Weight_IsValid;

	private static FFieldAddress OverrideEnvSettings_Weight_PropertyAddress;

	private static int OverrideEnvSettings_Weight_Offset;

	private static bool OnWeatherChanged_IsValid;

	private IntPtr OnWeatherChanged_InstanceFunctionAddress;

	private static IntPtr OnWeatherChanged_FunctionAddress;

	private static int OnWeatherChanged_ParamsSize;

	private static bool OnWeatherChanged_CameraLocation_IsValid;

	private static FFieldAddress OnWeatherChanged_CameraLocation_PropertyAddress;

	private static int OnWeatherChanged_CameraLocation_Offset;

	private static bool OnTickEnvVolume_IsValid;

	private static IntPtr OnTickEnvVolume_FunctionAddress;

	private static int OnTickEnvVolume_ParamsSize;

	private static bool OnTickEnvVolume_EnvSettings_IsValid;

	private static FFieldAddress OnTickEnvVolume_EnvSettings_PropertyAddress;

	private static int OnTickEnvVolume_EnvSettings_Offset;

	private static bool OnTickEnvVolume_ViewLocation_IsValid;

	private static FFieldAddress OnTickEnvVolume_ViewLocation_PropertyAddress;

	private static int OnTickEnvVolume_ViewLocation_Offset;

	private static bool OnTickEnvVolume_InTime_IsValid;

	private static FFieldAddress OnTickEnvVolume_InTime_PropertyAddress;

	private static int OnTickEnvVolume_InTime_Offset;

	private static bool OnLerpEnvSettings_IsValid;

	private IntPtr OnLerpEnvSettings_InstanceFunctionAddress;

	private static IntPtr OnLerpEnvSettings_FunctionAddress;

	private static int OnLerpEnvSettings_ParamsSize;

	private static bool OnLerpEnvSettings_Weight_IsValid;

	private static FFieldAddress OnLerpEnvSettings_Weight_PropertyAddress;

	private static int OnLerpEnvSettings_Weight_Offset;

	private static bool OnLerpEnvSettings_InTime_IsValid;

	private static FFieldAddress OnLerpEnvSettings_InTime_PropertyAddress;

	private static int OnLerpEnvSettings_InTime_Offset;

	private static bool OnLerpEnvSettings_Src_IsValid;

	private static FFieldAddress OnLerpEnvSettings_Src_PropertyAddress;

	private static int OnLerpEnvSettings_Src_Offset;

	private static bool OnApplyEnvSettings_IsValid;

	private IntPtr OnApplyEnvSettings_InstanceFunctionAddress;

	private static IntPtr OnApplyEnvSettings_FunctionAddress;

	private static int OnApplyEnvSettings_ParamsSize;

	private static bool OnApplyEnvSettings_IsNight_IsValid;

	private static FFieldAddress OnApplyEnvSettings_IsNight_PropertyAddress;

	private static int OnApplyEnvSettings_IsNight_Offset;

	private static bool IsWeatherAvailable_IsValid;

	private static IntPtr IsWeatherAvailable_FunctionAddress;

	private static int IsWeatherAvailable_ParamsSize;

	private static bool IsWeatherAvailable_InWeather_IsValid;

	private static FFieldAddress IsWeatherAvailable_InWeather_PropertyAddress;

	private static int IsWeatherAvailable_InWeather_Offset;

	private static bool IsWeatherAvailable_ViewLocation_IsValid;

	private static FFieldAddress IsWeatherAvailable_ViewLocation_PropertyAddress;

	private static int IsWeatherAvailable_ViewLocation_Offset;

	private static bool IsWeatherAvailable_ReturnValue_IsValid;

	private static FFieldAddress IsWeatherAvailable_ReturnValue_PropertyAddress;

	private static int IsWeatherAvailable_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:MoonPositionCurve")]
	public UCurveFloat MoonPositionCurve
	{
		get
		{
			CheckDestroyed();
			if (!MoonPositionCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:MoonPositionCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, MoonPositionCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoonPositionCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:MoonPositionCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, MoonPositionCurve_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:EnvSystemConf")]
	public UBWS_DispLibEnvSystemConf EnvSystemConf
	{
		get
		{
			CheckDestroyed();
			if (!EnvSystemConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:EnvSystemConf");
				return null;
			}
			return UObjectMarshaler<UBWS_DispLibEnvSystemConf>.FromNative(IntPtr.Add(base.Address, EnvSystemConf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvSystemConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:EnvSystemConf");
			}
			else
			{
				UObjectMarshaler<UBWS_DispLibEnvSystemConf>.ToNative(IntPtr.Add(base.Address, EnvSystemConf_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:Weather")]
	public EBGW_DispLibEnvWeather Weather
	{
		get
		{
			CheckDestroyed();
			if (!Weather_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:Weather");
				return EBGW_DispLibEnvWeather.Sunny;
			}
			return EnumMarshaler<EBGW_DispLibEnvWeather>.FromNative(IntPtr.Add(base.Address, Weather_Offset), 0, Weather_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Weather_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:Weather");
			}
			else
			{
				EnumMarshaler<EBGW_DispLibEnvWeather>.ToNative(IntPtr.Add(base.Address, Weather_Offset), 0, Weather_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:TimeOfDay")]
	public float TimeOfDay
	{
		get
		{
			CheckDestroyed();
			if (!TimeOfDay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:TimeOfDay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeOfDay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeOfDay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:TimeOfDay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeOfDay_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:AutoTimeOfDay")]
	public bool AutoTimeOfDay
	{
		get
		{
			CheckDestroyed();
			if (!AutoTimeOfDay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:AutoTimeOfDay");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoTimeOfDay_Offset), 0, AutoTimeOfDay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoTimeOfDay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:AutoTimeOfDay");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoTimeOfDay_Offset), 0, AutoTimeOfDay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:AutoRandormWeather")]
	public bool AutoRandormWeather
	{
		get
		{
			CheckDestroyed();
			if (!AutoRandormWeather_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:AutoRandormWeather");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoRandormWeather_Offset), 0, AutoRandormWeather_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoRandormWeather_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:AutoRandormWeather");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoRandormWeather_Offset), 0, AutoRandormWeather_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:bEnableDayNightCircle")]
	public bool EnableDayNightCircle
	{
		get
		{
			CheckDestroyed();
			if (!EnableDayNightCircle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:bEnableDayNightCircle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDayNightCircle_Offset), 0, EnableDayNightCircle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDayNightCircle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:bEnableDayNightCircle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDayNightCircle_Offset), 0, EnableDayNightCircle_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:WindDir")]
	public FVector2D WindDir
	{
		get
		{
			CheckDestroyed();
			if (!WindDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:WindDir");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, WindDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:WindDir");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, WindDir_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:FinalEnvSettings")]
	public FBWC_DispLibEnvSettings FinalEnvSettings
	{
		get
		{
			CheckDestroyed();
			if (!FinalEnvSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:FinalEnvSettings");
				return default(FBWC_DispLibEnvSettings);
			}
			return FBWC_DispLibEnvSettings.FromNative(IntPtr.Add(base.Address, FinalEnvSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinalEnvSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:FinalEnvSettings");
			}
			else
			{
				FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(base.Address, FinalEnvSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SceneRoot")]
	public USceneComponent SceneRoot
	{
		get
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SceneRoot");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, SceneRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SceneRoot");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, SceneRoot_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SunLight")]
	public UDirectionalLightComponent SunLight
	{
		get
		{
			CheckDestroyed();
			if (!SunLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SunLight");
				return null;
			}
			return UObjectMarshaler<UDirectionalLightComponent>.FromNative(IntPtr.Add(base.Address, SunLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SunLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SunLight");
			}
			else
			{
				UObjectMarshaler<UDirectionalLightComponent>.ToNative(IntPtr.Add(base.Address, SunLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:MoonLight")]
	public UDirectionalLightComponent MoonLight
	{
		get
		{
			CheckDestroyed();
			if (!MoonLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:MoonLight");
				return null;
			}
			return UObjectMarshaler<UDirectionalLightComponent>.FromNative(IntPtr.Add(base.Address, MoonLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoonLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:MoonLight");
			}
			else
			{
				UObjectMarshaler<UDirectionalLightComponent>.ToNative(IntPtr.Add(base.Address, MoonLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SkyLight")]
	public USkyLightComponent SkyLight
	{
		get
		{
			CheckDestroyed();
			if (!SkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SkyLight");
				return null;
			}
			return UObjectMarshaler<USkyLightComponent>.FromNative(IntPtr.Add(base.Address, SkyLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SkyLight");
			}
			else
			{
				UObjectMarshaler<USkyLightComponent>.ToNative(IntPtr.Add(base.Address, SkyLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:HeightFog")]
	public UExponentialHeightFogComponent HeightFog
	{
		get
		{
			CheckDestroyed();
			if (!HeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:HeightFog");
				return null;
			}
			return UObjectMarshaler<UExponentialHeightFogComponent>.FromNative(IntPtr.Add(base.Address, HeightFog_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightFog_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:HeightFog");
			}
			else
			{
				UObjectMarshaler<UExponentialHeightFogComponent>.ToNative(IntPtr.Add(base.Address, HeightFog_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SkyAtmosphere")]
	public USkyAtmosphereComponent SkyAtmosphere
	{
		get
		{
			CheckDestroyed();
			if (!SkyAtmosphere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SkyAtmosphere");
				return null;
			}
			return UObjectMarshaler<USkyAtmosphereComponent>.FromNative(IntPtr.Add(base.Address, SkyAtmosphere_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyAtmosphere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SkyAtmosphere");
			}
			else
			{
				UObjectMarshaler<USkyAtmosphereComponent>.ToNative(IntPtr.Add(base.Address, SkyAtmosphere_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SunRoot")]
	public UArrowComponent SunRoot
	{
		get
		{
			CheckDestroyed();
			if (!SunRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SunRoot");
				return null;
			}
			return UObjectMarshaler<UArrowComponent>.FromNative(IntPtr.Add(base.Address, SunRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SunRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SunRoot");
			}
			else
			{
				UObjectMarshaler<UArrowComponent>.ToNative(IntPtr.Add(base.Address, SunRoot_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:MoonRoot")]
	public UArrowComponent MoonRoot
	{
		get
		{
			CheckDestroyed();
			if (!MoonRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:MoonRoot");
				return null;
			}
			return UObjectMarshaler<UArrowComponent>.FromNative(IntPtr.Add(base.Address, MoonRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoonRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:MoonRoot");
			}
			else
			{
				UObjectMarshaler<UArrowComponent>.ToNative(IntPtr.Add(base.Address, MoonRoot_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:WeathFXRoot")]
	public USceneComponent WeathFXRoot
	{
		get
		{
			CheckDestroyed();
			if (!WeathFXRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:WeathFXRoot");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, WeathFXRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeathFXRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:WeathFXRoot");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, WeathFXRoot_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:WeatherFXActor")]
	public AActor WeatherFXActor
	{
		get
		{
			CheckDestroyed();
			if (!WeatherFXActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:WeatherFXActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, WeatherFXActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeatherFXActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:WeatherFXActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, WeatherFXActor_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:UpdateSunAndMoonAngle")]
	public unsafe void UpdateSunAndMoonAngle(FBWC_DispLibEnvSettings Settings)
	{
		CheckDestroyed();
		if (!UpdateSunAndMoonAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:UpdateSunAndMoonAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateSunAndMoonAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateSunAndMoonAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(UpdateSunAndMoonAngle_Settings_PropertyAddress.Address, intPtr);
		FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(intPtr, UpdateSunAndMoonAngle_Settings_Offset), 0, UpdateSunAndMoonAngle_Settings_PropertyAddress.Address, Settings);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateSunAndMoonAngle_FunctionAddress, intPtr, UpdateSunAndMoonAngle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:UpdateEnvSystemConfig")]
	public unsafe void UpdateEnvSystemConfig(UBWS_DispLibEnvSystemConf SystemConf)
	{
		CheckDestroyed();
		if (!UpdateEnvSystemConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:UpdateEnvSystemConfig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateEnvSystemConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateEnvSystemConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBWS_DispLibEnvSystemConf>.ToNative(IntPtr.Add(intPtr, UpdateEnvSystemConfig_SystemConf_Offset), 0, UpdateEnvSystemConfig_SystemConf_PropertyAddress.Address, SystemConf);
		NativeReflection.InvokeFunctionOptimized(base.Address, UpdateEnvSystemConfig_FunctionAddress, intPtr, UpdateEnvSystemConfig_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SwithToNarrative")]
	public unsafe void SwithToNarrative(bool Enable, float ChangeDuration)
	{
		CheckDestroyed();
		if (!SwithToNarrative_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SwithToNarrative");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SwithToNarrative_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SwithToNarrative_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SwithToNarrative_Enable_Offset), 0, SwithToNarrative_Enable_PropertyAddress.Address, Enable);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SwithToNarrative_ChangeDuration_Offset), 0, SwithToNarrative_ChangeDuration_PropertyAddress.Address, ChangeDuration);
		NativeReflection.InvokeFunctionOptimized(base.Address, SwithToNarrative_FunctionAddress, intPtr, SwithToNarrative_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SetWeather")]
	public unsafe void SetWeather(EBGW_DispLibEnvWeather InWeather)
	{
		CheckDestroyed();
		if (!SetWeather_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SetWeather");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWeather_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWeather_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGW_DispLibEnvWeather>.ToNative(IntPtr.Add(intPtr, SetWeather_InWeather_Offset), 0, SetWeather_InWeather_PropertyAddress.Address, InWeather);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWeather_FunctionAddress, intPtr, SetWeather_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:SetEnvSettings")]
	public unsafe void SetEnvSettings(bool IsNight, FVector CameraLocation)
	{
		CheckDestroyed();
		if (!SetEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:SetEnvSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnvSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnvSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnvSettings_IsNight_Offset), 0, SetEnvSettings_IsNight_PropertyAddress.Address, IsNight);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetEnvSettings_CameraLocation_Offset), 0, SetEnvSettings_CameraLocation_PropertyAddress.Address, CameraLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnvSettings_FunctionAddress, intPtr, SetEnvSettings_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:RandomWeather")]
	public unsafe EBGW_DispLibEnvWeather RandomWeather(FVector ViewLocation)
	{
		CheckDestroyed();
		if (!RandomWeather_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:RandomWeather");
			return EBGW_DispLibEnvWeather.Sunny;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RandomWeather_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RandomWeather_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RandomWeather_ViewLocation_Offset), 0, RandomWeather_ViewLocation_PropertyAddress.Address, ViewLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, RandomWeather_FunctionAddress, intPtr, RandomWeather_ParamsSize);
		return EnumMarshaler<EBGW_DispLibEnvWeather>.FromNative(IntPtr.Add(intPtr, RandomWeather_ReturnValue_Offset), 0, RandomWeather_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:OverrideEnvSettings")]
	public unsafe void OverrideEnvSettings(FBWC_DispLibEnvSettings Src, out FBWC_DispLibEnvSettings Dest, float Weight)
	{
		CheckDestroyed();
		if (!OverrideEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OverrideEnvSettings");
			Dest = default(FBWC_DispLibEnvSettings);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverrideEnvSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverrideEnvSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OverrideEnvSettings_Src_PropertyAddress.Address, intPtr);
		FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(intPtr, OverrideEnvSettings_Src_Offset), 0, OverrideEnvSettings_Src_PropertyAddress.Address, Src);
		NativeReflection.InitializeValue_InContainer(OverrideEnvSettings_Dest_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OverrideEnvSettings_Weight_Offset), 0, OverrideEnvSettings_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeFunctionOptimized(base.Address, OverrideEnvSettings_FunctionAddress, intPtr, OverrideEnvSettings_ParamsSize);
		Dest = FBWC_DispLibEnvSettings.FromNative(IntPtr.Add(intPtr, OverrideEnvSettings_Dest_Offset), 0, OverrideEnvSettings_Dest_PropertyAddress.Address);
	}

	[UFunction(Flags = 146934784u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:OnWeatherChanged")]
	public unsafe void OnWeatherChanged(FVector CameraLocation)
	{
		CheckDestroyed();
		if (!OnWeatherChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OnWeatherChanged");
			return;
		}
		if (OnWeatherChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnWeatherChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnWeatherChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWeatherChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWeatherChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWeatherChanged_CameraLocation_Offset), 0, OnWeatherChanged_CameraLocation_PropertyAddress.Address, CameraLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWeatherChanged_InstanceFunctionAddress, intPtr, OnWeatherChanged_ParamsSize);
	}

	protected unsafe virtual void OnWeatherChanged_Implementation(FVector CameraLocation)
	{
		CheckDestroyed();
		if (!OnWeatherChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OnWeatherChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnWeatherChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnWeatherChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnWeatherChanged_CameraLocation_Offset), 0, OnWeatherChanged_CameraLocation_PropertyAddress.Address, CameraLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnWeatherChanged_FunctionAddress, intPtr, OnWeatherChanged_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:OnTickEnvVolume")]
	public unsafe void OnTickEnvVolume(out FBWC_DispLibEnvSettings EnvSettings, FVector ViewLocation, float InTime)
	{
		CheckDestroyed();
		if (!OnTickEnvVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OnTickEnvVolume");
			EnvSettings = default(FBWC_DispLibEnvSettings);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTickEnvVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTickEnvVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OnTickEnvVolume_EnvSettings_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnTickEnvVolume_ViewLocation_Offset), 0, OnTickEnvVolume_ViewLocation_PropertyAddress.Address, ViewLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnTickEnvVolume_InTime_Offset), 0, OnTickEnvVolume_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTickEnvVolume_FunctionAddress, intPtr, OnTickEnvVolume_ParamsSize);
		EnvSettings = FBWC_DispLibEnvSettings.FromNative(IntPtr.Add(intPtr, OnTickEnvVolume_EnvSettings_Offset), 0, OnTickEnvVolume_EnvSettings_PropertyAddress.Address);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:OnLerpEnvSettings")]
	public unsafe void OnLerpEnvSettings(float Weight, float InTime, FBWC_DispLibEnvSettings Src)
	{
		CheckDestroyed();
		if (!OnLerpEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OnLerpEnvSettings");
			return;
		}
		if (OnLerpEnvSettings_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnLerpEnvSettings_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnLerpEnvSettings");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLerpEnvSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLerpEnvSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnLerpEnvSettings_Weight_Offset), 0, OnLerpEnvSettings_Weight_PropertyAddress.Address, Weight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnLerpEnvSettings_InTime_Offset), 0, OnLerpEnvSettings_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InitializeValue_InContainer(OnLerpEnvSettings_Src_PropertyAddress.Address, intPtr);
		FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(intPtr, OnLerpEnvSettings_Src_Offset), 0, OnLerpEnvSettings_Src_PropertyAddress.Address, Src);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLerpEnvSettings_InstanceFunctionAddress, intPtr, OnLerpEnvSettings_ParamsSize);
	}

	protected unsafe virtual void OnLerpEnvSettings_Implementation(float Weight, float InTime, FBWC_DispLibEnvSettings Src)
	{
		CheckDestroyed();
		if (!OnLerpEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OnLerpEnvSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnLerpEnvSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnLerpEnvSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnLerpEnvSettings_Weight_Offset), 0, OnLerpEnvSettings_Weight_PropertyAddress.Address, Weight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnLerpEnvSettings_InTime_Offset), 0, OnLerpEnvSettings_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InitializeValue_InContainer(OnLerpEnvSettings_Src_PropertyAddress.Address, intPtr);
		FBWC_DispLibEnvSettings.ToNative(IntPtr.Add(intPtr, OnLerpEnvSettings_Src_Offset), 0, OnLerpEnvSettings_Src_PropertyAddress.Address, Src);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnLerpEnvSettings_FunctionAddress, intPtr, OnLerpEnvSettings_ParamsSize);
	}

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:OnApplyEnvSettings")]
	public unsafe void OnApplyEnvSettings(bool IsNight)
	{
		CheckDestroyed();
		if (!OnApplyEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OnApplyEnvSettings");
			return;
		}
		if (OnApplyEnvSettings_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnApplyEnvSettings_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnApplyEnvSettings");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplyEnvSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplyEnvSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnApplyEnvSettings_IsNight_Offset), 0, OnApplyEnvSettings_IsNight_PropertyAddress.Address, IsNight);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnApplyEnvSettings_InstanceFunctionAddress, intPtr, OnApplyEnvSettings_ParamsSize);
	}

	protected unsafe virtual void OnApplyEnvSettings_Implementation(bool IsNight)
	{
		CheckDestroyed();
		if (!OnApplyEnvSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:OnApplyEnvSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnApplyEnvSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnApplyEnvSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnApplyEnvSettings_IsNight_Offset), 0, OnApplyEnvSettings_IsNight_PropertyAddress.Address, IsNight);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnApplyEnvSettings_FunctionAddress, intPtr, OnApplyEnvSettings_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BWC_DispLibDynamicEnvManager:IsWeatherAvailable")]
	public unsafe bool IsWeatherAvailable(EBGW_DispLibEnvWeather InWeather, FVector ViewLocation)
	{
		CheckDestroyed();
		if (!IsWeatherAvailable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BWC_DispLibDynamicEnvManager:IsWeatherAvailable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsWeatherAvailable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsWeatherAvailable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EBGW_DispLibEnvWeather>.ToNative(IntPtr.Add(intPtr, IsWeatherAvailable_InWeather_Offset), 0, IsWeatherAvailable_InWeather_PropertyAddress.Address, InWeather);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsWeatherAvailable_ViewLocation_Offset), 0, IsWeatherAvailable_ViewLocation_PropertyAddress.Address, ViewLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsWeatherAvailable_FunctionAddress, intPtr, IsWeatherAvailable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsWeatherAvailable_ReturnValue_Offset), 0, IsWeatherAvailable_ReturnValue_PropertyAddress.Address);
	}

	static ABWC_DispLibDynamicEnvManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABWC_DispLibDynamicEnvManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABWC_DispLibDynamicEnvManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BWC_DispLibDynamicEnvManager");
		MoonPositionCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonPositionCurve");
		MoonPositionCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonPositionCurve", Classes.FObjectProperty);
		EnvSystemConf_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EnvSystemConf");
		EnvSystemConf_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EnvSystemConf", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Weather_PropertyAddress, intPtr, "Weather");
		Weather_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Weather");
		Weather_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Weather", Classes.FEnumProperty);
		TimeOfDay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeOfDay");
		TimeOfDay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeOfDay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoTimeOfDay_PropertyAddress, intPtr, "AutoTimeOfDay");
		AutoTimeOfDay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoTimeOfDay");
		AutoTimeOfDay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoTimeOfDay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoRandormWeather_PropertyAddress, intPtr, "AutoRandormWeather");
		AutoRandormWeather_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoRandormWeather");
		AutoRandormWeather_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoRandormWeather", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableDayNightCircle_PropertyAddress, intPtr, "bEnableDayNightCircle");
		EnableDayNightCircle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableDayNightCircle");
		EnableDayNightCircle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableDayNightCircle", Classes.FBoolProperty);
		WindDir_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindDir");
		WindDir_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindDir", Classes.FStructProperty);
		FinalEnvSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinalEnvSettings");
		FinalEnvSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinalEnvSettings", Classes.FStructProperty);
		SceneRoot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneRoot");
		SceneRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneRoot", Classes.FObjectProperty);
		SunLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunLight");
		SunLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunLight", Classes.FObjectProperty);
		MoonLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonLight");
		MoonLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonLight", Classes.FObjectProperty);
		SkyLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyLight");
		SkyLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyLight", Classes.FObjectProperty);
		HeightFog_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeightFog");
		HeightFog_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeightFog", Classes.FObjectProperty);
		SkyAtmosphere_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SkyAtmosphere");
		SkyAtmosphere_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SkyAtmosphere", Classes.FObjectProperty);
		SunRoot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SunRoot");
		SunRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SunRoot", Classes.FObjectProperty);
		MoonRoot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MoonRoot");
		MoonRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MoonRoot", Classes.FObjectProperty);
		WeathFXRoot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeathFXRoot");
		WeathFXRoot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeathFXRoot", Classes.FObjectProperty);
		WeatherFXActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WeatherFXActor");
		WeatherFXActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WeatherFXActor", Classes.FObjectProperty);
		UpdateSunAndMoonAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateSunAndMoonAngle");
		UpdateSunAndMoonAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSunAndMoonAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateSunAndMoonAngle_Settings_PropertyAddress, UpdateSunAndMoonAngle_FunctionAddress, "Settings");
		UpdateSunAndMoonAngle_Settings_Offset = NativeReflectionCached.GetPropertyOffset(UpdateSunAndMoonAngle_FunctionAddress, "Settings");
		UpdateSunAndMoonAngle_Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateSunAndMoonAngle_FunctionAddress, "Settings", Classes.FStructProperty);
		UpdateSunAndMoonAngle_IsValid = UpdateSunAndMoonAngle_FunctionAddress != IntPtr.Zero && UpdateSunAndMoonAngle_Settings_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:UpdateSunAndMoonAngle", UpdateSunAndMoonAngle_IsValid);
		UpdateEnvSystemConfig_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateEnvSystemConfig");
		UpdateEnvSystemConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateEnvSystemConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateEnvSystemConfig_SystemConf_PropertyAddress, UpdateEnvSystemConfig_FunctionAddress, "SystemConf");
		UpdateEnvSystemConfig_SystemConf_Offset = NativeReflectionCached.GetPropertyOffset(UpdateEnvSystemConfig_FunctionAddress, "SystemConf");
		UpdateEnvSystemConfig_SystemConf_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateEnvSystemConfig_FunctionAddress, "SystemConf", Classes.FObjectProperty);
		UpdateEnvSystemConfig_IsValid = UpdateEnvSystemConfig_FunctionAddress != IntPtr.Zero && UpdateEnvSystemConfig_SystemConf_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:UpdateEnvSystemConfig", UpdateEnvSystemConfig_IsValid);
		SwithToNarrative_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SwithToNarrative");
		SwithToNarrative_ParamsSize = NativeReflection.GetFunctionParamsSize(SwithToNarrative_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SwithToNarrative_Enable_PropertyAddress, SwithToNarrative_FunctionAddress, "Enable");
		SwithToNarrative_Enable_Offset = NativeReflectionCached.GetPropertyOffset(SwithToNarrative_FunctionAddress, "Enable");
		SwithToNarrative_Enable_IsValid = NativeReflectionCached.ValidatePropertyClass(SwithToNarrative_FunctionAddress, "Enable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SwithToNarrative_ChangeDuration_PropertyAddress, SwithToNarrative_FunctionAddress, "ChangeDuration");
		SwithToNarrative_ChangeDuration_Offset = NativeReflectionCached.GetPropertyOffset(SwithToNarrative_FunctionAddress, "ChangeDuration");
		SwithToNarrative_ChangeDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(SwithToNarrative_FunctionAddress, "ChangeDuration", Classes.FFloatProperty);
		SwithToNarrative_IsValid = SwithToNarrative_FunctionAddress != IntPtr.Zero && SwithToNarrative_Enable_IsValid && SwithToNarrative_ChangeDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:SwithToNarrative", SwithToNarrative_IsValid);
		SetWeather_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWeather");
		SetWeather_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWeather_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWeather_InWeather_PropertyAddress, SetWeather_FunctionAddress, "InWeather");
		SetWeather_InWeather_Offset = NativeReflectionCached.GetPropertyOffset(SetWeather_FunctionAddress, "InWeather");
		SetWeather_InWeather_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWeather_FunctionAddress, "InWeather", Classes.FEnumProperty);
		SetWeather_IsValid = SetWeather_FunctionAddress != IntPtr.Zero && SetWeather_InWeather_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:SetWeather", SetWeather_IsValid);
		SetEnvSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnvSettings");
		SetEnvSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnvSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnvSettings_IsNight_PropertyAddress, SetEnvSettings_FunctionAddress, "IsNight");
		SetEnvSettings_IsNight_Offset = NativeReflectionCached.GetPropertyOffset(SetEnvSettings_FunctionAddress, "IsNight");
		SetEnvSettings_IsNight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnvSettings_FunctionAddress, "IsNight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEnvSettings_CameraLocation_PropertyAddress, SetEnvSettings_FunctionAddress, "CameraLocation");
		SetEnvSettings_CameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetEnvSettings_FunctionAddress, "CameraLocation");
		SetEnvSettings_CameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnvSettings_FunctionAddress, "CameraLocation", Classes.FStructProperty);
		SetEnvSettings_IsValid = SetEnvSettings_FunctionAddress != IntPtr.Zero && SetEnvSettings_IsNight_IsValid && SetEnvSettings_CameraLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:SetEnvSettings", SetEnvSettings_IsValid);
		RandomWeather_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RandomWeather");
		RandomWeather_ParamsSize = NativeReflection.GetFunctionParamsSize(RandomWeather_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RandomWeather_ViewLocation_PropertyAddress, RandomWeather_FunctionAddress, "ViewLocation");
		RandomWeather_ViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(RandomWeather_FunctionAddress, "ViewLocation");
		RandomWeather_ViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomWeather_FunctionAddress, "ViewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RandomWeather_ReturnValue_PropertyAddress, RandomWeather_FunctionAddress, "ReturnValue");
		RandomWeather_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RandomWeather_FunctionAddress, "ReturnValue");
		RandomWeather_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RandomWeather_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		RandomWeather_IsValid = RandomWeather_FunctionAddress != IntPtr.Zero && RandomWeather_ViewLocation_IsValid && RandomWeather_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:RandomWeather", RandomWeather_IsValid);
		OverrideEnvSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OverrideEnvSettings");
		OverrideEnvSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideEnvSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverrideEnvSettings_Src_PropertyAddress, OverrideEnvSettings_FunctionAddress, "Src");
		OverrideEnvSettings_Src_Offset = NativeReflectionCached.GetPropertyOffset(OverrideEnvSettings_FunctionAddress, "Src");
		OverrideEnvSettings_Src_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideEnvSettings_FunctionAddress, "Src", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideEnvSettings_Dest_PropertyAddress, OverrideEnvSettings_FunctionAddress, "Dest");
		OverrideEnvSettings_Dest_Offset = NativeReflectionCached.GetPropertyOffset(OverrideEnvSettings_FunctionAddress, "Dest");
		OverrideEnvSettings_Dest_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideEnvSettings_FunctionAddress, "Dest", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OverrideEnvSettings_Weight_PropertyAddress, OverrideEnvSettings_FunctionAddress, "Weight");
		OverrideEnvSettings_Weight_Offset = NativeReflectionCached.GetPropertyOffset(OverrideEnvSettings_FunctionAddress, "Weight");
		OverrideEnvSettings_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(OverrideEnvSettings_FunctionAddress, "Weight", Classes.FFloatProperty);
		OverrideEnvSettings_IsValid = OverrideEnvSettings_FunctionAddress != IntPtr.Zero && OverrideEnvSettings_Src_IsValid && OverrideEnvSettings_Dest_IsValid && OverrideEnvSettings_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:OverrideEnvSettings", OverrideEnvSettings_IsValid);
		OnWeatherChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnWeatherChanged");
		OnWeatherChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnWeatherChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnWeatherChanged_CameraLocation_PropertyAddress, OnWeatherChanged_FunctionAddress, "CameraLocation");
		OnWeatherChanged_CameraLocation_Offset = NativeReflectionCached.GetPropertyOffset(OnWeatherChanged_FunctionAddress, "CameraLocation");
		OnWeatherChanged_CameraLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnWeatherChanged_FunctionAddress, "CameraLocation", Classes.FStructProperty);
		OnWeatherChanged_IsValid = OnWeatherChanged_FunctionAddress != IntPtr.Zero && OnWeatherChanged_CameraLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:OnWeatherChanged", OnWeatherChanged_IsValid);
		OnTickEnvVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTickEnvVolume");
		OnTickEnvVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTickEnvVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTickEnvVolume_EnvSettings_PropertyAddress, OnTickEnvVolume_FunctionAddress, "EnvSettings");
		OnTickEnvVolume_EnvSettings_Offset = NativeReflectionCached.GetPropertyOffset(OnTickEnvVolume_FunctionAddress, "EnvSettings");
		OnTickEnvVolume_EnvSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTickEnvVolume_FunctionAddress, "EnvSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTickEnvVolume_ViewLocation_PropertyAddress, OnTickEnvVolume_FunctionAddress, "ViewLocation");
		OnTickEnvVolume_ViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(OnTickEnvVolume_FunctionAddress, "ViewLocation");
		OnTickEnvVolume_ViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTickEnvVolume_FunctionAddress, "ViewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OnTickEnvVolume_InTime_PropertyAddress, OnTickEnvVolume_FunctionAddress, "InTime");
		OnTickEnvVolume_InTime_Offset = NativeReflectionCached.GetPropertyOffset(OnTickEnvVolume_FunctionAddress, "InTime");
		OnTickEnvVolume_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTickEnvVolume_FunctionAddress, "InTime", Classes.FFloatProperty);
		OnTickEnvVolume_IsValid = OnTickEnvVolume_FunctionAddress != IntPtr.Zero && OnTickEnvVolume_EnvSettings_IsValid && OnTickEnvVolume_ViewLocation_IsValid && OnTickEnvVolume_InTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:OnTickEnvVolume", OnTickEnvVolume_IsValid);
		OnLerpEnvSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnLerpEnvSettings");
		OnLerpEnvSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(OnLerpEnvSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnLerpEnvSettings_Weight_PropertyAddress, OnLerpEnvSettings_FunctionAddress, "Weight");
		OnLerpEnvSettings_Weight_Offset = NativeReflectionCached.GetPropertyOffset(OnLerpEnvSettings_FunctionAddress, "Weight");
		OnLerpEnvSettings_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLerpEnvSettings_FunctionAddress, "Weight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnLerpEnvSettings_InTime_PropertyAddress, OnLerpEnvSettings_FunctionAddress, "InTime");
		OnLerpEnvSettings_InTime_Offset = NativeReflectionCached.GetPropertyOffset(OnLerpEnvSettings_FunctionAddress, "InTime");
		OnLerpEnvSettings_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLerpEnvSettings_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnLerpEnvSettings_Src_PropertyAddress, OnLerpEnvSettings_FunctionAddress, "Src");
		OnLerpEnvSettings_Src_Offset = NativeReflectionCached.GetPropertyOffset(OnLerpEnvSettings_FunctionAddress, "Src");
		OnLerpEnvSettings_Src_IsValid = NativeReflectionCached.ValidatePropertyClass(OnLerpEnvSettings_FunctionAddress, "Src", Classes.FStructProperty);
		OnLerpEnvSettings_IsValid = OnLerpEnvSettings_FunctionAddress != IntPtr.Zero && OnLerpEnvSettings_Weight_IsValid && OnLerpEnvSettings_InTime_IsValid && OnLerpEnvSettings_Src_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:OnLerpEnvSettings", OnLerpEnvSettings_IsValid);
		OnApplyEnvSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnApplyEnvSettings");
		OnApplyEnvSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(OnApplyEnvSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnApplyEnvSettings_IsNight_PropertyAddress, OnApplyEnvSettings_FunctionAddress, "IsNight");
		OnApplyEnvSettings_IsNight_Offset = NativeReflectionCached.GetPropertyOffset(OnApplyEnvSettings_FunctionAddress, "IsNight");
		OnApplyEnvSettings_IsNight_IsValid = NativeReflectionCached.ValidatePropertyClass(OnApplyEnvSettings_FunctionAddress, "IsNight", Classes.FBoolProperty);
		OnApplyEnvSettings_IsValid = OnApplyEnvSettings_FunctionAddress != IntPtr.Zero && OnApplyEnvSettings_IsNight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:OnApplyEnvSettings", OnApplyEnvSettings_IsValid);
		IsWeatherAvailable_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsWeatherAvailable");
		IsWeatherAvailable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsWeatherAvailable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsWeatherAvailable_InWeather_PropertyAddress, IsWeatherAvailable_FunctionAddress, "InWeather");
		IsWeatherAvailable_InWeather_Offset = NativeReflectionCached.GetPropertyOffset(IsWeatherAvailable_FunctionAddress, "InWeather");
		IsWeatherAvailable_InWeather_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWeatherAvailable_FunctionAddress, "InWeather", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IsWeatherAvailable_ViewLocation_PropertyAddress, IsWeatherAvailable_FunctionAddress, "ViewLocation");
		IsWeatherAvailable_ViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(IsWeatherAvailable_FunctionAddress, "ViewLocation");
		IsWeatherAvailable_ViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWeatherAvailable_FunctionAddress, "ViewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsWeatherAvailable_ReturnValue_PropertyAddress, IsWeatherAvailable_FunctionAddress, "ReturnValue");
		IsWeatherAvailable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsWeatherAvailable_FunctionAddress, "ReturnValue");
		IsWeatherAvailable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsWeatherAvailable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsWeatherAvailable_IsValid = IsWeatherAvailable_FunctionAddress != IntPtr.Zero && IsWeatherAvailable_InWeather_IsValid && IsWeatherAvailable_ViewLocation_IsValid && IsWeatherAvailable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BWC_DispLibDynamicEnvManager:IsWeatherAvailable", IsWeatherAvailable_IsValid);
	}
}
