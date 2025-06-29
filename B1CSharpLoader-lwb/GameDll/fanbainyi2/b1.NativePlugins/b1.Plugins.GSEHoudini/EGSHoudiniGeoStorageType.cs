using UnrealEngine.Runtime;

namespace b1.Plugins.GSEHoudini;

[UEnum]
[UMetaPath("/Script/GSEHoudini.EGSHoudiniGeoStorageType", "GSEHoudini", UnrealModuleType.GamePlugin)]
public enum EGSHoudiniGeoStorageType
{
	EGSH_INT32,
	EGSH_INT64,
	EGSH_FPREAL32,
	EGSH_FPREAL64
}
