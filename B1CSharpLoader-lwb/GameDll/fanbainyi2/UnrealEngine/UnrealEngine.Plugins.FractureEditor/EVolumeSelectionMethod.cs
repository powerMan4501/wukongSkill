using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EVolumeSelectionMethod", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EVolumeSelectionMethod
{
	CubeRootOfVolume,
	RelativeToWhole,
	RelativeToLargest
}
