using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EPropertyEditorNameAreaSettings", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EPropertyEditorNameAreaSettings
{
	HideNameArea,
	ObjectsUseNameArea,
	ActorsUseNameArea,
	ComponentsAndActorsUseNameArea
}
