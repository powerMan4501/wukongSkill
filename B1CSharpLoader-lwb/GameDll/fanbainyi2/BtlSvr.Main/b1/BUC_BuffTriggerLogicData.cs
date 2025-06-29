using System.Collections.Generic;

namespace b1;

internal class BUC_BuffTriggerLogicData : b1.IBUC_BuffTriggerLogicData
{
	public bool bTriggerEndOverlapWhenDisable { get; set; }

	public List<FBuffTriggerUnitCondition> BuffTriggerUnitConditions { get; set; }

	public BUC_BuffTriggerLogicData()
	{
		BuffTriggerUnitConditions = new List<FBuffTriggerUnitCondition>();
	}
}
