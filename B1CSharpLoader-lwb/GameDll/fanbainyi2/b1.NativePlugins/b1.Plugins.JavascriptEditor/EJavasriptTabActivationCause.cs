using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EJavasriptTabActivationCause", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJavasriptTabActivationCause
{
	UserClickedOnTab,
	SetDirectly
}
