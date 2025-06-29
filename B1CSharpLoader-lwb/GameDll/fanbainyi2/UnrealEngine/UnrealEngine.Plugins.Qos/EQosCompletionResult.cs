using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Qos;

[UEnum]
[UMetaPath("/Script/Qos.EQosCompletionResult", "Qos", UnrealModuleType.EnginePlugin)]
public enum EQosCompletionResult
{
	Invalid,
	Success,
	Failure,
	Canceled
}
