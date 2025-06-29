using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ParticleReplayState", "Engine", UnrealModuleType.Engine)]
public enum EParticleReplayState
{
	PRS_Disabled,
	PRS_Capturing,
	PRS_Replaying
}
