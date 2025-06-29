using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BUS_BattleFieldPerformanceOptAreaLogicComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
	}

	private void OnActorEnter(AActor OtherActor)
	{
		base.BGSEventCollection.Evt_BGS_BattleFieldPerformanceOptUnit.Invoke(OtherActor);
	}
}
