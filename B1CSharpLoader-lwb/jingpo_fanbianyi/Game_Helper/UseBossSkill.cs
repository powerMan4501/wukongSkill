using b1;

namespace Game_Helper;

public class UseBossSkill : BuffRunTemplate
{
	protected override void BuffRunTime_Implement(BuffDescRuntime buffDescRuntime, int EffectIdx)
	{
		if (buffDescRuntime.GetIntEffectParamCount(EffectIdx) >= 4)
		{
			int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 0);
			bool isInit = buffDescRuntime.GetIntEffectParam(EffectIdx, 1) > 0;
			int intEffectParam2 = buffDescRuntime.GetIntEffectParam(EffectIdx, 2);
			float scale3D = (float)buffDescRuntime.GetIntEffectParam(EffectIdx, 3) / 10f;
			Tools.PlayerTrans(intEffectParam, isInit, intEffectParam2, scale3D);
		}
	}
}
