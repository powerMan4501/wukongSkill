using System;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BPC_PlayerAttrData : IBPC_PlayerAttrData, IPersistentECSData
{
	private float __PlayerLifeSavingCoolDownRemainTime_Raw;

	private BindListPlayerPersistentAttr __PlayerPersistentAttr_Raw;

	private BindListPlayerMagicSkillCd __PlayerMagicSkillCd_Raw;

	private BindDictString_Int __KeyMonsterMeetCount_Raw;

	private BindDictString_Int __KeyMonsterBattlePlayerDieTimes_Raw;

	[GSPersistent]
	public float PlayerLifeSavingCoolDownRemainTime
	{
		get
		{
			return __PlayerLifeSavingCoolDownRemainTime_Raw;
		}
		set
		{
			float _PlayerLifeSavingCoolDownRemainTime_Raw = __PlayerLifeSavingCoolDownRemainTime_Raw;
			__PlayerLifeSavingCoolDownRemainTime_Raw = value;
			OnPlayerLifeSavingCoolDownRemainTimeChg_Invoke(_PlayerLifeSavingCoolDownRemainTime_Raw, value);
		}
	}

	[GSPersistent]
	public BindListPlayerPersistentAttr PlayerPersistentAttr
	{
		get
		{
			return __PlayerPersistentAttr_Raw;
		}
		set
		{
			BindListPlayerPersistentAttr _PlayerPersistentAttr_Raw = __PlayerPersistentAttr_Raw;
			__PlayerPersistentAttr_Raw = value;
			OnPlayerPersistentAttrChg_Invoke(_PlayerPersistentAttr_Raw, value);
		}
	}

	[GSPersistent]
	public BindListPlayerMagicSkillCd PlayerMagicSkillCd
	{
		get
		{
			return __PlayerMagicSkillCd_Raw;
		}
		set
		{
			BindListPlayerMagicSkillCd _PlayerMagicSkillCd_Raw = __PlayerMagicSkillCd_Raw;
			__PlayerMagicSkillCd_Raw = value;
			OnPlayerMagicSkillCdChg_Invoke(_PlayerMagicSkillCd_Raw, value);
		}
	}

	[GSPersistent]
	public BindDictString_Int KeyMonsterMeetCount
	{
		get
		{
			return __KeyMonsterMeetCount_Raw;
		}
		set
		{
			BindDictString_Int _KeyMonsterMeetCount_Raw = __KeyMonsterMeetCount_Raw;
			__KeyMonsterMeetCount_Raw = value;
			OnKeyMonsterMeetCountChg_Invoke(_KeyMonsterMeetCount_Raw, value);
		}
	}

	[GSPersistent]
	public BindDictString_Int KeyMonsterBattlePlayerDieTimes
	{
		get
		{
			return __KeyMonsterBattlePlayerDieTimes_Raw;
		}
		set
		{
			BindDictString_Int _KeyMonsterBattlePlayerDieTimes_Raw = __KeyMonsterBattlePlayerDieTimes_Raw;
			__KeyMonsterBattlePlayerDieTimes_Raw = value;
			OnKeyMonsterBattlePlayerDieTimesChg_Invoke(_KeyMonsterBattlePlayerDieTimes_Raw, value);
		}
	}

	public float HpPercentTransTmp { get; set; }

	public float MpPercentTransTmp { get; set; }

	public event Action<float, float> OnPlayerLifeSavingCoolDownRemainTimeChg;

	public event Action<BindListPlayerPersistentAttr, BindListPlayerPersistentAttr> OnPlayerPersistentAttrChg;

	public event Action<BindListPlayerMagicSkillCd, BindListPlayerMagicSkillCd> OnPlayerMagicSkillCdChg;

	public event Action<BindDictString_Int, BindDictString_Int> OnKeyMonsterMeetCountChg;

	public event Action<BindDictString_Int, BindDictString_Int> OnKeyMonsterBattlePlayerDieTimesChg;

	private void OnPlayerLifeSavingCoolDownRemainTimeChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPlayerLifeSavingCoolDownRemainTimeChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnPlayerPersistentAttrChg_Invoke(BindListPlayerPersistentAttr OldValue, BindListPlayerPersistentAttr NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnPlayerPersistentAttrChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnPlayerMagicSkillCdChg_Invoke(BindListPlayerMagicSkillCd OldValue, BindListPlayerMagicSkillCd NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnPlayerMagicSkillCdChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnKeyMonsterMeetCountChg_Invoke(BindDictString_Int OldValue, BindDictString_Int NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnKeyMonsterMeetCountChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnKeyMonsterBattlePlayerDieTimesChg_Invoke(BindDictString_Int OldValue, BindDictString_Int NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnKeyMonsterBattlePlayerDieTimesChg?.Invoke(OldValue, NewValue);
		}
	}

	public BPC_PlayerAttrData()
	{
		PlayerPersistentAttr = new BindListPlayerPersistentAttr();
		PlayerMagicSkillCd = new BindListPlayerMagicSkillCd();
		KeyMonsterMeetCount = new BindDictString_Int();
		KeyMonsterBattlePlayerDieTimes = new BindDictString_Int();
	}
}
