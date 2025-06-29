using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleEventType", "Engine", UnrealModuleType.Engine)]
public enum EParticleEventType
{
	EPET_Any,
	EPET_Spawn,
	EPET_Death,
	EPET_Collision,
	EPET_Burst,
	EPET_Blueprint
}
