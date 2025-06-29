using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERootMotionFinishVelocityMode", "Engine", UnrealModuleType.Engine)]
public enum ERootMotionFinishVelocityMode
{
	MaintainLastRootMotionVelocity,
	SetVelocity,
	ClampVelocity
}
