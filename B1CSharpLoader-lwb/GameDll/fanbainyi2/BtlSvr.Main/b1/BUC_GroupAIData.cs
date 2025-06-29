using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_GroupAIData : IBUC_GroupAIData, IPersistentECSData
{
	public bool IsCtrlByGroupAI;

	public bool IsInAction;

	public bool IsInPriorityAction;

	public bool IsFirstTimeReceiveATKToken;

	public bool IsFirstTimeReceiveToken;

	public bool IsFirstTimeLostToken;

	public bool CanBeInterrupted;

	public Dictionary<EAINodeActionType, bool> IsAIActionFinishDict = new Dictionary<EAINodeActionType, bool>();

	public List<int> GroupAISkillListForMeleeAttack = new List<int>();

	public List<int> GroupAISkillListForRangeAttack = new List<int>();

	public HotZonePointInfo CacheHZPI = HotZonePointInfo.Null;

	public EGroupAITROCullType GroupAITROCullType { get; set; }

	public bool IsForceDisableGroupAI { get; set; }

	public bool IsBossUnit { get; set; }

	public bool OnlyUseOnceOnFightSkill { get; set; }

	public List<int> GroupAIOnFightSkillList { get; set; }

	public bool OnlyTriggerOnceAddBuffWhenReceiveToken { get; set; }

	public List<int> BuffListWhenReceiveToken { get; set; }

	public bool OnlyTriggerOnceAddBuffWhenLostToken { get; set; }

	public List<int> BuffListWhenLostToken { get; set; }

	public bool GetIsCtrlByGroupAI()
	{
		return IsCtrlByGroupAI;
	}

	public bool GetIsInAction()
	{
		return IsInAction;
	}

	public bool GetIsInPriorityAction()
	{
		return IsInPriorityAction;
	}

	public bool CanReceiveAttackAction()
	{
		if (!IsInAction && !IsInPriorityAction)
		{
			return true;
		}
		return CanBeInterrupted;
	}

	public void Init()
	{
		IsCtrlByGroupAI = false;
		IsInAction = false;
		IsInPriorityAction = false;
		IsFirstTimeReceiveATKToken = false;
		IsFirstTimeReceiveToken = false;
		IsFirstTimeLostToken = false;
		CanBeInterrupted = false;
		IsAIActionFinishDict = new Dictionary<EAINodeActionType, bool>
		{
			{
				EAINodeActionType.MoveTo,
				false
			},
			{
				EAINodeActionType.EQSRun,
				false
			},
			{
				EAINodeActionType.Combo,
				false
			}
		};
	}

	public void SetGroupAIBPConfig(FGroupAIBPConfig GroupAIBPConfig)
	{
		IsForceDisableGroupAI = GroupAIBPConfig.IsForceDisableGroupAI;
		IsBossUnit = GroupAIBPConfig.IsBossUnit;
		OnlyUseOnceOnFightSkill = GroupAIBPConfig.OnlyUseOnceOnFightSkill;
		GroupAIOnFightSkillList = GroupAIBPConfig.GroupAIOnFightSkillList;
		OnlyTriggerOnceAddBuffWhenReceiveToken = GroupAIBPConfig.OnlyTriggerOnceAddBuffWhenReceiveToken;
		BuffListWhenReceiveToken = GroupAIBPConfig.BuffListWhenReceiveToken;
		OnlyTriggerOnceAddBuffWhenLostToken = GroupAIBPConfig.OnlyTriggerOnceAddBuffWhenLostToken;
		BuffListWhenLostToken = GroupAIBPConfig.BuffListWhenLostToken;
	}

	public void GetCanCastSkillInfoNum(out int MeleeAtkSkillNum, out int RangeAtkSkillNum)
	{
		MeleeAtkSkillNum = GroupAISkillListForMeleeAttack.Count;
		RangeAtkSkillNum = GroupAISkillListForRangeAttack.Count;
	}

	public bool GetGroupAIHotZonePointPos(out FVector2D HotZonePointPos)
	{
		HotZonePointPos = CacheHZPI.RelativePos;
		return CacheHZPI.HotZoneIdx > EGroupAIHotZoneType.None;
	}

	public bool GetGroupAIHotZonePointInfo(out HotZonePointInfo HPI)
	{
		HPI = CacheHZPI;
		return CacheHZPI.HotZoneIdx > EGroupAIHotZoneType.None;
	}
}
