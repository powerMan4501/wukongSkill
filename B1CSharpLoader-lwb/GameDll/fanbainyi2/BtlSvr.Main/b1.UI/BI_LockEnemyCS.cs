using System;
using b1.ECS;
using b1.EventDelDefine;
using b1.UI.Comm;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_LockEnemyCS")]
public class BI_LockEnemyCS : BUI_ProjWidget
{
	private UImage ImgDingshenLock;

	private UImage NormalLock;

	private int LockType;

	private bool IsLockTarget;

	private int BarSockTargetChangeIdx = -1;

	private int BarSockSkeletonSocketChangeIdx = -1;

	private int CantShowBarSockUIChangeIdx = -1;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		ImgDingshenLock = FindChildWidget("DingShenLock") as UImage;
		NormalLock = FindChildWidget("NormalLock") as UImage;
		DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
		BarSockTargetChangeIdx = battleData.BindLockTargetActorChange(UIBarSockTargetChange);
		BarSockSkeletonSocketChangeIdx = battleData.BindLockTargetSkeletonSocketChange(UIBarSockTargetSkeletonSocketChange);
		CantShowBarSockUIChangeIdx = battleData.BindCantShowBarSockUIChange(UICantShowBarSockUIChange);
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_Camera_SwitchHideUILockPoint = (Del_Void)Delegate.Combine(actorEvt.Evt_Camera_SwitchHideUILockPoint, new Del_Void(SwitchTmpHideUI));
			actorEvt.Evt_GM_SwitchHideUILockPoint = (Del_Void_Float)Delegate.Combine(actorEvt.Evt_GM_SwitchHideUILockPoint, new Del_Void_Float(GMSwitchHideUILockPoint));
		}
		if (!IsLockTarget)
		{
			DS_IBUC_TargetInfoData battleData2 = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_TargetInfoData>(B1ActorTag.CurPlayerActor);
			if (battleData2 != null && !battleData2.GetTargetInfo().LockTargetEntity.IsNull())
			{
				IsLockTarget = true;
			}
		}
		SetUIVisibility(IsLockTarget);
		GMSwitchHideUILockPoint(DebugConfig.HideLockTarget);
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_TransStateChange = (BGW_UIEventCollection.Del_UI_Void)Delegate.Combine(bGW_UIEventCollection.Evt_UI_TransStateChange, new BGW_UIEventCollection.Del_UI_Void(TransStateChange));
			bGW_UIEventCollection.Evt_SettingValueChanged = (BGW_UIEventCollection.Del_UI_SettingValue)Delegate.Combine(bGW_UIEventCollection.Evt_SettingValueChanged, new BGW_UIEventCollection.Del_UI_SettingValue(SettingValueChange));
		}
	}

	private void TransStateChange()
	{
		if (B1GSUIActorMgr.Get(this) != null)
		{
			DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
			Entity lockTargetActor = battleData.GetLockTargetActor();
			if (lockTargetActor != Entity.Null)
			{
				UnitLockTargetInfo unitLockTargetInfo = new UnitLockTargetInfo();
				unitLockTargetInfo.LockTargetEntity = lockTargetActor;
				unitLockTargetInfo.LockTargetSkeletonSocketName = battleData.GetLockTargetSkeletonSocket();
				EnableLockTarget(unitLockTargetInfo);
			}
			else
			{
				DisableLockTarget();
			}
		}
	}

	private void SettingValueChange(int OldSettingValue, int NewSettingValue, UISettingConfigType SettingType)
	{
		if (SettingType == UISettingConfigType.LockBar)
		{
			DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
			Entity lockTargetActor = battleData.GetLockTargetActor();
			if (lockTargetActor != Entity.Null)
			{
				UnitLockTargetInfo unitLockTargetInfo = new UnitLockTargetInfo();
				unitLockTargetInfo.LockTargetEntity = lockTargetActor;
				unitLockTargetInfo.LockTargetSkeletonSocketName = battleData.GetLockTargetSkeletonSocket();
				EnableLockTarget(unitLockTargetInfo);
			}
			else
			{
				DisableLockTarget();
			}
		}
	}

	public void UIBarSockTargetChange(Entity OldValue, Entity NewValue)
	{
		if (NewValue != Entity.Null)
		{
			DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
			UnitLockTargetInfo unitLockTargetInfo = new UnitLockTargetInfo();
			unitLockTargetInfo.LockTargetEntity = NewValue;
			unitLockTargetInfo.LockTargetSkeletonSocketName = battleData.GetLockTargetSkeletonSocket();
			EnableLockTarget(unitLockTargetInfo);
		}
		else
		{
			DisableLockTarget();
		}
	}

	public void UIBarSockTargetSkeletonSocketChange(string OldValue, string NewValue)
	{
		DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
		UnitLockTargetInfo unitLockTargetInfo = new UnitLockTargetInfo();
		if (battleData.GetLockTargetActor() != Entity.Null)
		{
			unitLockTargetInfo.LockTargetEntity = battleData.GetLockTargetActor();
			unitLockTargetInfo.LockTargetSkeletonSocketName = NewValue;
			EnableLockTarget(unitLockTargetInfo);
		}
	}

	public void UICantShowBarSockUIChange(bool OldValue, bool NewValue)
	{
		if (NewValue)
		{
			DisableLockTarget();
			return;
		}
		DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
		UnitLockTargetInfo unitLockTargetInfo = new UnitLockTargetInfo();
		unitLockTargetInfo.LockTargetEntity = battleData.GetLockTargetActor();
		unitLockTargetInfo.LockTargetSkeletonSocketName = battleData.GetLockTargetSkeletonSocket();
		EnableLockTarget(unitLockTargetInfo);
	}

	protected override void UpdateScrPosAngle(FVector2D ScrPos, float RectAngle)
	{
		base.UpdateScrPosAngle(ScrPos, RectAngle);
		SetRenderTranslation(ScrPos);
	}

	public void ChangeLockType(int NewLockType)
	{
		if (LockType != NewLockType)
		{
			LockType = NewLockType;
			if (LockType == 0)
			{
				ImgDingshenLock.SetVisibility(ESlateVisibility.Collapsed);
				NormalLock.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else if (LockType == 1)
			{
				ImgDingshenLock.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
				NormalLock.SetVisibility(ESlateVisibility.Collapsed);
			}
		}
	}

	public void EnableLockTarget(UnitLockTargetInfo TargetInfo)
	{
		InitSet(new LockEnemyProjInfo(TargetInfo.LockTargetActor as BGUCharacterCS, TargetInfo.LockTargetSkeletonSocketName));
		SetUIVisibility(IsVisible: true);
	}

	public void DisableLockTarget()
	{
		Reset();
		SetUIVisibility(IsVisible: false);
	}

	public void SetUIVisibility(bool IsVisible)
	{
		if (BGW_SettingFuncUtil.GetSettingIntValueByType(this, UISettingConfigType.LockBar) == 0)
		{
			IsVisible = false;
		}
		DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
		if (battleData != null && battleData.IsCantShowBarSockUI())
		{
			IsVisible = false;
		}
		if (battleData == null || battleData.GetLockTargetActor().IsNull())
		{
			IsVisible = false;
		}
		SetVisibility((!IsVisible) ? ESlateVisibility.Hidden : ESlateVisibility.Visible);
		if (IsVisible)
		{
			StopAnimation("AnimLockOn");
			StopAnimation("AnimLockOnSp");
			if (battleData != null && battleData.GetIsTargetSp() && !B1Global.GIsBossRushMode)
			{
				PlayAnimation("AnimLockOnSp");
			}
			else
			{
				PlayAnimation("AnimLockOn");
			}
		}
	}

	public void SwitchTmpHideUI()
	{
		if (GetRenderOpacity() == 0f)
		{
			SetRenderOpacity(1f);
		}
		else
		{
			SetRenderOpacity(0f);
		}
	}

	public void GMSwitchHideUILockPoint(float NewScale)
	{
		if (!this.IsNullOrDestroyed())
		{
			SetRenderScale(new FVector2D(NewScale, NewScale));
		}
	}

	public bool GetCanTick()
	{
		return IsLockTarget;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		DS_IBUC_BarSockData battleData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBUC_BarSockData>(B1ActorTag.CurPlayerActor);
		battleData.UnBindLockTargetActorChange(BarSockTargetChangeIdx, UIBarSockTargetChange);
		battleData.UnBindLockTargetSkeletonSocketChange(BarSockSkeletonSocketChangeIdx, UIBarSockTargetSkeletonSocketChange);
		battleData.UnBindCantShowBarSockUIChange(CantShowBarSockUIChangeIdx, UICantShowBarSockUIChange);
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_Camera_SwitchHideUILockPoint = (Del_Void)Delegate.Remove(actorEvt.Evt_Camera_SwitchHideUILockPoint, new Del_Void(SwitchTmpHideUI));
			actorEvt.Evt_GM_SwitchHideUILockPoint = (Del_Void_Float)Delegate.Remove(actorEvt.Evt_GM_SwitchHideUILockPoint, new Del_Void_Float(GMSwitchHideUILockPoint));
		}
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(this);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_TransStateChange = (BGW_UIEventCollection.Del_UI_Void)Delegate.Remove(bGW_UIEventCollection.Evt_UI_TransStateChange, new BGW_UIEventCollection.Del_UI_Void(TransStateChange));
			bGW_UIEventCollection.Evt_SettingValueChanged = (BGW_UIEventCollection.Del_UI_SettingValue)Delegate.Remove(bGW_UIEventCollection.Evt_SettingValueChanged, new BGW_UIEventCollection.Del_UI_SettingValue(SettingValueChange));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_LockEnemyCS");
	}

	static BI_LockEnemyCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_LockEnemyCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_LockEnemyCS));
	}
}
