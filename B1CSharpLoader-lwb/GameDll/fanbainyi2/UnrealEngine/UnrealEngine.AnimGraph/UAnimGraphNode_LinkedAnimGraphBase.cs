using UnrealEngine.BlueprintGraph;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[Abstract]
[UClass(Flags = (ClassFlags)810025121uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AnimGraph.AnimGraphNode_LinkedAnimGraphBase", "AnimGraph", UnrealModuleType.Engine)]
public class UAnimGraphNode_LinkedAnimGraphBase : UAnimGraphNode_CustomProperty, IK2Node_EventNodeInterface, IInterface
{
}
