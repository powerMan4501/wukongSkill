using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810623140uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AnimNotify_PlaySound", "Engine", UnrealModuleType.Engine)]
public class UAnimNotify_PlaySound : UAnimNotify
{
	private static bool Sound_IsValid;

	private static int Sound_Offset;

	private static bool VolumeMultiplier_IsValid;

	private static int VolumeMultiplier_Offset;

	private static bool PitchMultiplier_IsValid;

	private static int PitchMultiplier_Offset;

	private static bool Follow_IsValid;

	private static FFieldAddress Follow_PropertyAddress;

	private static int Follow_Offset;

	private static bool AttachName_IsValid;

	private static int AttachName_Offset;

	[UProperty(Flags = (PropFlags)8162844117828117uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlaySound:Sound")]
	public USoundBase Sound
	{
		get
		{
			CheckDestroyed();
			if (!Sound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:Sound");
				return null;
			}
			return UObjectMarshaler<USoundBase>.FromNative(IntPtr.Add(base.Address, Sound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Sound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:Sound");
			}
			else
			{
				UObjectMarshaler<USoundBase>.ToNative(IntPtr.Add(base.Address, Sound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985493uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlaySound:VolumeMultiplier")]
	public float VolumeMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!VolumeMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:VolumeMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VolumeMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VolumeMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:VolumeMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VolumeMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985493uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlaySound:PitchMultiplier")]
	public float PitchMultiplier
	{
		get
		{
			CheckDestroyed();
			if (!PitchMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:PitchMultiplier");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PitchMultiplier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchMultiplier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:PitchMultiplier");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PitchMultiplier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlaySound:bFollow")]
	public bool Follow
	{
		get
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:bFollow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Follow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:bFollow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Follow_Offset), 0, Follow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985493uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlaySound:AttachName")]
	public FName AttachName
	{
		get
		{
			CheckDestroyed();
			if (!AttachName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:AttachName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AttachName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlaySound:AttachName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AttachName_Offset), value);
			}
		}
	}

	static UAnimNotify_PlaySound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotify_PlaySound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotify_PlaySound));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.AnimNotify_PlaySound");
		Sound_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Sound");
		Sound_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Sound", Classes.FObjectProperty);
		VolumeMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "VolumeMultiplier");
		VolumeMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "VolumeMultiplier", Classes.FFloatProperty);
		PitchMultiplier_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PitchMultiplier");
		PitchMultiplier_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PitchMultiplier", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Follow_PropertyAddress, unrealStruct, "bFollow");
		Follow_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bFollow");
		Follow_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bFollow", Classes.FBoolProperty);
		AttachName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttachName");
		AttachName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttachName", Classes.FNameProperty);
	}
}
