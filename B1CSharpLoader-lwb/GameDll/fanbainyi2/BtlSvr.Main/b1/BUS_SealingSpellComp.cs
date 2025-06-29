using System.Collections.Generic;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUS_SealingSpellComp : UActorCompBaseCS
{
	private static float INV1000 = 0.001f;

	private BUC_SealingSpellData SealingSpellData;

	private IBUC_BuffData BuffData;

	public override bool AllowTRO()
	{
		return false;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnAttach()
	{
		SealingSpellData = RequireWritableData<BUC_SealingSpellData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		base.BUSEventCollection.Evt_TriggerSealingSpell += new Del_Void(OnTriggerSealingSpell);
		base.BUSEventCollection.Evt_ResetSealingSpell += new Del_Void(OnResetSealingSpell);
		base.BUSEventCollection.Evt_AfterUnitRebirth += new Del_UnitRebirth(OnAfterUnitRebirth);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (SealingSpellData.IsInSealingSpellState)
		{
			SealingSpellData.SealingSpellDuration -= DeltaTime;
			if (SealingSpellData.SealingSpellDuration <= 0f)
			{
				RemoveCurrentSealingSpellEffect();
			}
		}
	}

	private void RemoveCurrentSealingSpellEffect()
	{
		if (!SealingSpellData.IsInSealingSpellState)
		{
			return;
		}
		FUStSealingSpellSkillConfigDesc sealingSpellSkillConfigDesc = BGW_GameDB.GetSealingSpellSkillConfigDesc(SealingSpellData.SealingSpellDescID, Owner);
		if (sealingSpellSkillConfigDesc != null)
		{
			foreach (int triggerLoppBuffID in sealingSpellSkillConfigDesc.TriggerLoppBuffIDs)
			{
				if (BuffData.HasBuff(triggerLoppBuffID))
				{
					base.BUSEventCollection.Evt_BuffRemove.Invoke(triggerLoppBuffID, EBuffEffectTriggerType.None, 1);
				}
			}
		}
		SealingSpellData.IsInSealingSpellState = false;
		SealingSpellData.SealingSpellDescID = -1;
		SealingSpellData.SealingSpellDuration = -1f;
	}

	private void OnTriggerSealingSpell()
	{
		if (SealingSpellData.IsInSealingSpellState)
		{
			RemoveCurrentSealingSpellEffect();
		}
		int actorResID = GetActorResID();
		foreach (KeyValuePair<int, FUStSealingSpellSkillConfigDesc> item in BGW_GameDB.GetAllSealingSpellSkillConfigDesc(Owner))
		{
			FUStSealingSpellSkillConfigDesc value = item.Value;
			if (value.ResID != actorResID)
			{
				continue;
			}
			SealingSpellData.IsInSealingSpellState = true;
			SealingSpellData.SealingSpellDescID = item.Key;
			SealingSpellData.SealingSpellDuration = (float)value.DurationMs * INV1000;
			foreach (int triggerBeginBuffID in value.TriggerBeginBuffIDs)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(triggerBeginBuffID, Owner, Owner, 0f, EBuffSourceType.SealingSpell);
			}
			foreach (int triggerLoppBuffID in value.TriggerLoppBuffIDs)
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(triggerLoppBuffID, Owner, Owner, -1f, EBuffSourceType.SealingSpell);
			}
			if (value.TriggerSkillEffectIDs.Count <= 0)
			{
				continue;
			}
			FEffectInstReq fEffectInstReq = new FEffectInstReq(Owner);
			fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Owner);
			fEffectInstReq.HitActionDir = EHitActionDir.Default;
			FEffectInstReq effectInstReq = fEffectInstReq;
			foreach (int triggerSkillEffectID in value.TriggerSkillEffectIDs)
			{
				base.BUSEventCollection.Evt_TriggerSkillEffect.Invoke(triggerSkillEffectID, effectInstReq);
			}
		}
	}

	private void OnResetSealingSpell()
	{
		RemoveCurrentSealingSpellEffect();
	}

	private void OnAfterUnitRebirth(ERebirthType RebirthType)
	{
		RemoveCurrentSealingSpellEffect();
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		RemoveCurrentSealingSpellEffect();
	}
}
