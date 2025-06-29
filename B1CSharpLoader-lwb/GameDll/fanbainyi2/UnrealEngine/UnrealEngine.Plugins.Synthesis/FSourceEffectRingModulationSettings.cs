using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Synthesis.SourceEffectRingModulationSettings", "Synthesis", UnrealModuleType.EnginePlugin)]
public struct FSourceEffectRingModulationSettings
{
	private static bool ModulatorType_IsValid;

	private static FFieldAddress ModulatorType_PropertyAddress;

	private static int ModulatorType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectRingModulationSettings:ModulatorType")]
	public ERingModulatorTypeSourceEffect ModulatorType;

	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectRingModulationSettings:Frequency")]
	public float Frequency;

	private static bool Depth_IsValid;

	private static int Depth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectRingModulationSettings:Depth")]
	public float Depth;

	private static bool DryLevel_IsValid;

	private static int DryLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectRingModulationSettings:DryLevel")]
	public float DryLevel;

	private static bool WetLevel_IsValid;

	private static int WetLevel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectRingModulationSettings:WetLevel")]
	public float WetLevel;

	private static bool AudioBusModulator_IsValid;

	private static int AudioBusModulator_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Synthesis.SourceEffectRingModulationSettings:AudioBusModulator")]
	public UAudioBus AudioBusModulator;

	private static bool FSourceEffectRingModulationSettings_IsValid;

	private static int FSourceEffectRingModulationSettings_StructSize;

	public FSourceEffectRingModulationSettings Copy()
	{
		return this;
	}

	public static FSourceEffectRingModulationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSourceEffectRingModulationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSourceEffectRingModulationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSourceEffectRingModulationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSourceEffectRingModulationSettings(nativeBuffer + arrayIndex * FSourceEffectRingModulationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSourceEffectRingModulationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSourceEffectRingModulationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSourceEffectRingModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectRingModulationSettings");
			return;
		}
		EnumMarshaler<ERingModulatorTypeSourceEffect>.ToNative(IntPtr.Add(nativeStruct, ModulatorType_Offset), 0, ModulatorType_PropertyAddress.Address, ModulatorType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Depth_Offset), Depth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DryLevel_Offset), DryLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WetLevel_Offset), WetLevel);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(nativeStruct, AudioBusModulator_Offset), AudioBusModulator);
	}

	public FSourceEffectRingModulationSettings(IntPtr nativeStruct)
	{
		if (!FSourceEffectRingModulationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Synthesis.SourceEffectRingModulationSettings");
			ModulatorType = ERingModulatorTypeSourceEffect.Sine;
			Frequency = 0f;
			Depth = 0f;
			DryLevel = 0f;
			WetLevel = 0f;
			AudioBusModulator = null;
		}
		else
		{
			ModulatorType = EnumMarshaler<ERingModulatorTypeSourceEffect>.FromNative(IntPtr.Add(nativeStruct, ModulatorType_Offset), 0, ModulatorType_PropertyAddress.Address);
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			Depth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Depth_Offset));
			DryLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DryLevel_Offset));
			WetLevel = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WetLevel_Offset));
			AudioBusModulator = UObjectMarshaler<UAudioBus>.FromNative(IntPtr.Add(nativeStruct, AudioBusModulator_Offset));
		}
	}

	static FSourceEffectRingModulationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSourceEffectRingModulationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSourceEffectRingModulationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Synthesis.SourceEffectRingModulationSettings");
		FSourceEffectRingModulationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ModulatorType_PropertyAddress, intPtr, "ModulatorType");
		ModulatorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulatorType");
		ModulatorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulatorType", Classes.FEnumProperty);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		Depth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Depth");
		Depth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Depth", Classes.FFloatProperty);
		DryLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DryLevel");
		DryLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DryLevel", Classes.FFloatProperty);
		WetLevel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WetLevel");
		WetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WetLevel", Classes.FFloatProperty);
		AudioBusModulator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AudioBusModulator");
		AudioBusModulator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AudioBusModulator", Classes.FObjectProperty);
		FSourceEffectRingModulationSettings_IsValid = intPtr != IntPtr.Zero && ModulatorType_IsValid && Frequency_IsValid && Depth_IsValid && DryLevel_IsValid && WetLevel_IsValid && AudioBusModulator_IsValid;
		NativeReflection.LogStructIsValid("/Script/Synthesis.SourceEffectRingModulationSettings", FSourceEffectRingModulationSettings_IsValid);
	}
}
