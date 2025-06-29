using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EHLODLayerType", "Engine", UnrealModuleType.Engine)]
public enum EHLODLayerType
{
	Instancing,
	MeshMerge,
	MeshSimplify,
	MeshApproximate,
	Custom
}
