using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniFolderParameterType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniFolderParameterType
{
	Invalid,
	Collapsible,
	Simple,
	Tabs,
	Radio,
	Other
}
