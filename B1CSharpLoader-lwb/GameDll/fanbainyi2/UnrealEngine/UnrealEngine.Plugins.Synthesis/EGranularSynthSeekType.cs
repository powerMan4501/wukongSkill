using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EGranularSynthSeekType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum EGranularSynthSeekType : byte
{
	FromBeginning,
	FromCurrentPosition,
	Count
}
