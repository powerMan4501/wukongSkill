using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.ESampleType", "UnrealExtent", UnrealModuleType.Game)]
public enum ESampleType : byte
{
	Nearest,
	Bilinear
}
