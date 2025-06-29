using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EJavascriptTabRole", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJavascriptTabRole
{
	MajorTab,
	PanelTab,
	NomadTab,
	DocumentTab
}
