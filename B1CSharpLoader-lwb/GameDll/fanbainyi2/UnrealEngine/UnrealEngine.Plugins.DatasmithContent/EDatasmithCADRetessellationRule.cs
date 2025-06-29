using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithCADRetessellationRule", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithCADRetessellationRule
{
	All,
	SkipDeletedSurfaces
}
