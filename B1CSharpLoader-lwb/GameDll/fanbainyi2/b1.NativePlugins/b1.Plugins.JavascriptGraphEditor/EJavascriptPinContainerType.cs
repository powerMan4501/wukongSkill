using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptGraphEditor;

[UEnum]
[UMetaPath("/Script/JavascriptGraphEditor.EJavascriptPinContainerType", "JavascriptGraphEditor", UnrealModuleType.GamePlugin)]
public enum EJavascriptPinContainerType
{
	None,
	Array,
	Set,
	Map
}
