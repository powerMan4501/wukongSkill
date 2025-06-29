using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[UMetaPath("/Script/Synthesis.ESubmixEffectConvolutionReverbBlockSize", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ESubmixEffectConvolutionReverbBlockSize
{
	BlockSize256,
	BlockSize512,
	BlockSize1024
}
