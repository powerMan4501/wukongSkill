using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_RebirthPointData : IBUC_RebirthPointData, IPersistentECSData
{
	[GSGameDataSnapShot]
	public int RebirthPointConfigID { get; set; }

	[GSGameDataSnapShot]
	public bool ActiveSetCurrentRebirthPoint { get; set; }

	public FTransform RebirthPointRebirthTrans { get; set; }

	[GSGameDataSnapShot]
	public bool bActiveState { get; set; }

	public BGWDataAsset_B1DBC RebirthDBC { get; set; }
}
