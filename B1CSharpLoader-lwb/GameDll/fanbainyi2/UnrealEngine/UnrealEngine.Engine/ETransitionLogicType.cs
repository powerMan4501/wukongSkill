using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETransitionLogicType", "Engine", UnrealModuleType.Engine)]
public enum ETransitionLogicType
{
	TLT_StandardBlend,
	TLT_Inertialization,
	TLT_Custom
}
