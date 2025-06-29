using UnrealEngine.Runtime;

namespace UnrealEngine.EditorStyle;

[UEnum]
[UMetaPath("/Script/EditorStyle.EAssetEditorOpenLocation", "EditorStyle", UnrealModuleType.Engine)]
public enum EAssetEditorOpenLocation
{
	Default,
	NewWindow,
	MainWindow,
	ContentBrowser,
	LastDockedWindowOrNewWindow,
	LastDockedWindowOrMainWindow,
	LastDockedWindowOrContentBrowser
}
