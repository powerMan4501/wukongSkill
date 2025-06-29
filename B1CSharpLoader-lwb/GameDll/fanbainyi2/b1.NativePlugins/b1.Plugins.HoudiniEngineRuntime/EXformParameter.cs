using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EXformParameter", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EXformParameter
{
	TX,
	TY,
	TZ,
	RX,
	RY,
	RZ,
	SX,
	SY,
	SZ,
	COUNT
}
