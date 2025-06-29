using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_VigourDropperComp : UActorCompBaseCS
{
	private BUC_VigourDropperData VigourDropperData;

	private IBUC_BattleStateData BattleStateData;

	public override void OnAttach()
	{
		VigourDropperData = RequireWritableData<BUC_VigourDropperData>();
		BattleStateData = RequireReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>();
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_SetEnableVigourDropManually += new Del_Void_Bool(OnSetEnableVigourDropManually);
	}

	public override void PreBeginPlay()
	{
		VigourDropperData.bIsVigourBattleBuffEnabled = false;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc == null || unitBattleInfoExtendDesc.VigourDropId == 0 || unitBattleInfoExtendDesc.VigourDroperBattleBuff == 0)
		{
			SetCanTick(Val: false);
		}
		if (unitBattleInfoExtendDesc != null)
		{
			VigourDropperData.NeedManuallyEnableVigourDrop = unitBattleInfoExtendDesc.ManuallyEnableVigourDrop == EGSYesNo.Yes;
			VigourDropperData.VigourDroperBattleBuff = unitBattleInfoExtendDesc.VigourDroperBattleBuff;
		}
	}

	public override void OnBeginPlay()
	{
		UpdateCanDropVigourItem();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		SetVigourBattleBuffEnabled(bIsEnabled: false);
		VigourDropperData.CanDropVigourItem = false;
		UpdateCanDropVigourItem();
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		bool flag = BattleStateData.IsUnitInBattle() && VigourDropperData.CanDropVigourItem;
		if (VigourDropperData.bIsVigourBattleBuffEnabled != flag)
		{
			SetVigourBattleBuffEnabled(flag);
		}
	}

	private void SetVigourBattleBuffEnabled(bool bIsEnabled)
	{
		if (bIsEnabled)
		{
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
			if (unitBattleInfoExtendDesc != null && unitBattleInfoExtendDesc.VigourDropId != 0)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(VigourDropperData.VigourDroperBattleBuff, Owner, Owner, 0f, EBuffSourceType.VigourDropper);
			}
		}
		else
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(VigourDropperData.VigourDroperBattleBuff, EBuffEffectTriggerType.None, 1);
		}
		VigourDropperData.bIsVigourBattleBuffEnabled = bIsEnabled;
	}

	private void OnSetEnableVigourDropManually(bool bIsEnabled)
	{
		if (bIsEnabled)
		{
			VigourDropperData.ManuallyEnableVigourDrop++;
		}
		else
		{
			VigourDropperData.ManuallyEnableVigourDrop--;
		}
		UpdateCanDropVigourItem();
	}

	private void UpdateCanDropVigourItem()
	{
		bool flag = !VigourDropperData.NeedManuallyEnableVigourDrop || VigourDropperData.ManuallyEnableVigourDrop > 0;
		if (VigourDropperData.CanDropVigourItem != flag)
		{
			VigourDropperData.CanDropVigourItem = flag;
			UpdateVigourBuff();
		}
	}

	private void UpdateVigourBuff()
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc == null || unitBattleInfoExtendDesc.VigourDropId == 0)
		{
			return;
		}
		RefreshVigourBuff(unitBattleInfoExtendDesc.VigourDroperEnhancedBuff);
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner));
		if (readOnlyData != null)
		{
			BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.EnableVigourUnitDispItem, out var ConfigInfo);
			if (ConfigInfo != null && RoleDataHelper.HasItem(readOnlyData, ConfigInfo.IntValue))
			{
				RefreshVigourBuff(unitBattleInfoExtendDesc.VigourDroperDispBuff);
			}
		}
	}

	private void RefreshVigourBuff(int BuffId)
	{
		base.BUSEventCollection.Evt_BuffRemove.Invoke(BuffId, EBuffEffectTriggerType.None, 1);
		if (VigourDropperData.CanDropVigourItem)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(BuffId, Owner, Owner, -1f, EBuffSourceType.VigourDropper);
		}
	}
}
