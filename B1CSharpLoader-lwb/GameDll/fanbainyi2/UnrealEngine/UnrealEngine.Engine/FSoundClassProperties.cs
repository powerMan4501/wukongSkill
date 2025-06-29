using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundClassProperties", "Engine", UnrealModuleType.Engine)]
public struct FSoundClassProperties
{
	private static bool Volume_IsValid;

	private static int Volume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:Volume")]
	public float Volume;

	private static bool Pitch_IsValid;

	private static int Pitch_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:Pitch")]
	public float Pitch;

	private static bool LowPassFilterFrequency_IsValid;

	private static int LowPassFilterFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:LowPassFilterFrequency")]
	public float LowPassFilterFrequency;

	private static bool AttenuationDistanceScale_IsValid;

	private static int AttenuationDistanceScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:AttenuationDistanceScale")]
	public float AttenuationDistanceScale;

	private static bool LFEBleed_IsValid;

	private static int LFEBleed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:LFEBleed")]
	public float LFEBleed;

	private static bool VoiceCenterChannelVolume_IsValid;

	private static int VoiceCenterChannelVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:VoiceCenterChannelVolume")]
	public float VoiceCenterChannelVolume;

	private static bool RadioFilterVolume_IsValid;

	private static int RadioFilterVolume_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:RadioFilterVolume")]
	public float RadioFilterVolume;

	private static bool RadioFilterVolumeThreshold_IsValid;

	private static int RadioFilterVolumeThreshold_Offset;

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:RadioFilterVolumeThreshold")]
	public float RadioFilterVolumeThreshold;

	private static bool ApplyEffects_IsValid;

	private static FFieldAddress ApplyEffects_PropertyAddress;

	private static int ApplyEffects_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:bApplyEffects")]
	public bool ApplyEffects;

	private static bool AlwaysPlay_IsValid;

	private static FFieldAddress AlwaysPlay_PropertyAddress;

	private static int AlwaysPlay_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:bAlwaysPlay")]
	public bool AlwaysPlay;

	private static bool IsUISound_IsValid;

	private static FFieldAddress IsUISound_PropertyAddress;

	private static int IsUISound_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:bIsUISound")]
	public bool IsUISound;

	private static bool IsMusic_IsValid;

	private static FFieldAddress IsMusic_PropertyAddress;

	private static int IsMusic_Offset;

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:bIsMusic")]
	public bool IsMusic;

	private static bool CenterChannelOnly_IsValid;

	private static FFieldAddress CenterChannelOnly_PropertyAddress;

	private static int CenterChannelOnly_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:bCenterChannelOnly")]
	public bool CenterChannelOnly;

	private static bool ApplyAmbientVolumes_IsValid;

	private static FFieldAddress ApplyAmbientVolumes_PropertyAddress;

	private static int ApplyAmbientVolumes_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:bApplyAmbientVolumes")]
	public bool ApplyAmbientVolumes;

	private static bool Reverb_IsValid;

	private static FFieldAddress Reverb_PropertyAddress;

	private static int Reverb_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:bReverb")]
	public bool Reverb;

	private static bool Default2DReverbSendAmount_IsValid;

	private static int Default2DReverbSendAmount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:Default2DReverbSendAmount")]
	public float Default2DReverbSendAmount;

	private static bool ModulationSettings_IsValid;

	private static int ModulationSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:ModulationSettings")]
	public FSoundModulationDefaultSettings ModulationSettings;

	private static bool OutputTarget_IsValid;

	private static FFieldAddress OutputTarget_PropertyAddress;

	private static int OutputTarget_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:OutputTarget")]
	public EAudioOutputTarget OutputTarget;

	private static bool LoadingBehavior_IsValid;

	private static FFieldAddress LoadingBehavior_PropertyAddress;

	private static int LoadingBehavior_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:LoadingBehavior")]
	public ESoundWaveLoadingBehavior LoadingBehavior;

	private static bool DefaultSubmix_IsValid;

	private static int DefaultSubmix_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.SoundClassProperties:DefaultSubmix")]
	public USoundSubmix DefaultSubmix;

	private static bool FSoundClassProperties_IsValid;

	private static int FSoundClassProperties_StructSize;

	public FSoundClassProperties Copy()
	{
		return this;
	}

	public static FSoundClassProperties FromNative(IntPtr nativeBuffer)
	{
		return new FSoundClassProperties(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSoundClassProperties value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSoundClassProperties FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoundClassProperties(nativeBuffer + arrayIndex * FSoundClassProperties_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoundClassProperties value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSoundClassProperties_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSoundClassProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundClassProperties");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Volume_Offset), Volume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Pitch_Offset), Pitch);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LowPassFilterFrequency_Offset), LowPassFilterFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttenuationDistanceScale_Offset), AttenuationDistanceScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LFEBleed_Offset), LFEBleed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VoiceCenterChannelVolume_Offset), VoiceCenterChannelVolume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RadioFilterVolume_Offset), RadioFilterVolume);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RadioFilterVolumeThreshold_Offset), RadioFilterVolumeThreshold);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyEffects_Offset), 0, ApplyEffects_PropertyAddress.Address, ApplyEffects);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AlwaysPlay_Offset), 0, AlwaysPlay_PropertyAddress.Address, AlwaysPlay);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsUISound_Offset), 0, IsUISound_PropertyAddress.Address, IsUISound);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsMusic_Offset), 0, IsMusic_PropertyAddress.Address, IsMusic);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CenterChannelOnly_Offset), 0, CenterChannelOnly_PropertyAddress.Address, CenterChannelOnly);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyAmbientVolumes_Offset), 0, ApplyAmbientVolumes_PropertyAddress.Address, ApplyAmbientVolumes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Reverb_Offset), 0, Reverb_PropertyAddress.Address, Reverb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Default2DReverbSendAmount_Offset), Default2DReverbSendAmount);
		FSoundModulationDefaultSettings.ToNative(IntPtr.Add(nativeStruct, ModulationSettings_Offset), ModulationSettings);
		EnumMarshaler<EAudioOutputTarget>.ToNative(IntPtr.Add(nativeStruct, OutputTarget_Offset), 0, OutputTarget_PropertyAddress.Address, OutputTarget);
		EnumMarshaler<ESoundWaveLoadingBehavior>.ToNative(IntPtr.Add(nativeStruct, LoadingBehavior_Offset), 0, LoadingBehavior_PropertyAddress.Address, LoadingBehavior);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(nativeStruct, DefaultSubmix_Offset), DefaultSubmix);
	}

	public FSoundClassProperties(IntPtr nativeStruct)
	{
		if (!FSoundClassProperties_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SoundClassProperties");
			Volume = 0f;
			Pitch = 0f;
			LowPassFilterFrequency = 0f;
			AttenuationDistanceScale = 0f;
			LFEBleed = 0f;
			VoiceCenterChannelVolume = 0f;
			RadioFilterVolume = 0f;
			RadioFilterVolumeThreshold = 0f;
			ApplyEffects = false;
			AlwaysPlay = false;
			IsUISound = false;
			IsMusic = false;
			CenterChannelOnly = false;
			ApplyAmbientVolumes = false;
			Reverb = false;
			Default2DReverbSendAmount = 0f;
			ModulationSettings = default(FSoundModulationDefaultSettings);
			OutputTarget = EAudioOutputTarget.Speaker;
			LoadingBehavior = ESoundWaveLoadingBehavior.Inherited;
			DefaultSubmix = null;
		}
		else
		{
			Volume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Volume_Offset));
			Pitch = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Pitch_Offset));
			LowPassFilterFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LowPassFilterFrequency_Offset));
			AttenuationDistanceScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttenuationDistanceScale_Offset));
			LFEBleed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LFEBleed_Offset));
			VoiceCenterChannelVolume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VoiceCenterChannelVolume_Offset));
			RadioFilterVolume = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RadioFilterVolume_Offset));
			RadioFilterVolumeThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RadioFilterVolumeThreshold_Offset));
			ApplyEffects = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyEffects_Offset), 0, ApplyEffects_PropertyAddress.Address);
			AlwaysPlay = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AlwaysPlay_Offset), 0, AlwaysPlay_PropertyAddress.Address);
			IsUISound = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsUISound_Offset), 0, IsUISound_PropertyAddress.Address);
			IsMusic = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsMusic_Offset), 0, IsMusic_PropertyAddress.Address);
			CenterChannelOnly = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CenterChannelOnly_Offset), 0, CenterChannelOnly_PropertyAddress.Address);
			ApplyAmbientVolumes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyAmbientVolumes_Offset), 0, ApplyAmbientVolumes_PropertyAddress.Address);
			Reverb = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Reverb_Offset), 0, Reverb_PropertyAddress.Address);
			Default2DReverbSendAmount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Default2DReverbSendAmount_Offset));
			ModulationSettings = FSoundModulationDefaultSettings.FromNative(IntPtr.Add(nativeStruct, ModulationSettings_Offset));
			OutputTarget = EnumMarshaler<EAudioOutputTarget>.FromNative(IntPtr.Add(nativeStruct, OutputTarget_Offset), 0, OutputTarget_PropertyAddress.Address);
			LoadingBehavior = EnumMarshaler<ESoundWaveLoadingBehavior>.FromNative(IntPtr.Add(nativeStruct, LoadingBehavior_Offset), 0, LoadingBehavior_PropertyAddress.Address);
			DefaultSubmix = UObjectMarshaler<USoundSubmix>.FromNative(IntPtr.Add(nativeStruct, DefaultSubmix_Offset));
		}
	}

	static FSoundClassProperties()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSoundClassProperties)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSoundClassProperties));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SoundClassProperties");
		FSoundClassProperties_StructSize = NativeReflection.GetStructSize(intPtr);
		Volume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Volume");
		Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Volume", Classes.FFloatProperty);
		Pitch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pitch");
		Pitch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pitch", Classes.FFloatProperty);
		LowPassFilterFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LowPassFilterFrequency");
		LowPassFilterFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LowPassFilterFrequency", Classes.FFloatProperty);
		AttenuationDistanceScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationDistanceScale");
		AttenuationDistanceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationDistanceScale", Classes.FFloatProperty);
		LFEBleed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LFEBleed");
		LFEBleed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LFEBleed", Classes.FFloatProperty);
		VoiceCenterChannelVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VoiceCenterChannelVolume");
		VoiceCenterChannelVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VoiceCenterChannelVolume", Classes.FFloatProperty);
		RadioFilterVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RadioFilterVolume");
		RadioFilterVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RadioFilterVolume", Classes.FFloatProperty);
		RadioFilterVolumeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RadioFilterVolumeThreshold");
		RadioFilterVolumeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RadioFilterVolumeThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyEffects_PropertyAddress, intPtr, "bApplyEffects");
		ApplyEffects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyEffects");
		ApplyEffects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyEffects", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysPlay_PropertyAddress, intPtr, "bAlwaysPlay");
		AlwaysPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlwaysPlay");
		AlwaysPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlwaysPlay", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUISound_PropertyAddress, intPtr, "bIsUISound");
		IsUISound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsUISound");
		IsUISound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsUISound", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMusic_PropertyAddress, intPtr, "bIsMusic");
		IsMusic_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsMusic");
		IsMusic_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsMusic", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CenterChannelOnly_PropertyAddress, intPtr, "bCenterChannelOnly");
		CenterChannelOnly_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCenterChannelOnly");
		CenterChannelOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCenterChannelOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyAmbientVolumes_PropertyAddress, intPtr, "bApplyAmbientVolumes");
		ApplyAmbientVolumes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyAmbientVolumes");
		ApplyAmbientVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyAmbientVolumes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Reverb_PropertyAddress, intPtr, "bReverb");
		Reverb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReverb");
		Reverb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReverb", Classes.FBoolProperty);
		Default2DReverbSendAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Default2DReverbSendAmount");
		Default2DReverbSendAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Default2DReverbSendAmount", Classes.FFloatProperty);
		ModulationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationSettings");
		ModulationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OutputTarget_PropertyAddress, intPtr, "OutputTarget");
		OutputTarget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputTarget");
		OutputTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputTarget", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadingBehavior_PropertyAddress, intPtr, "LoadingBehavior");
		LoadingBehavior_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LoadingBehavior");
		LoadingBehavior_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LoadingBehavior", Classes.FEnumProperty);
		DefaultSubmix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultSubmix");
		DefaultSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultSubmix", Classes.FObjectProperty);
		FSoundClassProperties_IsValid = intPtr != IntPtr.Zero && Volume_IsValid && Pitch_IsValid && LowPassFilterFrequency_IsValid && AttenuationDistanceScale_IsValid && LFEBleed_IsValid && VoiceCenterChannelVolume_IsValid && RadioFilterVolume_IsValid && RadioFilterVolumeThreshold_IsValid && ApplyEffects_IsValid && AlwaysPlay_IsValid && IsUISound_IsValid && IsMusic_IsValid && CenterChannelOnly_IsValid && ApplyAmbientVolumes_IsValid && Reverb_IsValid && Default2DReverbSendAmount_IsValid && ModulationSettings_IsValid && OutputTarget_IsValid && LoadingBehavior_IsValid && DefaultSubmix_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SoundClassProperties", FSoundClassProperties_IsValid);
	}
}
