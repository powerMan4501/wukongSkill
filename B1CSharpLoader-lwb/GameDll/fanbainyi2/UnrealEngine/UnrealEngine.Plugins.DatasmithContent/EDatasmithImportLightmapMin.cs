using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithImportLightmapMin", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithImportLightmapMin
{
	LIGHTMAP_16,
	LIGHTMAP_32,
	LIGHTMAP_64,
	LIGHTMAP_128,
	LIGHTMAP_256,
	LIGHTMAP_512
}
