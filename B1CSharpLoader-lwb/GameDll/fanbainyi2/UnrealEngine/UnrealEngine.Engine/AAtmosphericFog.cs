using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818414244uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.AtmosphericFog", "Engine", UnrealModuleType.Engine)]
public class AAtmosphericFog : AInfo
{
	private static bool AtmosphericFogComponent_IsValid;

	private static int AtmosphericFogComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.AtmosphericFog:AtmosphericFogComponent")]
	public UAtmosphericFogComponent AtmosphericFogComponent
	{
		get
		{
			CheckDestroyed();
			if (!AtmosphericFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AtmosphericFog:AtmosphericFogComponent");
				return null;
			}
			return UObjectMarshaler<UAtmosphericFogComponent>.FromNative(IntPtr.Add(base.Address, AtmosphericFogComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtmosphericFogComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AtmosphericFog:AtmosphericFogComponent");
			}
			else
			{
				UObjectMarshaler<UAtmosphericFogComponent>.ToNative(IntPtr.Add(base.Address, AtmosphericFogComponent_Offset), value);
			}
		}
	}

	static AAtmosphericFog()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAtmosphericFog)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAtmosphericFog));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.AtmosphericFog");
		AtmosphericFogComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AtmosphericFogComponent");
		AtmosphericFogComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AtmosphericFogComponent", Classes.FObjectProperty);
	}
}
