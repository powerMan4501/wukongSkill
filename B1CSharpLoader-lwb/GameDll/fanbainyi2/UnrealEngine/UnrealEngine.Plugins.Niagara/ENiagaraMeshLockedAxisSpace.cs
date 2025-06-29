using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraMeshLockedAxisSpace", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraMeshLockedAxisSpace
{
	Simulation,
	World,
	Local
}
