using UnrealEngine.Runtime;

namespace b1;

internal interface IBUC_DroppedItemManagerData
{
	FTransform DropTransform { get; set; }

	int DropItemID { get; set; }

	float SpawnDelayTime { get; set; }
}
