using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraVariantMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraVariantMode
{
	None,
	Object,
	DataInterface,
	Bytes
}
