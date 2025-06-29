using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraSystemInstanceState", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraSystemInstanceState
{
	None,
	PendingSpawn,
	PendingSpawnPaused,
	Spawning,
	Running,
	Paused,
	Num
}
