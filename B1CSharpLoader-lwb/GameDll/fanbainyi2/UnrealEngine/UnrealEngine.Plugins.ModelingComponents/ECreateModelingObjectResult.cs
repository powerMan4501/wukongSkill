using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ModelingComponents.ECreateModelingObjectResult", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum ECreateModelingObjectResult : byte
{
	Ok,
	Cancelled,
	Failed_Unknown,
	Failed_NoAPIFound,
	Failed_InvalidWorld,
	Failed_InvalidMesh,
	Failed_InvalidTexture,
	Failed_AssetCreationFailed
}
