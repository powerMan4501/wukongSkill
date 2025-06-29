using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

public class BUS_ForceOriginalFormOuterAreaLogicComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	private void OnActorEnter(AActor OtherActor)
	{
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(OtherActor, EBGUSimpleState.IgnoreUnitTransSkill, IsRemove: false);
	}

	private void OnActorLeave(AActor OtherActor)
	{
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(OtherActor, EBGUSimpleState.IgnoreUnitTransSkill, IsRemove: true);
	}
}
