using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraShader;

[UEnum]
[UMetaPath("/Script/NiagaraShader.ENiagaraMipMapGenerationType", "NiagaraShader", UnrealModuleType.EnginePlugin)]
public enum ENiagaraMipMapGenerationType
{
	Unfiltered,
	Linear,
	Blur1,
	Blur2,
	Blur3,
	Blur4
}
