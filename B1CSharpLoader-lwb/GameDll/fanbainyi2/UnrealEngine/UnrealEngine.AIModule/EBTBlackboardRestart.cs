using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EBTBlackboardRestart", "AIModule", UnrealModuleType.Engine)]
public enum EBTBlackboardRestart
{
	ValueChange,
	ResultChange
}
