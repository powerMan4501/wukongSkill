using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ArmorData : IBUC_ArmorData, IPersistentECSData
{
	public bool Armor_Enable;

	private FGSArmorSettingInBP DefaultArmorSetting;

	public bool IsGetTopRandomSkill;

	public int TopRandomSkillPercent;

	private List<int> Armor_SkillID;

	public float Armor_Timer;

	public float Armor_LastTriggerTime;

	public int Armor_BeAttackedNum;

	public int Armor_BeAttackedCnt;

	public EFightBackCountType Armor_BeAttackedCntType;

	public int OriBeHitNum_Min;

	public int OriBeHitNum_Max;

	public List<FGSArmorCounterWithBlood> CounterWithBloodConfig;

	public bool PreHRCounterattacking;

	public bool PreHRCounterattackingUsingSuperArmor;

	private TStrongObjectPtr<BGWDataAsset_BlockInfoConfig> mDefaultBlockInfoConfig = new TStrongObjectPtr<BGWDataAsset_BlockInfoConfig>();

	private TStrongObjectPtr<BGWDataAsset_BlockInfoConfig> mNowUseBlockInfoConfig = new TStrongObjectPtr<BGWDataAsset_BlockInfoConfig>();

	public int NowBlockTimes;

	public int SequenceCounter;

	public int NowUseBlockInfoIdx;

	public int PreUseBlockInfoIdx;

	public float BlockCoolDownTimer;

	public float ResetBlockCounterTimer;

	public bool HasBeginBlock;

	public float RemoveBRKBlockCollapseArmorStateTimer;

	public float RemoveBRKBlockArmor2WeakStateTimer;

	public int MaxBlockTimes;

	private int PerfectBlockTriggerTimes;

	public float BlockCoolDownTime;

	public float ResetBlockCounterTime;

	public List<int> CacheTriggerBuffList;

	public int TriggerBlockHitLevel;

	public EAttackerArea TriggerBlockAttackerArea;

	public FBlockAMInfo TriggerBlockAMInfo;

	public bool Cache_IsUseSkill2BlockBounce;

	public int Cache_Skill2BlockBounce;

	public UAnimMontage Cache_BlockBounceAM;

	public BGWDataAsset_BlockInfoConfig DefaultBlockInfoConfig
	{
		get
		{
			return mDefaultBlockInfoConfig.Get();
		}
		set
		{
			mDefaultBlockInfoConfig.Set(value);
		}
	}

	public BGWDataAsset_BlockInfoConfig NowUseBlockInfoConfig
	{
		get
		{
			return mNowUseBlockInfoConfig.Get();
		}
		set
		{
			mNowUseBlockInfoConfig.Set(value);
		}
	}

	public FAnimNotifyTriggerList TriggerList { get; } = new FAnimNotifyTriggerList();

	public BUC_ArmorData()
	{
		DefaultArmorSetting = default(FGSArmorSettingInBP);
		Armor_SkillID = new List<int>();
		CounterWithBloodConfig = new List<FGSArmorCounterWithBlood>();
		Armor_Enable = false;
		IsGetTopRandomSkill = false;
		TopRandomSkillPercent = 0;
		Armor_Timer = 0f;
		Armor_BeAttackedNum = 0;
		Armor_LastTriggerTime = 0f;
		Armor_BeAttackedCnt = 0;
		OriBeHitNum_Min = 0;
		OriBeHitNum_Max = 0;
		PreHRCounterattacking = false;
		PreHRCounterattackingUsingSuperArmor = false;
		RemoveBRKBlockCollapseArmorStateTimer = 0f;
		RemoveBRKBlockArmor2WeakStateTimer = 0f;
		NowUseBlockInfoIdx = -1;
		PreUseBlockInfoIdx = -1;
		MaxBlockTimes = -1;
		PerfectBlockTriggerTimes = 0;
		BlockCoolDownTime = 0f;
		BlockCoolDownTimer = 0f;
		ResetBlockCounterTime = 0f;
		ResetBlockCounterTimer = 0f;
		NowBlockTimes = 0;
		HasBeginBlock = false;
		CacheTriggerBuffList = new List<int>();
		SequenceCounter = 0;
		TriggerBlockHitLevel = -1;
		TriggerBlockAttackerArea = EAttackerArea.Forward;
		TriggerBlockAMInfo = default(FBlockAMInfo);
	}

	public void SetArmorSetting(FGSArmorSettingInBP NewSetting, AActor TargetActor, bool IsSetDefault, bool IsReset)
	{
		if (IsSetDefault)
		{
			DefaultArmorSetting = NewSetting;
		}
		Armor_Enable = NewSetting.Armor_Enable;
		IsGetTopRandomSkill = NewSetting.IsGetTopRandomSkill;
		TopRandomSkillPercent = NewSetting.TopRandomSkillPercent;
		Armor_Timer = NewSetting.Armor_Timer;
		Armor_BeAttackedCntType = NewSetting.BeHitCountType;
		OriBeHitNum_Min = NewSetting.OriBeHitNum_Min;
		OriBeHitNum_Max = NewSetting.OriBeHitNum_Max;
		Armor_BeAttackedNum = UB1Util.GetRandomNumberInt(OriBeHitNum_Min, OriBeHitNum_Max);
		CounterWithBloodConfig = NewSetting.CounterWithBloodConfig;
		Armor_SkillID.Clear();
		for (int i = 0; i < NewSetting.Armor_SkillID.Count; i++)
		{
			int num = NewSetting.Armor_SkillID[i];
			if (BGW_GameDB.GetSkillSDesc(num, TargetActor) != null)
			{
				Armor_SkillID.Add(num);
			}
		}
		SetNewBlockInfoConfig(NewSetting.DefaultBlockInfoConfig, IsSetDefault);
		MaxBlockTimes = NewSetting.MaxBlockTimes;
		PerfectBlockTriggerTimes = NewSetting.PerfectBlockTimes;
		BlockCoolDownTime = NewSetting.BlockCoolDownTime;
		ResetBlockCounterTime = NewSetting.ResetBlockCounterTime;
	}

	public void ResetArmorSetting(AActor TargetActor)
	{
		SetArmorSetting(DefaultArmorSetting, TargetActor, IsSetDefault: false, IsReset: true);
	}

	public bool CanTriggerCounterFightBack()
	{
		if (Armor_Enable)
		{
			return Armor_BeAttackedCnt >= Armor_BeAttackedNum;
		}
		return false;
	}

	public bool CanTriggerAddCounterAttackTimes(EFightBackCountType BeAttackedCntType)
	{
		return BeAttackedCntType == Armor_BeAttackedCntType;
	}

	public bool IsInPreHRCounterattacking()
	{
		return PreHRCounterattacking;
	}

	public bool IsInPreHRCounterattackingSuperArmor()
	{
		return PreHRCounterattackingUsingSuperArmor;
	}

	public List<int> GetArmorSkillIDs()
	{
		return Armor_SkillID;
	}

	public void SetNewBlockInfoConfig(BGWDataAsset_BlockInfoConfig NewUseBlockInfoConfig, bool NeedUpdateDefaultValue = false)
	{
		NowUseBlockInfoConfig = NewUseBlockInfoConfig;
		if (NeedUpdateDefaultValue)
		{
			DefaultBlockInfoConfig = NewUseBlockInfoConfig;
		}
	}

	public void GetHitRecoverCounterInfo(out int CurCount, out int TotalTimes)
	{
		CurCount = Armor_BeAttackedCnt;
		TotalTimes = Armor_BeAttackedNum;
	}

	public void GetBlockCounterInfo(out int CurCount, out int PerfectBlockTime, out int TotalTimes, out float BlockCD, out float BlockResetTime)
	{
		CurCount = NowBlockTimes;
		PerfectBlockTime = PerfectBlockTriggerTimes;
		TotalTimes = MaxBlockTimes;
		BlockCD = BlockCoolDownTimer;
		BlockResetTime = ResetBlockCounterTimer;
	}

	public bool GetCurrentBlockInfoByHitLevel(int HitLevel, out FBlockInfoByHitLevel CurrentBlockInfo)
	{
		CurrentBlockInfo = default(FBlockInfoByHitLevel);
		if (NowUseBlockInfoConfig == null || NowUseBlockInfoConfig.NormalBlockInfoWarp.BlockInfoByHitLevelList == null)
		{
			return false;
		}
		if (NowUseBlockInfoConfig.NormalBlockInfoWarp.BlockInfoByHitLevelList.Count == 0)
		{
			return false;
		}
		bool flag = false;
		bool flag2 = false;
		FBlockInfoByHitLevel fBlockInfoByHitLevel = default(FBlockInfoByHitLevel);
		foreach (FBlockInfoByHitLevel blockInfoByHitLevel in NowUseBlockInfoConfig.NormalBlockInfoWarp.BlockInfoByHitLevelList)
		{
			if (blockInfoByHitLevel.HitLevel == HitLevel)
			{
				flag = true;
				CurrentBlockInfo = blockInfoByHitLevel;
				break;
			}
			if (blockInfoByHitLevel.HitLevel == -1)
			{
				flag2 = true;
				fBlockInfoByHitLevel = blockInfoByHitLevel;
			}
		}
		if (!flag && flag2)
		{
			flag = true;
			CurrentBlockInfo = fBlockInfoByHitLevel;
		}
		return flag;
	}

	public void GetCurrentBlockInfoConfig(out BGWDataAsset_BlockInfoConfig _NowUseBlockInfoConfig)
	{
		_NowUseBlockInfoConfig = NowUseBlockInfoConfig;
	}

	public bool CheckIsInPerfectBlock()
	{
		if (PerfectBlockTriggerTimes > 0 && NowBlockTimes > 0 && NowBlockTimes % PerfectBlockTriggerTimes == 0)
		{
			return true;
		}
		return false;
	}

	public bool CheckIsTriggerPerfectBlock()
	{
		if (PerfectBlockTriggerTimes > 0 && NowBlockTimes > 0 && (NowBlockTimes + 1) % PerfectBlockTriggerTimes == 0)
		{
			return true;
		}
		return false;
	}
}
