using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Google.Protobuf.Collections;
using UnrealEngine.Engine;

namespace b1;

public class BUS_IronBodyComp : UActorCompBaseCS
{
	private BUC_IronBodyData IronBodyData;

	private IBUC_ChargeSkillData ChargeSkillData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_PassiveSkillData PassiveSkillData;

	public override void OnAttach()
	{
		IronBodyData = RequireWritableData<BUC_IronBodyData>();
		ChargeSkillData = RequireReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		PassiveSkillData = RequireReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>();
		base.BUSEventCollection.Evt_CastIronBody += new Del_CastIronBody(OnCastIronBody);
		base.BUSEventCollection.Evt_IronBodyStart += new Del_Void(OnIronBodyStart);
		base.BUSEventCollection.Evt_OnRemoveIronBodyStartBuff += new Del_Void(OnRemoveIronBodyStartBuff);
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		int actorResID = GetActorResID();
		FUStIronBodyConfigDesc ironBodyConfigDesc = BGW_GameDB.GetIronBodyConfigDesc(actorResID, Owner);
		if (ironBodyConfigDesc != null)
		{
			IronBodyData.ResId = actorResID;
			IronBodyData.BeginPreciseWindowTime = ironBodyConfigDesc.BeginPreciseWindowTime;
			IronBodyData.EndPreciseWindowTime = ironBodyConfigDesc.EndPreciseWindowTime;
			IronBodyData.IsInPrecise = false;
			IronBodyData.CurrentTime = 0f;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!(GetOwner() == null))
		{
			UpdataTime(DeltaTime);
		}
	}

	private void UpdataTime(float DeltaTime)
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.InTTTB))
		{
			IronBodyData.IsUpdataTime = false;
			IronBodyData.CurrentTime = 0f;
		}
		if (IronBodyData.IsUpdataTime)
		{
			IronBodyData.CurrentTime += DeltaTime;
		}
		IronBodyData.IsInPrecise = IronBodyData.CurrentTime < IronBodyData.BeginPreciseWindowTime + IronBodyData.EndPreciseWindowTime && IronBodyData.CurrentTime > IronBodyData.BeginPreciseWindowTime;
	}

	private void UpdateAttacker(AActor Attacker)
	{
		IronBodyData.Attacker = Attacker;
	}

	private void OnIronBodyStart()
	{
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentChargeSkillID, Owner);
		if (chargeSkillSDesc != null)
		{
			IronBodyData.EndSkillID = chargeSkillSDesc.EndSkillID;
		}
		IronBodyData.IsDefeat = false;
		IronBodyData.IsUpdataTime = true;
		FUStIronBodyConfigDesc ironBodyConfigDesc = BGW_GameDB.GetIronBodyConfigDesc(GetActorResID(), Owner);
		if (ironBodyConfigDesc != null && ironBodyConfigDesc.StartTriggerInfoList != null)
		{
			TriggerIronBodyBuffAndEffect(ironBodyConfigDesc.StartTriggerInfoList);
		}
		base.BGSEventCollection?.Evt_BGS_ClearAttachedProjectiles_OnUnit.Invoke(Owner);
	}

	private void OnCastIronBody(AActor Attacker, int SkillEffectID, ESkillDamageType SkillDamageType)
	{
		FUStIronBodyConfigDesc ironBodyConfigDesc = BGW_GameDB.GetIronBodyConfigDesc(GetActorResID(), Owner);
		if (ironBodyConfigDesc == null)
		{
			return;
		}
		if (Attacker as BGUCharacterCS == null)
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Attacker);
			if (readOnlyData == null)
			{
				return;
			}
			Attacker = readOnlyData.GetMasterActor();
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(GetActorResID());
		if (unitCommDesc == null)
		{
			return;
		}
		int num = 0;
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, Attacker);
		if (skillEffectDesc == null && SkillDamageType != ESkillDamageType.ExplosionAtk)
		{
			return;
		}
		UpdateAttacker(Attacker);
		if (skillEffectDesc != null)
		{
			int SkillDamageExpandID;
			FUStSkillDamageExpandDesc skillDamageExpandDesc = BGW_GameDB.GetSkillDamageExpandDesc(SkillEffectID, Attacker, out SkillDamageExpandID);
			if (ironBodyConfigDesc != null && skillDamageExpandDesc != null)
			{
				switch (skillDamageExpandDesc.HitWeightGearType)
				{
				case EHitWeightGearType.LowHitWeight:
					num = ironBodyConfigDesc.LowHitWeight;
					break;
				case EHitWeightGearType.MediueHitWeight:
					num = ironBodyConfigDesc.MediueHitWeight;
					break;
				case EHitWeightGearType.HeightHitWeight:
					num = ironBodyConfigDesc.HeightHitWeight;
					break;
				case EHitWeightGearType.HugeHitWeight:
					num = ironBodyConfigDesc.HugeHitWeight;
					break;
				case EHitWeightGearType.MustDefeatHitWeight:
					num = ironBodyConfigDesc.MustDefeatHitWeight;
					break;
				}
			}
		}
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.CanDefeatTTTBAdditive, out var ConfigInfo);
		float num2 = (BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Attacker).HasSimpleState(EBGUSimpleState.CanDefeatTTTB) ? ConfigInfo.FloatValue : 0f);
		if ((float)(num + unitCommDesc.DefaultTenacity) + num2 - (float)ironBodyConfigDesc.PlayerDefense > 0f)
		{
			TriggerIronBodyBuffAndEffect(ironBodyConfigDesc.DefeatTriggerInfoList);
			IronBodyData.IsDefeat = true;
			return;
		}
		TriggerIronBodyBuffAndEffect(IronBodyData.IsInPrecise ? ironBodyConfigDesc.PreciseTriggerInfoList : ironBodyConfigDesc.NotPreciseTriggerInfoList);
		FUStChargeSkillSDesc chargeSkillSDesc = BGW_GameDB.GetChargeSkillSDesc(ChargeSkillData.CurrentChargeSkillID, Owner);
		if (chargeSkillSDesc != null)
		{
			IronBodyData.IsDefeat = false;
			base.BUSEventCollection.Evt_RequestSmartCastSkill.Invoke(chargeSkillSDesc.EndSkillID, null);
		}
	}

	private void OnRemoveIronBodyStartBuff()
	{
		if (!SimpleStateData.HasSimpleState(EBGUSimpleState.InTTTB))
		{
			return;
		}
		FUStIronBodyConfigDesc ironBodyConfigDesc = BGW_GameDB.GetIronBodyConfigDesc(GetActorResID(), Owner);
		if (ironBodyConfigDesc == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(IronBodyData.Attacker);
		foreach (FUStIronBodyBuffTriggerInfo startTriggerInfo in ironBodyConfigDesc.StartTriggerInfoList)
		{
			if (startTriggerInfo != null && startTriggerInfo.BuffID != 0)
			{
				if (startTriggerInfo.IronBodyBuffTarget == FUStIronBodyBuffTarget.Victim)
				{
					base.BUSEventCollection.Evt_BuffRemove.Invoke(startTriggerInfo.BuffID, EBuffEffectTriggerType.None, 1);
				}
				else if (startTriggerInfo.IronBodyBuffTarget == FUStIronBodyBuffTarget.Attacker)
				{
					bUS_GSEventCollection.Evt_BuffRemove.Invoke(startTriggerInfo.BuffID, EBuffEffectTriggerType.None, 1);
				}
			}
		}
	}

	private void TriggerIronBodyBuffAndEffect(RepeatedField<FUStIronBodyBuffTriggerInfo> Infos)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(IronBodyData.Attacker);
		foreach (FUStIronBodyBuffTriggerInfo Info in Infos)
		{
			if (Info != null && Info.BuffID != 0)
			{
				if (Info.IronBodyBuffTarget == FUStIronBodyBuffTarget.Victim)
				{
					base.BUSEventCollection.Evt_BuffAdd.Invoke(Info.BuffID, Owner, Owner, 0f, EBuffSourceType.IronBody);
				}
				else if (Info.IronBodyBuffTarget == FUStIronBodyBuffTarget.Attacker)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(Info.BuffID, Owner, Owner, 0f, EBuffSourceType.IronBody);
				}
			}
		}
	}
}
