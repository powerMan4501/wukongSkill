using System;
using System.Collections.Generic;
using UnrealEngine.AudioMixer;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSubmixEffectMultibandCompressorSettings
{
	private static bool DynamicsProcessorType_IsValid;

	private static FFieldAddress DynamicsProcessorType_PropertyAddress;

	private static int DynamicsProcessorType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:DynamicsProcessorType")]
	public ESubmixEffectDynamicsProcessorType DynamicsProcessorType;

	private static bool PeakMode_IsValid;

	private static FFieldAddress PeakMode_PropertyAddress;

	private static int PeakMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:PeakMode")]
	public ESubmixEffectDynamicsPeakMode PeakMode;

	private static bool LinkMode_IsValid;

	private static FFieldAddress LinkMode_PropertyAddress;

	private static int LinkMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:LinkMode")]
	public ESubmixEffectDynamicsChannelLinkMode LinkMode;

	private static bool LookAheadMsec_IsValid;

	private static int LookAheadMsec_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:LookAheadMsec")]
	public float LookAheadMsec;

	private static bool AnalogMode_IsValid;

	private static FFieldAddress AnalogMode_PropertyAddress;

	private static int AnalogMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:bAnalogMode")]
	public bool AnalogMode;

	private static bool FourPole_IsValid;

	private static FFieldAddress FourPole_PropertyAddress;

	private static int FourPole_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:bFourPole")]
	public bool FourPole;

	private static bool Bypass_IsValid;

	private static FFieldAddress Bypass_PropertyAddress;

	private static int Bypass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:bBypass")]
	public bool Bypass;

	private static bool KeySource_IsValid;

	private static FFieldAddress KeySource_PropertyAddress;

	private static int KeySource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:KeySource")]
	public ESubmixEffectDynamicsKeySource KeySource;

	private static bool ExternalAudioBus_IsValid;

	private static int ExternalAudioBus_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:ExternalAudioBus")]
	public UAudioBus ExternalAudioBus;

	private static bool ExternalSubmix_IsValid;

	private static int ExternalSubmix_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:ExternalSubmix")]
	public USoundSubmix ExternalSubmix;

	private static bool KeyGainDb_IsValid;

	private static int KeyGainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:KeyGainDb")]
	public float KeyGainDb;

	private static bool KeyAudition_IsValid;

	private static FFieldAddress KeyAudition_PropertyAddress;

	private static int KeyAudition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:bKeyAudition")]
	public bool KeyAudition;

	private static bool Bands_IsValid;

	private static FFieldAddress Bands_PropertyAddress;

	private static int Bands_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Synthesis.SubmixEffectMultibandCompressorSettings:Bands")]
	public List<FDynamicsBandSettings> Bands;

	private static bool FSubmixEffectMultibandCompressorSettings_IsValid;

	private static int FSubmixEffectMultibandCompressorSettings_StructSize;

	public FSubmixEffectMultibandCompressorSettings Copy()
	{
		FSubmixEffectMultibandCompressorSettings result = this;
		if (Bands != null)
		{
			result.Bands = new List<FDynamicsBandSettings>(Bands);
		}
		return result;
	}

	public static FSubmixEffectMultibandCompressorSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectMultibandCompressorSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectMultibandCompressorSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectMultibandCompressorSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectMultibandCompressorSettings(nativeBuffer + arrayIndex * FSubmixEffectMultibandCompressorSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectMultibandCompressorSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectMultibandCompressorSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectMultibandCompressorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorSettings");
			return;
		}
		EnumMarshaler<ESubmixEffectDynamicsProcessorType>.ToNative(IntPtr.Add(nativeStruct, DynamicsProcessorType_Offset), 0, DynamicsProcessorType_PropertyAddress.Address, DynamicsProcessorType);
		EnumMarshaler<ESubmixEffectDynamicsPeakMode>.ToNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address, PeakMode);
		EnumMarshaler<ESubmixEffectDynamicsChannelLinkMode>.ToNative(IntPtr.Add(nativeStruct, LinkMode_Offset), 0, LinkMode_PropertyAddress.Address, LinkMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LookAheadMsec_Offset), LookAheadMsec);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AnalogMode_Offset), 0, AnalogMode_PropertyAddress.Address, AnalogMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FourPole_Offset), 0, FourPole_PropertyAddress.Address, FourPole);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address, Bypass);
		EnumMarshaler<ESubmixEffectDynamicsKeySource>.ToNative(IntPtr.Add(nativeStruct, KeySource_Offset), 0, KeySource_PropertyAddress.Address, KeySource);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(nativeStruct, ExternalAudioBus_Offset), ExternalAudioBus);
		UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(nativeStruct, ExternalSubmix_Offset), ExternalSubmix);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, KeyGainDb_Offset), KeyGainDb);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, KeyAudition_Offset), 0, KeyAudition_PropertyAddress.Address, KeyAudition);
		new TArrayCopyMarshaler<FDynamicsBandSettings>(1, Bands_PropertyAddress, CachedMarshalingDelegates<FDynamicsBandSettings, FDynamicsBandSettings>.FromNative, CachedMarshalingDelegates<FDynamicsBandSettings, FDynamicsBandSettings>.ToNative).ToNative(IntPtr.Add(nativeStruct, Bands_Offset), Bands);
	}

	public FSubmixEffectMultibandCompressorSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectMultibandCompressorSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SubmixEffectMultibandCompressorSettings");
			DynamicsProcessorType = ESubmixEffectDynamicsProcessorType.Compressor;
			PeakMode = ESubmixEffectDynamicsPeakMode.MeanSquared;
			LinkMode = ESubmixEffectDynamicsChannelLinkMode.Disabled;
			LookAheadMsec = 0f;
			AnalogMode = false;
			FourPole = false;
			Bypass = false;
			KeySource = ESubmixEffectDynamicsKeySource.Default;
			ExternalAudioBus = null;
			ExternalSubmix = null;
			KeyGainDb = 0f;
			KeyAudition = false;
			Bands = null;
		}
		else
		{
			DynamicsProcessorType = EnumMarshaler<ESubmixEffectDynamicsProcessorType>.FromNative(IntPtr.Add(nativeStruct, DynamicsProcessorType_Offset), 0, DynamicsProcessorType_PropertyAddress.Address);
			PeakMode = EnumMarshaler<ESubmixEffectDynamicsPeakMode>.FromNative(IntPtr.Add(nativeStruct, PeakMode_Offset), 0, PeakMode_PropertyAddress.Address);
			LinkMode = EnumMarshaler<ESubmixEffectDynamicsChannelLinkMode>.FromNative(IntPtr.Add(nativeStruct, LinkMode_Offset), 0, LinkMode_PropertyAddress.Address);
			LookAheadMsec = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LookAheadMsec_Offset));
			AnalogMode = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AnalogMode_Offset), 0, AnalogMode_PropertyAddress.Address);
			FourPole = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FourPole_Offset), 0, FourPole_PropertyAddress.Address);
			Bypass = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Bypass_Offset), 0, Bypass_PropertyAddress.Address);
			KeySource = EnumMarshaler<ESubmixEffectDynamicsKeySource>.FromNative(IntPtr.Add(nativeStruct, KeySource_Offset), 0, KeySource_PropertyAddress.Address);
			ExternalAudioBus = UObjectMarshaler<UAudioBus>.FromNative(IntPtr.Add(nativeStruct, ExternalAudioBus_Offset));
			ExternalSubmix = UObjectMarshaler<USoundSubmix>.FromNative(IntPtr.Add(nativeStruct, ExternalSubmix_Offset));
			KeyGainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, KeyGainDb_Offset));
			KeyAudition = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, KeyAudition_Offset), 0, KeyAudition_PropertyAddress.Address);
			Bands = new TArrayCopyMarshaler<FDynamicsBandSettings>(1, Bands_PropertyAddress, CachedMarshalingDelegates<FDynamicsBandSettings, FDynamicsBandSettings>.FromNative, CachedMarshalingDelegates<FDynamicsBandSettings, FDynamicsBandSettings>.ToNative).FromNative(IntPtr.Add(nativeStruct, Bands_Offset));
		}
	}

	static FSubmixEffectMultibandCompressorSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectMultibandCompressorSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectMultibandCompressorSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SubmixEffectMultibandCompressorSettings");
		FSubmixEffectMultibandCompressorSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DynamicsProcessorType_PropertyAddress, intPtr, "DynamicsProcessorType");
		DynamicsProcessorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicsProcessorType");
		DynamicsProcessorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicsProcessorType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref PeakMode_PropertyAddress, intPtr, "PeakMode");
		PeakMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PeakMode");
		PeakMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PeakMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LinkMode_PropertyAddress, intPtr, "LinkMode");
		LinkMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LinkMode");
		LinkMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LinkMode", Classes.FEnumProperty);
		LookAheadMsec_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LookAheadMsec");
		LookAheadMsec_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LookAheadMsec", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AnalogMode_PropertyAddress, intPtr, "bAnalogMode");
		AnalogMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnalogMode");
		AnalogMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnalogMode", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FourPole_PropertyAddress, intPtr, "bFourPole");
		FourPole_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFourPole");
		FourPole_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFourPole", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Bypass_PropertyAddress, intPtr, "bBypass");
		Bypass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBypass");
		Bypass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBypass", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref KeySource_PropertyAddress, intPtr, "KeySource");
		KeySource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeySource");
		KeySource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeySource", Classes.FEnumProperty);
		ExternalAudioBus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalAudioBus");
		ExternalAudioBus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalAudioBus", Classes.FObjectProperty);
		ExternalSubmix_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExternalSubmix");
		ExternalSubmix_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExternalSubmix", Classes.FObjectProperty);
		KeyGainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeyGainDb");
		KeyGainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeyGainDb", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref KeyAudition_PropertyAddress, intPtr, "bKeyAudition");
		KeyAudition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bKeyAudition");
		KeyAudition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bKeyAudition", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Bands_PropertyAddress, intPtr, "Bands");
		Bands_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bands");
		Bands_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bands", Classes.FArrayProperty);
		FSubmixEffectMultibandCompressorSettings_IsValid = intPtr != IntPtr.Zero && DynamicsProcessorType_IsValid && PeakMode_IsValid && LinkMode_IsValid && LookAheadMsec_IsValid && AnalogMode_IsValid && FourPole_IsValid && Bypass_IsValid && KeySource_IsValid && ExternalAudioBus_IsValid && ExternalSubmix_IsValid && KeyGainDb_IsValid && KeyAudition_IsValid && Bands_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SubmixEffectMultibandCompressorSettings", FSubmixEffectMultibandCompressorSettings_IsValid);
	}
}
