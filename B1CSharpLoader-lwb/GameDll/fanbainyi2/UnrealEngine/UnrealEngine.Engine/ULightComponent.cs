using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.LightComponent", "Engine", UnrealModuleType.Engine)]
public class ULightComponent : ULightComponentBase
{
	private static bool Temperature_IsValid;

	private static int Temperature_Offset;

	private static bool UseTemperature_IsValid;

	private static FFieldAddress UseTemperature_PropertyAddress;

	private static int UseTemperature_Offset;

	private static bool SpecularScale_IsValid;

	private static int SpecularScale_Offset;

	private static bool ShadowResolutionScale_IsValid;

	private static int ShadowResolutionScale_Offset;

	private static bool ShadowBias_IsValid;

	private static int ShadowBias_Offset;

	private static bool ShadowSlopeBias_IsValid;

	private static int ShadowSlopeBias_Offset;

	private static bool ShadowSharpen_IsValid;

	private static int ShadowSharpen_Offset;

	private static bool ContactShadowLength_IsValid;

	private static int ContactShadowLength_Offset;

	private static bool ContactShadowLengthInWS_IsValid;

	private static FFieldAddress ContactShadowLengthInWS_PropertyAddress;

	private static int ContactShadowLengthInWS_Offset;

	private static bool CastTranslucentShadows_IsValid;

	private static FFieldAddress CastTranslucentShadows_PropertyAddress;

	private static int CastTranslucentShadows_Offset;

	private static bool CastShadowsFromCinematicObjectsOnly_IsValid;

	private static FFieldAddress CastShadowsFromCinematicObjectsOnly_PropertyAddress;

	private static int CastShadowsFromCinematicObjectsOnly_Offset;

	private static bool AffectDynamicIndirectLighting_IsValid;

	private static FFieldAddress AffectDynamicIndirectLighting_PropertyAddress;

	private static int AffectDynamicIndirectLighting_Offset;

	private static bool ForceCachedShadowsForMovablePrimitives_IsValid;

	private static FFieldAddress ForceCachedShadowsForMovablePrimitives_PropertyAddress;

	private static int ForceCachedShadowsForMovablePrimitives_Offset;

	private static bool LightingChannels_IsValid;

	private static int LightingChannels_Offset;

	private static bool LightFunctionMaterial_IsValid;

	private static int LightFunctionMaterial_Offset;

	private static bool LightFunctionScale_IsValid;

	private static int LightFunctionScale_Offset;

	private static bool IESTexture_IsValid;

	private static int IESTexture_Offset;

	private static bool UseIESBrightness_IsValid;

	private static FFieldAddress UseIESBrightness_PropertyAddress;

	private static int UseIESBrightness_Offset;

	private static bool IESBrightnessScale_IsValid;

	private static int IESBrightnessScale_Offset;

	private static bool LightFunctionFadeDistance_IsValid;

	private static int LightFunctionFadeDistance_Offset;

	private static bool DisabledBrightness_IsValid;

	private static int DisabledBrightness_Offset;

	private static bool EnableLightShaftBloom_IsValid;

	private static FFieldAddress EnableLightShaftBloom_PropertyAddress;

	private static int EnableLightShaftBloom_Offset;

	private static bool BloomScale_IsValid;

	private static int BloomScale_Offset;

	private static bool BloomThreshold_IsValid;

	private static int BloomThreshold_Offset;

	private static bool BloomMaxBrightness_IsValid;

	private static int BloomMaxBrightness_Offset;

	private static bool BloomTint_IsValid;

	private static int BloomTint_Offset;

	private static bool UseRayTracedDistanceFieldShadows_IsValid;

	private static FFieldAddress UseRayTracedDistanceFieldShadows_PropertyAddress;

	private static int UseRayTracedDistanceFieldShadows_Offset;

	private static bool RayStartOffsetDepthScale_IsValid;

	private static int RayStartOffsetDepthScale_Offset;

	private static bool AffectWaterCaustics_IsValid;

	private static FFieldAddress AffectWaterCaustics_PropertyAddress;

	private static int AffectWaterCaustics_Offset;

	private static bool WaterCausticsPrecision_IsValid;

	private static int WaterCausticsPrecision_Offset;

	private static bool NumWaterCausticsMapCascades_IsValid;

	private static int NumWaterCausticsMapCascades_Offset;

	private static bool WaterCausticsMapCascadeScale_IsValid;

	private static int WaterCausticsMapCascadeScale_Offset;

	private static bool SetWaterCausticsPrecision_IsValid;

	private static IntPtr SetWaterCausticsPrecision_FunctionAddress;

	private static int SetWaterCausticsPrecision_ParamsSize;

	private static bool SetWaterCausticsPrecision_NewValue_IsValid;

	private static FFieldAddress SetWaterCausticsPrecision_NewValue_PropertyAddress;

	private static int SetWaterCausticsPrecision_NewValue_Offset;

	private static bool SetWaterCausticsMapCascadeScale_IsValid;

	private static IntPtr SetWaterCausticsMapCascadeScale_FunctionAddress;

	private static int SetWaterCausticsMapCascadeScale_ParamsSize;

	private static bool SetWaterCausticsMapCascadeScale_NewValue_IsValid;

	private static FFieldAddress SetWaterCausticsMapCascadeScale_NewValue_PropertyAddress;

	private static int SetWaterCausticsMapCascadeScale_NewValue_Offset;

	private static bool SetVolumetricScatteringIntensity_IsValid;

	private static IntPtr SetVolumetricScatteringIntensity_FunctionAddress;

	private static int SetVolumetricScatteringIntensity_ParamsSize;

	private static bool SetVolumetricScatteringIntensity_NewIntensity_IsValid;

	private static FFieldAddress SetVolumetricScatteringIntensity_NewIntensity_PropertyAddress;

	private static int SetVolumetricScatteringIntensity_NewIntensity_Offset;

	private static bool SetUseTemperature_IsValid;

	private static IntPtr SetUseTemperature_FunctionAddress;

	private static int SetUseTemperature_ParamsSize;

	private static bool SetUseTemperature_bNewValue_IsValid;

	private static FFieldAddress SetUseTemperature_bNewValue_PropertyAddress;

	private static int SetUseTemperature_bNewValue_Offset;

	private static bool SetUseIESBrightness_IsValid;

	private static IntPtr SetUseIESBrightness_FunctionAddress;

	private static int SetUseIESBrightness_ParamsSize;

	private static bool SetUseIESBrightness_bNewValue_IsValid;

	private static FFieldAddress SetUseIESBrightness_bNewValue_PropertyAddress;

	private static int SetUseIESBrightness_bNewValue_Offset;

	private static bool SetTransmission_IsValid;

	private static IntPtr SetTransmission_FunctionAddress;

	private static int SetTransmission_ParamsSize;

	private static bool SetTransmission_bNewValue_IsValid;

	private static FFieldAddress SetTransmission_bNewValue_PropertyAddress;

	private static int SetTransmission_bNewValue_Offset;

	private static bool SetTemperature_IsValid;

	private static IntPtr SetTemperature_FunctionAddress;

	private static int SetTemperature_ParamsSize;

	private static bool SetTemperature_NewTemperature_IsValid;

	private static FFieldAddress SetTemperature_NewTemperature_PropertyAddress;

	private static int SetTemperature_NewTemperature_Offset;

	private static bool SetSpecularScale_IsValid;

	private static IntPtr SetSpecularScale_FunctionAddress;

	private static int SetSpecularScale_ParamsSize;

	private static bool SetSpecularScale_NewValue_IsValid;

	private static FFieldAddress SetSpecularScale_NewValue_PropertyAddress;

	private static int SetSpecularScale_NewValue_Offset;

	private static bool SetShadowSlopeBias_IsValid;

	private static IntPtr SetShadowSlopeBias_FunctionAddress;

	private static int SetShadowSlopeBias_ParamsSize;

	private static bool SetShadowSlopeBias_NewValue_IsValid;

	private static FFieldAddress SetShadowSlopeBias_NewValue_PropertyAddress;

	private static int SetShadowSlopeBias_NewValue_Offset;

	private static bool SetShadowBias_IsValid;

	private static IntPtr SetShadowBias_FunctionAddress;

	private static int SetShadowBias_ParamsSize;

	private static bool SetShadowBias_NewValue_IsValid;

	private static FFieldAddress SetShadowBias_NewValue_PropertyAddress;

	private static int SetShadowBias_NewValue_Offset;

	private static bool SetNumWaterCausticsMapCascades_IsValid;

	private static IntPtr SetNumWaterCausticsMapCascades_FunctionAddress;

	private static int SetNumWaterCausticsMapCascades_ParamsSize;

	private static bool SetNumWaterCausticsMapCascades_NewValue_IsValid;

	private static FFieldAddress SetNumWaterCausticsMapCascades_NewValue_PropertyAddress;

	private static int SetNumWaterCausticsMapCascades_NewValue_Offset;

	private static bool SetLightingChannels_IsValid;

	private static IntPtr SetLightingChannels_FunctionAddress;

	private static int SetLightingChannels_ParamsSize;

	private static bool SetLightingChannels_bChannel0_IsValid;

	private static FFieldAddress SetLightingChannels_bChannel0_PropertyAddress;

	private static int SetLightingChannels_bChannel0_Offset;

	private static bool SetLightingChannels_bChannel1_IsValid;

	private static FFieldAddress SetLightingChannels_bChannel1_PropertyAddress;

	private static int SetLightingChannels_bChannel1_Offset;

	private static bool SetLightingChannels_bChannel2_IsValid;

	private static FFieldAddress SetLightingChannels_bChannel2_PropertyAddress;

	private static int SetLightingChannels_bChannel2_Offset;

	private static bool SetLightFunctionScale_IsValid;

	private static IntPtr SetLightFunctionScale_FunctionAddress;

	private static int SetLightFunctionScale_ParamsSize;

	private static bool SetLightFunctionScale_NewLightFunctionScale_IsValid;

	private static FFieldAddress SetLightFunctionScale_NewLightFunctionScale_PropertyAddress;

	private static int SetLightFunctionScale_NewLightFunctionScale_Offset;

	private static bool SetLightFunctionMaterial_IsValid;

	private static IntPtr SetLightFunctionMaterial_FunctionAddress;

	private static int SetLightFunctionMaterial_ParamsSize;

	private static bool SetLightFunctionMaterial_NewLightFunctionMaterial_IsValid;

	private static FFieldAddress SetLightFunctionMaterial_NewLightFunctionMaterial_PropertyAddress;

	private static int SetLightFunctionMaterial_NewLightFunctionMaterial_Offset;

	private static bool SetLightFunctionFadeDistance_IsValid;

	private static IntPtr SetLightFunctionFadeDistance_FunctionAddress;

	private static int SetLightFunctionFadeDistance_ParamsSize;

	private static bool SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_IsValid;

	private static FFieldAddress SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_PropertyAddress;

	private static int SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_Offset;

	private static bool SetLightFunctionDisabledBrightness_IsValid;

	private static IntPtr SetLightFunctionDisabledBrightness_FunctionAddress;

	private static int SetLightFunctionDisabledBrightness_ParamsSize;

	private static bool SetLightFunctionDisabledBrightness_NewValue_IsValid;

	private static FFieldAddress SetLightFunctionDisabledBrightness_NewValue_PropertyAddress;

	private static int SetLightFunctionDisabledBrightness_NewValue_Offset;

	private static bool SetLightColor_IsValid;

	private static IntPtr SetLightColor_FunctionAddress;

	private static int SetLightColor_ParamsSize;

	private static bool SetLightColor_NewLightColor_IsValid;

	private static FFieldAddress SetLightColor_NewLightColor_PropertyAddress;

	private static int SetLightColor_NewLightColor_Offset;

	private static bool SetLightColor_bSRGB_IsValid;

	private static FFieldAddress SetLightColor_bSRGB_PropertyAddress;

	private static int SetLightColor_bSRGB_Offset;

	private static bool SetIntensity_IsValid;

	private static IntPtr SetIntensity_FunctionAddress;

	private static int SetIntensity_ParamsSize;

	private static bool SetIntensity_NewIntensity_IsValid;

	private static FFieldAddress SetIntensity_NewIntensity_PropertyAddress;

	private static int SetIntensity_NewIntensity_Offset;

	private static bool SetIndirectLightingIntensity_IsValid;

	private static IntPtr SetIndirectLightingIntensity_FunctionAddress;

	private static int SetIndirectLightingIntensity_ParamsSize;

	private static bool SetIndirectLightingIntensity_NewIntensity_IsValid;

	private static FFieldAddress SetIndirectLightingIntensity_NewIntensity_PropertyAddress;

	private static int SetIndirectLightingIntensity_NewIntensity_Offset;

	private static bool SetIESTexture_IsValid;

	private static IntPtr SetIESTexture_FunctionAddress;

	private static int SetIESTexture_ParamsSize;

	private static bool SetIESTexture_NewValue_IsValid;

	private static FFieldAddress SetIESTexture_NewValue_PropertyAddress;

	private static int SetIESTexture_NewValue_Offset;

	private static bool SetIESBrightnessScale_IsValid;

	private static IntPtr SetIESBrightnessScale_FunctionAddress;

	private static int SetIESBrightnessScale_ParamsSize;

	private static bool SetIESBrightnessScale_NewValue_IsValid;

	private static FFieldAddress SetIESBrightnessScale_NewValue_PropertyAddress;

	private static int SetIESBrightnessScale_NewValue_Offset;

	private static bool SetForceCachedShadowsForMovablePrimitives_IsValid;

	private static IntPtr SetForceCachedShadowsForMovablePrimitives_FunctionAddress;

	private static int SetForceCachedShadowsForMovablePrimitives_ParamsSize;

	private static bool SetForceCachedShadowsForMovablePrimitives_bNewValue_IsValid;

	private static FFieldAddress SetForceCachedShadowsForMovablePrimitives_bNewValue_PropertyAddress;

	private static int SetForceCachedShadowsForMovablePrimitives_bNewValue_Offset;

	private static bool SetEnableLightShaftBloom_IsValid;

	private static IntPtr SetEnableLightShaftBloom_FunctionAddress;

	private static int SetEnableLightShaftBloom_ParamsSize;

	private static bool SetEnableLightShaftBloom_bNewValue_IsValid;

	private static FFieldAddress SetEnableLightShaftBloom_bNewValue_PropertyAddress;

	private static int SetEnableLightShaftBloom_bNewValue_Offset;

	private static bool SetBloomTint_IsValid;

	private static IntPtr SetBloomTint_FunctionAddress;

	private static int SetBloomTint_ParamsSize;

	private static bool SetBloomTint_NewValue_IsValid;

	private static FFieldAddress SetBloomTint_NewValue_PropertyAddress;

	private static int SetBloomTint_NewValue_Offset;

	private static bool SetBloomThreshold_IsValid;

	private static IntPtr SetBloomThreshold_FunctionAddress;

	private static int SetBloomThreshold_ParamsSize;

	private static bool SetBloomThreshold_NewValue_IsValid;

	private static FFieldAddress SetBloomThreshold_NewValue_PropertyAddress;

	private static int SetBloomThreshold_NewValue_Offset;

	private static bool SetBloomScale_IsValid;

	private static IntPtr SetBloomScale_FunctionAddress;

	private static int SetBloomScale_ParamsSize;

	private static bool SetBloomScale_NewValue_IsValid;

	private static FFieldAddress SetBloomScale_NewValue_PropertyAddress;

	private static int SetBloomScale_NewValue_Offset;

	private static bool SetBloomMaxBrightness_IsValid;

	private static IntPtr SetBloomMaxBrightness_FunctionAddress;

	private static int SetBloomMaxBrightness_ParamsSize;

	private static bool SetBloomMaxBrightness_NewValue_IsValid;

	private static FFieldAddress SetBloomMaxBrightness_NewValue_PropertyAddress;

	private static int SetBloomMaxBrightness_NewValue_Offset;

	private static bool SetAffectWaterCaustics_IsValid;

	private static IntPtr SetAffectWaterCaustics_FunctionAddress;

	private static int SetAffectWaterCaustics_ParamsSize;

	private static bool SetAffectWaterCaustics_bNewValue_IsValid;

	private static FFieldAddress SetAffectWaterCaustics_bNewValue_PropertyAddress;

	private static int SetAffectWaterCaustics_bNewValue_Offset;

	private static bool SetAffectTranslucentLighting_IsValid;

	private static IntPtr SetAffectTranslucentLighting_FunctionAddress;

	private static int SetAffectTranslucentLighting_ParamsSize;

	private static bool SetAffectTranslucentLighting_bNewValue_IsValid;

	private static FFieldAddress SetAffectTranslucentLighting_bNewValue_PropertyAddress;

	private static int SetAffectTranslucentLighting_bNewValue_Offset;

	private static bool SetAffectDynamicIndirectLighting_IsValid;

	private static IntPtr SetAffectDynamicIndirectLighting_FunctionAddress;

	private static int SetAffectDynamicIndirectLighting_ParamsSize;

	private static bool SetAffectDynamicIndirectLighting_bNewValue_IsValid;

	private static FFieldAddress SetAffectDynamicIndirectLighting_bNewValue_PropertyAddress;

	private static int SetAffectDynamicIndirectLighting_bNewValue_Offset;

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.LightComponent:Temperature")]
	public float Temperature
	{
		get
		{
			CheckDestroyed();
			if (!Temperature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:Temperature");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Temperature_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Temperature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:Temperature");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Temperature_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightComponent:bUseTemperature")]
	public bool UseTemperature
	{
		get
		{
			CheckDestroyed();
			if (!UseTemperature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bUseTemperature");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseTemperature_Offset), 0, UseTemperature_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseTemperature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bUseTemperature");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseTemperature_Offset), 0, UseTemperature_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:SpecularScale")]
	public float SpecularScale
	{
		get
		{
			CheckDestroyed();
			if (!SpecularScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:SpecularScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpecularScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecularScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:SpecularScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpecularScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:ShadowResolutionScale")]
	public float ShadowResolutionScale
	{
		get
		{
			CheckDestroyed();
			if (!ShadowResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowResolutionScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowResolutionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowResolutionScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowResolutionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:ShadowBias")]
	public float ShadowBias
	{
		get
		{
			CheckDestroyed();
			if (!ShadowBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowBias");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowBias");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:ShadowSlopeBias")]
	public float ShadowSlopeBias
	{
		get
		{
			CheckDestroyed();
			if (!ShadowSlopeBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowSlopeBias");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowSlopeBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowSlopeBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowSlopeBias");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowSlopeBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:ShadowSharpen")]
	public float ShadowSharpen
	{
		get
		{
			CheckDestroyed();
			if (!ShadowSharpen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowSharpen");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowSharpen_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowSharpen_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ShadowSharpen");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowSharpen_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.LightComponent:ContactShadowLength")]
	public float ContactShadowLength
	{
		get
		{
			CheckDestroyed();
			if (!ContactShadowLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ContactShadowLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ContactShadowLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContactShadowLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ContactShadowLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ContactShadowLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043589uL)]
	[UMetaPath("/Script/Engine.LightComponent:ContactShadowLengthInWS")]
	public bool ContactShadowLengthInWS
	{
		get
		{
			CheckDestroyed();
			if (!ContactShadowLengthInWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ContactShadowLengthInWS");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ContactShadowLengthInWS_Offset), 0, ContactShadowLengthInWS_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ContactShadowLengthInWS_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:ContactShadowLengthInWS");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ContactShadowLengthInWS_Offset), 0, ContactShadowLengthInWS_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponent:CastTranslucentShadows")]
	public bool CastTranslucentShadows
	{
		get
		{
			CheckDestroyed();
			if (!CastTranslucentShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:CastTranslucentShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastTranslucentShadows_Offset), 0, CastTranslucentShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastTranslucentShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:CastTranslucentShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastTranslucentShadows_Offset), 0, CastTranslucentShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponent:bCastShadowsFromCinematicObjectsOnly")]
	public bool CastShadowsFromCinematicObjectsOnly
	{
		get
		{
			CheckDestroyed();
			if (!CastShadowsFromCinematicObjectsOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bCastShadowsFromCinematicObjectsOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadowsFromCinematicObjectsOnly_Offset), 0, CastShadowsFromCinematicObjectsOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadowsFromCinematicObjectsOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bCastShadowsFromCinematicObjectsOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadowsFromCinematicObjectsOnly_Offset), 0, CastShadowsFromCinematicObjectsOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponent:bAffectDynamicIndirectLighting")]
	public bool AffectDynamicIndirectLighting
	{
		get
		{
			CheckDestroyed();
			if (!AffectDynamicIndirectLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bAffectDynamicIndirectLighting");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectDynamicIndirectLighting_Offset), 0, AffectDynamicIndirectLighting_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectDynamicIndirectLighting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bAffectDynamicIndirectLighting");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectDynamicIndirectLighting_Offset), 0, AffectDynamicIndirectLighting_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponent:bForceCachedShadowsForMovablePrimitives")]
	public bool ForceCachedShadowsForMovablePrimitives
	{
		get
		{
			CheckDestroyed();
			if (!ForceCachedShadowsForMovablePrimitives_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bForceCachedShadowsForMovablePrimitives");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceCachedShadowsForMovablePrimitives_Offset), 0, ForceCachedShadowsForMovablePrimitives_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceCachedShadowsForMovablePrimitives_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bForceCachedShadowsForMovablePrimitives");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceCachedShadowsForMovablePrimitives_Offset), 0, ForceCachedShadowsForMovablePrimitives_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4508066393358357uL)]
	[UMetaPath("/Script/Engine.LightComponent:LightingChannels")]
	public FLightingChannels LightingChannels
	{
		get
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightingChannels");
				return default(FLightingChannels);
			}
			return FLightingChannels.FromNative(IntPtr.Add(base.Address, LightingChannels_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightingChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightingChannels");
			}
			else
			{
				FLightingChannels.ToNative(IntPtr.Add(base.Address, LightingChannels_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.LightComponent:LightFunctionMaterial")]
	public UMaterialInterface LightFunctionMaterial
	{
		get
		{
			CheckDestroyed();
			if (!LightFunctionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightFunctionMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, LightFunctionMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightFunctionMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightFunctionMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, LightFunctionMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:LightFunctionScale")]
	public FVector LightFunctionScale
	{
		get
		{
			CheckDestroyed();
			if (!LightFunctionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightFunctionScale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LightFunctionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightFunctionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightFunctionScale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LightFunctionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.LightComponent:IESTexture")]
	public UTextureLightProfile IESTexture
	{
		get
		{
			CheckDestroyed();
			if (!IESTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:IESTexture");
				return null;
			}
			return UObjectMarshaler<UTextureLightProfile>.FromNative(IntPtr.Add(base.Address, IESTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IESTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:IESTexture");
			}
			else
			{
				UObjectMarshaler<UTextureLightProfile>.ToNative(IntPtr.Add(base.Address, IESTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightComponent:bUseIESBrightness")]
	public bool UseIESBrightness
	{
		get
		{
			CheckDestroyed();
			if (!UseIESBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bUseIESBrightness");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseIESBrightness_Offset), 0, UseIESBrightness_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseIESBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bUseIESBrightness");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseIESBrightness_Offset), 0, UseIESBrightness_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.LightComponent:IESBrightnessScale")]
	public float IESBrightnessScale
	{
		get
		{
			CheckDestroyed();
			if (!IESBrightnessScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:IESBrightnessScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IESBrightnessScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IESBrightnessScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:IESBrightnessScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IESBrightnessScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:LightFunctionFadeDistance")]
	public float LightFunctionFadeDistance
	{
		get
		{
			CheckDestroyed();
			if (!LightFunctionFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightFunctionFadeDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LightFunctionFadeDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightFunctionFadeDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:LightFunctionFadeDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LightFunctionFadeDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:DisabledBrightness")]
	public float DisabledBrightness
	{
		get
		{
			CheckDestroyed();
			if (!DisabledBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:DisabledBrightness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DisabledBrightness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DisabledBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:DisabledBrightness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DisabledBrightness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.LightComponent:bEnableLightShaftBloom")]
	public bool EnableLightShaftBloom
	{
		get
		{
			CheckDestroyed();
			if (!EnableLightShaftBloom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bEnableLightShaftBloom");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableLightShaftBloom_Offset), 0, EnableLightShaftBloom_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableLightShaftBloom_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bEnableLightShaftBloom");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableLightShaftBloom_Offset), 0, EnableLightShaftBloom_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:BloomScale")]
	public float BloomScale
	{
		get
		{
			CheckDestroyed();
			if (!BloomScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BloomScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BloomScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BloomScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:BloomThreshold")]
	public float BloomThreshold
	{
		get
		{
			CheckDestroyed();
			if (!BloomThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BloomThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BloomThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BloomThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:BloomMaxBrightness")]
	public float BloomMaxBrightness
	{
		get
		{
			CheckDestroyed();
			if (!BloomMaxBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomMaxBrightness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BloomMaxBrightness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BloomMaxBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomMaxBrightness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BloomMaxBrightness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:BloomTint")]
	public FColor BloomTint
	{
		get
		{
			CheckDestroyed();
			if (!BloomTint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomTint");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, BloomTint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BloomTint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:BloomTint");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, BloomTint_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.LightComponent:bUseRayTracedDistanceFieldShadows")]
	public bool UseRayTracedDistanceFieldShadows
	{
		get
		{
			CheckDestroyed();
			if (!UseRayTracedDistanceFieldShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bUseRayTracedDistanceFieldShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseRayTracedDistanceFieldShadows_Offset), 0, UseRayTracedDistanceFieldShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseRayTracedDistanceFieldShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bUseRayTracedDistanceFieldShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseRayTracedDistanceFieldShadows_Offset), 0, UseRayTracedDistanceFieldShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:RayStartOffsetDepthScale")]
	public float RayStartOffsetDepthScale
	{
		get
		{
			CheckDestroyed();
			if (!RayStartOffsetDepthScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:RayStartOffsetDepthScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RayStartOffsetDepthScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayStartOffsetDepthScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:RayStartOffsetDepthScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RayStartOffsetDepthScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.LightComponent:bAffectWaterCaustics")]
	public bool AffectWaterCaustics
	{
		get
		{
			CheckDestroyed();
			if (!AffectWaterCaustics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bAffectWaterCaustics");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AffectWaterCaustics_Offset), 0, AffectWaterCaustics_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AffectWaterCaustics_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:bAffectWaterCaustics");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AffectWaterCaustics_Offset), 0, AffectWaterCaustics_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:WaterCausticsPrecision")]
	public float WaterCausticsPrecision
	{
		get
		{
			CheckDestroyed();
			if (!WaterCausticsPrecision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:WaterCausticsPrecision");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WaterCausticsPrecision_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterCausticsPrecision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:WaterCausticsPrecision");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WaterCausticsPrecision_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:NumWaterCausticsMapCascades")]
	public int NumWaterCausticsMapCascades
	{
		get
		{
			CheckDestroyed();
			if (!NumWaterCausticsMapCascades_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:NumWaterCausticsMapCascades");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumWaterCausticsMapCascades_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumWaterCausticsMapCascades_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:NumWaterCausticsMapCascades");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumWaterCausticsMapCascades_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.LightComponent:WaterCausticsMapCascadeScale")]
	public float WaterCausticsMapCascadeScale
	{
		get
		{
			CheckDestroyed();
			if (!WaterCausticsMapCascadeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:WaterCausticsMapCascadeScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WaterCausticsMapCascadeScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaterCausticsMapCascadeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LightComponent:WaterCausticsMapCascadeScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WaterCausticsMapCascadeScale_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetWaterCausticsPrecision")]
	public unsafe void SetWaterCausticsPrecision(float NewValue)
	{
		CheckDestroyed();
		if (!SetWaterCausticsPrecision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetWaterCausticsPrecision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWaterCausticsPrecision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWaterCausticsPrecision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWaterCausticsPrecision_NewValue_Offset), 0, SetWaterCausticsPrecision_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWaterCausticsPrecision_FunctionAddress, intPtr, SetWaterCausticsPrecision_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetWaterCausticsMapCascadeScale")]
	public unsafe void SetWaterCausticsMapCascadeScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetWaterCausticsMapCascadeScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetWaterCausticsMapCascadeScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWaterCausticsMapCascadeScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWaterCausticsMapCascadeScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWaterCausticsMapCascadeScale_NewValue_Offset), 0, SetWaterCausticsMapCascadeScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWaterCausticsMapCascadeScale_FunctionAddress, intPtr, SetWaterCausticsMapCascadeScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetVolumetricScatteringIntensity")]
	public unsafe void SetVolumetricScatteringIntensity(float NewIntensity)
	{
		CheckDestroyed();
		if (!SetVolumetricScatteringIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetVolumetricScatteringIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVolumetricScatteringIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVolumetricScatteringIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVolumetricScatteringIntensity_NewIntensity_Offset), 0, SetVolumetricScatteringIntensity_NewIntensity_PropertyAddress.Address, NewIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVolumetricScatteringIntensity_FunctionAddress, intPtr, SetVolumetricScatteringIntensity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetUseTemperature")]
	public unsafe void SetUseTemperature(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetUseTemperature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetUseTemperature");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseTemperature_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseTemperature_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseTemperature_bNewValue_Offset), 0, SetUseTemperature_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseTemperature_FunctionAddress, intPtr, SetUseTemperature_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetUseIESBrightness")]
	public unsafe void SetUseIESBrightness(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetUseIESBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetUseIESBrightness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseIESBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseIESBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseIESBrightness_bNewValue_Offset), 0, SetUseIESBrightness_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseIESBrightness_FunctionAddress, intPtr, SetUseIESBrightness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetTransmission")]
	public unsafe void SetTransmission(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetTransmission_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetTransmission");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTransmission_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTransmission_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTransmission_bNewValue_Offset), 0, SetTransmission_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTransmission_FunctionAddress, intPtr, SetTransmission_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetTemperature")]
	public unsafe void SetTemperature(float NewTemperature)
	{
		CheckDestroyed();
		if (!SetTemperature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetTemperature");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTemperature_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTemperature_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetTemperature_NewTemperature_Offset), 0, SetTemperature_NewTemperature_PropertyAddress.Address, NewTemperature);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTemperature_FunctionAddress, intPtr, SetTemperature_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetSpecularScale")]
	public unsafe void SetSpecularScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetSpecularScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetSpecularScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpecularScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpecularScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSpecularScale_NewValue_Offset), 0, SetSpecularScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpecularScale_FunctionAddress, intPtr, SetSpecularScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetShadowSlopeBias")]
	public unsafe void SetShadowSlopeBias(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowSlopeBias_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetShadowSlopeBias");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowSlopeBias_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowSlopeBias_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowSlopeBias_NewValue_Offset), 0, SetShadowSlopeBias_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowSlopeBias_FunctionAddress, intPtr, SetShadowSlopeBias_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetShadowBias")]
	public unsafe void SetShadowBias(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowBias_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetShadowBias");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowBias_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowBias_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowBias_NewValue_Offset), 0, SetShadowBias_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowBias_FunctionAddress, intPtr, SetShadowBias_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetNumWaterCausticsMapCascades")]
	public unsafe void SetNumWaterCausticsMapCascades(int NewValue)
	{
		CheckDestroyed();
		if (!SetNumWaterCausticsMapCascades_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetNumWaterCausticsMapCascades");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumWaterCausticsMapCascades_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumWaterCausticsMapCascades_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumWaterCausticsMapCascades_NewValue_Offset), 0, SetNumWaterCausticsMapCascades_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNumWaterCausticsMapCascades_FunctionAddress, intPtr, SetNumWaterCausticsMapCascades_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetLightingChannels")]
	public unsafe void SetLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
	{
		CheckDestroyed();
		if (!SetLightingChannels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetLightingChannels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightingChannels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightingChannels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightingChannels_bChannel0_Offset), 0, SetLightingChannels_bChannel0_PropertyAddress.Address, bChannel0);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightingChannels_bChannel1_Offset), 0, SetLightingChannels_bChannel1_PropertyAddress.Address, bChannel1);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightingChannels_bChannel2_Offset), 0, SetLightingChannels_bChannel2_PropertyAddress.Address, bChannel2);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightingChannels_FunctionAddress, intPtr, SetLightingChannels_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.LightComponent:SetLightFunctionScale")]
	public unsafe void SetLightFunctionScale(FVector NewLightFunctionScale)
	{
		CheckDestroyed();
		if (!SetLightFunctionScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetLightFunctionScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightFunctionScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightFunctionScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLightFunctionScale_NewLightFunctionScale_Offset), 0, SetLightFunctionScale_NewLightFunctionScale_PropertyAddress.Address, NewLightFunctionScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightFunctionScale_FunctionAddress, intPtr, SetLightFunctionScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetLightFunctionMaterial")]
	public unsafe void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
	{
		CheckDestroyed();
		if (!SetLightFunctionMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetLightFunctionMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightFunctionMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightFunctionMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetLightFunctionMaterial_NewLightFunctionMaterial_Offset), 0, SetLightFunctionMaterial_NewLightFunctionMaterial_PropertyAddress.Address, NewLightFunctionMaterial);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightFunctionMaterial_FunctionAddress, intPtr, SetLightFunctionMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetLightFunctionFadeDistance")]
	public unsafe void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
	{
		CheckDestroyed();
		if (!SetLightFunctionFadeDistance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetLightFunctionFadeDistance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightFunctionFadeDistance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightFunctionFadeDistance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_Offset), 0, SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_PropertyAddress.Address, NewLightFunctionFadeDistance);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightFunctionFadeDistance_FunctionAddress, intPtr, SetLightFunctionFadeDistance_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetLightFunctionDisabledBrightness")]
	public unsafe void SetLightFunctionDisabledBrightness(float NewValue)
	{
		CheckDestroyed();
		if (!SetLightFunctionDisabledBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetLightFunctionDisabledBrightness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightFunctionDisabledBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightFunctionDisabledBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLightFunctionDisabledBrightness_NewValue_Offset), 0, SetLightFunctionDisabledBrightness_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightFunctionDisabledBrightness_FunctionAddress, intPtr, SetLightFunctionDisabledBrightness_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.LightComponent:SetLightColor")]
	public unsafe void SetLightColor(FLinearColor NewLightColor, bool bSRGB = true)
	{
		CheckDestroyed();
		if (!SetLightColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetLightColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetLightColor_NewLightColor_Offset), 0, SetLightColor_NewLightColor_PropertyAddress.Address, NewLightColor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLightColor_bSRGB_Offset), 0, SetLightColor_bSRGB_PropertyAddress.Address, bSRGB);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightColor_FunctionAddress, intPtr, SetLightColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetIntensity")]
	public unsafe void SetIntensity(float NewIntensity)
	{
		CheckDestroyed();
		if (!SetIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIntensity_NewIntensity_Offset), 0, SetIntensity_NewIntensity_PropertyAddress.Address, NewIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIntensity_FunctionAddress, intPtr, SetIntensity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetIndirectLightingIntensity")]
	public unsafe void SetIndirectLightingIntensity(float NewIntensity)
	{
		CheckDestroyed();
		if (!SetIndirectLightingIntensity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetIndirectLightingIntensity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIndirectLightingIntensity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIndirectLightingIntensity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIndirectLightingIntensity_NewIntensity_Offset), 0, SetIndirectLightingIntensity_NewIntensity_PropertyAddress.Address, NewIntensity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIndirectLightingIntensity_FunctionAddress, intPtr, SetIndirectLightingIntensity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetIESTexture")]
	public unsafe void SetIESTexture(UTextureLightProfile NewValue)
	{
		CheckDestroyed();
		if (!SetIESTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetIESTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIESTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIESTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTextureLightProfile>.ToNative(IntPtr.Add(intPtr, SetIESTexture_NewValue_Offset), 0, SetIESTexture_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIESTexture_FunctionAddress, intPtr, SetIESTexture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetIESBrightnessScale")]
	public unsafe void SetIESBrightnessScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetIESBrightnessScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetIESBrightnessScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIESBrightnessScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIESBrightnessScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetIESBrightnessScale_NewValue_Offset), 0, SetIESBrightnessScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIESBrightnessScale_FunctionAddress, intPtr, SetIESBrightnessScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetForceCachedShadowsForMovablePrimitives")]
	public unsafe void SetForceCachedShadowsForMovablePrimitives(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetForceCachedShadowsForMovablePrimitives_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetForceCachedShadowsForMovablePrimitives");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForceCachedShadowsForMovablePrimitives_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForceCachedShadowsForMovablePrimitives_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForceCachedShadowsForMovablePrimitives_bNewValue_Offset), 0, SetForceCachedShadowsForMovablePrimitives_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForceCachedShadowsForMovablePrimitives_FunctionAddress, intPtr, SetForceCachedShadowsForMovablePrimitives_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetEnableLightShaftBloom")]
	public unsafe void SetEnableLightShaftBloom(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetEnableLightShaftBloom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetEnableLightShaftBloom");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableLightShaftBloom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableLightShaftBloom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableLightShaftBloom_bNewValue_Offset), 0, SetEnableLightShaftBloom_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableLightShaftBloom_FunctionAddress, intPtr, SetEnableLightShaftBloom_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.LightComponent:SetBloomTint")]
	public unsafe void SetBloomTint(FColor NewValue)
	{
		CheckDestroyed();
		if (!SetBloomTint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetBloomTint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBloomTint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBloomTint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetBloomTint_NewValue_Offset), 0, SetBloomTint_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBloomTint_FunctionAddress, intPtr, SetBloomTint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetBloomThreshold")]
	public unsafe void SetBloomThreshold(float NewValue)
	{
		CheckDestroyed();
		if (!SetBloomThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetBloomThreshold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBloomThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBloomThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBloomThreshold_NewValue_Offset), 0, SetBloomThreshold_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBloomThreshold_FunctionAddress, intPtr, SetBloomThreshold_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetBloomScale")]
	public unsafe void SetBloomScale(float NewValue)
	{
		CheckDestroyed();
		if (!SetBloomScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetBloomScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBloomScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBloomScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBloomScale_NewValue_Offset), 0, SetBloomScale_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBloomScale_FunctionAddress, intPtr, SetBloomScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetBloomMaxBrightness")]
	public unsafe void SetBloomMaxBrightness(float NewValue)
	{
		CheckDestroyed();
		if (!SetBloomMaxBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetBloomMaxBrightness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBloomMaxBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBloomMaxBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBloomMaxBrightness_NewValue_Offset), 0, SetBloomMaxBrightness_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBloomMaxBrightness_FunctionAddress, intPtr, SetBloomMaxBrightness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetAffectWaterCaustics")]
	public unsafe void SetAffectWaterCaustics(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetAffectWaterCaustics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetAffectWaterCaustics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAffectWaterCaustics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAffectWaterCaustics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAffectWaterCaustics_bNewValue_Offset), 0, SetAffectWaterCaustics_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAffectWaterCaustics_FunctionAddress, intPtr, SetAffectWaterCaustics_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetAffectTranslucentLighting")]
	public unsafe void SetAffectTranslucentLighting(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetAffectTranslucentLighting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetAffectTranslucentLighting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAffectTranslucentLighting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAffectTranslucentLighting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAffectTranslucentLighting_bNewValue_Offset), 0, SetAffectTranslucentLighting_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAffectTranslucentLighting_FunctionAddress, intPtr, SetAffectTranslucentLighting_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.LightComponent:SetAffectDynamicIndirectLighting")]
	public unsafe void SetAffectDynamicIndirectLighting(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetAffectDynamicIndirectLighting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.LightComponent:SetAffectDynamicIndirectLighting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAffectDynamicIndirectLighting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAffectDynamicIndirectLighting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAffectDynamicIndirectLighting_bNewValue_Offset), 0, SetAffectDynamicIndirectLighting_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAffectDynamicIndirectLighting_FunctionAddress, intPtr, SetAffectDynamicIndirectLighting_ParamsSize);
	}

	static ULightComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULightComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULightComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.LightComponent");
		Temperature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Temperature");
		Temperature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Temperature", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseTemperature_PropertyAddress, intPtr, "bUseTemperature");
		UseTemperature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseTemperature");
		UseTemperature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseTemperature", Classes.FBoolProperty);
		SpecularScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpecularScale");
		SpecularScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpecularScale", Classes.FFloatProperty);
		ShadowResolutionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowResolutionScale");
		ShadowResolutionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowResolutionScale", Classes.FFloatProperty);
		ShadowBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowBias");
		ShadowBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowBias", Classes.FFloatProperty);
		ShadowSlopeBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowSlopeBias");
		ShadowSlopeBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowSlopeBias", Classes.FFloatProperty);
		ShadowSharpen_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowSharpen");
		ShadowSharpen_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowSharpen", Classes.FFloatProperty);
		ContactShadowLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContactShadowLength");
		ContactShadowLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContactShadowLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ContactShadowLengthInWS_PropertyAddress, intPtr, "ContactShadowLengthInWS");
		ContactShadowLengthInWS_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContactShadowLengthInWS");
		ContactShadowLengthInWS_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContactShadowLengthInWS", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastTranslucentShadows_PropertyAddress, intPtr, "CastTranslucentShadows");
		CastTranslucentShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastTranslucentShadows");
		CastTranslucentShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastTranslucentShadows", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowsFromCinematicObjectsOnly_PropertyAddress, intPtr, "bCastShadowsFromCinematicObjectsOnly");
		CastShadowsFromCinematicObjectsOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastShadowsFromCinematicObjectsOnly");
		CastShadowsFromCinematicObjectsOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastShadowsFromCinematicObjectsOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectDynamicIndirectLighting_PropertyAddress, intPtr, "bAffectDynamicIndirectLighting");
		AffectDynamicIndirectLighting_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectDynamicIndirectLighting");
		AffectDynamicIndirectLighting_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectDynamicIndirectLighting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceCachedShadowsForMovablePrimitives_PropertyAddress, intPtr, "bForceCachedShadowsForMovablePrimitives");
		ForceCachedShadowsForMovablePrimitives_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceCachedShadowsForMovablePrimitives");
		ForceCachedShadowsForMovablePrimitives_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceCachedShadowsForMovablePrimitives", Classes.FBoolProperty);
		LightingChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightingChannels");
		LightingChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightingChannels", Classes.FStructProperty);
		LightFunctionMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightFunctionMaterial");
		LightFunctionMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightFunctionMaterial", Classes.FObjectProperty);
		LightFunctionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightFunctionScale");
		LightFunctionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightFunctionScale", Classes.FStructProperty);
		IESTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IESTexture");
		IESTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IESTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseIESBrightness_PropertyAddress, intPtr, "bUseIESBrightness");
		UseIESBrightness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseIESBrightness");
		UseIESBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseIESBrightness", Classes.FBoolProperty);
		IESBrightnessScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IESBrightnessScale");
		IESBrightnessScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IESBrightnessScale", Classes.FFloatProperty);
		LightFunctionFadeDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightFunctionFadeDistance");
		LightFunctionFadeDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightFunctionFadeDistance", Classes.FFloatProperty);
		DisabledBrightness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DisabledBrightness");
		DisabledBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DisabledBrightness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableLightShaftBloom_PropertyAddress, intPtr, "bEnableLightShaftBloom");
		EnableLightShaftBloom_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableLightShaftBloom");
		EnableLightShaftBloom_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableLightShaftBloom", Classes.FBoolProperty);
		BloomScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BloomScale");
		BloomScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BloomScale", Classes.FFloatProperty);
		BloomThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BloomThreshold");
		BloomThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BloomThreshold", Classes.FFloatProperty);
		BloomMaxBrightness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BloomMaxBrightness");
		BloomMaxBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BloomMaxBrightness", Classes.FFloatProperty);
		BloomTint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BloomTint");
		BloomTint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BloomTint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UseRayTracedDistanceFieldShadows_PropertyAddress, intPtr, "bUseRayTracedDistanceFieldShadows");
		UseRayTracedDistanceFieldShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseRayTracedDistanceFieldShadows");
		UseRayTracedDistanceFieldShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseRayTracedDistanceFieldShadows", Classes.FBoolProperty);
		RayStartOffsetDepthScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RayStartOffsetDepthScale");
		RayStartOffsetDepthScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RayStartOffsetDepthScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AffectWaterCaustics_PropertyAddress, intPtr, "bAffectWaterCaustics");
		AffectWaterCaustics_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAffectWaterCaustics");
		AffectWaterCaustics_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAffectWaterCaustics", Classes.FBoolProperty);
		WaterCausticsPrecision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterCausticsPrecision");
		WaterCausticsPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterCausticsPrecision", Classes.FFloatProperty);
		NumWaterCausticsMapCascades_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumWaterCausticsMapCascades");
		NumWaterCausticsMapCascades_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumWaterCausticsMapCascades", Classes.FIntProperty);
		WaterCausticsMapCascadeScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WaterCausticsMapCascadeScale");
		WaterCausticsMapCascadeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WaterCausticsMapCascadeScale", Classes.FFloatProperty);
		SetWaterCausticsPrecision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWaterCausticsPrecision");
		SetWaterCausticsPrecision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWaterCausticsPrecision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWaterCausticsPrecision_NewValue_PropertyAddress, SetWaterCausticsPrecision_FunctionAddress, "NewValue");
		SetWaterCausticsPrecision_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetWaterCausticsPrecision_FunctionAddress, "NewValue");
		SetWaterCausticsPrecision_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaterCausticsPrecision_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetWaterCausticsPrecision_IsValid = SetWaterCausticsPrecision_FunctionAddress != IntPtr.Zero && SetWaterCausticsPrecision_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetWaterCausticsPrecision", SetWaterCausticsPrecision_IsValid);
		SetWaterCausticsMapCascadeScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWaterCausticsMapCascadeScale");
		SetWaterCausticsMapCascadeScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWaterCausticsMapCascadeScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWaterCausticsMapCascadeScale_NewValue_PropertyAddress, SetWaterCausticsMapCascadeScale_FunctionAddress, "NewValue");
		SetWaterCausticsMapCascadeScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetWaterCausticsMapCascadeScale_FunctionAddress, "NewValue");
		SetWaterCausticsMapCascadeScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWaterCausticsMapCascadeScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetWaterCausticsMapCascadeScale_IsValid = SetWaterCausticsMapCascadeScale_FunctionAddress != IntPtr.Zero && SetWaterCausticsMapCascadeScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetWaterCausticsMapCascadeScale", SetWaterCausticsMapCascadeScale_IsValid);
		SetVolumetricScatteringIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVolumetricScatteringIntensity");
		SetVolumetricScatteringIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVolumetricScatteringIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVolumetricScatteringIntensity_NewIntensity_PropertyAddress, SetVolumetricScatteringIntensity_FunctionAddress, "NewIntensity");
		SetVolumetricScatteringIntensity_NewIntensity_Offset = NativeReflectionCached.GetPropertyOffset(SetVolumetricScatteringIntensity_FunctionAddress, "NewIntensity");
		SetVolumetricScatteringIntensity_NewIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVolumetricScatteringIntensity_FunctionAddress, "NewIntensity", Classes.FFloatProperty);
		SetVolumetricScatteringIntensity_IsValid = SetVolumetricScatteringIntensity_FunctionAddress != IntPtr.Zero && SetVolumetricScatteringIntensity_NewIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetVolumetricScatteringIntensity", SetVolumetricScatteringIntensity_IsValid);
		SetUseTemperature_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseTemperature");
		SetUseTemperature_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseTemperature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseTemperature_bNewValue_PropertyAddress, SetUseTemperature_FunctionAddress, "bNewValue");
		SetUseTemperature_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetUseTemperature_FunctionAddress, "bNewValue");
		SetUseTemperature_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseTemperature_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetUseTemperature_IsValid = SetUseTemperature_FunctionAddress != IntPtr.Zero && SetUseTemperature_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetUseTemperature", SetUseTemperature_IsValid);
		SetUseIESBrightness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseIESBrightness");
		SetUseIESBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseIESBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseIESBrightness_bNewValue_PropertyAddress, SetUseIESBrightness_FunctionAddress, "bNewValue");
		SetUseIESBrightness_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetUseIESBrightness_FunctionAddress, "bNewValue");
		SetUseIESBrightness_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseIESBrightness_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetUseIESBrightness_IsValid = SetUseIESBrightness_FunctionAddress != IntPtr.Zero && SetUseIESBrightness_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetUseIESBrightness", SetUseIESBrightness_IsValid);
		SetTransmission_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTransmission");
		SetTransmission_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTransmission_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTransmission_bNewValue_PropertyAddress, SetTransmission_FunctionAddress, "bNewValue");
		SetTransmission_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetTransmission_FunctionAddress, "bNewValue");
		SetTransmission_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTransmission_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetTransmission_IsValid = SetTransmission_FunctionAddress != IntPtr.Zero && SetTransmission_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetTransmission", SetTransmission_IsValid);
		SetTemperature_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTemperature");
		SetTemperature_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTemperature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTemperature_NewTemperature_PropertyAddress, SetTemperature_FunctionAddress, "NewTemperature");
		SetTemperature_NewTemperature_Offset = NativeReflectionCached.GetPropertyOffset(SetTemperature_FunctionAddress, "NewTemperature");
		SetTemperature_NewTemperature_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTemperature_FunctionAddress, "NewTemperature", Classes.FFloatProperty);
		SetTemperature_IsValid = SetTemperature_FunctionAddress != IntPtr.Zero && SetTemperature_NewTemperature_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetTemperature", SetTemperature_IsValid);
		SetSpecularScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpecularScale");
		SetSpecularScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpecularScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpecularScale_NewValue_PropertyAddress, SetSpecularScale_FunctionAddress, "NewValue");
		SetSpecularScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSpecularScale_FunctionAddress, "NewValue");
		SetSpecularScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpecularScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetSpecularScale_IsValid = SetSpecularScale_FunctionAddress != IntPtr.Zero && SetSpecularScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetSpecularScale", SetSpecularScale_IsValid);
		SetShadowSlopeBias_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowSlopeBias");
		SetShadowSlopeBias_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowSlopeBias_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowSlopeBias_NewValue_PropertyAddress, SetShadowSlopeBias_FunctionAddress, "NewValue");
		SetShadowSlopeBias_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowSlopeBias_FunctionAddress, "NewValue");
		SetShadowSlopeBias_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowSlopeBias_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowSlopeBias_IsValid = SetShadowSlopeBias_FunctionAddress != IntPtr.Zero && SetShadowSlopeBias_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetShadowSlopeBias", SetShadowSlopeBias_IsValid);
		SetShadowBias_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowBias");
		SetShadowBias_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowBias_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowBias_NewValue_PropertyAddress, SetShadowBias_FunctionAddress, "NewValue");
		SetShadowBias_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowBias_FunctionAddress, "NewValue");
		SetShadowBias_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowBias_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowBias_IsValid = SetShadowBias_FunctionAddress != IntPtr.Zero && SetShadowBias_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetShadowBias", SetShadowBias_IsValid);
		SetNumWaterCausticsMapCascades_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNumWaterCausticsMapCascades");
		SetNumWaterCausticsMapCascades_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumWaterCausticsMapCascades_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumWaterCausticsMapCascades_NewValue_PropertyAddress, SetNumWaterCausticsMapCascades_FunctionAddress, "NewValue");
		SetNumWaterCausticsMapCascades_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetNumWaterCausticsMapCascades_FunctionAddress, "NewValue");
		SetNumWaterCausticsMapCascades_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumWaterCausticsMapCascades_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetNumWaterCausticsMapCascades_IsValid = SetNumWaterCausticsMapCascades_FunctionAddress != IntPtr.Zero && SetNumWaterCausticsMapCascades_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetNumWaterCausticsMapCascades", SetNumWaterCausticsMapCascades_IsValid);
		SetLightingChannels_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightingChannels");
		SetLightingChannels_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightingChannels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightingChannels_bChannel0_PropertyAddress, SetLightingChannels_FunctionAddress, "bChannel0");
		SetLightingChannels_bChannel0_Offset = NativeReflectionCached.GetPropertyOffset(SetLightingChannels_FunctionAddress, "bChannel0");
		SetLightingChannels_bChannel0_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightingChannels_FunctionAddress, "bChannel0", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLightingChannels_bChannel1_PropertyAddress, SetLightingChannels_FunctionAddress, "bChannel1");
		SetLightingChannels_bChannel1_Offset = NativeReflectionCached.GetPropertyOffset(SetLightingChannels_FunctionAddress, "bChannel1");
		SetLightingChannels_bChannel1_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightingChannels_FunctionAddress, "bChannel1", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLightingChannels_bChannel2_PropertyAddress, SetLightingChannels_FunctionAddress, "bChannel2");
		SetLightingChannels_bChannel2_Offset = NativeReflectionCached.GetPropertyOffset(SetLightingChannels_FunctionAddress, "bChannel2");
		SetLightingChannels_bChannel2_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightingChannels_FunctionAddress, "bChannel2", Classes.FBoolProperty);
		SetLightingChannels_IsValid = SetLightingChannels_FunctionAddress != IntPtr.Zero && SetLightingChannels_bChannel0_IsValid && SetLightingChannels_bChannel1_IsValid && SetLightingChannels_bChannel2_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetLightingChannels", SetLightingChannels_IsValid);
		SetLightFunctionScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightFunctionScale");
		SetLightFunctionScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightFunctionScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightFunctionScale_NewLightFunctionScale_PropertyAddress, SetLightFunctionScale_FunctionAddress, "NewLightFunctionScale");
		SetLightFunctionScale_NewLightFunctionScale_Offset = NativeReflectionCached.GetPropertyOffset(SetLightFunctionScale_FunctionAddress, "NewLightFunctionScale");
		SetLightFunctionScale_NewLightFunctionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightFunctionScale_FunctionAddress, "NewLightFunctionScale", Classes.FStructProperty);
		SetLightFunctionScale_IsValid = SetLightFunctionScale_FunctionAddress != IntPtr.Zero && SetLightFunctionScale_NewLightFunctionScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetLightFunctionScale", SetLightFunctionScale_IsValid);
		SetLightFunctionMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightFunctionMaterial");
		SetLightFunctionMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightFunctionMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightFunctionMaterial_NewLightFunctionMaterial_PropertyAddress, SetLightFunctionMaterial_FunctionAddress, "NewLightFunctionMaterial");
		SetLightFunctionMaterial_NewLightFunctionMaterial_Offset = NativeReflectionCached.GetPropertyOffset(SetLightFunctionMaterial_FunctionAddress, "NewLightFunctionMaterial");
		SetLightFunctionMaterial_NewLightFunctionMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightFunctionMaterial_FunctionAddress, "NewLightFunctionMaterial", Classes.FObjectProperty);
		SetLightFunctionMaterial_IsValid = SetLightFunctionMaterial_FunctionAddress != IntPtr.Zero && SetLightFunctionMaterial_NewLightFunctionMaterial_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetLightFunctionMaterial", SetLightFunctionMaterial_IsValid);
		SetLightFunctionFadeDistance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightFunctionFadeDistance");
		SetLightFunctionFadeDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightFunctionFadeDistance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_PropertyAddress, SetLightFunctionFadeDistance_FunctionAddress, "NewLightFunctionFadeDistance");
		SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_Offset = NativeReflectionCached.GetPropertyOffset(SetLightFunctionFadeDistance_FunctionAddress, "NewLightFunctionFadeDistance");
		SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightFunctionFadeDistance_FunctionAddress, "NewLightFunctionFadeDistance", Classes.FFloatProperty);
		SetLightFunctionFadeDistance_IsValid = SetLightFunctionFadeDistance_FunctionAddress != IntPtr.Zero && SetLightFunctionFadeDistance_NewLightFunctionFadeDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetLightFunctionFadeDistance", SetLightFunctionFadeDistance_IsValid);
		SetLightFunctionDisabledBrightness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightFunctionDisabledBrightness");
		SetLightFunctionDisabledBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightFunctionDisabledBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightFunctionDisabledBrightness_NewValue_PropertyAddress, SetLightFunctionDisabledBrightness_FunctionAddress, "NewValue");
		SetLightFunctionDisabledBrightness_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLightFunctionDisabledBrightness_FunctionAddress, "NewValue");
		SetLightFunctionDisabledBrightness_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightFunctionDisabledBrightness_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetLightFunctionDisabledBrightness_IsValid = SetLightFunctionDisabledBrightness_FunctionAddress != IntPtr.Zero && SetLightFunctionDisabledBrightness_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetLightFunctionDisabledBrightness", SetLightFunctionDisabledBrightness_IsValid);
		SetLightColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightColor");
		SetLightColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightColor_NewLightColor_PropertyAddress, SetLightColor_FunctionAddress, "NewLightColor");
		SetLightColor_NewLightColor_Offset = NativeReflectionCached.GetPropertyOffset(SetLightColor_FunctionAddress, "NewLightColor");
		SetLightColor_NewLightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightColor_FunctionAddress, "NewLightColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLightColor_bSRGB_PropertyAddress, SetLightColor_FunctionAddress, "bSRGB");
		SetLightColor_bSRGB_Offset = NativeReflectionCached.GetPropertyOffset(SetLightColor_FunctionAddress, "bSRGB");
		SetLightColor_bSRGB_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightColor_FunctionAddress, "bSRGB", Classes.FBoolProperty);
		SetLightColor_IsValid = SetLightColor_FunctionAddress != IntPtr.Zero && SetLightColor_NewLightColor_IsValid && SetLightColor_bSRGB_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetLightColor", SetLightColor_IsValid);
		SetIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIntensity");
		SetIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIntensity_NewIntensity_PropertyAddress, SetIntensity_FunctionAddress, "NewIntensity");
		SetIntensity_NewIntensity_Offset = NativeReflectionCached.GetPropertyOffset(SetIntensity_FunctionAddress, "NewIntensity");
		SetIntensity_NewIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIntensity_FunctionAddress, "NewIntensity", Classes.FFloatProperty);
		SetIntensity_IsValid = SetIntensity_FunctionAddress != IntPtr.Zero && SetIntensity_NewIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetIntensity", SetIntensity_IsValid);
		SetIndirectLightingIntensity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIndirectLightingIntensity");
		SetIndirectLightingIntensity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIndirectLightingIntensity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIndirectLightingIntensity_NewIntensity_PropertyAddress, SetIndirectLightingIntensity_FunctionAddress, "NewIntensity");
		SetIndirectLightingIntensity_NewIntensity_Offset = NativeReflectionCached.GetPropertyOffset(SetIndirectLightingIntensity_FunctionAddress, "NewIntensity");
		SetIndirectLightingIntensity_NewIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIndirectLightingIntensity_FunctionAddress, "NewIntensity", Classes.FFloatProperty);
		SetIndirectLightingIntensity_IsValid = SetIndirectLightingIntensity_FunctionAddress != IntPtr.Zero && SetIndirectLightingIntensity_NewIntensity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetIndirectLightingIntensity", SetIndirectLightingIntensity_IsValid);
		SetIESTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIESTexture");
		SetIESTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIESTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIESTexture_NewValue_PropertyAddress, SetIESTexture_FunctionAddress, "NewValue");
		SetIESTexture_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetIESTexture_FunctionAddress, "NewValue");
		SetIESTexture_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIESTexture_FunctionAddress, "NewValue", Classes.FObjectProperty);
		SetIESTexture_IsValid = SetIESTexture_FunctionAddress != IntPtr.Zero && SetIESTexture_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetIESTexture", SetIESTexture_IsValid);
		SetIESBrightnessScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIESBrightnessScale");
		SetIESBrightnessScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIESBrightnessScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIESBrightnessScale_NewValue_PropertyAddress, SetIESBrightnessScale_FunctionAddress, "NewValue");
		SetIESBrightnessScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetIESBrightnessScale_FunctionAddress, "NewValue");
		SetIESBrightnessScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIESBrightnessScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetIESBrightnessScale_IsValid = SetIESBrightnessScale_FunctionAddress != IntPtr.Zero && SetIESBrightnessScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetIESBrightnessScale", SetIESBrightnessScale_IsValid);
		SetForceCachedShadowsForMovablePrimitives_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetForceCachedShadowsForMovablePrimitives");
		SetForceCachedShadowsForMovablePrimitives_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForceCachedShadowsForMovablePrimitives_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForceCachedShadowsForMovablePrimitives_bNewValue_PropertyAddress, SetForceCachedShadowsForMovablePrimitives_FunctionAddress, "bNewValue");
		SetForceCachedShadowsForMovablePrimitives_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetForceCachedShadowsForMovablePrimitives_FunctionAddress, "bNewValue");
		SetForceCachedShadowsForMovablePrimitives_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForceCachedShadowsForMovablePrimitives_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetForceCachedShadowsForMovablePrimitives_IsValid = SetForceCachedShadowsForMovablePrimitives_FunctionAddress != IntPtr.Zero && SetForceCachedShadowsForMovablePrimitives_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetForceCachedShadowsForMovablePrimitives", SetForceCachedShadowsForMovablePrimitives_IsValid);
		SetEnableLightShaftBloom_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableLightShaftBloom");
		SetEnableLightShaftBloom_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableLightShaftBloom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableLightShaftBloom_bNewValue_PropertyAddress, SetEnableLightShaftBloom_FunctionAddress, "bNewValue");
		SetEnableLightShaftBloom_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableLightShaftBloom_FunctionAddress, "bNewValue");
		SetEnableLightShaftBloom_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableLightShaftBloom_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetEnableLightShaftBloom_IsValid = SetEnableLightShaftBloom_FunctionAddress != IntPtr.Zero && SetEnableLightShaftBloom_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetEnableLightShaftBloom", SetEnableLightShaftBloom_IsValid);
		SetBloomTint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBloomTint");
		SetBloomTint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBloomTint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBloomTint_NewValue_PropertyAddress, SetBloomTint_FunctionAddress, "NewValue");
		SetBloomTint_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBloomTint_FunctionAddress, "NewValue");
		SetBloomTint_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBloomTint_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetBloomTint_IsValid = SetBloomTint_FunctionAddress != IntPtr.Zero && SetBloomTint_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetBloomTint", SetBloomTint_IsValid);
		SetBloomThreshold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBloomThreshold");
		SetBloomThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBloomThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBloomThreshold_NewValue_PropertyAddress, SetBloomThreshold_FunctionAddress, "NewValue");
		SetBloomThreshold_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBloomThreshold_FunctionAddress, "NewValue");
		SetBloomThreshold_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBloomThreshold_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetBloomThreshold_IsValid = SetBloomThreshold_FunctionAddress != IntPtr.Zero && SetBloomThreshold_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetBloomThreshold", SetBloomThreshold_IsValid);
		SetBloomScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBloomScale");
		SetBloomScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBloomScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBloomScale_NewValue_PropertyAddress, SetBloomScale_FunctionAddress, "NewValue");
		SetBloomScale_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBloomScale_FunctionAddress, "NewValue");
		SetBloomScale_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBloomScale_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetBloomScale_IsValid = SetBloomScale_FunctionAddress != IntPtr.Zero && SetBloomScale_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetBloomScale", SetBloomScale_IsValid);
		SetBloomMaxBrightness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBloomMaxBrightness");
		SetBloomMaxBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBloomMaxBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBloomMaxBrightness_NewValue_PropertyAddress, SetBloomMaxBrightness_FunctionAddress, "NewValue");
		SetBloomMaxBrightness_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBloomMaxBrightness_FunctionAddress, "NewValue");
		SetBloomMaxBrightness_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBloomMaxBrightness_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetBloomMaxBrightness_IsValid = SetBloomMaxBrightness_FunctionAddress != IntPtr.Zero && SetBloomMaxBrightness_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetBloomMaxBrightness", SetBloomMaxBrightness_IsValid);
		SetAffectWaterCaustics_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAffectWaterCaustics");
		SetAffectWaterCaustics_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAffectWaterCaustics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAffectWaterCaustics_bNewValue_PropertyAddress, SetAffectWaterCaustics_FunctionAddress, "bNewValue");
		SetAffectWaterCaustics_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAffectWaterCaustics_FunctionAddress, "bNewValue");
		SetAffectWaterCaustics_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAffectWaterCaustics_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetAffectWaterCaustics_IsValid = SetAffectWaterCaustics_FunctionAddress != IntPtr.Zero && SetAffectWaterCaustics_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetAffectWaterCaustics", SetAffectWaterCaustics_IsValid);
		SetAffectTranslucentLighting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAffectTranslucentLighting");
		SetAffectTranslucentLighting_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAffectTranslucentLighting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAffectTranslucentLighting_bNewValue_PropertyAddress, SetAffectTranslucentLighting_FunctionAddress, "bNewValue");
		SetAffectTranslucentLighting_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAffectTranslucentLighting_FunctionAddress, "bNewValue");
		SetAffectTranslucentLighting_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAffectTranslucentLighting_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetAffectTranslucentLighting_IsValid = SetAffectTranslucentLighting_FunctionAddress != IntPtr.Zero && SetAffectTranslucentLighting_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetAffectTranslucentLighting", SetAffectTranslucentLighting_IsValid);
		SetAffectDynamicIndirectLighting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAffectDynamicIndirectLighting");
		SetAffectDynamicIndirectLighting_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAffectDynamicIndirectLighting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAffectDynamicIndirectLighting_bNewValue_PropertyAddress, SetAffectDynamicIndirectLighting_FunctionAddress, "bNewValue");
		SetAffectDynamicIndirectLighting_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAffectDynamicIndirectLighting_FunctionAddress, "bNewValue");
		SetAffectDynamicIndirectLighting_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAffectDynamicIndirectLighting_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetAffectDynamicIndirectLighting_IsValid = SetAffectDynamicIndirectLighting_FunctionAddress != IntPtr.Zero && SetAffectDynamicIndirectLighting_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.LightComponent:SetAffectDynamicIndirectLighting", SetAffectDynamicIndirectLighting_IsValid);
	}
}
