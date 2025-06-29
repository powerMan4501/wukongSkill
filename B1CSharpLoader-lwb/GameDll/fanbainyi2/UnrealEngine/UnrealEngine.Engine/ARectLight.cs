using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.RectLight", "Engine", UnrealModuleType.Engine)]
public class ARectLight : ALight
{
	private static bool RectLightComponent_IsValid;

	private static int RectLightComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/Engine.RectLight:RectLightComponent")]
	public URectLightComponent RectLightComponent
	{
		get
		{
			CheckDestroyed();
			if (!RectLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLight:RectLightComponent");
				return null;
			}
			return UObjectMarshaler<URectLightComponent>.FromNative(IntPtr.Add(base.Address, RectLightComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RectLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.RectLight:RectLightComponent");
			}
			else
			{
				UObjectMarshaler<URectLightComponent>.ToNative(IntPtr.Add(base.Address, RectLightComponent_Offset), value);
			}
		}
	}

	static ARectLight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ARectLight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ARectLight));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.RectLight");
		RectLightComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RectLightComponent");
		RectLightComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RectLightComponent", Classes.FObjectProperty);
	}
}
