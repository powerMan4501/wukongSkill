using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EJavascriptExtensionHook", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJavascriptExtensionHook
{
	Before,
	After,
	First
}
