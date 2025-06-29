using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDebugPlaybackMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDebugPlaybackMode
{
	Play,
	Loop,
	Paused,
	Step
}
