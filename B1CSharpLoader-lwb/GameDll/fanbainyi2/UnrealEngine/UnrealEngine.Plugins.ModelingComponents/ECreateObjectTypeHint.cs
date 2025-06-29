using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.ECreateObjectTypeHint", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum ECreateObjectTypeHint : byte
{
	Undefined,
	StaticMesh,
	Volume,
	DynamicMeshActor
}
