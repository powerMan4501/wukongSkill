using System;
using b1.UI.Comm;
using B1UI.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_SoulSkillCS")]
public class BI_SoulSkillCS : BUI_StateWidget
{
	private UImage ImgIcon;

	private UImage ImgCD;

	private UMaterialInstanceDynamic MICD;

	private UWidgetAnimation AnimCosted;

	private UWidgetAnimation AnimReady;

	private UWidgetAnimation AnimActived;

	private UWidgetAnimation AnimNSHide;

	private int SoulSkillID;

	private bool IsInCD;

	private BGW_SettingMgrV2 SettingMgrV2;

	private BGW_UIMgr UIMgr;

	private MDSBattleMain BattleMainData;

	private DS_IBPC_BattleMainInfoData BattleMainInfoData;

	private bool IsInit;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr.GetMDSBattleMain();
		SettingMgrV2 = BGW_SettingMgrV2.Get(this);
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		ImgCD = FindChildWidget("ImgCD") as UImage;
		MICD = ImgCD.GetDynamicMaterial();
		AnimCosted = FindWidgetAnimation("AnimCosted");
		AnimReady = FindWidgetAnimation("AnimReady");
		AnimActived = FindWidgetAnimation("AnimActived");
		AnimNSHide = FindWidgetAnimation("AnimUINSSkill_Hide");
	}

	protected override void OnSwitchState(WidgetUIStat State)
	{
		base.OnSwitchState(State);
		StopNSSkillHideAnim();
	}

	protected override void OnForbidStateChange(bool IsForbid)
	{
		base.OnForbidStateChange(IsForbid);
		StopNSSkillHideAnim();
	}

	private bool IsNeedUpdateSoulSkill(int ReasonValue)
	{
		if (ReasonValue != 146 && ReasonValue != 1 && ReasonValue != 206)
		{
			return ReasonValue == 2;
		}
		return true;
	}

	public void OnChangeSoulSkill(int ReasonValue, int OldValue, int NewValue)
	{
		SoulSkillID = NewValue;
		if (NewValue == 0)
		{
			SetVisibility(ESlateVisibility.Collapsed);
			return;
		}
		UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgIcon, GSUIResPathUtil.GetItemIconGPath(SoulSkillID));
		UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgCD, GSUIResPathUtil.GetItemIconGPath(SoulSkillID));
		SetVisibility(ESlateVisibility.SelfHitTestInvisible);
	}

	private void OnChangeInCD(bool OldValue, bool NewValue)
	{
		if (IsInCD == NewValue && IsInit)
		{
			return;
		}
		if (!IsInit)
		{
			IsInit = true;
		}
		IsInCD = NewValue;
		if (IsInCD)
		{
			if (IsAnimationPlaying(AnimReady))
			{
				StopAnimation(AnimReady);
			}
			if (GetCurState() != WidgetUIStat.None)
			{
				PlayWidgetAnimation(AnimActived);
				BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			}
			SwitchState(WidgetUIStat.NorInCD);
			MICD = ImgCD.GetDynamicMaterial();
			MICD.SetScalarParameterValue(B1GlobalFNames.Percent, 0f);
		}
		else
		{
			MICD.SetScalarParameterValue(B1GlobalFNames.Percent, 1f);
			BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			if (IsCanPerform())
			{
				PlayWidgetAnimation(AnimReady);
				UIMgr.PlayUISound("EVT_hud_player_fashu_full");
			}
			SwitchState(WidgetUIStat.NorReady);
		}
	}

	private void TickSoulSkillCD(float DeltaTime, float CDTimePercent)
	{
		OnChangeInCD(IsInCD, CDTimePercent > 0f);
		if (IsInCD && !MICD.IsNullOrDestroyed())
		{
			MICD.SetScalarParameterValue(B1GlobalFNames.Percent, 1f - CDTimePercent);
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickInfo(InDeltaTime);
	}

	private void TickInfo(float DeltaTime)
	{
		if (BattleMainInfoData != null && BattleMainInfoData.GetSoulSkillInfo(out var SoulInfo))
		{
			SwitchState(SoulInfo.IsDisabled);
			SetForbidState(SoulInfo.IsForbid);
			TickSoulSkillCD(DeltaTime, SoulInfo.CDTimePercent);
		}
	}

	private void StopNSSkillHideAnim()
	{
		if (IsAnimationPlaying(AnimNSHide))
		{
			StopAnimation(AnimNSHide);
		}
	}

	public void PlayNSSkillHideAnim()
	{
		PlayWidgetAnimation(AnimNSHide);
	}

	public void OnUseSoulSkill()
	{
		if (BattleMainData.GetIsActive() && GetVisibility() != ESlateVisibility.Collapsed)
		{
			PlayWidgetAnimation(AnimCosted);
			if (IsInCD)
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_fashu_nocd");
			}
		}
	}

	private bool IsCanPerform()
	{
		return BattleMainData.GetIsActive();
	}

	public void OnShowState(bool IsShow)
	{
		if (IsShow)
		{
			if (SoulSkillID != 0)
			{
				SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
		}
		else
		{
			SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_SoulSkillCS");
	}

	static BI_SoulSkillCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_SoulSkillCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_SoulSkillCS));
	}
}
