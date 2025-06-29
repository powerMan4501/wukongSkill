using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ENetDormancy", "Engine", UnrealModuleType.Engine)]
public enum ENetDormancy : byte
{
	DORM_Never,
	DORM_Awake,
	DORM_DormantAll,
	DORM_DormantPartial,
	DORM_Initial
}
