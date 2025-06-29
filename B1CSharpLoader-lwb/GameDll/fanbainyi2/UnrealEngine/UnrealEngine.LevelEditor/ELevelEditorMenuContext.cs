using UnrealEngine.Runtime;

namespace UnrealEngine.LevelEditor;

[UEnum]
[UMetaPath("/Script/LevelEditor.ELevelEditorMenuContext", "LevelEditor", UnrealModuleType.Engine)]
public enum ELevelEditorMenuContext
{
	Viewport,
	SceneOutliner,
	MainMenu
}
