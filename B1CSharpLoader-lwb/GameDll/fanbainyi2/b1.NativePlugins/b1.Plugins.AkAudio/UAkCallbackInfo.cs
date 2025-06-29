using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkCallbackInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkCallbackInfo : UObject
{
	private static bool AkComponent_IsValid;

	private static int AkComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234799133uL)]
	[UMetaPath("/Script/AkAudio.AkCallbackInfo:AkComponent")]
	public UAkComponent AkComponent
	{
		get
		{
			CheckDestroyed();
			if (!AkComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCallbackInfo:AkComponent");
				return null;
			}
			return UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(base.Address, AkComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkCallbackInfo:AkComponent");
			}
			else
			{
				UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(base.Address, AkComponent_Offset), value);
			}
		}
	}

	static UAkCallbackInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkCallbackInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkCallbackInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkCallbackInfo");
		AkComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AkComponent");
		AkComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AkComponent", Classes.FObjectProperty);
	}
}
