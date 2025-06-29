using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithImportScene", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithImportScene
{
	NewLevel,
	CurrentLevel,
	AssetsOnly
}
