using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818942112uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.SoundCue", "Engine", UnrealModuleType.Engine)]
public class USoundCue : USoundBase
{
	private static bool VolumeMultiplier_IsValid;

	private static int VolumeMultiplier_Offset;

	private static bool PitchMultiplier_IsValid;

	private static int PitchMultiplier_Offset;

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.SoundCue:VolumeMultiplier")]
	public float VolumeMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!VolumeMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundCue:VolumeMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumeMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundCue:VolumeMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumeMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6756568745902613uL)]
	[UMetaPath("/Script/Engine.SoundCue:PitchMultiplier")]
	public float PitchMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!PitchMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundCue:PitchMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PitchMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.SoundCue:PitchMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PitchMultiplier_Offset), value);
			}
		}
	}

	static USoundCue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USoundCue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USoundCue));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.SoundCue");
		VolumeMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VolumeMultiplier");
		VolumeMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VolumeMultiplier", Classes.FFloatProperty);
		PitchMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PitchMultiplier");
		PitchMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PitchMultiplier", Classes.FFloatProperty);
	}
}
