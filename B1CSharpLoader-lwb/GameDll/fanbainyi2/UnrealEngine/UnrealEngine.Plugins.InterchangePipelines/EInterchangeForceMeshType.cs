using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangePipelines;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InterchangePipelines.EInterchangeForceMeshType", "InterchangePipelines", UnrealModuleType.EnginePlugin)]
public enum EInterchangeForceMeshType : byte
{
	IFMT_None,
	IFMT_StaticMesh,
	IFMT_SkeletalMesh
}
