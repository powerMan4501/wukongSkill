using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithImportActorPolicy", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithImportActorPolicy
{
	Update,
	Full,
	Ignore
}
