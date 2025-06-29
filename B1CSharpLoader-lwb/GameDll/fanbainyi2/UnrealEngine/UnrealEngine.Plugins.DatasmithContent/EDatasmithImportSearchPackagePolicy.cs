using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithImportSearchPackagePolicy", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithImportSearchPackagePolicy
{
	Current,
	All
}
