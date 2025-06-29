using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.ENeighborSelectionMethod", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum ENeighborSelectionMethod
{
	LargestNeighbor,
	NearestCenter
}
