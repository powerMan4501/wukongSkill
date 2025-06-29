using System;
using System.Collections.Generic;
using b1.Localization;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1.UI;

public class DSHpProgBar : DSAttrProgBar
{
	protected bool UseAbnormalFx;

	protected bool IsZeroHide;

	public readonly GSBindProp<FText> Name = new GSBindProp<FText>();

	public readonly GSBindProp<BGUCharacterCS> CharacterActor = new GSBindProp<BGUCharacterCS>();

	public readonly GSBindProp<DS_IBUC_UnitBarInfoData> UnitBarInfoData = new GSBindProp<DS_IBUC_UnitBarInfoData>();

	public readonly GSBindProp<DS_IBUC_AbnormalStateData> AbnormalStateData = new GSBindProp<DS_IBUC_AbnormalStateData>();

	public readonly GSBindProp<EAbnormalStateType> CurAbnormalStateType = new GSBindProp<EAbnormalStateType>();

	public readonly List<EAbnormalStateType> AbnormalStack = new List<EAbnormalStateType>();

	public readonly Dictionary<EAbnormalStateType, bool> NeedShowDic = new Dictionary<EAbnormalStateType, bool>();

	private Dictionary<EAbnormalStateType, Action> ReleaseActionMap = new Dictionary<EAbnormalStateType, Action>();

	private int AddIdx;

	private int RemoveIdx;

	public DSHpProgBar(BUI_Widget BindWidget, bool InUseAbnormalFx = false, bool InIsZeroHide = false)
		: base(BindWidget, EBGUAttrFloat.Hp, EBGUAttrFloat.HpMax)
	{
		UseAbnormalFx = InUseAbnormalFx;
		IsZeroHide = InIsZeroHide;
		GSBindProp<float> percent = Percent;
		percent.OnValueChanged = (GSBindProp<float>.ValueChangedHandler)Delegate.Combine(percent.OnValueChanged, (GSBindProp<float>.ValueChangedHandler)delegate
		{
			UpdateIsShow();
		});
		GSBindProp<DS_IBUC_AttrContainer> curAttrContainer = CurAttrContainer;
		curAttrContainer.OnValueChanged = (GSBindProp<DS_IBUC_AttrContainer>.ValueChangedHandler)Delegate.Combine(curAttrContainer.OnValueChanged, (GSBindProp<DS_IBUC_AttrContainer>.ValueChangedHandler)delegate
		{
			UpdateIsShow();
		});
		GSBindProp<DS_IBUC_AbnormalStateData> abnormalStateData = AbnormalStateData;
		abnormalStateData.OnValueChanged = (GSBindProp<DS_IBUC_AbnormalStateData>.ValueChangedHandler)Delegate.Combine(abnormalStateData.OnValueChanged, (GSBindProp<DS_IBUC_AbnormalStateData>.ValueChangedHandler)delegate(EChangeReason Reason, DS_IBUC_AbnormalStateData OldValue, DS_IBUC_AbnormalStateData NewValue)
		{
			if (OldValue != null)
			{
				if (OldValue.AbnormalStateUIInfoDic != null)
				{
					foreach (KeyValuePair<EAbnormalStateType, FAbnormalStateUIInfo> item in OldValue.AbnormalStateUIInfoDic)
					{
						OnAbnormalStateDicRemove(item.Key, item.Value);
					}
				}
				OldValue.UnBindAbnormalStateUIInfoDicAdd(AddIdx, OnAbnormalStateDicAdd);
				OldValue.UnBindAbnormalStateUIInfoDicRemove(RemoveIdx, OnAbnormalStateDicRemove);
			}
			if (NewValue != null)
			{
				AddIdx = NewValue.BindAbnormalStateUIInfoDicAdd(OnAbnormalStateDicAdd);
				RemoveIdx = NewValue.BindAbnormalStateUIInfoDicRemove(OnAbnormalStateDicRemove);
				if (NewValue.AbnormalStateUIInfoDic != null)
				{
					foreach (KeyValuePair<EAbnormalStateType, FAbnormalStateUIInfo> item2 in NewValue.AbnormalStateUIInfoDic)
					{
						OnAbnormalStateDicAdd(item2.Key, item2.Value);
					}
				}
				UpdateAbnormalState();
			}
		});
		UpdateIsShow();
		BindValueToCustom(CharacterActor, OnChangeCharacterActor);
	}

	public override void Init(B1ActorTag InBindTag)
	{
		base.Init(InBindTag);
		if (UseAbnormalFx)
		{
			DS_IBUC_AbnormalStateData battleData = B1GSUIActorMgr.Get(GetWorldContext()).GetBattleData<DS_IBUC_AbnormalStateData>(InBindTag);
			AbnormalStateData.SetValue(EChangeReason.Init, battleData);
		}
	}

	public void Init(BGUCharacterCS CharacterActor)
	{
		SetCharacterActor(CharacterActor);
	}

	public override void Clear()
	{
		base.Clear();
		SetUnitBarInfoData(null);
		SetAbnormalStateData(null);
		SetCharacterActor(null);
	}

	private void OnChangeCharacterActor(EChangeReason Reason, BGUCharacterCS OldValue, BGUCharacterCS NewValue)
	{
		if (!(NewValue == null))
		{
			DS_IBUC_AttrContainer battleDataByActor = B1GSUIActorMgr.Get(GetWorldContext()).GetBattleDataByActor<DS_IBUC_AttrContainer>(NewValue);
			SetCurAttrContainer(battleDataByActor);
			DS_IBUC_UnitBarInfoData battleDataByActor2 = B1GSUIActorMgr.Get(GetWorldContext()).GetBattleDataByActor<DS_IBUC_UnitBarInfoData>(NewValue);
			SetUnitBarInfoData(battleDataByActor2);
			if (UseAbnormalFx)
			{
				DS_IBUC_AbnormalStateData battleDataByActor3 = B1GSUIActorMgr.Get(GetWorldContext()).GetBattleDataByActor<DS_IBUC_AbnormalStateData>(NewValue);
				AbnormalStateData.SetValue(EChangeReason.Init, battleDataByActor3);
			}
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BGU_DataUtil.GetFinalBattleInfoExtendID(NewValue));
			if (unitBattleInfoExtendDesc != null)
			{
				FText name = unitBattleInfoExtendDesc.UnitName.ToFText();
				SetName(name);
			}
		}
	}

	private void OnAbnormalStateDicAdd(EAbnormalStateType Key, FAbnormalStateUIInfo Value)
	{
		GSBindProp<bool> bIsInFinalState = Value.bIsInFinalState;
		bIsInFinalState.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(bIsInFinalState.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnbIsFinalStateChange));
		if (ReleaseActionMap.ContainsKey(Key))
		{
			ReleaseActionMap[Key]?.Invoke();
		}
		ReleaseActionMap[Key] = delegate
		{
			AbnormalStack.Remove(Key);
			GSBindProp<bool> bIsInFinalState2 = Value.bIsInFinalState;
			bIsInFinalState2.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Remove(bIsInFinalState2.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnbIsFinalStateChange));
		};
		UpdateAbnormalState();
		void OnbIsFinalStateChange(EChangeReason Reason, bool OldValue, bool NewValue)
		{
			if (NewValue)
			{
				AbnormalStack.Add(Key);
			}
			else
			{
				AbnormalStack.Remove(Key);
			}
			UpdateAbnormalState();
		}
	}

	private void OnAbnormalStateDicRemove(EAbnormalStateType Key, FAbnormalStateUIInfo Value)
	{
		if (ReleaseActionMap.ContainsKey(Key))
		{
			ReleaseActionMap[Key]();
			ReleaseActionMap[Key] = null;
		}
		UpdateAbnormalState();
	}

	public void UpdateAbnormalState()
	{
		EAbnormalStateType curAbnormalStateType = EAbnormalStateType.None;
		for (int num = AbnormalStack.Count - 1; num >= 0; num--)
		{
			EAbnormalStateType eAbnormalStateType = AbnormalStack[num];
			if (NeedShowDic.ContainsKey(eAbnormalStateType))
			{
				curAbnormalStateType = eAbnormalStateType;
				break;
			}
		}
		SetCurAbnormalStateType(curAbnormalStateType);
	}

	public override void UpdateIsShow()
	{
		bool flag = CanShow.Value;
		if (CurAttrContainer.Value != null)
		{
			if (CurAttrContainer.Value.GetFloatValue(EBGUAttrFloat.Hp) <= 0f && IsZeroHide)
			{
				flag = false;
			}
		}
		else
		{
			flag &= !IsZeroHide;
		}
		IsShow.SetValue(EChangeReason.ManualSet, flag);
	}

	public void SetCurAbnormalStateType(EAbnormalStateType InCurAbnormalStateType)
	{
		CurAbnormalStateType.SetValue(EChangeReason.ManualSet, InCurAbnormalStateType);
	}

	public void SetNeedShowAbnormalState(EAbnormalStateType InAbnormalStateType)
	{
		NeedShowDic.Add(InAbnormalStateType, value: true);
	}

	public void SetCharacterActor(BGUCharacterCS InCharacterActor)
	{
		CharacterActor.SetValue(EChangeReason.ManualSet, InCharacterActor);
	}

	public void SetUnitBarInfoData(DS_IBUC_UnitBarInfoData InUnitBarInfoData)
	{
		UnitBarInfoData.SetValue(EChangeReason.ManualSet, InUnitBarInfoData);
	}

	public void SetAbnormalStateData(DS_IBUC_AbnormalStateData InAbnormalStateData)
	{
		AbnormalStateData.SetValue(EChangeReason.ManualSet, InAbnormalStateData);
	}

	public void SetName(FText InName)
	{
		Name.SetValue(EChangeReason.ManualSet, InName);
	}

	protected override void OnDestructImpl()
	{
		foreach (Action value in ReleaseActionMap.Values)
		{
			value?.Invoke();
		}
		ReleaseActionMap.Clear();
		Clear();
		base.OnDestructImpl();
	}
}
