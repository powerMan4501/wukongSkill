using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public static class ECSUtil
{
	public static Entity ToEntity(AActor Actor)
	{
		if (!(Actor is IECSWorldObj iECSWorldObj))
		{
			return Entity.Null;
		}
		return iECSWorldObj.ECSEntity;
	}

	public static Entity ToEntity(UActorComponent ActorComp)
	{
		if (ActorComp == null)
		{
			return Entity.Null;
		}
		return ToEntity(ActorComp.GetOwner());
	}

	public static AActor ToActor(Entity Ent)
	{
		return (BGW_ECSWorld.Get(Ent)?.GetObject<BUC_ActorBasicData>(Ent))?.Actor;
	}
}
