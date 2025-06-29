using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraStaticSwitchType", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraStaticSwitchType
{
	Bool,
	Integer,
	Enum
}
