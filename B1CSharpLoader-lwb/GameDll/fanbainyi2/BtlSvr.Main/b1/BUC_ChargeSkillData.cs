using System;
using System.Collections.Generic;
using b1.ECS;
using BtlShare;
using GUR.Runtime;
using GurGsReplicate;

namespace b1;

public class BUC_ChargeSkillData : IBUC_ChargeSkillData, IPersistentECSData
{
	private int __LocalRepVersion = -1;

	private int __LocalOldRepVersion = -1;

	private bool _RepActive;

	protected int[] __GlobalRepVersionMap = new int[64];

	protected int[] __LocalRepVersionMap = new int[64];

	public ChargeSkillData[] _RepData = new ChargeSkillData[64];

	private int __CurChargeLevel_Raw;

	public int CurMaxLevel;

	public FChargeLevelConfig CurChargeLevelConfig;

	public float IntoNextCLevelRemaining;

	public bool NeedAddChargeLevelBuffWithinLoop;

	public bool HasChargeLevelBuffWithinLoop;

	public int CurrentBeginChargeSkillID { get; set; }

	public int CurrentBeginChargeSkillOriginSkillID { get; set; }

	public int CurrentChargeSkillID { get; set; }

	public float ChargeTimer { get; set; }

	public int BeAttackedTriggerForceAttackCnt { get; set; }

	public EChargeSkillStage ChargeSkillStage { get; set; }

	public bool IsCastingChargeSkill { get; set; }

	public bool NeedTriggerNextStage { get; set; }

	public bool NeedCancel { get; set; }

	public List<ChargeSkillBuffInfo> BuffInfoList { get; set; }

	public ChargeSkillSuperArmorInfo SuperArmorInfo { get; set; }

	[GSReplicated]
	public int CurChargeLevel
	{
		get
		{
			return __CurChargeLevel_Raw;
		}
		set
		{
			int _CurChargeLevel_Raw = __CurChargeLevel_Raw;
			__CurChargeLevel_Raw = value;
			OnCurChargeLevelChg_Invoke(_CurChargeLevel_Raw, value);
		}
	}

	public event Action<int, int> OnCurChargeLevelChg;

	public void _SetRepActive(bool IsActive)
	{
		if (_RepActive != IsActive)
		{
			_RepActive = IsActive;
			RefreshGetDeltaDataFunc(IsActive);
		}
	}

	private void RefreshGetDeltaDataFunc(bool IsActive)
	{
	}

	public ChargeSkillData GetOrAllocRepData()
	{
		bool flag = false;
		if (__LocalRepVersion < 0 || (__LocalOldRepVersion >= __LocalRepVersion && __LocalOldRepVersion >= 0))
		{
			__LocalRepVersion = __LocalOldRepVersion + 1;
			__GlobalRepVersionMap[__LocalRepVersion % 64] = BGWGameInstanceCS.AllocGlobalReplicateVersion();
			flag = true;
		}
		ChargeSkillData chargeSkillData = _RepData[__LocalRepVersion % 64];
		if (chargeSkillData == null)
		{
			chargeSkillData = new ChargeSkillData();
			_RepData[__LocalRepVersion % 64] = chargeSkillData;
		}
		else if (flag)
		{
			chargeSkillData.ClearCurChargeLevel();
		}
		return chargeSkillData;
	}

	public ChargeSkillData GetRepDataForNetRep(IntPtr ConnectionPtr, int OldGlobalVersion)
	{
		if (__LocalOldRepVersion < __LocalRepVersion)
		{
			__LocalOldRepVersion = __LocalRepVersion;
		}
		if (__LocalRepVersion < 0 || OldGlobalVersion > __GlobalRepVersionMap[__LocalRepVersion % 64])
		{
			return null;
		}
		ChargeSkillData chargeSkillData = new ChargeSkillData();
		int num = Math.Max(__LocalRepVersion - 64 + 1, 0);
		if (__GlobalRepVersionMap[num % 64] > OldGlobalVersion)
		{
			if (OldGlobalVersion > 0)
			{
				BGW_LogUtil.LogError($"ChargeSkillData Cache OverFlow On Replicate Full Data {OldGlobalVersion}");
			}
			chargeSkillData.CurChargeLevel = CurChargeLevel;
		}
		else
		{
			for (int i = num; i <= __LocalRepVersion; i++)
			{
				if (__GlobalRepVersionMap[i % 64] > OldGlobalVersion)
				{
					ChargeSkillData other = _RepData[i % 64];
					chargeSkillData.MergeFrom(other);
				}
			}
		}
		return chargeSkillData;
	}

	private void OnCurChargeLevelChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			if (_RepActive)
			{
				GetOrAllocRepData().CurChargeLevel = NewValue;
			}
			this.OnCurChargeLevelChg?.Invoke(OldValue, NewValue);
		}
	}

	public BUC_ChargeSkillData()
	{
		CurMaxLevel = 0;
		CurChargeLevel = -1;
		CurChargeLevelConfig = default(FChargeLevelConfig);
		CurChargeLevelConfig.InfoList = new List<FChargeLevelUnitInfo>();
		IntoNextCLevelRemaining = -1f;
		NeedAddChargeLevelBuffWithinLoop = false;
	}
}
