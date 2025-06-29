using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EAITaskPriority", "AIModule", UnrealModuleType.Engine)]
public enum EAITaskPriority
{
	Lowest = 0,
	Low = 64,
	AutonomousAI = 127,
	High = 192,
	Ultimate = 254
}
