using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAnimGroupRole", "Engine", UnrealModuleType.Engine)]
public enum EAnimGroupRole
{
	CanBeLeader,
	AlwaysFollower,
	AlwaysLeader,
	TransitionLeader,
	TransitionFollower
}
