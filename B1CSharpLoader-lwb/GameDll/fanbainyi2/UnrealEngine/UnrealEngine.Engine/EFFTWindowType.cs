using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EFFTWindowType", "Engine", UnrealModuleType.Engine)]
public enum EFFTWindowType
{
	None,
	Hamming,
	Hann,
	Blackman
}
