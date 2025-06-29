using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.HeterogeneousVolume", "Engine", UnrealModuleType.Engine)]
public class AHeterogeneousVolume : AInfo
{
	private static bool HeterogeneousVolumeComponent_IsValid;

	private static int HeterogeneousVolumeComponent_Offset;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.HeterogeneousVolume:HeterogeneousVolumeComponent")]
	public UHeterogeneousVolumeComponent HeterogeneousVolumeComponent
	{
		get
		{
			CheckDestroyed();
			if (!HeterogeneousVolumeComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolume:HeterogeneousVolumeComponent");
				return null;
			}
			return UObjectMarshaler<UHeterogeneousVolumeComponent>.FromNative(IntPtr.Add(base.Address, HeterogeneousVolumeComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeterogeneousVolumeComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.HeterogeneousVolume:HeterogeneousVolumeComponent");
			}
			else
			{
				UObjectMarshaler<UHeterogeneousVolumeComponent>.ToNative(IntPtr.Add(base.Address, HeterogeneousVolumeComponent_Offset), value);
			}
		}
	}

	static AHeterogeneousVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AHeterogeneousVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AHeterogeneousVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.HeterogeneousVolume");
		HeterogeneousVolumeComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HeterogeneousVolumeComponent");
		HeterogeneousVolumeComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HeterogeneousVolumeComponent", Classes.FObjectProperty);
	}
}
