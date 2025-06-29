using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EGeometrySelectionMethod", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EGeometrySelectionMethod
{
	VolumeCubeRoot,
	RelativeVolume
}
