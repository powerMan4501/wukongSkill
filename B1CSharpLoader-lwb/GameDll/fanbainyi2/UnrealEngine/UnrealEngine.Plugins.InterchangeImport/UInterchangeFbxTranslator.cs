using UnrealEngine.InterchangeCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeImport;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/InterchangeImport.InterchangeFbxTranslator", "InterchangeImport", UnrealModuleType.EnginePlugin)]
public class UInterchangeFbxTranslator : UInterchangeTranslatorBase, IInterchangeTexturePayloadInterface, IInterface, IInterchangeStaticMeshPayloadInterface, IInterchangeSkeletalMeshPayloadInterface
{
}
