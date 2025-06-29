using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangeIESTranslator", "InterchangeImport", UnrealModuleType.EnginePlugin)]
public class UInterchangeIESTranslator : UInterchangeTranslatorBase, IInterchangeTextureLightProfilePayloadInterface, IInterface
{
}
