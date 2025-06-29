using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_CheckHPPercent : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (ConditionInstData.Target.IsNullOrDestroyed())
		{
			return false;
		}
		if (!BGUFuncLibAiConversation.AnalysisStrParam_To_TwoValueBetween(ConditionInstData.ConditionValue, out var SmallValue, out var LargeValue))
		{
			return false;
		}
		float num = BGUFunctionLibraryCS.BGUGetFloatAttr(ConditionInstData.Target, EBGUAttrFloat.Hp);
		float num2 = BGUFunctionLibraryCS.BGUGetFloatAttr(ConditionInstData.Target, EBGUAttrFloat.HpMax);
		float num3 = num / num2;
		if (num3 >= (float)SmallValue && num3 <= (float)LargeValue)
		{
			return true;
		}
		return false;
	}
}
