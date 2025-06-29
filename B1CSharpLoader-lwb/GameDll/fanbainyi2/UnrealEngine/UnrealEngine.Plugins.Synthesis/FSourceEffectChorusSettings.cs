using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectChorusSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectChorusSettings
{
	private static bool DepthModulation_IsValid;

	private static int DepthModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusSettings:DepthModulation")]
	public FSoundModulationDestinationSettings DepthModulation;

	private static bool FrequencyModulation_IsValid;

	private static int FrequencyModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusSettings:FrequencyModulation")]
	public FSoundModulationDestinationSettings FrequencyModulation;

	private static bool FeedbackModulation_IsValid;

	private static int FeedbackModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusSettings:FeedbackModulation")]
	public FSoundModulationDestinationSettings FeedbackModulation;

	private static bool WetModulation_IsValid;

	private static int WetModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusSettings:WetModulation")]
	public FSoundModulationDestinationSettings WetModulation;

	private static bool DryModulation_IsValid;

	private static int DryModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusSettings:DryModulation")]
	public FSoundModulationDestinationSettings DryModulation;

	private static bool SpreadModulation_IsValid;

	private static int SpreadModulation_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectChorusSettings:SpreadModulation")]
	public FSoundModulationDestinationSettings SpreadModulation;

	private static bool FSourceEffectChorusSettings_IsValid;

	private static int FSourceEffectChorusSettings_StructSize;

	public FSourceEffectChorusSettings Copy()
	{
		return this;
	}

	public static FSourceEffectChorusSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectChorusSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectChorusSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectChorusSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectChorusSettings(nativeBuffer + arrayIndex * FSourceEffectChorusSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectChorusSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectChorusSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectChorusSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectChorusSettings");
			return;
		}
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, DepthModulation_Offset), DepthModulation);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, FrequencyModulation_Offset), FrequencyModulation);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, FeedbackModulation_Offset), FeedbackModulation);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, WetModulation_Offset), WetModulation);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, DryModulation_Offset), DryModulation);
		FSoundModulationDestinationSettings.ToNative(IntPtr.Add(nativeStruct, SpreadModulation_Offset), SpreadModulation);
	}

	public FSourceEffectChorusSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectChorusSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectChorusSettings");
			DepthModulation = default(FSoundModulationDestinationSettings);
			FrequencyModulation = default(FSoundModulationDestinationSettings);
			FeedbackModulation = default(FSoundModulationDestinationSettings);
			WetModulation = default(FSoundModulationDestinationSettings);
			DryModulation = default(FSoundModulationDestinationSettings);
			SpreadModulation = default(FSoundModulationDestinationSettings);
		}
		else
		{
			DepthModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, DepthModulation_Offset));
			FrequencyModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, FrequencyModulation_Offset));
			FeedbackModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, FeedbackModulation_Offset));
			WetModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, WetModulation_Offset));
			DryModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, DryModulation_Offset));
			SpreadModulation = FSoundModulationDestinationSettings.FromNative(IntPtr.Add(nativeStruct, SpreadModulation_Offset));
		}
	}

	static FSourceEffectChorusSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectChorusSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectChorusSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectChorusSettings");
		FSourceEffectChorusSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		DepthModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DepthModulation");
		DepthModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DepthModulation", Classes.FStructProperty);
		FrequencyModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrequencyModulation");
		FrequencyModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrequencyModulation", Classes.FStructProperty);
		FeedbackModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FeedbackModulation");
		FeedbackModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FeedbackModulation", Classes.FStructProperty);
		WetModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetModulation");
		WetModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetModulation", Classes.FStructProperty);
		DryModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryModulation");
		DryModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryModulation", Classes.FStructProperty);
		SpreadModulation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpreadModulation");
		SpreadModulation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpreadModulation", Classes.FStructProperty);
		FSourceEffectChorusSettings_IsValid = intPtr != IntPtr.Zero && DepthModulation_IsValid && FrequencyModulation_IsValid && FeedbackModulation_IsValid && WetModulation_IsValid && DryModulation_IsValid && SpreadModulation_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectChorusSettings", FSourceEffectChorusSettings_IsValid);
	}
}
