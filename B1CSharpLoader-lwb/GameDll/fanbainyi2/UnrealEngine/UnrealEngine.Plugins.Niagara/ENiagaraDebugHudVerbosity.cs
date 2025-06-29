using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDebugHudVerbosity", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDebugHudVerbosity
{
	None,
	Basic,
	Verbose
}
