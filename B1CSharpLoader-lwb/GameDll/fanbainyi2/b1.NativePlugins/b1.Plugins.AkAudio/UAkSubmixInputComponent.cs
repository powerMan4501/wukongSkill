using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkSubmixInputComponent", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkSubmixInputComponent : UAkAudioInputComponent
{
	private static bool SubmixToRecord_IsValid;

	private static int SubmixToRecord_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSubmixInputComponent:SubmixToRecord")]
	public USoundSubmix SubmixToRecord
	{
		get
		{
			CheckDestroyed();
			if (!SubmixToRecord_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSubmixInputComponent:SubmixToRecord");
				return null;
			}
			return UObjectMarshaler<USoundSubmix>.FromNative(IntPtr.Add(base.Address, SubmixToRecord_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubmixToRecord_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSubmixInputComponent:SubmixToRecord");
			}
			else
			{
				UObjectMarshaler<USoundSubmix>.ToNative(IntPtr.Add(base.Address, SubmixToRecord_Offset), value);
			}
		}
	}

	static UAkSubmixInputComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkSubmixInputComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkSubmixInputComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkSubmixInputComponent");
		SubmixToRecord_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SubmixToRecord");
		SubmixToRecord_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SubmixToRecord", Classes.FObjectProperty);
	}
}
