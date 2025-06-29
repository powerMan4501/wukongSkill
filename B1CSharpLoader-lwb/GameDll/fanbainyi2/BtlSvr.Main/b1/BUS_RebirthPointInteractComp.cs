using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_RebirthPointInteractComp : UActorCompBaseCS
{
	private BUC_RebirthPointData RebirthPointData;

	public override void OnAttach()
	{
		RebirthPointData = RequireWritableData<BUC_RebirthPointData>();
		base.BUSEventCollection.Evt_InteractRebirthPoint += new Del_Void_Actor(OnInteractRebirthPoint);
	}

	private void OnInteractRebirthPoint(AActor User)
	{
		if (!RebirthPointData.bActiveState)
		{
			base.BUSEventCollection.Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.RebirthPointTag.Event_Active);
			BGW_LogUtil.LogIfNull(BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID), "Find RebirthPointDesc failed! RebirthPoint ID: {0}", RebirthPointData.RebirthPointConfigID);
		}
	}
}
