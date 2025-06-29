using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810623136uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.AnimNotify_PlayParticleEffect", "Engine", UnrealModuleType.Engine)]
public class UAnimNotify_PlayParticleEffect : UAnimNotify
{
	private static bool PSTemplate_IsValid;

	private static int PSTemplate_Offset;

	private static bool LocationOffset_IsValid;

	private static int LocationOffset_Offset;

	private static bool RotationOffset_IsValid;

	private static int RotationOffset_Offset;

	private static bool Attached_IsValid;

	private static FFieldAddress Attached_PropertyAddress;

	private static int Attached_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlayParticleEffect:PSTemplate")]
	public UParticleSystem PSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!PSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:PSTemplate");
				return null;
			}
			return UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(base.Address, PSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:PSTemplate");
			}
			else
			{
				UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(base.Address, PSTemplate_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlayParticleEffect:LocationOffset")]
	public FVector LocationOffset
	{
		get
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:LocationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LocationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:LocationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LocationOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589589uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlayParticleEffect:RotationOffset")]
	public FRotator RotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:RotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:RotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationOffset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlayParticleEffect:Attached")]
	public bool Attached
	{
		get
		{
			CheckDestroyed();
			if (!Attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:Attached");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Attached_Offset), 0, Attached_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:Attached");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Attached_Offset), 0, Attached_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.AnimNotify_PlayParticleEffect:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.AnimNotify_PlayParticleEffect:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	static UAnimNotify_PlayParticleEffect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotify_PlayParticleEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotify_PlayParticleEffect));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.AnimNotify_PlayParticleEffect");
		PSTemplate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PSTemplate");
		PSTemplate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PSTemplate", Classes.FObjectProperty);
		LocationOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LocationOffset");
		LocationOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LocationOffset", Classes.FStructProperty);
		RotationOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RotationOffset");
		RotationOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RotationOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Attached_PropertyAddress, unrealStruct, "Attached");
		Attached_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Attached");
		Attached_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Attached", Classes.FBoolProperty);
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SocketName", Classes.FNameProperty);
	}
}
