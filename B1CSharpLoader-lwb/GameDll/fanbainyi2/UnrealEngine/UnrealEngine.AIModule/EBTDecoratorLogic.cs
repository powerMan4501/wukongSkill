using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EBTDecoratorLogic", "AIModule", UnrealModuleType.Engine)]
public enum EBTDecoratorLogic
{
	Invalid,
	Test,
	And,
	Or,
	Not
}
