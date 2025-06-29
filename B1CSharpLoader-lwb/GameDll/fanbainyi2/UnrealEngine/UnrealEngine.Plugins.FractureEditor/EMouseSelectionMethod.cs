using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EMouseSelectionMethod", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EMouseSelectionMethod
{
	RectSelect,
	StandardSelect
}
