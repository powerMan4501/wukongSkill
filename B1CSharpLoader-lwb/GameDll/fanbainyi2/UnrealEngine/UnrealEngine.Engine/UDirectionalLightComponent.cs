using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.DirectionalLightComponent", "Engine", UnrealModuleType.Engine)]
public class UDirectionalLightComponent : ULightComponent
{
	private static bool ShadowCascadeBiasDistribution_IsValid;

	private static int ShadowCascadeBiasDistribution_Offset;

	private static bool EnableLightShaftOcclusion_IsValid;

	private static FFieldAddress EnableLightShaftOcclusion_PropertyAddress;

	private static int EnableLightShaftOcclusion_Offset;

	private static bool OcclusionMaskDarkness_IsValid;

	private static int OcclusionMaskDarkness_Offset;

	private static bool OcclusionDepthRange_IsValid;

	private static int OcclusionDepthRange_Offset;

	private static bool LightShaftOverrideDirection_IsValid;

	private static int LightShaftOverrideDirection_Offset;

	private static bool DynamicShadowDistanceMovableLight_IsValid;

	private static int DynamicShadowDistanceMovableLight_Offset;

	private static bool DynamicShadowDistanceStationaryLight_IsValid;

	private static int DynamicShadowDistanceStationaryLight_Offset;

	private static bool DynamicShadowCascades_IsValid;

	private static int DynamicShadowCascades_Offset;

	private static bool CascadeDistributionExponent_IsValid;

	private static int CascadeDistributionExponent_Offset;

	private static bool CascadeTransitionFraction_IsValid;

	private static int CascadeTransitionFraction_Offset;

	private static bool ShadowDistanceFadeoutFraction_IsValid;

	private static int ShadowDistanceFadeoutFraction_Offset;

	private static bool UseInsetShadowsForMovableObjects_IsValid;

	private static FFieldAddress UseInsetShadowsForMovableObjects_PropertyAddress;

	private static int UseInsetShadowsForMovableObjects_Offset;

	private static bool FarShadowCascadeCount_IsValid;

	private static int FarShadowCascadeCount_Offset;

	private static bool FarShadowDistance_IsValid;

	private static int FarShadowDistance_Offset;

	private static bool DistanceFieldShadowDistance_IsValid;

	private static int DistanceFieldShadowDistance_Offset;

	private static bool LightSourceAngle_IsValid;

	private static int LightSourceAngle_Offset;

	private static bool LightSourceSoftAngle_IsValid;

	private static int LightSourceSoftAngle_Offset;

	private static bool ShadowSourceAngleFactor_IsValid;

	private static int ShadowSourceAngleFactor_Offset;

	private static bool TraceDistance_IsValid;

	private static int TraceDistance_Offset;

	private static bool AtmosphereSunLight_IsValid;

	private static FFieldAddress AtmosphereSunLight_PropertyAddress;

	private static int AtmosphereSunLight_Offset;

	private static bool AtmosphereSunLightIndex_IsValid;

	private static int AtmosphereSunLightIndex_Offset;

	private static bool AtmosphereSunDiskColorScale_IsValid;

	private static int AtmosphereSunDiskColorScale_Offset;

	private static bool PerPixelAtmosphereTransmittance_IsValid;

	private static FFieldAddress PerPixelAtmosphereTransmittance_PropertyAddress;

	private static int PerPixelAtmosphereTransmittance_Offset;

	private static bool CastShadowsOnClouds_IsValid;

	private static FFieldAddress CastShadowsOnClouds_PropertyAddress;

	private static int CastShadowsOnClouds_Offset;

	private static bool CastShadowsOnAtmosphere_IsValid;

	private static FFieldAddress CastShadowsOnAtmosphere_PropertyAddress;

	private static int CastShadowsOnAtmosphere_Offset;

	private static bool CastCloudShadows_IsValid;

	private static FFieldAddress CastCloudShadows_PropertyAddress;

	private static int CastCloudShadows_Offset;

	private static bool CloudShadowStrength_IsValid;

	private static int CloudShadowStrength_Offset;

	private static bool CloudShadowOnAtmosphereStrength_IsValid;

	private static int CloudShadowOnAtmosphereStrength_Offset;

	private static bool CloudShadowOnSurfaceStrength_IsValid;

	private static int CloudShadowOnSurfaceStrength_Offset;

	private static bool CloudShadowDepthBias_IsValid;

	private static int CloudShadowDepthBias_Offset;

	private static bool CloudShadowExtent_IsValid;

	private static int CloudShadowExtent_Offset;

	private static bool CloudShadowMapResolutionScale_IsValid;

	private static int CloudShadowMapResolutionScale_Offset;

	private static bool CloudShadowRaySampleCountScale_IsValid;

	private static int CloudShadowRaySampleCountScale_Offset;

	private static bool CloudScatteredLuminanceScale_IsValid;

	private static int CloudScatteredLuminanceScale_Offset;

	private static bool CastModulatedShadows_IsValid;

	private static FFieldAddress CastModulatedShadows_PropertyAddress;

	private static int CastModulatedShadows_Offset;

	private static bool ModulatedShadowColor_IsValid;

	private static int ModulatedShadowColor_Offset;

	private static bool ShadowAmount_IsValid;

	private static int ShadowAmount_Offset;

	private static bool RTShadowPositionOffset_IsValid;

	private static int RTShadowPositionOffset_Offset;

	private static bool SetShadowSourceAngleFactor_IsValid;

	private static IntPtr SetShadowSourceAngleFactor_FunctionAddress;

	private static int SetShadowSourceAngleFactor_ParamsSize;

	private static bool SetShadowSourceAngleFactor_NewValue_IsValid;

	private static FFieldAddress SetShadowSourceAngleFactor_NewValue_PropertyAddress;

	private static int SetShadowSourceAngleFactor_NewValue_Offset;

	private static bool SetShadowDistanceFadeoutFraction_IsValid;

	private static IntPtr SetShadowDistanceFadeoutFraction_FunctionAddress;

	private static int SetShadowDistanceFadeoutFraction_ParamsSize;

	private static bool SetShadowDistanceFadeoutFraction_NewValue_IsValid;

	private static FFieldAddress SetShadowDistanceFadeoutFraction_NewValue_PropertyAddress;

	private static int SetShadowDistanceFadeoutFraction_NewValue_Offset;

	private static bool SetShadowCascadeBiasDistribution_IsValid;

	private static IntPtr SetShadowCascadeBiasDistribution_FunctionAddress;

	private static int SetShadowCascadeBiasDistribution_ParamsSize;

	private static bool SetShadowCascadeBiasDistribution_NewValue_IsValid;

	private static FFieldAddress SetShadowCascadeBiasDistribution_NewValue_PropertyAddress;

	private static int SetShadowCascadeBiasDistribution_NewValue_Offset;

	private static bool SetShadowAmount_IsValid;

	private static IntPtr SetShadowAmount_FunctionAddress;

	private static int SetShadowAmount_ParamsSize;

	private static bool SetShadowAmount_NewValue_IsValid;

	private static FFieldAddress SetShadowAmount_NewValue_PropertyAddress;

	private static int SetShadowAmount_NewValue_Offset;

	private static bool SetOcclusionMaskDarkness_IsValid;

	private static IntPtr SetOcclusionMaskDarkness_FunctionAddress;

	private static int SetOcclusionMaskDarkness_ParamsSize;

	private static bool SetOcclusionMaskDarkness_NewValue_IsValid;

	private static FFieldAddress SetOcclusionMaskDarkness_NewValue_PropertyAddress;

	private static int SetOcclusionMaskDarkness_NewValue_Offset;

	private static bool SetOcclusionDepthRange_IsValid;

	private static IntPtr SetOcclusionDepthRange_FunctionAddress;

	private static int SetOcclusionDepthRange_ParamsSize;

	private static bool SetOcclusionDepthRange_NewValue_IsValid;

	private static FFieldAddress SetOcclusionDepthRange_NewValue_PropertyAddress;

	private static int SetOcclusionDepthRange_NewValue_Offset;

	private static bool SetLightSourceSoftAngle_IsValid;

	private static IntPtr SetLightSourceSoftAngle_FunctionAddress;

	private static int SetLightSourceSoftAngle_ParamsSize;

	private static bool SetLightSourceSoftAngle_NewValue_IsValid;

	private static FFieldAddress SetLightSourceSoftAngle_NewValue_PropertyAddress;

	private static int SetLightSourceSoftAngle_NewValue_Offset;

	private static bool SetLightSourceAngle_IsValid;

	private static IntPtr SetLightSourceAngle_FunctionAddress;

	private static int SetLightSourceAngle_ParamsSize;

	private static bool SetLightSourceAngle_NewValue_IsValid;

	private static FFieldAddress SetLightSourceAngle_NewValue_PropertyAddress;

	private static int SetLightSourceAngle_NewValue_Offset;

	private static bool SetLightShaftOverrideDirection_IsValid;

	private static IntPtr SetLightShaftOverrideDirection_FunctionAddress;

	private static int SetLightShaftOverrideDirection_ParamsSize;

	private static bool SetLightShaftOverrideDirection_NewValue_IsValid;

	private static FFieldAddress SetLightShaftOverrideDirection_NewValue_PropertyAddress;

	private static int SetLightShaftOverrideDirection_NewValue_Offset;

	private static bool SetEnableLightShaftOcclusion_IsValid;

	private static IntPtr SetEnableLightShaftOcclusion_FunctionAddress;

	private static int SetEnableLightShaftOcclusion_ParamsSize;

	private static bool SetEnableLightShaftOcclusion_bNewValue_IsValid;

	private static FFieldAddress SetEnableLightShaftOcclusion_bNewValue_PropertyAddress;

	private static int SetEnableLightShaftOcclusion_bNewValue_Offset;

	private static bool SetDynamicShadowDistanceStationaryLight_IsValid;

	private static IntPtr SetDynamicShadowDistanceStationaryLight_FunctionAddress;

	private static int SetDynamicShadowDistanceStationaryLight_ParamsSize;

	private static bool SetDynamicShadowDistanceStationaryLight_NewValue_IsValid;

	private static FFieldAddress SetDynamicShadowDistanceStationaryLight_NewValue_PropertyAddress;

	private static int SetDynamicShadowDistanceStationaryLight_NewValue_Offset;

	private static bool SetDynamicShadowDistanceMovableLight_IsValid;

	private static IntPtr SetDynamicShadowDistanceMovableLight_FunctionAddress;

	private static int SetDynamicShadowDistanceMovableLight_ParamsSize;

	private static bool SetDynamicShadowDistanceMovableLight_NewValue_IsValid;

	private static FFieldAddress SetDynamicShadowDistanceMovableLight_NewValue_PropertyAddress;

	private static int SetDynamicShadowDistanceMovableLight_NewValue_Offset;

	private static bool SetDynamicShadowCascades_IsValid;

	private static IntPtr SetDynamicShadowCascades_FunctionAddress;

	private static int SetDynamicShadowCascades_ParamsSize;

	private static bool SetDynamicShadowCascades_NewValue_IsValid;

	private static FFieldAddress SetDynamicShadowCascades_NewValue_PropertyAddress;

	private static int SetDynamicShadowCascades_NewValue_Offset;

	private static bool SetCascadeTransitionFraction_IsValid;

	private static IntPtr SetCascadeTransitionFraction_FunctionAddress;

	private static int SetCascadeTransitionFraction_ParamsSize;

	private static bool SetCascadeTransitionFraction_NewValue_IsValid;

	private static FFieldAddress SetCascadeTransitionFraction_NewValue_PropertyAddress;

	private static int SetCascadeTransitionFraction_NewValue_Offset;

	private static bool SetCascadeDistributionExponent_IsValid;

	private static IntPtr SetCascadeDistributionExponent_FunctionAddress;

	private static int SetCascadeDistributionExponent_ParamsSize;

	private static bool SetCascadeDistributionExponent_NewValue_IsValid;

	private static FFieldAddress SetCascadeDistributionExponent_NewValue_PropertyAddress;

	private static int SetCascadeDistributionExponent_NewValue_Offset;

	private static bool SetAtmosphereSunLightIndex_IsValid;

	private static IntPtr SetAtmosphereSunLightIndex_FunctionAddress;

	private static int SetAtmosphereSunLightIndex_ParamsSize;

	private static bool SetAtmosphereSunLightIndex_NewValue_IsValid;

	private static FFieldAddress SetAtmosphereSunLightIndex_NewValue_PropertyAddress;

	private static int SetAtmosphereSunLightIndex_NewValue_Offset;

	private static bool SetAtmosphereSunLight_IsValid;

	private static IntPtr SetAtmosphereSunLight_FunctionAddress;

	private static int SetAtmosphereSunLight_ParamsSize;

	private static bool SetAtmosphereSunLight_bNewValue_IsValid;

	private static FFieldAddress SetAtmosphereSunLight_bNewValue_PropertyAddress;

	private static int SetAtmosphereSunLight_bNewValue_Offset;

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:ShadowCascadeBiasDistribution")]
	public float ShadowCascadeBiasDistribution
	{
		get
		{
			CheckDestroyed();
			if (!ShadowCascadeBiasDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowCascadeBiasDistribution");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowCascadeBiasDistribution_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowCascadeBiasDistribution_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowCascadeBiasDistribution");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowCascadeBiasDistribution_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755476750467093uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bEnableLightShaftOcclusion")]
	public bool EnableLightShaftOcclusion
	{
		get
		{
			CheckDestroyed();
			if (!EnableLightShaftOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bEnableLightShaftOcclusion");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableLightShaftOcclusion_Offset), 0, EnableLightShaftOcclusion_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableLightShaftOcclusion_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bEnableLightShaftOcclusion");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableLightShaftOcclusion_Offset), 0, EnableLightShaftOcclusion_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:OcclusionMaskDarkness")]
	public float OcclusionMaskDarkness
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionMaskDarkness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:OcclusionMaskDarkness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OcclusionMaskDarkness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionMaskDarkness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:OcclusionMaskDarkness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OcclusionMaskDarkness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:OcclusionDepthRange")]
	public float OcclusionDepthRange
	{
		get
		{
			CheckDestroyed();
			if (!OcclusionDepthRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:OcclusionDepthRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OcclusionDepthRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OcclusionDepthRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:OcclusionDepthRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OcclusionDepthRange_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:LightShaftOverrideDirection")]
	public FVector LightShaftOverrideDirection
	{
		get
		{
			CheckDestroyed();
			if (!LightShaftOverrideDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:LightShaftOverrideDirection");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LightShaftOverrideDirection_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightShaftOverrideDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:LightShaftOverrideDirection");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LightShaftOverrideDirection_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:DynamicShadowDistanceMovableLight")]
	public float DynamicShadowDistanceMovableLight
	{
		get
		{
			CheckDestroyed();
			if (!DynamicShadowDistanceMovableLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DynamicShadowDistanceMovableLight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DynamicShadowDistanceMovableLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DynamicShadowDistanceMovableLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DynamicShadowDistanceMovableLight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DynamicShadowDistanceMovableLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:DynamicShadowDistanceStationaryLight")]
	public float DynamicShadowDistanceStationaryLight
	{
		get
		{
			CheckDestroyed();
			if (!DynamicShadowDistanceStationaryLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DynamicShadowDistanceStationaryLight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DynamicShadowDistanceStationaryLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DynamicShadowDistanceStationaryLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DynamicShadowDistanceStationaryLight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DynamicShadowDistanceStationaryLight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:DynamicShadowCascades")]
	public int DynamicShadowCascades
	{
		get
		{
			CheckDestroyed();
			if (!DynamicShadowCascades_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DynamicShadowCascades");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DynamicShadowCascades_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DynamicShadowCascades_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DynamicShadowCascades");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DynamicShadowCascades_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CascadeDistributionExponent")]
	public float CascadeDistributionExponent
	{
		get
		{
			CheckDestroyed();
			if (!CascadeDistributionExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CascadeDistributionExponent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CascadeDistributionExponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CascadeDistributionExponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CascadeDistributionExponent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CascadeDistributionExponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CascadeTransitionFraction")]
	public float CascadeTransitionFraction
	{
		get
		{
			CheckDestroyed();
			if (!CascadeTransitionFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CascadeTransitionFraction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CascadeTransitionFraction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CascadeTransitionFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CascadeTransitionFraction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CascadeTransitionFraction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:ShadowDistanceFadeoutFraction")]
	public float ShadowDistanceFadeoutFraction
	{
		get
		{
			CheckDestroyed();
			if (!ShadowDistanceFadeoutFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowDistanceFadeoutFraction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowDistanceFadeoutFraction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowDistanceFadeoutFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowDistanceFadeoutFraction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowDistanceFadeoutFraction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bUseInsetShadowsForMovableObjects")]
	public bool UseInsetShadowsForMovableObjects
	{
		get
		{
			CheckDestroyed();
			if (!UseInsetShadowsForMovableObjects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bUseInsetShadowsForMovableObjects");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseInsetShadowsForMovableObjects_Offset), 0, UseInsetShadowsForMovableObjects_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseInsetShadowsForMovableObjects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bUseInsetShadowsForMovableObjects");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseInsetShadowsForMovableObjects_Offset), 0, UseInsetShadowsForMovableObjects_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:FarShadowCascadeCount")]
	public int FarShadowCascadeCount
	{
		get
		{
			CheckDestroyed();
			if (!FarShadowCascadeCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:FarShadowCascadeCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FarShadowCascadeCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FarShadowCascadeCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:FarShadowCascadeCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FarShadowCascadeCount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:FarShadowDistance")]
	public float FarShadowDistance
	{
		get
		{
			CheckDestroyed();
			if (!FarShadowDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:FarShadowDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FarShadowDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FarShadowDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:FarShadowDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FarShadowDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:DistanceFieldShadowDistance")]
	public float DistanceFieldShadowDistance
	{
		get
		{
			CheckDestroyed();
			if (!DistanceFieldShadowDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DistanceFieldShadowDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceFieldShadowDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceFieldShadowDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:DistanceFieldShadowDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceFieldShadowDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:LightSourceAngle")]
	public float LightSourceAngle
	{
		get
		{
			CheckDestroyed();
			if (!LightSourceAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:LightSourceAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LightSourceAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightSourceAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:LightSourceAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LightSourceAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:LightSourceSoftAngle")]
	public float LightSourceSoftAngle
	{
		get
		{
			CheckDestroyed();
			if (!LightSourceSoftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:LightSourceSoftAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LightSourceSoftAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightSourceSoftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:LightSourceSoftAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LightSourceSoftAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:ShadowSourceAngleFactor")]
	public float ShadowSourceAngleFactor
	{
		get
		{
			CheckDestroyed();
			if (!ShadowSourceAngleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowSourceAngleFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowSourceAngleFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowSourceAngleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowSourceAngleFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowSourceAngleFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:TraceDistance")]
	public float TraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:TraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:TraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bAtmosphereSunLight")]
	public bool AtmosphereSunLight
	{
		get
		{
			CheckDestroyed();
			if (!AtmosphereSunLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bAtmosphereSunLight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AtmosphereSunLight_Offset), 0, AtmosphereSunLight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AtmosphereSunLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bAtmosphereSunLight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AtmosphereSunLight_Offset), 0, AtmosphereSunLight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:AtmosphereSunLightIndex")]
	public int AtmosphereSunLightIndex
	{
		get
		{
			CheckDestroyed();
			if (!AtmosphereSunLightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:AtmosphereSunLightIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AtmosphereSunLightIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtmosphereSunLightIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:AtmosphereSunLightIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AtmosphereSunLightIndex_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:AtmosphereSunDiskColorScale")]
	public FLinearColor AtmosphereSunDiskColorScale
	{
		get
		{
			CheckDestroyed();
			if (!AtmosphereSunDiskColorScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:AtmosphereSunDiskColorScale");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, AtmosphereSunDiskColorScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtmosphereSunDiskColorScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:AtmosphereSunDiskColorScale");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, AtmosphereSunDiskColorScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bPerPixelAtmosphereTransmittance")]
	public bool PerPixelAtmosphereTransmittance
	{
		get
		{
			CheckDestroyed();
			if (!PerPixelAtmosphereTransmittance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bPerPixelAtmosphereTransmittance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PerPixelAtmosphereTransmittance_Offset), 0, PerPixelAtmosphereTransmittance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PerPixelAtmosphereTransmittance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bPerPixelAtmosphereTransmittance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PerPixelAtmosphereTransmittance_Offset), 0, PerPixelAtmosphereTransmittance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bCastShadowsOnClouds")]
	public bool CastShadowsOnClouds
	{
		get
		{
			CheckDestroyed();
			if (!CastShadowsOnClouds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastShadowsOnClouds");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadowsOnClouds_Offset), 0, CastShadowsOnClouds_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadowsOnClouds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastShadowsOnClouds");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadowsOnClouds_Offset), 0, CastShadowsOnClouds_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bCastShadowsOnAtmosphere")]
	public bool CastShadowsOnAtmosphere
	{
		get
		{
			CheckDestroyed();
			if (!CastShadowsOnAtmosphere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastShadowsOnAtmosphere");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastShadowsOnAtmosphere_Offset), 0, CastShadowsOnAtmosphere_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastShadowsOnAtmosphere_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastShadowsOnAtmosphere");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastShadowsOnAtmosphere_Offset), 0, CastShadowsOnAtmosphere_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bCastCloudShadows")]
	public bool CastCloudShadows
	{
		get
		{
			CheckDestroyed();
			if (!CastCloudShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastCloudShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastCloudShadows_Offset), 0, CastCloudShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastCloudShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastCloudShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastCloudShadows_Offset), 0, CastCloudShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudShadowStrength")]
	public float CloudShadowStrength
	{
		get
		{
			CheckDestroyed();
			if (!CloudShadowStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudShadowStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudShadowStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudShadowStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudShadowOnAtmosphereStrength")]
	public float CloudShadowOnAtmosphereStrength
	{
		get
		{
			CheckDestroyed();
			if (!CloudShadowOnAtmosphereStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowOnAtmosphereStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudShadowOnAtmosphereStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudShadowOnAtmosphereStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowOnAtmosphereStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudShadowOnAtmosphereStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudShadowOnSurfaceStrength")]
	public float CloudShadowOnSurfaceStrength
	{
		get
		{
			CheckDestroyed();
			if (!CloudShadowOnSurfaceStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowOnSurfaceStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudShadowOnSurfaceStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudShadowOnSurfaceStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowOnSurfaceStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudShadowOnSurfaceStrength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudShadowDepthBias")]
	public float CloudShadowDepthBias
	{
		get
		{
			CheckDestroyed();
			if (!CloudShadowDepthBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowDepthBias");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudShadowDepthBias_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudShadowDepthBias_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowDepthBias");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudShadowDepthBias_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudShadowExtent")]
	public float CloudShadowExtent
	{
		get
		{
			CheckDestroyed();
			if (!CloudShadowExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowExtent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudShadowExtent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudShadowExtent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowExtent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudShadowExtent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudShadowMapResolutionScale")]
	public float CloudShadowMapResolutionScale
	{
		get
		{
			CheckDestroyed();
			if (!CloudShadowMapResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowMapResolutionScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudShadowMapResolutionScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudShadowMapResolutionScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowMapResolutionScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudShadowMapResolutionScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudShadowRaySampleCountScale")]
	public float CloudShadowRaySampleCountScale
	{
		get
		{
			CheckDestroyed();
			if (!CloudShadowRaySampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowRaySampleCountScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CloudShadowRaySampleCountScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudShadowRaySampleCountScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudShadowRaySampleCountScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CloudShadowRaySampleCountScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209429uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:CloudScatteredLuminanceScale")]
	public FLinearColor CloudScatteredLuminanceScale
	{
		get
		{
			CheckDestroyed();
			if (!CloudScatteredLuminanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudScatteredLuminanceScale");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, CloudScatteredLuminanceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CloudScatteredLuminanceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:CloudScatteredLuminanceScale");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, CloudScatteredLuminanceScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:bCastModulatedShadows")]
	public bool CastModulatedShadows
	{
		get
		{
			CheckDestroyed();
			if (!CastModulatedShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastModulatedShadows");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CastModulatedShadows_Offset), 0, CastModulatedShadows_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CastModulatedShadows_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:bCastModulatedShadows");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CastModulatedShadows_Offset), 0, CastModulatedShadows_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:ModulatedShadowColor")]
	public FColor ModulatedShadowColor
	{
		get
		{
			CheckDestroyed();
			if (!ModulatedShadowColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ModulatedShadowColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, ModulatedShadowColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ModulatedShadowColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ModulatedShadowColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, ModulatedShadowColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:ShadowAmount")]
	public float ShadowAmount
	{
		get
		{
			CheckDestroyed();
			if (!ShadowAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowAmount");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ShadowAmount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShadowAmount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:ShadowAmount");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ShadowAmount_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759875870720533uL)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:RTShadowPositionOffset")]
	public float RTShadowPositionOffset
	{
		get
		{
			CheckDestroyed();
			if (!RTShadowPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:RTShadowPositionOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RTShadowPositionOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RTShadowPositionOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DirectionalLightComponent:RTShadowPositionOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RTShadowPositionOffset_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetShadowSourceAngleFactor")]
	public unsafe void SetShadowSourceAngleFactor(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowSourceAngleFactor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetShadowSourceAngleFactor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowSourceAngleFactor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowSourceAngleFactor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowSourceAngleFactor_NewValue_Offset), 0, SetShadowSourceAngleFactor_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowSourceAngleFactor_FunctionAddress, intPtr, SetShadowSourceAngleFactor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetShadowDistanceFadeoutFraction")]
	public unsafe void SetShadowDistanceFadeoutFraction(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowDistanceFadeoutFraction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetShadowDistanceFadeoutFraction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowDistanceFadeoutFraction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowDistanceFadeoutFraction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowDistanceFadeoutFraction_NewValue_Offset), 0, SetShadowDistanceFadeoutFraction_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowDistanceFadeoutFraction_FunctionAddress, intPtr, SetShadowDistanceFadeoutFraction_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetShadowCascadeBiasDistribution")]
	public unsafe void SetShadowCascadeBiasDistribution(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowCascadeBiasDistribution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetShadowCascadeBiasDistribution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowCascadeBiasDistribution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowCascadeBiasDistribution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowCascadeBiasDistribution_NewValue_Offset), 0, SetShadowCascadeBiasDistribution_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowCascadeBiasDistribution_FunctionAddress, intPtr, SetShadowCascadeBiasDistribution_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetShadowAmount")]
	public unsafe void SetShadowAmount(float NewValue)
	{
		CheckDestroyed();
		if (!SetShadowAmount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetShadowAmount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetShadowAmount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetShadowAmount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetShadowAmount_NewValue_Offset), 0, SetShadowAmount_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetShadowAmount_FunctionAddress, intPtr, SetShadowAmount_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetOcclusionMaskDarkness")]
	public unsafe void SetOcclusionMaskDarkness(float NewValue)
	{
		CheckDestroyed();
		if (!SetOcclusionMaskDarkness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetOcclusionMaskDarkness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOcclusionMaskDarkness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOcclusionMaskDarkness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOcclusionMaskDarkness_NewValue_Offset), 0, SetOcclusionMaskDarkness_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOcclusionMaskDarkness_FunctionAddress, intPtr, SetOcclusionMaskDarkness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetOcclusionDepthRange")]
	public unsafe void SetOcclusionDepthRange(float NewValue)
	{
		CheckDestroyed();
		if (!SetOcclusionDepthRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetOcclusionDepthRange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOcclusionDepthRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOcclusionDepthRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetOcclusionDepthRange_NewValue_Offset), 0, SetOcclusionDepthRange_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOcclusionDepthRange_FunctionAddress, intPtr, SetOcclusionDepthRange_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetLightSourceSoftAngle")]
	public unsafe void SetLightSourceSoftAngle(float NewValue)
	{
		CheckDestroyed();
		if (!SetLightSourceSoftAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetLightSourceSoftAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightSourceSoftAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightSourceSoftAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLightSourceSoftAngle_NewValue_Offset), 0, SetLightSourceSoftAngle_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightSourceSoftAngle_FunctionAddress, intPtr, SetLightSourceSoftAngle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetLightSourceAngle")]
	public unsafe void SetLightSourceAngle(float NewValue)
	{
		CheckDestroyed();
		if (!SetLightSourceAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetLightSourceAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightSourceAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightSourceAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLightSourceAngle_NewValue_Offset), 0, SetLightSourceAngle_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightSourceAngle_FunctionAddress, intPtr, SetLightSourceAngle_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetLightShaftOverrideDirection")]
	public unsafe void SetLightShaftOverrideDirection(FVector NewValue)
	{
		CheckDestroyed();
		if (!SetLightShaftOverrideDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetLightShaftOverrideDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightShaftOverrideDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightShaftOverrideDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLightShaftOverrideDirection_NewValue_Offset), 0, SetLightShaftOverrideDirection_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightShaftOverrideDirection_FunctionAddress, intPtr, SetLightShaftOverrideDirection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetEnableLightShaftOcclusion")]
	public unsafe void SetEnableLightShaftOcclusion(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetEnableLightShaftOcclusion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetEnableLightShaftOcclusion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableLightShaftOcclusion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableLightShaftOcclusion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableLightShaftOcclusion_bNewValue_Offset), 0, SetEnableLightShaftOcclusion_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEnableLightShaftOcclusion_FunctionAddress, intPtr, SetEnableLightShaftOcclusion_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetDynamicShadowDistanceStationaryLight")]
	public unsafe void SetDynamicShadowDistanceStationaryLight(float NewValue)
	{
		CheckDestroyed();
		if (!SetDynamicShadowDistanceStationaryLight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetDynamicShadowDistanceStationaryLight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicShadowDistanceStationaryLight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicShadowDistanceStationaryLight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDynamicShadowDistanceStationaryLight_NewValue_Offset), 0, SetDynamicShadowDistanceStationaryLight_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicShadowDistanceStationaryLight_FunctionAddress, intPtr, SetDynamicShadowDistanceStationaryLight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetDynamicShadowDistanceMovableLight")]
	public unsafe void SetDynamicShadowDistanceMovableLight(float NewValue)
	{
		CheckDestroyed();
		if (!SetDynamicShadowDistanceMovableLight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetDynamicShadowDistanceMovableLight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicShadowDistanceMovableLight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicShadowDistanceMovableLight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDynamicShadowDistanceMovableLight_NewValue_Offset), 0, SetDynamicShadowDistanceMovableLight_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicShadowDistanceMovableLight_FunctionAddress, intPtr, SetDynamicShadowDistanceMovableLight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetDynamicShadowCascades")]
	public unsafe void SetDynamicShadowCascades(int NewValue)
	{
		CheckDestroyed();
		if (!SetDynamicShadowCascades_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetDynamicShadowCascades");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDynamicShadowCascades_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDynamicShadowCascades_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetDynamicShadowCascades_NewValue_Offset), 0, SetDynamicShadowCascades_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDynamicShadowCascades_FunctionAddress, intPtr, SetDynamicShadowCascades_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetCascadeTransitionFraction")]
	public unsafe void SetCascadeTransitionFraction(float NewValue)
	{
		CheckDestroyed();
		if (!SetCascadeTransitionFraction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetCascadeTransitionFraction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCascadeTransitionFraction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCascadeTransitionFraction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCascadeTransitionFraction_NewValue_Offset), 0, SetCascadeTransitionFraction_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCascadeTransitionFraction_FunctionAddress, intPtr, SetCascadeTransitionFraction_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetCascadeDistributionExponent")]
	public unsafe void SetCascadeDistributionExponent(float NewValue)
	{
		CheckDestroyed();
		if (!SetCascadeDistributionExponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetCascadeDistributionExponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCascadeDistributionExponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCascadeDistributionExponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetCascadeDistributionExponent_NewValue_Offset), 0, SetCascadeDistributionExponent_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCascadeDistributionExponent_FunctionAddress, intPtr, SetCascadeDistributionExponent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetAtmosphereSunLightIndex")]
	public unsafe void SetAtmosphereSunLightIndex(int NewValue)
	{
		CheckDestroyed();
		if (!SetAtmosphereSunLightIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetAtmosphereSunLightIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAtmosphereSunLightIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAtmosphereSunLightIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAtmosphereSunLightIndex_NewValue_Offset), 0, SetAtmosphereSunLightIndex_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAtmosphereSunLightIndex_FunctionAddress, intPtr, SetAtmosphereSunLightIndex_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.DirectionalLightComponent:SetAtmosphereSunLight")]
	public unsafe void SetAtmosphereSunLight(bool bNewValue)
	{
		CheckDestroyed();
		if (!SetAtmosphereSunLight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.DirectionalLightComponent:SetAtmosphereSunLight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAtmosphereSunLight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAtmosphereSunLight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAtmosphereSunLight_bNewValue_Offset), 0, SetAtmosphereSunLight_bNewValue_PropertyAddress.Address, bNewValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAtmosphereSunLight_FunctionAddress, intPtr, SetAtmosphereSunLight_ParamsSize);
	}

	static UDirectionalLightComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDirectionalLightComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDirectionalLightComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.DirectionalLightComponent");
		ShadowCascadeBiasDistribution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowCascadeBiasDistribution");
		ShadowCascadeBiasDistribution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowCascadeBiasDistribution", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableLightShaftOcclusion_PropertyAddress, intPtr, "bEnableLightShaftOcclusion");
		EnableLightShaftOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableLightShaftOcclusion");
		EnableLightShaftOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableLightShaftOcclusion", Classes.FBoolProperty);
		OcclusionMaskDarkness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionMaskDarkness");
		OcclusionMaskDarkness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionMaskDarkness", Classes.FFloatProperty);
		OcclusionDepthRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionDepthRange");
		OcclusionDepthRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionDepthRange", Classes.FFloatProperty);
		LightShaftOverrideDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightShaftOverrideDirection");
		LightShaftOverrideDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightShaftOverrideDirection", Classes.FStructProperty);
		DynamicShadowDistanceMovableLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicShadowDistanceMovableLight");
		DynamicShadowDistanceMovableLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicShadowDistanceMovableLight", Classes.FFloatProperty);
		DynamicShadowDistanceStationaryLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicShadowDistanceStationaryLight");
		DynamicShadowDistanceStationaryLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicShadowDistanceStationaryLight", Classes.FFloatProperty);
		DynamicShadowCascades_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicShadowCascades");
		DynamicShadowCascades_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicShadowCascades", Classes.FIntProperty);
		CascadeDistributionExponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CascadeDistributionExponent");
		CascadeDistributionExponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CascadeDistributionExponent", Classes.FFloatProperty);
		CascadeTransitionFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CascadeTransitionFraction");
		CascadeTransitionFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CascadeTransitionFraction", Classes.FFloatProperty);
		ShadowDistanceFadeoutFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowDistanceFadeoutFraction");
		ShadowDistanceFadeoutFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowDistanceFadeoutFraction", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseInsetShadowsForMovableObjects_PropertyAddress, intPtr, "bUseInsetShadowsForMovableObjects");
		UseInsetShadowsForMovableObjects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseInsetShadowsForMovableObjects");
		UseInsetShadowsForMovableObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseInsetShadowsForMovableObjects", Classes.FBoolProperty);
		FarShadowCascadeCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FarShadowCascadeCount");
		FarShadowCascadeCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FarShadowCascadeCount", Classes.FIntProperty);
		FarShadowDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FarShadowDistance");
		FarShadowDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FarShadowDistance", Classes.FFloatProperty);
		DistanceFieldShadowDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceFieldShadowDistance");
		DistanceFieldShadowDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceFieldShadowDistance", Classes.FFloatProperty);
		LightSourceAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightSourceAngle");
		LightSourceAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightSourceAngle", Classes.FFloatProperty);
		LightSourceSoftAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightSourceSoftAngle");
		LightSourceSoftAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightSourceSoftAngle", Classes.FFloatProperty);
		ShadowSourceAngleFactor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowSourceAngleFactor");
		ShadowSourceAngleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowSourceAngleFactor", Classes.FFloatProperty);
		TraceDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TraceDistance");
		TraceDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TraceDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AtmosphereSunLight_PropertyAddress, intPtr, "bAtmosphereSunLight");
		AtmosphereSunLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAtmosphereSunLight");
		AtmosphereSunLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAtmosphereSunLight", Classes.FBoolProperty);
		AtmosphereSunLightIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtmosphereSunLightIndex");
		AtmosphereSunLightIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtmosphereSunLightIndex", Classes.FIntProperty);
		AtmosphereSunDiskColorScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AtmosphereSunDiskColorScale");
		AtmosphereSunDiskColorScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AtmosphereSunDiskColorScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PerPixelAtmosphereTransmittance_PropertyAddress, intPtr, "bPerPixelAtmosphereTransmittance");
		PerPixelAtmosphereTransmittance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPerPixelAtmosphereTransmittance");
		PerPixelAtmosphereTransmittance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPerPixelAtmosphereTransmittance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowsOnClouds_PropertyAddress, intPtr, "bCastShadowsOnClouds");
		CastShadowsOnClouds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastShadowsOnClouds");
		CastShadowsOnClouds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastShadowsOnClouds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowsOnAtmosphere_PropertyAddress, intPtr, "bCastShadowsOnAtmosphere");
		CastShadowsOnAtmosphere_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastShadowsOnAtmosphere");
		CastShadowsOnAtmosphere_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastShadowsOnAtmosphere", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastCloudShadows_PropertyAddress, intPtr, "bCastCloudShadows");
		CastCloudShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastCloudShadows");
		CastCloudShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastCloudShadows", Classes.FBoolProperty);
		CloudShadowStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudShadowStrength");
		CloudShadowStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudShadowStrength", Classes.FFloatProperty);
		CloudShadowOnAtmosphereStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudShadowOnAtmosphereStrength");
		CloudShadowOnAtmosphereStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudShadowOnAtmosphereStrength", Classes.FFloatProperty);
		CloudShadowOnSurfaceStrength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudShadowOnSurfaceStrength");
		CloudShadowOnSurfaceStrength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudShadowOnSurfaceStrength", Classes.FFloatProperty);
		CloudShadowDepthBias_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudShadowDepthBias");
		CloudShadowDepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudShadowDepthBias", Classes.FFloatProperty);
		CloudShadowExtent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudShadowExtent");
		CloudShadowExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudShadowExtent", Classes.FFloatProperty);
		CloudShadowMapResolutionScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudShadowMapResolutionScale");
		CloudShadowMapResolutionScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudShadowMapResolutionScale", Classes.FFloatProperty);
		CloudShadowRaySampleCountScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudShadowRaySampleCountScale");
		CloudShadowRaySampleCountScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudShadowRaySampleCountScale", Classes.FFloatProperty);
		CloudScatteredLuminanceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CloudScatteredLuminanceScale");
		CloudScatteredLuminanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CloudScatteredLuminanceScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CastModulatedShadows_PropertyAddress, intPtr, "bCastModulatedShadows");
		CastModulatedShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastModulatedShadows");
		CastModulatedShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastModulatedShadows", Classes.FBoolProperty);
		ModulatedShadowColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulatedShadowColor");
		ModulatedShadowColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulatedShadowColor", Classes.FStructProperty);
		ShadowAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowAmount");
		ShadowAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowAmount", Classes.FFloatProperty);
		RTShadowPositionOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RTShadowPositionOffset");
		RTShadowPositionOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RTShadowPositionOffset", Classes.FFloatProperty);
		SetShadowSourceAngleFactor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowSourceAngleFactor");
		SetShadowSourceAngleFactor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowSourceAngleFactor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowSourceAngleFactor_NewValue_PropertyAddress, SetShadowSourceAngleFactor_FunctionAddress, "NewValue");
		SetShadowSourceAngleFactor_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowSourceAngleFactor_FunctionAddress, "NewValue");
		SetShadowSourceAngleFactor_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowSourceAngleFactor_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowSourceAngleFactor_IsValid = SetShadowSourceAngleFactor_FunctionAddress != IntPtr.Zero && SetShadowSourceAngleFactor_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetShadowSourceAngleFactor", SetShadowSourceAngleFactor_IsValid);
		SetShadowDistanceFadeoutFraction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowDistanceFadeoutFraction");
		SetShadowDistanceFadeoutFraction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowDistanceFadeoutFraction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowDistanceFadeoutFraction_NewValue_PropertyAddress, SetShadowDistanceFadeoutFraction_FunctionAddress, "NewValue");
		SetShadowDistanceFadeoutFraction_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowDistanceFadeoutFraction_FunctionAddress, "NewValue");
		SetShadowDistanceFadeoutFraction_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowDistanceFadeoutFraction_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowDistanceFadeoutFraction_IsValid = SetShadowDistanceFadeoutFraction_FunctionAddress != IntPtr.Zero && SetShadowDistanceFadeoutFraction_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetShadowDistanceFadeoutFraction", SetShadowDistanceFadeoutFraction_IsValid);
		SetShadowCascadeBiasDistribution_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowCascadeBiasDistribution");
		SetShadowCascadeBiasDistribution_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowCascadeBiasDistribution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowCascadeBiasDistribution_NewValue_PropertyAddress, SetShadowCascadeBiasDistribution_FunctionAddress, "NewValue");
		SetShadowCascadeBiasDistribution_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowCascadeBiasDistribution_FunctionAddress, "NewValue");
		SetShadowCascadeBiasDistribution_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowCascadeBiasDistribution_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowCascadeBiasDistribution_IsValid = SetShadowCascadeBiasDistribution_FunctionAddress != IntPtr.Zero && SetShadowCascadeBiasDistribution_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetShadowCascadeBiasDistribution", SetShadowCascadeBiasDistribution_IsValid);
		SetShadowAmount_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetShadowAmount");
		SetShadowAmount_ParamsSize = NativeReflection.GetFunctionParamsSize(SetShadowAmount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetShadowAmount_NewValue_PropertyAddress, SetShadowAmount_FunctionAddress, "NewValue");
		SetShadowAmount_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetShadowAmount_FunctionAddress, "NewValue");
		SetShadowAmount_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetShadowAmount_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetShadowAmount_IsValid = SetShadowAmount_FunctionAddress != IntPtr.Zero && SetShadowAmount_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetShadowAmount", SetShadowAmount_IsValid);
		SetOcclusionMaskDarkness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOcclusionMaskDarkness");
		SetOcclusionMaskDarkness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOcclusionMaskDarkness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOcclusionMaskDarkness_NewValue_PropertyAddress, SetOcclusionMaskDarkness_FunctionAddress, "NewValue");
		SetOcclusionMaskDarkness_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOcclusionMaskDarkness_FunctionAddress, "NewValue");
		SetOcclusionMaskDarkness_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOcclusionMaskDarkness_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetOcclusionMaskDarkness_IsValid = SetOcclusionMaskDarkness_FunctionAddress != IntPtr.Zero && SetOcclusionMaskDarkness_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetOcclusionMaskDarkness", SetOcclusionMaskDarkness_IsValid);
		SetOcclusionDepthRange_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOcclusionDepthRange");
		SetOcclusionDepthRange_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOcclusionDepthRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOcclusionDepthRange_NewValue_PropertyAddress, SetOcclusionDepthRange_FunctionAddress, "NewValue");
		SetOcclusionDepthRange_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOcclusionDepthRange_FunctionAddress, "NewValue");
		SetOcclusionDepthRange_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOcclusionDepthRange_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetOcclusionDepthRange_IsValid = SetOcclusionDepthRange_FunctionAddress != IntPtr.Zero && SetOcclusionDepthRange_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetOcclusionDepthRange", SetOcclusionDepthRange_IsValid);
		SetLightSourceSoftAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightSourceSoftAngle");
		SetLightSourceSoftAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightSourceSoftAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightSourceSoftAngle_NewValue_PropertyAddress, SetLightSourceSoftAngle_FunctionAddress, "NewValue");
		SetLightSourceSoftAngle_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLightSourceSoftAngle_FunctionAddress, "NewValue");
		SetLightSourceSoftAngle_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightSourceSoftAngle_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetLightSourceSoftAngle_IsValid = SetLightSourceSoftAngle_FunctionAddress != IntPtr.Zero && SetLightSourceSoftAngle_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetLightSourceSoftAngle", SetLightSourceSoftAngle_IsValid);
		SetLightSourceAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightSourceAngle");
		SetLightSourceAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightSourceAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightSourceAngle_NewValue_PropertyAddress, SetLightSourceAngle_FunctionAddress, "NewValue");
		SetLightSourceAngle_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLightSourceAngle_FunctionAddress, "NewValue");
		SetLightSourceAngle_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightSourceAngle_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetLightSourceAngle_IsValid = SetLightSourceAngle_FunctionAddress != IntPtr.Zero && SetLightSourceAngle_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetLightSourceAngle", SetLightSourceAngle_IsValid);
		SetLightShaftOverrideDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightShaftOverrideDirection");
		SetLightShaftOverrideDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightShaftOverrideDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightShaftOverrideDirection_NewValue_PropertyAddress, SetLightShaftOverrideDirection_FunctionAddress, "NewValue");
		SetLightShaftOverrideDirection_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetLightShaftOverrideDirection_FunctionAddress, "NewValue");
		SetLightShaftOverrideDirection_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightShaftOverrideDirection_FunctionAddress, "NewValue", Classes.FStructProperty);
		SetLightShaftOverrideDirection_IsValid = SetLightShaftOverrideDirection_FunctionAddress != IntPtr.Zero && SetLightShaftOverrideDirection_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetLightShaftOverrideDirection", SetLightShaftOverrideDirection_IsValid);
		SetEnableLightShaftOcclusion_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEnableLightShaftOcclusion");
		SetEnableLightShaftOcclusion_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableLightShaftOcclusion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableLightShaftOcclusion_bNewValue_PropertyAddress, SetEnableLightShaftOcclusion_FunctionAddress, "bNewValue");
		SetEnableLightShaftOcclusion_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableLightShaftOcclusion_FunctionAddress, "bNewValue");
		SetEnableLightShaftOcclusion_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableLightShaftOcclusion_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetEnableLightShaftOcclusion_IsValid = SetEnableLightShaftOcclusion_FunctionAddress != IntPtr.Zero && SetEnableLightShaftOcclusion_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetEnableLightShaftOcclusion", SetEnableLightShaftOcclusion_IsValid);
		SetDynamicShadowDistanceStationaryLight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicShadowDistanceStationaryLight");
		SetDynamicShadowDistanceStationaryLight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicShadowDistanceStationaryLight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicShadowDistanceStationaryLight_NewValue_PropertyAddress, SetDynamicShadowDistanceStationaryLight_FunctionAddress, "NewValue");
		SetDynamicShadowDistanceStationaryLight_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicShadowDistanceStationaryLight_FunctionAddress, "NewValue");
		SetDynamicShadowDistanceStationaryLight_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicShadowDistanceStationaryLight_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetDynamicShadowDistanceStationaryLight_IsValid = SetDynamicShadowDistanceStationaryLight_FunctionAddress != IntPtr.Zero && SetDynamicShadowDistanceStationaryLight_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetDynamicShadowDistanceStationaryLight", SetDynamicShadowDistanceStationaryLight_IsValid);
		SetDynamicShadowDistanceMovableLight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicShadowDistanceMovableLight");
		SetDynamicShadowDistanceMovableLight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicShadowDistanceMovableLight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicShadowDistanceMovableLight_NewValue_PropertyAddress, SetDynamicShadowDistanceMovableLight_FunctionAddress, "NewValue");
		SetDynamicShadowDistanceMovableLight_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicShadowDistanceMovableLight_FunctionAddress, "NewValue");
		SetDynamicShadowDistanceMovableLight_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicShadowDistanceMovableLight_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetDynamicShadowDistanceMovableLight_IsValid = SetDynamicShadowDistanceMovableLight_FunctionAddress != IntPtr.Zero && SetDynamicShadowDistanceMovableLight_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetDynamicShadowDistanceMovableLight", SetDynamicShadowDistanceMovableLight_IsValid);
		SetDynamicShadowCascades_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDynamicShadowCascades");
		SetDynamicShadowCascades_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDynamicShadowCascades_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDynamicShadowCascades_NewValue_PropertyAddress, SetDynamicShadowCascades_FunctionAddress, "NewValue");
		SetDynamicShadowCascades_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetDynamicShadowCascades_FunctionAddress, "NewValue");
		SetDynamicShadowCascades_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDynamicShadowCascades_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetDynamicShadowCascades_IsValid = SetDynamicShadowCascades_FunctionAddress != IntPtr.Zero && SetDynamicShadowCascades_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetDynamicShadowCascades", SetDynamicShadowCascades_IsValid);
		SetCascadeTransitionFraction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCascadeTransitionFraction");
		SetCascadeTransitionFraction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCascadeTransitionFraction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCascadeTransitionFraction_NewValue_PropertyAddress, SetCascadeTransitionFraction_FunctionAddress, "NewValue");
		SetCascadeTransitionFraction_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCascadeTransitionFraction_FunctionAddress, "NewValue");
		SetCascadeTransitionFraction_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCascadeTransitionFraction_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetCascadeTransitionFraction_IsValid = SetCascadeTransitionFraction_FunctionAddress != IntPtr.Zero && SetCascadeTransitionFraction_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetCascadeTransitionFraction", SetCascadeTransitionFraction_IsValid);
		SetCascadeDistributionExponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCascadeDistributionExponent");
		SetCascadeDistributionExponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCascadeDistributionExponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCascadeDistributionExponent_NewValue_PropertyAddress, SetCascadeDistributionExponent_FunctionAddress, "NewValue");
		SetCascadeDistributionExponent_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetCascadeDistributionExponent_FunctionAddress, "NewValue");
		SetCascadeDistributionExponent_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCascadeDistributionExponent_FunctionAddress, "NewValue", Classes.FFloatProperty);
		SetCascadeDistributionExponent_IsValid = SetCascadeDistributionExponent_FunctionAddress != IntPtr.Zero && SetCascadeDistributionExponent_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetCascadeDistributionExponent", SetCascadeDistributionExponent_IsValid);
		SetAtmosphereSunLightIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAtmosphereSunLightIndex");
		SetAtmosphereSunLightIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAtmosphereSunLightIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAtmosphereSunLightIndex_NewValue_PropertyAddress, SetAtmosphereSunLightIndex_FunctionAddress, "NewValue");
		SetAtmosphereSunLightIndex_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAtmosphereSunLightIndex_FunctionAddress, "NewValue");
		SetAtmosphereSunLightIndex_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAtmosphereSunLightIndex_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetAtmosphereSunLightIndex_IsValid = SetAtmosphereSunLightIndex_FunctionAddress != IntPtr.Zero && SetAtmosphereSunLightIndex_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetAtmosphereSunLightIndex", SetAtmosphereSunLightIndex_IsValid);
		SetAtmosphereSunLight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAtmosphereSunLight");
		SetAtmosphereSunLight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAtmosphereSunLight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAtmosphereSunLight_bNewValue_PropertyAddress, SetAtmosphereSunLight_FunctionAddress, "bNewValue");
		SetAtmosphereSunLight_bNewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAtmosphereSunLight_FunctionAddress, "bNewValue");
		SetAtmosphereSunLight_bNewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAtmosphereSunLight_FunctionAddress, "bNewValue", Classes.FBoolProperty);
		SetAtmosphereSunLight_IsValid = SetAtmosphereSunLight_FunctionAddress != IntPtr.Zero && SetAtmosphereSunLight_bNewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.DirectionalLightComponent:SetAtmosphereSunLight", SetAtmosphereSunLight_IsValid);
	}
}
