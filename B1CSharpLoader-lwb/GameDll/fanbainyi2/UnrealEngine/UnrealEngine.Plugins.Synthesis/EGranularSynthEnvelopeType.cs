using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EGranularSynthEnvelopeType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum EGranularSynthEnvelopeType : byte
{
	Rectangular,
	Triangle,
	DownwardTriangle,
	UpwardTriangle,
	ExponentialDecay,
	ExponentialIncrease,
	Gaussian,
	Hanning,
	Lanczos,
	Cosine,
	CosineSquared,
	Welch,
	Blackman,
	BlackmanHarris,
	Count
}
