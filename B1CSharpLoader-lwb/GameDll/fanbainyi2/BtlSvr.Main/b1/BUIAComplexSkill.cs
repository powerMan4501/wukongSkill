using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIAComplexSkill : BUInteractActionTemplate
{
	public BUIAComplexSkill()
	{
		ParamIntNum = 2;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (Action.ParamsInt.Count > 1)
		{
			BUS_EventCollectionCS.Get(User).Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(Action.ParamsInt[0], ECastSkillSourceType.Interact));
			BUS_EventCollectionCS.Get(InteractiveActor).Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(Action.ParamsInt[1], ECastSkillSourceType.Interact));
		}
		return true;
	}
}
