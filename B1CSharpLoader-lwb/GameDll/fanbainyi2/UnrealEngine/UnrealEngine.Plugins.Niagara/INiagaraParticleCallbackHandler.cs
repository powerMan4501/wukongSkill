using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[Abstract]
[UInterface(Flags = 809517217u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraParticleCallbackHandler", "Niagara", UnrealModuleType.EnginePlugin, InterfaceImpl = typeof(INiagaraParticleCallbackHandlerImpl))]
public interface INiagaraParticleCallbackHandler : IInterface
{
	[UFunction(Flags = 214043648u)]
	[UMetaPath("/Script/Niagara.NiagaraParticleCallbackHandler:ReceiveParticleData")]
	void ReceiveParticleData(List<FBasicParticleData> Data, UNiagaraSystem NiagaraSystem, FVector SimulationPositionOffset);
}
