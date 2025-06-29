using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraShader;

[UEnum]
[UMetaPath("/Script/NiagaraShader.ENiagaraSimStageExecuteBehavior", "NiagaraShader", UnrealModuleType.EnginePlugin)]
public enum ENiagaraSimStageExecuteBehavior
{
	Always,
	OnSimulationReset,
	NotOnSimulationReset
}
