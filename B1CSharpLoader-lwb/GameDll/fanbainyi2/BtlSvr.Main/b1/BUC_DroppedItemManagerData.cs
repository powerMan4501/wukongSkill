using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_DroppedItemManagerData : b1.IBUC_DroppedItemManagerData
{
	public FTransform DropTransform { get; set; }

	public int DropItemID { get; set; }

	public float SpawnDelayTime { get; set; }

	public TSoftObject<BGU_EQSPointRecorderActor> PointRecorder { get; set; }

	public string DropUnitGuid { get; set; }

	public AActor SpawnedDroppedItem { get; set; }

	public FName DropSocket { get; set; }

	public bool bUseSocketRotation { get; set; }

	public bool bUseSocketRotationAxisX { get; set; }

	public bool bUseSocketRotationAxisY { get; set; }

	public bool bUseSocketRotationAxisZ { get; set; }

	public FTransform DropOffset { get; set; }

	public bool NeedSpawn { get; set; }

	public float DelayTime { get; set; }
}
