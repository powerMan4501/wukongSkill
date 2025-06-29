using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_AbnormalHandleComp : UActorCompBaseCS
{
	private b1.BUC_AbnormalHandleData AbnormalHandleData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_SkillInstsData SkillInstsData;

	public override void OnAttach()
	{
		AbnormalHandleData = RequireWritableData<b1.BUC_AbnormalHandleData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		base.BUSEventCollection.Evt_PlayBRKSuperSkillArmorMontage += new Del_Void(OnPlayBRKSuperSkillArmorMontage);
		base.BUSEventCollection.Evt_TriggerSkillSuperArmor += new Del_TriggerSkillSuperArmor(OnTriggerSkillSuperArmor);
		base.BUSEventCollection.Evt_RemoveSkillSuperArmor += new Del_Void_Int(OnRemoveSkillSuperArmor);
	}

	public override void PreBeginPlay()
	{
		AbnormalHandleData.InitData();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!UnitStateData.HasState(EBGUUnitState.Dead))
		{
			UpdateForRemoveSimpleState(DeltaTime);
		}
	}

	private void UpdateForRemoveSimpleState(float DeltaTime)
	{
		AActor owner = GetOwner();
		if (owner == null || owner.IsPendingKill || SimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			return;
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.InPointAttraction) && AbnormalHandleData.RemovePAStateTimer > 0f)
		{
			AbnormalHandleData.RemovePAStateTimer -= DeltaTime;
			if (AbnormalHandleData.RemovePAStateTimer <= 0f)
			{
				AbnormalHandleData.ResetBHAInfo();
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.InPointAttraction, IsRemove: true);
			}
		}
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.BreakSkillSuperArmor) && AbnormalHandleData.RemoveBRKSkillSuperArmorStateTimer > 0f)
		{
			AbnormalHandleData.RemoveBRKSkillSuperArmorStateTimer -= DeltaTime;
			if (AbnormalHandleData.RemoveBRKSkillSuperArmorStateTimer <= 0f)
			{
				AbnormalHandleData.ResetBreakSSAInfo();
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakSkillSuperArmor, IsRemove: true);
			}
		}
	}

	private void OnTriggerSkillSuperArmor(UAnimMontage AssignedAnimMontage, float SetArmorValue, int UniqueID)
	{
		if (!(GetOwner() as ACharacter == null))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.SkillSuperArmor);
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.SkillSuperArmor, SetArmorValue);
			AbnormalHandleData.AssignedSSABreakAM = AssignedAnimMontage;
			AddAttrInSkillSuperArmor(UniqueID);
		}
	}

	private void OnPlayBRKSuperSkillArmorMontage()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(aCharacter);
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID))
		{
			return;
		}
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillInstsData.CurrentCastingSkillID, aCharacter);
		if (skillSDesc != null)
		{
			UAnimMontage uAnimMontage = null;
			if (AbnormalHandleData.AssignedSSABreakAM != null)
			{
				uAnimMontage = AbnormalHandleData.AssignedSSABreakAM;
			}
			if (uAnimMontage == null)
			{
				uAnimMontage = BGW_PreloadAssetMgr.Get(aCharacter).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.SkillArmorBrokeMontage, ELoadResourceType.SyncLoadAndCache);
			}
			if (uAnimMontage != null)
			{
				float num = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(aCharacter, uAnimMontage, 0);
				AbnormalHandleData.RemoveBRKSkillSuperArmorStateTimer = num;
				base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
				base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("技能霸体护甲打破");
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakSkillSuperArmor);
				BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None);
				base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
			}
		}
	}

	private void OnRemoveSkillSuperArmor(int UniqueID)
	{
		if (!(GetOwner() as ACharacter == null))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.SkillSuperArmor, IsRemove: true);
			RecoveryAttrInSkillSuperArmor(UniqueID);
		}
	}

	public void AddAttrInSkillSuperArmor(int UniqueID)
	{
		if (!AbnormalHandleData.DmgDefInSkillSuperArmor.ContainsKey(UniqueID) && OwnerAsCharacterCS != null)
		{
			FUStUnitLevelUpDesc unitLevelUpDesc = BGW_GameDB.GetUnitLevelUpDesc(OwnerAsCharacterCS.GetResID(), OwnerAsCharacterCS.GetFinalBattleInfoExtendID());
			if (unitLevelUpDesc != null)
			{
				float num = unitLevelUpDesc.DmgDefInSSA;
				AbnormalHandleData.DmgDefInSkillSuperArmor.Add(UniqueID, num);
				base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.DmgDefBase, num);
			}
		}
	}

	public void RecoveryAttrInSkillSuperArmor(int UniqueID)
	{
		if (AbnormalHandleData.DmgDefInSkillSuperArmor.ContainsKey(UniqueID))
		{
			float num = AbnormalHandleData.DmgDefInSkillSuperArmor[UniqueID];
			AbnormalHandleData.DmgDefInSkillSuperArmor.Remove(UniqueID);
			base.BUSEventCollection.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.DmgDefBase, 0f - num);
		}
	}
}
