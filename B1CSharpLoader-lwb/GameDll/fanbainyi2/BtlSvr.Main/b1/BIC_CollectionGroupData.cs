using BtlB1;

namespace b1;

public class BIC_CollectionGroupData : IBIC_CollectionGroupData
{
	public BICCollectionGroupDataOperation CollectionGroupMgr = new BICCollectionGroupDataOperation();

	public BIC_CollectionGroupData()
	{
		CollectionGroupMgr.Init();
	}

	public bool CheckActorIsRandom(string Guid)
	{
		return CollectionGroupMgr.CheckActorIsRandom(Guid);
	}

	public ECollectionInteractType GetCollectiontType(string Guid)
	{
		return CollectionGroupMgr.GetCollectiontType(Guid);
	}

	public ECollectionQualityType CheckCollectionQuality(string Guid)
	{
		return CollectionGroupMgr.CheckCollectionQuality(Guid);
	}

	public bool CheckActorIsBeCollected(string Guid)
	{
		return CollectionGroupMgr.CheckActorIsBeCollected(Guid);
	}

	public bool CheckInBlackList(string Guid)
	{
		return CollectionGroupMgr.CheckInBlackList(Guid);
	}

	public bool ReMoveFormBlackList(string Guid)
	{
		return CollectionGroupMgr.ReMoveFormBlackList(Guid);
	}
}
