using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UEnum]
[UMetaPath("/Script/Paper2D.EFlipbookCollisionMode", "Paper2D", UnrealModuleType.EnginePlugin)]
public enum EFlipbookCollisionMode
{
	NoCollision,
	FirstFrameCollision,
	EachFrameCollision
}
