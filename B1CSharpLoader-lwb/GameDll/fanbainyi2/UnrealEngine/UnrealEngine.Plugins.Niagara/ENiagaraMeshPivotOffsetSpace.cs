using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraMeshPivotOffsetSpace", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraMeshPivotOffsetSpace
{
	Mesh,
	Simulation,
	World,
	Local
}
