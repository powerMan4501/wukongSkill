using UnrealEngine.Runtime;

namespace UnrealEngine.MeshDescription;

[UEnum]
[UMetaPath("/Script/MeshDescription.EComputeNTBsOptions", "MeshDescription", UnrealModuleType.Engine)]
public enum EComputeNTBsOptions
{
	None = 0,
	Normals = 1,
	Tangents = 2,
	WeightedNTBs = 4
}
