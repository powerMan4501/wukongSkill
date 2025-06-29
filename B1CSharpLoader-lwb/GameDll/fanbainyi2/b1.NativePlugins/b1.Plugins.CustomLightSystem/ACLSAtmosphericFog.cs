using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSAtmosphericFog", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSAtmosphericFog : AActor
{
	private static bool AtmosphericFogComponent_IsValid;

	private static int AtmosphericFogComponent_Offset;

	private static bool TagComponent_IsValid;

	private static int TagComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSAtmosphericFog:AtmosphericFogComponent")]
	public USkyAtmosphereComponent AtmosphericFogComponent
	{
		get
		{
			CheckDestroyed();
			if (!AtmosphericFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSAtmosphericFog:AtmosphericFogComponent");
				return null;
			}
			return UObjectMarshaler<USkyAtmosphereComponent>.FromNative(IntPtr.Add(base.Address, AtmosphericFogComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtmosphericFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSAtmosphericFog:AtmosphericFogComponent");
			}
			else
			{
				UObjectMarshaler<USkyAtmosphereComponent>.ToNative(IntPtr.Add(base.Address, AtmosphericFogComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSAtmosphericFog:TagComponent")]
	public UCLSTagComponent TagComponent
	{
		get
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSAtmosphericFog:TagComponent");
				return null;
			}
			return UObjectMarshaler<UCLSTagComponent>.FromNative(IntPtr.Add(base.Address, TagComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSAtmosphericFog:TagComponent");
			}
			else
			{
				UObjectMarshaler<UCLSTagComponent>.ToNative(IntPtr.Add(base.Address, TagComponent_Offset), value);
			}
		}
	}

	static ACLSAtmosphericFog()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSAtmosphericFog)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSAtmosphericFog));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CustomLightSystem.CLSAtmosphericFog");
		AtmosphericFogComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AtmosphericFogComponent");
		AtmosphericFogComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AtmosphericFogComponent", Classes.FObjectProperty);
		TagComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TagComponent");
		TagComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TagComponent", Classes.FObjectProperty);
	}
}
