using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleSignificanceLevel", "Engine", UnrealModuleType.Engine)]
public enum EParticleSignificanceLevel
{
	Low,
	Medium,
	High,
	Critical,
	Num
}
