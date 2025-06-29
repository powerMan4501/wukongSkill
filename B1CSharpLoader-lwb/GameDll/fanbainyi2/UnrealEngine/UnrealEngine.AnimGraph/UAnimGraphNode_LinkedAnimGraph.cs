using UnrealEngine.BlueprintGraph;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AnimGraph.AnimGraphNode_LinkedAnimGraph", "AnimGraph", UnrealModuleType.Engine)]
public class UAnimGraphNode_LinkedAnimGraph : UAnimGraphNode_LinkedAnimGraphBase, IK2Node_ExternalGraphInterface, IInterface
{
}
