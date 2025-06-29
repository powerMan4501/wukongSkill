using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CustomLightSystem.CLSDirectionalLight", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class ACLSDirectionalLight : AActor
{
	private static bool DirectionalLightComponent_IsValid;

	private static int DirectionalLightComponent_Offset;

	private static bool TagComponent_IsValid;

	private static int TagComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSDirectionalLight:DirectionalLightComponent")]
	public UDirectionalLightComponent DirectionalLightComponent
	{
		get
		{
			CheckDestroyed();
			if (!DirectionalLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSDirectionalLight:DirectionalLightComponent");
				return null;
			}
			return UObjectMarshaler<UDirectionalLightComponent>.FromNative(IntPtr.Add(base.Address, DirectionalLightComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DirectionalLightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSDirectionalLight:DirectionalLightComponent");
			}
			else
			{
				UObjectMarshaler<UDirectionalLightComponent>.ToNative(IntPtr.Add(base.Address, DirectionalLightComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSDirectionalLight:TagComponent")]
	public UCLSTagComponent TagComponent
	{
		get
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSDirectionalLight:TagComponent");
				return null;
			}
			return UObjectMarshaler<UCLSTagComponent>.FromNative(IntPtr.Add(base.Address, TagComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TagComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSDirectionalLight:TagComponent");
			}
			else
			{
				UObjectMarshaler<UCLSTagComponent>.ToNative(IntPtr.Add(base.Address, TagComponent_Offset), value);
			}
		}
	}

	static ACLSDirectionalLight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACLSDirectionalLight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACLSDirectionalLight));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CustomLightSystem.CLSDirectionalLight");
		DirectionalLightComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DirectionalLightComponent");
		DirectionalLightComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DirectionalLightComponent", Classes.FObjectProperty);
		TagComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TagComponent");
		TagComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TagComponent", Classes.FObjectProperty);
	}
}
