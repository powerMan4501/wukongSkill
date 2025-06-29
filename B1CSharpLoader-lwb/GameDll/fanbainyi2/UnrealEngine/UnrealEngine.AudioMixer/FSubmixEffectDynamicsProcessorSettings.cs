using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings", "AudioMixer", UnrealModuleType.Engine)]
public struct FSubmixEffectDynamicsProcessorSettings
{
	private static bool DynamicsProcessorType_IsValid;

	private static FFieldAddress DynamicsProcessorType_PropertyAddress;

	private static int DynamicsProcessorType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:DynamicsProcessorType")]
	public ESubmixEffectDynamicsProcessorType DynamicsProcessorType;

	private static bool PeakMode_IsValid;

	private static FFieldAddress PeakMode_PropertyAddress;

	private static int PeakMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:PeakMode")]
	public ESubmixEffectDynamicsPeakMode PeakMode;

	private static bool LinkMode_IsValid;

	private static FFieldAddress LinkMode_PropertyAddress;

	private static int LinkMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:LinkMode")]
	public ESubmixEffectDynamicsChannelLinkMode LinkMode;

	private static bool InputGainDb_IsValid;

	private static int InputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:InputGainDb")]
	public float InputGainDb;

	private static bool ThresholdDb_IsValid;

	private static int ThresholdDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ThresholdDb")]
	public float ThresholdDb;

	private static bool Ratio_IsValid;

	private static int Ratio_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:Ratio")]
	public float Ratio;

	private static bool KneeBandwidthDb_IsValid;

	private static int KneeBandwidthDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KneeBandwidthDb")]
	public float KneeBandwidthDb;

	private static bool LookAheadMsec_IsValid;

	private static int LookAheadMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:LookAheadMsec")]
	public float LookAheadMsec;

	private static bool AttackTimeMsec_IsValid;

	private static int AttackTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:AttackTimeMsec")]
	public float AttackTimeMsec;

	private static bool ReleaseTimeMsec_IsValid;

	private static int ReleaseTimeMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ReleaseTimeMsec")]
	public float ReleaseTimeMsec;

	private static bool KeySource_IsValid;

	private static FFieldAddress KeySource_PropertyAddress;

	private static int KeySource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeySource")]
	public ESubmixEffectDynamicsKeySource KeySource;

	private static bool ExternalAudioBus_IsValid;

	private static int ExternalAudioBus_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ExternalAudioBus")]
	public UAudioBus ExternalAudioBus;

	private static bool ExternalSubmix_IsValid;

	private static int ExternalSubmix_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:ExternalSubmix")]
	public USoundSubmix ExternalSubmix;

	private static bool AnalogMode_IsValid;

	private static FFieldAddress AnalogMode_PropertyAddress;

	private static int AnalogMode_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:bAnalogMode")]
	public bool AnalogMode;

	private static bool Bypass_IsValid;

	private static FFieldAddress Bypass_PropertyAddress;

	private static int Bypass_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:bBypass")]
	public bool Bypass;

	private static bool KeyAudition_IsValid;

	private static FFieldAddress KeyAudition_PropertyAddress;

	private static int KeyAudition_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:bKeyAudition")]
	public bool KeyAudition;

	private static bool KeyGainDb_IsValid;

	private static int KeyGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeyGainDb")]
	public float KeyGainDb;

	private static bool OutputGainDb_IsValid;

	private static int OutputGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:OutputGainDb")]
	public float OutputGainDb;

	private static bool KeyHighshelf_IsValid;

	private static int KeyHighshelf_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeyHighshelf")]
	public FSubmixEffectDynamicProcessorFilterSettings KeyHighshelf;

	private static bool KeyLowshelf_IsValid;

	private static int KeyLowshelf_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings:KeyLowshelf")]
	public FSubmixEffectDynamicProcessorFilterSettings KeyLowshelf;

	private static bool FSubmixEffectDynamicsProcessorSettings_IsValid;

	private static int FSubmixEffectDynamicsProcessorSettings_StructSize;

	public FSubmixEffectDynamicsProcessorSettings Copy()
	{
		return this;
	}

	public static FSubmixEffectDynamicsProcessorSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectDynamicsProcessorSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectDynamicsProcessorSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectDynamicsProcessorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectDynamicsProcessorSettings(nativeBuffer + arrayIndex * FSubmixEffectDynamicsProcessorSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectDynamicsProcessorSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectDynamicsProcessorSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectDynamicsProcessorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings");
			return;
		}
		EnumMarshaler<ESubmixEffectDynamicsProcessorType>.ToNative(IntPtr.Add(nativeStruct, DynamicsProcessorType_Offset), 0, DynamicsProcessorType_PropertyAddress.Address, DynamicsProcessorType);
		EnumMarshaler<ESubmixEffectDynamicsPeakMode>.ToNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address, PeakMode);
		EnumMarshaler<ESubmixEffectDynamicsChannelLinkMode>.ToNative(IntPtr.Add(nativeStruct, LinkMode_Offset), 0, LinkMode_PropertyAddress.Address, LinkMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InputGainDb_Offset), InputGainDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset), ThresholdDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Ratio_Offset), Ratio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, KneeBandwidthDb_Offset), KneeBandwidthDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LookAheadMsec_Offset), LookAheadMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset), AttackTimeMsec);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset), ReleaseTimeMsec);
		EnumMarshaler<ESubmixEffectDynamicsKeySource>.ToNative(IntPtr.Add(nativeStruct, KeySource_Offset), 0, KeySource_PropertyAddress.Address, KeySource);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(nativeStruct, ExternalAudioBus_Offset), ExternalAudioBus);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(nativeStruct, ExternalSubmix_Offset), ExternalSubmix);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AnalogMode_Offset), 0, AnalogMode_PropertyAddress.Address, AnalogMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address, Bypass);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, KeyAudition_Offset), 0, KeyAudition_PropertyAddress.Address, KeyAudition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, KeyGainDb_Offset), KeyGainDb);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset), OutputGainDb);
		FSubmixEffectDynamicProcessorFilterSettings.ToNative(IntPtr.Add(nativeStruct, KeyHighshelf_Offset), KeyHighshelf);
		FSubmixEffectDynamicProcessorFilterSettings.ToNative(IntPtr.Add(nativeStruct, KeyLowshelf_Offset), KeyLowshelf);
	}

	public FSubmixEffectDynamicsProcessorSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectDynamicsProcessorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings");
			DynamicsProcessorType = ESubmixEffectDynamicsProcessorType.Compressor;
			PeakMode = ESubmixEffectDynamicsPeakMode.MeanSquared;
			LinkMode = ESubmixEffectDynamicsChannelLinkMode.Disabled;
			InputGainDb = 0f;
			ThresholdDb = 0f;
			Ratio = 0f;
			KneeBandwidthDb = 0f;
			LookAheadMsec = 0f;
			AttackTimeMsec = 0f;
			ReleaseTimeMsec = 0f;
			KeySource = ESubmixEffectDynamicsKeySource.Default;
			ExternalAudioBus = null;
			ExternalSubmix = null;
			AnalogMode = false;
			Bypass = false;
			KeyAudition = false;
			KeyGainDb = 0f;
			OutputGainDb = 0f;
			KeyHighshelf = default(FSubmixEffectDynamicProcessorFilterSettings);
			KeyLowshelf = default(FSubmixEffectDynamicProcessorFilterSettings);
		}
		else
		{
			DynamicsProcessorType = EnumMarshaler<ESubmixEffectDynamicsProcessorType>.FromNative(IntPtr.Add(nativeStruct, DynamicsProcessorType_Offset), 0, DynamicsProcessorType_PropertyAddress.Address);
			PeakMode = EnumMarshaler<ESubmixEffectDynamicsPeakMode>.FromNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address);
			LinkMode = EnumMarshaler<ESubmixEffectDynamicsChannelLinkMode>.FromNative(IntPtr.Add(nativeStruct, LinkMode_Offset), 0, LinkMode_PropertyAddress.Address);
			InputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InputGainDb_Offset));
			ThresholdDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ThresholdDb_Offset));
			Ratio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Ratio_Offset));
			KneeBandwidthDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, KneeBandwidthDb_Offset));
			LookAheadMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LookAheadMsec_Offset));
			AttackTimeMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackTimeMsec_Offset));
			ReleaseTimeMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReleaseTimeMsec_Offset));
			KeySource = EnumMarshaler<ESubmixEffectDynamicsKeySource>.FromNative(IntPtr.Add(nativeStruct, KeySource_Offset), 0, KeySource_PropertyAddress.Address);
			ExternalAudioBus = UObjectMarshaler<UAudioBus>.FromNative(IntPtr.Add(nativeStruct, ExternalAudioBus_Offset));
			ExternalSubmix = UObjectMarshaler<USoundSubmix>.FromNative(IntPtr.Add(nativeStruct, ExternalSubmix_Offset));
			AnalogMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AnalogMode_Offset), 0, AnalogMode_PropertyAddress.Address);
			Bypass = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address);
			KeyAudition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, KeyAudition_Offset), 0, KeyAudition_PropertyAddress.Address);
			KeyGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, KeyGainDb_Offset));
			OutputGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutputGainDb_Offset));
			KeyHighshelf = FSubmixEffectDynamicProcessorFilterSettings.FromNative(IntPtr.Add(nativeStruct, KeyHighshelf_Offset));
			KeyLowshelf = FSubmixEffectDynamicProcessorFilterSettings.FromNative(IntPtr.Add(nativeStruct, KeyLowshelf_Offset));
		}
	}

	static FSubmixEffectDynamicsProcessorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectDynamicsProcessorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectDynamicsProcessorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings");
		FSubmixEffectDynamicsProcessorSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DynamicsProcessorType_PropertyAddress, intPtr, "DynamicsProcessorType");
		DynamicsProcessorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicsProcessorType");
		DynamicsProcessorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicsProcessorType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PeakMode_PropertyAddress, intPtr, "PeakMode");
		PeakMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PeakMode");
		PeakMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PeakMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LinkMode_PropertyAddress, intPtr, "LinkMode");
		LinkMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkMode");
		LinkMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkMode", Classes.FEnumProperty);
		InputGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InputGainDb");
		InputGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InputGainDb", Classes.FFloatProperty);
		ThresholdDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ThresholdDb");
		ThresholdDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ThresholdDb", Classes.FFloatProperty);
		Ratio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Ratio");
		Ratio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Ratio", Classes.FFloatProperty);
		KneeBandwidthDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KneeBandwidthDb");
		KneeBandwidthDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KneeBandwidthDb", Classes.FFloatProperty);
		LookAheadMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LookAheadMsec");
		LookAheadMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LookAheadMsec", Classes.FFloatProperty);
		AttackTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttackTimeMsec");
		AttackTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttackTimeMsec", Classes.FFloatProperty);
		ReleaseTimeMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReleaseTimeMsec");
		ReleaseTimeMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReleaseTimeMsec", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref KeySource_PropertyAddress, intPtr, "KeySource");
		KeySource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeySource");
		KeySource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeySource", Classes.FEnumProperty);
		ExternalAudioBus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalAudioBus");
		ExternalAudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalAudioBus", Classes.FObjectProperty);
		ExternalSubmix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalSubmix");
		ExternalSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalSubmix", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AnalogMode_PropertyAddress, intPtr, "bAnalogMode");
		AnalogMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnalogMode");
		AnalogMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnalogMode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Bypass_PropertyAddress, intPtr, "bBypass");
		Bypass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBypass");
		Bypass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBypass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref KeyAudition_PropertyAddress, intPtr, "bKeyAudition");
		KeyAudition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bKeyAudition");
		KeyAudition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bKeyAudition", Classes.FBoolProperty);
		KeyGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeyGainDb");
		KeyGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeyGainDb", Classes.FFloatProperty);
		OutputGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutputGainDb");
		OutputGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutputGainDb", Classes.FFloatProperty);
		KeyHighshelf_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeyHighshelf");
		KeyHighshelf_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeyHighshelf", Classes.FStructProperty);
		KeyLowshelf_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeyLowshelf");
		KeyLowshelf_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeyLowshelf", Classes.FStructProperty);
		FSubmixEffectDynamicsProcessorSettings_IsValid = intPtr != IntPtr.Zero && DynamicsProcessorType_IsValid && PeakMode_IsValid && LinkMode_IsValid && InputGainDb_IsValid && ThresholdDb_IsValid && Ratio_IsValid && KneeBandwidthDb_IsValid && LookAheadMsec_IsValid && AttackTimeMsec_IsValid && ReleaseTimeMsec_IsValid && KeySource_IsValid && ExternalAudioBus_IsValid && ExternalSubmix_IsValid && AnalogMode_IsValid && Bypass_IsValid && KeyAudition_IsValid && KeyGainDb_IsValid && OutputGainDb_IsValid && KeyHighshelf_IsValid && KeyLowshelf_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings", FSubmixEffectDynamicsProcessorSettings_IsValid);
	}
}
