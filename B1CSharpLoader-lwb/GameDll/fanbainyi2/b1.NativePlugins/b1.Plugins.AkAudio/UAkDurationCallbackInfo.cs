using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)817889440uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkDurationCallbackInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkDurationCallbackInfo : UAkEventCallbackInfo
{
	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool EstimatedDuration_IsValid;

	private static int EstimatedDuration_Offset;

	private static bool AudioNodeID_IsValid;

	private static int AudioNodeID_Offset;

	private static bool MediaID_IsValid;

	private static int MediaID_Offset;

	private static bool Streaming_IsValid;

	private static FFieldAddress Streaming_PropertyAddress;

	private static int Streaming_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkDurationCallbackInfo:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkDurationCallbackInfo:EstimatedDuration")]
	public float EstimatedDuration
	{
		get
		{
			CheckDestroyed();
			if (!EstimatedDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:EstimatedDuration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EstimatedDuration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EstimatedDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:EstimatedDuration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EstimatedDuration_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkDurationCallbackInfo:AudioNodeID")]
	public int AudioNodeID
	{
		get
		{
			CheckDestroyed();
			if (!AudioNodeID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:AudioNodeID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AudioNodeID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioNodeID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:AudioNodeID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AudioNodeID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkDurationCallbackInfo:MediaID")]
	public int MediaID
	{
		get
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:MediaID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MediaID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MediaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:MediaID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MediaID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkDurationCallbackInfo:bStreaming")]
	public bool Streaming
	{
		get
		{
			CheckDestroyed();
			if (!Streaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:bStreaming");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Streaming_Offset), 0, Streaming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Streaming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkDurationCallbackInfo:bStreaming");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Streaming_Offset), 0, Streaming_PropertyAddress.Address, value);
			}
		}
	}

	static UAkDurationCallbackInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkDurationCallbackInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkDurationCallbackInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkDurationCallbackInfo");
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Duration", Classes.FFloatProperty);
		EstimatedDuration_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EstimatedDuration");
		EstimatedDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EstimatedDuration", Classes.FFloatProperty);
		AudioNodeID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AudioNodeID");
		AudioNodeID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AudioNodeID", Classes.FIntProperty);
		MediaID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MediaID");
		MediaID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MediaID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Streaming_PropertyAddress, unrealStruct, "bStreaming");
		Streaming_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bStreaming");
		Streaming_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bStreaming", Classes.FBoolProperty);
	}
}
