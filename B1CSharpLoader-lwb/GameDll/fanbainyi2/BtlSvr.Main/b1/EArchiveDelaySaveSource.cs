namespace b1;

public enum EArchiveDelaySaveSource
{
	RpcRequest = 1,
	RoleDataMerge = 2,
	CalliopeGraphTriggerInput = 100,
	CalliopeNodeDataChanged = 101,
	FarmedUnitDead = 102,
	LevelIDChanged = 103,
	NeverPlaySequenceListAdd = 104,
	SafePointChanged = 105,
	InteractStateChanged = 106,
	TaskInteractRecordChanged = 107,
	CollectionStateChanged = 108,
	SequencePlaying = 109,
	Teleporting = 110,
	TravelLevel = 111,
	FinishPlayerGuide = 112
}
