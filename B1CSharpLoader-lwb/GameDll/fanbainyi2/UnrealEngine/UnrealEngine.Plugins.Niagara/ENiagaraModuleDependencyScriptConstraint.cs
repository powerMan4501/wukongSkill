using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraModuleDependencyScriptConstraint", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraModuleDependencyScriptConstraint
{
	SameScript,
	AllScripts
}
