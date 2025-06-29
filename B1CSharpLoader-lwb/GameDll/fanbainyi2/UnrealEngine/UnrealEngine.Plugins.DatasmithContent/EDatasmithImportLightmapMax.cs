using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithImportLightmapMax", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithImportLightmapMax
{
	LIGHTMAP_64,
	LIGHTMAP_128,
	LIGHTMAP_256,
	LIGHTMAP_512,
	LIGHTMAP_1024,
	LIGHTMAP_2048,
	LIGHTMAP_4096
}
