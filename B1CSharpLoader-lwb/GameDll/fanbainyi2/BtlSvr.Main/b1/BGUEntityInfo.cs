using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BGUEntityInfo
{
	public Entity Ent;

	public float Radius;

	public AActor Actor;

	public int Mask;

	public IBUC_ActorTransformInfoData ActorTransformInfoData { get; set; }

	public BGUEntityInfo(EntityUpdateInfo EntUpdateInfo)
	{
		Ent = EntUpdateInfo.Ent;
		Radius = EntUpdateInfo.Radius;
		Actor = EntUpdateInfo.Actor;
		Mask = EntUpdateInfo.Mask;
		ActorTransformInfoData = EntUpdateInfo.ActorTransformInfoData;
	}
}
