using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[UMetaPath("/Script/FractureEditor.EFractureAutoClusterMode", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EFractureAutoClusterMode
{
	BoundingBox,
	Proximity,
	Distance,
	Voronoi
}
