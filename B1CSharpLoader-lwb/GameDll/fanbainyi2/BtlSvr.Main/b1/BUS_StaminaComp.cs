using System.Linq;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_StaminaComp : UActorCompBaseCS
{
	private BUC_StaminaData StaminaData;

	private BUC_AttrContainer AttrContainer;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_BuffData BuffData;

	private IBUC_PlayerInputActionData PlayerInputActionData;

	private IBUC_HardMoveData HardmMoveData;

	public override void OnAttach()
	{
		StaminaData = RequireWritableData<BUC_StaminaData>();
		AttrContainer = RequireWritableData<BUC_AttrContainer>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		PlayerInputActionData = RequireReadOnlyData<IBUC_PlayerInputActionData, BUC_PlayerInputActionData>();
		HardmMoveData = RequireReadOnlyData<IBUC_HardMoveData, b1.BUC_HardMoveData>();
		AttrContainer.FloatAttrs.BindOnSetIdxValue(OnBindOnSetIdxValueChange);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnCastSkillSuccess);
		base.BUSEventCollection.Evt_FreezeCostAttr += new Del_FreezeCostAttr(OnFreezeCostAttr);
		base.BUSEventCollection.Evt_OnSetStaminaRecoverMul += new Del_Void_Float(OnSetStaminaRecoverMul);
		base.BUSEventCollection.Evt_OnResetStaminaRecoverMul += new Del_Void(OnResetStaminaRecoverMul);
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!UnitStateData.HasState(EBGUUnitState.Dead))
		{
			UpdateStaminaRecover(DeltaTime);
			UpdateSprintStaminaCost(DeltaTime);
			UpdateStaminaDepleted();
		}
	}

	private void OnCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.StaminaDepleted))
		{
			ClearStaminaDepletedBuff();
		}
	}

	private void OnBindOnSetIdxValueChange(int AttrId, float OldValue, float NewValue)
	{
		if (AttrId == 158)
		{
			OnStaminaChanged(EBGUAttrFloat.Stamina, OldValue, NewValue);
		}
	}

	private void OnStaminaChanged(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		if (OldValue != NewValue && NewValue <= 0f)
		{
			OnStaminaDepleted();
		}
	}

	private void OnFreezeCostAttr(EAttrCostType AttrCostType, float FreezeTime, int NotifyUniqueID)
	{
		if (AttrCostType == EAttrCostType.Stamina)
		{
			if (StaminaData.MapStaminaFreezeTimer.ContainsKey(NotifyUniqueID))
			{
				StaminaData.MapStaminaFreezeTimer[NotifyUniqueID] = FreezeTime;
			}
			else
			{
				StaminaData.MapStaminaFreezeTimer.Add(NotifyUniqueID, FreezeTime);
			}
		}
	}

	private void UpdateStaminaRecover(float DeltaTime)
	{
		foreach (int item in StaminaData.MapStaminaFreezeTimer.Keys.ToList())
		{
			if (StaminaData.MapStaminaFreezeTimer[item] > 0f)
			{
				StaminaData.MapStaminaFreezeTimer[item] -= DeltaTime;
			}
			else
			{
				StaminaData.MapStaminaFreezeTimer.Remove(item);
			}
		}
		if (StaminaData.MapStaminaFreezeTimer.Count <= 0 && !SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Stamina);
			float floatValMax = AttrContainer.GetFloatValMax(EBGUAttrFloat.Stamina);
			if (!(floatValue >= floatValMax))
			{
				StaminaData.StaminaRecoverFinal = AttrContainer.GetFloatValue(EBGUAttrFloat.StaminaRecover) * StaminaData.GetStaminaRecoverMul();
				float increaseValue = StaminaData.StaminaRecoverFinal * DeltaTime;
				base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Stamina, increaseValue);
			}
		}
	}

	private void UpdateSprintStaminaCost(float DeltaTime)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter.GetLastMovementInputVector().Size() < 0.001f || HardmMoveData.IsHardMoving() || !UnitStateData.HasState(EBGUUnitState.Sprinting) || !BGUFunctionLibraryCS.BGUCanMoveRun(aCharacter))
		{
			return;
		}
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(GetActorResID(), Owner);
		if (playerCommDesc != null)
		{
			float attrCostBase = playerCommDesc.StaminaCostMoveFast * DeltaTime;
			BGW_EffectTemplateList.Get(aCharacter).GetAttrCostTemplate(EAttrCostType.Stamina).DoCostAttrValue(aCharacter, AttrContainer, attrCostBase, 0f);
			if (StaminaData.MapStaminaFreezeTimer.ContainsKey(-1))
			{
				StaminaData.MapStaminaFreezeTimer[-1] += DeltaTime;
			}
			else
			{
				StaminaData.MapStaminaFreezeTimer.Add(-1, DeltaTime);
			}
		}
	}

	private void UpdateStaminaDepleted()
	{
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.StaminaDepleted);
		if (flag && UnitStateData.HasState(EBGUUnitState.Sprinting))
		{
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.BreakSprint, -1f);
		}
		if (StaminaData.bLastFrameStaminaDepleted && !flag && PlayerInputActionData.bPressedSprinting)
		{
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.UnitInputSprintPressed, -1f);
		}
		StaminaData.bLastFrameStaminaDepleted = flag;
	}

	private void OnStaminaDepleted()
	{
		base.BUSEventCollection.Evt_OnStaminaDepleted.Invoke();
		int actorResID = BGU_DataUtil.GetActorResID(GetOwner());
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(actorResID, Owner);
		if (!BGW_LogUtil.LogIfNull(playerCommDesc, "Find UnitCommDesc failed, ResID: {0}", actorResID) && playerCommDesc.NoStaminaBuffID > 0 && !BuffData.HasBuff(playerCommDesc.NoStaminaBuffID))
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(playerCommDesc.NoStaminaBuffID, Owner, Owner, 0f, EBuffSourceType.Stamina);
		}
	}

	private void ClearStaminaDepletedBuff()
	{
		FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(GetActorResID(), Owner);
		if (playerCommDesc != null && playerCommDesc.NoStaminaBuffID > 0)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(playerCommDesc.NoStaminaBuffID, EBuffEffectTriggerType.None, 1);
		}
	}

	private void OnSetStaminaRecoverMul(float RecoverMul)
	{
		StaminaData.SetStaminaRecoverMul(RecoverMul);
	}

	private void OnResetStaminaRecoverMul()
	{
		StaminaData.ResetStaminaRecoverMul();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		AttrContainer.FloatAttrs.UnBindOnSetIdxValue(OnBindOnSetIdxValueChange);
	}
}
