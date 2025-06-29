using System;
using b1.GSMUI;
using b1.GSMUI.Core;
using B1UI.GSUI;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI.Comm;

public class MDSInteractIcon : IGSMUIDestruct, IProjInfo
{
	public readonly GSBindProp<AActor> BindActor = new GSBindProp<AActor>();

	public readonly GSBindProp<EInteractType> InteractType = new GSBindProp<EInteractType>();

	public readonly GSBindProp<DS_IBUC_InteractData> InteractData = new GSBindProp<DS_IBUC_InteractData>();

	public readonly GSBindProp<GSUIActorMgr.EvtClass> ActorEvt = new GSBindProp<GSUIActorMgr.EvtClass>();

	public readonly GSBindProp<string> InteractTips = new GSBindProp<string>();

	public readonly GSBindProp<EInteractUIState> InteractUIState = new GSBindProp<EInteractUIState>();

	public readonly GSBindProp<bool> IsInInteractAction = new GSBindProp<bool>();

	public readonly GSBindProp<float> InteractTime = new GSBindProp<float>();

	public readonly GSBindProp<bool> IsSpecial = new GSBindProp<bool>();

	public readonly GSBindProp<bool> IsShowSpecial = new GSBindProp<bool>();

	private Action OnDestruct;

	private int TipBindIdx;

	private int UIStateBindIdx;

	private int InputTimeBindIdx;

	public MDSInteractIcon(AActor InBindActor, EInteractType InInteractType)
	{
		GSBindProp<DS_IBUC_InteractData> interactData = InteractData;
		interactData.OnValueChanged = (GSBindProp<DS_IBUC_InteractData>.ValueChangedHandler)Delegate.Combine(interactData.OnValueChanged, new GSBindProp<DS_IBUC_InteractData>.ValueChangedHandler(OnChangeInteractData));
		BindActor.InitForEnumBugFix(InBindActor);
		InteractType.InitForEnumBugFix(InInteractType);
		InteractTips.InitForEnumBugFix(GSMUIUtil.GetUIWordDescFTextIndex(EUIWordID.INTERACT_ACTIVE));
		B1GSUIActorMgr b1GSUIActorMgr = B1GSUIActorMgr.Get(InBindActor);
		if (b1GSUIActorMgr != null)
		{
			InteractData.SetValue(EChangeReason.Init, b1GSUIActorMgr.GetBattleDataByActor<DS_IBUC_InteractData>(InBindActor));
			ActorEvt.SetValue(EChangeReason.Init, b1GSUIActorMgr.GetActorEvt(1));
		}
	}

	private void OnChangeInteractData(EChangeReason Reason, DS_IBUC_InteractData OldValue, DS_IBUC_InteractData NewValue)
	{
		if (OldValue != null)
		{
			OldValue.UnBindInteractTipOverrideChange(TipBindIdx, OnInteractTipValChg);
			OldValue.UnBindInteractUIStateChange(UIStateBindIdx, OnInteractUIStateValChg);
			OldValue.UnBindInteractinputTimeChange(InputTimeBindIdx, OnInteractInputTimeChg);
		}
		if (NewValue != null)
		{
			TipBindIdx = InteractData.Value.BindInteractTipOverrideChange(OnInteractTipValChg);
			OnInteractTipValChg(InteractData.Value.InteractTipOverride, InteractData.Value.InteractTipOverride);
			UIStateBindIdx = InteractData.Value.BindInteractUIStateChange(OnInteractUIStateValChg);
			OnInteractUIStateValChg(InteractData.Value.InteractUIState, InteractData.Value.InteractUIState);
			InputTimeBindIdx = InteractData.Value.BindInteractinputTimeChange(OnInteractInputTimeChg);
			OnInteractInputTimeChg(InteractData.Value.InteractinputTime, InteractData.Value.InteractinputTime);
		}
	}

	private void OnInteractInputTimeChg(float OldValue, float NewValue)
	{
		InteractTime.SetValue(EChangeReason.ManualSet, NewValue);
	}

	private void OnInteractUIStateValChg(EInteractUIState OldValue, EInteractUIState NewValue)
	{
		InteractUIState.SetValue(EChangeReason.ManualSet, NewValue);
	}

	private void OnInteractTipValChg(string OldValue, string NewValue)
	{
		InteractTips.SetValue(EChangeReason.ManualSet, NewValue);
	}

	public void SetIsInInteractAction(bool InIsInInteractAction)
	{
		IsInInteractAction.SetValue(EChangeReason.ManualSet, InIsInInteractAction);
	}

	public void BindDestructAction(Action InAction)
	{
		OnDestruct = (Action)Delegate.Combine(OnDestruct, InAction);
	}

	public void SetIsSpecial(bool InIsSpecial)
	{
		IsSpecial.SetValue(EChangeReason.ManualSet, InIsSpecial);
	}

	public void SetIsShowSpecial(bool InIsShowSpecial)
	{
		IsShowSpecial.SetValue(EChangeReason.ManualSet, InIsShowSpecial);
	}

	public void GSOnDestruct()
	{
		IsShowSpecial.SetValue(EChangeReason.Init, value: false);
		IsSpecial.SetValue(EChangeReason.Init, value: false);
		InteractUIState.SetValue(EChangeReason.Init, EInteractUIState.Invisiable);
		OnDestruct?.Invoke();
		OnDestruct = null;
		InteractData.SetValue(EChangeReason.ManualSet, null);
		ActorEvt.SetValue(EChangeReason.ManualSet, null);
	}

	public FVector GetLocation()
	{
		return InteractData.Value.IconSockVector;
	}
}
