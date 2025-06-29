using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangePCXTranslator", "InterchangeImport", UnrealModuleType.EnginePlugin)]
public class UInterchangePCXTranslator : UInterchangeTranslatorBase, IInterchangeTexturePayloadInterface, IInterface
{
}
