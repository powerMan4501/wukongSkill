using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSExponentialHeightFog", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSExponentialHeightFog : AActor
{
	private static bool ExponentialHeightFogComponent_IsValid;

	private static int ExponentialHeightFogComponent_Offset;

	private static bool TagComponent_IsValid;

	private static int TagComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSExponentialHeightFog:ExponentialHeightFogComponent")]
	public UExponentialHeightFogComponent ExponentialHeightFogComponent
	{
		get
		{
			CheckDestroyed();
			if (!ExponentialHeightFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSExponentialHeightFog:ExponentialHeightFogComponent");
				return null;
			}
			return UObjectMarshaler<UExponentialHeightFogComponent>.FromNative(IntPtr.Add(base.Address, ExponentialHeightFogComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExponentialHeightFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSExponentialHeightFog:ExponentialHeightFogComponent");
			}
			else
			{
				UObjectMarshaler<UExponentialHeightFogComponent>.ToNative(IntPtr.Add(base.Address, ExponentialHeightFogComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSExponentialHeightFog:TagComponent")]
	public UCLSTagComponent TagComponent
	{
		get
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSExponentialHeightFog:TagComponent");
				return null;
			}
			return UObjectMarshaler<UCLSTagComponent>.FromNative(IntPtr.Add(base.Address, TagComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSExponentialHeightFog:TagComponent");
			}
			else
			{
				UObjectMarshaler<UCLSTagComponent>.ToNative(IntPtr.Add(base.Address, TagComponent_Offset), value);
			}
		}
	}

	static ACLSExponentialHeightFog()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSExponentialHeightFog)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSExponentialHeightFog));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CustomLightSystem.CLSExponentialHeightFog");
		ExponentialHeightFogComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExponentialHeightFogComponent");
		ExponentialHeightFogComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExponentialHeightFogComponent", Classes.FObjectProperty);
		TagComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TagComponent");
		TagComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TagComponent", Classes.FObjectProperty);
	}
}
