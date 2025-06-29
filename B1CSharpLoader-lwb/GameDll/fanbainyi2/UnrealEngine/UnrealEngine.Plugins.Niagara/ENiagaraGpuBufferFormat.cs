using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraGpuBufferFormat", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraGpuBufferFormat
{
	Float,
	HalfFloat,
	UnsignedNormalizedByte,
	Max
}
