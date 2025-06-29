using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UEnum]
[UMetaPath("/Script/Paper2D.ESpriteCollisionMode", "Paper2D", UnrealModuleType.EnginePlugin)]
public enum ESpriteCollisionMode
{
	None,
	Use2DPhysics,
	Use3DPhysics
}
