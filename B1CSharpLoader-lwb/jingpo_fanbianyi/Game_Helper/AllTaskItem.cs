using System;
using System.Collections.Generic;
using b1;
using B1UI;
using CsB1;

namespace Game_Helper;

public class AllTaskItem : BuffRunTemplate
{
	protected override void BuffRunTime_Implement(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 1);
		List<string> list = new List<string>();
		PlayerGmExecutor.TryInvokeGmCmd(GSG.GamePlayer, BuffRunTemplate.playerDataMgr, stringEffectParam, list);
		Console.WriteLine(stringEffectParam ?? "");
		UpData();
	}
}
