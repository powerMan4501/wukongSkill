using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_DistanceToSpeaker2D : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (!BGUFuncLibAiConversation.AnalysisStrParam_To_TwoValueBetween(ConditionInstData.ConditionValue, out var SmallValue, out var LargeValue))
		{
			return false;
		}
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(Speaker);
		FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(ConditionInstData.Target);
		float num = FVector.Dist2D(v, v2);
		if (num >= (float)SmallValue && num <= (float)LargeValue)
		{
			return true;
		}
		return false;
	}
}
