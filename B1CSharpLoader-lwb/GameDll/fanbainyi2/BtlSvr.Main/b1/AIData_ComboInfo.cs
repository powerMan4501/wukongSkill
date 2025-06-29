using System.Collections.Generic;
using System.Linq;

namespace b1;

public class AIData_ComboInfo
{
	public List<int> CurComboHasCastSkillList;

	public bool IsFirstSkill;

	public int CurComboSkillNum;

	public int CurComboStage;

	public int CurComboLength;

	public Dictionary<int, float> SkillModifyScoreDic;

	public int MaxComboNum;

	public Dictionary<int, AISkillDynamicFeature> MapSkillFeatures;

	private const float SCORE_DISABLE_SKILL = -9999f;

	public void ResetComboInfo(bool IsFirstSkill, int CurComboSkillNum, int CurComboStage)
	{
		this.IsFirstSkill = IsFirstSkill;
		this.CurComboSkillNum = CurComboSkillNum;
		this.CurComboStage = CurComboStage;
	}

	public void Init(int UnitResID)
	{
		CurComboHasCastSkillList = new List<int>();
		SkillModifyScoreDic = new Dictionary<int, float>();
		IsFirstSkill = false;
		CurComboSkillNum = 0;
		CurComboStage = 0;
		MaxComboNum = 0;
		MapSkillFeatures = new Dictionary<int, AISkillDynamicFeature>();
		AIDataUtil.FOR_GET_VALID_SKILL_ID(UnitResID, MapSkillFeatures, delegate(Dictionary<int, AISkillDynamicFeature> MapSkillFeatures, int SkillID)
		{
			if (!MapSkillFeatures.ContainsKey(SkillID))
			{
				MapSkillFeatures.Add(SkillID, new AISkillDynamicFeature());
			}
		});
	}

	public void SetMaxComboNum(int _MaxComboNum)
	{
		MaxComboNum = _MaxComboNum;
	}

	public void SetComboLength(int _CurComboLength)
	{
		CurComboLength = _CurComboLength;
	}

	public void SetSkillCantCast(List<int> SkillIDListCanCast)
	{
		foreach (KeyValuePair<int, AISkillDynamicFeature> mapSkillFeature in MapSkillFeatures)
		{
			AISkillDynamicFeature value = mapSkillFeature.Value;
			if (!SkillIDListCanCast.Contains(mapSkillFeature.Key))
			{
				value.Score = -9999f;
			}
		}
		MapSkillFeatures = MapSkillFeatures.OrderByDescending((KeyValuePair<int, AISkillDynamicFeature> r) => r.Value.Score).ToDictionary((KeyValuePair<int, AISkillDynamicFeature> r) => r.Key, (KeyValuePair<int, AISkillDynamicFeature> r) => r.Value);
	}

	public void ResetSkillScores()
	{
		foreach (KeyValuePair<int, AISkillDynamicFeature> mapSkillFeature in MapSkillFeatures)
		{
			mapSkillFeature.Value.Score = 0f;
		}
	}
}
