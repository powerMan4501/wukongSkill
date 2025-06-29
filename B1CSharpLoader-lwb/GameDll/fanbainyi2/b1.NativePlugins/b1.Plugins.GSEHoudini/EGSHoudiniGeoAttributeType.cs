using UnrealEngine.Runtime;

namespace b1.Plugins.GSEHoudini;

[UEnum]
[UMetaPath("/Script/GSEHoudini.EGSHoudiniGeoAttributeType", "GSEHoudini", UnrealModuleType.GamePlugin)]
public enum EGSHoudiniGeoAttributeType
{
	EGSH_ENUMERIC,
	EGSH_STRING,
	EGSH_DICT,
	EGSH_ENUMERIC_ARRAY,
	EGSH_STRING_ARRAY,
	EGSH_DICT_ARRAY
}
