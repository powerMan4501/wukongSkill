using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshApproximationType", "Engine", UnrealModuleType.Engine)]
public enum EMeshApproximationType
{
	MeshAndMaterials,
	MeshShapeOnly
}
