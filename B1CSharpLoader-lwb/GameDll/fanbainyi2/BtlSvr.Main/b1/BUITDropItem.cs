using ResB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUITDropItem : BUInteractTypeTemplate
{
	public BUITDropItem()
	{
		PreCheckBehaviorArr = new EPreCheckBehavior[1] { EPreCheckBehavior.NotInTransforming };
	}

	public override void FinishInteract(int InteractiveActorID, AActor User, AActor InteractiveActor)
	{
		base.FinishInteract(InteractiveActorID, User, InteractiveActor);
		BUC_DropItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DropItemData>(InteractiveActor);
		if (readOnlyData == null || !readOnlyData.UseSoulBottleCondition || IsHaveSoulBottle(User))
		{
			BUS_EventCollectionCS.Get(InteractiveActor).Evt_OnPickDropItem.Invoke();
		}
	}

	private bool IsHaveSoulBottle(AActor User)
	{
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.SoukBottleItemId);
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(User) as BGP_PlayerControllerCS);
		if (readOnlyData == null)
		{
			BGW_LogUtil.LogError("[BUITDropItem] IsHaveSoukBottle PlayerRoleData == null");
			return false;
		}
		return RoleDataHelper.HasItem(readOnlyData, commLogicCfgValue);
	}
}
