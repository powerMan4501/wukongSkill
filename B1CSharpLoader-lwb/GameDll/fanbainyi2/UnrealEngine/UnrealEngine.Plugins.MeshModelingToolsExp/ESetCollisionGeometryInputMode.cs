using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ESetCollisionGeometryInputMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ESetCollisionGeometryInputMode
{
	CombineAll,
	PerInputObject,
	PerMeshComponent,
	PerMeshGroup
}
