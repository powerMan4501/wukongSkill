using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBloomMethod", "Engine", UnrealModuleType.Engine)]
public enum EBloomMethod
{
	BM_SOG,
	BM_FFT
}
