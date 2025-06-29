using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_PartnerAround : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (ConditionInstData.Target != null && BGUFuncLibAiConversation.AnalysisStrParam_To_Int_LessMore_Int(ConditionInstData.ConditionValue, out var Int_, out var LMType, out var Int_2))
		{
			int num = 0;
			List<AActor> allActorsOfClassList = UGameplayStatics.GetAllActorsOfClassList(ConditionInstData.Target, UClass.GetClass<ABGUCharacter>());
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(ConditionInstData.Target);
			for (int i = 0; i < allActorsOfClassList.Count; i++)
			{
				if (!(allActorsOfClassList[i] == ConditionInstData.Target) && !BGUFunctionLibraryCS.BGUIsEnemyTeam(allActorsOfClassList[i], ConditionInstData.Target))
				{
					FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(allActorsOfClassList[i]);
					if (FVector.Dist2D(v, v2) <= (float)Int_)
					{
						num++;
					}
				}
			}
			if (BGUFuncLibAiConversation.bPocess_LessMore(num, LMType, Int_2))
			{
				return true;
			}
		}
		return false;
	}
}
