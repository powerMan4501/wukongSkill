using System;
using b1.BGW;
using b1.GSMUI.Core;
using B1UI.GSUI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropSpecialTipsCS")]
public class BI_DropSpecialTipsCS : BUI_Widget
{
	private BGW_UIMgr UIMgr;

	private EnShowState ShowState;

	private UTextBlock TxtTips;

	private float ShowTime;

	private float ShowTimeCheck;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		ShowTime = uIConfigDataAsset.DropSpecialTipsShowTime;
		ShowTimeCheck = ShowTime;
		TxtTips = FindChildWidget("TxtTips") as UTextBlock;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickUpdateContent(InDeltaTime);
	}

	private void TickUpdateContent(float DeltaTime)
	{
		if (ShowState == EnShowState.Show)
		{
			ShowTimeCheck -= DeltaTime;
			if (ShowTimeCheck <= 0f)
			{
				DoShowOut();
			}
		}
	}

	public void DoShowIn(EDropSpecialTipsType DropSpecialTipsType)
	{
		ShowTimeCheck = ShowTime;
		switch (ShowState)
		{
		case EnShowState.Min:
		case EnShowState.HideComplete:
			DoShowIn();
			break;
		case EnShowState.Hide:
			StopAllAnimations();
			DoShowIn();
			break;
		}
		TxtTips.SetText(GSMUIUtil.GetUIWordDescFText((EUIWordID)(1410 + DropSpecialTipsType)));
	}

	private void DoShowIn()
	{
		ShowState = EnShowState.Show;
		SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		PlayWidgetAnimationByInfoName("AnimShow");
	}

	private void DoShowOut()
	{
		if (ShowState != EnShowState.Show)
		{
			return;
		}
		ShowState = EnShowState.Hide;
		PlayWidgetAnimationByInfoName("AnimHide", 0f, 1f, 1, delegate
		{
			if (ShowState == EnShowState.Hide)
			{
				SetVisibility(ESlateVisibility.Collapsed);
				ShowState = EnShowState.HideComplete;
			}
		});
	}

	public void Reset()
	{
		StopAllAnimations();
		SetVisibility(ESlateVisibility.Collapsed);
		ShowState = EnShowState.HideComplete;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropSpecialTipsCS");
	}

	static BI_DropSpecialTipsCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropSpecialTipsCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropSpecialTipsCS));
	}
}
