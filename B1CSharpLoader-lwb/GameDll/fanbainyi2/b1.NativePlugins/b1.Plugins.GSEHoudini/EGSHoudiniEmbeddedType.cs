using UnrealEngine.Runtime;

namespace b1.Plugins.GSEHoudini;

[UEnum]
[UMetaPath("/Script/GSEHoudini.EGSHoudiniEmbeddedType", "GSEHoudini", UnrealModuleType.GamePlugin)]
public enum EGSHoudiniEmbeddedType
{
	EGSH_NONE,
	EGSH_EMBED_INT_ARRAY,
	EGSH_EMBED_FLOAT_ARRAY,
	EGSH_EMBED_STRING_ARRAY,
	EGSH_EMBED_VECTOR,
	EGSH_EMBDED_DICT
}
