using System;
using System.Collections.Generic;
using b1.BGW;
using b1.GSMUICore.Event;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropExpProgCS")]
public class BI_DropExpProgCS : BUI_Widget
{
	private struct ExpChangeConfig
	{
		public int ExpChange;

		public bool IsIncrease;
	}

	private BGW_UIMgr UIMgr;

	private UCanvasPanel ExpCon;

	private BI_ProgBarCS ExpProgBar;

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

	private bool IsLevelUpShowing;

	private GSMUIEventSequence LevelUpEvent = new GSMUIEventSequence();

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		ShowTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ExpShowTime;
		MultiShowTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ExpMultiShowTime;
		ExpCon = FindChildWidget("ExpRoot") as UCanvasPanel;
		ExpProgBar = FindChildWidget("BI_ProgBar") as BI_ProgBarCS;
		DSProgBarInfo inDataStore = new DSProgBarInfo(this);
		ExpProgBar.InitDataStore(inDataStore);
		ExpProgBar.SetProgress(0f, 1f);
		TxtNumExp = FindChildWidget("TxtNumExp") as UTextBlock;
		TxtNumLv = FindChildWidget("TxtLevl") as UTextBlock;
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
		TalenPointChangeNum = NewValue - OldValue;
		OnUpdateSpChange(CurTalenPoint);
	}

	public void OnLevelChange()
	{
		IsLevelUp = true;
	}

	private void OnLevelChangeReal()
	{
		IsLevelUpShowing = true;
		ClearGSMUIEvent(LevelUpEvent);
		LevelUpEvent.Clear();
		LevelUpEvent.AddEvent(new GSMUIDelayExec(0.2f, delegate
		{
			if (IsAnimationPlaying(AnimUpgrade))
			{
				StopAnimation(AnimUpgrade);
			}
			PlayWidgetAnimation(AnimUpgrade);
		}));
		LevelUpEvent.AddEvent(new GSMUITweenSetMatParam_Scalar(ExpProgBar.GetMainMI(), B1GlobalFNames.Percent, 1f, 0f, 1.25f, 1.25f));
		LevelUpEvent.AddEvent(new GSMUIDelayExec(0.01f, delegate
		{
			ExpProgBar.SetProgress(0f, NextLevelExp, IsImmediately: true);
			ExpProgBar.SetProgress(ExpNewValue, NextLevelExp);
			TxtNumLv.SetText(FText.FromString($"{LastLevel}"));
			IsLevelUpShowing = false;
		}));
		AppendGSMUIEvent(LevelUpEvent);
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
				ExpProgBar.SetProgress(playerLevelDesc3.NextLevelExp, playerLevelDesc3.NextLevelExp);
			}
			TxtNumLv.SetText(FText.FromString($"{LastLevel}"));
		}
		else
		{
			item.ExpChange = ExpNewValue - ExpOldValue;
			item.IsIncrease = ExpNewValue > ExpOldValue;
			ExpProgBar.SetProgress(ExpNewValue, NextLevelExp);
			TxtNumLv.SetText(FText.FromString($"{CurLevel}"));
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
		TxtNumSp.SetText(FText.FromString($"{CurTalenPoint}"));
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
		ClearGSMUIEvent(LevelUpEvent);
		LevelUpEvent.Clear();
		ExpProgBar.SetProgress(ExpNewValue, NextLevelExp, IsImmediately: true);
		SetVisibility(ESlateVisibility.Collapsed);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropExpProgCS");
	}

	static BI_DropExpProgCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropExpProgCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropExpProgCS));
	}
}
