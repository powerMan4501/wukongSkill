using System;
using b1.UI.Comm;
using B1UI.GSUI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_RideMountCS")]
public class BI_RideMountCS : BUI_StateWidget
{
	private UCanvasPanel RootCon;

	private UImage ImgIcon;

	private DS_IBPC_BattleMainInfoData BattleMainInfoData;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		BattleMainInfoData = B1GSUIActorMgr.Get(this).GetBattleData<DS_IBPC_BattleMainInfoData>(B1ActorTag.PlayerController);
		RootCon = FindChildWidget("Root") as UCanvasPanel;
		RootCon.SetVisibility(ESlateVisibility.Collapsed);
		SwitchState(WidgetUIStat.NorReady);
	}

	public void OnShowIn(int ItemID)
	{
		UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(this, ImgIcon, GSUIResPathUtil.GetItemIconGPath(ItemID));
		RootCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
	}

	public void OnShowState(bool IsShow)
	{
		if (IsShow)
		{
			SwitchState(WidgetUIStat.NorReady);
		}
		SetVisibility((!IsShow) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickInfo();
	}

	private void TickInfo()
	{
		if (BattleMainInfoData != null && BattleMainInfoData.GetCloudMoveInfo(out var CloudMoveInfo))
		{
			SetDisable(CloudMoveInfo.IsDisabled);
		}
	}

	public void SetDisable(bool IsDisable)
	{
		if (base.IsDisable != IsDisable)
		{
			if (IsDisable)
			{
				SwitchState(WidgetUIStat.NorReady);
				SwitchState(SwitchDisable: true);
			}
			else
			{
				SwitchState();
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_RideMountCS");
	}

	static BI_RideMountCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_RideMountCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_RideMountCS));
	}
}
