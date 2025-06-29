using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EEvaluatorMode", "Engine", UnrealModuleType.Engine)]
public enum EEvaluatorMode
{
	EM_Standard,
	EM_Freeze,
	EM_DelayedFreeze
}
