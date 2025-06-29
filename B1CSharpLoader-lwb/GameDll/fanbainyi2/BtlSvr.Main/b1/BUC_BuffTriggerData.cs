using System.Collections.Generic;

namespace b1;

internal class BUC_BuffTriggerData : b1.IBUC_BuffTriggerData
{
	public List<BGUCharacterCS> InAreaUnits;

	public bool bTriggerEndOverlapWhenDisable { get; set; }

	public List<FBuffTriggerUnitCondition> BuffTriggerUnitConditions { get; set; }

	public BUC_BuffTriggerData()
	{
		BuffTriggerUnitConditions = new List<FBuffTriggerUnitCondition>();
	}
}
