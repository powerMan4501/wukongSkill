using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleSystemInsignificanceReaction", "Engine", UnrealModuleType.Engine)]
public enum EParticleSystemInsignificanceReaction
{
	Auto,
	Complete,
	DisableTick,
	DisableTickAndKill,
	Num
}
