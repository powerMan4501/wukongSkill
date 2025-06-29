using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using BtlShare;
using GUR.Runtime;

namespace b1;

public class BUC_UnitBarInfoData : IBUC_UnitBarInfoData, IPersistentECSData
{
	private bool __ShieldBarActived_Raw;

	private bool __BossShieldBarActived_Raw;

	private float __ShieldBarPercent_Raw;

	private bool __BloodBarActived_Raw;

	private float __BloodBarPercent_Raw;

	public GSBindDictionary<int, BuffInstData> LocalBuffInstDic = new BindDictInt_BuffInstData();

	public EBGUBloodBarType BarType { get; set; }

	public bool ShieldShowInUI { get; set; }

	public bool IsInBattle { get; set; }

	public bool IsLocked { get; set; }

	public bool IsInLastDmgWindow { get; set; }

	public bool IsDead { get; set; }

	public bool PlayerInBossBattle { get; set; }

	public float LockDelayTime { get; set; }

	public float LastDmgDelayTime { get; set; }

	[NeedToUI]
	public bool ShieldBarActived
	{
		get
		{
			return __ShieldBarActived_Raw;
		}
		set
		{
			bool _ShieldBarActived_Raw = __ShieldBarActived_Raw;
			__ShieldBarActived_Raw = value;
			OnShieldBarActivedChg_Invoke(_ShieldBarActived_Raw, value);
		}
	}

	[NeedToUI]
	public bool BossShieldBarActived
	{
		get
		{
			return __BossShieldBarActived_Raw;
		}
		set
		{
			bool _BossShieldBarActived_Raw = __BossShieldBarActived_Raw;
			__BossShieldBarActived_Raw = value;
			OnBossShieldBarActivedChg_Invoke(_BossShieldBarActived_Raw, value);
		}
	}

	[NeedToUI]
	public float ShieldBarPercent
	{
		get
		{
			return __ShieldBarPercent_Raw;
		}
		set
		{
			float _ShieldBarPercent_Raw = __ShieldBarPercent_Raw;
			__ShieldBarPercent_Raw = value;
			OnShieldBarPercentChg_Invoke(_ShieldBarPercent_Raw, value);
		}
	}

	[NeedToUI]
	public bool BloodBarActived
	{
		get
		{
			return __BloodBarActived_Raw;
		}
		set
		{
			bool _BloodBarActived_Raw = __BloodBarActived_Raw;
			__BloodBarActived_Raw = value;
			OnBloodBarActivedChg_Invoke(_BloodBarActived_Raw, value);
		}
	}

	[NeedToUI]
	public float BloodBarPercent
	{
		get
		{
			return __BloodBarPercent_Raw;
		}
		set
		{
			float _BloodBarPercent_Raw = __BloodBarPercent_Raw;
			__BloodBarPercent_Raw = value;
			OnBloodBarPercentChg_Invoke(_BloodBarPercent_Raw, value);
		}
	}

	public bool IsBlockCollapseArmorUnit { get; set; }

	public GSBindProp<bool> BossBarAcived { get; set; } = new GSBindProp<bool>();

	public GSBindProp<bool> EliteBarActived { get; set; } = new GSBindProp<bool>();

	public List<string> ObserveBoss { get; set; } = new List<string>();

	public List<int> BuffIconList { get; set; } = new List<int>();

	public GSBindDictionary<int, List<BuffInstData>> BuffIconInfo { get; set; } = new GSBindDictionary<int, List<BuffInstData>>();

	public bool bShouldUpdateBuffTime { get; set; } = true;

	public bool BeAttackedByPlayer { get; set; }

	public float LastTimeBeAttackedByPlayer { get; set; }

	public event Action<bool, bool> OnShieldBarActivedChg;

	public event Action<bool, bool> OnBossShieldBarActivedChg;

	public event Action<float, float> OnShieldBarPercentChg;

	public event Action<bool, bool> OnBloodBarActivedChg;

	public event Action<float, float> OnBloodBarPercentChg;

	private void OnShieldBarActivedChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnShieldBarActivedChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnBossShieldBarActivedChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnBossShieldBarActivedChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnShieldBarPercentChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnShieldBarPercentChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnBloodBarActivedChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnBloodBarActivedChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnBloodBarPercentChg_Invoke(float OldValue, float NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnBloodBarPercentChg?.Invoke(OldValue, NewValue);
		}
	}

	public float GetIconDuration(int IconID)
	{
		if (BuffIconInfo.ContainsKey(IconID))
		{
			return BuffIconInfo[IconID].Max((BuffInstData Data) => Data.LeftTime);
		}
		return -1f;
	}

	public int GetIconNum(int IconID)
	{
		if (BuffIconInfo.ContainsKey(IconID))
		{
			return BuffIconInfo[IconID].Count;
		}
		return 0;
	}
}
