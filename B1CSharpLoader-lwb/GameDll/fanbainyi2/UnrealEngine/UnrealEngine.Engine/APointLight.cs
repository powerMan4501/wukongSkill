using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.PointLight", "Engine", UnrealModuleType.Engine)]
public class APointLight : ALight
{
	private static bool PointLightComponent_IsValid;

	private static int PointLightComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/Engine.PointLight:PointLightComponent")]
	public UPointLightComponent PointLightComponent
	{
		get
		{
			CheckDestroyed();
			if (!PointLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLight:PointLightComponent");
				return null;
			}
			return UObjectMarshaler<UPointLightComponent>.FromNative(IntPtr.Add(base.Address, PointLightComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.PointLight:PointLightComponent");
			}
			else
			{
				UObjectMarshaler<UPointLightComponent>.ToNative(IntPtr.Add(base.Address, PointLightComponent_Offset), value);
			}
		}
	}

	static APointLight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(APointLight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(APointLight));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.PointLight");
		PointLightComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PointLightComponent");
		PointLightComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PointLightComponent", Classes.FObjectProperty);
	}
}
