using System;
using System.Collections.Generic;
using b1.BGW;
using b1.Localization;
using b1.Plugins.GSInput;
using ResB1;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI;

[UClass]
[USharpPath("/Script/b1-Managed.BI_ShortcutCommCS")]
public class BI_ShortcutCommCS : BUI_Widget
{
	public readonly float MaxShortcutNum = 4f;

	protected BGW_UIMgr UIMgr;

	protected MDSBattleMain BattleMainData;

	protected UCanvasPanel KeyboardMouseCon;

	protected UCanvasPanel GamepadCon;

	protected List<BI_ShortcutDescCS> DescList = new List<BI_ShortcutDescCS>();

	protected Dictionary<int, UTextBlock> TxtNameDic = new Dictionary<int, UTextBlock>();

	protected EnShortcutActiveState ActiveState;

	private float ActiveDelayTimeCheck;

	private float ActiveADelayTime;

	private float ActiveBDelayTime;

	private bool IsShowEffectDesc;

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		UIMgr = BGW_UIMgr.Get(this);
		BattleMainData = UIMgr.GetMDSBattleMain();
		ActiveADelayTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ShortcutActiveDelayTime;
		ActiveBDelayTime = BGW_PreloadAssetMgr.Get(this).UIConfigDataAsset.ShortcutDetailActiveDelayTime;
		KeyboardMouseCon = FindChildWidget("Keyboard") as UCanvasPanel;
		KeyboardMouseCon.SetRenderOpacity(0f);
		KeyboardMouseCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		GamepadCon = FindChildWidget("Gamepad") as UCanvasPanel;
		GamepadCon.SetRenderOpacity(0f);
		GamepadCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		GSBindDelegateToOnAKBStateEnd("GSAKBActiveState", OnStateChange);
		for (int i = 0; i < 4; i++)
		{
			BI_ShortcutDescCS bI_ShortcutDescCS = FindChildWidget($"Desc_{i + 1}") as BI_ShortcutDescCS;
			if (bI_ShortcutDescCS != null)
			{
				DescList.Add(bI_ShortcutDescCS);
			}
		}
		OnSwitchInput(BGW_EnhancedInputMgrV2.GetCurrentInputType());
		GSAnimKeyToState("GSAKBActiveState", "Normal", IsForce: true);
		GSAnimKeyToState("AKBDescState", "Hide", IsForce: true);
	}

	private void OnStateChange(FName BeginStateName, FName EndStateName, bool IsFromForceSetStateImmediately)
	{
		if (EndStateName == B1GlobalFNames.Normal)
		{
			GSAnimKeyToState("GSAKBActiveState", "NormalFinish", IsForce: true);
		}
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		TickActive(InDeltaTime);
		TickActiving(InDeltaTime);
	}

	private void TickActive(float DeltaTiem)
	{
		if (ActiveState >= EnShortcutActiveState.ActiveDelay)
		{
			ActiveDelayTimeCheck += DeltaTiem;
			if (ActiveDelayTimeCheck >= ActiveADelayTime)
			{
				OnActiveA();
			}
			if (ActiveDelayTimeCheck >= ActiveBDelayTime)
			{
				OnActiveB();
			}
		}
	}

	private void TickActiving(float DeltaTiem)
	{
		if (ActiveState >= EnShortcutActiveState.ActiveA)
		{
			BattleMainData.TriggerShowState(EnMainShowState.SHOW);
		}
	}

	public void OnTriggerActive(bool IsActive)
	{
		if (IsActive)
		{
			BGW_SettingMgrV2 bGW_SettingMgrV = BGW_SettingMgrV2.Get(this);
			IsShowEffectDesc = bGW_SettingMgrV.GetCVBoolByType(UISettingConfigType.GamepadEffectDesc);
			OnActive();
		}
		else
		{
			OnNormal();
		}
	}

	private void OnActive()
	{
		if (ActiveState <= EnShortcutActiveState.ActiveDelay)
		{
			ActiveDelayTimeCheck = 0f;
			ActiveState = EnShortcutActiveState.ActiveDelay;
		}
	}

	protected virtual void OnActiveA()
	{
		if (ActiveState < EnShortcutActiveState.ActiveA)
		{
			ActiveState = EnShortcutActiveState.ActiveA;
			GSAnimKeyToState("GSAKBActiveState", "Actived");
		}
	}

	private void OnActiveB()
	{
		if (IsShowEffectDesc && ActiveState < EnShortcutActiveState.ActiveB)
		{
			ActiveState = EnShortcutActiveState.ActiveB;
			GSAnimKeyToState("AKBDescState", "Show");
		}
	}

	private void OnNormal()
	{
		if (ActiveState < EnShortcutActiveState.ActiveA)
		{
			ActiveState = EnShortcutActiveState.Normal;
			return;
		}
		ActiveState = EnShortcutActiveState.Normal;
		GSAnimKeyToState("GSAKBActiveState", "Normal");
		GSAnimKeyToState("AKBDescState", "Hide");
	}

	public void UpdateDesc(int PosIdx, int ItemID)
	{
		UpdateName(PosIdx, ItemID);
		if (PosIdx >= 0 && PosIdx < DescList.Count)
		{
			DescList[PosIdx].UpdateDesc(ItemID);
		}
	}

	public void UpdateName(int PosIdx, int ItemID)
	{
		if (PosIdx >= 0 && PosIdx < TxtNameDic.Count)
		{
			ItemDesc itemDesc = GameDBRuntime.GetItemDesc(ItemID);
			if (itemDesc == null)
			{
				TxtNameDic[PosIdx].SetText(FText.GetEmpty());
			}
			else
			{
				TxtNameDic[PosIdx].SetText(itemDesc.Name.ToFTextRemoveRich());
			}
		}
	}

	protected override void OnSwitchInput(EGSInputType InputType)
	{
		switch (InputType)
		{
		case EGSInputType.KeyboardMouse:
			KeyboardMouseCon.SetRenderOpacity(1f);
			GamepadCon.SetRenderOpacity(0f);
			break;
		case EGSInputType.Gamepad:
			KeyboardMouseCon.SetRenderOpacity(0f);
			GamepadCon.SetRenderOpacity(1f);
			break;
		case EGSInputType.None:
		case EGSInputType.Touch:
		case EGSInputType.Other:
			break;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BI_ShortcutCommCS");
	}

	static BI_ShortcutCommCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BI_ShortcutCommCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BI_ShortcutCommCS));
	}
}
