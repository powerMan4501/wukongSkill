using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkEventCallbackInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkEventCallbackInfo : UAkCallbackInfo
{
	private static bool PlayingID_IsValid;

	private static int PlayingID_Offset;

	private static bool EventID_IsValid;

	private static int EventID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkEventCallbackInfo:PlayingID")]
	public int PlayingID
	{
		get
		{
			CheckDestroyed();
			if (!PlayingID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkEventCallbackInfo:PlayingID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PlayingID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayingID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkEventCallbackInfo:PlayingID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PlayingID_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkEventCallbackInfo:EventID")]
	public int EventID
	{
		get
		{
			CheckDestroyed();
			if (!EventID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkEventCallbackInfo:EventID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EventID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EventID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkEventCallbackInfo:EventID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EventID_Offset), value);
			}
		}
	}

	static UAkEventCallbackInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkEventCallbackInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkEventCallbackInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkEventCallbackInfo");
		PlayingID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PlayingID");
		PlayingID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PlayingID", Classes.FIntProperty);
		EventID_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EventID");
		EventID_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EventID", Classes.FIntProperty);
	}
}
