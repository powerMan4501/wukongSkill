using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UEnum]
[UMetaPath("/Script/TressFX.ETressFXCollisionType", "TressFX", UnrealModuleType.GamePlugin)]
public enum ETressFXCollisionType
{
	TFXCollsion_None,
	TFXCollsion_Capsule,
	TFXCollsion_PhysicsAsset,
	TFXCollsion_SDF
}
