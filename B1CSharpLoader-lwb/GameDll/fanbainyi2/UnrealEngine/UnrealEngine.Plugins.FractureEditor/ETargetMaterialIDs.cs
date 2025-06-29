using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.ETargetMaterialIDs", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum ETargetMaterialIDs
{
	OddIDs,
	OddAndSelectedIDs,
	SelectedIDs,
	AllIDs
}
