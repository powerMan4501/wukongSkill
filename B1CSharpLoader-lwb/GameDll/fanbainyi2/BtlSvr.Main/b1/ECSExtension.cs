using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public static class ECSExtension
{
	public static bool IsECSActor(this AActor Actor)
	{
		return Actor is IECSWorldObj;
	}

	public static Entity ToEntity(this AActor Actor)
	{
		return ECSUtil.ToEntity(Actor);
	}

	public static Entity ToEntity(this UActorComponent ActorComponent)
	{
		return ECSUtil.ToEntity(ActorComponent);
	}

	public static AActor ToActor(this Entity Ent)
	{
		return ECSUtil.ToActor(Ent);
	}
}
