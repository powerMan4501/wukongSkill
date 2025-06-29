using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_GlobalFoliageInteractSoundConfig")]
public class BGWDataAsset_GlobalFoliageInteractSoundConfig : UBGWDataAsset
{
	private static bool SoundMap_IsValid;

	private static int SoundMap_Offset;

	private static FFieldAddress SoundMap_PropertyAddress;

	private TMapReadWriteMarshaler<string, UAkAudioEvent> SoundMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_GlobalFoliageInteractSoundConfig:SoundMap")]
	public TMapReadWrite<string, UAkAudioEvent> SoundMap
	{
		get
		{
			CheckDestroyed();
			if (!SoundMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_GlobalFoliageInteractSoundConfig:SoundMap");
				return null;
			}
			if (SoundMap_Marshaler == null)
			{
				SoundMap_Marshaler = new TMapReadWriteMarshaler<string, UAkAudioEvent>(1, SoundMap_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<UAkAudioEvent, UObjectMarshaler<UAkAudioEvent>>.FromNative, CachedMarshalingDelegates<UAkAudioEvent, UObjectMarshaler<UAkAudioEvent>>.ToNative);
			}
			return SoundMap_Marshaler.FromNative(IntPtr.Add(base.Address, SoundMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_GlobalFoliageInteractSoundConfig");
		NativeReflection.GetPropertyRef(ref SoundMap_PropertyAddress, unrealStruct, "SoundMap");
		SoundMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SoundMap");
		SoundMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SoundMap", Classes.FMapProperty);
	}

	static BGWDataAsset_GlobalFoliageInteractSoundConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_GlobalFoliageInteractSoundConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_GlobalFoliageInteractSoundConfig));
	}
}
