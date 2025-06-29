using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectAwakePartner : BUEffectTemplate
{
	public BUEffectAwakePartner()
	{
		EffectType = EBuffAndSkillEffectType.AwakePartner;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = BGUFunctionLibraryCS.BGUGetTarget(Caster) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS2 = Target as BGUCharacterCS;
		if (!(bGUCharacterCS2 == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
			if (!(bUS_GSEventCollection == null) && (skillEffectDesc.EffectParamsInt.Count <= 0 || ((skillEffectDesc.EffectParamsInt.Count <= 1 || skillEffectDesc.EffectParamsInt.Contains(bGUCharacterCS2.GetResID())) && (skillEffectDesc.EffectParamsInt[0] != 0 || !(BGUFunctionLibraryCS.BGUGetTarget(Target) != null)))))
			{
				bUS_GSEventCollection.Evt_AICatchTarget.Invoke(bGUCharacterCS, ETargetSourceType.Target_AwakePartner);
			}
		}
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		AActor aActor = EntitySharedRefFuncLib.Actor(BuffInst.CasterRef);
		if (aActor == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = BGUFunctionLibraryCS.BGUGetTarget(aActor) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS2 = Target as BGUCharacterCS;
		if (bGUCharacterCS2 == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection == null))
		{
			int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
			if (intEffectParamCount <= 0 || ((intEffectParamCount <= 1 || buffDescRuntime.GetIntEffectParamList(EffectIdx).Contains(bGUCharacterCS2.GetResID())) && (buffDescRuntime.GetIntEffectParam(EffectIdx, 0) != 0 || !(BGUFunctionLibraryCS.BGUGetTarget(Target) != null))))
			{
				bUS_GSEventCollection.Evt_AICatchTarget.Invoke(bGUCharacterCS, ETargetSourceType.Target_AwakePartner);
			}
		}
	}
}
