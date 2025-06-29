using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/b1.ETamerType", "b1", UnrealModuleType.Game)]
public enum ETamerType
{
	None,
	LevelLoaded,
	Spawned,
	Summoned
}
