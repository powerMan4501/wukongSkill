using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810029216uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundAttenuation", "Engine", UnrealModuleType.Engine)]
public class USoundAttenuation : UObject
{
	private static bool Attenuation_IsValid;

	private static int Attenuation_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Engine.SoundAttenuation:Attenuation")]
	public FSoundAttenuationSettings Attenuation
	{
		get
		{
			CheckDestroyed();
			if (!Attenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundAttenuation:Attenuation");
				return default(FSoundAttenuationSettings);
			}
			return FSoundAttenuationSettings.FromNative(IntPtr.Add(base.Address, Attenuation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Attenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundAttenuation:Attenuation");
			}
			else
			{
				FSoundAttenuationSettings.ToNative(IntPtr.Add(base.Address, Attenuation_Offset), value);
			}
		}
	}

	static USoundAttenuation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundAttenuation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundAttenuation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundAttenuation");
		Attenuation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Attenuation");
		Attenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Attenuation", Classes.FStructProperty);
	}
}
