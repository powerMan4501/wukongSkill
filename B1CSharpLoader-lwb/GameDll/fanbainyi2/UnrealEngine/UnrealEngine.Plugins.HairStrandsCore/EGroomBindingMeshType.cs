using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EGroomBindingMeshType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EGroomBindingMeshType : byte
{
	SkeletalMesh,
	GeometryCache
}
