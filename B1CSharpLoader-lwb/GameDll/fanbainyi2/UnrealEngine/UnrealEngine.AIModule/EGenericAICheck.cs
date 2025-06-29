using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EGenericAICheck", "AIModule", UnrealModuleType.Engine)]
public enum EGenericAICheck
{
	Less,
	LessOrEqual,
	Equal,
	NotEqual,
	GreaterOrEqual,
	Greater,
	IsTrue
}
