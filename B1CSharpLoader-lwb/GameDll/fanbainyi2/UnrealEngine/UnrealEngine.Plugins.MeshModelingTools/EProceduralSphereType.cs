using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingTools;

[UEnum]
[UMetaPath("/Script/MeshModelingTools.EProceduralSphereType", "MeshModelingTools", UnrealModuleType.EnginePlugin)]
public enum EProceduralSphereType
{
	LatLong,
	Box
}
