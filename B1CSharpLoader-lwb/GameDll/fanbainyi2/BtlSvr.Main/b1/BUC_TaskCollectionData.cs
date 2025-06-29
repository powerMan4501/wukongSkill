using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_TaskCollectionData : IBUC_TaskCollectionData, IPersistentECSData
{
	public int CD { get; set; }

	public int FinishCD { get; set; }

	public int TaskStageId { get; set; }

	public int TaskStageStage { get; set; }

	public bool CanDestoryTaskFinish { get; set; }

	public int DropID { get; set; }

	public AActor SpawnerActor { get; set; }

	public UBGWDropItemTemplete CollectionDropTemplete { get; set; }

	public UBGWDropItemTemplete CollectionDropTemplete_TaskFinish { get; set; }

	public BGWDataAsset_B1DBC CacheDBC { get; set; }

	public FName CollectionFXSpawnCompTag { get; set; }

	public int CollectionNumMax { get; set; }

	public float DestoryDelayTime { get; set; }

	public int DestroyFXID { get; set; }
}
