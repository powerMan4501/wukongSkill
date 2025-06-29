using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UEnum]
[UMetaPath("/Script/DatasmithContent.EDatasmithImportMaterialQuality", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public enum EDatasmithImportMaterialQuality
{
	UseNoFresnelCurves,
	UseSimplifierFresnelCurves,
	UseRealFresnelCurves
}
