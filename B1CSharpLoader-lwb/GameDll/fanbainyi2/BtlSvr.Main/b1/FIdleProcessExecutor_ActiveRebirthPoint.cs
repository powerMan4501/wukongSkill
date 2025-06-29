using CommB1;
using Google.Protobuf.Collections;
using GurGsPersistent;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_ActiveRebirthPoint : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.ActiveRebirthPoint;

	private int RebirthPointID { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		RebirthPointID = InIdleProcessAction.RebirthPointId;
	}

	public override void Run(UObject InWorldContext)
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(InWorldContext, 0);
		BPS_GSEventCollection local = BPS_EventCollectionCS.GetLocal(playerCharacter);
		if (local == null)
		{
			BIC_PersistentECSData gameInstanceWritableData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(InWorldContext).GetGameInstanceWritableData<BIC_PersistentECSData>();
			if (gameInstanceWritableData != null)
			{
				RepeatedField<ListDeltaMsgInt> activedRebirthPointList = gameInstanceWritableData.GetPersistentBPCData().BPCRebirthPointData.ActivedRebirthPointList;
				ListDeltaMsgInt listDeltaMsgInt = new ListDeltaMsgInt();
				listDeltaMsgInt.Value = RebirthPointID;
				if (!activedRebirthPointList.Contains(listDeltaMsgInt))
				{
					activedRebirthPointList.Add(listDeltaMsgInt);
				}
			}
			return;
		}
		local?.Evt_SetCurrentRebirthPoint.Invoke(RebirthPointID);
		foreach (BGURebirthPointBase allActorsOfClass in UGameplayStatics.GetAllActorsOfClassList<BGURebirthPointBase>(playerCharacter))
		{
			BUS_RebirthPointConfigComp componentByClass = allActorsOfClass.GetComponentByClass<BUS_RebirthPointConfigComp>();
			if (componentByClass != null && componentByClass.RebirthPointConfig.RebirthPointID == RebirthPointID)
			{
				BUS_EventCollectionCS.Get(allActorsOfClass).Evt_SetRebirthPointActiveState.Invoke(P1: true, P2: true);
				return;
			}
		}
		if (BGW_GameDB.GetRebirthPointDesc(RebirthPointID) != null)
		{
			BPS_EventCollectionCS.GetLocal(playerCharacter)?.Evt_ActiveRebirthPoint?.Invoke(RebirthPointID, P2: true);
		}
	}
}
