using System;
using b1.BGW;
using b1.GSMUICore.Event;
using b1.Plugins.GSInput;
using ResB1;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_DropAdvanceCS")]
public class BI_DropAdvanceCS : BUI_Widget
{
	protected enum DropAdvanceType
	{
		Min,
		Manual,
		MiddleItem
	}

	protected BGW_SettingMgrV2 SettingMgr;

	private BGW_UIMgr UIMgr;

	private UGSInputActionIcon InputIcon;

	protected DropAdvanceType ShowType;

	protected EnShowState ShowState;

	protected float ShowTime;

	protected float MinShowTime;

	protected float ShowTimeCheck;

	protected float FirstShowDelayTime;

	protected bool IsStartPress;

	protected float PressTimeCheck;

	protected float PressTime;

	protected bool IsInFunc;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		SettingMgr = BGW_SettingMgrV2.Get(this);
		UIMgr = BGW_UIMgr.Get(this);
		BGWUIConfigDataAsset uIConfigDataAsset = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset;
		FirstShowDelayTime = uIConfigDataAsset.DropFirstShowDelayTime;
		PressTime = uIConfigDataAsset.DropAdvanceJumpTime;
		InputIcon = FindChildWidget("InputIcon") as UGSInputActionIcon;
		BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSBattleActionEn.ManualJump, this, OnManualJumpPress, ETriggerEvent.Started);
		BGW_EnhancedInputMgrV2.Get(this).BindUIAction(GSBattleActionEn.ManualJump, this, OnManualJumpRelease, ETriggerEvent.Completed);
	}

	protected virtual bool OnManualJumpPress(FInputActionValue Value)
	{
		if (ShowState != EnShowState.Show)
		{
			return false;
		}
		IsStartPress = true;
		InputIcon.OpenPercentBg();
		InputIcon.BeginHold(PressTime);
		return true;
	}

	protected virtual bool OnManualJumpRelease(FInputActionValue Value)
	{
		IsStartPress = false;
		InputIcon.StopHold();
		return true;
	}

	public void DoShowIn()
	{
		ShowState = EnShowState.Show;
		UpdateContent();
		StopAllAnimations();
		SetRenderOpacity(1f);
		PlayWidgetAnimationByInfoName("AnimShow");
		IBGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(this);
		if (gameStateReadonlyData != null && gameStateReadonlyData.IsPlaying())
		{
			UIMgr.ShowPage(2);
		}
	}

	public void DoShowOut()
	{
		if (ShowState != EnShowState.Show)
		{
			return;
		}
		StopAllAnimations();
		ShowState = EnShowState.Hide;
		float inDelay = PlayWidgetAnimationByInfoName("AnimHide");
		GSMUIEventSequence gSMUIEventSequence = new GSMUIEventSequence();
		gSMUIEventSequence.AddEvent(new GSMUIDelayExec(inDelay, delegate
		{
			if (ShowState == EnShowState.Hide)
			{
				SetRenderOpacity(0f);
				ShowState = EnShowState.HideComplete;
			}
		}));
		AppendGSMUIEvent(gSMUIEventSequence);
		UpdateDropFill();
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickUpdateContent(InDeltaTime);
		TickJump(InDeltaTime);
	}

	private void TickUpdateContent(float DeltaTime)
	{
		if (IsStartPress)
		{
			return;
		}
		ShowTimeCheck -= DeltaTime;
		if (ShowState == EnShowState.Show && GetDataCount() > 0 && ShowTime - ShowTimeCheck >= MinShowTime)
		{
			ShowTimeCheck = 0f;
		}
		if (!(ShowTimeCheck <= 0f))
		{
			return;
		}
		if (ShowState != EnShowState.Show)
		{
			if (GetDataCount() != 0 && CanShow())
			{
				DoShowIn();
			}
		}
		else if (SettingMgr.GetCVBoolByType(UISettingConfigType.AdvanceDropManualClose) && ShowType == DropAdvanceType.MiddleItem && !IsInFunc)
		{
			ShowTimeCheck = ShowTime;
		}
		else
		{
			OnNext();
		}
	}

	protected void OnNext()
	{
		if (GetDataCount() > 0)
		{
			DoRefresh();
		}
		else
		{
			DoShowOut();
		}
	}

	private void TickJump(float DeltaTime)
	{
		if (ShowState == EnShowState.Show && (IsStartPress || !(PressTimeCheck <= 0f)))
		{
			if (IsStartPress)
			{
				PressTimeCheck += DeltaTime;
			}
			else
			{
				PressTimeCheck -= DeltaTime;
			}
			if (PressTimeCheck >= PressTime)
			{
				IsStartPress = false;
				PressTimeCheck = 0f;
				OnJump();
				ShowTimeCheck = 0f;
			}
		}
	}

	public virtual int GetDataCount()
	{
		return 0;
	}

	public virtual void CheckData()
	{
	}

	protected virtual void DoRefresh()
	{
		StopAllAnimations();
		ShowTimeCheck = ShowTime;
		float inDelay = PlayWidgetAnimationByInfoName("AnimIncreHide");
		GSMUIEventSequence gSMUIEventSequence = new GSMUIEventSequence();
		gSMUIEventSequence.AddEvent(new GSMUIDelayExec(inDelay, delegate
		{
			UpdateDropFill();
			UpdateContent();
			PlayWidgetAnimationByInfoName("AnimIncreShow");
		}));
		AppendGSMUIEvent(gSMUIEventSequence);
	}

	protected virtual bool CanShow()
	{
		IBGC_MovieData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_MovieData, BGC_MovieData>(this);
		if (gameStateReadonlyData != null && gameStateReadonlyData.IsPlaying())
		{
			return false;
		}
		return true;
	}

	protected virtual void UpdateContent()
	{
	}

	protected virtual void UpdateDropFill()
	{
	}

	protected virtual void OnJump()
	{
	}

	public void SetIsInFunc(bool IsIn)
	{
		IsInFunc = IsIn;
		UpdateFuncInfo();
	}

	protected virtual void UpdateFuncInfo()
	{
	}

	public virtual void Reset()
	{
		StopAllAnimations();
		SetRenderOpacity(0f);
		ShowState = EnShowState.HideComplete;
	}

	public void ResetJump()
	{
		IsStartPress = false;
		PressTimeCheck = 0f;
	}

	public bool GetIsShow()
	{
		if (ShowState != EnShowState.Show)
		{
			return ShowState == EnShowState.Hide;
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_DropAdvanceCS");
	}

	static BI_DropAdvanceCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_DropAdvanceCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_DropAdvanceCS));
	}
}
