using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.Emitter", "Engine", UnrealModuleType.Engine)]
public class AEmitter : AActor
{
	private static bool ParticleSystemComponent_IsValid;

	private static int ParticleSystemComponent_Offset;

	private static bool PostUpdateTickGroup_IsValid;

	private static FFieldAddress PostUpdateTickGroup_PropertyAddress;

	private static int PostUpdateTickGroup_Offset;

	private static bool OnParticleSpawn_IsValid;

	private static int OnParticleSpawn_Offset;

	private FParticleSpawnSignature OnParticleSpawn_DelegateCached;

	private static bool OnParticleBurst_IsValid;

	private static int OnParticleBurst_Offset;

	private FParticleBurstSignature OnParticleBurst_DelegateCached;

	private static bool OnParticleDeath_IsValid;

	private static int OnParticleDeath_Offset;

	private FParticleDeathSignature OnParticleDeath_DelegateCached;

	private static bool OnParticleCollide_IsValid;

	private static int OnParticleCollide_Offset;

	private FParticleCollisionSignature OnParticleCollide_DelegateCached;

	[UProperty(Flags = (PropFlags)21392168023884317uL)]
	[UMetaPath("/Script/Engine.Emitter:ParticleSystemComponent")]
	public UParticleSystemComponent ParticleSystemComponent
	{
		get
		{
			CheckDestroyed();
			if (!ParticleSystemComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:ParticleSystemComponent");
				return null;
			}
			return UObjectMarshaler<UParticleSystemComponent>.FromNative(IntPtr.Add(base.Address, ParticleSystemComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParticleSystemComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:ParticleSystemComponent");
			}
			else
			{
				UObjectMarshaler<UParticleSystemComponent>.ToNative(IntPtr.Add(base.Address, ParticleSystemComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.Emitter:bPostUpdateTickGroup")]
	public bool PostUpdateTickGroup
	{
		get
		{
			CheckDestroyed();
			if (!PostUpdateTickGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:bPostUpdateTickGroup");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PostUpdateTickGroup_Offset), 0, PostUpdateTickGroup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PostUpdateTickGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:bPostUpdateTickGroup");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PostUpdateTickGroup_Offset), 0, PostUpdateTickGroup_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Emitter:OnParticleSpawn")]
	public FParticleSpawnSignature OnParticleSpawn
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:OnParticleSpawn");
				return new FParticleSpawnSignature();
			}
			if (OnParticleSpawn_DelegateCached == null)
			{
				OnParticleSpawn_DelegateCached = new FParticleSpawnSignature();
				OnParticleSpawn_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleSpawn_Offset));
			}
			return OnParticleSpawn_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Emitter:OnParticleBurst")]
	public FParticleBurstSignature OnParticleBurst
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleBurst_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:OnParticleBurst");
				return new FParticleBurstSignature();
			}
			if (OnParticleBurst_DelegateCached == null)
			{
				OnParticleBurst_DelegateCached = new FParticleBurstSignature();
				OnParticleBurst_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleBurst_Offset));
			}
			return OnParticleBurst_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Emitter:OnParticleDeath")]
	public FParticleDeathSignature OnParticleDeath
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleDeath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:OnParticleDeath");
				return new FParticleDeathSignature();
			}
			if (OnParticleDeath_DelegateCached == null)
			{
				OnParticleDeath_DelegateCached = new FParticleDeathSignature();
				OnParticleDeath_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleDeath_Offset));
			}
			return OnParticleDeath_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.Emitter:OnParticleCollide")]
	public FParticleCollisionSignature OnParticleCollide
	{
		get
		{
			CheckDestroyed();
			if (!OnParticleCollide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.Emitter:OnParticleCollide");
				return new FParticleCollisionSignature();
			}
			if (OnParticleCollide_DelegateCached == null)
			{
				OnParticleCollide_DelegateCached = new FParticleCollisionSignature();
				OnParticleCollide_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnParticleCollide_Offset));
			}
			return OnParticleCollide_DelegateCached;
		}
	}

	static AEmitter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AEmitter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AEmitter));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.Emitter");
		ParticleSystemComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ParticleSystemComponent");
		ParticleSystemComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ParticleSystemComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PostUpdateTickGroup_PropertyAddress, unrealStruct, "bPostUpdateTickGroup");
		PostUpdateTickGroup_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bPostUpdateTickGroup");
		PostUpdateTickGroup_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bPostUpdateTickGroup", Classes.FBoolProperty);
		OnParticleSpawn_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnParticleSpawn");
		OnParticleSpawn_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnParticleSpawn", Classes.FMulticastDelegateProperty);
		OnParticleBurst_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnParticleBurst");
		OnParticleBurst_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnParticleBurst", Classes.FMulticastDelegateProperty);
		OnParticleDeath_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnParticleDeath");
		OnParticleDeath_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnParticleDeath", Classes.FMulticastDelegateProperty);
		OnParticleCollide_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnParticleCollide");
		OnParticleCollide_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnParticleCollide", Classes.FMulticastDelegateProperty);
	}
}
