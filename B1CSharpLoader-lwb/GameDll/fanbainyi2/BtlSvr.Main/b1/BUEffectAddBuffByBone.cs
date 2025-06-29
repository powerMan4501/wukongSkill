using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUEffectAddBuffByBone : BUEffectTemplate
{
	public BUEffectAddBuffByBone()
	{
		EffectType = EBuffAndSkillEffectType.AddBuffByBone;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!(Caster is IECSWorldObj) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		USkeletalMeshComponent mesh = bGUCharacterCS.Mesh;
		FName hitBoneName = EffectInstReq.HitBoneName;
		if (hitBoneName == B1GlobalFNames.head || (mesh.GetBoneIndex(B1GlobalFNames.head) != -1 && mesh.BoneIsChildOf(hitBoneName, B1GlobalFNames.head)))
		{
			if (skillEffectDesc.EffectParamsInt.Count > 0)
			{
				int buffID = skillEffectDesc.EffectParamsInt[0];
				IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
				BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(buffID, readOnlyData);
				if (buffDescRuntime != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID, Caster, Caster, buffDescRuntime.GetDuration(), EBuffSourceType.AddBuffEffect);
				}
			}
		}
		else if (hitBoneName == B1GlobalFNames.clavicle_l || (mesh.GetBoneIndex(B1GlobalFNames.clavicle_l) != -1 && mesh.BoneIsChildOf(hitBoneName, B1GlobalFNames.clavicle_l)))
		{
			if (skillEffectDesc.EffectParamsInt.Count > 1)
			{
				int buffID2 = skillEffectDesc.EffectParamsInt[1];
				IBUC_PassiveSkillData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
				BuffDescRuntime buffDescRuntime2 = BGW_GameDB.GetBuffDescRuntime(buffID2, readOnlyData2);
				if (buffDescRuntime2 != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID2, Caster, Caster, buffDescRuntime2.GetDuration(), EBuffSourceType.AddBuffEffect);
				}
			}
		}
		else if (hitBoneName == B1GlobalFNames.clavicle_r || (mesh.GetBoneIndex(B1GlobalFNames.clavicle_r) != -1 && mesh.BoneIsChildOf(hitBoneName, B1GlobalFNames.clavicle_r)))
		{
			if (skillEffectDesc.EffectParamsInt.Count > 2)
			{
				int buffID3 = skillEffectDesc.EffectParamsInt[2];
				IBUC_PassiveSkillData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
				BuffDescRuntime buffDescRuntime3 = BGW_GameDB.GetBuffDescRuntime(buffID3, readOnlyData3);
				if (buffDescRuntime3 != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID3, Caster, Caster, buffDescRuntime3.GetDuration(), EBuffSourceType.AddBuffEffect);
				}
			}
		}
		else if (hitBoneName == B1GlobalFNames.thigh_l || (mesh.GetBoneIndex(B1GlobalFNames.thigh_l) != -1 && mesh.BoneIsChildOf(hitBoneName, B1GlobalFNames.thigh_l)))
		{
			if (skillEffectDesc.EffectParamsInt.Count > 3)
			{
				int buffID4 = skillEffectDesc.EffectParamsInt[3];
				IBUC_PassiveSkillData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
				BuffDescRuntime buffDescRuntime4 = BGW_GameDB.GetBuffDescRuntime(buffID4, readOnlyData4);
				if (buffDescRuntime4 != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID4, Caster, Caster, buffDescRuntime4.GetDuration(), EBuffSourceType.AddBuffEffect);
				}
			}
		}
		else if (hitBoneName == B1GlobalFNames.thigh_r || (mesh.GetBoneIndex(B1GlobalFNames.thigh_r) != -1 && mesh.BoneIsChildOf(hitBoneName, B1GlobalFNames.thigh_r)))
		{
			if (skillEffectDesc.EffectParamsInt.Count > 4)
			{
				int buffID5 = skillEffectDesc.EffectParamsInt[4];
				IBUC_PassiveSkillData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
				BuffDescRuntime buffDescRuntime5 = BGW_GameDB.GetBuffDescRuntime(buffID5, readOnlyData5);
				if (buffDescRuntime5 != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID5, Caster, Caster, buffDescRuntime5.GetDuration(), EBuffSourceType.AddBuffEffect);
				}
			}
		}
		else if (skillEffectDesc.EffectParamsInt.Count > 5)
		{
			int buffID6 = skillEffectDesc.EffectParamsInt[5];
			IBUC_PassiveSkillData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
			BuffDescRuntime buffDescRuntime6 = BGW_GameDB.GetBuffDescRuntime(buffID6, readOnlyData6);
			if (buffDescRuntime6 != null)
			{
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID6, Caster, Caster, buffDescRuntime6.GetDuration(), EBuffSourceType.AddBuffEffect);
			}
		}
	}
}
