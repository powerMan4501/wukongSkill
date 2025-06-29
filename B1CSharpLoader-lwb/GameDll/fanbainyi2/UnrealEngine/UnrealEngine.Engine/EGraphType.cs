using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EGraphType", "Engine", UnrealModuleType.Engine)]
public enum EGraphType
{
	GT_Function,
	GT_Ubergraph,
	GT_Macro,
	GT_Animation,
	GT_StateMachine
}
