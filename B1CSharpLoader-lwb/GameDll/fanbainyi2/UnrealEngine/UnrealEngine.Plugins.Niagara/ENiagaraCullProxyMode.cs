using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraCullProxyMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraCullProxyMode
{
	None,
	Instanced_Rendered
}
