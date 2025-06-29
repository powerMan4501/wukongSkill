using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraDataInterfaceEmitterBindingMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDataInterfaceEmitterBindingMode
{
	Self,
	Other
}
