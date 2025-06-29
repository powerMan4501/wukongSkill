using System;
using System.Collections.Generic;
using b1.BGW;
using b1.GSMUICore.Event;
using b1.Plugins.NiagaraUIRenderer;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropMuseumCS")]
public class BI_DropMuseumCS : BUI_Widget
{
	private BGW_UIMgr UIMgr;

	private UWidgetAnimation AnimRefresh;

	private UNiagaraSystemWidget NSDrop;

	private bool IsShow;

	private bool IsHideComplete = true;

	private float ShowTime;

	private float ShowTimeCheck;

	private List<int> MuseumList = new List<int>();

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		ShowTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.DropMuseumShowTime;
		ShowTimeCheck = ShowTime;
		AnimRefresh = FindWidgetAnimation("AnimRefresh");
		NSDrop = FindChildWidget("UNISDrop") as UNiagaraSystemWidget;
		NSDrop.DeactivateSystem();
	}

	public void DoShowIn()
	{
		IsHideComplete = false;
		StopAllAnimations();
		SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		SetRenderOpacity(1f);
		NSDrop.ActivateSystem(Reset: true);
		PlayWidgetAnimationByInfoName("AnimShow");
		IBGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(this);
		if (gameStateReadonlyData != null && gameStateReadonlyData.IsPlaying())
		{
			UIMgr.ShowPage(2);
		}
		UIMgr.PlayUISound("UI_Drop_Popup_Show");
		UpdateContent();
	}

	public void DoShowOut()
	{
		float inDelay = PlayWidgetAnimationByInfoName("AnimHide");
		UIMgr.PlayUISound("UI_Drop_Popup_Close");
		GSMUIEventSequence gSMUIEventSequence = new GSMUIEventSequence();
		gSMUIEventSequence.AddEvent(new GSMUIDelayExec(inDelay, delegate
		{
			if (!IsShow)
			{
				NSDrop.DeactivateSystem();
				SetVisibility(ESlateVisibility.Collapsed);
				IsHideComplete = true;
			}
		}));
		AppendGSMUIEvent(gSMUIEventSequence);
	}

	public void DoRefresh()
	{
		PlayWidgetAnimation(AnimRefresh);
		GSMUIEventSequence gSMUIEventSequence = new GSMUIEventSequence();
		gSMUIEventSequence.AddEvent(new GSMUIDelayExec(0.001f, delegate
		{
			UpdateContent();
		}));
		AppendGSMUIEvent(gSMUIEventSequence);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickShow(InDeltaTime);
	}

	private void TickShow(float DeltaTime)
	{
		if (IsShow && IsShow)
		{
			ShowTimeCheck -= DeltaTime;
			if (ShowTimeCheck <= 0f)
			{
				TickRefresh();
			}
		}
	}

	private void TickRefresh()
	{
		ShowTimeCheck = ShowTime;
		if (MuseumList.Count > 0)
		{
			DoRefresh();
			return;
		}
		IsShow = false;
		DoShowOut();
	}

	public void AddMuseum(int MuseumID)
	{
		if (!MuseumList.Contains(MuseumID))
		{
			MuseumList.Add(MuseumID);
			if (MuseumList.Count > 0 && !IsShow)
			{
				DoShowIn();
				IsShow = true;
			}
		}
	}

	public void UpdateContent()
	{
		if (MuseumList.Count != 0)
		{
			MuseumList.RemoveAt(0);
			ShowTimeCheck = ShowTime;
		}
	}

	public bool GetIsShow()
	{
		return IsShow;
	}

	public bool GetIsHideComplete()
	{
		return IsHideComplete;
	}

	public bool GetCanTick()
	{
		return !IsHideComplete;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropMuseumCS");
	}

	static BI_DropMuseumCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropMuseumCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropMuseumCS));
	}
}
