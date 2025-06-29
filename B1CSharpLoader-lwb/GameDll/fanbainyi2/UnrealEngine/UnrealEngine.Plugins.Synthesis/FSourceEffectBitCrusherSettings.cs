using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectBitCrusherSettings
{
	private static bool SampleRateModulation_IsValid;

	private static int SampleRateModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherSettings:SampleRateModulation")]
	public FSoundModulationDestinationSettings SampleRateModulation;

	private static bool BitModulation_IsValid;

	private static int BitModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectBitCrusherSettings:BitModulation")]
	public FSoundModulationDestinationSettings BitModulation;

	private static bool FSourceEffectBitCrusherSettings_IsValid;

	private static int FSourceEffectBitCrusherSettings_StructSize;

	public FSourceEffectBitCrusherSettings Copy()
	{
		return this;
	}

	public static FSourceEffectBitCrusherSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectBitCrusherSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectBitCrusherSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectBitCrusherSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectBitCrusherSettings(nativeBuffer + arrayIndex * FSourceEffectBitCrusherSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectBitCrusherSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectBitCrusherSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectBitCrusherSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectBitCrusherSettings");
			return;
		}
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, SampleRateModulation_Offset), SampleRateModulation);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, BitModulation_Offset), BitModulation);
	}

	public FSourceEffectBitCrusherSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectBitCrusherSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectBitCrusherSettings");
			SampleRateModulation = default(FSoundModulationDestinationSettings);
			BitModulation = default(FSoundModulationDestinationSettings);
		}
		else
		{
			SampleRateModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, SampleRateModulation_Offset));
			BitModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, BitModulation_Offset));
		}
	}

	static FSourceEffectBitCrusherSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectBitCrusherSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectBitCrusherSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectBitCrusherSettings");
		FSourceEffectBitCrusherSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		SampleRateModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SampleRateModulation");
		SampleRateModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SampleRateModulation", Classes.FStructProperty);
		BitModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BitModulation");
		BitModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BitModulation", Classes.FStructProperty);
		FSourceEffectBitCrusherSettings_IsValid = intPtr != IntPtr.Zero && SampleRateModulation_IsValid && BitModulation_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectBitCrusherSettings", FSourceEffectBitCrusherSettings_IsValid);
	}
}
