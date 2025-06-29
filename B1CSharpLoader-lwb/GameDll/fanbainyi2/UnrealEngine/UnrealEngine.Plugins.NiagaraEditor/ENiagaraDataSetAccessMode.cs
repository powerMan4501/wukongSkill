using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraDataSetAccessMode", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraDataSetAccessMode
{
	AppendConsume,
	Direct,
	Num
}
