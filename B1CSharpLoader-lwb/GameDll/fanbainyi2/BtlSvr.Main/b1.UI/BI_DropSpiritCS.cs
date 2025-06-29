using System;
using b1.BGW;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropSpiritCS")]
public class BI_DropSpiritCS : BUI_Widget
{
	private readonly string AnimIncludeIn = "AnimIncludeIn";

	private BGW_UIMgr UIMgr;

	private UCanvasPanel SizeCon;

	private UImage ImgIcon;

	private UTextBlock TxtNum;

	private TweenTxtBlockValue TxtNumTween;

	private UTextBlock TxtIncNum;

	private TweenTxtBlockValue TxtIncNumTween;

	private UTextBlock TxtNew;

	private UWidgetAnimation AnimIncrease;

	private EnShowState ShowState;

	private bool IsHideAfterAnim;

	private bool IsShow;

	private float ShowTime;

	private float MinShowTime;

	private float ShowTimeCheck;

	private float AllIncreaseNum;

	private float StartNum;

	private bool IsAnimHideComplete;

	private int CurItemID;

	private bool IsInFunc;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		if (IsInFunc)
		{
			ShowTime = uIConfigDataAsset.DropInFuncShowTime;
		}
		else
		{
			ShowTime = uIConfigDataAsset.DropShowTime;
		}
		MinShowTime = uIConfigDataAsset.DropMinShowTime;
		SizeCon = FindChildWidget("ResizeCon") as UCanvasPanel;
		ImgIcon = FindChildWidget("ImgIcon") as UImage;
		TxtNum = FindChildWidget("TxtNum") as UTextBlock;
		TxtNumTween = new TweenTxtBlockValue(TxtNum);
		TxtIncNum = FindChildWidget("TxtIncre") as UTextBlock;
		TxtIncNumTween = new TweenTxtBlockValue(TxtIncNum, EEasingFunc.EaseOut, "×");
		TxtNew = FindChildWidget("TxtNew") as UTextBlock;
		AnimIncrease = FindWidgetAnimation("AnimIncrease");
		ShowState = EnShowState.Min;
		Evt_OnUIAniSequence = (Action<UWidgetAnimation, string>)Delegate.Combine(Evt_OnUIAniSequence, new Action<UWidgetAnimation, string>(OnUIAniSequence));
	}

	protected void OnUIAniSequence(UWidgetAnimation Animation, string EventName)
	{
		if (EventName == "UpdateIncreNum")
		{
			TxtIncNumTween.ChangeToValue(-1f, AllIncreaseNum, -1f);
			AppendGSMUIEvent(TxtIncNumTween);
		}
		else if (EventName == "UpdateTotalNum")
		{
			TxtNumTween.ChangeToValue(-1f, StartNum + AllIncreaseNum, -1f);
			AppendGSMUIEvent(TxtNumTween);
		}
	}

	public void SetHideAfterAnim(bool IsHide)
	{
		IsHideAfterAnim = IsHide;
	}

	public void DoShowIn()
	{
		StopAllAnimations();
		SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		PlayWidgetAnimationByInfoName("AnimShow");
	}

	public void DoShowOut()
	{
		ShowState = EnShowState.Hide;
		StopAnimationByInfo("AnimShow");
		PlayWidgetAnimationByInfoName("AnimHide", 0f, 1f, 1, delegate
		{
			AllIncreaseNum = 0f;
			if (ShowState == EnShowState.Hide && IsHideAfterAnim)
			{
				SetVisibility(ESlateVisibility.Collapsed);
			}
			ShowState = EnShowState.HideComplete;
		});
		CurItemID = 0;
	}

	public void SetIsInFunc(bool IsIn)
	{
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		IsInFunc = IsIn;
		if (IsIn)
		{
			ShowTime = uIConfigDataAsset.DropInFuncShowTime;
		}
		else
		{
			ShowTime = uIConfigDataAsset.DropShowTime;
		}
	}

	public void Reset()
	{
		AllIncreaseNum = 0f;
		ShowState = EnShowState.HideComplete;
		SetVisibility(ESlateVisibility.Collapsed);
		CurItemID = 0;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (ShowState == EnShowState.Show)
		{
			ShowTimeCheck -= InDeltaTime;
			if (ShowTimeCheck <= 0f)
			{
				DoShowOut();
			}
		}
	}

	public void UpdateContent(ItemOne ItemData, int StartNum)
	{
		if (GameDBRuntime.GetItemDesc(ItemData.Id) == null)
		{
			return;
		}
		if (ShowState != EnShowState.Show)
		{
			AllIncreaseNum = 0f;
		}
		CurItemID = ItemData.Id;
		AllIncreaseNum += ItemData.Num;
		UIMgr.PlayUISound("EVT_ui_hud_hint_lingyun_drop");
		if (ShowState != EnShowState.Show)
		{
			this.StartNum = StartNum;
			TxtNumTween.ChangeToValue(-1f, StartNum, -1f, IsForce: true);
			TxtIncNumTween.ChangeToValue(-1f, AllIncreaseNum, -1f, IsForce: true);
			TxtNew.SetRenderOpacity(0f);
			DoShowIn();
		}
		else
		{
			TxtIncNumTween.ChangeToValue(-1f, AllIncreaseNum - (float)ItemData.Num, -1f);
			AppendGSMUIEvent(TxtIncNumTween);
			TxtNew.SetText(FText.FromString($"+{ItemData.Num}"));
			if (IsAnimationPlaying(AnimIncrease))
			{
				StopAnimation(AnimIncrease);
			}
			PlayWidgetAnimation(AnimIncrease);
		}
		ShowTimeCheck = ShowTime;
		ShowState = EnShowState.Show;
	}

	public bool GetIsShow()
	{
		if (ShowState != EnShowState.Show)
		{
			return ShowState == EnShowState.Hide;
		}
		return true;
	}

	public void SetMinShowTime()
	{
		if (ShowTimeCheck > MinShowTime)
		{
			ShowTimeCheck = MinShowTime;
		}
	}

	public float GetItemHeight()
	{
		return (SizeCon.Slot as UCanvasPanelSlot).GetSize().Y;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropSpiritCS");
	}

	static BI_DropSpiritCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropSpiritCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropSpiritCS));
	}
}
