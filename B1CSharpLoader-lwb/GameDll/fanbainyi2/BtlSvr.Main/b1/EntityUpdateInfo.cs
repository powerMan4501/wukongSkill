using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class EntityUpdateInfo
{
	public IBUC_ActorTransformInfoData ActorTransformInfoData { get; set; }

	public float Radius { get; set; }

	public int Mask { get; set; }

	public bool IsPlayer { get; set; }

	public Entity Ent { get; set; }

	public AActor Actor { get; set; }

	public Dictionary<Entity, List<FVector2D>> IndexMappingDic { get; set; } = new Dictionary<Entity, List<FVector2D>>();
}
