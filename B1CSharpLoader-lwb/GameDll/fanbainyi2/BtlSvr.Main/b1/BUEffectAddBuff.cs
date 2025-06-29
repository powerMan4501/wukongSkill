using System;
using System.Collections.Generic;
using System.Linq;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectAddBuff : BUEffectTemplate
{
	public BUEffectAddBuff()
	{
		EffectType = EBuffAndSkillEffectType.AddBuff;
	}

	[ParamInfoF(3, "BuffID_3的持续时间,单位毫秒，填0表示读取Buff表配置")]
	[ParamInfoF(2, "BuffID_2的持续时间,单位毫秒，填0表示读取Buff表配置")]
	[ParamInfoI(1, "BuffID_1")]
	[ParamInfoI(2, "BuffID_2")]
	[ParamInfoI(3, "BuffID_3")]
	[ParamInfoF(0, "BuffID_0的持续时间,单位毫秒，填0表示读取Buff表配置")]
	[ParamInfoI(0, "BuffID_0")]
	[ParamInfoF(1, "BuffID_1的持续时间,单位毫秒，填0表示读取Buff表配置")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		List<int> list = skillEffectDesc.EffectParamsInt.ToList();
		List<float> list2 = skillEffectDesc.EffectParamsFloat.ToList();
		for (int i = 0; i < list.Count; i++)
		{
			float duration = 0f;
			if (list2.Count > i)
			{
				duration = list2[i];
			}
			bUS_GSEventCollection.Evt_BuffAdd.Invoke(list[i], Caster, Caster, duration, EBuffSourceType.AddBuffEffect);
		}
	}

	private static void ApplyBySkillUseStringParam(int EffectID, AActor Caster, AActor Target)
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
		if (skillEffectDesc.EffectParamsInt.Count >= 1)
		{
			int buffID = skillEffectDesc.EffectParamsInt[0];
			IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(buffID, readOnlyData);
			if (buffDescRuntime != null)
			{
				int num = buffDescRuntime.GetDuration();
				if (skillEffectDesc.EffectParamsInt.Count >= 2)
				{
					int num2 = skillEffectDesc.EffectParamsInt[1];
					if (num2 > 0)
					{
						num = num2;
					}
				}
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID, Caster, Caster, num, EBuffSourceType.AddBuffEffect);
			}
		}
		if (skillEffectDesc.EffectParamsStr.Count < 1)
		{
			return;
		}
		string[] array = skillEffectDesc.EffectParamsStr[0].Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		int num3 = array.Length;
		if (num3 <= 0)
		{
			return;
		}
		int[] array2 = new int[num3];
		int[] array3 = new int[num3];
		for (int i = 0; i < num3; i++)
		{
			array2[i] = -1;
			array3[i] = 0;
			if (int.TryParse(array[i], out var result))
			{
				IBUC_PassiveSkillData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(Caster);
				BuffDescRuntime buffDescRuntime2 = BGW_GameDB.GetBuffDescRuntime(result, readOnlyData2);
				if (buffDescRuntime2 != null)
				{
					array3[i] = buffDescRuntime2.GetDuration();
					array2[i] = result;
				}
			}
		}
		if (skillEffectDesc.EffectParamsStr.Count >= 2)
		{
			string[] array4 = skillEffectDesc.EffectParamsStr[1].Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			if (array4.Length == num3)
			{
				for (int j = 0; j < num3; j++)
				{
					if (int.TryParse(array4[j], out var result2) && result2 != 0)
					{
						array3[j] = result2;
					}
				}
			}
		}
		for (int k = 0; k < num3; k++)
		{
			int num4 = array2[k];
			if (num4 >= 0)
			{
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(num4, Caster, Caster, array3[k], EBuffSourceType.AddBuffEffect);
			}
		}
	}

	[ParamInfoF(3, "BuffID_3的持续时间,单位毫秒，填0表示读取Buff表配置")]
	[ParamInfoF(2, "BuffID_2的持续时间,单位毫秒，填0表示读取Buff表配置")]
	[ParamInfoF(1, "BuffID_1的持续时间,单位毫秒，填0表示读取Buff表配置")]
	[ParamInfoF(0, "BuffID_0的持续时间,单位毫秒，填0表示读取Buff表配置")]
	[ParamInfoI(3, "BuffID_3")]
	[ParamInfoI(2, "BuffID_2")]
	[ParamInfoI(1, "BuffID_1")]
	[ParamInfoI(0, "BuffID_0")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection == null)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(EffectIdx);
		int floatEffectParamCount = buffDescRuntime.GetFloatEffectParamCount(EffectIdx);
		if (intEffectParamCount <= floatEffectParamCount)
		{
			for (int i = 0; i < intEffectParamCount; i++)
			{
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, i);
				int num = (int)buffDescRuntime.GetFloatEffectParam(EffectIdx, i);
				bUS_GSEventCollection.Evt_BuffAdd.Invoke(intEffectParam, EntitySharedRefFuncLib.Actor(BuffInst.CasterRef), EntitySharedRefFuncLib.Actor(BuffInst.RootCasterRef), num, EBuffSourceType.AddBuffEffect, bRecursed: false, BuffInst.Caster_AttrMemData);
			}
		}
	}
}
