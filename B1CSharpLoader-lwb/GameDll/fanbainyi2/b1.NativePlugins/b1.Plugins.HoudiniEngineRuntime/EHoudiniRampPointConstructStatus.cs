using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniRampPointConstructStatus", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniRampPointConstructStatus
{
	None,
	INITIALIZED,
	POSITION_INSERTED,
	VALUE_INSERTED,
	INTERPTYPE_INSERTED
}
