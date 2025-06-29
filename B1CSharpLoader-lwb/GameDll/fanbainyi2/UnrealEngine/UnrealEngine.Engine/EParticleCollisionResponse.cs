using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleCollisionResponse", "Engine", UnrealModuleType.Engine)]
public enum EParticleCollisionResponse
{
	Bounce,
	Stop,
	Kill
}
