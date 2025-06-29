using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PartnerComp : UActorCompBaseCS
{
	private BUC_PartnerData PartnerData;

	public override void OnAttach()
	{
		PartnerData = RequireWritableData<BUC_PartnerData>();
		base.BUSEventCollection.Evt_RegisterTeamMngInfo += new Del_Void_ActorInt(RegisterTeamMngInfo);
		base.BUSEventCollection.Evt_OnTriggerWakeBroadCastToTeam += new Del_Void_Actor(OnTriggerWakeBroadCastToTeam);
	}

	private void RegisterTeamMngInfo(AActor TeamMngActor, int TeamID)
	{
		PartnerData.TeamMngEntityRef = new EntitySharedRef(TeamMngActor);
		PartnerData.TeamIDList.Add(TeamID);
	}

	private void OnTriggerWakeBroadCastToTeam(AActor CatchedTarget)
	{
		if (PartnerData.TeamMngEntityRef == null)
		{
			return;
		}
		AActor aActor = EntitySharedRefFuncLib.Actor(PartnerData.TeamMngEntityRef);
		if (!aActor.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_WakeUpPartnersInSameTeam.Invoke(PartnerData.TeamIDList, CatchedTarget);
			}
		}
	}
}
