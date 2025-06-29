using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EMakeMeshPivotLocation", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EMakeMeshPivotLocation
{
	Base_,
	Centered,
	Top
}
