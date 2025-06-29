using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraStatDisplayMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraStatDisplayMode
{
	Percent,
	Absolute
}
