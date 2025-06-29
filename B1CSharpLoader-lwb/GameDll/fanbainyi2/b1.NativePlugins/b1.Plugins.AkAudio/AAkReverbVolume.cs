using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkReverbVolume", "AkAudio", UnrealModuleType.GamePlugin)]
public class AAkReverbVolume : AVolume
{
	private static bool LateReverbComponent_IsValid;

	private static int LateReverbComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234930189uL)]
	[UMetaPath("/Script/AkAudio.AkReverbVolume:LateReverbComponent")]
	public UAkLateReverbComponent LateReverbComponent
	{
		get
		{
			CheckDestroyed();
			if (!LateReverbComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkReverbVolume:LateReverbComponent");
				return null;
			}
			return UObjectMarshaler<UAkLateReverbComponent>.FromNative(IntPtr.Add(base.Address, LateReverbComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LateReverbComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkReverbVolume:LateReverbComponent");
			}
			else
			{
				UObjectMarshaler<UAkLateReverbComponent>.ToNative(IntPtr.Add(base.Address, LateReverbComponent_Offset), value);
			}
		}
	}

	static AAkReverbVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAkReverbVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAkReverbVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkReverbVolume");
		LateReverbComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LateReverbComponent");
		LateReverbComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LateReverbComponent", Classes.FObjectProperty);
	}
}
