namespace b1;

public class BUS_SpawnCollectionCompImpl : UActorCompBaseCS
{
	private IBIC_CollectionGroupData CollectionGroupData { get; set; }

	public override void OnAttach()
	{
		CollectionGroupData = RequireReadonlyGameInstanceData<IBIC_CollectionGroupData, BIC_CollectionGroupData>();
	}

	public override void OnBeginPlay()
	{
	}
}
