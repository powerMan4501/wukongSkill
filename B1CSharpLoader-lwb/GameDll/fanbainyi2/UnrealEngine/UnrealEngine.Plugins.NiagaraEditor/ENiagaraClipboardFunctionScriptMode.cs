using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraClipboardFunctionScriptMode", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraClipboardFunctionScriptMode
{
	ScriptAsset,
	Assignment
}
