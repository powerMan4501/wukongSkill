using System;
using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_AbnormalStateData : IBUC_AbnormalStateData
{
	private GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo> __AbnormalStateUIInfoDic_Raw;

	private TStrongObjectPtr<BGWDataAsset_AbnormalAttrConfig> mDefaultAbnormalAttrConfig = new TStrongObjectPtr<BGWDataAsset_AbnormalAttrConfig>();

	public int UnFreezeCount;

	public int UnFreezeCounter;

	public string UnFreezeAdditiveAMPath;

	public string UnFreezeFXPath;

	public float UnFreezeEventGap;

	public float UnFreeze_LastPlayAMTime;

	public bool bActive_AbnormalState;

	public BGWDataAsset_AbnormalAttrConfig DefaultAbnormalAttrConfig
	{
		get
		{
			return mDefaultAbnormalAttrConfig.Get();
		}
		set
		{
			mDefaultAbnormalAttrConfig.Set(value);
		}
	}

	public List<Birth_AbnormalStateImmueType> AbnormalStateImmueList { get; set; }

	public List<Birth_AbnomalState> BirthAbnormalStateList { get; set; }

	public bool IsInFrozen { get; set; }

	public bool FrozenBreakProtect { get; set; }

	public float CurrentFrozenBrokenAccHP { get; set; }

	public int TriggerSkillEffectID_WhenFrozenBroken { get; set; }

	public uint PauseAnimsHandleID { get; set; }

	public uint EnableIKHandleID { get; set; }

	public Dictionary<EAbnormalStateType, bool> AbnormalUIVisibleList { get; set; }

	[NeedToUI]
	public GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo> AbnormalStateUIInfoDic { get; set; }

	public event Action<GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo>, GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo>> OnAbnormalStateUIInfoDicChg;

	private void OnAbnormalStateUIInfoDicChg_Invoke(GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo> OldValue, GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo> NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnAbnormalStateUIInfoDicChg?.Invoke(OldValue, NewValue);
		}
	}

	public BUC_AbnormalStateData()
	{
		AbnormalUIVisibleList = new Dictionary<EAbnormalStateType, bool>();
		int num = 7;
		for (int i = 1; i < num; i++)
		{
			AbnormalUIVisibleList[(EAbnormalStateType)i] = true;
		}
		AbnormalStateUIInfoDic = new GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo>();
	}

	public bool bNeedShowAbnormalAccUI(EAbnormalStateType Type)
	{
		return AbnormalUIVisibleList[Type];
	}
}
