using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Qos;

[UEnum]
[UMetaPath("/Script/Qos.EQosDatacenterResult", "Qos", UnrealModuleType.EnginePlugin)]
public enum EQosDatacenterResult
{
	Invalid,
	Success,
	Incomplete
}
