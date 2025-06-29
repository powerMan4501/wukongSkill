using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsManagedParamType", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsManagedParamType : byte
{
	None = 0,
	Parameter = 1,
	SceneObj = 2,
	DynamicObstacle = 3,
	Overlap = 4,
	Interactor = 5,
	Spawner = 6,
	Unit = 7,
	NPCUnit = 8,
	GroupUnit = 9,
	IntParam = 32,
	SequenceID = 33,
	TaskStageID = 34,
	BuffID = 35,
	GroupID = 36,
	AiConversationID = 37,
	TaskLineID = 38,
	NameParam = 64,
	ArchiveLabel = 65,
	StreamingLevel = 66,
	AssociationUnitConfig = 67,
	AssociationOnFightSkillID = 68,
	FollowPartnerConfig = 69,
	TeamID = 70,
	IdleAMIdx = 71,
	InteractGroupID = 72,
	StreamingLevelStateConfig = 73,
	LeisureAnimIndex = 74
}
