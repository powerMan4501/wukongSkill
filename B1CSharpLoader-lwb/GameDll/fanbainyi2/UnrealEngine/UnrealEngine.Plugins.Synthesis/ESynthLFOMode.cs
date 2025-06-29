using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthLFOMode", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthLFOMode : byte
{
	Sync,
	OneShot,
	Free,
	Count
}
