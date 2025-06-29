using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ModularSynthPresetBankEntry", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FModularSynthPresetBankEntry
{
	private static bool PresetName_IsValid;

	private static int PresetName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPresetBankEntry:PresetName")]
	public string PresetName;

	private static bool Preset_IsValid;

	private static int Preset_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/Synthesis.ModularSynthPresetBankEntry:Preset")]
	public FModularSynthPreset Preset;

	private static bool FModularSynthPresetBankEntry_IsValid;

	private static int FModularSynthPresetBankEntry_StructSize;

	public FModularSynthPresetBankEntry Copy()
	{
		return this;
	}

	public static FModularSynthPresetBankEntry FromNative(IntPtr nativeBuffer)
	{
		return new FModularSynthPresetBankEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FModularSynthPresetBankEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FModularSynthPresetBankEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FModularSynthPresetBankEntry(nativeBuffer + arrayIndex * FModularSynthPresetBankEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FModularSynthPresetBankEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FModularSynthPresetBankEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FModularSynthPresetBankEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.ModularSynthPresetBankEntry");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, PresetName_Offset), PresetName);
		FModularSynthPreset.ToNative(IntPtr.Add(nativeStruct, Preset_Offset), Preset);
	}

	public FModularSynthPresetBankEntry(IntPtr nativeStruct)
	{
		if (!FModularSynthPresetBankEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.ModularSynthPresetBankEntry");
			PresetName = FStringMarshaler.DefaultString;
			Preset = default(FModularSynthPreset);
		}
		else
		{
			PresetName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, PresetName_Offset));
			Preset = FModularSynthPreset.FromNative(IntPtr.Add(nativeStruct, Preset_Offset));
		}
	}

	static FModularSynthPresetBankEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FModularSynthPresetBankEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FModularSynthPresetBankEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.ModularSynthPresetBankEntry");
		FModularSynthPresetBankEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		PresetName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PresetName");
		PresetName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PresetName", Classes.FStrProperty);
		Preset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Preset");
		Preset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Preset", Classes.FStructProperty);
		FModularSynthPresetBankEntry_IsValid = intPtr != IntPtr.Zero && PresetName_IsValid && Preset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.ModularSynthPresetBankEntry", FModularSynthPresetBankEntry_IsValid);
	}
}
