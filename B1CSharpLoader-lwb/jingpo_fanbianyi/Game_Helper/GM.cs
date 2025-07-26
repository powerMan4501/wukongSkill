using System;
using System.Collections.Generic;
using b1;
using B1UI;
using CsB1;

namespace Game_Helper;

public class GM : BuffRunTemplate
{
	protected override void BuffRunTime_Implement(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (buffDescRuntime.GetStringEffectParamCount(EffectIdx) < 3)
		{
			return;
		}
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 2);
		if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) < 2)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (int intEffectParam in buffDescRuntime.GetIntEffectParamList(EffectIdx))
		{
			list.Add(intEffectParam.ToString());
		}
		PlayerGmExecutor.TryInvokeGmCmd(GSG.GamePlayer, BuffRunTemplate.playerDataMgr, stringEffectParam, list);
		Console.WriteLine("GM--" + stringEffectParam);
		UpData();
	}
}
