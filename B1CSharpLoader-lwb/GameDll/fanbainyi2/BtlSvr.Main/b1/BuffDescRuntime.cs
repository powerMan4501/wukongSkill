using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;

namespace b1;

public class BuffDescRuntime
{
	private Dictionary<string, float> ModifyData;

	private FUStBuffDesc BuffDesc;

	private string[] ActiveConditionStringParams;

	public BuffDescRuntime(int BuffID, IBUC_PassiveSkillData PassiveSkillData, FUStBuffDesc InBuffDesc)
	{
		if (PassiveSkillData != null && PassiveSkillData.CachedBuffModifyData != null)
		{
			PassiveSkillData.CachedBuffModifyData.TryGetValue(BuffID, out ModifyData);
		}
		BuffDesc = InBuffDesc;
	}

	public BuffDescRuntime(Dictionary<string, float> InModifyData, FUStBuffDesc InBuffDesc)
	{
		ModifyData = InModifyData;
		BuffDesc = InBuffDesc;
	}

	private (int, float) GetValueByModifyMethod(EModifyMethod InModifyMethod, int InSubID = 0, int InSubID2 = 0)
	{
		if (ModifyData != null && ModifyData.Count > 0)
		{
			foreach (KeyValuePair<string, float> modifyDatum in ModifyData)
			{
				string key = modifyDatum.Key;
				float value = modifyDatum.Value;
				string[] array = key.Split(',');
				if (array.Length == 0 || !Enum.TryParse<EModifyMethod>(array[0], out var result) || result != InModifyMethod)
				{
					continue;
				}
				switch (result)
				{
				case EModifyMethod.BuffDuration:
				case EModifyMethod.BuffInterval:
				case EModifyMethod.BuffMaxLayer:
				case EModifyMethod.BuffTargetCount:
				case EModifyMethod.BuffRange:
				case EModifyMethod.BuffDelayTime:
					return ((int)value, -1f);
				case EModifyMethod.BuffEffectFloatN:
					if (array.Length > 3)
					{
						int num3 = int.Parse(array[2]);
						int num4 = int.Parse(array[3]);
						if (InSubID == num3 && InSubID2 == num4)
						{
							return (-1, value);
						}
					}
					break;
				case EModifyMethod.BuffEffectIntN:
					if (array.Length > 3)
					{
						int num = int.Parse(array[2]);
						int num2 = int.Parse(array[3]);
						if (InSubID == num && InSubID2 == num2)
						{
							return ((int)value, -1f);
						}
					}
					break;
				default:
					BGW_LogUtil.LogError("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
					BGW_LogUtil.LogError("Failed to get buff modified data with unprocessed buff modify method: {}!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!", result);
					BGW_LogUtil.LogError("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
					break;
				}
			}
		}
		return InModifyMethod switch
		{
			EModifyMethod.BuffDuration => (BuffDesc.Duration, -1f), 
			EModifyMethod.BuffInterval => (BuffDesc.Interval, -1f), 
			EModifyMethod.BuffMaxLayer => (BuffDesc.MaxLayer, -1f), 
			EModifyMethod.BuffTargetCount => (BuffDesc.TargetCount, -1f), 
			EModifyMethod.BuffDelayTime => (BuffDesc.Delay, -1f), 
			EModifyMethod.BuffRange => (BuffDesc.Range.RangeParam[0], -1f), 
			EModifyMethod.BuffEffectFloatN => (-1, GetFloatEffectParamInternal(BuffDesc, InSubID, InSubID2)), 
			EModifyMethod.BuffEffectIntN => (GetIntEffectParamInternal(BuffDesc, InSubID, InSubID2), -1f), 
			_ => (-1, -1f), 
		};
	}

	private int GetIntEffectParamInternal(FUStBuffDesc BuffDesc, int EffectIdx, int ParamIdx)
	{
		if (BuffDesc == null || BuffDesc.BuffEffects == null || EffectIdx < 0 || BuffDesc.BuffEffects.Count <= EffectIdx || BuffDesc.BuffEffects[EffectIdx].EffectParams == null || ParamIdx < 0 || BuffDesc.BuffEffects[EffectIdx].EffectParams.Count <= ParamIdx)
		{
			return -1;
		}
		return BuffDesc.BuffEffects[EffectIdx].EffectParams[ParamIdx];
	}

	private float GetFloatEffectParamInternal(FUStBuffDesc BuffDesc, int EffectIdx, int ParamIdx)
	{
		if (BuffDesc == null || BuffDesc.BuffEffects == null || EffectIdx < 0 || BuffDesc.BuffEffects.Count <= EffectIdx || BuffDesc.BuffEffects[EffectIdx].EffectParamsFloat == null || ParamIdx < 0 || BuffDesc.BuffEffects[EffectIdx].EffectParamsFloat.Count <= ParamIdx)
		{
			return -1f;
		}
		return BuffDesc.BuffEffects[EffectIdx].EffectParamsFloat[ParamIdx];
	}

	private string GetStringEffectParamInternal(FUStBuffDesc BuffDesc, int EffectIdx, int ParamIdx)
	{
		if (BuffDesc.BuffEffects[EffectIdx].EffectParamsString.Count > ParamIdx)
		{
			return BuffDesc.BuffEffects[EffectIdx].EffectParamsString[ParamIdx];
		}
		return "";
	}

	public string[] GetSplittedActiveConditionParams()
	{
		if (ActiveConditionStringParams == null)
		{
			ActiveConditionStringParams = BuffDesc.BuffActiveCondition.ConditionParams.Split(',');
		}
		if (ModifyData != null && ModifyData.Count > 0)
		{
			foreach (KeyValuePair<string, float> modifyDatum in ModifyData)
			{
				string key = modifyDatum.Key;
				float value = modifyDatum.Value;
				string[] array = key.Split(',');
				if (array.Length > 2 && Enum.TryParse<EModifyMethod>(array[0], out var result) && result == EModifyMethod.BuffActiveConditionParams)
				{
					int num = int.Parse(array[2]);
					if (ActiveConditionStringParams.Length > num)
					{
						ActiveConditionStringParams[num] = value.ToString();
					}
				}
			}
		}
		return ActiveConditionStringParams;
	}

	public EGSBuffAndSkillEffectActiveCondition GetActiveConditionType()
	{
		return BuffDesc.BuffActiveCondition.ConditionType;
	}

	public EGSBuffLayerCounterType GetBuffLayerCounterType()
	{
		return BuffDesc.BuffLayerCounterType;
	}

	public int GetDuration()
	{
		return GetValueByModifyMethod(EModifyMethod.BuffDuration).Item1;
	}

	public int GetInterval()
	{
		return GetValueByModifyMethod(EModifyMethod.BuffInterval).Item1;
	}

	public int GetMaxLayer()
	{
		return GetValueByModifyMethod(EModifyMethod.BuffMaxLayer).Item1;
	}

	public int GetTargetCount()
	{
		return GetValueByModifyMethod(EModifyMethod.BuffTargetCount).Item1;
	}

	public int GetDelay()
	{
		return GetValueByModifyMethod(EModifyMethod.BuffDelayTime).Item1;
	}

	public ERangeType GetRangeType()
	{
		return BuffDesc.Range.RangeType;
	}

	public EEffectRangeCenterType GetRangeCenterType()
	{
		return BuffDesc.Range.RangeCenterType;
	}

	public int GetRangeParamCount()
	{
		return BuffDesc.Range.RangeParam.Count;
	}

	public int GetRangeParam(int Index)
	{
		if (Index != 0)
		{
			return BuffDesc.Range.RangeParam[Index];
		}
		return GetValueByModifyMethod(EModifyMethod.BuffRange).Item1;
	}

	public IList<int> GetRangeParamList()
	{
		IList<int> rangeParam = BuffDesc.Range.RangeParam;
		if (rangeParam.Count < 1)
		{
			return rangeParam;
		}
		if (ModifyData != null && ModifyData.Count > 0)
		{
			foreach (KeyValuePair<string, float> modifyDatum in ModifyData)
			{
				string key = modifyDatum.Key;
				float value = modifyDatum.Value;
				string[] array = key.Split(',');
				if (array.Length != 0 && Enum.TryParse<EModifyMethod>(array[0], out var result) && result == EModifyMethod.BuffRange)
				{
					rangeParam[0] = (int)value;
				}
			}
		}
		return rangeParam;
	}

	public int GetFloatEffectParamCount(int EffectIdx)
	{
		return BuffDesc.BuffEffects[EffectIdx].EffectParamsFloat.Count;
	}

	public int GetIntEffectParamCount(int EffectIdx)
	{
		return BuffDesc.BuffEffects[EffectIdx].EffectParams.Count;
	}

	public int GetStringEffectParamCount(int EffectIdx)
	{
		return BuffDesc.BuffEffects[EffectIdx].EffectParamsString.Count;
	}

	public float GetFloatEffectParam(int EffectIdx, int ParamIdx)
	{
		return GetValueByModifyMethod(EModifyMethod.BuffEffectFloatN, EffectIdx, ParamIdx).Item2;
	}

	public List<float> GetFloatEffectParamList(int EffectIdx)
	{
		int floatEffectParamCount = GetFloatEffectParamCount(EffectIdx);
		List<float> list = new List<float>(floatEffectParamCount);
		for (int i = 0; i < floatEffectParamCount; i++)
		{
			list.Add(GetFloatEffectParam(EffectIdx, i));
		}
		return list;
	}

	public int GetIntEffectParam(int EffectIdx, int ParamIdx)
	{
		return GetValueByModifyMethod(EModifyMethod.BuffEffectIntN, EffectIdx, ParamIdx).Item1;
	}

	public List<int> GetIntEffectParamList(int EffectIdx)
	{
		int intEffectParamCount = GetIntEffectParamCount(EffectIdx);
		List<int> list = new List<int>(intEffectParamCount);
		for (int i = 0; i < intEffectParamCount; i++)
		{
			list.Add(GetIntEffectParam(EffectIdx, i));
		}
		return list;
	}

	public string GetStringEffectParam(int EffectIdx, int ParamIdx)
	{
		return GetStringEffectParamInternal(BuffDesc, EffectIdx, ParamIdx);
	}

	public List<string> GetStringEffectParamList(int EffectIdx)
	{
		int stringEffectParamCount = GetStringEffectParamCount(EffectIdx);
		List<string> list = new List<string>(stringEffectParamCount);
		for (int i = 0; i < stringEffectParamCount; i++)
		{
			list.Add(GetStringEffectParam(EffectIdx, i));
		}
		return list;
	}

	public bool GetIsExclusiveBuff()
	{
		return BuffDesc.IsExclusiveBuff == EGSYesNo.Yes;
	}

	public bool GetCanBeInherited()
	{
		return BuffDesc.CanBeInherited == EGSYesNo.Yes;
	}

	public int GetAlmostEndAheadTime()
	{
		return BuffDesc.AlmostEndAheadTime;
	}

	public bool GetCanRemoveWhenAttacked()
	{
		return BuffDesc.CanRemoveWhenAttacked == EGSYesNo.Yes;
	}

	public bool GetCanRemoveWhenAttackHit()
	{
		return BuffDesc.CanRemoveWhenAttackHit == EGSYesNo.Yes;
	}

	public int GetEffectsCount()
	{
		return BuffDesc.BuffEffects.Count;
	}

	public EBuffAndSkillEffectType GetEffectType(int Index)
	{
		return BuffDesc.BuffEffects[Index].EffectType;
	}

	public EBuffEffectTriggerType GetEffectTriggerType(int Index)
	{
		return BuffDesc.BuffEffects[Index].EffectTrigger;
	}

	public EBuffEffectTargetSelectType GetEffectTargetSelectType(int Index)
	{
		return BuffDesc.BuffEffects[Index].EffectTargetSelectType;
	}

	public int GetTargetFilter()
	{
		return BuffDesc.TargetFilter;
	}

	public int GetTargetTypeFilter()
	{
		return BuffDesc.TargetTypeFilter;
	}

	public int GetAffiliationTypeFilter()
	{
		return BuffDesc.AffiliationTypeFilter;
	}

	public EBuffRangeTargetBase GetTargetBase()
	{
		return BuffDesc.TargetBase;
	}
}
