using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_HeroSwitchData : IBUC_HeroSwitchData, IPersistentECSData
{
	public EPartnerAssistState CurPartnerAssistState { get; set; }

	public EntitySharedRefList PartnerRefList { get; set; } = new EntitySharedRefList();

	public EntitySharedRef LeaderRef { get; set; }

	public List<int> PartnerBuff { get; set; } = new List<int>();

	public int TurningAIActorID { get; set; }

	public float AutoRebirthTimer { get; set; }

	public bool IsAllPartnerDied()
	{
		bool result = true;
		foreach (EntitySharedRef partnerRef in PartnerRefList)
		{
			AActor aActor = EntitySharedRefFuncLib.Actor(partnerRef);
			if (!aActor.IsNullOrDestroyed() && !BGUFunctionLibraryCS.BGUIsUnitDead(aActor))
			{
				result = false;
				break;
			}
		}
		return result;
	}
}
