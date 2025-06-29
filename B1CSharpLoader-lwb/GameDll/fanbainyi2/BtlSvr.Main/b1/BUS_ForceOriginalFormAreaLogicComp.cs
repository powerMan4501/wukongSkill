using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_ForceOriginalFormAreaLogicComp : UActorCompBaseCS
{
	private BUC_ForceOriginalFormAreaLogicData ForceOriginalFormData;

	public override void OnAttach()
	{
		ForceOriginalFormData = RequireWritableData<BUC_ForceOriginalFormAreaLogicData>();
		base.BUSEventCollection.Evt_OnActorEnterArea += new Del_Void_Actor(OnActorEnter);
		base.BUSEventCollection.Evt_OnActorLeaveArea += new Del_Void_Actor(OnActorLeave);
	}

	private void OnActorEnter(AActor OtherActor)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = OtherActor.GetInstigatorController() as BGP_PlayerControllerCS;
		if (!(bGP_PlayerControllerCS == null))
		{
			GetPlayerEventCollection(bGP_PlayerControllerCS)?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.DisableTransformBegin, -1f);
			int actorResID = BGU_DataUtil.GetActorResID(OtherActor);
			ForceOriginalFormData.OverrideSkillIDs.TryGetValue(actorResID, out var value);
			PlayerTransParam playerTransParam = new PlayerTransParam
			{
				TransSkillId = value
			};
			BPS_EventCollectionCS.Get(bGP_PlayerControllerCS.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.TriggerBoxForceTransBack, playerTransParam);
		}
	}

	private void OnActorLeave(AActor OtherActor)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = OtherActor.GetInstigatorController() as BGP_PlayerControllerCS;
		if (!(bGP_PlayerControllerCS == null))
		{
			GetPlayerEventCollection(bGP_PlayerControllerCS)?.Evt_BPS_PlayerTagTrigger.Invoke(EBGPTagTrigger.DisableTransformEnd, -1f);
		}
	}

	private BPS_GSEventCollection GetPlayerEventCollection(BGP_PlayerControllerCS PC)
	{
		return (PC.PlayerState as BGP_PlayerStateCS).PlayerEventCollection;
	}
}
