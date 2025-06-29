using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBGUEQCQueryType", "b1", UnrealModuleType.Game)]
public enum EBGUEQCQueryType : byte
{
	None,
	SingleActor,
	SingleLocation,
	ActorSet,
	LocationSet
}
