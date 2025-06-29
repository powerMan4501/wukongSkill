using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818938021uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.Light", "Engine", UnrealModuleType.Engine)]
public class ALight : AActor
{
	private static bool LightComponent_IsValid;

	private static int LightComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023753244uL)]
	[UMetaPath("/Script/Engine.Light:LightComponent")]
	public ULightComponent LightComponent
	{
		get
		{
			CheckDestroyed();
			if (!LightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Light:LightComponent");
				return null;
			}
			return UObjectMarshaler<ULightComponent>.FromNative(IntPtr.Add(base.Address, LightComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Light:LightComponent");
			}
			else
			{
				UObjectMarshaler<ULightComponent>.ToNative(IntPtr.Add(base.Address, LightComponent_Offset), value);
			}
		}
	}

	static ALight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALight));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.Light");
		LightComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightComponent");
		LightComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightComponent", Classes.FObjectProperty);
	}
}
