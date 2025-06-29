using b1.ECS;

namespace b1;

public class AlwaysCantMoveActorInit : ECSDataInitTemplate
{
	public AlwaysCantMoveActorInit(Entity InitEntity, int AActorNetRole)
		: base(InitEntity, AActorNetRole)
	{
	}

	public override void InitDataLateBeginPlay()
	{
	}

	public override void InitDataPreBeginPlay()
	{
	}

	public override void InitDataOnNew()
	{
		GetUnPersistentData<BUC_ActorTransformInfoData>().InitOwnerActor(Owner);
	}
}
