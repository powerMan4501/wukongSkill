using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/HairStrandsCore.GroomActor", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class AGroomActor : AActor
{
	private static bool GroomComponent_IsValid;

	private static int GroomComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomActor:GroomComponent")]
	public UGroomComponent GroomComponent
	{
		get
		{
			CheckDestroyed();
			if (!GroomComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomActor:GroomComponent");
				return null;
			}
			return UObjectMarshaler<UGroomComponent>.FromNative(IntPtr.Add(base.Address, GroomComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroomComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomActor:GroomComponent");
			}
			else
			{
				UObjectMarshaler<UGroomComponent>.ToNative(IntPtr.Add(base.Address, GroomComponent_Offset), value);
			}
		}
	}

	static AGroomActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGroomActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGroomActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomActor");
		GroomComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GroomComponent");
		GroomComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GroomComponent", Classes.FObjectProperty);
	}
}
