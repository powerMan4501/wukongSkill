using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraAgeUpdateMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraAgeUpdateMode
{
	TickDeltaTime,
	DesiredAge,
	DesiredAgeNoSeek
}
