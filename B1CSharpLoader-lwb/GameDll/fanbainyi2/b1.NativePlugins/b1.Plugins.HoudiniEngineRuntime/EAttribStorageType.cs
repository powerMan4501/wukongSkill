using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EAttribStorageType", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EAttribStorageType
{
	Invalid = -1,
	INT,
	INT64,
	FLOAT,
	FLOAT64,
	STRING
}
