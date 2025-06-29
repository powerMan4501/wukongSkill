using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[UMetaPath("/Script/JavascriptEditor.EPropertyAccessResult", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EPropertyAccessResult
{
	MultipleValues,
	Fail,
	Success
}
