using BtlB1;

namespace b1;

public interface IBIC_CollectionGroupData
{
	bool CheckActorIsRandom(string Guid);

	bool CheckActorIsBeCollected(string Guid);

	bool CheckInBlackList(string Guid);

	ECollectionQualityType CheckCollectionQuality(string Guid);

	ECollectionInteractType GetCollectiontType(string Guid);

	bool ReMoveFormBlackList(string Guid);
}
