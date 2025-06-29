using System.Collections.Generic;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;

namespace b1;

public class BUFFPlayerDashengTalentAttr : BUFixFunctionTemplate
{
	public BUFFPlayerDashengTalentAttr()
	{
		Type = EFixFunctionType.PlayerDashengTalentAttr;
	}

	public override void ApplyBySkill(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		Apply(Caster, Target, Param1, Param2, Param3, Param4, Param5, Param6, out OutAbs, out OutMul);
	}

	public override void ApplyByBuff(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		Apply(Caster, Target, Param1, Param2, Param3, Param4, Param5, Param6, out OutAbs, out OutMul);
	}

	public override void RemoveByBuff(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		Apply(Caster, Target, Param1, Param2, Param3, Param4, Param5, Param6, out OutAbs, out OutMul);
		OutAbs = 0f - OutAbs;
		OutMul = 1f / OutMul;
	}

	private void Apply(AActor Caster, AActor Target, int Param1, int Param2, int Param3, int Param4, int Param5, float Param6, out float OutAbs, out float OutMul)
	{
		BUC_TalentData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_TalentData>(Target);
		int num = 0;
		if (unPersistentReadOnlyData != null)
		{
			int actorResID = BGU_DataUtil.GetActorResID(Target);
			foreach (KeyValuePair<int, int> item in unPersistentReadOnlyData.ActivatingTalentDic)
			{
				TalentSDesc talentSDescByUnitResIDInMapCache = GameDBRuntime.GetTalentSDescByUnitResIDInMapCache(item.Key, actorResID);
				if (talentSDescByUnitResIDInMapCache != null && talentSDescByUnitResIDInMapCache.Type == TalentType.Legacy)
				{
					num++;
				}
			}
		}
		OutAbs = (float)num * Param6;
		OutMul = OutAbs / 10000f;
	}
}
