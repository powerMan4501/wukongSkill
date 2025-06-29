using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EJavascriptEditAction", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJavascriptEditAction
{
	Skip,
	Process,
	Halt
}
