using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraModuleDependencyType", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraModuleDependencyType
{
	PreDependency,
	PostDependency
}
