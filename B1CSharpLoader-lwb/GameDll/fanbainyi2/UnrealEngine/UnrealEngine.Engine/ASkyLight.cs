using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SkyLight", "Engine", UnrealModuleType.Engine)]
public class ASkyLight : AInfo
{
	private static bool LightComponent_IsValid;

	private static int LightComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.SkyLight:LightComponent")]
	public USkyLightComponent LightComponent
	{
		get
		{
			CheckDestroyed();
			if (!LightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLight:LightComponent");
				return null;
			}
			return UObjectMarshaler<USkyLightComponent>.FromNative(IntPtr.Add(base.Address, LightComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyLight:LightComponent");
			}
			else
			{
				UObjectMarshaler<USkyLightComponent>.ToNative(IntPtr.Add(base.Address, LightComponent_Offset), value);
			}
		}
	}

	static ASkyLight()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASkyLight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASkyLight));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SkyLight");
		LightComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightComponent");
		LightComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightComponent", Classes.FObjectProperty);
	}
}
