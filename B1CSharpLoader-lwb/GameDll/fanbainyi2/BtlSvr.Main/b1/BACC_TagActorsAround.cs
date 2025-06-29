using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_TagActorsAround : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (ConditionInstData.Target != null && BGUFuncLibAiConversation.AnalysisStrParam_To_Int_LessMore_Int_Str(ConditionInstData.ConditionValue, out var Int_, out var LMType, out var Int_2, out var Str_))
		{
			int num = 0;
			UGameplayStatics.GetAllActorsOfClassWithTag(ConditionInstData.Target, UClass.GetClass<AActor>(), new FName(Str_), out var OutActors);
			FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(ConditionInstData.Target);
			for (int i = 0; i < OutActors.Count; i++)
			{
				if (OutActors[i] == ConditionInstData.Target)
				{
					continue;
				}
				BGUCharacterCS bGUCharacterCS = OutActors[i] as BGUCharacterCS;
				if (bGUCharacterCS.IsNullOrDestroyed() || (!BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS, EBGUUnitState.Dead) && !BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.PendingDeathInAnimationSyncing)))
				{
					FVector v2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[i]);
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
