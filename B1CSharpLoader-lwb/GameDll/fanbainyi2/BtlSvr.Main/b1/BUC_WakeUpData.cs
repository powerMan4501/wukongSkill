using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;

namespace b1;

public class BUC_WakeUpData : IBUC_WakeUpData, ICloneable, IPersistentECSData
{
	public bool bNotFirstTimeWakeUp { get; set; }

	public bool bJustUseOnFightSkillFirstTime { get; set; }

	public bool DisabledWakeUp { get; set; }

	public int OnFightSkillID { get; set; }

	public int OnFightSkillIDBack { get; set; }

	public int OnFightSkillIDLeft { get; set; }

	public int OnFightSkillIDRight { get; set; }

	public int NPCAnimOverrideOnFightSkillID { get; set; }

	public int NPCAnimOverrideOnFightSkillIDBack { get; set; }

	public int NPCAnimOverrideOnFightSkillIDLeft { get; set; }

	public int NPCAnimOverrideOnFightSkillIDRight { get; set; }

	public int AfterSequenceOverrideOnFightSkillID { get; set; }

	public int AfterSequenceOverrideOnFightSkillIDBack { get; set; }

	public int AfterSequenceOverrideOnFightSkillIDLeft { get; set; }

	public int AfterSequenceOverrideOnFightSkillIDRight { get; set; }

	public List<int> SurpriseSkillID { get; set; }

	public bool CanCastSurpriseSkill { get; set; }

	public bool WakeUpLinkEnable { get; set; }

	public bool CanTriggerWakeUpLinkWhenDead { get; set; }

	public bool HasTriggerWakeUp { get; set; }

	public bool UseManualSelect { get; set; }

	public List<string> ManualTargetGuidList { get; set; } = new List<string>();

	public bool UseRangeSelect { get; set; }

	public ERangeType RangeType { get; set; }

	public float RangeParam_1 { get; set; }

	public float RangeParam_2 { get; set; }

	public float RangeParam_3 { get; set; }

	public List<int> ResIDList { get; set; }

	public bool bSelectUnitHasTarget { get; set; }

	public bool bSelectPassiveUnit { get; set; }

	public object Clone()
	{
		return new BUC_WakeUpData
		{
			DisabledWakeUp = DisabledWakeUp,
			OnFightSkillID = OnFightSkillID,
			OnFightSkillIDBack = OnFightSkillID,
			OnFightSkillIDLeft = OnFightSkillIDLeft,
			OnFightSkillIDRight = OnFightSkillIDRight,
			bJustUseOnFightSkillFirstTime = bJustUseOnFightSkillFirstTime,
			SurpriseSkillID = SurpriseSkillID,
			WakeUpLinkEnable = WakeUpLinkEnable,
			CanTriggerWakeUpLinkWhenDead = CanTriggerWakeUpLinkWhenDead,
			UseManualSelect = UseManualSelect,
			ManualTargetGuidList = ManualTargetGuidList,
			UseRangeSelect = UseRangeSelect,
			RangeType = RangeType,
			RangeParam_1 = RangeParam_1,
			RangeParam_2 = RangeParam_2,
			RangeParam_3 = RangeParam_3,
			ResIDList = ResIDList,
			bSelectUnitHasTarget = bSelectUnitHasTarget,
			bSelectPassiveUnit = bSelectPassiveUnit
		};
	}
}
