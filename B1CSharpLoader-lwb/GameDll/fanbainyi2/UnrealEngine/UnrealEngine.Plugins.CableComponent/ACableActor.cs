using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CableComponent;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/CableComponent.CableActor", "CableComponent", UnrealModuleType.EnginePlugin)]
public class ACableActor : AActor
{
	private static bool CableComponent_IsValid;

	private static int CableComponent_Offset;

	[UProperty(Flags = (PropFlags)7881369141772829uL)]
	[UMetaPath("/Script/CableComponent.CableActor:CableComponent")]
	public UCableComponent CableComponent
	{
		get
		{
			CheckDestroyed();
			if (!CableComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableActor:CableComponent");
				return null;
			}
			return UObjectMarshaler<UCableComponent>.FromNative(IntPtr.Add(base.Address, CableComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CableComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CableComponent.CableActor:CableComponent");
			}
			else
			{
				UObjectMarshaler<UCableComponent>.ToNative(IntPtr.Add(base.Address, CableComponent_Offset), value);
			}
		}
	}

	static ACableActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACableActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACableActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CableComponent.CableActor");
		CableComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CableComponent");
		CableComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CableComponent", Classes.FObjectProperty);
	}
}
