using b1.ECS;

namespace b1;

public class MonsterAttrInitAttr : CharacterAttrDataInitTemplate
{
	public MonsterAttrInitAttr(Entity InitEntity, int AActorNetRole)
		: base(InitEntity, AActorNetRole)
	{
	}

	public override void InitDataPreBeginPlay()
	{
		base.InitDataPreBeginPlay();
	}

	public override void InitDataLateBeginPlay()
	{
	}
}
