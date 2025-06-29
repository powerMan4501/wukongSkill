using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPropertyBagContainerType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPropertyBagContainerType : byte
{
	None,
	Array,
	Count
}
