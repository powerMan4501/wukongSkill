using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EMaterialUsage", "Engine", UnrealModuleType.Engine)]
public enum EMaterialUsage : byte
{
	MATUSAGE_SkeletalMesh,
	MATUSAGE_ParticleSprites,
	MATUSAGE_BeamTrails,
	MATUSAGE_MeshParticles,
	MATUSAGE_StaticLighting,
	MATUSAGE_MorphTargets,
	MATUSAGE_SplineMesh,
	MATUSAGE_InstancedStaticMeshes,
	MATUSAGE_GeometryCollections,
	MATUSAGE_Clothing,
	MATUSAGE_NiagaraSprites,
	MATUSAGE_NiagaraRibbons,
	MATUSAGE_NiagaraMeshParticles,
	MATUSAGE_GeometryCache,
	MATUSAGE_Water,
	MATUSAGE_WaterCaustics,
	MATUSAGE_HairStrands,
	MATUSAGE_LidarPointCloud,
	MATUSAGE_ReorientedNiagara,
	MATUSAGE_VirtualHeightfieldMesh,
	MATUSAGE_Nanite,
	MATUSAGE_VolumetricCloud,
	MATUSAGE_HeterogeneousVolumes
}
