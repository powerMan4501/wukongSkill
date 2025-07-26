using System;
using b1;
using BtlB1;

namespace Game_Helper;

public class Ksxl : BuffRunTemplate
{
	protected override void BuffRunTime_Implement(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		ksxl();
		Console.WriteLine("ksxl");
	}

	public void ksxl()
	{
		FUStPassiveSkillDesc passiveSkillDescByMappingIndex = BGW_GameDB.GetPassiveSkillDescByMappingIndex(10507, 4);
		if (passiveSkillDescByMappingIndex != null)
		{
			passiveSkillDescByMappingIndex.ValOp = (EValOp)2;
			passiveSkillDescByMappingIndex.BaseValue = 100f;
			passiveSkillDescByMappingIndex.MainID = "50016,50091,246,285,286";
			BUS_GSEventCollection bUSEventCollection = BuffRunTemplate.BUSEventCollection;
			bUSEventCollection.Evt_PassiveSkillModifyParam.Invoke(10507, 4, false, 4);
			bUSEventCollection.Evt_PassiveSkillModifyParam.Invoke(20302, 1, false, 1);
		}
	}
}
