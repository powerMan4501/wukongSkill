using System.Collections.Generic;

namespace b1;

internal class BUPCMul : BUPropCalcTemplate
{
	public BUPCMul()
	{
		CalcRule = EPropCalcRule.Mul;
	}

	public override BGU_PropMgrRequestBase Calculate(Dictionary<uint, BGU_PropMgrRequestBase> MapProRequest, List<uint> HandleList)
	{
		if (HandleList.Count == 1)
		{
			return MapProRequest[HandleList[0]];
		}
		BGU_PropMgrRequestBase bGU_PropMgrRequestBase = MapProRequest[HandleList[0]].Clone();
		for (int i = 1; i < HandleList.Count; i++)
		{
			bGU_PropMgrRequestBase.Mul(MapProRequest[HandleList[i]]);
		}
		return bGU_PropMgrRequestBase;
	}
}
