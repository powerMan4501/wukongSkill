using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SplineFlyMoveTriggerData : IBUC_SplineFlyMoveTriggerData, IPersistentECSData
{
	public Dictionary<string, SplineMoveConfig> CachedUnSpawnedConfig = new Dictionary<string, SplineMoveConfig>();

	public int ControlledCount { get; set; }

	public GSBindProp<bool> bOverlapEnable { get; set; } = new GSBindProp<bool>();

	public bool bAutoEnable { get; set; }

	public List<SplineMoveConfig> Configs { get; set; } = new List<SplineMoveConfig>();

	public float TraceVelocityCameraSpeedRate { get; set; }

	public bool bDestoryControlledUnitInActived { get; set; }

	public FTransform PlayerEndTransform { get; set; }

	public bool IsPlayerObserveMode { get; set; }

	public bool bUseTransform { get; set; }

	public bool OnlyTransitionPlayerCanTrigger { get; set; }
}
