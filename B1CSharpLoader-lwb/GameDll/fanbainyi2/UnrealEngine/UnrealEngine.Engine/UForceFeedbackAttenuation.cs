using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810029216uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ForceFeedbackAttenuation", "Engine", UnrealModuleType.Engine)]
public class UForceFeedbackAttenuation : UObject
{
	private static bool Attenuation_IsValid;

	private static int Attenuation_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Engine.ForceFeedbackAttenuation:Attenuation")]
	public FForceFeedbackAttenuationSettings Attenuation
	{
		get
		{
			CheckDestroyed();
			if (!Attenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackAttenuation:Attenuation");
				return default(FForceFeedbackAttenuationSettings);
			}
			return FForceFeedbackAttenuationSettings.FromNative(IntPtr.Add(base.Address, Attenuation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Attenuation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ForceFeedbackAttenuation:Attenuation");
			}
			else
			{
				FForceFeedbackAttenuationSettings.ToNative(IntPtr.Add(base.Address, Attenuation_Offset), value);
			}
		}
	}

	static UForceFeedbackAttenuation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UForceFeedbackAttenuation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UForceFeedbackAttenuation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ForceFeedbackAttenuation");
		Attenuation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Attenuation");
		Attenuation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Attenuation", Classes.FStructProperty);
	}
}
