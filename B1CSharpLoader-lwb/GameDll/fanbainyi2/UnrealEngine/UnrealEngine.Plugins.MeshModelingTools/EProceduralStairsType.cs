using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EProceduralStairsType", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EProceduralStairsType
{
	Linear,
	Floating,
	Curved,
	Spiral
}
