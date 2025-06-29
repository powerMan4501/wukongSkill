using System;
using b1.UI.Comm;
using B1UI.GSUI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_TreasureCS")]
public class BI_TreasureCS : BUI_StateWidget
{
	private UImage ImgIcon;

	private UImage ImgCD;

	private UMaterialInstanceDynamic MICD;

	private UWidgetAnimation AnimCosted;

	private UWidgetAnimation AnimReady;

	private UWidgetAnimation AnimActived;

	private UWidgetAnimation AnimNSHide;

	private int FaBaoID;

	private bool IsInCD;

	private int BindIdx;

	private BGW_SettingMgrV2 SettingMgrV2;

	private BGW_UIMgr UIMgr;

	private MDSBattleMain BattleMainData;

	private DS_IBUC_EquipFaBaoData EquipFaBaoData;

	private DS_IBPC_BattleMainInfoData BattleMainInfoData;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SettingMgrV2 = BGW_SettingMgrV2.Get(this);
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr.GetMDSBattleMain();
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		ImgCD = FindChildWidget("ImgCD") as UImage;
		MICD = ImgCD.GetDynamicMaterial();
		AnimCosted = FindWidgetAnimation("AnimCosted");
		AnimReady = FindWidgetAnimation("AnimReady");
		AnimActived = FindWidgetAnimation("AnimActived");
		AnimNSHide = FindWidgetAnimation("AnimUINSSkill_Hide");
		EquipFaBaoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_EquipFaBaoData>(B1ActorTag.CurPlayerActor);
		if (EquipFaBaoData != null)
		{
			BindIdx = EquipFaBaoData.BindFaBaoStateChange(OnFaBaoStateChange);
			if (EquipFaBaoData.GetEquippedFaBaoID() != 0)
			{
				OnFaBaoStateChange(EquipFaBaoData.FaBaoState, EquipFaBaoData.FaBaoState);
			}
		}
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

	private bool IsNeedUpdateFaBao(int ReasonValue)
	{
		if (ReasonValue != 95 && ReasonValue != 1)
		{
			return ReasonValue == 206;
		}
		return true;
	}

	public void OnChangeFabao(int ReasonValue, int OldValue, int NewValue)
	{
		if (!IsNeedUpdateFaBao(ReasonValue) && NewValue != 0)
		{
			return;
		}
		FaBaoID = NewValue;
		if (NewValue == 0)
		{
			SetVisibility(ESlateVisibility.Collapsed);
			return;
		}
		UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgIcon, GSUIResPathUtil.GetItemIconGPath(FaBaoID));
		UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgCD, GSUIResPathUtil.GetItemIconGPath(FaBaoID));
		if (BattleMainData.IsTrans)
		{
			return;
		}
		SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		if (OldValue == 0)
		{
			EquipFaBaoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_EquipFaBaoData>(B1ActorTag.CurPlayerActor);
			if (EquipFaBaoData != null)
			{
				OnFaBaoStateChange(EquipFaBaoData.FaBaoState, EquipFaBaoData.FaBaoState);
			}
		}
	}

	public void OnShowState(bool IsShow)
	{
		if (IsShow)
		{
			if (FaBaoID != 0)
			{
				SetVisibility(ESlateVisibility.SelfHitTestInvisible);
				if (EquipFaBaoData != null)
				{
					OnFaBaoStateChange(EquipFaBaoData.FaBaoState, EquipFaBaoData.FaBaoState);
				}
			}
		}
		else
		{
			SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	private void OnFaBaoStateChange(EFaBaoState OldValue, EFaBaoState NewValue)
	{
		switch (NewValue)
		{
		case EFaBaoState.Carry:
			BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			MICD.SetScalarParameterValue(B1GlobalFNames.Percent, 1f);
			if (IsCanPerform() && NewValue != OldValue)
			{
				PlayWidgetAnimation(AnimReady);
				UIMgr.PlayUISound("EVT_hud_player_fashu_full");
			}
			SwitchState(WidgetUIStat.NorReady);
			IsInCD = false;
			break;
		case EFaBaoState.Cast:
			SwitchState(WidgetUIStat.Actived);
			BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			PlayWidgetAnimation(AnimCosted);
			PlayWidgetAnimation(AnimActived);
			break;
		case EFaBaoState.Cooldown:
			if (IsAnimationPlaying(AnimReady))
			{
				StopAnimation(AnimReady);
			}
			SwitchState(WidgetUIStat.NorInCD);
			MICD = ImgCD.GetDynamicMaterial();
			if (!IsInCD)
			{
				MICD.SetScalarParameterValue(B1GlobalFNames.Percent, 0f);
			}
			IsInCD = true;
			break;
		}
	}

	private void TickSpellCD(float DeltaTime)
	{
		if (EquipFaBaoData != null && IsInCD && !MICD.IsNullOrDestroyed())
		{
			MICD.SetScalarParameterValue(B1GlobalFNames.Percent, EquipFaBaoData.FaBaoCoolDownPercentage);
		}
	}

	private void TickActiveState(float DeltaTime)
	{
		if (EquipFaBaoData != null && EquipFaBaoData.FaBaoState == EFaBaoState.Cast && !MICD.IsNullOrDestroyed())
		{
			MICD.SetScalarParameterValue(B1GlobalFNames.Percent, EquipFaBaoData.CurrentCastDuration / EquipFaBaoData.FaBaoCastDuration);
		}
	}

	private void TickInfo(float DeltaTime)
	{
		if (BattleMainInfoData != null && BattleMainInfoData.GetFaBaoInfo(out var FaBaoInfo))
		{
			SwitchState(FaBaoInfo.IsDisabled);
			SetForbidState(FaBaoInfo.IsForbid);
			SwitchLockState(FaBaoInfo.IsLocked);
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickSpellCD(InDeltaTime);
		TickActiveState(InDeltaTime);
		TickInfo(InDeltaTime);
	}

	public bool IsGSNeedTick()
	{
		return IsInCD;
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

	public void OnMagicArtifact()
	{
		if (BattleMainData.GetIsActive() && GetVisibility() != ESlateVisibility.Collapsed)
		{
			PlayWidgetAnimation(AnimCosted);
			if (EquipFaBaoData.FaBaoState != EFaBaoState.Carry)
			{
				UIMgr.PlayUISound("EVT_ui_hud_hint_fashu_nocd");
			}
		}
	}

	private bool IsCanPerform()
	{
		if (FaBaoID != 0)
		{
			return BattleMainData.GetIsActive();
		}
		return false;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		if (EquipFaBaoData != null)
		{
			EquipFaBaoData.UnBindFaBaoStateChange(BindIdx, OnFaBaoStateChange);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_TreasureCS");
	}

	static BI_TreasureCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_TreasureCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_TreasureCS));
	}
}
