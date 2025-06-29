using System.Collections.Generic;

namespace b1;

public abstract class BUPropCalcTemplate
{
	protected EPropCalcRule CalcRule;

	public abstract BGU_PropMgrRequestBase Calculate(Dictionary<uint, BGU_PropMgrRequestBase> MapProRequest, List<uint> HandleList);
}
