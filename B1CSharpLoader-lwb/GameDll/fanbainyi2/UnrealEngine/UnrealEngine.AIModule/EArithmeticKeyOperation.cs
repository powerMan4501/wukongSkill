using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EArithmeticKeyOperation", "AIModule", UnrealModuleType.Engine)]
public enum EArithmeticKeyOperation
{
	Equal,
	NotEqual,
	Less,
	LessOrEqual,
	Greater,
	GreaterOrEqual
}
