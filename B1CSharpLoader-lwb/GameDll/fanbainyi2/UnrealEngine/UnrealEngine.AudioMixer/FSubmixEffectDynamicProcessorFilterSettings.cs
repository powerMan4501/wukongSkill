using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings", "AudioMixer", UnrealModuleType.Engine)]
public struct FSubmixEffectDynamicProcessorFilterSettings
{
	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings:bEnabled")]
	public bool Enabled;

	private static bool Cutoff_IsValid;

	private static int Cutoff_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings:Cutoff")]
	public float Cutoff;

	private static bool GainDb_IsValid;

	private static int GainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings:GainDb")]
	public float GainDb;

	private static bool FSubmixEffectDynamicProcessorFilterSettings_IsValid;

	private static int FSubmixEffectDynamicProcessorFilterSettings_StructSize;

	public FSubmixEffectDynamicProcessorFilterSettings Copy()
	{
		return this;
	}

	public static FSubmixEffectDynamicProcessorFilterSettings FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectDynamicProcessorFilterSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectDynamicProcessorFilterSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectDynamicProcessorFilterSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectDynamicProcessorFilterSettings(nativeBuffer + arrayIndex * FSubmixEffectDynamicProcessorFilterSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectDynamicProcessorFilterSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectDynamicProcessorFilterSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectDynamicProcessorFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Cutoff_Offset), Cutoff);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GainDb_Offset), GainDb);
	}

	public FSubmixEffectDynamicProcessorFilterSettings(IntPtr nativeStruct)
	{
		if (!FSubmixEffectDynamicProcessorFilterSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings");
			Enabled = false;
			Cutoff = 0f;
			GainDb = 0f;
		}
		else
		{
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
			Cutoff = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Cutoff_Offset));
			GainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GainDb_Offset));
		}
	}

	static FSubmixEffectDynamicProcessorFilterSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectDynamicProcessorFilterSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectDynamicProcessorFilterSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings");
		FSubmixEffectDynamicProcessorFilterSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		Cutoff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Cutoff");
		Cutoff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Cutoff", Classes.FFloatProperty);
		GainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GainDb");
		GainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GainDb", Classes.FFloatProperty);
		FSubmixEffectDynamicProcessorFilterSettings_IsValid = intPtr != IntPtr.Zero && Enabled_IsValid && Cutoff_IsValid && GainDb_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioMixer.SubmixEffectDynamicProcessorFilterSettings", FSubmixEffectDynamicProcessorFilterSettings_IsValid);
	}
}
