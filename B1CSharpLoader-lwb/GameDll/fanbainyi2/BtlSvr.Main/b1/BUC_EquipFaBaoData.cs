using System;
using System.Collections.Generic;
using System.Linq;
using b1.ECS;
using GUR.Runtime;
using ResB1;

namespace b1;

public class BUC_EquipFaBaoData : IBUC_EquipFaBaoData, IPersistentECSData
{
	private EFaBaoState __FaBaoState_Raw;

	private bool __bSatisfiedHasBuffCondition_Raw;

	public int CurrentFaBaoID;

	public int FaBaoSkillID;

	public List<int> HasBuffList = new List<int>();

	public List<int> FaBaoCastBuffIDs = new List<int>();

	public List<int> FaBaoCarryBuffIDs = new List<int>();

	public bool bIsFaBaoCarryBuffEnableWhenCasting;

	[NeedToUI]
	public EFaBaoState FaBaoState
	{
		get
		{
			return __FaBaoState_Raw;
		}
		set
		{
			EFaBaoState _FaBaoState_Raw = __FaBaoState_Raw;
			__FaBaoState_Raw = value;
			OnFaBaoStateChg_Invoke(_FaBaoState_Raw, value);
		}
	}

	[NeedToUI]
	public bool bSatisfiedHasBuffCondition
	{
		get
		{
			return __bSatisfiedHasBuffCondition_Raw;
		}
		set
		{
			bool _bSatisfiedHasBuffCondition_Raw = __bSatisfiedHasBuffCondition_Raw;
			__bSatisfiedHasBuffCondition_Raw = value;
			OnbSatisfiedHasBuffConditionChg_Invoke(_bSatisfiedHasBuffCondition_Raw, value);
		}
	}

	public float FaBaoCastDuration { get; set; }

	public float FaBaoCoolDownPercentage { get; set; }

	public float CurrentCastDuration { get; set; }

	public event Action<EFaBaoState, EFaBaoState> OnFaBaoStateChg;

	public event Action<bool, bool> OnbSatisfiedHasBuffConditionChg;

	private void OnFaBaoStateChg_Invoke(EFaBaoState OldValue, EFaBaoState NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnFaBaoStateChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnbSatisfiedHasBuffConditionChg_Invoke(bool OldValue, bool NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnbSatisfiedHasBuffConditionChg?.Invoke(OldValue, NewValue);
		}
	}

	public int GetEquippedFaBaoID()
	{
		return CurrentFaBaoID;
	}

	public void Clear()
	{
		CurrentFaBaoID = -1;
		FaBaoSkillID = -1;
		HasBuffList?.Clear();
		bSatisfiedHasBuffCondition = false;
		FaBaoCastDuration = -1f;
		FaBaoCoolDownPercentage = -1f;
		FaBaoCastBuffIDs?.Clear();
		FaBaoCarryBuffIDs?.Clear();
		bIsFaBaoCarryBuffEnableWhenCasting = false;
		FaBaoState = EFaBaoState.Carry;
		CurrentCastDuration = -1f;
	}

	public void Equip(EquipFaBaoAttrDesc FaBaoInfo)
	{
		CurrentFaBaoID = FaBaoInfo.Id;
		FaBaoSkillID = FaBaoInfo.CastSkillId;
		string[] array = FaBaoInfo.HasBuff.Split(',');
		for (int i = 0; i < array.Length; i++)
		{
			if (int.TryParse(array[i], out var result))
			{
				HasBuffList.Add(result);
			}
		}
		bSatisfiedHasBuffCondition = false;
		FaBaoCastDuration = FaBaoInfo.Duration;
		FaBaoCoolDownPercentage = 0f;
		FaBaoCastBuffIDs = FaBaoInfo.CastBuffId.ToList();
		FaBaoCarryBuffIDs = FaBaoInfo.CarryBuffId.ToList();
		bIsFaBaoCarryBuffEnableWhenCasting = FaBaoInfo.CarryBuffActiveWhenCasting == YesNoType.Yes;
	}

	public bool GetCanCastFaBaoSkill()
	{
		return bSatisfiedHasBuffCondition;
	}
}
