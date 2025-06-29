using System.Collections.Generic;

namespace b1;

internal class BUPCQueue : BUPropCalcTemplate
{
	public BUPCQueue()
	{
		CalcRule = EPropCalcRule.Queue;
	}

	public override BGU_PropMgrRequestBase Calculate(Dictionary<uint, BGU_PropMgrRequestBase> MapProRequest, List<uint> HandleList)
	{
		uint key = ((HandleList.Count == 1) ? HandleList[0] : HandleList[1]);
		return MapProRequest[key];
	}
}
