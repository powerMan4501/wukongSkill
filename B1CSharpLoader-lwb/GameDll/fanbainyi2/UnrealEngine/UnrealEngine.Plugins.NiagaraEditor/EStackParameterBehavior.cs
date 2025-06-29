using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.EStackParameterBehavior", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum EStackParameterBehavior
{
	Dynamic,
	Static
}
