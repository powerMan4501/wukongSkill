using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleCollisionComplete", "Engine", UnrealModuleType.Engine)]
public enum EParticleCollisionComplete
{
	EPCC_Kill,
	EPCC_Freeze,
	EPCC_HaltCollisions,
	EPCC_FreezeTranslation,
	EPCC_FreezeRotation,
	EPCC_FreezeMovement
}
