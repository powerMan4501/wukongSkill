using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEQSNormalizationType", "AIModule", UnrealModuleType.Engine)]
public enum EEQSNormalizationType
{
	Absolute,
	RelativeToScores
}
