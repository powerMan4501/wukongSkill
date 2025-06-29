using System;
using UnrealEngine.AudioMixer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioCapture;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AudioCapture.AudioCaptureComponent", "AudioCapture", UnrealModuleType.EnginePlugin)]
public class UAudioCaptureComponent : USynthComponent
{
	private static bool JitterLatencyFrames_IsValid;

	private static int JitterLatencyFrames_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AudioCapture.AudioCaptureComponent:JitterLatencyFrames")]
	public int JitterLatencyFrames
	{
		get
		{
			CheckDestroyed();
			if (!JitterLatencyFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioCapture.AudioCaptureComponent:JitterLatencyFrames");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, JitterLatencyFrames_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JitterLatencyFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AudioCapture.AudioCaptureComponent:JitterLatencyFrames");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, JitterLatencyFrames_Offset), value);
			}
		}
	}

	static UAudioCaptureComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioCaptureComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioCaptureComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AudioCapture.AudioCaptureComponent");
		JitterLatencyFrames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "JitterLatencyFrames");
		JitterLatencyFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "JitterLatencyFrames", Classes.FIntProperty);
	}
}
