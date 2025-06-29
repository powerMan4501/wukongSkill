using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniXformType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniXformType
{
	None,
	IntoThisObject,
	Auto
}
