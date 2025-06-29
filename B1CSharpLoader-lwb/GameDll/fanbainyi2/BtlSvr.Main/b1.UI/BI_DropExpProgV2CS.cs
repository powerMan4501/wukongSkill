using System;
using System.Collections.Generic;
using b1.BGW;
using b1.GSMUI.GSWidget;
using b1.GSMUICore.Event;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropExpProgV2CS")]
public class BI_DropExpProgV2CS : BUI_Widget
{
	private struct ExpChangeConfig
	{
		public int ExpChange;

		public bool IsIncrease;
	}

	private BGW_UIMgr UIMgr;

	private UCanvasPanel ExpCon;

	private IProcBar ProgBar;

	private UTextBlock TxtNumExp;

	private UTextBlock TxtNumLv;

	private UCanvasPanel SpCon;

	private UTextBlock TxtNumSp;

	private UTextBlock TxtNumSpChange;

	private UWidgetAnimation AnimShowHide;

	private UWidgetAnimation AnimExpChange;

	private UWidgetAnimation AnimExpNum;

	private UWidgetAnimation AnimUpgrade;

	private UWidgetAnimation AnimSpChange;

	private FWidgetAnimationDynamicEvent AnimSpChangeFinishEvent = new FWidgetAnimationDynamicEvent();

	private bool IsShow;

	private bool IsExpShow;

	private bool IsSpShow;

	private float ShowTime;

	private float MultiShowTime;

	private float ShowTimeCheck;

	private bool IsLevelUp;

	private int ExpNewValue;

	private int ExpOldValue;

	private int LastLevel;

	private int NextLevelExp;

	private List<ExpChangeConfig> ExpChangeList = new List<ExpChangeConfig>();

	private int TalenPointChangeNum;

	private int CurTalenPointNum;

	private bool IsLevelUpShowing;

	private GSMUIEventSequence LevelUpEvent = new GSMUIEventSequence();

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		ShowTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ExpShowTime;
		MultiShowTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ExpMultiShowTime;
		ExpCon = FindChildWidget("ExpRoot") as UCanvasPanel;
		ProgBar = FindAndConstructIProcBar("ProgBar");
		TxtNumExp = FindChildWidget("TxtNumExp") as UTextBlock;
		TxtNumLv = FindChildWidget("TxtLevel") as UTextBlock;
		SpCon = FindChildWidget("SpRoot") as UCanvasPanel;
		TxtNumSp = FindChildWidget("TxtSp") as UTextBlock;
		TxtNumSpChange = FindChildWidget("TxtSpChange") as UTextBlock;
		AnimShowHide = FindWidgetAnimation("AnimShowHide");
		AnimExpChange = FindWidgetAnimation("AnimExpChange");
		AnimExpNum = FindWidgetAnimation("AnimExpNum");
		AnimUpgrade = FindWidgetAnimation("AnimUpgrade");
		AnimSpChange = FindWidgetAnimation("AnimSpChange");
		AnimSpChangeFinishEvent.Bind(delegate
		{
			TalenPointChangeNum = 0;
		});
		BindToAnimationFinished(AnimSpChange, AnimSpChangeFinishEvent);
		Evt_OnUIAniSequence = (Action<UWidgetAnimation, string>)Delegate.Combine(Evt_OnUIAniSequence, new Action<UWidgetAnimation, string>(OnUIAniSequence));
	}

	protected void OnUIAniSequence(UWidgetAnimation Animation, string EventName)
	{
		switch (EventName)
		{
		case "UpdateLevel":
			TxtNumLv.SetText(FText.FromString($"{LastLevel}"));
			break;
		case "UpdatePercent":
			ProgBar.SetValue(0f, IsImmediately: true);
			ProgBar.SetMaxValue(NextLevelExp, IsImmediately: true);
			ProgBar.SetValue(ExpNewValue);
			ProgBar.SetMaxValue(NextLevelExp);
			TxtNumLv.SetText(FText.FromString($"{LastLevel}"));
			IsLevelUpShowing = false;
			break;
		case "UpdateSkillPoint":
			TxtNumSp.SetText(FText.FromString($"{CurTalenPointNum}"));
			UIMgr.PlayUISound("EVT_ui_chapter_award_talentponit_show");
			break;
		}
	}

	public void InitLastLevel(int _LastLevel)
	{
		LastLevel = _LastLevel;
	}

	private void DoShowIn()
	{
		if (!IsShow)
		{
			IsShow = true;
			SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			ShowTimeCheck = ShowTime;
			if (IsAnimationPlaying(AnimShowHide))
			{
				StopAnimation(AnimShowHide);
			}
			PlayWidgetAnimationByInfoName("AnimShow");
		}
	}

	private void DoShowOut()
	{
		if (IsShow)
		{
			IsShow = false;
			PlayWidgetAnimationByInfoName("AnimHide");
		}
	}

	private void DoShowInExp()
	{
		if (!IsExpShow)
		{
			IsExpShow = true;
			ShowTimeCheck = ShowTime;
			if (IsAnimationPlaying(AnimExpChange))
			{
				StopAnimation(AnimExpChange);
			}
			PlayWidgetAnimationByInfoName("AnimExpShow");
		}
	}

	private void DoShowOutExp()
	{
		if (IsExpShow)
		{
			IsExpShow = false;
			PlayWidgetAnimationByInfoName("AnimExpHide");
		}
	}

	public void OnExpChange(int OldValue, int NewValue, int CurLevel)
	{
		ExpOldValue = OldValue;
		ExpNewValue = NewValue;
		OnUpdateExpProg(CurLevel);
	}

	public void OnTalenPointChange(int OldValue, int NewValue, int CurTalenPoint)
	{
		if (IsAnimationPlaying(AnimSpChange))
		{
			StopAnimation(AnimSpChange);
		}
		CurTalenPointNum = CurTalenPoint;
		TalenPointChangeNum = NewValue - OldValue;
		TxtNumSp.SetText(FText.FromString($"{CurTalenPointNum - TalenPointChangeNum}"));
		OnUpdateSpChange(CurTalenPoint);
	}

	public void OnLevelChange()
	{
		IsLevelUp = true;
	}

	private void OnLevelChangeReal()
	{
		IsLevelUpShowing = true;
		if (IsAnimationPlaying(AnimUpgrade))
		{
			StopAnimation(AnimUpgrade);
		}
		PlayWidgetAnimation(AnimUpgrade);
	}

	private void OnUpdateExpProg(int CurLevel)
	{
		if (ExpNewValue == ExpOldValue || CurLevel >= GameDBRuntime.GetPlayerLevelMax())
		{
			return;
		}
		PlayerLevelDesc playerLevelDesc = GameDBRuntime.GetPlayerLevelDesc(CurLevel);
		if (playerLevelDesc == null)
		{
			return;
		}
		NextLevelExp = playerLevelDesc.NextLevelExp;
		ExpChangeConfig item = default(ExpChangeConfig);
		if (LastLevel != CurLevel)
		{
			int num = 0;
			for (int i = LastLevel; i < CurLevel; i++)
			{
				PlayerLevelDesc playerLevelDesc2 = GameDBRuntime.GetPlayerLevelDesc(i);
				if (playerLevelDesc2 == null)
				{
					return;
				}
				num += playerLevelDesc2.NextLevelExp;
			}
			item.ExpChange = num - ExpOldValue + ExpNewValue;
			item.IsIncrease = true;
			PlayerLevelDesc playerLevelDesc3 = GameDBRuntime.GetPlayerLevelDesc(LastLevel);
			if (playerLevelDesc3 != null)
			{
				ProgBar.SetValue(playerLevelDesc3.NextLevelExp);
				ProgBar.SetMaxValue(playerLevelDesc3.NextLevelExp);
			}
			TxtNumLv.SetText(FText.FromString($"{LastLevel}"));
		}
		else
		{
			item.ExpChange = ExpNewValue - ExpOldValue;
			item.IsIncrease = ExpNewValue > ExpOldValue;
			if (!IsLevelUpShowing)
			{
				ProgBar.SetValue(ExpNewValue);
				ProgBar.SetMaxValue(NextLevelExp);
				TxtNumLv.SetText(FText.FromString($"{CurLevel}"));
			}
		}
		LastLevel = CurLevel;
		ExpChangeList.Add(item);
		DoShowInExp();
		DoShowIn();
	}

	private void OnUpdateSpChange(int CurTalenPoint)
	{
		if (TalenPointChangeNum == 0)
		{
			return;
		}
		UIMgr.PlayUISound("EVT_ui_hud_hint_talentpoint_gain");
		TxtNumSpChange.SetText(FText.FromString($"{TalenPointChangeNum}"));
		if (!IsLevelUp)
		{
			if (IsAnimationPlaying(AnimSpChange))
			{
				StopAnimation(AnimSpChange);
			}
			PlayWidgetAnimation(AnimSpChange);
		}
		IsSpShow = true;
		DoShowIn();
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickExpChange(InDeltaTime);
		TickSpChange(InDeltaTime);
		TickShowOut();
		TickLevelUpChange();
	}

	private void TickLevelUpChange()
	{
		if (IsLevelUp)
		{
			IsLevelUp = false;
			OnLevelChangeReal();
		}
	}

	private void TickShowOut()
	{
		if (IsShow && !IsExpShow && !IsSpShow)
		{
			DoShowOut();
		}
	}

	private void TickSpChange(float DeltaTime)
	{
		if (IsSpShow && TalenPointChangeNum == 0)
		{
			IsSpShow = false;
		}
	}

	private void TickExpChange(float DeltaTime)
	{
		if (!IsExpShow)
		{
			return;
		}
		ShowTimeCheck += DeltaTime;
		if (ExpChangeList.Count == 0)
		{
			if (ShowTimeCheck >= ShowTime && !IsLevelUpShowing)
			{
				ShowTimeCheck = 0f;
				DoShowOutExp();
			}
		}
		else if (ShowTimeCheck >= MultiShowTime)
		{
			if (IsAnimationPlaying(AnimExpNum))
			{
				StopAnimation(AnimExpNum);
			}
			if (ExpChangeList[0].IsIncrease)
			{
				TxtNumExp.SetText(FText.FromString($"+{ExpChangeList[0].ExpChange}"));
				PlayWidgetAnimationByInfoName("AnimExpIncre");
				UIMgr.PlayUISound("EVT_ui_hud_hint_xp_gain");
			}
			else
			{
				TxtNumExp.SetText(FText.FromString($"{ExpChangeList[0].ExpChange}"));
				PlayWidgetAnimationByInfoName("AnimExpReduce");
			}
			ExpChangeList.RemoveAt(0);
			ShowTimeCheck = 0f;
		}
	}

	public void Reset()
	{
		StopAllAnimations();
		IsShow = false;
		IsExpShow = false;
		IsSpShow = false;
		IsLevelUp = false;
		IsLevelUpShowing = false;
		ProgBar.SetValue(ExpNewValue, IsImmediately: true);
		ProgBar.SetMaxValue(NextLevelExp, IsImmediately: true);
		SetVisibility(ESlateVisibility.Collapsed);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropExpProgV2CS");
	}

	static BI_DropExpProgV2CS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropExpProgV2CS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropExpProgV2CS));
	}
}
