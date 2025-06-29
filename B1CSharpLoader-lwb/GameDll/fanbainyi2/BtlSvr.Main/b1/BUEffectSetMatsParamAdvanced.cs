using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUEffectSetMatsParamAdvanced : BUEffectTemplate
{
	public BUEffectSetMatsParamAdvanced()
	{
		EffectType = EBuffAndSkillEffectType.SetMatsParamAdvanced;
	}

	[ParamInfoS(0, "ParamName")]
	[ParamInfoF(6, "VectorYDefaultValue")]
	[ParamInfoI(0, "触发时强行设置默认值（0:false, 1:true)")]
	[ParamInfoI(1, "结束时恢复为缓存默认值（0:false, 1:true）")]
	[ParamInfoI(2, "参数类型（0=Scalar，1=Vector）")]
	[ParamInfoF(0, "ScalarValue")]
	[ParamInfoF(1, "ScalarDefaultValue")]
	[ParamInfoF(2, "VectorXValue")]
	[ParamInfoF(3, "VectorYValue")]
	[ParamInfoF(4, "VectorZValue")]
	[ParamInfoF(5, "VectorXDefaultValue")]
	[ParamInfoF(7, "VectorZDefaultValue")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		if (stringEffectParam.Equals(""))
		{
			return;
		}
		List<int> intEffectParamList = buffDescRuntime.GetIntEffectParamList(EffectIdx);
		if (intEffectParamList.Count < 3)
		{
			return;
		}
		bool forceUpdateDefaultValue = intEffectParamList[0] == 0;
		bool num = intEffectParamList[2] == 0;
		List<float> floatEffectParamList = buffDescRuntime.GetFloatEffectParamList(EffectIdx);
		if (num)
		{
			if (floatEffectParamList.Count >= 2)
			{
				float inScalarValueBlendInTime = 0f;
				float outScalarValueBlendOutTime = 0f;
				if (floatEffectParamList.Count >= 4)
				{
					inScalarValueBlendInTime = floatEffectParamList[2];
					outScalarValueBlendOutTime = floatEffectParamList[3];
				}
				bUS_GSEventCollection.Evt_SetMatsParam.Invoke(new FName(stringEffectParam), new MaterialParamInfo(floatEffectParamList[0], floatEffectParamList[1], inScalarValueBlendInTime, outScalarValueBlendOutTime), forceUpdateDefaultValue);
			}
		}
		else if (floatEffectParamList.Count >= 8)
		{
			bUS_GSEventCollection.Evt_SetMatsParam.Invoke(new FName(stringEffectParam), new MaterialParamInfo(new FLinearColor(floatEffectParamList[2], floatEffectParamList[3], floatEffectParamList[4]), new FLinearColor(floatEffectParamList[5], floatEffectParamList[6], floatEffectParamList[7])), forceUpdateDefaultValue);
		}
	}

	[TemplateFunNote("恢复")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
		if (stringEffectParam.Equals(""))
		{
			return;
		}
		List<int> intEffectParamList = buffDescRuntime.GetIntEffectParamList(EffectIdx);
		if (intEffectParamList.Count < 3 || intEffectParamList[1] != 1)
		{
			return;
		}
		bool num = intEffectParamList[2] == 0;
		List<float> floatEffectParamList = buffDescRuntime.GetFloatEffectParamList(EffectIdx);
		if (num)
		{
			if (floatEffectParamList.Count >= 2)
			{
				bUS_GSEventCollection.Evt_ResetMatsParam.Invoke(new FName(stringEffectParam));
			}
		}
		else if (floatEffectParamList.Count >= 8)
		{
			bUS_GSEventCollection.Evt_ResetMatsParam.Invoke(new FName(stringEffectParam));
		}
	}
}
