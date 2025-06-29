using b1.EventDelDefine;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_OwningItem : FGuardConditionBase
{
	private int OwningItemID { get; set; }

	private int OwningNum { get; set; }

	private BPS_GSEventCollection BPSEventCollection { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.OwningItem;

	protected override void Start()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		BPSEventCollection = BPS_EventCollectionCS.Get(firstLocalPlayerController);
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_ChangePlayerItem += new Del_Void_IntInt(OnChangePlayerItem);
		}
		int bagItemNum = RoleDataHelper.GetBagItemNum(BGU_DataUtil.GetReadOnlyData<IBPC_PlayerRoleData, BPC_PlayerRoleData>(firstLocalPlayerController), OwningItemID);
		base.QueryState = ((bagItemNum >= OwningNum) ? EQueryState.QuerySuccess : EQueryState.Querying);
	}

	protected override void OnPlayerControllerAttach()
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(base.Owner);
		BPSEventCollection = BPS_EventCollectionCS.Get(firstLocalPlayerController);
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_ChangePlayerItem += new Del_Void_IntInt(OnChangePlayerItem);
		}
	}

	protected override void Stop()
	{
		if (BPSEventCollection != null)
		{
			BPSEventCollection.Evt_ChangePlayerItem -= new Del_Void_IntInt(OnChangePlayerItem);
		}
	}

	protected override void Clean()
	{
		OwningItemID = 0;
		OwningNum = 0;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Idle IdleCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OwningItemID = IdleCondition.OwningItemId;
		OwningNum = IdleCondition.OwningNum;
		return true;
	}

	public override bool Initial(CalliopeCustom_TransitionCondition_Guide GuideCondition, PsmNodeInstance InPsmNodeInstance)
	{
		OwningItemID = GuideCondition.ItemId;
		OwningNum = GuideCondition.ItemNum;
		return true;
	}

	private void OnChangePlayerItem(int ItemId, int Num)
	{
		if (OwningItemID == ItemId)
		{
			base.QueryState = ((Num >= OwningNum) ? EQueryState.QuerySuccess : EQueryState.Querying);
		}
	}
}
