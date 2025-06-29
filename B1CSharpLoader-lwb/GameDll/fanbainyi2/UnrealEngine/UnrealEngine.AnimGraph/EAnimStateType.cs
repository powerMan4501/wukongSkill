using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UEnum]
[UMetaPath("/Script/AnimGraph.EAnimStateType", "AnimGraph", UnrealModuleType.Engine)]
public enum EAnimStateType
{
	AST_SingleAnimation,
	AST_BlendGraph
}
