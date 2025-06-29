using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraCoordinateSpace", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraCoordinateSpace
{
	Simulation,
	World,
	Local
}
