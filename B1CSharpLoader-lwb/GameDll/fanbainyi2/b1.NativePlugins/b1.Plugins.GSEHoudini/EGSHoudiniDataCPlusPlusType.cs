using UnrealEngine.Runtime;

namespace b1.Plugins.GSEHoudini;

[UEnum]
[UMetaPath("/Script/GSEHoudini.EGSHoudiniDataCPlusPlusType", "GSEHoudini", UnrealModuleType.GamePlugin)]
public enum EGSHoudiniDataCPlusPlusType
{
	EGSH_CPLUSPLUS_NONE,
	EGSH_CPLUSPLUS_INT,
	EGSH_CPLUSPLUS_FLOAT,
	EGSH_CPLUSPLUS_FVECTOR,
	EGSH_CPLUSPLUS_FSTRING
}
