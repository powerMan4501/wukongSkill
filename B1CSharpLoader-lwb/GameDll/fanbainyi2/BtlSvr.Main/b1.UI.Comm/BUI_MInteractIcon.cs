using System;
using b1.EventDelDefine;
using b1.Localization;
using b1.Plugins.GSInput;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MInteractIcon")]
public class BUI_MInteractIcon : BUI_ProjWidget
{
	private MDSInteractIcon DataStore;

	private UTextBlock TxtItem;

	private UTextBlock TxtTips;

	private UImage ImgDisable;

	private UGSInputActionIcon InputIcon;

	private bool IsInInteractInputStep;

	private EInteractUIState StateCache;

	protected override void OnUIPreConstruct()
	{
		base.OnUIPreConstruct();
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		InputIcon = FindChildWidget("ImgIcon") as UGSInputActionIcon;
		ImgDisable = FindChildWidget("ImgDisable") as UImage;
		TxtTips = FindChildWidget("TxtTips") as UTextBlock;
		TxtItem = FindChildWidget("TxtItem") as UTextBlock;
	}

	public override void InitSet(IProjInfo InProjData)
	{
		base.InitSet(InProjData);
		InitDataStore(InProjData as MDSInteractIcon);
		SetAlwaysShowSetting(AlwaysShowSetting.Always, Value: true);
	}

	protected void InitDataStore(MDSInteractIcon InDataStore)
	{
		if (DataStore != null)
		{
			DataStore.GSOnDestruct();
		}
		DataStore = InDataStore;
		if (DataStore.InteractData.Value != null)
		{
			FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(DataStore.InteractData.Value.InteractiveUnitID);
			UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgDisable, interactiveUnitCommDesc.FocusIconPath);
		}
		if (DataStore.ActorEvt.Value != null)
		{
			GSUIActorMgr.EvtClass ActorEvt = DataStore.ActorEvt.Value;
			if (ActorEvt != null)
			{
				GSUIActorMgr.EvtClass evtClass = ActorEvt;
				evtClass.Evt_PlayerBeInteractInput = (Del_Void_Actor)Delegate.Combine(evtClass.Evt_PlayerBeInteractInput, new Del_Void_Actor(OnTriggerBeInteract));
				GSUIActorMgr.EvtClass evtClass2 = ActorEvt;
				evtClass2.Evt_PlayerBreakInteractInput = (Del_Void_Actor)Delegate.Combine(evtClass2.Evt_PlayerBreakInteractInput, new Del_Void_Actor(OnTriggerBreakInteractInput));
				GSUIActorMgr.EvtClass evtClass3 = ActorEvt;
				evtClass3.Evt_PlayerFinishInteractInput = (Del_Void_Actor)Delegate.Combine(evtClass3.Evt_PlayerFinishInteractInput, new Del_Void_Actor(OnTriggerFinishInteractInput));
				GSUIActorMgr.EvtClass evtClass4 = ActorEvt;
				evtClass4.Evt_TriggerFinishInteract = (Del_Void_Actor)Delegate.Combine(evtClass4.Evt_TriggerFinishInteract, new Del_Void_Actor(OnTriggerFinishInteractAction));
				GSUIActorMgr.EvtClass evtClass5 = ActorEvt;
				evtClass5.Evt_OnPlayerBreakInteract = (Del_Void_Actor)Delegate.Combine(evtClass5.Evt_OnPlayerBreakInteract, new Del_Void_Actor(OnTriggerBreakAction));
				GSUIActorMgr.EvtClass evtClass6 = ActorEvt;
				evtClass6.Evt_PlayerCollectedV2 = (Del_Void_Actor)Delegate.Combine(evtClass6.Evt_PlayerCollectedV2, new Del_Void_Actor(OnTriggerRemoveCollect));
				GSUIActorMgr.EvtClass evtClass7 = ActorEvt;
				evtClass7.Evt_TriggerBeSaving = (Del_Void_ActorActor)Delegate.Combine(evtClass7.Evt_TriggerBeSaving, new Del_Void_ActorActor(OnTriggerBeSaving));
				GSUIActorMgr.EvtClass evtClass8 = ActorEvt;
				evtClass8.Evt_TriggerBreakBeSaving = (Del_Void_ActorActor)Delegate.Combine(evtClass8.Evt_TriggerBreakBeSaving, new Del_Void_ActorActor(OnTriggerBreakBeSaving));
				GSUIActorMgr.EvtClass evtClass9 = ActorEvt;
				evtClass9.Evt_TriggerFinishBeSaving = (Del_Void_ActorActor)Delegate.Combine(evtClass9.Evt_TriggerFinishBeSaving, new Del_Void_ActorActor(OnTriggerFinishBeSaving));
				DataStore.BindDestructAction(delegate
				{
					GSUIActorMgr.EvtClass evtClass10 = ActorEvt;
					evtClass10.Evt_PlayerBeInteractInput = (Del_Void_Actor)Delegate.Remove(evtClass10.Evt_PlayerBeInteractInput, new Del_Void_Actor(OnTriggerBeInteract));
					GSUIActorMgr.EvtClass evtClass11 = ActorEvt;
					evtClass11.Evt_PlayerBreakInteractInput = (Del_Void_Actor)Delegate.Remove(evtClass11.Evt_PlayerBreakInteractInput, new Del_Void_Actor(OnTriggerBreakInteractInput));
					GSUIActorMgr.EvtClass evtClass12 = ActorEvt;
					evtClass12.Evt_PlayerFinishInteractInput = (Del_Void_Actor)Delegate.Remove(evtClass12.Evt_PlayerFinishInteractInput, new Del_Void_Actor(OnTriggerFinishInteractInput));
					GSUIActorMgr.EvtClass evtClass13 = ActorEvt;
					evtClass13.Evt_TriggerFinishInteract = (Del_Void_Actor)Delegate.Remove(evtClass13.Evt_TriggerFinishInteract, new Del_Void_Actor(OnTriggerFinishInteractAction));
					GSUIActorMgr.EvtClass evtClass14 = ActorEvt;
					evtClass14.Evt_OnPlayerBreakInteract = (Del_Void_Actor)Delegate.Remove(evtClass14.Evt_OnPlayerBreakInteract, new Del_Void_Actor(OnTriggerBreakAction));
					GSUIActorMgr.EvtClass evtClass15 = ActorEvt;
					evtClass15.Evt_PlayerCollectedV2 = (Del_Void_Actor)Delegate.Remove(evtClass15.Evt_PlayerCollectedV2, new Del_Void_Actor(OnTriggerRemoveCollect));
					GSUIActorMgr.EvtClass evtClass16 = ActorEvt;
					evtClass16.Evt_TriggerBeSaving = (Del_Void_ActorActor)Delegate.Remove(evtClass16.Evt_TriggerBeSaving, new Del_Void_ActorActor(OnTriggerBeSaving));
					GSUIActorMgr.EvtClass evtClass17 = ActorEvt;
					evtClass17.Evt_TriggerBreakBeSaving = (Del_Void_ActorActor)Delegate.Remove(evtClass17.Evt_TriggerBreakBeSaving, new Del_Void_ActorActor(OnTriggerBreakBeSaving));
					GSUIActorMgr.EvtClass evtClass18 = ActorEvt;
					evtClass18.Evt_TriggerFinishBeSaving = (Del_Void_ActorActor)Delegate.Remove(evtClass18.Evt_TriggerFinishBeSaving, new Del_Void_ActorActor(OnTriggerFinishBeSaving));
				});
			}
		}
		GSBindProp<string> interactTips = DataStore.InteractTips;
		interactTips.OnValueChanged = (GSBindProp<string>.ValueChangedHandler)Delegate.Combine(interactTips.OnValueChanged, new GSBindProp<string>.ValueChangedHandler(OnInteractTipValChg));
		OnInteractTipValChg(EChangeReason.Init, DataStore.InteractTips.Value, DataStore.InteractTips.Value);
		GSBindProp<EInteractUIState> interactUIState = DataStore.InteractUIState;
		interactUIState.OnValueChanged = (GSBindProp<EInteractUIState>.ValueChangedHandler)Delegate.Combine(interactUIState.OnValueChanged, new GSBindProp<EInteractUIState>.ValueChangedHandler(OnInteractUIStateChange));
		OnInteractUIStateChange(EChangeReason.Init, DataStore.InteractUIState.Value, DataStore.InteractUIState.Value);
		GSBindProp<bool> isShowSpecial = DataStore.IsShowSpecial;
		isShowSpecial.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isShowSpecial.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnIsShowSpecialChange));
		GSBindProp<bool> isSpecial = DataStore.IsSpecial;
		isSpecial.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isSpecial.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnIsSpecialChange));
		GSBindProp<float> interactTime = DataStore.InteractTime;
		interactTime.OnValueChanged = (GSBindProp<float>.ValueChangedHandler)Delegate.Combine(interactTime.OnValueChanged, new GSBindProp<float>.ValueChangedHandler(OnInteractTimeValChg));
		OnInteractTimeValChg(EChangeReason.Init, DataStore.InteractTime.Value, DataStore.InteractTime.Value);
	}

	private void OnIsSpecialChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		OnIsShowSpecialChange(Reason, DataStore.IsShowSpecial.Value, DataStore.IsShowSpecial.Value);
	}

	private void OnIsShowSpecialChange(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (Reason == EChangeReason.Init || !DataStore.IsSpecial.Value)
		{
			SetWidgetAnimationTimeByInfoName("GSAnimSpecialHide", IsStart: false);
		}
		else if (NewValue)
		{
			PlayWidgetAnimationByInfoName("GSAnimSpecialShow");
		}
		else
		{
			PlayWidgetAnimationByInfoName("GSAnimSpecialHide");
		}
	}

	private void OnInteractTipValChg(EChangeReason Reason, string OldValue, string NewValue)
	{
		if (!string.IsNullOrEmpty(NewValue))
		{
			TxtTips?.SetText(NewValue.ToFText());
		}
	}

	private void OnInteractTimeValChg(EChangeReason Reason, float OldValue, float NewValue)
	{
		if (NewValue <= 0f)
		{
			InputIcon.OpenPercentBg(bOpen: false);
		}
	}

	private void OnInteractUIStateChange(EChangeReason Reason, EInteractUIState OldValue, EInteractUIState NewValue)
	{
		StateCache = NewValue;
		if (IsInInteractInputStep)
		{
			return;
		}
		switch (NewValue)
		{
		case EInteractUIState.Min:
		case EInteractUIState.Invisiable:
			GSAnimKeyToState("GSAKBInteractState", "Invisible", Reason == EChangeReason.Init);
			break;
		case EInteractUIState.Focus:
			GSAnimKeyToState("GSAKBInteractState", "Disable");
			break;
		case EInteractUIState.Interactable:
			if (DataStore != null && DataStore.InteractData.Value.bSpecialIcon)
			{
				GSAnimKeyToState("GSAKBInteractState", "InteractableSpecial");
			}
			else
			{
				GSAnimKeyToState("GSAKBInteractState", "Interactable");
			}
			break;
		case EInteractUIState.CantInteract:
			GSAnimKeyToState("GSAKBInteractState", "Matched");
			break;
		}
		DataStore?.SetIsShowSpecial(NewValue != EInteractUIState.Min && NewValue != EInteractUIState.Invisiable);
	}

	public void SetItemText(FText Text)
	{
		TxtItem?.SetText(Text);
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		Reset();
	}

	public override bool GetIsUseHideRound()
	{
		return false;
	}

	public override bool GetIsUseRound()
	{
		return false;
	}

	public override void Reset()
	{
		base.Reset();
		DataStore?.GSOnDestruct();
		DataStore = null;
		InputIcon.SetPercent(0f);
		IsInInteractInputStep = false;
		OnInteractUIStateChange(EChangeReason.ManualSet, EInteractUIState.Min, StateCache);
	}

	protected override void UpdateScrPosAngle(FVector2D ScrPos, float RectAngle)
	{
		base.UpdateScrPosAngle(ScrPos, RectAngle);
		SetRenderTranslation(ScrPos);
	}

	public void OnTriggerBreakAction(AActor Actor)
	{
		OnTriggerFinishInteractAction(Actor);
	}

	public void OnTriggerFinishInteractAction(AActor Actor)
	{
		if (DataStore.BindActor.Value != Actor)
		{
			return;
		}
		DataStore.SetIsInInteractAction(InIsInInteractAction: false);
		DS_IBUC_InteractData battleDataByActor = B1GSUIActorMgr.Get(this).GetBattleDataByActor<DS_IBUC_InteractData>(Actor);
		if (battleDataByActor != null && battleDataByActor.InteractUnitState == EBGUInteractUnitState.BeforeActive)
		{
			FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(battleDataByActor.InteractiveUnitID);
			if (interactiveUnitCommDesc != null && interactiveUnitCommDesc.InteractType != EInteractType.RebirthPoint && battleDataByActor.InteractUIState > EInteractUIState.Invisiable)
			{
				Play();
			}
		}
	}

	public void OnTriggerBeInteract(AActor Actor)
	{
		if (!(DataStore.BindActor.Value != Actor))
		{
			IsInInteractInputStep = true;
			InputIcon.OpenPercentBg(DataStore.InteractTime.Value > 0f);
			if (DataStore.InteractTime.Value > 0f)
			{
				InputIcon.BeginHold(DataStore.InteractTime.Value);
			}
		}
	}

	public void OnTriggerBreakInteractInput(AActor Actor)
	{
		if (!(DataStore.BindActor.Value != Actor))
		{
			IsInInteractInputStep = false;
			OnInteractUIStateChange(EChangeReason.ManualSet, EInteractUIState.Min, StateCache);
			InputIcon.StopHold();
		}
	}

	public void OnTriggerFinishInteractInput(AActor Actor)
	{
		if (DataStore != null && !(DataStore.BindActor.Value != Actor))
		{
			IsInInteractInputStep = false;
			OnInteractUIStateChange(EChangeReason.ManualSet, EInteractUIState.Min, StateCache);
			DataStore.SetIsInInteractAction(InIsInInteractAction: true);
		}
	}

	public void OnTriggerBeSaving(AActor BeSaveActor, AActor SaveActor)
	{
		if (!(BeSaveActor == SaveActor))
		{
			OnTriggerBeInteract(BeSaveActor);
		}
	}

	public void OnTriggerBreakBeSaving(AActor BeSaveActor, AActor SaveActor)
	{
		if (!(BeSaveActor == SaveActor))
		{
			OnTriggerBreakInteractInput(BeSaveActor);
		}
	}

	public void OnTriggerFinishBeSaving(AActor BeSaveActor, AActor SaveActor)
	{
		if (!(BeSaveActor == SaveActor))
		{
			OnTriggerFinishInteractInput(BeSaveActor);
			Reset();
		}
	}

	private void OnTriggerRemoveCollect(AActor Actor)
	{
		if (!(DataStore.BindActor.Value != Actor))
		{
			Reset();
		}
	}

	public AActor GetBindActor()
	{
		return DataStore.BindActor.Value;
	}

	public void SetIsSpecial(bool InIsSpecial)
	{
		DataStore.SetIsSpecial(InIsSpecial);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_MInteractIcon");
	}

	static BUI_MInteractIcon()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MInteractIcon)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MInteractIcon));
	}
}
