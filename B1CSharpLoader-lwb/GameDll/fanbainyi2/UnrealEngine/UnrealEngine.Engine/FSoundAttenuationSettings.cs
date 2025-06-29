using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 266753)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundAttenuationSettings", "Engine", UnrealModuleType.Engine)]
public struct FSoundAttenuationSettings
{
	private static bool DistanceAlgorithm_IsValid;

	private static FFieldAddress DistanceAlgorithm_PropertyAddress;

	private static int DistanceAlgorithm_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:DistanceAlgorithm")]
	public EAttenuationDistanceModel DistanceAlgorithm;

	private static bool AttenuationShape_IsValid;

	private static FFieldAddress AttenuationShape_PropertyAddress;

	private static int AttenuationShape_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:AttenuationShape")]
	public EAttenuationShape AttenuationShape;

	private static bool dBAttenuationAtMax_IsValid;

	private static int dBAttenuationAtMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:dBAttenuationAtMax")]
	public float dBAttenuationAtMax;

	private static bool FalloffMode_IsValid;

	private static FFieldAddress FalloffMode_PropertyAddress;

	private static int FalloffMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:FalloffMode")]
	public ENaturalSoundFalloffMode FalloffMode;

	private static bool AttenuationShapeExtents_IsValid;

	private static int AttenuationShapeExtents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:AttenuationShapeExtents")]
	public FVector AttenuationShapeExtents;

	private static bool ConeOffset_IsValid;

	private static int ConeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:ConeOffset")]
	public float ConeOffset;

	private static bool FalloffDistance_IsValid;

	private static int FalloffDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:FalloffDistance")]
	public float FalloffDistance;

	private static bool ConeSphereRadius_IsValid;

	private static int ConeSphereRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:ConeSphereRadius")]
	public float ConeSphereRadius;

	private static bool ConeSphereFalloffDistance_IsValid;

	private static int ConeSphereFalloffDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:ConeSphereFalloffDistance")]
	public float ConeSphereFalloffDistance;

	private static bool CustomAttenuationCurve_IsValid;

	private static int CustomAttenuationCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.BaseAttenuationSettings:CustomAttenuationCurve")]
	public FRuntimeFloatCurve CustomAttenuationCurve;

	private static bool Attenuate_IsValid;

	private static FFieldAddress Attenuate_PropertyAddress;

	private static int Attenuate_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bAttenuate")]
	public bool Attenuate;

	private static bool Spatialize_IsValid;

	private static FFieldAddress Spatialize_PropertyAddress;

	private static int Spatialize_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bSpatialize")]
	public bool Spatialize;

	private static bool AttenuateWithLPF_IsValid;

	private static FFieldAddress AttenuateWithLPF_PropertyAddress;

	private static int AttenuateWithLPF_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bAttenuateWithLPF")]
	public bool AttenuateWithLPF;

	private static bool EnableListenerFocus_IsValid;

	private static FFieldAddress EnableListenerFocus_PropertyAddress;

	private static int EnableListenerFocus_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnableListenerFocus")]
	public bool EnableListenerFocus;

	private static bool EnableFocusInterpolation_IsValid;

	private static FFieldAddress EnableFocusInterpolation_PropertyAddress;

	private static int EnableFocusInterpolation_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnableFocusInterpolation")]
	public bool EnableFocusInterpolation;

	private static bool EnableOcclusion_IsValid;

	private static FFieldAddress EnableOcclusion_PropertyAddress;

	private static int EnableOcclusion_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnableOcclusion")]
	public bool EnableOcclusion;

	private static bool UseComplexCollisionForOcclusion_IsValid;

	private static FFieldAddress UseComplexCollisionForOcclusion_PropertyAddress;

	private static int UseComplexCollisionForOcclusion_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bUseComplexCollisionForOcclusion")]
	public bool UseComplexCollisionForOcclusion;

	private static bool EnableReverbSend_IsValid;

	private static FFieldAddress EnableReverbSend_PropertyAddress;

	private static int EnableReverbSend_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnableReverbSend")]
	public bool EnableReverbSend;

	private static bool EnablePriorityAttenuation_IsValid;

	private static FFieldAddress EnablePriorityAttenuation_PropertyAddress;

	private static int EnablePriorityAttenuation_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnablePriorityAttenuation")]
	public bool EnablePriorityAttenuation;

	private static bool ApplyNormalizationToStereoSounds_IsValid;

	private static FFieldAddress ApplyNormalizationToStereoSounds_PropertyAddress;

	private static int ApplyNormalizationToStereoSounds_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bApplyNormalizationToStereoSounds")]
	public bool ApplyNormalizationToStereoSounds;

	private static bool EnableLogFrequencyScaling_IsValid;

	private static FFieldAddress EnableLogFrequencyScaling_PropertyAddress;

	private static int EnableLogFrequencyScaling_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnableLogFrequencyScaling")]
	public bool EnableLogFrequencyScaling;

	private static bool EnableSubmixSends_IsValid;

	private static FFieldAddress EnableSubmixSends_PropertyAddress;

	private static int EnableSubmixSends_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnableSubmixSends")]
	public bool EnableSubmixSends;

	private static bool EnableSourceDataOverride_IsValid;

	private static FFieldAddress EnableSourceDataOverride_PropertyAddress;

	private static int EnableSourceDataOverride_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:bEnableSourceDataOverride")]
	public bool EnableSourceDataOverride;

	private static bool SpatializationAlgorithm_IsValid;

	private static FFieldAddress SpatializationAlgorithm_PropertyAddress;

	private static int SpatializationAlgorithm_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:SpatializationAlgorithm")]
	public ESoundSpatializationAlgorithm SpatializationAlgorithm;

	private static bool BinauralRadius_IsValid;

	private static int BinauralRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:BinauralRadius")]
	public float BinauralRadius;

	private static bool AbsorptionMethod_IsValid;

	private static FFieldAddress AbsorptionMethod_PropertyAddress;

	private static int AbsorptionMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:AbsorptionMethod")]
	public EAirAbsorptionMethod AbsorptionMethod;

	private static bool OcclusionTraceChannel_IsValid;

	private static FFieldAddress OcclusionTraceChannel_PropertyAddress;

	private static int OcclusionTraceChannel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:OcclusionTraceChannel")]
	public ECollisionChannel OcclusionTraceChannel;

	private static bool ReverbSendMethod_IsValid;

	private static FFieldAddress ReverbSendMethod_PropertyAddress;

	private static int ReverbSendMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:ReverbSendMethod")]
	public EReverbSendMethod ReverbSendMethod;

	private static bool PriorityAttenuationMethod_IsValid;

	private static FFieldAddress PriorityAttenuationMethod_PropertyAddress;

	private static int PriorityAttenuationMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:PriorityAttenuationMethod")]
	public EPriorityAttenuationMethod PriorityAttenuationMethod;

	private static bool OmniRadius_IsValid;

	private static int OmniRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:OmniRadius")]
	public float OmniRadius;

	private static bool StereoSpread_IsValid;

	private static int StereoSpread_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:StereoSpread")]
	public float StereoSpread;

	private static bool LPFRadiusMin_IsValid;

	private static int LPFRadiusMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:LPFRadiusMin")]
	public float LPFRadiusMin;

	private static bool LPFRadiusMax_IsValid;

	private static int LPFRadiusMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:LPFRadiusMax")]
	public float LPFRadiusMax;

	private static bool CustomLowpassAirAbsorptionCurve_IsValid;

	private static int CustomLowpassAirAbsorptionCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:CustomLowpassAirAbsorptionCurve")]
	public FRuntimeFloatCurve CustomLowpassAirAbsorptionCurve;

	private static bool CustomHighpassAirAbsorptionCurve_IsValid;

	private static int CustomHighpassAirAbsorptionCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:CustomHighpassAirAbsorptionCurve")]
	public FRuntimeFloatCurve CustomHighpassAirAbsorptionCurve;

	private static bool LPFFrequencyAtMin_IsValid;

	private static int LPFFrequencyAtMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:LPFFrequencyAtMin")]
	public float LPFFrequencyAtMin;

	private static bool LPFFrequencyAtMax_IsValid;

	private static int LPFFrequencyAtMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:LPFFrequencyAtMax")]
	public float LPFFrequencyAtMax;

	private static bool HPFFrequencyAtMin_IsValid;

	private static int HPFFrequencyAtMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:HPFFrequencyAtMin")]
	public float HPFFrequencyAtMin;

	private static bool HPFFrequencyAtMax_IsValid;

	private static int HPFFrequencyAtMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:HPFFrequencyAtMax")]
	public float HPFFrequencyAtMax;

	private static bool FocusAzimuth_IsValid;

	private static int FocusAzimuth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:FocusAzimuth")]
	public float FocusAzimuth;

	private static bool NonFocusAzimuth_IsValid;

	private static int NonFocusAzimuth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:NonFocusAzimuth")]
	public float NonFocusAzimuth;

	private static bool FocusDistanceScale_IsValid;

	private static int FocusDistanceScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:FocusDistanceScale")]
	public float FocusDistanceScale;

	private static bool NonFocusDistanceScale_IsValid;

	private static int NonFocusDistanceScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:NonFocusDistanceScale")]
	public float NonFocusDistanceScale;

	private static bool FocusPriorityScale_IsValid;

	private static int FocusPriorityScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:FocusPriorityScale")]
	public float FocusPriorityScale;

	private static bool NonFocusPriorityScale_IsValid;

	private static int NonFocusPriorityScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:NonFocusPriorityScale")]
	public float NonFocusPriorityScale;

	private static bool FocusVolumeAttenuation_IsValid;

	private static int FocusVolumeAttenuation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:FocusVolumeAttenuation")]
	public float FocusVolumeAttenuation;

	private static bool NonFocusVolumeAttenuation_IsValid;

	private static int NonFocusVolumeAttenuation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:NonFocusVolumeAttenuation")]
	public float NonFocusVolumeAttenuation;

	private static bool FocusAttackInterpSpeed_IsValid;

	private static int FocusAttackInterpSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:FocusAttackInterpSpeed")]
	public float FocusAttackInterpSpeed;

	private static bool FocusReleaseInterpSpeed_IsValid;

	private static int FocusReleaseInterpSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:FocusReleaseInterpSpeed")]
	public float FocusReleaseInterpSpeed;

	private static bool OcclusionLowPassFilterFrequency_IsValid;

	private static int OcclusionLowPassFilterFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:OcclusionLowPassFilterFrequency")]
	public float OcclusionLowPassFilterFrequency;

	private static bool OcclusionVolumeAttenuation_IsValid;

	private static int OcclusionVolumeAttenuation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:OcclusionVolumeAttenuation")]
	public float OcclusionVolumeAttenuation;

	private static bool OcclusionInterpolationTime_IsValid;

	private static int OcclusionInterpolationTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:OcclusionInterpolationTime")]
	public float OcclusionInterpolationTime;

	private static bool ReverbWetLevelMin_IsValid;

	private static int ReverbWetLevelMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:ReverbWetLevelMin")]
	public float ReverbWetLevelMin;

	private static bool ReverbWetLevelMax_IsValid;

	private static int ReverbWetLevelMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:ReverbWetLevelMax")]
	public float ReverbWetLevelMax;

	private static bool ReverbDistanceMin_IsValid;

	private static int ReverbDistanceMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:ReverbDistanceMin")]
	public float ReverbDistanceMin;

	private static bool ReverbDistanceMax_IsValid;

	private static int ReverbDistanceMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:ReverbDistanceMax")]
	public float ReverbDistanceMax;

	private static bool ManualReverbSendLevel_IsValid;

	private static int ManualReverbSendLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:ManualReverbSendLevel")]
	public float ManualReverbSendLevel;

	private static bool CustomReverbSendCurve_IsValid;

	private static int CustomReverbSendCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:CustomReverbSendCurve")]
	public FRuntimeFloatCurve CustomReverbSendCurve;

	private static bool SubmixSendSettings_IsValid;

	private static FFieldAddress SubmixSendSettings_PropertyAddress;

	private static int SubmixSendSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:SubmixSendSettings")]
	public List<FAttenuationSubmixSendSettings> SubmixSendSettings;

	private static bool PriorityAttenuationMin_IsValid;

	private static int PriorityAttenuationMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:PriorityAttenuationMin")]
	public float PriorityAttenuationMin;

	private static bool PriorityAttenuationMax_IsValid;

	private static int PriorityAttenuationMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:PriorityAttenuationMax")]
	public float PriorityAttenuationMax;

	private static bool PriorityAttenuationDistanceMin_IsValid;

	private static int PriorityAttenuationDistanceMin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:PriorityAttenuationDistanceMin")]
	public float PriorityAttenuationDistanceMin;

	private static bool PriorityAttenuationDistanceMax_IsValid;

	private static int PriorityAttenuationDistanceMax_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:PriorityAttenuationDistanceMax")]
	public float PriorityAttenuationDistanceMax;

	private static bool ManualPriorityAttenuation_IsValid;

	private static int ManualPriorityAttenuation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:ManualPriorityAttenuation")]
	public float ManualPriorityAttenuation;

	private static bool CustomPriorityAttenuationCurve_IsValid;

	private static int CustomPriorityAttenuationCurve_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:CustomPriorityAttenuationCurve")]
	public FRuntimeFloatCurve CustomPriorityAttenuationCurve;

	private static bool PluginSettings_IsValid;

	private static int PluginSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Engine.SoundAttenuationSettings:PluginSettings")]
	public FSoundAttenuationPluginSettings PluginSettings;

	private static bool FSoundAttenuationSettings_IsValid;

	private static int FSoundAttenuationSettings_StructSize;

	public FSoundAttenuationSettings Copy()
	{
		FSoundAttenuationSettings result = this;
		if (SubmixSendSettings != null)
		{
			result.SubmixSendSettings = new List<FAttenuationSubmixSendSettings>(SubmixSendSettings);
		}
		return result;
	}

	public static FSoundAttenuationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSoundAttenuationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundAttenuationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundAttenuationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundAttenuationSettings(nativeBuffer + arrayIndex * FSoundAttenuationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundAttenuationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundAttenuationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundAttenuationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundAttenuationSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Attenuate_Offset), 0, Attenuate_PropertyAddress.Address, Attenuate);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Spatialize_Offset), 0, Spatialize_PropertyAddress.Address, Spatialize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttenuateWithLPF_Offset), 0, AttenuateWithLPF_PropertyAddress.Address, AttenuateWithLPF);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableListenerFocus_Offset), 0, EnableListenerFocus_PropertyAddress.Address, EnableListenerFocus);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableFocusInterpolation_Offset), 0, EnableFocusInterpolation_PropertyAddress.Address, EnableFocusInterpolation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableOcclusion_Offset), 0, EnableOcclusion_PropertyAddress.Address, EnableOcclusion);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseComplexCollisionForOcclusion_Offset), 0, UseComplexCollisionForOcclusion_PropertyAddress.Address, UseComplexCollisionForOcclusion);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableReverbSend_Offset), 0, EnableReverbSend_PropertyAddress.Address, EnableReverbSend);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnablePriorityAttenuation_Offset), 0, EnablePriorityAttenuation_PropertyAddress.Address, EnablePriorityAttenuation);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyNormalizationToStereoSounds_Offset), 0, ApplyNormalizationToStereoSounds_PropertyAddress.Address, ApplyNormalizationToStereoSounds);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableLogFrequencyScaling_Offset), 0, EnableLogFrequencyScaling_PropertyAddress.Address, EnableLogFrequencyScaling);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableSubmixSends_Offset), 0, EnableSubmixSends_PropertyAddress.Address, EnableSubmixSends);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableSourceDataOverride_Offset), 0, EnableSourceDataOverride_PropertyAddress.Address, EnableSourceDataOverride);
		EnumMarshaler<ESoundSpatializationAlgorithm>.ToNative(IntPtr.Add(nativeStruct, SpatializationAlgorithm_Offset), 0, SpatializationAlgorithm_PropertyAddress.Address, SpatializationAlgorithm);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BinauralRadius_Offset), BinauralRadius);
		EnumMarshaler<EAirAbsorptionMethod>.ToNative(IntPtr.Add(nativeStruct, AbsorptionMethod_Offset), 0, AbsorptionMethod_PropertyAddress.Address, AbsorptionMethod);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(nativeStruct, OcclusionTraceChannel_Offset), 0, OcclusionTraceChannel_PropertyAddress.Address, OcclusionTraceChannel);
		EnumMarshaler<EReverbSendMethod>.ToNative(IntPtr.Add(nativeStruct, ReverbSendMethod_Offset), 0, ReverbSendMethod_PropertyAddress.Address, ReverbSendMethod);
		EnumMarshaler<EPriorityAttenuationMethod>.ToNative(IntPtr.Add(nativeStruct, PriorityAttenuationMethod_Offset), 0, PriorityAttenuationMethod_PropertyAddress.Address, PriorityAttenuationMethod);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OmniRadius_Offset), OmniRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StereoSpread_Offset), StereoSpread);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LPFRadiusMin_Offset), LPFRadiusMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LPFRadiusMax_Offset), LPFRadiusMax);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomLowpassAirAbsorptionCurve_Offset), CustomLowpassAirAbsorptionCurve);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomHighpassAirAbsorptionCurve_Offset), CustomHighpassAirAbsorptionCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LPFFrequencyAtMin_Offset), LPFFrequencyAtMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LPFFrequencyAtMax_Offset), LPFFrequencyAtMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HPFFrequencyAtMin_Offset), HPFFrequencyAtMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HPFFrequencyAtMax_Offset), HPFFrequencyAtMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusAzimuth_Offset), FocusAzimuth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NonFocusAzimuth_Offset), NonFocusAzimuth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusDistanceScale_Offset), FocusDistanceScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NonFocusDistanceScale_Offset), NonFocusDistanceScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusPriorityScale_Offset), FocusPriorityScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NonFocusPriorityScale_Offset), NonFocusPriorityScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusVolumeAttenuation_Offset), FocusVolumeAttenuation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NonFocusVolumeAttenuation_Offset), NonFocusVolumeAttenuation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusAttackInterpSpeed_Offset), FocusAttackInterpSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusReleaseInterpSpeed_Offset), FocusReleaseInterpSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OcclusionLowPassFilterFrequency_Offset), OcclusionLowPassFilterFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OcclusionVolumeAttenuation_Offset), OcclusionVolumeAttenuation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OcclusionInterpolationTime_Offset), OcclusionInterpolationTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReverbWetLevelMin_Offset), ReverbWetLevelMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReverbWetLevelMax_Offset), ReverbWetLevelMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReverbDistanceMin_Offset), ReverbDistanceMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReverbDistanceMax_Offset), ReverbDistanceMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ManualReverbSendLevel_Offset), ManualReverbSendLevel);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomReverbSendCurve_Offset), CustomReverbSendCurve);
		new TArrayCopyMarshaler<FAttenuationSubmixSendSettings>(1, SubmixSendSettings_PropertyAddress, CachedMarshalingDelegates<FAttenuationSubmixSendSettings, FAttenuationSubmixSendSettings>.FromNative, CachedMarshalingDelegates<FAttenuationSubmixSendSettings, FAttenuationSubmixSendSettings>.ToNative).ToNative(IntPtr.Add(nativeStruct, SubmixSendSettings_Offset), SubmixSendSettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PriorityAttenuationMin_Offset), PriorityAttenuationMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PriorityAttenuationMax_Offset), PriorityAttenuationMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PriorityAttenuationDistanceMin_Offset), PriorityAttenuationDistanceMin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PriorityAttenuationDistanceMax_Offset), PriorityAttenuationDistanceMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ManualPriorityAttenuation_Offset), ManualPriorityAttenuation);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomPriorityAttenuationCurve_Offset), CustomPriorityAttenuationCurve);
		FSoundAttenuationPluginSettings.ToNative(IntPtr.Add(nativeStruct, PluginSettings_Offset), PluginSettings);
		EnumMarshaler<EAttenuationDistanceModel>.ToNative(IntPtr.Add(nativeStruct, DistanceAlgorithm_Offset), 0, DistanceAlgorithm_PropertyAddress.Address, DistanceAlgorithm);
		EnumMarshaler<EAttenuationShape>.ToNative(IntPtr.Add(nativeStruct, AttenuationShape_Offset), 0, AttenuationShape_PropertyAddress.Address, AttenuationShape);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, dBAttenuationAtMax_Offset), dBAttenuationAtMax);
		EnumMarshaler<ENaturalSoundFalloffMode>.ToNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address, FalloffMode);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, AttenuationShapeExtents_Offset), AttenuationShapeExtents);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ConeOffset_Offset), ConeOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FalloffDistance_Offset), FalloffDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ConeSphereRadius_Offset), ConeSphereRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ConeSphereFalloffDistance_Offset), ConeSphereFalloffDistance);
		FRuntimeFloatCurve.ToNative(IntPtr.Add(nativeStruct, CustomAttenuationCurve_Offset), CustomAttenuationCurve);
	}

	public FSoundAttenuationSettings(IntPtr nativeStruct)
	{
		if (!FSoundAttenuationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundAttenuationSettings");
			Attenuate = false;
			Spatialize = false;
			AttenuateWithLPF = false;
			EnableListenerFocus = false;
			EnableFocusInterpolation = false;
			EnableOcclusion = false;
			UseComplexCollisionForOcclusion = false;
			EnableReverbSend = false;
			EnablePriorityAttenuation = false;
			ApplyNormalizationToStereoSounds = false;
			EnableLogFrequencyScaling = false;
			EnableSubmixSends = false;
			EnableSourceDataOverride = false;
			SpatializationAlgorithm = ESoundSpatializationAlgorithm.SPATIALIZATION_Default;
			BinauralRadius = 0f;
			AbsorptionMethod = EAirAbsorptionMethod.Linear;
			OcclusionTraceChannel = ECollisionChannel.ECC_WorldStatic;
			ReverbSendMethod = EReverbSendMethod.Linear;
			PriorityAttenuationMethod = EPriorityAttenuationMethod.Linear;
			OmniRadius = 0f;
			StereoSpread = 0f;
			LPFRadiusMin = 0f;
			LPFRadiusMax = 0f;
			CustomLowpassAirAbsorptionCurve = default(FRuntimeFloatCurve);
			CustomHighpassAirAbsorptionCurve = default(FRuntimeFloatCurve);
			LPFFrequencyAtMin = 0f;
			LPFFrequencyAtMax = 0f;
			HPFFrequencyAtMin = 0f;
			HPFFrequencyAtMax = 0f;
			FocusAzimuth = 0f;
			NonFocusAzimuth = 0f;
			FocusDistanceScale = 0f;
			NonFocusDistanceScale = 0f;
			FocusPriorityScale = 0f;
			NonFocusPriorityScale = 0f;
			FocusVolumeAttenuation = 0f;
			NonFocusVolumeAttenuation = 0f;
			FocusAttackInterpSpeed = 0f;
			FocusReleaseInterpSpeed = 0f;
			OcclusionLowPassFilterFrequency = 0f;
			OcclusionVolumeAttenuation = 0f;
			OcclusionInterpolationTime = 0f;
			ReverbWetLevelMin = 0f;
			ReverbWetLevelMax = 0f;
			ReverbDistanceMin = 0f;
			ReverbDistanceMax = 0f;
			ManualReverbSendLevel = 0f;
			CustomReverbSendCurve = default(FRuntimeFloatCurve);
			SubmixSendSettings = null;
			PriorityAttenuationMin = 0f;
			PriorityAttenuationMax = 0f;
			PriorityAttenuationDistanceMin = 0f;
			PriorityAttenuationDistanceMax = 0f;
			ManualPriorityAttenuation = 0f;
			CustomPriorityAttenuationCurve = default(FRuntimeFloatCurve);
			PluginSettings = default(FSoundAttenuationPluginSettings);
			DistanceAlgorithm = EAttenuationDistanceModel.Linear;
			AttenuationShape = EAttenuationShape.Sphere;
			dBAttenuationAtMax = 0f;
			FalloffMode = ENaturalSoundFalloffMode.Continues;
			AttenuationShapeExtents = default(FVector);
			ConeOffset = 0f;
			FalloffDistance = 0f;
			ConeSphereRadius = 0f;
			ConeSphereFalloffDistance = 0f;
			CustomAttenuationCurve = default(FRuntimeFloatCurve);
		}
		else
		{
			Attenuate = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Attenuate_Offset), 0, Attenuate_PropertyAddress.Address);
			Spatialize = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Spatialize_Offset), 0, Spatialize_PropertyAddress.Address);
			AttenuateWithLPF = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttenuateWithLPF_Offset), 0, AttenuateWithLPF_PropertyAddress.Address);
			EnableListenerFocus = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableListenerFocus_Offset), 0, EnableListenerFocus_PropertyAddress.Address);
			EnableFocusInterpolation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableFocusInterpolation_Offset), 0, EnableFocusInterpolation_PropertyAddress.Address);
			EnableOcclusion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableOcclusion_Offset), 0, EnableOcclusion_PropertyAddress.Address);
			UseComplexCollisionForOcclusion = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseComplexCollisionForOcclusion_Offset), 0, UseComplexCollisionForOcclusion_PropertyAddress.Address);
			EnableReverbSend = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableReverbSend_Offset), 0, EnableReverbSend_PropertyAddress.Address);
			EnablePriorityAttenuation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnablePriorityAttenuation_Offset), 0, EnablePriorityAttenuation_PropertyAddress.Address);
			ApplyNormalizationToStereoSounds = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyNormalizationToStereoSounds_Offset), 0, ApplyNormalizationToStereoSounds_PropertyAddress.Address);
			EnableLogFrequencyScaling = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableLogFrequencyScaling_Offset), 0, EnableLogFrequencyScaling_PropertyAddress.Address);
			EnableSubmixSends = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableSubmixSends_Offset), 0, EnableSubmixSends_PropertyAddress.Address);
			EnableSourceDataOverride = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableSourceDataOverride_Offset), 0, EnableSourceDataOverride_PropertyAddress.Address);
			SpatializationAlgorithm = EnumMarshaler<ESoundSpatializationAlgorithm>.FromNative(IntPtr.Add(nativeStruct, SpatializationAlgorithm_Offset), 0, SpatializationAlgorithm_PropertyAddress.Address);
			BinauralRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BinauralRadius_Offset));
			AbsorptionMethod = EnumMarshaler<EAirAbsorptionMethod>.FromNative(IntPtr.Add(nativeStruct, AbsorptionMethod_Offset), 0, AbsorptionMethod_PropertyAddress.Address);
			OcclusionTraceChannel = EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(nativeStruct, OcclusionTraceChannel_Offset), 0, OcclusionTraceChannel_PropertyAddress.Address);
			ReverbSendMethod = EnumMarshaler<EReverbSendMethod>.FromNative(IntPtr.Add(nativeStruct, ReverbSendMethod_Offset), 0, ReverbSendMethod_PropertyAddress.Address);
			PriorityAttenuationMethod = EnumMarshaler<EPriorityAttenuationMethod>.FromNative(IntPtr.Add(nativeStruct, PriorityAttenuationMethod_Offset), 0, PriorityAttenuationMethod_PropertyAddress.Address);
			OmniRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OmniRadius_Offset));
			StereoSpread = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StereoSpread_Offset));
			LPFRadiusMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LPFRadiusMin_Offset));
			LPFRadiusMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LPFRadiusMax_Offset));
			CustomLowpassAirAbsorptionCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomLowpassAirAbsorptionCurve_Offset));
			CustomHighpassAirAbsorptionCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomHighpassAirAbsorptionCurve_Offset));
			LPFFrequencyAtMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LPFFrequencyAtMin_Offset));
			LPFFrequencyAtMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LPFFrequencyAtMax_Offset));
			HPFFrequencyAtMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HPFFrequencyAtMin_Offset));
			HPFFrequencyAtMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HPFFrequencyAtMax_Offset));
			FocusAzimuth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusAzimuth_Offset));
			NonFocusAzimuth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NonFocusAzimuth_Offset));
			FocusDistanceScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusDistanceScale_Offset));
			NonFocusDistanceScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NonFocusDistanceScale_Offset));
			FocusPriorityScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusPriorityScale_Offset));
			NonFocusPriorityScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NonFocusPriorityScale_Offset));
			FocusVolumeAttenuation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusVolumeAttenuation_Offset));
			NonFocusVolumeAttenuation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NonFocusVolumeAttenuation_Offset));
			FocusAttackInterpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusAttackInterpSpeed_Offset));
			FocusReleaseInterpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusReleaseInterpSpeed_Offset));
			OcclusionLowPassFilterFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OcclusionLowPassFilterFrequency_Offset));
			OcclusionVolumeAttenuation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OcclusionVolumeAttenuation_Offset));
			OcclusionInterpolationTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OcclusionInterpolationTime_Offset));
			ReverbWetLevelMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReverbWetLevelMin_Offset));
			ReverbWetLevelMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReverbWetLevelMax_Offset));
			ReverbDistanceMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReverbDistanceMin_Offset));
			ReverbDistanceMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReverbDistanceMax_Offset));
			ManualReverbSendLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ManualReverbSendLevel_Offset));
			CustomReverbSendCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomReverbSendCurve_Offset));
			SubmixSendSettings = new TArrayCopyMarshaler<FAttenuationSubmixSendSettings>(1, SubmixSendSettings_PropertyAddress, CachedMarshalingDelegates<FAttenuationSubmixSendSettings, FAttenuationSubmixSendSettings>.FromNative, CachedMarshalingDelegates<FAttenuationSubmixSendSettings, FAttenuationSubmixSendSettings>.ToNative).FromNative(IntPtr.Add(nativeStruct, SubmixSendSettings_Offset));
			PriorityAttenuationMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PriorityAttenuationMin_Offset));
			PriorityAttenuationMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PriorityAttenuationMax_Offset));
			PriorityAttenuationDistanceMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PriorityAttenuationDistanceMin_Offset));
			PriorityAttenuationDistanceMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PriorityAttenuationDistanceMax_Offset));
			ManualPriorityAttenuation = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ManualPriorityAttenuation_Offset));
			CustomPriorityAttenuationCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomPriorityAttenuationCurve_Offset));
			PluginSettings = FSoundAttenuationPluginSettings.FromNative(IntPtr.Add(nativeStruct, PluginSettings_Offset));
			DistanceAlgorithm = EnumMarshaler<EAttenuationDistanceModel>.FromNative(IntPtr.Add(nativeStruct, DistanceAlgorithm_Offset), 0, DistanceAlgorithm_PropertyAddress.Address);
			AttenuationShape = EnumMarshaler<EAttenuationShape>.FromNative(IntPtr.Add(nativeStruct, AttenuationShape_Offset), 0, AttenuationShape_PropertyAddress.Address);
			dBAttenuationAtMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, dBAttenuationAtMax_Offset));
			FalloffMode = EnumMarshaler<ENaturalSoundFalloffMode>.FromNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address);
			AttenuationShapeExtents = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, AttenuationShapeExtents_Offset));
			ConeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ConeOffset_Offset));
			FalloffDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FalloffDistance_Offset));
			ConeSphereRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ConeSphereRadius_Offset));
			ConeSphereFalloffDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ConeSphereFalloffDistance_Offset));
			CustomAttenuationCurve = FRuntimeFloatCurve.FromNative(IntPtr.Add(nativeStruct, CustomAttenuationCurve_Offset));
		}
	}

	static FSoundAttenuationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundAttenuationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundAttenuationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundAttenuationSettings");
		FSoundAttenuationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DistanceAlgorithm_PropertyAddress, intPtr, "DistanceAlgorithm");
		DistanceAlgorithm_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceAlgorithm");
		DistanceAlgorithm_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceAlgorithm", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AttenuationShape_PropertyAddress, intPtr, "AttenuationShape");
		AttenuationShape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationShape");
		AttenuationShape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationShape", Classes.FByteProperty);
		dBAttenuationAtMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "dBAttenuationAtMax");
		dBAttenuationAtMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "dBAttenuationAtMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FalloffMode_PropertyAddress, intPtr, "FalloffMode");
		FalloffMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffMode");
		FalloffMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffMode", Classes.FEnumProperty);
		AttenuationShapeExtents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationShapeExtents");
		AttenuationShapeExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationShapeExtents", Classes.FStructProperty);
		ConeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConeOffset");
		ConeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConeOffset", Classes.FFloatProperty);
		FalloffDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffDistance");
		FalloffDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffDistance", Classes.FFloatProperty);
		ConeSphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConeSphereRadius");
		ConeSphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConeSphereRadius", Classes.FFloatProperty);
		ConeSphereFalloffDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ConeSphereFalloffDistance");
		ConeSphereFalloffDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ConeSphereFalloffDistance", Classes.FFloatProperty);
		CustomAttenuationCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomAttenuationCurve");
		CustomAttenuationCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomAttenuationCurve", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Attenuate_PropertyAddress, intPtr, "bAttenuate");
		Attenuate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAttenuate");
		Attenuate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAttenuate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Spatialize_PropertyAddress, intPtr, "bSpatialize");
		Spatialize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSpatialize");
		Spatialize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSpatialize", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AttenuateWithLPF_PropertyAddress, intPtr, "bAttenuateWithLPF");
		AttenuateWithLPF_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAttenuateWithLPF");
		AttenuateWithLPF_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAttenuateWithLPF", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableListenerFocus_PropertyAddress, intPtr, "bEnableListenerFocus");
		EnableListenerFocus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableListenerFocus");
		EnableListenerFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableListenerFocus", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableFocusInterpolation_PropertyAddress, intPtr, "bEnableFocusInterpolation");
		EnableFocusInterpolation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableFocusInterpolation");
		EnableFocusInterpolation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableFocusInterpolation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableOcclusion_PropertyAddress, intPtr, "bEnableOcclusion");
		EnableOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableOcclusion");
		EnableOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableOcclusion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseComplexCollisionForOcclusion_PropertyAddress, intPtr, "bUseComplexCollisionForOcclusion");
		UseComplexCollisionForOcclusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseComplexCollisionForOcclusion");
		UseComplexCollisionForOcclusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseComplexCollisionForOcclusion", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableReverbSend_PropertyAddress, intPtr, "bEnableReverbSend");
		EnableReverbSend_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableReverbSend");
		EnableReverbSend_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableReverbSend", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnablePriorityAttenuation_PropertyAddress, intPtr, "bEnablePriorityAttenuation");
		EnablePriorityAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnablePriorityAttenuation");
		EnablePriorityAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnablePriorityAttenuation", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyNormalizationToStereoSounds_PropertyAddress, intPtr, "bApplyNormalizationToStereoSounds");
		ApplyNormalizationToStereoSounds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyNormalizationToStereoSounds");
		ApplyNormalizationToStereoSounds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyNormalizationToStereoSounds", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableLogFrequencyScaling_PropertyAddress, intPtr, "bEnableLogFrequencyScaling");
		EnableLogFrequencyScaling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableLogFrequencyScaling");
		EnableLogFrequencyScaling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableLogFrequencyScaling", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSubmixSends_PropertyAddress, intPtr, "bEnableSubmixSends");
		EnableSubmixSends_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSubmixSends");
		EnableSubmixSends_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSubmixSends", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableSourceDataOverride_PropertyAddress, intPtr, "bEnableSourceDataOverride");
		EnableSourceDataOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableSourceDataOverride");
		EnableSourceDataOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableSourceDataOverride", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpatializationAlgorithm_PropertyAddress, intPtr, "SpatializationAlgorithm");
		SpatializationAlgorithm_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpatializationAlgorithm");
		SpatializationAlgorithm_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpatializationAlgorithm", Classes.FByteProperty);
		BinauralRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BinauralRadius");
		BinauralRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BinauralRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AbsorptionMethod_PropertyAddress, intPtr, "AbsorptionMethod");
		AbsorptionMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AbsorptionMethod");
		AbsorptionMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AbsorptionMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OcclusionTraceChannel_PropertyAddress, intPtr, "OcclusionTraceChannel");
		OcclusionTraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionTraceChannel");
		OcclusionTraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionTraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ReverbSendMethod_PropertyAddress, intPtr, "ReverbSendMethod");
		ReverbSendMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbSendMethod");
		ReverbSendMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbSendMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PriorityAttenuationMethod_PropertyAddress, intPtr, "PriorityAttenuationMethod");
		PriorityAttenuationMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PriorityAttenuationMethod");
		PriorityAttenuationMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PriorityAttenuationMethod", Classes.FEnumProperty);
		OmniRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OmniRadius");
		OmniRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OmniRadius", Classes.FFloatProperty);
		StereoSpread_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StereoSpread");
		StereoSpread_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StereoSpread", Classes.FFloatProperty);
		LPFRadiusMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LPFRadiusMin");
		LPFRadiusMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LPFRadiusMin", Classes.FFloatProperty);
		LPFRadiusMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LPFRadiusMax");
		LPFRadiusMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LPFRadiusMax", Classes.FFloatProperty);
		CustomLowpassAirAbsorptionCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomLowpassAirAbsorptionCurve");
		CustomLowpassAirAbsorptionCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomLowpassAirAbsorptionCurve", Classes.FStructProperty);
		CustomHighpassAirAbsorptionCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomHighpassAirAbsorptionCurve");
		CustomHighpassAirAbsorptionCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomHighpassAirAbsorptionCurve", Classes.FStructProperty);
		LPFFrequencyAtMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LPFFrequencyAtMin");
		LPFFrequencyAtMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LPFFrequencyAtMin", Classes.FFloatProperty);
		LPFFrequencyAtMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LPFFrequencyAtMax");
		LPFFrequencyAtMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LPFFrequencyAtMax", Classes.FFloatProperty);
		HPFFrequencyAtMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HPFFrequencyAtMin");
		HPFFrequencyAtMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HPFFrequencyAtMin", Classes.FFloatProperty);
		HPFFrequencyAtMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HPFFrequencyAtMax");
		HPFFrequencyAtMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HPFFrequencyAtMax", Classes.FFloatProperty);
		FocusAzimuth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusAzimuth");
		FocusAzimuth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusAzimuth", Classes.FFloatProperty);
		NonFocusAzimuth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NonFocusAzimuth");
		NonFocusAzimuth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NonFocusAzimuth", Classes.FFloatProperty);
		FocusDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusDistanceScale");
		FocusDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusDistanceScale", Classes.FFloatProperty);
		NonFocusDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NonFocusDistanceScale");
		NonFocusDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NonFocusDistanceScale", Classes.FFloatProperty);
		FocusPriorityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusPriorityScale");
		FocusPriorityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusPriorityScale", Classes.FFloatProperty);
		NonFocusPriorityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NonFocusPriorityScale");
		NonFocusPriorityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NonFocusPriorityScale", Classes.FFloatProperty);
		FocusVolumeAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusVolumeAttenuation");
		FocusVolumeAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusVolumeAttenuation", Classes.FFloatProperty);
		NonFocusVolumeAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NonFocusVolumeAttenuation");
		NonFocusVolumeAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NonFocusVolumeAttenuation", Classes.FFloatProperty);
		FocusAttackInterpSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusAttackInterpSpeed");
		FocusAttackInterpSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusAttackInterpSpeed", Classes.FFloatProperty);
		FocusReleaseInterpSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusReleaseInterpSpeed");
		FocusReleaseInterpSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusReleaseInterpSpeed", Classes.FFloatProperty);
		OcclusionLowPassFilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionLowPassFilterFrequency");
		OcclusionLowPassFilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionLowPassFilterFrequency", Classes.FFloatProperty);
		OcclusionVolumeAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionVolumeAttenuation");
		OcclusionVolumeAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionVolumeAttenuation", Classes.FFloatProperty);
		OcclusionInterpolationTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionInterpolationTime");
		OcclusionInterpolationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionInterpolationTime", Classes.FFloatProperty);
		ReverbWetLevelMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbWetLevelMin");
		ReverbWetLevelMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbWetLevelMin", Classes.FFloatProperty);
		ReverbWetLevelMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbWetLevelMax");
		ReverbWetLevelMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbWetLevelMax", Classes.FFloatProperty);
		ReverbDistanceMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbDistanceMin");
		ReverbDistanceMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbDistanceMin", Classes.FFloatProperty);
		ReverbDistanceMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbDistanceMax");
		ReverbDistanceMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbDistanceMax", Classes.FFloatProperty);
		ManualReverbSendLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManualReverbSendLevel");
		ManualReverbSendLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManualReverbSendLevel", Classes.FFloatProperty);
		CustomReverbSendCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomReverbSendCurve");
		CustomReverbSendCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomReverbSendCurve", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SubmixSendSettings_PropertyAddress, intPtr, "SubmixSendSettings");
		SubmixSendSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SubmixSendSettings");
		SubmixSendSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SubmixSendSettings", Classes.FArrayProperty);
		PriorityAttenuationMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PriorityAttenuationMin");
		PriorityAttenuationMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PriorityAttenuationMin", Classes.FFloatProperty);
		PriorityAttenuationMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PriorityAttenuationMax");
		PriorityAttenuationMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PriorityAttenuationMax", Classes.FFloatProperty);
		PriorityAttenuationDistanceMin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PriorityAttenuationDistanceMin");
		PriorityAttenuationDistanceMin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PriorityAttenuationDistanceMin", Classes.FFloatProperty);
		PriorityAttenuationDistanceMax_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PriorityAttenuationDistanceMax");
		PriorityAttenuationDistanceMax_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PriorityAttenuationDistanceMax", Classes.FFloatProperty);
		ManualPriorityAttenuation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManualPriorityAttenuation");
		ManualPriorityAttenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManualPriorityAttenuation", Classes.FFloatProperty);
		CustomPriorityAttenuationCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CustomPriorityAttenuationCurve");
		CustomPriorityAttenuationCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CustomPriorityAttenuationCurve", Classes.FStructProperty);
		PluginSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PluginSettings");
		PluginSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PluginSettings", Classes.FStructProperty);
		FSoundAttenuationSettings_IsValid = intPtr != IntPtr.Zero && Attenuate_IsValid && Spatialize_IsValid && AttenuateWithLPF_IsValid && EnableListenerFocus_IsValid && EnableFocusInterpolation_IsValid && EnableOcclusion_IsValid && UseComplexCollisionForOcclusion_IsValid && EnableReverbSend_IsValid && EnablePriorityAttenuation_IsValid && ApplyNormalizationToStereoSounds_IsValid && EnableLogFrequencyScaling_IsValid && EnableSubmixSends_IsValid && EnableSourceDataOverride_IsValid && SpatializationAlgorithm_IsValid && BinauralRadius_IsValid && AbsorptionMethod_IsValid && OcclusionTraceChannel_IsValid && ReverbSendMethod_IsValid && PriorityAttenuationMethod_IsValid && OmniRadius_IsValid && StereoSpread_IsValid && LPFRadiusMin_IsValid && LPFRadiusMax_IsValid && CustomLowpassAirAbsorptionCurve_IsValid && CustomHighpassAirAbsorptionCurve_IsValid && LPFFrequencyAtMin_IsValid && LPFFrequencyAtMax_IsValid && HPFFrequencyAtMin_IsValid && HPFFrequencyAtMax_IsValid && FocusAzimuth_IsValid && NonFocusAzimuth_IsValid && FocusDistanceScale_IsValid && NonFocusDistanceScale_IsValid && FocusPriorityScale_IsValid && NonFocusPriorityScale_IsValid && FocusVolumeAttenuation_IsValid && NonFocusVolumeAttenuation_IsValid && FocusAttackInterpSpeed_IsValid && FocusReleaseInterpSpeed_IsValid && OcclusionLowPassFilterFrequency_IsValid && OcclusionVolumeAttenuation_IsValid && OcclusionInterpolationTime_IsValid && ReverbWetLevelMin_IsValid && ReverbWetLevelMax_IsValid && ReverbDistanceMin_IsValid && ReverbDistanceMax_IsValid && ManualReverbSendLevel_IsValid && CustomReverbSendCurve_IsValid && SubmixSendSettings_IsValid && PriorityAttenuationMin_IsValid && PriorityAttenuationMax_IsValid && PriorityAttenuationDistanceMin_IsValid && PriorityAttenuationDistanceMax_IsValid && ManualPriorityAttenuation_IsValid && CustomPriorityAttenuationCurve_IsValid && PluginSettings_IsValid && DistanceAlgorithm_IsValid && AttenuationShape_IsValid && dBAttenuationAtMax_IsValid && FalloffMode_IsValid && AttenuationShapeExtents_IsValid && ConeOffset_IsValid && FalloffDistance_IsValid && ConeSphereRadius_IsValid && ConeSphereFalloffDistance_IsValid && CustomAttenuationCurve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundAttenuationSettings", FSoundAttenuationSettings_IsValid);
	}
}
