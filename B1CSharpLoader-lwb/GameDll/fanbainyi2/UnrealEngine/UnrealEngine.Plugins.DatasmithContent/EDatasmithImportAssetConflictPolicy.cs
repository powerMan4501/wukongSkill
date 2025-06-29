using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithImportAssetConflictPolicy", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithImportAssetConflictPolicy
{
	Replace,
	Update,
	Use,
	Ignore
}
