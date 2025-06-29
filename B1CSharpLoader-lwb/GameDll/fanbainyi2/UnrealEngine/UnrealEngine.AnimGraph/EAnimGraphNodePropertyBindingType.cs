using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UEnum]
[UMetaPath("/Script/AnimGraph.EAnimGraphNodePropertyBindingType", "AnimGraph", UnrealModuleType.Engine)]
public enum EAnimGraphNodePropertyBindingType
{
	None,
	Property,
	Function
}
