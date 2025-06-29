using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SpotLight", "Engine", UnrealModuleType.Engine)]
public class ASpotLight : ALight
{
	private static bool SpotLightComponent_IsValid;

	private static int SpotLightComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/Engine.SpotLight:SpotLightComponent")]
	public USpotLightComponent SpotLightComponent
	{
		get
		{
			CheckDestroyed();
			if (!SpotLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpotLight:SpotLightComponent");
				return null;
			}
			return UObjectMarshaler<USpotLightComponent>.FromNative(IntPtr.Add(base.Address, SpotLightComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpotLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SpotLight:SpotLightComponent");
			}
			else
			{
				UObjectMarshaler<USpotLightComponent>.ToNative(IntPtr.Add(base.Address, SpotLightComponent_Offset), value);
			}
		}
	}

	static ASpotLight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASpotLight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASpotLight));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SpotLight");
		SpotLightComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpotLightComponent");
		SpotLightComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpotLightComponent", Classes.FObjectProperty);
	}
}
