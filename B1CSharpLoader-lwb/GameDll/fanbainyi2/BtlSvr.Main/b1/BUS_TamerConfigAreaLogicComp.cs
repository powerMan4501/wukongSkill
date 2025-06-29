using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_TamerConfigAreaLogicComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorExit);
	}

	public override void OnBeginPlay()
	{
	}

	private void OnActorEnter(AActor OtherActor)
	{
		b1.BGUTamerConfigArea bGUTamerConfigArea = Owner as b1.BGUTamerConfigArea;
		if (!(bGUTamerConfigArea == null) && !OtherActor.IsNullOrDestroyed())
		{
			BGUFunctionLibraryCS.SetTamerStrategyArea(Owner, bGUTamerConfigArea.TamerStrategyArea);
		}
	}

	private void OnActorExit(AActor OtherActor)
	{
		if (!OtherActor.IsNullOrDestroyed())
		{
			BGUFunctionLibraryCS.SetTamerStrategyArea(Owner, ETamerStrategyArea.None);
		}
	}
}
