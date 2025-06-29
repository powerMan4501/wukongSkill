using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SkyAtmosphere", "Engine", UnrealModuleType.Engine)]
public class ASkyAtmosphere : AInfo
{
	private static bool SkyAtmosphereComponent_IsValid;

	private static int SkyAtmosphereComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.SkyAtmosphere:SkyAtmosphereComponent")]
	public USkyAtmosphereComponent SkyAtmosphereComponent
	{
		get
		{
			CheckDestroyed();
			if (!SkyAtmosphereComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphere:SkyAtmosphereComponent");
				return null;
			}
			return UObjectMarshaler<USkyAtmosphereComponent>.FromNative(IntPtr.Add(base.Address, SkyAtmosphereComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkyAtmosphereComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SkyAtmosphere:SkyAtmosphereComponent");
			}
			else
			{
				UObjectMarshaler<USkyAtmosphereComponent>.ToNative(IntPtr.Add(base.Address, SkyAtmosphereComponent_Offset), value);
			}
		}
	}

	static ASkyAtmosphere()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ASkyAtmosphere)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ASkyAtmosphere));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SkyAtmosphere");
		SkyAtmosphereComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SkyAtmosphereComponent");
		SkyAtmosphereComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SkyAtmosphereComponent", Classes.FObjectProperty);
	}
}
