using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[UEnum]
[UMetaPath("/Script/JavascriptGraphEditor.EPinVisibility", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public enum EPinVisibility
{
	Pin_Show,
	Pin_HideNoConnection,
	Pin_HideNoConnectionNoDefault
}
