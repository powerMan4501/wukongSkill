using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleCollisionMode", "Engine", UnrealModuleType.Engine)]
public enum EParticleCollisionMode
{
	SceneDepth,
	DistanceField
}
