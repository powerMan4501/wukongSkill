using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ERingModulatorTypeSourceEffect", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ERingModulatorTypeSourceEffect : byte
{
	Sine,
	Saw,
	Triangle,
	Square,
	Count
}
