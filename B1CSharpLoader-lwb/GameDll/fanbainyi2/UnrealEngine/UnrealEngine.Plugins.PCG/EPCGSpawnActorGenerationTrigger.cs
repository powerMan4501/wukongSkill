using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGSpawnActorGenerationTrigger", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGSpawnActorGenerationTrigger
{
	Default,
	ForceGenerate,
	DoNotGenerateInEditor,
	DoNotGenerate
}
