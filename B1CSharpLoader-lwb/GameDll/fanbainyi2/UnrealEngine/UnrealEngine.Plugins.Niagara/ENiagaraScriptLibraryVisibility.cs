using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraScriptLibraryVisibility", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraScriptLibraryVisibility
{
	Invalid,
	Unexposed,
	Library,
	Hidden
}
