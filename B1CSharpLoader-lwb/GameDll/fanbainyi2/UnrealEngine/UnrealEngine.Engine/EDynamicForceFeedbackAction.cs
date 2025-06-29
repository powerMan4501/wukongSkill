using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDynamicForceFeedbackAction", "Engine", UnrealModuleType.Engine)]
public enum EDynamicForceFeedbackAction
{
	Start,
	Update,
	Stop
}
