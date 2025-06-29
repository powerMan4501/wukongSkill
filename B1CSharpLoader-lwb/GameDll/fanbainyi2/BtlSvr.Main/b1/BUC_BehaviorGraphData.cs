using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_BehaviorGraphData
{
	public int BehaviorGraphTemplateID { get; set; }

	public int DialogueGraphTemplateID { get; set; }

	public bool bCanSetCBG { get; set; }

	public bool bHasRunCBG => bCanRunCBG;

	public bool bCanRunCBG { get; set; }

	public Dictionary<int, BUS_BehaviorGraphComp.FBehaviorInstance> IdleBehaviorInstances { get; } = new Dictionary<int, BUS_BehaviorGraphComp.FBehaviorInstance>();

	public Dictionary<int, BUS_BehaviorGraphComp.FBehaviorInstance> BattleBehaviorInstances { get; } = new Dictionary<int, BUS_BehaviorGraphComp.FBehaviorInstance>();

	public Dictionary<Entity, IBUC_CheckData> CheckDataCache { get; } = new Dictionary<Entity, IBUC_CheckData>();

	public Dictionary<EDetectedUnitType, IBUC_CheckData> CheckDataCacheByUnitType { get; } = new Dictionary<EDetectedUnitType, IBUC_CheckData>();
}
