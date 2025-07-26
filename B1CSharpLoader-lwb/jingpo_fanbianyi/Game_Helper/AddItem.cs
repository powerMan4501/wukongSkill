using System;
using System.Collections.Generic;
using b1;
using B1UI;
using CsB1;

namespace Game_Helper;

public class AddItem : BuffRunTemplate
{
	protected override void BuffRunTime_Implement(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 2)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 1);
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
			int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
			List<string> list = new List<string>
			{
				intEffectParam.ToString(),
				intEffectParam2.ToString()
			};
			PlayerGmExecutor.TryInvokeGmCmd(GSG.GamePlayer, BuffRunTemplate.playerDataMgr, stringEffectParam, list);
			Console.WriteLine(stringEffectParam ?? "");
			UpData();
		}
	}
}
