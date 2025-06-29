using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioMixer.SubmixEffectEQBand", "AudioMixer", UnrealModuleType.Engine)]
public struct FSubmixEffectEQBand
{
	private static bool Frequency_IsValid;

	private static int Frequency_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectEQBand:Frequency")]
	public float Frequency;

	private static bool Bandwidth_IsValid;

	private static int Bandwidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectEQBand:Bandwidth")]
	public float Bandwidth;

	private static bool GainDb_IsValid;

	private static int GainDb_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectEQBand:GainDb")]
	public float GainDb;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/AudioMixer.SubmixEffectEQBand:bEnabled")]
	public bool Enabled;

	private static bool FSubmixEffectEQBand_IsValid;

	private static int FSubmixEffectEQBand_StructSize;

	public FSubmixEffectEQBand Copy()
	{
		return this;
	}

	public static FSubmixEffectEQBand FromNative(IntPtr nativeBuffer)
	{
		return new FSubmixEffectEQBand(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubmixEffectEQBand value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubmixEffectEQBand FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubmixEffectEQBand(nativeBuffer + arrayIndex * FSubmixEffectEQBand_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubmixEffectEQBand value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubmixEffectEQBand_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubmixEffectEQBand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectEQBand");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Frequency_Offset), Frequency);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Bandwidth_Offset), Bandwidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GainDb_Offset), GainDb);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
	}

	public FSubmixEffectEQBand(IntPtr nativeStruct)
	{
		if (!FSubmixEffectEQBand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioMixer.SubmixEffectEQBand");
			Frequency = 0f;
			Bandwidth = 0f;
			GainDb = 0f;
			Enabled = false;
		}
		else
		{
			Frequency = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Frequency_Offset));
			Bandwidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Bandwidth_Offset));
			GainDb = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GainDb_Offset));
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
	}

	static FSubmixEffectEQBand()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubmixEffectEQBand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubmixEffectEQBand));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioMixer.SubmixEffectEQBand");
		FSubmixEffectEQBand_StructSize = NativeReflection.GetStructSize(intPtr);
		Frequency_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frequency");
		Frequency_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frequency", Classes.FFloatProperty);
		Bandwidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bandwidth");
		Bandwidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bandwidth", Classes.FFloatProperty);
		GainDb_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GainDb");
		GainDb_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GainDb", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		FSubmixEffectEQBand_IsValid = intPtr != IntPtr.Zero && Frequency_IsValid && Bandwidth_IsValid && GainDb_IsValid && Enabled_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioMixer.SubmixEffectEQBand", FSubmixEffectEQBand_IsValid);
	}
}
