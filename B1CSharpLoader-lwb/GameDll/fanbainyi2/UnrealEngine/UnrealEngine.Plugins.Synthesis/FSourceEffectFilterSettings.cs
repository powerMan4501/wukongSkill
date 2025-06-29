using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectFilterSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectFilterSettings
{
	private static bool FilterCircuit_IsValid;

	private static FFieldAddress FilterCircuit_PropertyAddress;

	private static int FilterCircuit_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterSettings:FilterCircuit")]
	public ESourceEffectFilterCircuit FilterCircuit;

	private static bool FilterType_IsValid;

	private static FFieldAddress FilterType_PropertyAddress;

	private static int FilterType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterSettings:FilterType")]
	public ESourceEffectFilterType FilterType;

	private static bool CutoffFrequency_IsValid;

	private static int CutoffFrequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterSettings:CutoffFrequency")]
	public float CutoffFrequency;

	private static bool FilterQ_IsValid;

	private static int FilterQ_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterSettings:FilterQ")]
	public float FilterQ;

	private static bool AudioBusModulation_IsValid;

	private static FFieldAddress AudioBusModulation_PropertyAddress;

	private static int AudioBusModulation_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectFilterSettings:AudioBusModulation")]
	public List<FSourceEffectFilterAudioBusModulationSettings> AudioBusModulation;

	private static bool FSourceEffectFilterSettings_IsValid;

	private static int FSourceEffectFilterSettings_StructSize;

	public FSourceEffectFilterSettings Copy()
	{
		FSourceEffectFilterSettings result = this;
		if (AudioBusModulation != null)
		{
			result.AudioBusModulation = new List<FSourceEffectFilterAudioBusModulationSettings>(AudioBusModulation);
		}
		return result;
	}

	public static FSourceEffectFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectFilterSettings(nativeBuffer + arrayIndex * FSourceEffectFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectFilterSettings");
			return;
		}
		EnumMarshaler<ESourceEffectFilterCircuit>.ToNative(IntPtr.Add(nativeStruct, FilterCircuit_Offset), 0, FilterCircuit_PropertyAddress.Address, FilterCircuit);
		EnumMarshaler<ESourceEffectFilterType>.ToNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address, FilterType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CutoffFrequency_Offset), CutoffFrequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilterQ_Offset), FilterQ);
		new TArrayCopyMarshaler<FSourceEffectFilterAudioBusModulationSettings>(1, AudioBusModulation_PropertyAddress, CachedMarshalingDelegates<FSourceEffectFilterAudioBusModulationSettings, FSourceEffectFilterAudioBusModulationSettings>.FromNative, CachedMarshalingDelegates<FSourceEffectFilterAudioBusModulationSettings, FSourceEffectFilterAudioBusModulationSettings>.ToNative).ToNative(IntPtr.Add(nativeStruct, AudioBusModulation_Offset), AudioBusModulation);
	}

	public FSourceEffectFilterSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectFilterSettings");
			FilterCircuit = ESourceEffectFilterCircuit.OnePole;
			FilterType = ESourceEffectFilterType.LowPass;
			CutoffFrequency = 0f;
			FilterQ = 0f;
			AudioBusModulation = null;
		}
		else
		{
			FilterCircuit = EnumMarshaler<ESourceEffectFilterCircuit>.FromNative(IntPtr.Add(nativeStruct, FilterCircuit_Offset), 0, FilterCircuit_PropertyAddress.Address);
			FilterType = EnumMarshaler<ESourceEffectFilterType>.FromNative(IntPtr.Add(nativeStruct, FilterType_Offset), 0, FilterType_PropertyAddress.Address);
			CutoffFrequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CutoffFrequency_Offset));
			FilterQ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilterQ_Offset));
			AudioBusModulation = new TArrayCopyMarshaler<FSourceEffectFilterAudioBusModulationSettings>(1, AudioBusModulation_PropertyAddress, CachedMarshalingDelegates<FSourceEffectFilterAudioBusModulationSettings, FSourceEffectFilterAudioBusModulationSettings>.FromNative, CachedMarshalingDelegates<FSourceEffectFilterAudioBusModulationSettings, FSourceEffectFilterAudioBusModulationSettings>.ToNative).FromNative(IntPtr.Add(nativeStruct, AudioBusModulation_Offset));
		}
	}

	static FSourceEffectFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectFilterSettings");
		FSourceEffectFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FilterCircuit_PropertyAddress, intPtr, "FilterCircuit");
		FilterCircuit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterCircuit");
		FilterCircuit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterCircuit", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterType_PropertyAddress, intPtr, "FilterType");
		FilterType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterType");
		FilterType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterType", Classes.FEnumProperty);
		CutoffFrequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CutoffFrequency");
		CutoffFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CutoffFrequency", Classes.FFloatProperty);
		FilterQ_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilterQ");
		FilterQ_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilterQ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AudioBusModulation_PropertyAddress, intPtr, "AudioBusModulation");
		AudioBusModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AudioBusModulation");
		AudioBusModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AudioBusModulation", Classes.FArrayProperty);
		FSourceEffectFilterSettings_IsValid = intPtr != IntPtr.Zero && FilterCircuit_IsValid && FilterType_IsValid && CutoffFrequency_IsValid && FilterQ_IsValid && AudioBusModulation_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectFilterSettings", FSourceEffectFilterSettings_IsValid);
	}
}
