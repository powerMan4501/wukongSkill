using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkAuxBus", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkAuxBus : UAkAudioType
{
	private static bool MaxAttenuationRadius_IsValid;

	private static int MaxAttenuationRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234414101uL)]
	[UMetaPath("/Script/AkAudio.AkAuxBus:MaxAttenuationRadius")]
	public float MaxAttenuationRadius
	{
		get
		{
			CheckDestroyed();
			if (!MaxAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAuxBus:MaxAttenuationRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAttenuationRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkAuxBus:MaxAttenuationRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAttenuationRadius_Offset), value);
			}
		}
	}

	static UAkAuxBus()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkAuxBus)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkAuxBus));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkAuxBus");
		MaxAttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxAttenuationRadius");
		MaxAttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxAttenuationRadius", Classes.FFloatProperty);
	}
}
