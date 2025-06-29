using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.EAkCollisionChannel", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkCollisionChannel : byte
{
	EAKCC_WorldStatic,
	EAKCC_WorldDynamic,
	EAKCC_Pawn,
	EAKCC_Visibility,
	EAKCC_Camera,
	EAKCC_PhysicsBody,
	EAKCC_Vehicle,
	EAKCC_Destructible,
	EAKCC_UseIntegrationSettingsDefault
}
