using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EPawnActionMoveMode", "AIModule", UnrealModuleType.Engine)]
public enum EPawnActionMoveMode
{
	UsePathfinding,
	StraightLine
}
