using System;
using b1.EventDelDefine;
using B1UI.GSUI;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_PlayerStateItemCS")]
public class BI_PlayerStateItemCS : BUI_Widget
{
	public delegate void Del_ShowOut(BI_PlayerStateItemCS Item);

	private BGW_UIMgr UIMgr;

	private MDSBattleMain BattleMainData;

	private DS_IBPC_BattleMainInfoData BattleMainInfoData;

	private UWidgetAnimation AnimShow;

	private UWidgetAnimation AnimHide;

	private UWidgetAnimation AnimLoopTimelimit;

	private UWidgetAnimation AnimRefreshState;

	private UImage ImgIcon;

	private UMaterialInstanceDynamic MIIcon;

	private UMaterialInstanceDynamic MIFXShine;

	private bool Warnning;

	private bool IsHiding;

	private float ChekcHidingTime;

	private int ItemID;

	public Del_ShowOut Evt_ShowOut;

	private static bool WarningRemaining_IsValid;

	private static int WarningRemaining_Offset;

	[DisplayName("消失警告倒计时")]
	[UProperty]
	[EditDefaultsOnly]
	[BlueprintReadWrite]
	[Category("配置")]
	[USharpPath("/Script/b1-Managed.BI_PlayerStateItemCS:WarningRemaining")]
	public float WarningRemaining
	{
		get
		{
			CheckDestroyed();
			if (!WarningRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_PlayerStateItemCS:WarningRemaining");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WarningRemaining_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WarningRemaining_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BI_PlayerStateItemCS:WarningRemaining");
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
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr?.GetMDSBattleMain();
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		MIIcon = ImgIcon?.GetDynamicMaterial();
		UImage uImage = FindChildWidget("UIFX_Shine") as UImage;
		if (uImage != null)
		{
			MIFXShine = uImage.GetDynamicMaterial();
		}
		AnimShow = FindWidgetAnimation("AnimShow");
		AnimHide = FindWidgetAnimation("AnimHide");
		AnimLoopTimelimit = FindWidgetAnimation("AnimLoopTimelimit");
		AnimRefreshState = FindWidgetAnimation("AnimRefreshState");
		UpdateShowState("Hide", IsForce: true);
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_AddBuffNotify = (Del_AddBuffNotify)Delegate.Combine(actorEvt.Evt_AddBuffNotify, new Del_AddBuffNotify(OnAddBuffNotify));
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		DurationCheck(InDeltaTime);
		CheckHide(InDeltaTime);
	}

	private void DurationCheck(float DeltaTime)
	{
		if (ItemID == 0)
		{
			return;
		}
		float iconDuration = BattleMainInfoData.GetIconDuration(ItemID);
		if (iconDuration == -0.001f)
		{
			return;
		}
		if (MIIcon != null)
		{
			MIIcon.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_TimeLimit, iconDuration);
			MIIcon.GetScalarParameterValue(B1GlobalFNames.GSMIParameter_TimeLimit);
			if (iconDuration <= MIIcon.GetScalarParameterValue(B1GlobalFNames.GSMIParameter_StartTime))
			{
				BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			}
		}
		if (iconDuration <= 0f)
		{
			ShowOut();
		}
	}

	private void CheckHide(float DeltaTime)
	{
		if (IsHiding)
		{
			ChekcHidingTime -= DeltaTime;
			if (ChekcHidingTime <= 0f)
			{
				ChekcHidingTime = 0f;
				IsHiding = false;
				SetVisibility(ESlateVisibility.Collapsed);
				Evt_ShowOut(this);
			}
		}
	}

	public void UpdateContent(int ItemID)
	{
		this.ItemID = ItemID;
		int num = ItemID / 1000;
		int itemID = ItemID;
		switch (num)
		{
		case 1:
			itemID = ItemID / 10;
			MIIcon.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_BuffState, ItemID % 10);
			MIFXShine.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_BuffState, ItemID % 10);
			break;
		case 2:
			MIFXShine.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_DebuffType, ItemID % 10);
			break;
		}
		UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgIcon, GSUIResPathUtil.GetStateIconGPath(itemID));
	}

	public void UpdateShowState(string State, bool IsForce = false)
	{
		GSAnimKeyToState("AKBShowHide", State, IsForce);
	}

	public void ShowIn(int ItemID, bool IsForce = false)
	{
		BattleMainData.TriggerShowState(EnMainShowState.SHOW);
		UpdateContent(ItemID);
		SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		GSAnimKeyToState("AKBShowHide", "Show", IsForce);
		if (IsAnimationPlaying(AnimHide))
		{
			StopAnimation(AnimHide);
		}
		PlayAnimation(AnimShow);
		Warnning = false;
	}

	public void ShowOut()
	{
		GSAnimKeyToState("AKBShowHide", "Hide");
		if (IsAnimationPlaying(AnimShow))
		{
			StopAnimation(AnimShow);
		}
		StopAnimation(AnimLoopTimelimit);
		PlayAnimation(AnimHide);
		ItemID = 0;
		ChekcHidingTime = GetAKBBlendTime("AKBShowHide");
		IsHiding = true;
		Warnning = false;
	}

	public int GetItemID()
	{
		return ItemID;
	}

	public bool IsIdle()
	{
		if (ItemID == 0)
		{
			return !IsHiding;
		}
		return false;
	}

	private void OnAddBuffNotify(bool IsHasBuffBefore, AActor Caster, int BuffID, float BuffDuration)
	{
		if (ItemID != 0)
		{
			FUStBuffIconDesc buffIconDesc = BGW_GameDB.GetBuffIconDesc(BuffID);
			if (buffIconDesc != null && buffIconDesc.IconID == ItemID)
			{
				PlayAnimation(AnimRefreshState);
				BattleMainData.TriggerShowState(EnMainShowState.SHOW);
			}
		}
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		GSUIActorMgr.EvtClass actorEvt = B1GSUIActorMgr.Get(this).GetActorEvt(1);
		if (actorEvt != null)
		{
			actorEvt.Evt_AddBuffNotify = (Del_AddBuffNotify)Delegate.Remove(actorEvt.Evt_AddBuffNotify, new Del_AddBuffNotify(OnAddBuffNotify));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BI_PlayerStateItemCS");
		WarningRemaining_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WarningRemaining");
		WarningRemaining_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WarningRemaining", Classes.FFloatProperty);
	}

	static BI_PlayerStateItemCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_PlayerStateItemCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_PlayerStateItemCS));
	}
}
