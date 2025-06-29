using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AudioSynesthesia.LoudnessResults", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public struct FLoudnessResults
{
	private static bool Loudness_IsValid;

	private static int Loudness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessResults:Loudness")]
	public float Loudness;

	private static bool NormalizedLoudness_IsValid;

	private static int NormalizedLoudness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessResults:NormalizedLoudness")]
	public float NormalizedLoudness;

	private static bool PerceptualEnergy_IsValid;

	private static int PerceptualEnergy_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessResults:PerceptualEnergy")]
	public float PerceptualEnergy;

	private static bool TimeSeconds_IsValid;

	private static int TimeSeconds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AudioSynesthesia.LoudnessResults:TimeSeconds")]
	public float TimeSeconds;

	private static bool FLoudnessResults_IsValid;

	private static int FLoudnessResults_StructSize;

	public FLoudnessResults Copy()
	{
		return this;
	}

	public static FLoudnessResults FromNative(IntPtr nativeBuffer)
	{
		return new FLoudnessResults(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLoudnessResults value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLoudnessResults FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLoudnessResults(nativeBuffer + arrayIndex * FLoudnessResults_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLoudnessResults value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLoudnessResults_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLoudnessResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioSynesthesia.LoudnessResults");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Loudness_Offset), Loudness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalizedLoudness_Offset), NormalizedLoudness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PerceptualEnergy_Offset), PerceptualEnergy);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TimeSeconds_Offset), TimeSeconds);
	}

	public FLoudnessResults(IntPtr nativeStruct)
	{
		if (!FLoudnessResults_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AudioSynesthesia.LoudnessResults");
			Loudness = 0f;
			NormalizedLoudness = 0f;
			PerceptualEnergy = 0f;
			TimeSeconds = 0f;
		}
		else
		{
			Loudness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Loudness_Offset));
			NormalizedLoudness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalizedLoudness_Offset));
			PerceptualEnergy = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PerceptualEnergy_Offset));
			TimeSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TimeSeconds_Offset));
		}
	}

	static FLoudnessResults()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLoudnessResults)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLoudnessResults));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AudioSynesthesia.LoudnessResults");
		FLoudnessResults_StructSize = NativeReflection.GetStructSize(intPtr);
		Loudness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Loudness");
		Loudness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Loudness", Classes.FFloatProperty);
		NormalizedLoudness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalizedLoudness");
		NormalizedLoudness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalizedLoudness", Classes.FFloatProperty);
		PerceptualEnergy_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerceptualEnergy");
		PerceptualEnergy_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerceptualEnergy", Classes.FFloatProperty);
		TimeSeconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TimeSeconds");
		TimeSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TimeSeconds", Classes.FFloatProperty);
		FLoudnessResults_IsValid = intPtr != IntPtr.Zero && Loudness_IsValid && NormalizedLoudness_IsValid && PerceptualEnergy_IsValid && TimeSeconds_IsValid;
		NativeReflection.LogStructIsValid("/Script/AudioSynesthesia.LoudnessResults", FLoudnessResults_IsValid);
	}
}
