using UnrealEngine.Runtime;

namespace UnrealEngine.InterchangeCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InterchangeCore.EInterchangeNodeContainerType", "InterchangeCore", UnrealModuleType.Engine)]
public enum EInterchangeNodeContainerType : byte
{
	NodeContainerType_None,
	NodeContainerType_TranslatedScene,
	NodeContainerType_TranslatedAsset,
	NodeContainerType_FactoryData
}
