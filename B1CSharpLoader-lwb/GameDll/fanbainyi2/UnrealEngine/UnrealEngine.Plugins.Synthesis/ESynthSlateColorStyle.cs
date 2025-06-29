using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESynthSlateColorStyle", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESynthSlateColorStyle : byte
{
	Light,
	Dark,
	Count
}
