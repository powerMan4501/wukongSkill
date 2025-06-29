using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using b1.ECS;
using BtlB1;
using BtlShare;

namespace b1;

public class BUC_PassiveSkillData : IBUC_PassiveSkillData, IPersistentECSData
{
	private Dictionary<string, List<float>> AddMods = new Dictionary<string, List<float>>();

	private Dictionary<string, List<float>> MulMods = new Dictionary<string, List<float>>();

	private Dictionary<string, List<float>> OverrideStack = new Dictionary<string, List<float>>();

	public Dictionary<int, FUStSkillSDesc> CachedSkillSDescs { get; set; } = new Dictionary<int, FUStSkillSDesc>();

	public Dictionary<int, FUStSkillEffectDesc> CachedSkillEffectDescs { get; set; } = new Dictionary<int, FUStSkillEffectDesc>();

	public Dictionary<int, FUStPlayerSkillCtrlDesc> CachedPlayerSkillCtrlDescs { get; set; } = new Dictionary<int, FUStPlayerSkillCtrlDesc>();

	public Dictionary<int, FUStChargeSkillSDesc> CachedChargeSkillSDescs { get; set; } = new Dictionary<int, FUStChargeSkillSDesc>();

	public Dictionary<int, Dictionary<string, float>> CachedBuffModifyData { get; set; } = new Dictionary<int, Dictionary<string, float>>();

	public Dictionary<int, FUStRollSkillDesc> CachedRollDescs { get; set; } = new Dictionary<int, FUStRollSkillDesc>();

	public Dictionary<int, FUStSummonCommDesc> CachedSummonCommDescs { get; set; } = new Dictionary<int, FUStSummonCommDesc>();

	public Dictionary<int, FUStPlayerInputSkillMappingDesc> CachedPlayerCommSkillDescs { get; set; } = new Dictionary<int, FUStPlayerInputSkillMappingDesc>();

	public Dictionary<int, FUStIronBodyConfigDesc> CachedIronBodyConfigDescs { get; set; } = new Dictionary<int, FUStIronBodyConfigDesc>();

	public Dictionary<int, FUStSkillDamageExpandDesc> CachedSkillDamageExpandDescs { get; set; } = new Dictionary<int, FUStSkillDamageExpandDesc>();

	public Dictionary<int, int> ChachedPotentialEnergyConfigID { get; set; } = new Dictionary<int, int>();

	public Dictionary<int, Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>>> CachedPotentialEnergyConfigDescs { get; set; } = new Dictionary<int, Dictionary<int, Dictionary<int, FUStPotentialEnergyConfigDesc>>>();

	public Dictionary<int, FUStPartRuleInfoDesc> CachedPartRuleInfoDescs { get; set; } = new Dictionary<int, FUStPartRuleInfoDesc>();

	public Dictionary<int, FUStProjectileCommDesc> CachedProjectileCommDescs { get; set; } = new Dictionary<int, FUStProjectileCommDesc>();

	public Dictionary<int, FUStAttrCopyConfigDesc> CacheAttrCopyConfigDescs { get; } = new Dictionary<int, FUStAttrCopyConfigDesc>();

	public Dictionary<int, FUStLifeSavingHairConfigDesc> CachedLifeSavingHairConfigDescs { get; } = new Dictionary<int, FUStLifeSavingHairConfigDesc>();

	public Dictionary<int, FUStSuperArmorLevelDesc> CachedFUStSuperArmorLevelDescs { get; set; } = new Dictionary<int, FUStSuperArmorLevelDesc>();

	public Dictionary<int, FUStPlayerCommDesc> CachedFUStPlayerCommDescs { get; set; } = new Dictionary<int, FUStPlayerCommDesc>();

	public Dictionary<int, FUStPhantomRushSkillConfigDesc> CachedFUStPhantomRushSkillConfigDescs { get; set; } = new Dictionary<int, FUStPhantomRushSkillConfigDesc>();

	public Dictionary<int, FUStEffectiveHitProjectileEffectDesc> CachedEffectiveHitProjectileEffectDescs { get; set; } = new Dictionary<int, FUStEffectiveHitProjectileEffectDesc>();

	public Dictionary<int, FUStSealingSpellSkillConfigDesc> CachedSealingSpellSkillConfigDescs { get; set; } = new Dictionary<int, FUStSealingSpellSkillConfigDesc>();

	public Dictionary<int, FUStTransQiTianDaShengConfigDesc> CachedTransQiTianDaShengConfigDescs { get; set; } = new Dictionary<int, FUStTransQiTianDaShengConfigDesc>();

	public void AddToAddMods(string AggregatedStr, float Value)
	{
		if (!AddMods.ContainsKey(AggregatedStr))
		{
			AddMods.Add(AggregatedStr, new List<float>());
		}
		AddMods[AggregatedStr].Add(Value);
	}

	public void RemoveFromAddMods(string AggregatedStr, float Value)
	{
		if (AddMods.ContainsKey(AggregatedStr))
		{
			AddMods[AggregatedStr].Remove(Value);
		}
	}

	public void AddToMulMods(string AggregatedStr, float Value)
	{
		if (!MulMods.ContainsKey(AggregatedStr))
		{
			MulMods.Add(AggregatedStr, new List<float>());
		}
		MulMods[AggregatedStr].Add(Value);
	}

	public void RemoveFromMulMods(string AggregatedStr, float Value)
	{
		if (MulMods.ContainsKey(AggregatedStr))
		{
			MulMods[AggregatedStr].Remove(Value);
		}
	}

	public void AddToOverrideStack(string AggregatedStr, float BaseValue, float Value)
	{
		if (!OverrideStack.ContainsKey(AggregatedStr))
		{
			OverrideStack.Add(AggregatedStr, new List<float>());
			if (OverrideStack[AggregatedStr].Count < 1)
			{
				OverrideStack[AggregatedStr].Add(BaseValue);
			}
		}
		OverrideStack[AggregatedStr].Add(Value);
	}

	public void RemoveFromOverrideStack(string AggregatedStr, float Value)
	{
		if (!OverrideStack.ContainsKey(AggregatedStr))
		{
			return;
		}
		List<float> list = OverrideStack[AggregatedStr];
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] == Value)
			{
				list.RemoveAt(i);
				break;
			}
		}
	}

	public float GetFinalValue(string AggregatedStr, float BaseValue)
	{
		return (GetLastFromOverrideStack(AggregatedStr, BaseValue) + GetSumOfAddMods(AggregatedStr)) * GetProductOfMulMods(AggregatedStr);
	}

	private float GetSumOfAddMods(string AggregatedStr)
	{
		float num = 0f;
		if (!AddMods.ContainsKey(AggregatedStr))
		{
			return num;
		}
		foreach (float item in AddMods[AggregatedStr])
		{
			num += item;
		}
		return num;
	}

	private float GetProductOfMulMods(string AggregatedStr)
	{
		float num = 1f;
		if (!MulMods.ContainsKey(AggregatedStr))
		{
			return num;
		}
		foreach (float item in MulMods[AggregatedStr])
		{
			num *= item;
		}
		return num;
	}

	private float GetLastFromOverrideStack(string AggregatedStr, float BaseValue)
	{
		if (!OverrideStack.ContainsKey(AggregatedStr) || OverrideStack[AggregatedStr].Count < 1)
		{
			return BaseValue;
		}
		List<float> list = OverrideStack[AggregatedStr];
		return list[list.Count - 1];
	}

	public string GetCompareResult()
	{
		StringBuilder InResultBuilder = new StringBuilder();
		GetCompareResult(ref InResultBuilder, CachedSkillSDescs, BGW_GameDB.GetOriginalSkillSDesc);
		GetCompareResult(ref InResultBuilder, CachedSkillEffectDescs, BGW_GameDB.GetOriginalSkillEffectDesc);
		return InResultBuilder.ToString();
	}

	private void GetCompareResult<T>(ref StringBuilder InResultBuilder, Dictionary<int, T> CachedDescs, Func<int, T> GetOriginalDescAction)
	{
		foreach (KeyValuePair<int, T> CachedDesc in CachedDescs)
		{
			T value = CachedDesc.Value;
			T val = GetOriginalDescAction(CachedDesc.Key);
			FieldInfo[] fields = typeof(T).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			foreach (FieldInfo fieldInfo in fields)
			{
				object value2 = fieldInfo.GetValue(value);
				object value3 = fieldInfo.GetValue(val);
				if (value2 is IList list && value3 is IList list2)
				{
					int count = list.Count;
					for (int j = 0; j < count; j++)
					{
						if (list[j] != list2[j])
						{
							InResultBuilder.AppendLine($"{typeof(T).Name}.{fieldInfo.Name}[{j}]: {list[j]}({list2[j]})\n");
						}
					}
				}
				else if (value2 != null && value3 != null)
				{
					string text = value2.ToString();
					string text2 = value3.ToString();
					if (text != text2)
					{
						InResultBuilder.AppendLine(typeof(T).Name + "." + fieldInfo.Name + ": " + text + "(" + text2 + ")\n");
					}
				}
			}
		}
	}
}
