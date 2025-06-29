using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthSlateSizeType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthSlateSizeType : byte
{
	Small,
	Medium,
	Large,
	Count
}
