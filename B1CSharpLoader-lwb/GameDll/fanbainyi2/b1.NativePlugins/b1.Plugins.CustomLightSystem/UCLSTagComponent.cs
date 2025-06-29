using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSTagComponent", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public class UCLSTagComponent : UActorComponent
{
	private static bool TargetVolume_IsValid;

	private static int TargetVolume_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSTagComponent:TargetVolume")]
	public ACLSBaseVolume TargetVolume
	{
		get
		{
			CheckDestroyed();
			if (!TargetVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSTagComponent:TargetVolume");
				return null;
			}
			return UObjectMarshaler<ACLSBaseVolume>.FromNative(IntPtr.Add(base.Address, TargetVolume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/CustomLightSystem.CLSTagComponent:TargetVolume");
			}
			else
			{
				UObjectMarshaler<ACLSBaseVolume>.ToNative(IntPtr.Add(base.Address, TargetVolume_Offset), value);
			}
		}
	}

	static UCLSTagComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCLSTagComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCLSTagComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/CustomLightSystem.CLSTagComponent");
		TargetVolume_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetVolume");
		TargetVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetVolume", Classes.FObjectProperty);
	}
}
