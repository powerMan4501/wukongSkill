using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Qos;

[UEnum]
[UMetaPath("/Script/Qos.EQosResponseType", "Qos", UnrealModuleType.EnginePlugin)]
public enum EQosResponseType
{
	NoResponse,
	Success,
	Failure
}
