using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESamplePlayerSeekType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESamplePlayerSeekType : byte
{
	FromBeginning,
	FromCurrentPosition,
	FromEnd,
	Count
}
