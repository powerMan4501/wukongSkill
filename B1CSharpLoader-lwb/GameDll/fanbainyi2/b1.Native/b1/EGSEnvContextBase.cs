using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSEnvContextBase", "b1", UnrealModuleType.Game)]
public enum EGSEnvContextBase : byte
{
	Querier,
	Player,
	PlayerCamera,
	SceneItemByTag,
	Target,
	CustomActor
}
