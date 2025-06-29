using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.Beam2SourceTargetMethod", "Engine", UnrealModuleType.Engine)]
public enum EBeam2SourceTargetMethod
{
	PEB2STM_Default,
	PEB2STM_UserSet,
	PEB2STM_Emitter,
	PEB2STM_Particle,
	PEB2STM_Actor
}
