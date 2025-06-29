using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SkillMappingData : IBUC_SkillMappingData, IPersistentECSData
{
	private List<SkillMappingInstData> SkillMappingInstsList = new List<SkillMappingInstData>();

	public Dictionary<ESkillMappingConditionType, bool> IgnoredMappingTypeMap { get; set; } = new Dictionary<ESkillMappingConditionType, bool>();

	public void UpdateInstsList(int MainSkillID)
	{
		foreach (SkillMappingInstData skillMappingInsts in SkillMappingInstsList)
		{
			if (skillMappingInsts._mainSkillID == MainSkillID)
			{
				return;
			}
		}
		SkillMappingInstsList.Add(new SkillMappingInstData
		{
			_mainSkillID = MainSkillID,
			_curResultSkillID = -1,
			_curResultMontage = ""
		});
	}

	public void SetResultSkillIDAndMontagePath(int MainSkillID, int ResultID, string ResultPath)
	{
		foreach (SkillMappingInstData skillMappingInsts in SkillMappingInstsList)
		{
			if (MainSkillID == skillMappingInsts._mainSkillID)
			{
				skillMappingInsts._curResultSkillID = ResultID;
				skillMappingInsts._curResultMontage = ResultPath;
				break;
			}
		}
	}

	public int GetCurResultSkillID(int MainSkillID)
	{
		foreach (SkillMappingInstData skillMappingInsts in SkillMappingInstsList)
		{
			if (skillMappingInsts._mainSkillID == MainSkillID)
			{
				return skillMappingInsts._curResultSkillID;
			}
		}
		return MainSkillID;
	}

	public string GetCurResultMontagePath(int MainSkillID)
	{
		foreach (SkillMappingInstData skillMappingInsts in SkillMappingInstsList)
		{
			if (skillMappingInsts._mainSkillID == MainSkillID)
			{
				return skillMappingInsts._curResultMontage;
			}
		}
		return "";
	}

	public FName GetCurResultSectionName(int MainSkillID, FName MontageStartSectionName)
	{
		foreach (SkillMappingInstData skillMappingInsts in SkillMappingInstsList)
		{
			if (skillMappingInsts._mainSkillID == MainSkillID)
			{
				if (string.IsNullOrEmpty(skillMappingInsts._curResultSectionName))
				{
					return MontageStartSectionName;
				}
				return new FName(skillMappingInsts._curResultSectionName);
			}
		}
		return MontageStartSectionName;
	}
}
