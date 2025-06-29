using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniHandleType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniHandleType
{
	Xform,
	Bounder,
	Unsupported
}
