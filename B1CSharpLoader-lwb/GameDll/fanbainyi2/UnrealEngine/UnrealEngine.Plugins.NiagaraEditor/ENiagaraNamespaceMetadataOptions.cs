using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.NiagaraEditor;

[UEnum]
[UMetaPath("/Script/NiagaraEditor.ENiagaraNamespaceMetadataOptions", "NiagaraEditor", UnrealModuleType.EnginePlugin)]
public enum ENiagaraNamespaceMetadataOptions
{
	HideInScript,
	HideInSystem,
	AdvancedInScript,
	AdvancedInSystem,
	PreventEditingNamespace,
	PreventEditingNamespaceModifier,
	PreventEditingName,
	PreventCreatingInSystemEditor,
	HideInDefinitions
}
