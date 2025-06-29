using b1.EventDelDefine;
using BtlB1;
using BtlShare;

namespace b1;

public class BUS_DodgeComp : UActorCompBaseCS
{
	private BUC_RollData RollData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SkillInstsData SkillInstsData;

	public override void OnBeginPlay()
	{
		RollData = RequireWritableData<BUC_RollData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		InitData();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_TriggerRollSkill += new Del_TriggerRollSkill(TriggerRollSkill);
			bUS_GSEventCollection.Evt_ReStartDodgeCombo += new Del_Void(ReStartCombo);
			bUS_GSEventCollection.Evt_ChangeDodgeSkill += new Del_Void_IntInt(OnChangeDodgeSkill);
			bUS_GSEventCollection.Evt_ResetDodgeSkill += new Del_Void(OnResetDodgeSkill);
			bUS_GSEventCollection.Evt_MarkRolling += new Del_Void_Bool(OnMarkRolling);
		}
	}

	private void OnMarkRolling(bool bRolling)
	{
		RollData.bCastRollingSkill = bRolling;
	}

	private void InitData()
	{
		InitDodgeSkillID();
	}

	private void InitDodgeSkillID()
	{
		FUStPlayerInputSkillMappingDesc playerInputSkillMappingDesc = BGW_GameDB.GetPlayerInputSkillMappingDesc(GetActorResID(), GetOwner());
		if (playerInputSkillMappingDesc != null)
		{
			RollData.DodgeStartSkillID = playerInputSkillMappingDesc.DodgeStartSkillID;
			InitDodgeCombo();
		}
	}

	private void InitDodgeCombo()
	{
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(RollData.DodgeStartSkillID, GetOwner());
		if (skillSDesc != null && BGW_GameDB.GetRollSkillDesc(RollData.DodgeStartSkillID, Owner) != null && skillSDesc.SkillType == ESkillType.RollSkill)
		{
			ReadRollChain(RollData.DodgeStartSkillID);
		}
	}

	private void ReadRollChain(int SkillID)
	{
		if (RollData.RollCombo.Contains(SkillID))
		{
			RollData.RollComboLoopStartIdx = RollData.RollCombo.FindIndex((int r) => r == SkillID);
			return;
		}
		FUStRollSkillDesc rollSkillDesc = BGW_GameDB.GetRollSkillDesc(SkillID, Owner);
		if (rollSkillDesc != null)
		{
			RollData.RollCombo.Add(SkillID);
			if (rollSkillDesc.NextRollSkillID != 0)
			{
				ReadRollChain(rollSkillDesc.NextRollSkillID);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (RollData.CurStateIndex != 0 && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			ReStartCombo();
		}
	}

	private void OnChangeDodgeSkill(int DodgeSkillID, int PreciseDogeSkillID)
	{
		if (DodgeSkillID > 0)
		{
			ClearRollCombo();
			RollData.DodgeStartSkillID = DodgeSkillID;
			InitDodgeCombo();
		}
	}

	private void OnResetDodgeSkill()
	{
		ClearRollCombo();
		InitDodgeSkillID();
	}

	private void ClearRollCombo()
	{
		RollData.RollCombo.Clear();
		RollData.RollComboLoopStartIdx = -1;
	}

	private void CheckRollComboLoopUpdate()
	{
		if (RollData.CurStateIndex >= RollData.RollCombo.Count && RollData.RollComboLoopStartIdx >= 0)
		{
			RollData.CurStateIndex = RollData.RollComboLoopStartIdx;
		}
	}

	private void TriggerRollSkill(ESkillDirection RollDir)
	{
		if (GetOwner() as BGUCharacterCS == null)
		{
			return;
		}
		CheckRollComboLoopUpdate();
		if (RollData.RollCombo.Count < 1 || RollData.CurStateIndex >= RollData.RollCombo.Count)
		{
			return;
		}
		int skillID = RollData.RollCombo[RollData.CurStateIndex];
		FUStRollSkillDesc rollSkillDesc = BGW_GameDB.GetRollSkillDesc(skillID, Owner);
		if (rollSkillDesc != null && rollSkillDesc.EnableSkill != EGSYesNo.No)
		{
			if (rollSkillDesc.UseMultiRoll == EGSYesNo.No)
			{
				RollDir = ESkillDirection.Forward;
			}
			else if (rollSkillDesc.MultiJustInLock == EGSYesNo.Yes && !UnitStateData.HasState(EBGUUnitState.SideWalking))
			{
				RollDir = ESkillDirection.Forward;
			}
			RollData.CurStateIndex++;
			FCastSkillInfo cSI = new FCastSkillInfo(skillID, ECastSkillSourceType.DodgeSkill);
			cSI.SkillDirection = RollDir;
			base.BUSEventCollection.Evt_UnitCastSkillTryCMultiCast.Invoke(cSI);
			if (SkillInstsData.GetLastSkillCastResult() != ECastSkillResult.CSR_OK)
			{
				RollData.CurStateIndex--;
			}
			else
			{
				base.BUSEventCollection.Evt_CastDodgeSkillSuccess.Invoke();
			}
		}
	}

	private void ReStartCombo()
	{
		RollData.CurStateIndex = 0;
	}
}
