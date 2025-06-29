using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.QuestActorType")]
public enum EQuestActorType : byte
{
	None,
	Overlap,
	DynamicObstacle,
	Spawn,
	Checker,
	CovertTimer,
	HLMQuest,
	PlayerChecker,
	SpawnWaves,
	BirthDecideArea
}
