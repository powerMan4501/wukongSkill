using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings", "AudioMixer", UnrealModuleType.Engine)]
public struct FSubmixEffectReverbSettings
{
	private static bool BypassEarlyReflections_IsValid;

	private static FFieldAddress BypassEarlyReflections_PropertyAddress;

	private static int BypassEarlyReflections_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:bBypassEarlyReflections")]
	public bool BypassEarlyReflections;

	private static bool ReflectionsDelay_IsValid;

	private static int ReflectionsDelay_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:ReflectionsDelay")]
	public float ReflectionsDelay;

	private static bool GainHF_IsValid;

	private static int GainHF_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:GainHF")]
	public float GainHF;

	private static bool ReflectionsGain_IsValid;

	private static int ReflectionsGain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:ReflectionsGain")]
	public float ReflectionsGain;

	private static bool BypassLateReflections_IsValid;

	private static FFieldAddress BypassLateReflections_PropertyAddress;

	private static int BypassLateReflections_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:bBypassLateReflections")]
	public bool BypassLateReflections;

	private static bool LateDelay_IsValid;

	private static int LateDelay_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:LateDelay")]
	public float LateDelay;

	private static bool DecayTime_IsValid;

	private static int DecayTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:DecayTime")]
	public float DecayTime;

	private static bool Density_IsValid;

	private static int Density_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:Density")]
	public float Density;

	private static bool Diffusion_IsValid;

	private static int Diffusion_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:Diffusion")]
	public float Diffusion;

	private static bool AirAbsorptionGainHF_IsValid;

	private static int AirAbsorptionGainHF_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:AirAbsorptionGainHF")]
	public float AirAbsorptionGainHF;

	private static bool DecayHFRatio_IsValid;

	private static int DecayHFRatio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:DecayHFRatio")]
	public float DecayHFRatio;

	private static bool LateGain_IsValid;

	private static int LateGain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:LateGain")]
	public float LateGain;

	private static bool Gain_IsValid;

	private static int Gain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:Gain")]
	public float Gain;

	private static bool WetLevel_IsValid;

	private static int WetLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:WetLevel")]
	public float WetLevel;

	private static bool DryLevel_IsValid;

	private static int DryLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:DryLevel")]
	public float DryLevel;

	private static bool Bypass_IsValid;

	private static FFieldAddress Bypass_PropertyAddress;

	private static int Bypass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectReverbSettings:bBypass")]
	public bool Bypass;

	private static bool FSubmixEffectReverbSettings_IsValid;

	private static int FSubmixEffectReverbSettings_StructSize;

	public FSubmixEffectReverbSettings Copy()
	{
		return this;
	}

	public static FSubmixEffectReverbSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectReverbSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectReverbSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectReverbSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectReverbSettings(nativeBuffer + arrayIndex * FSubmixEffectReverbSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectReverbSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectReverbSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectReverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectReverbSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BypassEarlyReflections_Offset), 0, BypassEarlyReflections_PropertyAddress.Address, BypassEarlyReflections);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReflectionsDelay_Offset), ReflectionsDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GainHF_Offset), GainHF);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReflectionsGain_Offset), ReflectionsGain);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, BypassLateReflections_Offset), 0, BypassLateReflections_PropertyAddress.Address, BypassLateReflections);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LateDelay_Offset), LateDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DecayTime_Offset), DecayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Density_Offset), Density);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Diffusion_Offset), Diffusion);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AirAbsorptionGainHF_Offset), AirAbsorptionGainHF);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DecayHFRatio_Offset), DecayHFRatio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LateGain_Offset), LateGain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Gain_Offset), Gain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WetLevel_Offset), WetLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DryLevel_Offset), DryLevel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address, Bypass);
	}

	public FSubmixEffectReverbSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectReverbSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectReverbSettings");
			BypassEarlyReflections = false;
			ReflectionsDelay = 0f;
			GainHF = 0f;
			ReflectionsGain = 0f;
			BypassLateReflections = false;
			LateDelay = 0f;
			DecayTime = 0f;
			Density = 0f;
			Diffusion = 0f;
			AirAbsorptionGainHF = 0f;
			DecayHFRatio = 0f;
			LateGain = 0f;
			Gain = 0f;
			WetLevel = 0f;
			DryLevel = 0f;
			Bypass = false;
		}
		else
		{
			BypassEarlyReflections = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BypassEarlyReflections_Offset), 0, BypassEarlyReflections_PropertyAddress.Address);
			ReflectionsDelay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReflectionsDelay_Offset));
			GainHF = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GainHF_Offset));
			ReflectionsGain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReflectionsGain_Offset));
			BypassLateReflections = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, BypassLateReflections_Offset), 0, BypassLateReflections_PropertyAddress.Address);
			LateDelay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LateDelay_Offset));
			DecayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DecayTime_Offset));
			Density = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Density_Offset));
			Diffusion = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Diffusion_Offset));
			AirAbsorptionGainHF = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AirAbsorptionGainHF_Offset));
			DecayHFRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DecayHFRatio_Offset));
			LateGain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LateGain_Offset));
			Gain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Gain_Offset));
			WetLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WetLevel_Offset));
			DryLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DryLevel_Offset));
			Bypass = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address);
		}
	}

	static FSubmixEffectReverbSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectReverbSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectReverbSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioMixer.SubmixEffectReverbSettings");
		FSubmixEffectReverbSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref BypassEarlyReflections_PropertyAddress, intPtr, "bBypassEarlyReflections");
		BypassEarlyReflections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBypassEarlyReflections");
		BypassEarlyReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBypassEarlyReflections", Classes.FBoolProperty);
		ReflectionsDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReflectionsDelay");
		ReflectionsDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReflectionsDelay", Classes.FFloatProperty);
		GainHF_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GainHF");
		GainHF_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GainHF", Classes.FFloatProperty);
		ReflectionsGain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReflectionsGain");
		ReflectionsGain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReflectionsGain", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BypassLateReflections_PropertyAddress, intPtr, "bBypassLateReflections");
		BypassLateReflections_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBypassLateReflections");
		BypassLateReflections_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBypassLateReflections", Classes.FBoolProperty);
		LateDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LateDelay");
		LateDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LateDelay", Classes.FFloatProperty);
		DecayTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecayTime");
		DecayTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecayTime", Classes.FFloatProperty);
		Density_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Density");
		Density_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Density", Classes.FFloatProperty);
		Diffusion_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Diffusion");
		Diffusion_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Diffusion", Classes.FFloatProperty);
		AirAbsorptionGainHF_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AirAbsorptionGainHF");
		AirAbsorptionGainHF_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AirAbsorptionGainHF", Classes.FFloatProperty);
		DecayHFRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DecayHFRatio");
		DecayHFRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DecayHFRatio", Classes.FFloatProperty);
		LateGain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LateGain");
		LateGain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LateGain", Classes.FFloatProperty);
		Gain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Gain");
		Gain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Gain", Classes.FFloatProperty);
		WetLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetLevel");
		WetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetLevel", Classes.FFloatProperty);
		DryLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryLevel");
		DryLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryLevel", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Bypass_PropertyAddress, intPtr, "bBypass");
		Bypass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBypass");
		Bypass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBypass", Classes.FBoolProperty);
		FSubmixEffectReverbSettings_IsValid = intPtr != IntPtr.Zero && BypassEarlyReflections_IsValid && ReflectionsDelay_IsValid && GainHF_IsValid && ReflectionsGain_IsValid && BypassLateReflections_IsValid && LateDelay_IsValid && DecayTime_IsValid && Density_IsValid && Diffusion_IsValid && AirAbsorptionGainHF_IsValid && DecayHFRatio_IsValid && LateGain_IsValid && Gain_IsValid && WetLevel_IsValid && DryLevel_IsValid && Bypass_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioMixer.SubmixEffectReverbSettings", FSubmixEffectReverbSettings_IsValid);
	}
}
