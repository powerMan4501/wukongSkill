using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniRuntimeSettingsSessionType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniRuntimeSettingsSessionType
{
	HRSST_InProcess,
	HRSST_Socket,
	HRSST_NamedPipe,
	HRSST_None
}
