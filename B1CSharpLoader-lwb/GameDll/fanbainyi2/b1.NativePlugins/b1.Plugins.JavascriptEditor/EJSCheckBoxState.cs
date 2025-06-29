using UnrealEngine.Runtime;

namespace b1.Plugins.JavascriptEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.EJSCheckBoxState", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public enum EJSCheckBoxState : byte
{
	Unchecked,
	Checked,
	Undetermined
}
