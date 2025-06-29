using System.Collections.Generic;

namespace b1;

public class DPSCalculateInfo
{
	public int DummyResID;

	public int PlayerRoleDataConfigID;

	public bool IsValid;

	public float TotalDamage;

	public int HitCount;

	public float MaxDamageOneHit;

	public EDPSCalTimeType DPSTimeType;

	public float TimeLimit;

	public float RemainTime;

	public float TotalTime;

	public float DPSCalTime;

	public Dictionary<int, float> ResIdDamageInfo;

	public Dictionary<int, float> SkillDamageInfo;

	public Dictionary<int, float> EffectDamageInfo;

	public float TotalSpecialDamage;

	public Dictionary<string, float> SpecialDamageInfo;

	public DPSCalculateInfo(int _DummyResID, int _PlayerRoleDataConfigID, EDPSCalTimeType _DPSTimeType, float _TimeLimit, bool _IsValid = true)
	{
		DummyResID = _DummyResID;
		PlayerRoleDataConfigID = _PlayerRoleDataConfigID;
		TotalDamage = (TotalSpecialDamage = 0f);
		HitCount = 0;
		DPSTimeType = _DPSTimeType;
		TotalTime = (DPSCalTime = 0f);
		TimeLimit = (RemainTime = _TimeLimit);
		MaxDamageOneHit = 0f;
		ResIdDamageInfo = new Dictionary<int, float>();
		SkillDamageInfo = new Dictionary<int, float>();
		EffectDamageInfo = new Dictionary<int, float>();
		SpecialDamageInfo = new Dictionary<string, float>();
		IsValid = _IsValid;
	}

	public void ApplyDamage(float Damage, int ResID, int SkillID, int EffectID, List<string> SpecialDamageTypeList)
	{
		if (DPSTimeType == EDPSCalTimeType.FromLastHit)
		{
			RemainTime = TimeLimit;
		}
		DPSCalTime = TotalTime;
		MaxDamageOneHit = ((MaxDamageOneHit > Damage) ? MaxDamageOneHit : Damage);
		if (SkillDamageInfo.ContainsKey(SkillID))
		{
			SkillDamageInfo[SkillID] += Damage;
		}
		else
		{
			SkillDamageInfo.Add(SkillID, Damage);
		}
		if (EffectDamageInfo.ContainsKey(EffectID))
		{
			EffectDamageInfo[EffectID] += Damage;
		}
		else
		{
			EffectDamageInfo.Add(EffectID, Damage);
		}
		if (ResIdDamageInfo.ContainsKey(ResID))
		{
			ResIdDamageInfo[ResID] += Damage;
		}
		else
		{
			ResIdDamageInfo.Add(ResID, Damage);
		}
		if (SpecialDamageTypeList != null && SpecialDamageTypeList.Count > 0)
		{
			foreach (string SpecialDamageType in SpecialDamageTypeList)
			{
				if (SpecialDamageInfo.ContainsKey(SpecialDamageType))
				{
					SpecialDamageInfo[SpecialDamageType] += Damage;
				}
				else
				{
					SpecialDamageInfo.Add(SpecialDamageType, Damage);
				}
			}
			TotalSpecialDamage += Damage;
		}
		TotalDamage += Damage;
		HitCount++;
	}

	public float GetDPSValue()
	{
		if (DPSTimeType == EDPSCalTimeType.FromLastHit)
		{
			if (HitCount != 1)
			{
				return TotalDamage / DPSCalTime;
			}
			return TotalDamage;
		}
		return TotalDamage / TotalTime;
	}

	public float GetDPHValue()
	{
		return TotalDamage / (float)HitCount;
	}

	public void GetMaxOneHitDamageInfo(out int EffectID, out float Damage)
	{
		EffectID = 0;
		Damage = 0f;
		foreach (KeyValuePair<int, float> item in EffectDamageInfo)
		{
			if (item.Value > Damage)
			{
				EffectID = item.Key;
				Damage = item.Value;
			}
		}
	}

	public bool Tick(float DeltaTime)
	{
		TotalTime += DeltaTime;
		RemainTime -= DeltaTime;
		return RemainTime < 0f;
	}
}
