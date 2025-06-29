using CommB1;
using Google.Protobuf.Collections;
using GurGsPersistent;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_BlockRebirthPoint : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.BlockRebirthPoint;

	private int RebirthPointID { get; set; }

	private bool IsBlockRebirthpoint { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		RebirthPointID = InIdleProcessAction.RebirthPointId;
		IsBlockRebirthpoint = InIdleProcessAction.IsBlockRebirthpoint;
	}

	public override void Run(UObject InWorldContext)
	{
		BPS_GSEventCollection local = BPS_EventCollectionCS.GetLocal(UGameplayStatics.GetPlayerCharacter(InWorldContext, 0));
		if (local == null)
		{
			BIC_PersistentECSData gameInstanceWritableData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(InWorldContext).GetGameInstanceWritableData<BIC_PersistentECSData>();
			if (gameInstanceWritableData != null)
			{
				RepeatedField<ListDeltaMsgInt> blockedRebirthPointList = gameInstanceWritableData.GetPersistentBPCData().BPCRebirthPointData.BlockedRebirthPointList;
				ListDeltaMsgInt listDeltaMsgInt = new ListDeltaMsgInt();
				listDeltaMsgInt.Value = RebirthPointID;
				if (IsBlockRebirthpoint && !blockedRebirthPointList.Contains(listDeltaMsgInt))
				{
					blockedRebirthPointList.Add(listDeltaMsgInt);
				}
				else if (!IsBlockRebirthpoint && blockedRebirthPointList.Contains(listDeltaMsgInt))
				{
					blockedRebirthPointList.Remove(listDeltaMsgInt);
				}
			}
		}
		else
		{
			local.Evt_BlockRebirthPoint.Invoke(RebirthPointID, IsBlockRebirthpoint);
		}
	}
}
