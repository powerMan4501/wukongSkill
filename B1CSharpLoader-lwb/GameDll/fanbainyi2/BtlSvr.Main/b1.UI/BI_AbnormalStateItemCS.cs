using System;
using b1.Plugins.NiagaraUIRenderer;
using B1UI.GSUI;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_AbnormalStateItemCS")]
public class BI_AbnormalStateItemCS : BUI_Widget
{
	protected UWidgetAnimation AnimShow;

	protected UWidgetAnimation AnimHide;

	protected UWidgetAnimation AnimLoopTimelimit;

	protected UWidgetAnimation AnimRefreshState;

	protected UImage ImgIcon;

	protected UMaterialInstanceDynamic MIIcon;

	protected UNiagaraSystemWidget UINSEffect;

	protected EAbnormalStateType AbnormalStateType;

	protected FAbnormalStateUIInfo DataStore;

	protected GSBindProp<bool> IsShowing = new GSBindProp<bool>();

	protected DS_IBUC_AttrContainer AttrContainer;

	protected GSUIActorMgr.EvtClass ActorEvt;

	private static bool WarningRemaining_IsValid;

	private static int WarningRemaining_Offset;

	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("配置")]
	[DisplayName("消失警告倒计时")]
	[USharpPath("/Script/b1-Managed.BI_AbnormalStateItemCS:WarningRemaining")]
	public float WarningRemaining
	{
		get
		{
			CheckDestroyed();
			if (!WarningRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateItemCS:WarningRemaining");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WarningRemaining_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarningRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_AbnormalStateItemCS:WarningRemaining");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WarningRemaining_Offset), value);
			}
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		MIIcon = ImgIcon?.GetDynamicMaterial();
		UINSEffect = FindChildWidget("UINS_Effect") as UNiagaraSystemWidget;
		AnimLoopTimelimit = FindWidgetAnimation("AnimLoopTimelimit");
		AnimRefreshState = FindWidgetAnimation("AnimRefreshState");
		GSBindDelegateToOnAKBStateEnd("AKBShowHide", OnAKBStateEndFunc);
		BindStateEvent();
	}

	private void OnAKBStateEndFunc(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		if (!IsShowing.Value)
		{
			SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	public void UpdateUnitInfo(BGUCharacterCS CharacterActor)
	{
		AttrContainer = B1GSUIActorMgr.Get(this).GetBattleDataByActor<DS_IBUC_AttrContainer>(CharacterActor);
	}

	private void BindStateEvent()
	{
		GSBindProp<bool> isShowing = IsShowing;
		isShowing.OnValueChanged = (GSBindProp<bool>.ValueChangedHandler)Delegate.Combine(isShowing.OnValueChanged, new GSBindProp<bool>.ValueChangedHandler(OnIsShowingChanged));
		OnIsShowingChanged(EChangeReason.Init, IsShowing.Value, IsShowing.Value);
	}

	public void BindDataStore(FAbnormalStateUIInfo InDataStore)
	{
		ReleaseBindAction();
		DataStore = InDataStore;
		BindValueToCustom(DataStore.bIsInFinalState, OnIsInFinalStateChanged);
		BindValueToCustom(DataStore.FinalEffectBuffID, OnFinalEffectBuffIDChanged);
	}

	private void OnIsInFinalStateChanged(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			StopAnimation(AnimRefreshState);
			PlayAnimation(AnimRefreshState);
		}
		GSAnimKeyToState("AKBTriggerFinalEffect", NewValue ? "Active" : "Deactive");
	}

	private void OnFinalEffectBuffIDChanged(EChangeReason Reason, int OldValue, int NewValue)
	{
		UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgIcon, GSUIResPathUtil.GetStateIconGPath(NewValue));
		StopAnimation(AnimRefreshState);
		PlayAnimation(AnimRefreshState);
	}

	private void OnIsShowingChanged(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		string animName = "AKBShowHide";
		if (Reason == EChangeReason.Init)
		{
			GSAnimKeyToState(animName, "Hide", IsForce: true);
			SetVisibility(ESlateVisibility.Collapsed);
		}
		else if (NewValue)
		{
			SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			GSAnimKeyToState(animName, "Show");
			if (IsAnimationPlaying(AnimHide))
			{
				StopAnimation(AnimHide);
			}
		}
		else
		{
			GSAnimKeyToState(animName, "Hide");
			if (IsAnimationPlaying(AnimShow))
			{
				StopAnimation(AnimShow);
			}
			StopAnimation(AnimLoopTimelimit);
		}
	}

	private void GetAttrValue(out float CurValue, out float MaxValue)
	{
		CurValue = 1f;
		MaxValue = 1f;
		if (DataStore != null && AttrContainer != null)
		{
			EBGUAttrFloat attrID = EBGUAttrFloat.None;
			EBGUAttrFloat attrID2 = EBGUAttrFloat.None;
			switch (AbnormalStateType)
			{
			case EAbnormalStateType.Abnormal_Freeze:
				attrID = EBGUAttrFloat.FreezeAbnormalAcc;
				attrID2 = EBGUAttrFloat.FreezeAbnormalAccMax;
				break;
			case EAbnormalStateType.Abnormal_Burn:
				attrID = EBGUAttrFloat.BurnAbnormalAcc;
				attrID2 = EBGUAttrFloat.BurnAbnormalAccMax;
				break;
			case EAbnormalStateType.Abnormal_Poison:
				attrID = EBGUAttrFloat.PoisonAbnormalAcc;
				attrID2 = EBGUAttrFloat.PoisonAbnormalAccMax;
				break;
			case EAbnormalStateType.Abnormal_Thunder:
				attrID = EBGUAttrFloat.ThunderAbnormalAcc;
				attrID2 = EBGUAttrFloat.ThunderAbnormalAccMax;
				break;
			case EAbnormalStateType.Abnormal_Yin:
				attrID = EBGUAttrFloat.YinAbnormalAcc;
				attrID2 = EBGUAttrFloat.YinAbnormalAccMax;
				break;
			case EAbnormalStateType.Abnormal_Yang:
				attrID = EBGUAttrFloat.YangAbnormalAcc;
				attrID2 = EBGUAttrFloat.YangAbnormalAccMax;
				break;
			}
			CurValue = AttrContainer.GetFloatValue(attrID);
			MaxValue = AttrContainer.GetFloatValue(attrID2);
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		StateCheck(InDeltaTime);
	}

	public void StateCheck(float InDeltaTime)
	{
		if (DataStore == null)
		{
			return;
		}
		float num = 0f;
		if (!DataStore.bIsInFinalState.Value)
		{
			GetAttrValue(out var CurValue, out var MaxValue);
			if (MaxValue > 0f)
			{
				num = CurValue / MaxValue;
			}
		}
		else
		{
			float remainTime_FinalEffectBuff = DataStore.RemainTime_FinalEffectBuff;
			if (remainTime_FinalEffectBuff == -0.001f)
			{
				num = 1f;
			}
			else if (DataStore.TotalTime_FinalEffectBuff > 0f)
			{
				num = remainTime_FinalEffectBuff / DataStore.TotalTime_FinalEffectBuff;
			}
			if (AnimLoopTimelimit != null)
			{
				if (remainTime_FinalEffectBuff <= WarningRemaining)
				{
					PlayAnimLoop(AnimLoopTimelimit, remainTime_FinalEffectBuff);
				}
				else
				{
					StopAnimation(AnimLoopTimelimit);
				}
			}
			MIIcon.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_TimeLimit, remainTime_FinalEffectBuff);
		}
		MIIcon.SetScalarParameterValue(B1GlobalFNames.GSScalarParameter_Percent, num);
		UINSEffect.GSSetNiagaraValFloat(B1GlobalFNames.GSScalarParameter_Percent.ToString(), num);
	}

	public bool GetIsShowing()
	{
		return IsShowing.Value;
	}

	public void SetIsShowing(bool InIsShowing)
	{
		IsShowing.SetValue(EChangeReason.ManualSet, InIsShowing);
	}

	public void ShowIn()
	{
		SetIsShowing(InIsShowing: true);
	}

	public void ShowOut()
	{
		SetIsShowing(InIsShowing: false);
	}

	public void SetAbnormalStateType(EAbnormalStateType InAbnormalStateType)
	{
		AbnormalStateType = InAbnormalStateType;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_AbnormalStateItemCS");
		WarningRemaining_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WarningRemaining");
		WarningRemaining_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WarningRemaining", Classes.FFloatProperty);
	}

	static BI_AbnormalStateItemCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_AbnormalStateItemCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_AbnormalStateItemCS));
	}
}
