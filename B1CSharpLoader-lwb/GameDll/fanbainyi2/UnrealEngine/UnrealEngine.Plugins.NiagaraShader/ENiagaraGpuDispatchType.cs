using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraShader;

[UEnum]
[UMetaPath("/Script/NiagaraShader.ENiagaraGpuDispatchType", "NiagaraShader", UnrealModuleType.EnginePlugin)]
public enum ENiagaraGpuDispatchType
{
	OneD,
	TwoD,
	ThreeD,
	Custom
}
