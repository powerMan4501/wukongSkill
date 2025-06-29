using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.ECreateMeshObjectSourceMeshType", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum ECreateMeshObjectSourceMeshType : byte
{
	MeshDescription,
	DynamicMesh
}
