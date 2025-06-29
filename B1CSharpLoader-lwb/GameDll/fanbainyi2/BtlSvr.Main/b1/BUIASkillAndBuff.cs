using BtlB1;
using BtlShare;
using CsB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIASkillAndBuff : BUInteractActionTemplate
{
	public BUIASkillAndBuff()
	{
		ParamIntNum = 1;
		ParamStringNum = 1;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		AActor aActor = ((Action.ParamsBool == EGSYesNo.Yes) ? User : InteractiveActor);
		if (Action.ParamsInt.Count > 0)
		{
			BUS_EventCollectionCS.Get(aActor).Evt_UnitCastSkillTryCMultiCast.Invoke(new FCastSkillInfo(Action.ParamsInt[0], ECastSkillSourceType.Interact));
		}
		if (Action.ParamsString.Count > 0)
		{
			string[] array = Action.ParamsString[0].Split(';');
			foreach (string text in array)
			{
				if (!text.Equals(""))
				{
					BUS_EventCollectionCS.Get(aActor).Evt_BuffAdd.Invoke(int.Parse(text), aActor, aActor, 0f, EBuffSourceType.PlayerInteract);
				}
			}
		}
		return true;
	}

	public override void OnFinishInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		base.OnFinishInteractAction(InteractiveActorID, User, InteractiveActor, Action);
		if (Action.Condition == EInterActMappingCondition.HasItem && Action.Param1 == 4025 && Action.Param2 == 1)
		{
			CSMsgInteractSoulBottleGainItemReq interactSoulBottleGainItem = new CSMsgInteractSoulBottleGainItemReq();
			BTF_EventCollectionCS.Get((User as BGUPlayerCharacterCS).PlayerState)?.Evt_InteractSoulBottleGainItemReq(interactSoulBottleGainItem, null);
		}
	}
}
