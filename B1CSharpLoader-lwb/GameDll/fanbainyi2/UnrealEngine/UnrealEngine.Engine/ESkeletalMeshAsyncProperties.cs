using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESkeletalMeshAsyncProperties", "Engine", UnrealModuleType.Engine)]
public enum ESkeletalMeshAsyncProperties
{
	None = 0,
	Materials = 1,
	Skeleton = 2,
	RefSkeleton = 4,
	RetargetBasePose = 8,
	RefBasesInvMatrix = 16,
	MeshClothingAssets = 32,
	UseLegacyMeshDerivedDataKey = 64,
	HasActiveClothingAssets = 128,
	LODSettings = 256,
	HasVertexColors = 512,
	VertexColorGuid = 1024,
	MorphTargets = 2048,
	SkeletalMeshRenderData = 4096,
	MeshEditorDataObject = 8192,
	NeverStream = 16384,
	OverrideLODStreamingSettings = 32768,
	SupportLODStreaming = 65536,
	MaxNumStreamedLODs = 131072,
	MaxNumOptionalLODs = 262144,
	ImportedModel = 524288,
	LODInfo = 1048576,
	SkinWeightProfiles = 2097152,
	CachedComposedRefPoseMatrices = 4194304,
	SamplingInfo = 8388608,
	NodeMappingData = 16777216,
	ShadowPhysicsAsset = 33554432,
	SkelMirrorTable = 67108864,
	MinLod = 134217728,
	DisableBelowMinLodStripping = 268435456,
	SkelMirrorAxis = 536870912,
	SkelMirrorFlipAxis = 1073741824,
	All = -1
}
