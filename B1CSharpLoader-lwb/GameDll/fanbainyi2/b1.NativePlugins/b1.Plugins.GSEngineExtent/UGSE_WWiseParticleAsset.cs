using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/GSEngineExtent.GSE_WWiseParticleAsset", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public class UGSE_WWiseParticleAsset : UPrimaryDataAsset
{
	private static bool ParticleSystem_IsValid;

	private static int ParticleSystem_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.GSE_WWiseParticleAsset:ParticleSystem")]
	public UParticleSystem ParticleSystem
	{
		get
		{
			CheckDestroyed();
			if (!ParticleSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSE_WWiseParticleAsset:ParticleSystem");
				return null;
			}
			return UObjectMarshaler<UParticleSystem>.FromNative(IntPtr.Add(base.Address, ParticleSystem_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ParticleSystem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSEngineExtent.GSE_WWiseParticleAsset:ParticleSystem");
			}
			else
			{
				UObjectMarshaler<UParticleSystem>.ToNative(IntPtr.Add(base.Address, ParticleSystem_Offset), value);
			}
		}
	}

	static UGSE_WWiseParticleAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_WWiseParticleAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_WWiseParticleAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSEngineExtent.GSE_WWiseParticleAsset");
		ParticleSystem_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ParticleSystem");
		ParticleSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ParticleSystem", Classes.FObjectProperty);
	}
}
