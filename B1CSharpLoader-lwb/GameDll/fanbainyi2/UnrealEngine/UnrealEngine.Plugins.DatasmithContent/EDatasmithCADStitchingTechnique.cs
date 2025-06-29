using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithCADStitchingTechnique", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithCADStitchingTechnique
{
	StitchingNone,
	StitchingHeal,
	StitchingSew
}
