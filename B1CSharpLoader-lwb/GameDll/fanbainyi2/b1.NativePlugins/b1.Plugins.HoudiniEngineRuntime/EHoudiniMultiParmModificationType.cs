using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniMultiParmModificationType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniMultiParmModificationType
{
	None,
	Inserted,
	Removed,
	Modified
}
