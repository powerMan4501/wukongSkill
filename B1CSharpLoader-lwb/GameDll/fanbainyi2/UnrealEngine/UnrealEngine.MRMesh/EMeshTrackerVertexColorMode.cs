using UnrealEngine.Runtime;

namespace UnrealEngine.MRMesh;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MRMesh.EMeshTrackerVertexColorMode", "MRMesh", UnrealModuleType.Engine)]
public enum EMeshTrackerVertexColorMode : byte
{
	None,
	Confidence,
	Block
}
