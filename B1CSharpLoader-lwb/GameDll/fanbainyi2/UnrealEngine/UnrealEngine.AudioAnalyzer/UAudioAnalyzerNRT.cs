using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioAnalyzer;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AudioAnalyzer.AudioAnalyzerNRT", "AudioAnalyzer", UnrealModuleType.Engine)]
public class UAudioAnalyzerNRT : UAudioAnalyzerAssetBase
{
	private static bool Sound_IsValid;

	private static int Sound_Offset;

	private static bool DurationInSeconds_IsValid;

	private static int DurationInSeconds_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/AudioAnalyzer.AudioAnalyzerNRT:Sound")]
	public USoundWave Sound
	{
		get
		{
			CheckDestroyed();
			if (!Sound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioAnalyzer.AudioAnalyzerNRT:Sound");
				return null;
			}
			return UObjectMarshaler<USoundWave>.FromNative(IntPtr.Add(base.Address, Sound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioAnalyzer.AudioAnalyzerNRT:Sound");
			}
			else
			{
				UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(base.Address, Sound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/AudioAnalyzer.AudioAnalyzerNRT:DurationInSeconds")]
	public float DurationInSeconds
	{
		get
		{
			CheckDestroyed();
			if (!DurationInSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioAnalyzer.AudioAnalyzerNRT:DurationInSeconds");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DurationInSeconds_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DurationInSeconds_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioAnalyzer.AudioAnalyzerNRT:DurationInSeconds");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DurationInSeconds_Offset), value);
			}
		}
	}

	static UAudioAnalyzerNRT()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioAnalyzerNRT)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioAnalyzerNRT));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioAnalyzer.AudioAnalyzerNRT");
		Sound_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Sound");
		Sound_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Sound", Classes.FObjectProperty);
		DurationInSeconds_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DurationInSeconds");
		DurationInSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DurationInSeconds", Classes.FFloatProperty);
	}
}
