using System.Collections.Generic;

namespace b1;

internal class BUPCStack : BUPropCalcTemplate
{
	public BUPCStack()
	{
		CalcRule = EPropCalcRule.Stack;
	}

	public override BGU_PropMgrRequestBase Calculate(Dictionary<uint, BGU_PropMgrRequestBase> MapProRequest, List<uint> HandleList)
	{
		uint key = HandleList[HandleList.Count - 1];
		return MapProRequest[key];
	}
}
