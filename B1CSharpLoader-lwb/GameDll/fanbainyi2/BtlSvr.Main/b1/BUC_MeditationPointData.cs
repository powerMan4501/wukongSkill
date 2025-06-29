using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MeditationPointData : IBUC_MeditationPointData, IPersistentECSData
{
	public int MeditationPointConfigID { get; set; }

	public FTransform MeditationPointMeditationTrans { get; set; }

	public bool bActiveState { get; set; }
}
