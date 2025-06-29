using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.ESelectionOperation", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum ESelectionOperation
{
	Replace,
	Add,
	Remove
}
