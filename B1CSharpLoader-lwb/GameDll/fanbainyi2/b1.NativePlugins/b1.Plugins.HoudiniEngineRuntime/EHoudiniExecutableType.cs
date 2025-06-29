using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniExecutableType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniExecutableType
{
	HRSHE_Houdini,
	HRSHE_HoudiniFX,
	HRSHE_HoudiniCore,
	HRSHE_HoudiniIndie
}
