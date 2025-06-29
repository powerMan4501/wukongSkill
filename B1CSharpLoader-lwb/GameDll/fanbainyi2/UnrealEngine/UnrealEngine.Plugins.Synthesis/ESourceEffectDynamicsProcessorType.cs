using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.ESourceEffectDynamicsProcessorType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESourceEffectDynamicsProcessorType : byte
{
	Compressor,
	Limiter,
	Expander,
	Gate,
	UpwardsCompressor,
	Count
}
